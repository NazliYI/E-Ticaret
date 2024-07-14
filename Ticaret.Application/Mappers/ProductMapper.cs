using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticaret.Application.DTOs;
using Ticaret.Core.Entities;

namespace Ticaret.Application.Mappers
{
    internal class ProductMapper
    {
        public static ProductDto ToDto(Product product)
        {
            return new ProductDto
            {
                ProductId = product.ProductId,
                Name = product.Name,
                Price = product.Price
            };
        }
        public static Product ToEntity(ProductDto productDto)
        {
            return new Product
            {
                ProductId = productDto.ProductId,
                Name = productDto.Name,
                Price = productDto.Price
            };
        }
    }
}
