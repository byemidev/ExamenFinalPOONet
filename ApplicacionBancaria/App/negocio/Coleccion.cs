using ApplicacionBancaria.App.modelo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicacionBancaria.App.negocio
{
    internal class Coleccion  //para el final 
    {
        public List<Cliente> clientes = new List<Cliente>();

        public Coleccion() {
            
        }

        public void ordenarPorNombreFechaNacimiento() {
        
            this.clientes.OrderBy(cuenta => cuenta.getNombre())
                                 .ThenBy(cuenta => cuenta.getFechaNacimiento())
                                 .ToList();
            Console.WriteLine("Ordenado");
        }

        public void imprimirColecion()
        {
            this.clientes.ForEach( cuenta => Console.WriteLine(cuenta.ToString()));
        }
    }
}
