using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using PoeShopWatcher.Models;

namespace PoeShopWatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            Watcher.Run();
        }
    }
}
