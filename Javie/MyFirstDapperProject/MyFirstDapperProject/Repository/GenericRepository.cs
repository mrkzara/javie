using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstDapperProject.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        IDbConnection _connection;
        readonly string connectionString = "";
        public GenericRepository() {

            _connection = new SqlConnection(connectionString);

        }
        public T GetById(int id)
        {
            return null;
        }
    }
}
