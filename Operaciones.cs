# Act_POO_Zoologico

using System;

namespace Zoologico
{
    class Operaciones
    {

        public int jaulas_ { set; };

        public int tigres_ { set; };
        public int aves_ { set; };
        public int peses_ { set; };

        public string veterinarios_ { set; };
        public string cuidadores_ { set; };
        public long sueldo_vet { set; };
        public long sueldo_cuid { set; };

        public int carne_ { set; };

        public int entradas { set; };
        public int permitido { set; };

        public int cc_ { get; set; };
        public int cc_juan_ {get; set; };
        public int cc_yeze_ { get; set; };

        int boleta_ { get; set; };
    






        public void jau(int j){

            int resultjau = j;

            Console.WriteLine($"el zoologico cuenta con: {resultjau} jaulas");
        }

        public void animals(int tig, int av, int pes ){

            int resulttig = tig;
            int resultaves = av;
            int resultpeses = pes;

            Console.WriteLine($"Cuenta con {resulttig} tigres, {resultaves} aves, y {resultpeses} peses");
        }

        public void roles( string vete, string cuid, long sv, long sc){

            string resultveterinarios = vete;
            string resultcuidadores = cuid;
            long resultsv = sv;
            long resultsc = sc;


            Console.WriteLine($"sus veterinarios de cabecera son: {resultveterinarios}, los cuidadores son: {resultcuidadores} cuyos sueldos son: {resultveterinarios} {resultsv}, {resultcuidadores} {resultsc}");
        }

        public void comida( int c){

            int resultc = c;

            Console.WriteLine($"Diariamente los tigres consumen: {resultc} kilos de carne");

        }

        public void logistica(int entr, int perm){

            int resultentr = entr;
            int resultperm = perm;

            Console.WriteLine($"El costo de las entradas es de {resultentr} y el aforo permitido es de: {resultperm} personas");
        }

        public void pregunta( int idt, int cj, int cy){

            int resultidt = idt;
            int resultcj = cj;
            int resultcy = cy;

            if(cc== cc_juan)
            {
                System.Console.WriteLine("Buenos dias doctor Juan, puede pasar");

                if(cc == cc_yeze)
                {

                    System.Console.WriteLine("Buenos días doctora Yezenia puede pasar");
                }

            }
            else
            {
                System.Console.WriteLine("su cc no es válido, no puedes pasar");
            }

        }
        prublic void pregunta2(int b){

            int resultb = b;

            if(boleta < 1000)
            {
                System.Console.WriteLine("puede pasar");
            }
            else
            {
                System.Console.WriteLine("El Zoologico ya se encuentra en su aforo completo, lo esperamos en una proxima ocasion");
            }


        }

        int[] jaulas_almac = {300, 100, 30, 90, 150};
        for(int jaulas = 0; jaulas < jaulas_almac.Length; jaulas++)
        {
            System.Console.WriteLine("jaula " + (jaulas + 1) + " es alamcen " + jaulas_almac[jaulas]);


        }

        







    }

}
