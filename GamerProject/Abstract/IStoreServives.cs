using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamerProject.Entities;

namespace GamerProject.Abstract
{
    public interface IStoreServices
    {
        void Add(Store store);
        void Delete(Store store);
    }
}
