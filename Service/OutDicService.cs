using Entity.Goodjob_Other;
using Iservice;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;
using Microsoft.EntityFrameworkCore.Internal;

namespace Service
{
    public class OutDicService : IOutDicService
    {
        private readonly Goodjob_OtherContext _goodjobOtherContext;
        public OutDicService(Goodjob_OtherContext goodjobOtherContext)
        {
            _goodjobOtherContext = goodjobOtherContext;
        }

        public async Task<List<OutDicModels>> GetDicDegree()
        {
            var getList = await _goodjobOtherContext.Set<DicDegree>().OrderBy(o=>o.OrderId).Select(o => new OutDicModels
            {
                Name=o.Pname,
                Id = o.Id,
            }).ToListAsync();
            OutDicModels outDic = new OutDicModels()
            {
                Name="无",
                Id = 0,
            };
            getList.Add(outDic);
            return getList;
        }

        public async Task<List<OutBigDicJobDto>> GetDicJobDto()
        {
            var getList = await (from a in _goodjobOtherContext.Set<DicJobFunction1>()
                                 join b in _goodjobOtherContext.Set<DicJobFunctionsBig>() on a.BigId equals b.Id into tableGroup1
                                 from b in tableGroup1.DefaultIfEmpty()
                                 join c in _goodjobOtherContext.Set<DicJobFunctionsSmal>() on a.SmalId equals c.Id into tableGroup2
                                 from c in tableGroup2.DefaultIfEmpty()
                                 where c != null
                                 select new
                                 {
                                     BigId = a.BigId,
                                     BigName = b.Pname,
                                     SmalId = a.SmalId,
                                     SmalName = c.Pname,
                                     Id = a.Id,
                                     Name = a.Pname
                                 }).ToListAsync();

            List<OutBigDicJobDto> outDic1 = new List<OutBigDicJobDto>();
            var bigList = getList.Select(o => new OutBigDicJobDto
            {
                Id = o.BigId,
                Name = o.BigName,
            }).GroupBy(o => new { o.Id, o.Name }).ToList();

            foreach (var item in bigList)
            {

                var smalList = getList.Where(o => o.BigName == item.First().Name && o.BigId == item.First().Id).
                    Select(o => new SmalJobDto
                    {
                        Id = o.SmalId,
                        Name = o.SmalName,
                    }).GroupBy(o => new { o.Id, o.Name }).ToList();

                foreach (var item2 in smalList)
                {
                    if (item.First().JobList == null)
                        item.First().JobList = new List<SmalJobDto>();

                    //三级
                    var list = getList.Where(o => o.BigName == item.First().Name && o.BigId == item.First().Id && o.SmalId == item2.First().Id && o.SmalName == item2.First().Name).
                        Select(o => new OutDicModels
                        {
                            Id = o.Id,
                            Name = o.Name,
                        }).GroupBy(o => new { o.Id, o.Name }).ToList();
                    foreach (var item3 in list)
                    {
                        if (item2.First().JobList == null)
                            item2.First().JobList = new List<OutDicModels>();

                        item2.First().JobList.Add(item3.First());
                    }
                    item.First().JobList.Add(item2.First());
                }
                outDic1.Add(item.First());
            }

            return outDic1;
        }

        public async Task<List<SmalJobDto>> GetDicCity(bool option)
        {
            var getList = await (from a in _goodjobOtherContext.Set<DicProvince>()
                                 join b in _goodjobOtherContext.Set<DicCity>() on a.Id equals b.ProvinceId into tableGroup1
                                 from b in tableGroup1.DefaultIfEmpty()
                                 where(option ? true:b.IsShow!=0)
                                 select new
                                 {
                                     ProvinceId = a.Id,
                                     ProvinceName = a.Pname,
                                     CityId = b.Id,
                                     CityName = b.Pname,
                                 }).ToListAsync();
            List<SmalJobDto> outDic = new List<SmalJobDto>();
            var bigList = getList.Select(o => new SmalJobDto
            {
                Id = o.ProvinceId,
                Name = o.ProvinceName,
            }).GroupBy(o => new { o.Id, o.Name }).ToList();
            foreach (var item in bigList)
            {

                var smalList = getList.Where(o => o.ProvinceName == item.First().Name && o.ProvinceId == item.First().Id).
                    Select(o => new OutDicModels
                    {
                        Id = o.CityId,
                        Name = o.CityName,
                    }).GroupBy(o => new { o.Id, o.Name }).ToList();

                foreach (var item2 in smalList)
                {
                    if (item.First().JobList == null)
                        item.First().JobList = new List<OutDicModels>();
                    
                    item.First().JobList.Add(item2.First());
                }
                outDic.Add(item.First());
            }


            return outDic;
        }
    }
}
