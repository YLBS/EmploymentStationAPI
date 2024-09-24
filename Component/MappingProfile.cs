using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Entity.Base;
using Entity.Goodjob;
using Entity.Sitedata;
using Models;
using Models.LiveAndZph;

namespace Component
{

    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // 获取当前程序集中所有的类型
            //var types = Assembly.GetExecutingAssembly().GetTypes();
            // 查找所有匹配的 DTO 和实体类型
            //var typePairs = GetMatchingType(types);

            // 为每一对类型创建映射
            //foreach (var pair in typePairs)
            //{
            //    CreateMap(pair.Item1, pair.Item2);
            //}


            // 获取当前正在运行的应用程序域
            //Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
            //string assemblyName1 = "Models";
            //string assemblyName2 = "Entity";

            //// 遍历程序集，找到名称匹配的程序集
            //Assembly targetAssembly1 = assemblies.FirstOrDefault(asm => asm.FullName.Contains(assemblyName1));
            //Assembly targetAssembly2 = assemblies.FirstOrDefault(asm => asm.FullName.Contains(assemblyName2));
            //if (targetAssembly1 != null && targetAssembly2 != null)
            //{
            //    // 获取Models程序集中的所有类型
            //    Type[] types1 = targetAssembly1.GetTypes();
            //    Type[] types2 = targetAssembly2.GetTypes();
            //    var typePairs1 = GetMatchingTypes(types1, types2);
            //    foreach (var pair in typePairs1)
            //    {
            //        CreateMap(pair.Item1, pair.Item2);
            //    }
            //}

            //CreateMap<源，目标>;

            //查询
            CreateMap<MngLive, OutMngLiveDto>();
            CreateMap<ZhaoPinHuiEntity, OutZhaoPinHuiDto>();
            CreateMap<MemInfoJy, UpdateMemInfoJyDto>();
            CreateMap<BaseNewsInfoEntity, OutBaseNewsInfoDto>();


            //添加
            CreateMap<InputBaseNewsInfoDto, BaseNewsInfoEntity>();
            CreateMap<InputRegisterUnemploymentDto,MyResume>();

            //修改
            CreateMap<UpdateMemInfoJyDto, MemInfoJy>();
            CreateMap<OutBaseNewsInfoDto, BaseNewsInfoEntity>();


            //修改时，_mapper.Map(dto, 查询回来的目标);
        }

        private static List<Tuple<Type, Type>> GetMatchingType(Type[] types)
        {
            var matches = new List<Tuple<Type, Type>>();
            var dtoTypes = types.Where(t => t.Name.EndsWith("Dto") && t.Name.StartsWith("Input")).ToList();
            var entityTypes = types.Where(t => t.Name.EndsWith("Entity")).ToList();
            var ls = types.Select(t=>t.Name).ToList();

            foreach (var dtoType in dtoTypes)
            {
                var entityTypeName = dtoType.Name.Replace("Dto", "Entity").Replace("Input", "");
                var entityType = entityTypes.FirstOrDefault(t => t.Name == entityTypeName);
                if (entityType != null)
                {
                    matches.Add(new Tuple<Type, Type>(dtoType, entityType));
                }
            }

            return matches;
        }
        private static List<Tuple<Type, Type>> GetMatchingTypes(Type[] types1, Type[] types2)
        {
            var matches = new List<Tuple<Type, Type>>();
            var dtoTypes = types1.Where(t => t.Name.EndsWith("Dto") && t.Name.StartsWith("Input")).ToList();
            var entityTypes = types2.Where(t => t.Name.EndsWith("Entity")).ToList();
            //为添加时的Dto进行映射
            foreach (var dtoType in dtoTypes)
            {
                var entityTypeName = dtoType.Name.Replace("Dto", "Entity").Replace("Input", "");
                var entityType = entityTypes.FirstOrDefault(t => t.Name == entityTypeName);
                if (entityType != null)
                {
                    matches.Add(new Tuple<Type, Type>(dtoType, entityType));
                }
            }
            //为输出返回时的Dto进行映射
            var dtoTypes1 = types1.Where(t => t.Name.EndsWith("Dto") && t.Name.StartsWith("Out")).ToList();
            foreach (var dtoType in dtoTypes1)
            {
                var entityTypeName = dtoType.Name.Replace("Dto", "Entity").Replace("Out", "");
                var entityType = entityTypes.FirstOrDefault(t => t.Name == entityTypeName);
                if (entityType != null)
                {
                    matches.Add(new Tuple<Type, Type>(dtoType, entityType));//映射，用于修改
                    matches.Add(new Tuple<Type, Type>(entityType, dtoType));//反向映射，用于输出
                }
            }
            return matches;
        }
    }

    //public class MappingProfile : Profile
    //{
    //    public MappingProfile()
    //    {
    //        CreateMap<InputBaseNewsInfoDto, BaseNewsInfo>(); // 对于Dto中不存在的属性，可以指定默认值或源

    //        // 反向映射可能不需要，取决于你的需求
    //        CreateMap<BaseNewsInfo, InputBaseNewsInfoDto>();
    //    }
    //}
}
