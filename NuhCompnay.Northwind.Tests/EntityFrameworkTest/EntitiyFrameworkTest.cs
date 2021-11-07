using Microsoft.VisualStudio.TestTools.UnitTesting;
using NuhCompnay.Northwind.DataAccess.Concrete.EntitiyFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuhCompnay.Northwind.Tests.EntityFrameworkTest
{
    [TestClass]
    public class EntitiyFrameworkTest
    {
        [TestMethod]
        public void Get_all_returns_all_products()
        {
            EfProductDal efProductDal = new EfProductDal();
            var result = efProductDal.GetList();
            Assert.AreEqual(85, result.Count);

        }
    }
}
