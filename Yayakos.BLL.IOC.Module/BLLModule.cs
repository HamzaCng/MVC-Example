using Core.DataAccess;
using Core.DataAccess.SqlServer.EntityFramework;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yayakos.BLL.Abstracts;
using Yayakos.Dal;

namespace Yayakos.BLL.IOC.Module
{
    public class BLLModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IUnitOfWork>().To<UnitOfWork>();
            Bind<IProductService>().To<ProductService>();

            List<INinjectModule> modules = new List<INinjectModule>();
            modules.Add(new DalModule());
            Kernel.Load(modules);
        }
    }
}
