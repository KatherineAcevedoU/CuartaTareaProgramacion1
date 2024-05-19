using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace InventarioTiendaDeCelular
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int opcion = 0;
            int repeticiones = 0; //Declaro esta variable inicializandola en 0, para que valide el numero de intentos al ingresar mal un dato
            string tipoTelefono;

            //Creacion del espacio en memoria para los vectores de las diferentes clases con un tamaño maximo de 5

            TelefonoInteligente[] registroTelefonoInteligente = new TelefonoInteligente[5];
            TelefonoBasico[] registroTelefonoBasico = new TelefonoBasico[5];


            do
            {
                while (repeticiones < 3) {

                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine("Bienvenido al sistema de inventario de telefonos");
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine();
                    Console.WriteLine("                 ---MENU---                     ");
                    Console.WriteLine("   1   ->     Registrar un telefono             ");
                    Console.WriteLine("   2   ->     Mostrar telefonos registrados     ");
                    Console.WriteLine("   3   ->     Stock de un telefono              ");
                    Console.WriteLine("   4   ->     Salir                             ");
                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine();

                    try{

                        Console.Write("Ingrese la opcion que desea: ");
                        opcion = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();

                        switch (opcion)
                        {

                            case 1:

                                Console.WriteLine("..................................");
                                Console.WriteLine("Usted eligio registrar un telefono");
                                Console.WriteLine("..................................");
                                Console.WriteLine();
                                Console.WriteLine("¿Que tipo de telefono desea registrar?");
                                Console.Write("Telefono Inteligente o Telefono Basico : ");
                                tipoTelefono = Console.ReadLine();
                                Console.WriteLine();

                                if (tipoTelefono == "Telefono Inteligente")
                                {

                                    //Este for permite rrecorer todo el vector de los telefonos inteligentes

                                    for (int i = 0; i < registroTelefonoInteligente.Length; i++)
                                    {

                                        Console.WriteLine("Telefono # : " + (i + 1));
                                        registroTelefonoInteligente[i] = new TelefonoInteligente();
                                        registroTelefonoInteligente[i].RegistrarTelefonoInteligente(); //Este objeto me permite tener acceso al metodo registrar
                                                                                                      //de la clase TelefonoInteligente

                                    }

                                }
                                else if (tipoTelefono == "Telefono Basico")
                                {

                                    //Este for permite rrecorer todo el vector de los telefonos basicos

                                    for (int i = 0; i < registroTelefonoBasico.Length; i++)
                                    {

                                        Console.WriteLine("Telefono # : " + (i + 1));
                                        registroTelefonoBasico[i] = new TelefonoBasico();
                                        registroTelefonoBasico[i].RegistrarTelefonoBasico(); //Este objeto me permite tener acceso al metodo registrar
                                                                                            //de la clase TelefonoBasico

                                    }

                                }

                                break;

                            case 2:

                                Console.WriteLine("..................................");
                                Console.WriteLine("Usted eligio mostrar los telefonos");
                                Console.WriteLine("..................................");
                                Console.WriteLine();
                                Console.WriteLine("¿Que tipo de telefono desea mostrar?");
                                Console.Write("Telefono Inteligente o Telefono Basico : ");
                                tipoTelefono = Console.ReadLine();
                                Console.WriteLine();

                                if (tipoTelefono == "Telefono Inteligente")
                                {

                                    Console.WriteLine("----------------------");
                                    Console.WriteLine("TELEFONOS INTELIGENTES");
                                    Console.WriteLine("----------------------");
                                    Console.WriteLine();

                                    for (int i = 0; i < registroTelefonoInteligente.Length; i++) 
                                    {

                                        Console.WriteLine("Telefono # : " + (i + 1));
                                        Console.WriteLine();

                                        registroTelefonoInteligente[i].MostrarInformacionInteligente(); //El objeto registroTelefonoInteligente[i], me permite
                                                                                                       //tener acceso al metodo que muestra los datos de la clase TelefonoInteligente

                                    }


                                }
                                else if (tipoTelefono == "Telefono Basico")
                                {

                                    Console.WriteLine("-----------------");
                                    Console.WriteLine("TELEFONOS BASICOS");
                                    Console.WriteLine("-----------------");
                                    Console.WriteLine();

                                    for (int i = 0; i < registroTelefonoBasico.Length; i++)
                                    {

                                        Console.WriteLine("Telefono # : " + (i + 1));
                                        Console.WriteLine();

                                        registroTelefonoBasico[i].MostrarInformacionBasica(); //El objeto registroTelefonoBasico[i], me permite
                                                                                              //tener acceso al metodo que muestra los datos de la clase TelefonoBasico

                                    }

                                }

                                break;

                            case 3:

                                Console.WriteLine("....................................");
                                Console.WriteLine("Usted eligio el STOCK de un telefono");
                                Console.WriteLine("....................................");
                                Console.WriteLine();
                                Console.WriteLine("¿Que tipo de telefono desea consultar?");
                                Console.Write("Telefono Inteligente o Telefono Basico : ");
                                tipoTelefono = Console.ReadLine();
                                Console.WriteLine();

                                Console.Write("Ingrese el modelo por el que va a consultar: ");
                                string modeloConsultado = Console.ReadLine();
                                Console.WriteLine();

                                if (tipoTelefono == "Telefono Inteligente")
                                {


                                    for (int i = 0; i < registroTelefonoInteligente.Length; i++)
                                    {

                                        if (registroTelefonoInteligente[i].Modelo == modeloConsultado) //Con la ayuda del objeto tengo acceso a la propiedad Modelo, esto me permite 
                                                                                                      //igualarlo al modelo por el que esta consultando el usuario                                                             
                                        {

                                            //Esto me permite mostrar la informacion del modelo por el que se esta consultando

                                            Console.WriteLine("--------- INFORMACION ----------");
                                            Console.WriteLine("Disponible del " + modeloConsultado + " es : " + registroTelefonoInteligente[i].Stock);
                                            Console.WriteLine();
                                            registroTelefonoInteligente[i].MostrarInformacionInteligente();
                                            Console.WriteLine("--------------------------------");

                                        }

                                    }

                                }
                                else if (tipoTelefono == "Telefono Basico")
                                {

                                    for (int i = 0; i < registroTelefonoBasico.Length; i++)
                                    {

                                        if (registroTelefonoBasico[i].Modelo == modeloConsultado) //Con la ayuda del objeto tengo acceso a la propiedad Modelo, esto me permite 
                                                                                                  //igualarlo al modelo por el que esta consultando el usuario    
                                        {

                                            //Esto me permite mostrar la informacion del modelo por el que se esta consultando

                                            Console.WriteLine("--------- INFORMACION ----------");
                                            Console.WriteLine("Disponible del " + modeloConsultado + " es : " + registroTelefonoBasico[i].Stock);
                                            Console.WriteLine();
                                            registroTelefonoBasico[i].MostrarInformacionBasica();
                                            Console.WriteLine("--------------------------------");

                                        }

                                    }

                                }

                                break;

                            case 4:

                                Console.WriteLine("Saliendo del inventario");
                                Console.WriteLine();

                                break;


                            default:

                                Console.WriteLine("Incorrecto");

                                break;

                        }

                        //Validacion en el caso de que la opcion ingresada no coincida con la del menu

                        if (opcion > 0 && opcion <= 4)  
                        {

                            break;

                        }
                        else
                        { 
                            repeticiones++;  //Esto me permite que se aumente el numero de repeticiones dandome una nueva oportunidad al ingresar al menu

                            if (repeticiones < 3)
                            {

                                Console.WriteLine("Este dato no existe.");
                                Console.WriteLine();

                            }
                            else if (repeticiones == 3) //Si el numero de repeticiones es igual a 3, entonces ya no me mostrara el menu
                            {

                                Console.WriteLine("Error, se intento varias veces!");
                                Console.WriteLine();

                            }

                        }

                    } 
                    catch(Exception e){  //Esta exepcion abarca todos las exepciones que pueden ocurrir al momento de ingresar mal un dato

                        repeticiones++;

                        if (repeticiones < 3)
                        {

                            Console.WriteLine();
                            Console.WriteLine("Este dato no es valido.");
                            Console.WriteLine();

                        }
                        else if (repeticiones == 3)
                        {

                            Console.WriteLine("Error, se intento varias veces!");
                            Console.WriteLine();

                        }

                    }

                }


            } while (opcion != 4);  //Este menu se repite mientras la opcion sea diferente a 4

            //Metodo para salir de la aplicacion
            Console.Clear();
             
        }
    }
}
