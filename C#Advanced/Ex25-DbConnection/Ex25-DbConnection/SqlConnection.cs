using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex25_DbConnection
{
    class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString) { }

        public override void Close()
        {
            Console.WriteLine("SqlConnection: Closing connection.");
        }

        public override void Open()
        {
            Console.WriteLine("SqlConnection: Opening connection.");
        }
    }
}
