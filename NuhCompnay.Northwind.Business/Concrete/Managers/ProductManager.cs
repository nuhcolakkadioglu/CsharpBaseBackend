using NuhCompnay.Northwind.Business.Abstract;
using NuhCompnay.Northwind.DataAccess.Abstract;
using NuhCompnay.Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuhCompnay.Northwind.Business.Concrete.Managers
{
    public class ProductManager : IProductService
    {
        private  IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public Product Add(Product product)
        {
            return _productDal.Add(product);
        }

        public List<Product> GetAll()
        {
            return _productDal.GetList();
        }

        public Product GetById(int id)
        {
            return _productDal.Get(m => m.ProductId==id) ;
        }
    }
}
