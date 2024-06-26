
using Intex_Group3_6.Models.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace Intex_Group3_6.Models
{
    public interface IDataRepo
    {
        void AddUser(User user);
        void AddOrder(Order order);
        void AddLineItem(LineItem lineItem);

        void SaveChanges();

        public IQueryable<User> GetUser(string email);
        
        public AdminOrdersViewModel GetOrders(int pageNum);
      
        public IQueryable<Product> Products { get; }

        public AdminProductsViewModel GetProducts(int pageNum, int pageSize);

        IEnumerable<AvgRating> AvgRatings { get; }

        public ProductDetailViewModel GetProductDetail(string productId);

        public IEnumerable<RatedProducts> GetRatingsWithPictures();
        public AdminUsersViewModel GetUsers(int pageNum);
        public Product GetProductById(int productId);
        void UpdateProduct(Product product);
        void DeleteProduct(Product product);
        public Order GetOrderById(int transactionId);
        public void DeleteOrder(Order order);
        void AddProduct(Product product);
        public User GetUserByEmail(string email);
        public IQueryable<Product> GetUserRec(int userId);
        public void UpdateUser(User user);
        public User GetUserById(int userId);
        public void DeleteUser(User user);
    }

}