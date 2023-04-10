using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    internal class EmployeeRepository : IRepository<Employees>
    {
        public int DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employees> GetAll()
        {
            throw new NotImplementedException();
        }

        public Employees GetById(int id)
        {
            throw new NotImplementedException();
        }

        public int Insert(Employees obj)
        {
            throw new NotImplementedException();
        }

        public int Update(Employees obj)
        {
            throw new NotImplementedException();
        }
    }
}
