using viepedia_product_service.DTO;
using viepedia_product_service.Models;
using viepedia_product_service.Mappings;

namespace viepedia_product_service.Services
{
    public class ConverterService
    {
        public static Product ProductDTOToProduct(ProductDTO productDTO)
        {
            Product product = MappingProfile.InitializeAutomapper().Map<Product>(productDTO);
            return product;
        }
    }
}

