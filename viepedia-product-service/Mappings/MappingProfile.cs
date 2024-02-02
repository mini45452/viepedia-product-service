using viepedia_product_service.Models;
using viepedia_product_service.DTO;
using AutoMapper;

namespace viepedia_product_service.Mappings
{
    public class MappingProfile
    {
        public static Mapper InitializeAutomapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                //cfg.CreateMap<ProductDTO, Product>()
                //    .ForMember(dest => dest.Thumbnail, opt => opt.MapFrom(src => Convert.FromBase64String(src.Thumbnail)));
            });

            var mapper = new Mapper(config);
            return mapper;
        }
    }
}
