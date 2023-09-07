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
                    if(Regex.IsMatch(nombre,@"^[A-Za-z]+$")){
                        Console.WriteLine($"Es correcto el nombre [Si/No]..¿?");
                        escrito = Console.ReadLine();
                        if(!string.IsNullOrWhiteSpace(escrito.Trim()) && escrito.Substring(0,1).Equals("S",StringComparison.OrdinalIgnoreCase)){
                            Console.WriteLine($"\nExcelente {Mayus(nombre)}..!\n");
                            break;
                        }else Console.WriteLine($"Tu respuesta es No..");
                    }else Console.WriteLine("Nombre incorrecto, vuelve a intentarlo por favor..!");
                } // while
                Console.WriteLine($"\nHola Bienvenido {Nombre = Mayus(nombre)}..!\n");
                //TODO : while end;
                //TODO : delegado;
                // bool? EsPar = null;
                string nEs,EOp,Salir;
                int NE,NN;
                int numEscrito;
                Random Azar = new Random();
                Delegado elDelegadoCuadrado = new Delegado((a,b) => a * a);
                Delegado elDelegadoSuma = new Delegado((a,b) => a + b);
                Delegado elDelegadoResta = new Delegado((a,b) => a - b);
                Delegado elDelegadoMulti = new Delegado((a,b) => a * b);
                Delegado elDelegadoDiv = new Delegado((a,b) => a / b);
                //TODO : while Operaciones;
                while(true){
                    Console.WriteLine($"\nElige que tipo de operación deseas realizar..¿?\n[Cuadrado \"!\", Suma \"+\", Resta \"-\", Multiplicación \"*\", División \"/\"]..¿?");
                    EOp = Console.ReadLine();
                    await Task.Delay(1000);
                    //TODO : Suma, Resta, Multiplicación, División, Cuadrado;
                    if(!string.IsNullOrWhiteSpace(EOp.Trim())){
                        if(EOp.Trim().Substring(0,1).Equals("C",StringComparison.OrdinalIgnoreCase) && !String.IsNullOrWhiteSpace(EOp) || EOp.Trim().Substring(0,1) == "!"){
                            Console.WriteLine($"Muy bien {Nombre}..! elegiste al \"Cuadrado\".\nEscribe a continuación el número para la operación.");
                            int.TryParse(nEs = Console.ReadLine(), out NE);
                            if(NE != 0) Console.WriteLine($"\nNúmero ejedido ({NE})\nMultiplicación: {NE} * {NE} = ({elDelegadoCuadrado(NE,NE)})\n");
                            // Console.WriteLine($"\nNúmeros ejedidos {(NE,Azar.Next(NE,NN = NE * 4))} azar: ({NN})\nMultiplicación: {NE} * {NN} = ({elDelegadoMulti(NE,NN)})\n");
                            else continue;
                        }else if(EOp.Trim().Substring(0,1).Equals("S",StringComparison.OrdinalIgnoreCase) && !String.IsNullOrWhiteSpace(EOp.Trim()) || EOp.Trim().Substring(0,1) == "+"){
                            Console.WriteLine($"Muy bien {Nombre}..! elegiste \"Suma\".\nEscribe a continuación el número para la operación.");
                            int.TryParse(nEs = Console.ReadLine(), out NE);
                            if(NE != 0) Console.WriteLine($"\nNúmeros ejedidos {(NE,Azar.Next(NE,NN = NE * 4))} azar: ({NN})\nSuma: {NE} + {NN} = ({elDelegadoSuma(NE,NN)})\n");
                            else continue;
                        }else if(EOp.Trim().Substring(0,1).Equals("R",StringComparison.OrdinalIgnoreCase) && !String.IsNullOrWhiteSpace(EOp.Trim()) || EOp.Trim().Substring(0,1) == "-"){
                            Console.WriteLine($"Muy bien {Nombre}..! elegiste \"Resta\".\nEscribe a continuación el número para la operación.");
                            int.TryParse(nEs = Console.ReadLine(), out NE);
                            if(NE != 0) Console.WriteLine($"\nNúmeros ejedidos {(Azar.Next(NE,NN = NE * 4),NE)} azar: ({NN})\nResta: {NN} - {NE} = ({elDelegadoResta(NN,NE)})\n");
                            else continue;
                        }else if(EOp.Trim().Substring(0,1).Equals("M",StringComparison.OrdinalIgnoreCase) && !String.IsNullOrWhiteSpace(EOp.Trim()) || EOp.Trim().Substring(0,1) == "*"){
                            Console.WriteLine($"Muy bien {Nombre}..! elegiste \"Multiplicación\".\nEscribe a continuación el número para la operación.");
                            int.TryParse(nEs = Console.ReadLine(), out NE);
                            if(NE != 0) Console.WriteLine($"\nNúmeros ejedidos {(NE,Azar.Next(NE,NN = NE * 4))} azar: ({NN})\nMultiplicación: {NE} * {NN} = ({elDelegadoMulti(NE,NN)})\n");
                            else continue;
                        }else if(EOp.Trim().Substring(0,1).Equals("D",StringComparison.OrdinalIgnoreCase) && !String.IsNullOrWhiteSpace(EOp.Trim()) || EOp.Trim().Substring(0,1) == "/"){
                            Console.WriteLine($"Muy bien {Nombre}..! elegiste \"División\".\nEscribe a continuación el número para la operación.");
                            int.TryParse(nEs = Console.ReadLine(), out NE);
                            if(NE != 0) Console.WriteLine($"\nNúmeros ejedidos {(Azar.Next(NE,NN = NE * 4),NE)} azar: ({NN})\nDivisión: {NN} / {NE} = ({elDelegadoDiv(NN,NE)})\n");
                            else continue;
                        }else Console.WriteLine($"\nNo se registró un dato.\nReintenta nuevamente..!\n");
                    }else continue;
                    //TODO : salir;
                    Console.WriteLine($"{Nombre}.. Deseas continuar con las operaciones [Si/No]..¿?");
                    Salir = Console.ReadLine();
                    if(!String.IsNullOrWhiteSpace(Salir) && Salir.Substring(0,1).Equals("N",StringComparison.OrdinalIgnoreCase)) break;
                    else Console.WriteLine($"Bueno {Nombre}.. continúa con las operaciones..!");
                    //TODO : salir end;
                } //TODO : while Operaciones end;
                //TODO : delegado end;
                //TODO : Pares;
                //TODO : Predicate;
                Predicate<Empleado> PreExisteNomb = new Predicate<Empleado>(ExisteNomb);
                Predicate<Empleado> PrediEdadMayor = new Predicate<Empleado>(EdadMayor);
                List<Empleado> personas = new List<Empleado>();

                Empleado P1 = new Empleado();
                P1.Nombre = "Maria";
                P1.Edad = 27;

                Empleado P2 = new Empleado();
                P2.Nombre = "Juan";
                P2.Edad = 32;

                Empleado P3 = new Empleado();
                P3.Nombre = "Ana";
                P3.Edad = 17;

                personas.AddRange(new Empleado[] {P1,P2,P3});

                Console.WriteLine($"\nVista previa de Lista Empleados: [{String.Join(",",personas)}]\n");

                bool ExisteUser = personas.Exists(PreExisteNomb);
                bool EsMayor = personas.Exists(PrediEdadMayor);

                foreach(Empleado per in personas) Console.WriteLine($"Empleado {per.Nombre} Edad: {per.Edad}");

                Console.WriteLine($"\nExiste el usuario \"Juan\"..¿? {ExisteUser}\n");
                // foreach(Empleado p in personas) Console.WriteLine($"{p.Nombre} de {p.Edad} años. Es Mayor de edad.. ¿? {PrediEdadMayor(p)}.");
                personas.ForEach(p => Console.WriteLine($"{p.Nombre} de {p.Edad} años. Es Mayor de edad.. ¿? {PrediEdadMayor(p)}."));
                Console.WriteLine($"");

                //TODO : Predicate end;
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
                //TODO : Resultado final;
                using(archivo = new StreamWriter(@"C:\Users\guillermo.giachetti\Desktop\NotaRapida.txt", append: false)){
                archivo.WriteLine($"Imprime el Resultado para {Mayus(nombre)}.\nVista final de la lista simple: [{String.Join(",",lista)}]\n\nVista final de la lista números pares: [{String.Join(",",listaPares)}]\n\nHasta Luego {Mayus(nombre)} y gracias por participar\n.. 😉 ..\n");
                }
                //TODO : Resultado final end;
                await Task.Delay(2000);
                Console.WriteLine($"\nEl Programa se está ejecutando con éxito..!\n");
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
        delegate int Delegado(int a, int b);
        public static bool Pares(int num){
            if(num % 2 == 0) return true;
            else return false;
        } // pares;
        static bool ExisteNomb(Empleado emp){
            if(emp.Nombre.Equals("juan",StringComparison.OrdinalIgnoreCase)) return true;
            else return false;
        }
        static bool EdadMayor(Empleado emp){
            if(emp.Edad >= 18) return true;
            else return false;
        }
        public class Empleado{
            private string nombre;
            private int edad;
            public String Nombre {get => nombre; set => nombre = value;}
            public int Edad {get => edad; set => edad = value;}
        } // Empleado;
    } // pro;
} // name;