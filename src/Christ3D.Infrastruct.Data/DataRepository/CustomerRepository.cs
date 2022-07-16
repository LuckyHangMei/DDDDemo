using Christ3D.Domain.Interfaces;
using Christ3D.Domain.Models;
using Christ3D.Infrastruct.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christ3D.Infrastruct.Data.DataRepository
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(StudyContext studyContext) : base(studyContext)
        {
        }

        public Customer GetByEmail(string email)
        {
            throw new NotImplementedException();
        }
    }
}
