using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//rt click and build class lib to dll, add refrence to dll in app, add using line in app, and rt click+set this application as StartUp Project
//using MyDynamicLibrary;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            try //try and catch is ok for this but do not use for high performance apps, like a game
            {
                System.Reflection.AssemblyName testAssembly
                    = System.Reflection.AssemblyName.GetAssemblyName("ClassLibrary1.dll");
                UseLibrary.weatherMenu();
            }
            catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine("dll not found");
                Console.ReadKey();
            }
            catch (BadImageFormatException)
            {
                Console.WriteLine("the file is not an assembly");
                Console.ReadKey();
            }
            catch (System.IO.FileLoadException)
            {
                Console.WriteLine("the assembly has already been loaded");
                Console.ReadKey();
            }
        }
    }
}
