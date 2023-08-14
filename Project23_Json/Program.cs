using System.IO;
using System.Text.Json;

var path = @"D:\Projects\Files\Person";


StreamReader reader = new StreamReader(path);
var Text =  reader.ReadToEnd();
//var Result = JsonSerializer.Deserialize<string>(Text);
reader.Close();
Console.WriteLine(Text);