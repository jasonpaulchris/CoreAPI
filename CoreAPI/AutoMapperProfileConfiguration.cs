using AutoMapper;
using CoreAPI.Models;

namespace CoreAPI
{
    public class AutoMapperProfileConfiguration : Profile
    {
        public AutoMapperProfileConfiguration()
        {
            CreateMap<StoreModel, StoreDto>()
                .AfterMap(model, cto) => dto.UId = model.Id);

            CreateMap<StoreDto, StoreModel>()
                ForSourceMember("StoreId", s => s.Ignore());
            ForSourceMember("UId", s => s.Ignore());
            ForMember("Id", s => s.Ignore());
            AfterMap((dto, model) => model.Id = dto.UId);
        }
    }
}
