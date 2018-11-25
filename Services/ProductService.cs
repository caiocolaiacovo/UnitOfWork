using System.Collections.Generic;
using UnitOfWorkProject.Interfaces;
using UnitOfWorkProject.Models;

namespace UnitOfWorkProject.Services
{
    public class ProductService
    {
        private readonly IBaseRepository<Product> productRepository;

        public ProductService(IBaseRepository<Product> productRepository)
        {
            this.productRepository = productRepository;   
        }

        public IEnumerable<Product> GetAll()
        {
            return productRepository.GetAll();
        }
    }
}