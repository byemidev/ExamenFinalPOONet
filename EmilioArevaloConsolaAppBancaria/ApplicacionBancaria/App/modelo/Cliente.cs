using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ApplicacionBancaria.App.modelo
{
    public abstract class Cliente
    {
        //encapsulamiento clasico
        private String Nombre;
        private String DNI;
        private String Direccion;
        private DateTime FechaNacimiento;


        //constructor

        public Cliente() { 
            //vacio
        }

        public Cliente(String nombre, String dni, String direccion, DateTime fecha) { 
            this.Nombre = nombre;
            this.DNI = dni;
            this.Direccion = direccion;
            this.FechaNacimiento = fecha;
        }

        //constructor para mi sobreecarga de constructor en la herencia , solo necesito 3 parametros no 4
        public Cliente(String nombre, String dni, String direccion) {
            this.Nombre = nombre;
            this.DNI = dni;
            this.Direccion = direccion;
        }

        //sobreescritura ToString()
        public override String ToString()
        {
            return $"\nNombre: {this.getNombre()} \nDNI: {this.getDNI()} \n\t\tDireccion: {this.getDireccion()} \n\t\tFecha Nacimiento: {this.getFechaNacimiento().ToString()}";
        }

        //sobreescritura Equals
        public override bool Equals(object? obj)
        {
            if (obj != null) {  //el objeto a comparar fue instaciado es decir no es null
                return true;
            }else { 
                return false; //si no hay una instacia del objeto con el que se compara devuelve false 
            }
        }

        //getters
        public String getNombre () { return Nombre; }   

        public String getDireccion () { return Direccion; }

        public String getDNI() { return DNI; }

        public DateTime getFechaNacimiento() { return FechaNacimiento; }

        //Setters

        public void setNombre(String nombre) {
            this.Nombre = Nombre;
        }

        public void setDireccion(String direccion)
        {
            this.Direccion= direccion;
        }

        public void setDNI(String dni)
        {
            this.DNI = dni;
        }

        public void setFechaNacimiento(DateTime fecha)
        {
            this.FechaNacimiento = fecha;
        }

        //dos metodos para sobrecargar en hijo
        public abstract double getSaldo(); //para implementar por el hijo
        public abstract double getSaldo(double tasainteres); //para implementar por el hijo
    }
}
