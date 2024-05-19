using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioTiendaDeCelular
{
    internal class TelefonoInteligente : Telefono
    {

        //Propiedades especificas de un telefono inteligente

        public string SistemaOperativo { get; set;  }

        public int MemoriaRam { get; set; } //En GB


        //Metodo para ingresar datos de telefonos inteligentes

        public void RegistrarTelefonoInteligente()
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
            Console.Write("Ingrese el sistema operativo: ");
            this.SistemaOperativo = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Ingrese la memoria RAM en GB: ");
            this.MemoriaRam = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

        }


        
        //Metodo para mostrar informacion especifica y llamar el metodo con informacion en comun

        public void MostrarInformacionInteligente()
        {
            this.MostrarInformacion();

            Console.WriteLine($"Sistema operativo: {SistemaOperativo} \n" +
                              $"Memoria RAM: {MemoriaRam} GB");
            Console.WriteLine();

        }

    }

}
