using GamerProject.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamerProject.Entities;

namespace GamerProject.Concrete
{
    public class StoreManager : IStoreServices
    {
       

        public void Add(Store store)
        {
            Console.WriteLine(store.StoreName);
        }

        public void Delete(Store store)
        {
            Console.WriteLine(store.StoreName);
        }

       
    }
}
