using CleanArchitecture.Core.Entities;
using CleanArchitecture.SharedKernel.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Infrastructure.Data
{
    public class CategoriesRepository : EfRepository, ICategoriesRepository
    {
        public CategoriesRepository(NorthwindDbContext dbContext)
            : base (dbContext)
        { }
    }
}
