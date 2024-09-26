using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicacionBancaria.App.modelo
{
    public class CuentaNomina : CuentaAhorro
    {
        private String SS;
        private String empresa;
        private double comision;
        


        public CuentaNomina() : base () { 
            //vacio
        }

        //readonly (?) aux = para acceder a datos de la cuenta en tiempo de ejecucion
        public static readonly double saldoTitular = 0.0d;

        public CuentaNomina(String ss, String empresa, double comision) : base(saldo: saldoTitular)
        { 
            this.SS = ss;
            this.empresa = empresa;
            this.comision = comision;
        }

        //getters
        public String getSS() { return this.SS; }
        public String getEmpresa() { return this.empresa; }
        public double getComision() { return this.comision; }


        public override double getSaldo()
        {
            return base.getSaldo() - this.getComisiones(); //deberia calcular la primera sobrecarga de getSaldo en Cuenta ahorro y despues restarle las comisiones
        }

        public double getComisiones() { 
           return this.getRetiros() * this.getComision();
        }

        //setters opcional por si necesito testear
        public void setSS(String ss) { 
            this.SS = ss;
        }

        public void setEmpresa(String empresa)
        {
            this.SS = empresa;
        }

        public void setComision(double comision)
        {
            this.comision = comision;
        }

    }
}
