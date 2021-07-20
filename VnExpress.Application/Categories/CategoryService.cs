using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VnExpress.Data.EF;
using VnExpress.Data.Entities;
using VnExpress.ViewModel.Categories;

namespace VnExpress.Application.Categories
{
    public class CategoryService : ICategoryService
    {
        private readonly VnExpressDbContext _context;
        public CategoryService(VnExpressDbContext context)
        {
            _context = context;

        }
        public async Task<int> Create(CategoryCreateRequest request)
        {
            {

                var category = new Category()
                {
                    CategoryName = request.CategoryName,
                    Description = request.Description

                };

                _context.Categories.Add(category);
                await _context.SaveChangesAsync();
                return category.CategoryId;
            }
        }

        public async Task<int> Delete(int categoryId)
        {
            var category = await _context.Categories.FindAsync(categoryId);
            if (category == null) throw new Exception($"Cannot find a category: {categoryId}");
            _context.Categories.Remove(category);
            return await _context.SaveChangesAsync();
        }

        public async Task<List<CategoryVm>> GetAll()
        {
            var categories = await _context.Categories.OrderByDescending(category => category.CategoryId).Select(category => new CategoryVm()
            {
                CategoryId = category.CategoryId,
                CategoryName = category.CategoryName,
                Description = category.Description
            }).ToListAsync();
            return categories;

        }

        public async Task<CategoryVm> GetById(int categoryId)
        {
            var category = await _context.Categories.FindAsync(categoryId);
            var categoryViewModel = new CategoryVm()
            {
               
                CategoryId = category.CategoryId,
                CategoryName = category.CategoryName,
                Description = category.Description

            };
            return categoryViewModel;
        }

        public async Task<int> Update(CategoryUpdateRequest request)
        {
            var category = await _context.Categories.FindAsync(request.CategoryId);
            if (category == null) throw new Exception($"Cannot find a category with id: {request.CategoryId}");
            category.CategoryName = request.CategoryName;
            category.Description = request.Description;
            return await _context.SaveChangesAsync();
        }
    }
}
