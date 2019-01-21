using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex25_DbConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            DbCommand newSqlCommand = new DbCommand(new SqlConnection("custom_connection_string"));
            newSqlCommand.Execute("select * from *");

            DbCommand newOracleCommand = new DbCommand(new OracleConnection("custom_connection_string"));
            newOracleCommand.Execute("select * from Customer");
        }
    }
}
