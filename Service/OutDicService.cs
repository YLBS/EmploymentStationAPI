using Entity.Goodjob_Other;
using Iservice;
using Models;
using Microsoft.EntityFrameworkCore;
using Entity.Goodjob;

namespace Service
{
    public class OutDicService : IOutDicService
    {
        private readonly Goodjob_OtherContext _goodjobOtherContext;
        private readonly GoodjobContext _goodjobdb;
        public OutDicService(Goodjob_OtherContext goodjobOtherContext,GoodjobContext goodjobContext)
        {
            _goodjobOtherContext = goodjobOtherContext;
            _goodjobdb = goodjobContext;
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

        public async Task<List<OutDicModels>> GetDicJobFunctionBig()
        {
            var getList = await _goodjobOtherContext.Set<DicJobFunctionsBig> ().OrderBy(o => o.OrderId).Select(o => new OutDicModels
            {
                Name = o.Pname,
                Id = o.Id,
            }).ToListAsync();

            return getList;
        }

        public async Task<List<OutDicTown>> GetDicTown()
        {
            var getList = await (from a in _goodjobOtherContext.Set<DicProvince>()
                                 join b in _goodjobOtherContext.Set<DicCity>() on a.Id equals b.ProvinceId into tableGroup1
                                 from b in tableGroup1.DefaultIfEmpty()
                                 join c in _goodjobOtherContext.Set<DicTown>() on b.Id equals c.CityId into tableGroup2
                                 from c in tableGroup2.DefaultIfEmpty()
                                 where (a.Pname == "广东")
                                 select new
                                 {
                                     IsShow = b.IsShow,
                                     ProvinceId = a.Id,
                                     ProvinceName = a.Pname,
                                     CityId = b.Id,
                                     CityName = b.Pname,
                                     TownId = c.Id == null ? 0 : c.Id,
                                     TownName = c.Pname == null ? "" : c.Pname,
                                 }).ToListAsync();
            List<OutDicTown> outDicTown = new List<OutDicTown>();
            //省
            var bigList = getList.Select(o => new OutDicTown
            {
                Id = o.ProvinceId,
                Name = o.ProvinceName,
            }).GroupBy(o => new { o.Id, o.Name }).ToList();
            foreach (var item in bigList)
            {
                //市
                var smalList = getList.Where(o => o.ProvinceName == item.First().Name && o.ProvinceId == item.First().Id && o.IsShow==0 && o.CityId== 724).
                    Select(o => new OutBigDicJobDto
                    {
                        Id = o.CityId,
                        Name = o.CityName,
                    }).GroupBy(o => new { o.Id, o.Name }).ToList();
                foreach (var item2 in smalList)
                {
                    //区
                    var smalList1 = getList.Where(o => o.IsShow == item2.First().Id && o.IsShow != 0).
                        Select(o => new SmalJobDto
                        {
                            Id = o.CityId,
                            Name = o.CityName,
                        }).GroupBy(o => new { o.Id, o.Name }).ToList();
                    foreach (var item3 in smalList1)
                    {
                        //镇
                        var smalList3 = getList.Where(o => o.CityId == item3.First().Id && o.TownId != 0).
                            Select(o => new OutDicModels
                            {
                                Id = o.TownId,
                                Name = o.TownName,
                            }).GroupBy(o => new { o.Id, o.Name }).ToList();
                        foreach (var item4 in smalList3)
                        {
                            if(item3.First().JobList == null)
                                item3.First().JobList = new List<OutDicModels>();
                            item3.First().JobList.Add(item4.First());
                        }
                        if (item2.First().JobList == null)
                            item2.First().JobList = new List<SmalJobDto>();
                        item2.First().JobList.Add(item3.First());
                    }
                    if (item.First().JobList == null)
                        item.First().JobList = new List<OutBigDicJobDto>();
                    item.First().JobList.Add(item2.First());
                }

                outDicTown.Add(item.First());
            }
            return outDicTown;
        }

        public async Task<List<OutDicModels>> GetDicSalaryNew()
        {
            var getList = await _goodjobOtherContext.Set<DicSalary>().Where(o=>o.Id!=1).OrderBy(o => o.OrderId).Select(o =>
                new OutDicModels
                {
                    Name = o.Id == 20 ? "面谈" : o.Name,
                    Id = o.Id,
                }).ToListAsync();
            return getList;
        }
        public async Task<List<OutDicModels>> GetPosLable()
        {
            var result = _goodjobdb.MemPosLabels.Select(o => new OutDicModels
            {
                Id = o.Id,
                Name = o.Name,
            }).ToList();
            return result;
        }
    }
}
