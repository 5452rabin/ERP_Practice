using Practise.GenericRepository.Interface;
using Practise.Models;
using Practise.Services.Interface;

namespace Practise.Services.Implementation
{
    public class SaleService : ISaleService
    {
        private readonly IGenericRepository<Sale> _genericRepository;
        public SaleService(IGenericRepository<Sale> genericRepository) {
            _genericRepository = genericRepository;
        }
        public Sale AddSale(Sale sale)
        {
            sale =_genericRepository.Add(sale);
            return sale;
        }

        public void DeleteSale(Sale sale)
        {
            _genericRepository.Delete(sale.saleId);
        }

       public Sale GetSaleById(int id)
        {
            Sale sale=_genericRepository.GetById(id);
            return sale;
        }

   

        public Sale UpdateSale(Sale sale)
        {
            throw new NotImplementedException();
        }
    }
}
