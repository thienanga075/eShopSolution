﻿using eShopSolution.ViewModels.Catalog.Categories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eShopSolution.Application.Catalog.categories
{
    public interface ICategoryService
    {
        Task<List<CategoryVm>> GetAll(string LanguageId);

        Task<CategoryVm> GetById(string languageId, int id);
    }
}