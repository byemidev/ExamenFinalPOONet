using ApplicacionBancaria.App.modelo;
using ApplicacionBancaria.App.negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicacionBancaria.App.presentacion
{
    public class presentacion
    {
        public presentacion() {

            //instanciacion de cuenta ahorro
            
            CuentaAhorro ahorroA = new CuentaAhorro();
            ahorroA.setNombre("Aahorro");
            ahorroA.setDNI("dni");
            ahorroA.setDireccion("dir");
            ahorroA.setFechaNacimiento(DateTime.Now);
            ahorroA.setIngresos(100.25d);
            ahorroA.setRetiros(50.2);
            ahorroA.setSaldoAnterior(400.84);
            
            //instanciacion de cuenta nomina

            CuentaNomina nominaB = new CuentaNomina();
            nominaB.setNombre("BNomina");
            nominaB.setDNI("dni");
            nominaB.setDireccion("dir");
            nominaB.setFechaNacimiento(DateTime.Now);
            nominaB.setIngresos(100.25d);
            nominaB.setRetiros(80.2);
            nominaB.setSaldoAnterior(8000.84);
            nominaB.setComision(45.2);
            nominaB.setSS("numero seguridad social");
            nominaB.setEmpresa("empresa");



            CuentaAhorro ahorroC = new CuentaAhorro();
            ahorroC.setNombre("Cahorro");
            ahorroC.setDNI("dni");
            ahorroC.setDireccion("dir");
            ahorroC.setFechaNacimiento(DateTime.Now);
            ahorroC.setIngresos(100.25d);
            ahorroC.setRetiros(50.2);
            ahorroC.setSaldoAnterior(400.84);

            //instanciacion de cuenta nomina

            CuentaNomina nominaD = new CuentaNomina();
            nominaD.setNombre("DNomina");
            nominaD.setDNI("dni");
            nominaD.setDireccion("dir");
            nominaD.setFechaNacimiento(DateTime.Now);
            nominaD.setIngresos(100.25d);
            nominaD.setRetiros(80.2);
            nominaD.setSaldoAnterior(8000.84);
            nominaD.setComision(45.2);
            nominaD.setSS("numero seguridad social");
            nominaD.setEmpresa("empresa");


            //instanciacion implementacion de interfaz

            Console.WriteLine("esta funcionando");

                //imprimir consola
            Imprimir impresor = new Imprimir();

            impresor.ImpresionConsola(1, ahorroA, nominaB); //impresion ahorro consola
            impresor.ImpresionConsola(2, ahorroC, nominaD); //impresion nomina consola

            impresor.ImpresionTxt(1, ahorroA, nominaB);
            impresor.ImpresionTxt(2, ahorroC, nominaD);

            Coleccion colecion = new Coleccion();  
            colecion.clientes.Add(ahorroC);
            colecion.clientes.Add(nominaD);
            colecion.clientes.Add(ahorroA);
            colecion.clientes.Add(nominaB);

            colecion.imprimirColecion();

            colecion.ordenarPorNombreFechaNacimiento();

            colecion.imprimirColecion();

        }
    }
}
