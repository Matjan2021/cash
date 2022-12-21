
using kasa;
using System.Runtime.CompilerServices;

Item Item = new Item();
Item.Name = "Masło Extra";
Item.Kod = "001";
Item.price = 6.50M;


Console.WriteLine(Item.Name);
Console.WriteLine(Item.Kod);
Console.WriteLine(Item.price);