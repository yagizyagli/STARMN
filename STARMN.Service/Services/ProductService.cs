

using STARMN.Access.Repositories.Interfaces;
using STARMN.Database.Entities;
using STARMN.Service.Services.Interfaces;

namespace STARMN.Service.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public bool Delete(int id)
        {
            try
            {
                _productRepository.Delete(id);

                return true;
            }
            catch (Exception ex)
            {
                return false;

            }
        }

        public List<Product> GetAll()
        {
            return _productRepository.GetAll();
        }

        public Product GetById(int id)
        {
            return _productRepository.GetById(id);
        }

        public Product Save(Product product)
        {
            try
            {
                _productRepository.Save(product);
                return product;

            }
            catch (Exception)
            {
                return null;

            }
        }

        public Product Update(Product product)
        {
            try
            {
                _productRepository.Update(product);
                return product;
            }
            catch (Exception)
            {
                return null;
            }
        }


    }
}
