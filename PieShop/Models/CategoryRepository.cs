﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PieShop.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _appDbContext;

        public CategoryRepository(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }

        public IEnumerable<Category> AllCategories
        {
            get
            {
                return _appDbContext.Categories;
            }
        }
    }
}