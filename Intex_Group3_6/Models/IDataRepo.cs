
using Intex_Group3_6.Models.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace Intex_Group3_6.Models
{
    public interface IDataRepo
    {
        void AddUser(User user);
        void SaveChanges();

        public IQueryable<User> GetUser(string email);
        
        public AdminOrdersViewModel GetOrders(int pageNum);
      
        public IQueryable<Product> Products { get; }

        public AdminProductsViewModel GetProducts(int pageNum, int pageSize);

        IEnumerable<AvgRating> AvgRatings { get; }

        public ProductDetailViewModel GetProductDetail(string productId);

        public IEnumerable<RatedProducts> GetRatingsWithPictures();
        public AdminUsersViewModel GetUsers(int pageNum);
    }

}