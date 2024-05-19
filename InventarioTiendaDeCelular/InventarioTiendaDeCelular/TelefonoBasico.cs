using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioTiendaDeCelular
{
    internal class TelefonoBasico : Telefono
    {

        //Propiedades especificas de un telefono basico

        public bool TieneRadioFM { get; set; }

        public bool TieneLinterna { get; set; }


        //Metodo para ingresar datos de telefonos basicos

        public void RegistrarTelefonoBasico()
        {

            Console.Write("Ingrese la marca: ");
            this.Marca = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Ingrese el modelo: ");
            this.Modelo = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Ingrese el precio: ");
            this.Precio = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Ingrese el stock: ");  
            this.Stock = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("¿Tiene radio Fm?: ");
            this.TieneRadioFM = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine();
            Console.Write("¿Tiene linterna?: ");
            this.TieneLinterna = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine();

        }


        //Metodo para mostrar informacion especifica y llamar el metodo con informacion en comun

        public void MostrarInformacionBasica()
        {

            //Creamos operadores ternarios ubicando la condicion dentro de parentesis; si es true cumplira con la primera respuesta,
            //si es false cumplicara con la segunda respuesta

            string tieneRadio = (this.TieneRadioFM) ? "Si tiene radio" : "No tiene radio";  

            string tieneLinterna = (this.TieneLinterna) ? "Si tiene linterna" : "No tiene Linterna";

            this.MostrarInformacion();

            Console.WriteLine($"Tiene radio FM ? : {tieneRadio} \n" +
                              $"Tiene linterna ? : {tieneLinterna}");
            Console.WriteLine();

        }

    }
}
