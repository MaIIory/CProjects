using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex25_DbConnection
{
    class DbCommand
    {
        public DbConnection DbConnection { get; }

        public DbCommand(DbConnection dbConnection)
        {
            if (dbConnection is null)
                throw new InvalidOperationException("DBConnection argument cannot be null.");
            DbConnection = dbConnection;
        }

        public void Execute(string dbCommand)
        {
            DbConnection.Open();
            Console.WriteLine("Run the instruction: {0}",dbCommand);
            DbConnection.Close();
        }
    }
}
