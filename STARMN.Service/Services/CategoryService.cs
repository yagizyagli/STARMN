

using STARMN.Access.Repositories.Interfaces;
using STARMN.Database.Entities;
using STARMN.Service.Services.Interfaces;

namespace STARMN.Service.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public bool Delete(int id)
        {
            try
            {
                _categoryRepository.Delete(id);
                return true;
            }
            catch { 
                return false;
            
            }
        }

        public List<Category> GetAll()
        {
            return _categoryRepository.GetAll();
        }

        public Category GetById(int id)
        {
            return _categoryRepository.GetById(id);
        }

        public int ProductCount(int categoryId)
        {
            return _categoryRepository.ProductCount(categoryId);
        }

        public bool Save(Category category)
        {
            try
            {
                _categoryRepository.Save(category);
                return true;
            }
            catch
            {
                return false;
            }
        }        

        public bool Update(Category category)
        {
            try
            {
                _categoryRepository.Update(category);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
