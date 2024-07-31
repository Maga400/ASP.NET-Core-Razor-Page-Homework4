using ASP.NET_Core_Razor_Page_Homework4.Entities;

namespace ASP.NET_Core_Razor_Page_Homework4.Services
{
    public interface IProductService
    {
        List<Product> GetAllAsync();
        void AddAsync(Product product);
        void UpdateAsync(Product product);
        void DeleteAsync(int id);
        Product GetByIdAsync(int id);
    }
}
