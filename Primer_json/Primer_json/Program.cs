﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer_json
{
    class Program
    {
        static void Main(string[] args)
        {
            Učilnica u = JsonConvert.DeserializeObject<Učilnica>(
                File.ReadAllText(@"D:\pro2021\Primer_json\Primer_json\Učilnica.json")
                );
            foreach(var p in u.poglavja)
            {
                Console.WriteLine(p.name);
                foreach(var m in p.modules)
                {
                    Console.WriteLine("\t" + m.name);
                }
            }
            Console.ReadLine();
        }
    }
}
