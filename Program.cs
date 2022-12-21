using Newtonsoft.Json;

using kasa;
using System.Runtime.CompilerServices;



string des = File.ReadAllText(@"C:\\Users\\matja\\OneDrive\\Pulpit\\zaliczenie na studia\\kasa\\kasa\\dane.json");  
Item item= JsonConvert.DeserializeObject<Item>(des);

Console.WriteLine(item.Name);