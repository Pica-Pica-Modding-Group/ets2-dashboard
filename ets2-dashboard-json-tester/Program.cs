using ets2_dashboard_lib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ets2_dashboard_json_tester
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().Fetch();
        }

        void Fetch()
        {
            ETS2_Data stuff = ETS2_Data.Generate(File.ReadAllText("data.json"));            
        }
    }
}
