using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using VnExpress.ViewModel.Categories;

namespace VnExpress.Application.Categories
{
    public interface ICategoryService
    {
        Task<List<CategoryVm>> GetAll();
        Task<int> Create(CategoryCreateRequest request);

        Task<int> Update(CategoryUpdateRequest request);
        Task<int> Delete(int categoryId);
        Task<CategoryVm> GetById(int categoryId);
    }
}
