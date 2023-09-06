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
                            Console.WriteLine($"\nExcelente {Mayus(nombre)}..!\n");
                            break;
                        }else Console.WriteLine($"Tu respuesta es No..");
                    }else Console.WriteLine("Nombre incorrecto, vuelve a intentarlo por favor..!");
                } // while
                Console.WriteLine($"\nHola Bienvenido {Mayus(nombre)}..!\n");
                //TODO : while end;
                //TODO : delegado;
                // bool? EsPar = null;
                string nEs = "";
                int numEscrito;
                Console.WriteLine($"Escrime un número para saber el cuadrádo");
                Delegado elDelegado = new Delegado(num => num * num);
                int.TryParse(nEs = Console.ReadLine(), out int NE);
                if(NE != 0) Console.WriteLine($"\nNúmero {NE} al cuadrado = ({elDelegado(NE)})\n");
                else Console.WriteLine($"\nNúmero {NE = 2} al cuadrado = ({elDelegado(NE)})\n");
                //TODO : delegado end;
                //TODO : Pares;
                StreamWriter? archivo = null;
                int valor = 1;
                Random azar = new Random();
                string EscrLista;

                List<int> lista = new List<int>();
                
                while(valor != 0){
                    Console.WriteLine("Escribe un número para ir completando la lista y \"0\" para salir..!");
                    EscrLista = Console.ReadLine();
                    int.TryParse(EscrLista, out int Valor);
                    if(Regex.IsMatch(EscrLista,"^[0-9]+$")){
                        lista.Add(valor = Valor);
                    }else lista.Add(azar.Next(2,99));
                }
                lista.RemoveAt(lista.Count - 1);

                Predicate<int> dPares = new Predicate<int>(Pares);
                List<int> listaPares = lista.FindAll(dPares);
                Console.WriteLine("\nVista final de la lista pares: {0}",String.Join(",",listaPares));
                Console.WriteLine($"");
                //TODO : Pares end;
                await Task.Delay(2000);
                Console.WriteLine($"\nEl Programa se está ejecutándo con éxito..!\n");
                //TODO : Resultado final;
                using(archivo = new StreamWriter(@"C:\Users\guillermo.giachetti\Desktop\NotaRapida.txt", append: false)){
                archivo.WriteLine($"Imprime el Resultado para {Mayus(nombre)}.\nNúmero al cuadrado = ({elDelegado(NE)})\n\nVista final de la lista simple: [{String.Join(",",lista)}]\n\nVista final de la lista números pares: [{String.Join(",",listaPares)}]\n\nHasta Luego {Mayus(nombre)} y gracias por participar\n.. 😉 ..\n");
                }
                //TODO : Resultado final end;
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
        delegate int Delegado(int a);
        // delegate bool DelegaPares(int num);
        public static bool Pares(int num){
            if(num % 2 == 0) return true;
            else return false;
        } // pares;
        public class Empleado{
            private string nombre;
            private int edad;
            public String Nombre {get => nombre; set => nombre = value;}
            public int Edad {get => edad; set => edad = value;}
        } // Empleado;
    } // pro;
} // name;