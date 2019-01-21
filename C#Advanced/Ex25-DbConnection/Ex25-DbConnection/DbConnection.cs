using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex25_DbConnection
{
    abstract class DbConnection
    {
        public string ConnectionString { get; private set; }
        public TimeSpan Timeout { get; set; }

        public DbConnection(string connectionString)
        {
            if (String.IsNullOrWhiteSpace(connectionString))
                throw new InvalidOperationException("Connection string must be set.");
            this.ConnectionString = connectionString;
        }

        abstract public void Open();
        abstract public void Close();
    }
}
