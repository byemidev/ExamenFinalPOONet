using ApplicacionBancaria.App.modelo;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ApplicacionBancaria.App.negocio
{
    public class Imprimir : ImpresionInterface //imprimirCualquier cuenta implementacion
    {

        //impresion consola
        public void imprimirAhorroConsola(CuentaAhorro cAhorro)
        {
            Console.WriteLine(cAhorro.ToString());
        }

        public void imprimirNominaConsola(CuentaNomina cNomina)
        {
            Console.WriteLine(cNomina.ToString());
        }
        public void ImpresionConsola(int type, CuentaAhorro a, CuentaNomina n){ //imprimir cualquir cuenta indicando el typo

            if (type == 1 )
            {
                imprimirAhorroConsola(a);
            }
            else if(type == 2) {
                imprimirNominaConsola(n);
            }
        }

        //impresion txt
        public async void imprimirAhorroAsync(CuentaAhorro a) {
            using (StreamWriter writer = File.CreateText("CuentasAhorro.txt"))
            {
                Console.WriteLine("imprimiento async ahorro txt");
                await writer.WriteLineAsync(a.ToString());
            }
        }

        public async void imprimirNominaAsync(CuentaNomina n)
        {
            using (StreamWriter writer = File.CreateText("CuentasNomina.txt"))
            {
                Console.WriteLine("imprimiento async nomina txt");
                await writer.WriteLineAsync(n.ToString());
            }
        }

        
        public async Task<bool> ImpresionTxt(int type, CuentaAhorro a, CuentaNomina n) {
            try
            {
                if (type == 1)
                {
                    imprimirAhorroAsync(a);
                }
                else if (type == 2)
                {
                    imprimirNominaAsync(n);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            finally {
                Console.WriteLine("impresion txt finalizado"); // se ejecuta siempre
            }
            
            return false;
        }
    }
}
