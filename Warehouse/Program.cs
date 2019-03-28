using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    class Program
    {
        static void Main(string[] args)
        {

            Product product = new Product();          
            var reporter = new ConsoleReporter();
            product.ReportEvent += reporter.NewProduct;

            int i = 0; int n = 0;

            Console.WriteLine("Введите имя товара:");
            product.Name = Console.ReadLine();
            Console.WriteLine("Введите Id товара:");
            while (!int.TryParse(Console.ReadLine(), out i))
            {
                Console.WriteLine("Неверный ID ");
            }
            product.Id = i;
            Console.WriteLine("Введите описание товара:");
            product.Description = Console.ReadLine();
            Console.WriteLine("Введите количество товара:");
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Введите колличество ");
            }
            product.AddProduct(n);
          

            string json = JsonConvert.SerializeObject(product);
            string filepath = "C:/Users/АйткожаЖ.CORP/source/repos/Warehouse/Warehouse/Data.json";
            File.AppendAllText(filepath, json);

            Console.ReadLine();
        }
    }
}
