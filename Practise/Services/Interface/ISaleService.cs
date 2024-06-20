using Practise.Models;

namespace Practise.Services.Interface
{
    public interface ISaleService
    {
        Sale AddSale(Sale sale);
        Sale UpdateSale(Sale sale);
        void DeleteSale(Sale sale);
        Sale GetSaleById(int id);



    }
}
