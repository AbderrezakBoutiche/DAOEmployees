using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace DAO
{
    class Program
    {
        static void Main(string[] args)
        {
            // SQLConnexion objCon = new SQLConnexion();
            List<Employe> liste = SQLConnexion.GetAllEmployes();
            Console.ReadKey();
        }
    }
}
