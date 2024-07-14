using Ticaret.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticaret.Core.Interfaces;



namespace Ticaret.Application.AppServices
{
    internal class ProductAppService
    {
        // Dependency Injection ile alınan repository örneği
        private readonly IProductRepository _productRepository;

        public ProductAppService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        // Ürünleri almak için bir metot
        public IEnumerable<ProductDto> GetAllProducts()
        {
            var products = _productRepository.GetAll();
            var productDtos = new List<ProductDto>();

            foreach (var product in products)
            {
                productDtos.Add(new ProductDto
                {
                    ProductId = product.ProductId,
                    Name = product.Name,
                    Price = product.Price
                });
            }

            return productDtos;
        }
    }
}

   