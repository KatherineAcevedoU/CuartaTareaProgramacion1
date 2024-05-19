using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioTiendaDeCelular
{
    internal class Telefono
    {

        //Propiedades en comun de los telefonos
        public string Marca { get; set; }

        public string Modelo { get; set; }

        public decimal Precio { get; set; }

        public int Stock { get; set; }  //El stock significa la cantidad de telefonos de un modelo


        //Metodo para mostrar la informacion en comun de un telefono, ya sea inteligente o basico

        public void MostrarInformacion()
        {

            Console.WriteLine($"Marca: {Marca} \n" +
                              $"Modelo: {Modelo} \n" +
                              $"Precio: ${Precio} \n" +
                              $"Stock: {Stock} ");
             
        }



    }
}
