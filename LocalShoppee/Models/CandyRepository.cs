using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalShoppee.Models
{
    public class CandyRepository : ICandyRepository
    {
        private readonly ICategoryRepository _categoryRepository = new CategoryRepository();

        public IEnumerable<Candy> GetAllCandy => new List<Candy>
        {
        new Candy{CandyId=1,Name="Assorted",Price=4.95M, Description="Assorted",
            Category=_categoryRepository.GetAllCategories.ToList()[0],ImageUrl="https://en.wikipedia.org/wiki/Candy#/media/File:Candy_in_Damascus.jpg",
        IsInStock=true,IsOnSale=true,ImageThumbnailUrl="https://upload.wikimedia.org/wikipedia/commons/b/bb/Assorted_snacks.jpg"},
        new Candy{CandyId=2,Name="Assorted",Price=4.95M, Description="Assorted",
            Category=_categoryRepository.GetAllCategories.ToList()[0],ImageUrl="https://en.wikipedia.org/wiki/Candy#/media/File:Candy_in_Damascus.jpg",
        IsInStock=true,IsOnSale=true,ImageThumbnailUrl="https://upload.wikimedia.org/wikipedia/commons/b/bb/Assorted_snacks.jpg"},
        new Candy{CandyId=3,Name="Assorted",Price=4.95M, Description="Assorted",
            Category=_categoryRepository.GetAllCategories.ToList()[0],ImageUrl="https://en.wikipedia.org/wiki/Candy#/media/File:Candy_in_Damascus.jpg",
        IsInStock=true,IsOnSale=true,ImageThumbnailUrl="https://upload.wikimedia.org/wikipedia/commons/b/bb/Assorted_snacks.jpg"},
        new Candy{CandyId=4,Name="Assorted",Price=4.95M, Description="Assorted",
            Category=_categoryRepository.GetAllCategories.ToList()[0],ImageUrl="https://en.wikipedia.org/wiki/Candy#/media/File:Candy_in_Damascus.jpg",
        IsInStock=true,IsOnSale=true,ImageThumbnailUrl="https://upload.wikimedia.org/wikipedia/commons/b/bb/Assorted_snacks.jpg"}
        };

        public IEnumerable<Candy> GetCandyOnSale => throw new NotImplementedException();

        public Candy GetCandyById(int CandyId)
        {
            return GetAllCandy.FirstOrDefault(c => c.CandyId == CandyId);
        }
    }
}