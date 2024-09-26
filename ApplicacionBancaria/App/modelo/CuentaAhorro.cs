using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ApplicacionBancaria.App.modelo
{
    public class CuentaAhorro : Cliente
    {
        //properties
        private double saldoAnterior;
        private double ingresos;
        private double retiros;

        //constructores

        public CuentaAhorro() : base() {
            //vacio        
        }

        //readonly (?) aux = para acceder a datos de la cuenta en tiempo de ejecucion 
        public static readonly String nombreTitular = String.Empty;
        public static readonly String dniTitular = String.Empty;
        public static readonly String direccionTitular = String.Empty;

        //aux
        private double saldo;

        public CuentaAhorro(double saldo) : base(nombre: nombreTitular, dni: dniTitular, direccion: direccionTitular ) { 
            this.saldo = saldo;
        }

        
        //sobreecarga de metodo padre en hijo --> implementacion del metodo
        public override double getSaldo() //no tested
        {
            this.saldo = this.saldoAnterior;

            return this.saldo += (this.getIngresos() - this.getRetiros()) ; 
        }

        //sobreecarga de metodo padre en hijo --> implementacion del metodo
        public override double getSaldo(double tasaInteres) {
            this.saldo = this.saldoAnterior;

            return (this.saldo * tasaInteres) + (this.getIngresos() - this.getRetiros());
        }

        //sobrecarga de metodos ToString() , Equals()
        public override String ToString()
        {
            return base.ToString() +  $"\n\t\tSaldo anterior: {this.getSaldoAnterior().ToString()} \n\t\tImgresos: {this.getIngresos().ToString()} \n\t\tRetiros: {this.getRetiros().ToString()}"; // hace referencia a la primera sobrecarga en el padre
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);    // hace referencia a la primera sobreecarga en el padre
        }

        //getters 

        public double getSaldoAnterior() { return this.saldoAnterior; } 
        
        public double getRetiros() {    return this.retiros; }

        public double getIngresos() { return this.ingresos; }

        //setters

        public void setSaldoAnterior(double saldo) {
            this.saldoAnterior = saldo; 
        }


        public void setIngresos(double ingresos)
        {
            this.ingresos = ingresos;
        }

        public void setRetiros(double retiros)
        {
            this.retiros = retiros;
        }
    }
}
