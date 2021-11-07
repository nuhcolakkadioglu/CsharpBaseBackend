using Microsoft.EntityFrameworkCore;
using Ninject.Modules;
using NuhCompnay.Northwind.Business.Abstract;
using NuhCompnay.Northwind.Business.Concrete.Managers;
using NuhCompnay.Northwind.DataAccess.Abstract;
using NuhCompnay.Northwind.DataAccess.Concrete.EntitiyFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuhCompnay.Northwind.Business.DependencyResolvers.Ninject
{
   public class BusinessModule:NinjectModule
    {
        public override void Load()
        {
            Bind<IProductService>().To<ProductManager>().InSingletonScope();
            Bind<IProductDal>().To<EfProductDal>();
            Bind<DbContext>().To<NorthwindContext>();

        }
    }
}
