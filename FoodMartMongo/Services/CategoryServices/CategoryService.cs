﻿using FoodMartMongo.Dtos.CategoryDtos;

namespace FoodMartMongo.Services.CategoryServices
{
    public class CategoryService : ICategoryService
    {
        public Task CreateCategoryAsync(CreateCategoryDto categoryDto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCategoryAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ResultCategoryDto>> GetAllCategoryAsync()
        {
            throw new NotImplementedException();
        }

        public Task<GetCategoryByIdDto> GetCategoryByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCategoryAsync(UpdateCategoryDto categoryDto)
        {
            throw new NotImplementedException();
        }
    }
}
