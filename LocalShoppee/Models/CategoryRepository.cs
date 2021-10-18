using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalShoppee.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> GetAllCategories => new List<Category>
        {
            new Category{CategoryId=1,CategoryName="Hard Candy",CategoryDescription="Awesome Candy"},
            new Category{CategoryId=2,CategoryName="Choco Candy",CategoryDescription="Awesome Choco Candy"},
            new Category{CategoryId=3,CategoryName="Fruit Candy",CategoryDescription="Awesome Fruit Candy"}
        };
    }
}