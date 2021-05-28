﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EIS.Models;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace EIS.Repository
{
    public class EmployeeRepo
    {
        string connectionString = "Server=(LOCALDB)\\MSSQLLOCALDB;Database=EmployeeDB;User ID=santhi;Password=priya";
        private IDbConnection conn { get; set; }

        public EmployeeRepo()
        {
            conn = new SqlConnection(connectionString);

        }

        public void AddEmployee(Employee emp)
        {
            this.conn.Execute("InsertEmployee", emp, commandType: CommandType.StoredProcedure);

        }

        public List<Employee> GetAllEmployees()
        {
            return this.conn.Query<Employee>("GetAllEmployees", commandType: CommandType.StoredProcedure).ToList();
        }
    }
}
