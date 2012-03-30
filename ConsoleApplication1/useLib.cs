using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    public static class UseLibrary
    {
       static public void weatherMenu()
       {
           Console.WriteLine("Select City");
           Console.WriteLine("1. Burlington, VT");
           Console.WriteLine("2. New York City, NY");
           Console.WriteLine("3. Boston, MA");
           Console.WriteLine("4. Miami, FL");
           Console.WriteLine("5. Austin, TX");
           string cityChoice = Console.ReadLine();
           Console.WriteLine("Select Data");
           Console.WriteLine("1. Hourly Temperature");
           Console.WriteLine("2. Maximum Tempature");
           Console.WriteLine("3. Minimum Tempature");
           string dataChoice = Console.ReadLine();
           switch (dataChoice)
           {
               case "1":
                   dataChoice = "temp=temp";
                   break;
               case "2":
                   dataChoice = "maxt=maxt";
                   break;
               case "3":
                   dataChoice = "mint=mint";
                   break;
               default:
                   Console.WriteLine("Defaulting to Hourly Temperature");
                   dataChoice = "temp=temp";
                   break;
           }
           string results = "";
           switch (cityChoice)
           {
               case "1":
                   results = MyDynamicLibrary.weatherRESTquery.Get_URI("44.47", "-73.23", dataChoice);
                   break;
               case "2":
                   results = MyDynamicLibrary.weatherRESTquery.Get_URI("40.71", "-73.98", dataChoice);
                   break;
               case "3":
                   results = MyDynamicLibrary.weatherRESTquery.Get_URI("42.36", "-71.07", dataChoice);
                   break;
               case "4":
                   results = MyDynamicLibrary.weatherRESTquery.Get_URI("25.76", "-80.21", dataChoice);
                   break;
               case "5":
                   results = MyDynamicLibrary.weatherRESTquery.Get_URI("30.27", "-97.74", dataChoice);
                   break;
               default:
                   Console.WriteLine("Defaulting to Burlington, VT");
                   results = MyDynamicLibrary.weatherRESTquery.Get_URI("44.47", "-73.23", dataChoice);
                   break;
           }

           Console.WriteLine(results);

           Console.WriteLine("Press any key to continue.");
           Console.ReadKey();
           Console.Clear();

           Console.WriteLine("Select City");
           Console.WriteLine("1. Burlington, VT");
           Console.WriteLine("2. New York City, NY");
           Console.WriteLine("3. Boston, MA");
           Console.WriteLine("4. Miami, FL");
           Console.WriteLine("5. Austin, TX");
           cityChoice = Console.ReadLine();
           Console.WriteLine("Select Data");
           Console.WriteLine("1. Hourly Temperature");
           Console.WriteLine("2. Maximum Tempature");
           Console.WriteLine("3. Minimum Tempature");
           dataChoice = Console.ReadLine();
           switch (dataChoice)
           {
               case "1":
                   dataChoice = "temp=temp";
                   break;
               case "2":
                   dataChoice = "maxt=maxt";
                   break;
               case "3":
                   dataChoice = "mint=mint";
                   break;
               default:
                   Console.WriteLine("Defaulting to Hourly Temperature");
                   dataChoice = "temp=temp";
                   break;
           }
           results = "";
           switch (cityChoice)
           {
               case "1":
                   results = MyDynamicLibrary.weatherRESTquery.Get_URI("44.47", "-73.23", dataChoice);
                   break;
               case "2":
                   results = MyDynamicLibrary.weatherRESTquery.Get_URI("40.71", "-73.98", dataChoice);
                   break;
               case "3":
                   results = MyDynamicLibrary.weatherRESTquery.Get_URI("42.36", "-71.07", dataChoice);
                   break;
               case "4":
                   results = MyDynamicLibrary.weatherRESTquery.Get_URI("25.76", "-80.21", dataChoice);
                   break;
               case "5":
                   results = MyDynamicLibrary.weatherRESTquery.Get_URI("30.27", "-97.74", dataChoice);
                   break;
               default:
                   Console.WriteLine("Defaulting to Burlington, VT");
                   results = MyDynamicLibrary.weatherRESTquery.Get_URI("44.47", "-73.23", dataChoice);
                   break;
           }
           Console.WriteLine(results);
           //pause again
           Console.WriteLine("Press any key to exit.");
           Console.ReadKey();
        }
    }
}
