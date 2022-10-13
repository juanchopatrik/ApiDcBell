using ApiDcBell.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiDcBell.TestX
{
    internal abstract class MockProduct
    {
        public Product product1 = new Product();
        
        public Product product2 = new Product();

        public Product firstProduct(Product pro)
        {
            pro.Id = new MongoDB.Bson.ObjectId();
            pro.Name = "red whine";
            pro.Stock = 1;
            
            return pro;
        }


    
    
    }
}
