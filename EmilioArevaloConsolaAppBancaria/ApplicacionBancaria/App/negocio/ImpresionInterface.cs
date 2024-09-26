using ApplicacionBancaria.App.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicacionBancaria.App.negocio
{
    public interface ImpresionInterface 
        //imprimirCualquierCuenta cuenta generacion -> no hago tres metodos por que el primero ya hace los dos primeros
        //, acepta el objeto cualquier tipo y ademas tambien imprime por pantalla
    {
        public void ImpresionConsola(int type, CuentaAhorro a, CuentaNomina n);
        public Task<bool> ImpresionTxt(int type, CuentaAhorro a, CuentaNomina n);
    }
}
