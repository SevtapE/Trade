using Business.Abstract;
using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete.Customer
{
    public class PersonManager : ICustomerManager
    {
        public void Add(ICustomer customer)
        {
            throw new NotImplementedException();
        }

        public void Delete(ICustomer customer)
        {
            throw new NotImplementedException();
        }

        public List<ICustomer> List()
        {
            throw new NotImplementedException();
        }

        public void Update(ICustomer customer)
        {
            throw new NotImplementedException();
        }
    }
}
