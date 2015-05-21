using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbPracticeConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Database db = new Database();
            db.dbQuery();
            db.dbClose();
        }
    }
}
