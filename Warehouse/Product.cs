using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    public delegate void NewProdouctDelegate(string message);

    class Product
    {
       public event NewProdouctDelegate ReportEvent;
       ConsoleReporter reporter = new ConsoleReporter();
        public string Name { get; set; }
       public int Id { get; set; }
       public string Description { get; set; }
       public int Count { get; set; } = 0;

        
        public bool AddProduct(int count)
        {
            Count = count;
            ReportEvent("Товар добавлен");
            return true;
        }

    }
}
