using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex25_DbConnection
{
    class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString) { }

        public override void Close()
        {
            Console.WriteLine("OracleConnection: Closing connection.");
        }

        public override void Open()
        {
            Console.WriteLine("OracleConnection: Opening connection.");
        }
    }
}
