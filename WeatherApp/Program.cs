using Newtonsoft.Json.Linq;


string key = File.ReadAllText("appsettings.json");
string APIkey = JObject.Parse(key).GetValue("DefaultKey").ToString();

Console.WriteLine("////////////////////////////////////////////////////");

Console.WriteLine("Welcome to the Weather Channel*\n" +
    "Please enter your zipcode for your local forecast.");

Console.WriteLine("////////////////////////////////////////////////////");

var zipCode = Console.ReadLine();
string apiCall = $"https://api.openweathermap.org/data/2.5/weather?zip={zipCode}&units=imperial&appid={APIkey}";

Console.WriteLine();

Console.WriteLine($"It is currently {WeatherApp.WeatherMap.GetTemp(apiCall)};");




