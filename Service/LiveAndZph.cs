﻿using Entity.Goodjob;
using Entity.Sitedata;
using Iservice;
using Models;
using Models.LiveAndZph;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

namespace Service
{
    public class LiveAndZph : ILiveAndZph
    {
        private readonly GoodjobContext _goodjobdb;
        private readonly sitedataContext _sitedatadb;
        private readonly IMapper _mapper;
        public LiveAndZph(GoodjobContext goodjobdb, sitedataContext sitedatadb, IMapper mapper)
        {
            _goodjobdb = goodjobdb;
            _sitedatadb = sitedatadb;
            _mapper = mapper;
        }

        public async Task<(List<OutMngLiveDto> liveDtos,int Count)> GetOutMngLivesList(BaseFilterModels baseFilter)
        {
            int count = await _goodjobdb.MngLives
                .Where(n => string.IsNullOrEmpty(baseFilter.Name) ? true : n.Title.Contains(baseFilter.Name))
                .CountAsync();
            if (count != 0)
            {
                var data = await _goodjobdb.MngLives
                    .Where(n => string.IsNullOrEmpty(baseFilter.Name) ? true : n.Title.Contains(baseFilter.Name))
                    .Skip((baseFilter.PageIndex - 1) * baseFilter.PageSize).Take(baseFilter.PageSize).ToListAsync();
                var dt = _mapper.Map<List<OutMngLiveDto>>(data);
                return (dt, count);
            }

            return (new List<OutMngLiveDto>(), 0);



            //var list = await _goodjobdb.Set<MngLiveEntity>()
            //    .Where(m => m.Esid == baseFilter.Id && string.IsNullOrEmpty(baseFilter.Name)? true : m.Title.Contains(baseFilter.Name)).Select(o => new OutMngLiveDto
            //        {
            //            Id = o.Id,
            //            Title = o.Title,
            //            LiveUrl = o.LiveUrl,
            //            LiveUrl2 = o.LiveUrl2,
            //            WxImage = o.WxImage,
            //            WxTitle = o.WxTitle,
            //            ZphId = o.ZphId,
            //            LiveUrl1 = o.LiveUrl1,
            //            Description = o.Description,
            //            PushShowWay = o.PushShowWay,
            //            PreviewImg = o.PreviewImg,
            //            OpenBarrage = o.OpenBarrage,
            //            OpenMassage = o.OpenMassage,
            //            PlayBackUrl = o.PlayBackUrl,
            //            Esid = o.Esid
            //        }).Skip((baseFilter.PageIndex-1)* baseFilter.PageSize).Take(baseFilter.PageSize).ToListAsync();
            //var i = await _goodjobdb.Set<MngLiveEntity>().Where(m => m.Esid == baseFilter.Id && string.IsNullOrEmpty(baseFilter.Name)
            //    ? true : m.Title.Contains(baseFilter.Name)).CountAsync();
            //return (list,i);
        }

        public async Task<(List<OutZhaoPinHuiDto> liveDtos, int Count)> GetOutZhpList(BaseFilterModels baseFilter)
        {
            int count = await _sitedatadb.ZhaoPinHuis
                .Where(m => m.Esid == baseFilter.Id && string.IsNullOrEmpty(baseFilter.Name) ? true : m.Title.Contains(baseFilter.Name))
                .CountAsync();
            if (count != 0)
            {
                var data = await _sitedatadb.ZhaoPinHuis
                    .Where(m => m.Esid == baseFilter.Id && string.IsNullOrEmpty(baseFilter.Name) ? true : m.Title.Contains(baseFilter.Name))
                    .Skip((baseFilter.PageIndex - 1) * baseFilter.PageSize).Take(baseFilter.PageSize).ToListAsync();
                var dt = _mapper.Map<List<OutZhaoPinHuiDto>>(data);
                return (dt, count);
            }
            return (new List<OutZhaoPinHuiDto>(), 0);

            //var i = await _sitedatadb.Set<ZhaoPinHui>().Where(m => m.Esid == baseFilter.Id && string.IsNullOrEmpty(baseFilter.Name)
            //    ? true : m.Title.Contains(baseFilter.Name)).CountAsync();
            //if (i != 0)
            //{
            //    var list = await _sitedatadb.Set<ZhaoPinHui>().Where(m => m.Esid == baseFilter.Id && string.IsNullOrEmpty(baseFilter.Name)
            //        ? true : m.Title.Contains(baseFilter.Name)).Select(o => new OutZhaoPinHuiDto
            //        {
            //            Pid = o.Pid,
            //            Title=o.Title,
            //            BenigDate = o.BenigDate,
            //            EndDate = o.EndDate,
            //            AssistHostunit=o.AssistHostunit,
            //            UndertakeHostunit=o.UndertakeHostunit,
            //            Remark = o.Remark,
            //            ZphGroupName = o.ZphGroupName,
            //            StudentInstructionsPath = o.StudentInstructionsPath,
            //            MemInstructionsPath = o.MemInstructionsPath,
            //            Esid=o.Esid,
            //        }).Skip((baseFilter.PageIndex - 1) * baseFilter.PageSize).Take(baseFilter.PageSize).ToListAsync();
            //    return (list, i);
            //}

            //return (new List<OutZhaoPinHuiDto>(), i);
        }
    }
}
