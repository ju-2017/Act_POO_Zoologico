# Act_POO_Zoologico

using System;

namespace Zoologico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BIENVENIDOS AL ZOOLOGICO
            
            int jaulas = 400;
            int tigres = 5;
            int aves = 10;
            int peses = 300;

            string veterinarios = "Juan y Yezenia";
            string cuidadores = "Jose y Melissa";
            long salario_veterinarios = 2500000;
            long salario_cuidadores = 1500000;

            int carne = 300;

            int costo_entradas = 25000;
            int perso_permitido = 1000;

            int cc_juan = 10020307;
            int cc_yeze = 10270976;

            int boleta = 1000;

            var numjaulas = new Operaciones(){

                jaulas_ = jaulas
            };

            numjaulas.jau(numjaulas.jaulas_);

            var numanimals = new Operaciones(){

                tigres_ = tigres,
                aves_ = aves,
                peses_ = peses
            };

            numanimals.animals(numanimals.tigres_, numanimals.aves_, numanimals.peses_);

            var funciones = new Operaciones(){

                veterinarios_ = veterinarios,
                cuidadores_ = cuidadores,
                sueldo_vet = salario_veterinarios,
                sueldo_cuid = salario_cuidadores
            };

            funciones.roles(funciones.veterinarios_, funciones.cuidadores_, funciones.sueldo_vet, funciones.sueldo_cuid);

            var alimento = new Operaciones(){

                carne_ = carne
            };

            alimento.comida(alimento.carne_);

            var ingreso = new Operaciones(){

                entradas = costo_entradas,
                permitido = perso_permitido

            };

            ingreso.logistica(ingreso.entradas, ingreso.permitido);

            do
            {

            System.Console.WriteLine("Buenos días por favor ingrese su Cedula");
                
             CC = Convert.ToInt32(Console.ReadLine());
            

                
            } while (cc != cc_juan && cc != cc_yeze);

            var ingresocc = new Operaciones(){

                cc_ = cc,
                cc_juan_ = cc_juan,
                cc_yeze_ = cc_yeze
            };

            ingresocc.pregunta(ingresocc.cc_, ingresocc.cc_juan_, ingresocc.cc_yeze_);

            do
            {
                System.Console.WriteLine("ingrese la boleta");
                boleta = Convert.ToInt32(Console.ReadLine());
            } while (boleta < 1000);

            var aforo = new Operaciones(){

                boleta_ = boleta


            };

            aforo.pregunta2(aforo.boleta_);

            
   














        }
    }
}
