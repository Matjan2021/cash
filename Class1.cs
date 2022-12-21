using kasa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
namespace kasa
    {
    JObject jsonObject = JObject.Parse(data);
    Console.WriteLine("Name: "+ jsonObject["name"]);
    Console.WriteLine("Kod: "+ jsonObject["Kod"]);
    Console.WriteLine("price: "+ jsonObject["price"]);
    
    Console.ReadLine();
    public class Item
    {
        public string Kod { get; set; }
        public string Name { get; set; }
        public decimal price { get; set; }


    }

    


    
}
