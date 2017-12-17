using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //Esta exepcion fue utilizada para evitar errores
            try 
            {
                //Lo siguiente fue utilizado para establecer un tamano especifico para la consola
                int width = 100;
                int height = 14;
                Console.SetWindowSize(width, height);

                //Lo siguiente fue utilizado para establecer el color de las letras
                    Console.ForegroundColor = ConsoleColor.White;
                //arreglo que sera impreso al finalizar
                    int[] number = new int[9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                    int cerosiniciales = 0;

                    // El siguiente codigo fue empleado para el titulo y hacer un borde alrededor con asteriscos
                    Console.WriteLine("***************************************************************************************************");
                    Console.WriteLine("*                                                                                                 *");

                    Console.Write("*                                          ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Libro de Numeros");
                    Console.WriteLine("                                       *");
                    Console.WriteLine("*                                                                                                 *");
                    Console.WriteLine("***************************************************************************************************");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("\n");
                    Console.WriteLine("Con este programa usted podra traducir números escritos en palabras a su representacion numerica.");
                    Console.Write("Por favor ingrese el numero a traducir: ");

                    ////Usamos el siguiente codigo para convertir el input a un arreglo
                    char[] delimiterChars = { ' ', ',', '.', ':', '\t' };
                    Console.ForegroundColor = ConsoleColor.White;
                    string numero = Console.ReadLine();
                    string[] letras = numero.Split(delimiterChars);

                    //Empleamos la fucion foreach para traducir una palabra a su forma numericaa
                    foreach (string s in letras)
                    {
                        
                        
                        if (letras[0] == "cero")
                        {
                            Console.Write("su numero es: ");
                            Console.Write("0");
                            Console.ReadKey();
                            Console.Clear();
                            Main(null);
                        }

                        else if (s == "uno")
                        {
                            number[8] = 1;
                        }

                        else if (s == "dos")
                        {
                            number[8] = 2;
                        }

                        else if (s == "tres")
                        {
                            number[8] = 3;
                        }

                        else if (s == "cuatro")
                        {
                            number[8] = 4;
                        }

                        else if (s == "cinco")
                        {
                            number[8] = 5;
                        }

                        else if (s == "seis")
                        {
                            number[8] = 6;
                        }

                        else if (s == "siete")
                        {
                            number[8] = 7;
                        }

                        else if (s == "ocho")
                        {
                            number[8] = 8;
                        }

                        else if (s == "nueve")
                        {
                            number[8] = 9;
                        }

                        else if (s == "diez")
                        {
                            number[7] = 1;
                        }

                        else if (s == "once")
                        {
                            number[8] = 1;
                            number[7] = 1;
                        }

                        else if (s == "doce")
                        {
                            number[8] = 2;
                            number[7] = 1;
                        }

                        else if (s == "trece")
                        {
                            number[8] = 3;
                            number[7] = 1;
                        }

                        else if (s == "catorce")
                        {
                            number[8] = 4;
                            number[7] = 1;
                        }

                        else if (s == "quince")
                        {
                            number[8] = 5;
                            number[7] = 1;

                        }

                        else if (s == "dieciseis")
                        {
                            number[8] = 6;
                            number[7] = 1;
                        }

                        else if (s == "diecisiete")
                        {
                            number[8] = 7;
                            number[7] = 1;
                        }

                        else if (s == "dieciocho")
                        {
                            number[8] = 8;
                            number[7] = 1;
                        }

                        else if (s == "diecinueve")
                        {
                            number[8] = 9;
                            number[7] = 1;
                        }

                        else if (s == "veinte")
                        {
                            number[8] = 0;
                            number[7] = 2;
                        }
                        else if (s == "veintiuno")
                        {
                            number[8] = 1;
                            number[7] = 2;
                        }

                        else if (s == "veintidos")
                        {
                            number[8] = 2;
                            number[7] = 2;
                        }

                        else if (s == "veintitres")
                        {
                            number[8] = 3;
                            number[7] = 2;
                        }
                        else if (s == "veinticuatro")
                        {
                            number[8] = 4;
                            number[7] = 2;
                        }

                        else if (s == "veinticinco")
                        {
                            number[8] = 5;
                            number[7] = 2;
                        }

                        else if (s == "veintiseis")
                        {
                            number[8] = 6;
                            number[7] = 2;
                        }
                        else if (s == "veintisiete")
                        {
                            number[8] = 7;
                            number[7] = 2;
                        }

                        else if (s == "veintiocho")
                        {
                            number[8] = 8;
                            number[7] = 2;
                        }
                        else if (s == "veintinueve")
                        {
                            number[8] = 9;
                            number[7] = 2;
                        }
                        else if (s == "treinta")
                        {
                            number[7] = 3;
                        }

                        else if (s == "cuarenta")
                        {
                            number[7] = 4;
                        }

                        else if (s == "cincuenta")
                        {
                            number[7] = 5;
                        }

                        else if (s == "sesenta")
                        {
                            number[7] = 6;
                        }

                        else if (s == "setenta")
                        {
                            number[7] = 7;
                        }

                        else if (s == "ochenta")
                        {
                            number[7] = 8;
                        }

                        else if (s == "noventa")
                        {
                            number[7] = 9;
                        }

                        else if (s == "cien")
                        {
                            number[6] = 1;
                        }

                        else if (s == "ciento")
                        {
                            number[6] = 1;
                        }

                        else if (s == "doscientos")
                        {
                            number[6] = 2;
                        }

                        else if (s == "trescientos")
                        {
                            number[6] = 3;
                        }

                        else if (s == "cuatrocientos")
                        {
                            number[6] = 4;
                        }

                        else if (s == "quinientos")
                        {
                            number[6] = 5;
                        }

                        else if (s == "seiscientos")
                        {
                            number[6] = 6;
                        }

                        else if (s == "setecientos")
                        {
                            number[6] = 7;
                        }

                        else if (s == "ochocientos")
                        {
                            number[6] = 8;
                        }

                        else if (s == "novecientos")
                        {
                            number[6] = 9;
                        }

                        else if (s == "mil")
                        {
                            number[5] = number[8];
                            number[4] = number[7];
                            number[3] = number[6];
                            number[8] = 0;
                            number[7] = 0;
                            number[6] = 0;
                        }

                        
                        else if (s == "millones")
                        {
                            number[2] = number[8];
                            number[1] = number[7];
                            number[0] = number[6];
                            number[8] = 0;
                            number[7] = 0;
                            number[6] = 0;
                        }

                        else if (letras[0] == "un" && letras[1] == "millon")
                        {
                            number[2] = 1;
                        }
                        else if (letras[0]=="baraja")
                        {
                            Environment.Exit(0);
                        }
                        else if (s == "y")
                        {
             
                        }
                        else if (letras[0] == "negativo")
                        {
                            
                        }

                            //En caso de que lo escrito por el usuario no produzca una forma numerica fue utilizado else
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Ha ocurrido un error. Por favor asegure de haber escrito el numero correctamente");
                            Console.ReadKey();
                            Console.Clear();
                            Main(null);
                                
                        }
                    }
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("\n");
                    Console.Write("su numero es: ");
                    if (letras[0] == "negativo")
                    {
                        Console.Write("-");
                    }
                    else if (letras[0] == "mil")
                    {
                        number[5] = 1;
                    }

                    //Utilizamos la funcion foreach para imprimir todos los elementos del arreglo con los numeros
                    foreach (int s in number)
                    {
                        cerosiniciales += s;
                        //Esta condicion la empleamos para evitar imprimir ceros a la izquierda. Ej: 000000000015 
                        if (cerosiniciales != 0)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            System.Console.Write(s);
                        }
                    }

                    //Ademas, para volver al inicio del programa utilizamos console.clear y main(null)
                    Console.ReadKey();
                    Console.Clear();
                    Main(null);
                }
            // Finalmente, se empleo catch para evitar cualquier error inesperado
            catch (Exception e)
            {
                Console.WriteLine("An error occurred: '{0}'", e);
                Main(null);
            }
        }
    }
}
