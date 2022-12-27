using Newtonsoft.Json;

using kasa;
using System.Runtime.CompilerServices;



var des = File.ReadAllText(@"C:\\Users\\matja\\OneDrive\\Pulpit\\zaliczenie na studia\\kasa\\kasa\\dane.json");  
Item item= JsonConvert.DeserializeObject<Item>(des);
    //var text = File.ReadAllText(path);
    //var Item = JsonConvert.DeserializeObject<Item>(text);

Console.WriteLine(Item.Name);

