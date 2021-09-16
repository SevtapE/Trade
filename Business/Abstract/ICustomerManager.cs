using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
   public interface ICustomerManager
    {
        void Add(ICustomer customer);
        void Update(ICustomer customer);
        void Delete(ICustomer customer);
        List<ICustomer> List();
    }
}
