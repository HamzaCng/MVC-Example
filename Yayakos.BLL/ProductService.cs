using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonType.Classes;
using CommonType.Enums;
using Core.DataAccess;
using Yayakos.BLL.Abstracts;
using Yayakos.Entities;

namespace Yayakos.BLL
{
    public class ProductService : IProductService
    {
        IUnitOfWork _uow;
        public ProductService(IUnitOfWork uow)
        {
            _uow = uow;
        }
        public ServiceResult Add(Product product)
        {
            //kontroller gerçekleşmeli
            product.ID = Guid.NewGuid();
            _uow.GetRepository<Product>().Add(product);
           int ess= _uow.Save();
            if(ess>0)
            {
                return new ServiceResult("Kayıt başarılıdır", ResultState.Success);
            }
            return new ServiceResult("Bir hata nedeniyle kayıt gerçekleşmedi.", ResultState.Error);
        }

        public ServiceResult<Product> Get(Guid Id)
        {
            throw new NotImplementedException();
        }

        public ServiceResult<List<Product>> GetProducts()
        {            
           List<Product> products= _uow.GetRepository<Product>().GetList();
            return new ServiceResult<List<Product>>("Okuma Başarılı", ResultState.Success, products);
        }
    }
}
