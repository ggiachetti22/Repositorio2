using System;
using System.IO;
using System.Security.AccessControl;
using System.Security.Permissions;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace While{
    class Program{
        static async Task Main(string[] args){
            try{
                //TODO : var;
                string nombre,Nombre;
                string escrito,Escrito;
                String EscCorrect = @"^[A-Za-z]+$";
                String Correcto = "Pedro";
                bool? Verdad = null;
                //TODO : var end;
                Console.WriteLine($"Hola..");
                //TODO : while;
                while(true){
                    Console.WriteLine($"Escribe tu nombre por favor..");
                    nombre = Console.ReadLine();
                    if(Regex.IsMatch(nombre,EscCorrect)){
                        Console.WriteLine($"Es correcto el nombre [Si/No]..¿?");
                        escrito = Console.ReadLine();
                        if(!string.IsNullOrWhiteSpace(escrito.Trim()) && escrito.Substring(0,1).Equals("S",StringComparison.OrdinalIgnoreCase)){
                            Console.WriteLine($"Excelente {Mayus(nombre)}..!");
                            break;
                        }else Console.WriteLine($"Tu respuesta es No..");
                    }else Console.WriteLine("Nombre incorrecto, vuelve a intentarlo por favor..!");
                } // while
                Console.WriteLine($"Hola Bienvenido {Mayus(nombre)}..!");
                //TODO : while end;
                await Task.Delay(2000);
                Console.WriteLine($"\nEl Programa se está ejecutándo con éxito..!\n");
                // Console.WriteLine($"");
                // await Task.Delay(1000);
            }
            catch(Exception e){
                Console.WriteLine("\nError:\n",e);
                await Task.Delay(1000);
                Console.WriteLine($"Presiona cualquier tecla para \"salir\"");
                Console.ReadKey();
                // Console.WriteLine($"");
                // await Task.Delay(1000);
                // Thread.Sleep(1000);
            }
        } // main;
        public static string Mayus(string n){
            return n.Trim().Substring(0,1).ToUpper() + n.Trim().Substring(1).ToLower();
        } // Mayus(string)
    } // pro;
} // name;