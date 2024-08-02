using AutoMapper;
using Entity.Base;
using Iservice;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ServiceStack;

namespace Service
{
    public class NewsInfoService : INewsInfoService
    {
        private readonly BaseDbContext _basedb;
        private readonly IMapper _mapper;
        public NewsInfoService(BaseDbContext basedb,IMapper mapper)
        {
            _basedb = basedb;
            _mapper = mapper;
        }

        public async Task<ResultModel> AddBaseNewsInfo(InputBaseNewsInfoDto infoDto)
        {
            ResultModel resultModel = new ResultModel();
            var entity = _mapper.Map<BaseNewsInfoEntity>(infoDto);
            entity.UserId = 1;
            await _basedb.AddAsync(entity);
            if (await _basedb.SaveChangesAsync() > 0)
            {
                resultModel.Result = true;
                resultModel.Message = "新增成功";
            }
            else
            {
                resultModel.Result = false;
                resultModel.Message = "添加失败";
            }
            return resultModel;
        }


        public async Task<OutBaseNewsInfoDto> GetBaseNewsInfo(int id)
        {
            var data= await _basedb.BaseNewsInfos.Where(n=>n.NewsId==id).FirstOrDefaultAsync();
            var entity = _mapper.Map<OutBaseNewsInfoDto>(data);
            return entity;
        }

        public async Task<(List<OutBaseNewsInfoDto>, int Count)> GetBaseNewsInfos(BaseFilterModel baseFilter)
        {
            int count = await _basedb.BaseNewsInfos
                .Where(n => string.IsNullOrEmpty(baseFilter.Name) ? true : n.Title.Contains(baseFilter.Name))
                .CountAsync();
            var data = await _basedb.BaseNewsInfos
                .Where(n => string.IsNullOrEmpty(baseFilter.Name) ? true : n.Title.Contains(baseFilter.Name))
                .OrderByDescending(n=>n.UpdateDate)
                .Skip((baseFilter.PageIndex - 1) * baseFilter.PageSize).Take(baseFilter.PageSize).ToListAsync();
            var dt = _mapper.Map<List<OutBaseNewsInfoDto>>(data);
            return (dt,count);
        }

        public async Task<ResultModel> UpBaseNewsInfo(OutBaseNewsInfoDto infoDto)
        {
            ResultModel resultModel = new ResultModel();
            var data= await _basedb.Set<BaseNewsInfoEntity>().Where(n => n.NewsId == infoDto.NewsId).FirstOrDefaultAsync();
            if (data != null)
            {
                _mapper.Map(infoDto, data);

                //var entity = _mapper.Map<BaseNewsInfoEntity>(infoDto);
                //entity.EditDate = data.EditDate;
                //data = entity;
                data.UpdateDate = DateTime.Now;
                int i = await _basedb.SaveChangesAsync();
                if (i > 0)
                {
                    resultModel.Result = true;
                    resultModel.Message = "修改成功";
                }
                else
                {
                    resultModel.Result = false;
                    resultModel.Message = "修改失败";
                }
                return resultModel;
            }
            resultModel.Result = false;
            resultModel.Message = "没有找到该文章，无法修改";
            return resultModel;
        }


        public async Task<ResultModel> DelBaseNewsInfo(int id)
        {
            ResultModel resultModel = new ResultModel();
            var data = await _basedb.BaseNewsInfos.Where(n => n.NewsId == id).FirstOrDefaultAsync();

            if (data == null)
            {
                resultModel.Result = false;
                resultModel.Message = "删除失败，没有找到文章";
                return resultModel;
            }
            _basedb.Remove(data);
            if (await _basedb.SaveChangesAsync() > 0)
            {
                resultModel.Result = true;
                resultModel.Message = "删除成功";
                return resultModel;
            }
            resultModel.Result = false;
            resultModel.Message = "删除失败";
            return resultModel;
        }

    }
}
