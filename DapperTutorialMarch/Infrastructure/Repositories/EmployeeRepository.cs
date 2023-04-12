﻿using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Data;
using Dapper;
using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Entities;
using System.Data;
namespace Infrastructure.Repositories
{
    internal class EmployeeRepository : IRepository<Employees>
    {
        private readonly DapperDbContext _dbContext;
        
        public EmployeeRepository()
        {
            _dbContext = new DapperDbContext();
        }
        public int DeleteById(int id)
        {
            using (IDbConnection conn = _dbContext.GetConnection())
            {
                return conn.Execute("Delete From Employees Where Id = @Id", new { Id = id });
            }
        }

        public IEnumerable<Employees> GetAll()
        {
            using (IDbConnection conn = _dbContext.GetConnection())
            {
                return conn.Query<Employees>("Select * From Employees");
            }
        }

        public Employees GetById(int id)
        {
            using (IDbConnection conn=_dbContext.GetConnection())
            {
                return conn.QuerySingleOrDefault<Employees>("Select * From Employees Where Id = @Id", new { Id = id });
            }
        }

        public int Insert(Employees obj)
        {
            using (IDbConnection conn = _dbContext.GetConnection())
            {
             //   DynamicParameters paramters = new DynamicParameters();
                return conn.Execute("Insert Into Employees Values(@FirstName,@LastName,@Salary, @DeptId)", obj);
            }
        }

        public int Update(Employees obj)
        {
            using (IDbConnection conn = _dbContext.GetConnection())
            {
                return conn.Execute("Update Employees set FirstName = @FirstName, LastName = @LastName,Salary=@Salary,DeptId=@DeptId Where Id = @Id", obj);
            }
        }
    }
}
