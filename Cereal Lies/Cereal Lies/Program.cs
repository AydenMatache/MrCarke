using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace Cereal_Lies
{
    public class Cereal
    {
public string Name { get; set; }
        public string Solgan { get; set; }
        public Boolean clarkeApproved { get; set; }
        public int Calories { get; set; }   
       public decimal price { get; set; }
        public string picture { get; set; } 
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Cereal luckycharms = new Cereal();
            luckycharms.Name = "lucky Charms";
            luckycharms.price = 3.99m;
            luckycharms.clarkeApproved = true;
            luckycharms.Calories = 137;
            luckycharms.picture = "lucky";
            luckycharms.Solgan = "They're magically delicious.";
            Cereal cheerios = new Cereal();
            cheerios.Name = "Cheerios";
            cheerios.clarkeApproved= false;
            cheerios.price = 0.00m;
            cheerios.Calories = 000;
            cheerios.picture = "cheer";
            cheerios.Solgan = "Bee Happy, Bee Healthy";
            Cereal honeyNutCheerios = new Cereal();
            honeyNutCheerios.Name = "Honey Nut Cheerios";
            honeyNutCheerios.clarkeApproved = false;
            honeyNutCheerios.price = 0.00m;
            honeyNutCheerios.Calories = 000;
            honeyNutCheerios.picture = "nut";
            honeyNutCheerios.Solgan = "Good Goes Round";

            string jsonString = JsonSerializer.Serialize(luckycharms);
            Console.Write(jsonString);


            Cereal charms = new Cereal();
            charms = JsonSerializer.Deserialize<Cereal>(jsonString);


            Console.ReadKey();
        }
    }
}
