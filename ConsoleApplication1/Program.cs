using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            try 
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
