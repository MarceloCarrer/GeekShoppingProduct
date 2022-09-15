using AutoMapper;
using GeehShopping.ProductAPI.Data.ValueObjects;
using GeehShopping.ProductAPI.Model;

namespace GeehShopping.ProductAPI.Config
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config => {
                config.CreateMap<ProductVO, Product>();
                config.CreateMap<Product, ProductVO>();
            });

            return mappingConfig;
        }
    }
}
