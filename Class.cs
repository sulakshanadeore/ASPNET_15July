using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DIDemo
{
    public class Category
    {
        public int CatId { get; set; }
        public string CatName { get; set; }
        public string Description { get; set; }
    }

    public interface ICategory
    {
        List<Category> GetCategories();
    }

    public class CategoryRepository : ICategory
    {
        public List<Category> GetCategories()
        {
            //throw new System.NotImplementedException();
            List<Category> categories = new List<Category>();
            categories.Add(new Category { CatId = 1, CatName = "Beverages", Description = "Tea,Coffee" });

            categories.Add(new Category
            {
                CatId = 2,
                CatName = "Snacks",
                Description = "Pizza,Burger"
            });
            return categories;

        }
    }

}
