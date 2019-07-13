using CommonType.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yayakos.Entities;

namespace Yayakos.BLL.Abstracts
{
    public interface IProductService
    {
        ServiceResult<List<Product>> GetProducts();
        ServiceResult<Product> Get(Guid Id);
        ServiceResult Add(Product product);

    }
}
