using Pronia.Core.Entities;
using Pronia.Core.Entitiesı;
using Pronia.Core.Entitiesş;

namespace Pronia.ViewModels;

public class HomeVM
{
    public IEnumerable<Slidaer> Slidaers { get; set; }  
    public IEnumerable<Payment> Payments { get; set; }  
    public IEnumerable<Product> Products { get; set; }  
    public IEnumerable<Banner>Banners { get; set; }  
    public IEnumerable<NewProduct>NewProducts { get; set; }  

}
