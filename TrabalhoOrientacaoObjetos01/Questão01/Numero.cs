using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoOrientacaoObjetos01.Questão01
{
    public class Numero
    {

        public double Valor;


        public string ObterDecimalPorExtenso()
        {
            int numeroPositivo = 0;
            var numeroDecimalExtenso = "";

            if (Valor * 100 > numeroPositivo) 
            {

                numeroDecimalExtenso = ObterDezenaPorExtenso() + ObterUnidadePorExtenso();

            }

            return numeroDecimalExtenso;

        }








        public string ObterUnidadePorExtenso()
        {

            string[] unidadesExtenso = new string[9];

            string unidadeConvertida = "";


            unidadesExtenso[0] = "Um";
            unidadesExtenso[1] = "Dois";
            unidadesExtenso[2] = "Três";
            unidadesExtenso[3] = "Quatro";
            unidadesExtenso[4] = "Cinco";
            unidadesExtenso[5] = "Seis";
            unidadesExtenso[6] = "Sete";
            unidadesExtenso[7] = "Oito";
            unidadesExtenso[8] = "Nove";

            if (Valor == 1)
            {

                unidadeConvertida = unidadesExtenso[0];


            }
            else if (Valor == 2)
            {
                unidadeConvertida = unidadesExtenso[1];

            }
            else if (Valor == 3)
            {
                unidadeConvertida = unidadesExtenso[2];

            }
            else if (Valor == 4)
            {
                unidadeConvertida = unidadesExtenso[3];

            }
            else if (Valor == 5)
            {
                unidadeConvertida = unidadesExtenso[4];

            }
            else if (Valor == 6)
            {
                unidadeConvertida = unidadesExtenso[5];
            }
            else if (Valor == 7)
            {

                Console.WriteLine(unidadesExtenso[7]);

            }
            else if (Valor == 8)
            {
                Console.WriteLine(unidadesExtenso[8]);

            }
            else if (Valor == 9)
            {
                Console.WriteLine(unidadesExtenso[9]);
            }

            return unidadeConvertida;

        }









        public string ObterDezenaPorExtenso()
        {



            string[] dezenasExtenso = new string[8];
            string dezenaConvertida = "";

            dezenasExtenso[0] = "Dez";
            dezenasExtenso[1] = "Vinte";
            dezenasExtenso[2] = "Trinta";
            dezenasExtenso[3] = "Quarenta";
            dezenasExtenso[4] = "Cinquenta";
            dezenasExtenso[5] = "Sessenta";
            dezenasExtenso[6] = "Setenta";
            dezenasExtenso[7] = "Oitenta";
            dezenasExtenso[8] = "Noventa";



            if (Valor == 10)
            {
                dezenaConvertida = dezenasExtenso[0];

            }
            else if (Valor == 20)
            {
                Console.WriteLine(dezenasExtenso[1]);

            }
            else if (Valor == 30)
            {
                Console.WriteLine(dezenasExtenso[2]);

            }
            else if (Valor == 40)
            {
                Console.WriteLine(dezenasExtenso[3]);

            }
            else if (Valor == 50)
            {
                Console.WriteLine(dezenasExtenso[4]);

            }
            else if (Valor == 60)
            {
                Console.WriteLine(dezenasExtenso[5]);
            }
            else if (Valor == 70)
            {

                Console.WriteLine(dezenasExtenso[6]);

            }
            else if (Valor == 80)
            {
                Console.WriteLine(dezenasExtenso[7]);

            }
            else if (Valor == 90)
            {
                Console.WriteLine(dezenasExtenso[8]);
            }



            return dezenaConvertida;

        }








        public string ObterCentenaPorExtenso()
        {

            string[] CentenasExtenso = new string[8];
            string centenasConvertidas = "";



            CentenasExtenso[0] = "Cem";
            CentenasExtenso[1] = "Duzentos";
            CentenasExtenso[2] = "Trezentos";
            CentenasExtenso[3] = "Quatrocentos";
            CentenasExtenso[4] = "Quinhentos";
            CentenasExtenso[5] = "Seiscentos";
            CentenasExtenso[6] = "Setecentos";
            CentenasExtenso[7] = "Oitocentos";
            CentenasExtenso[8] = "Novecentos";


            if (Valor == 100)
            {

                centenasConvertidas = CentenasExtenso[0];
            }
            else if (Valor == 200)
            {
                centenasConvertidas = CentenasExtenso[1];

            }
            else if (Valor == 300)
            {
                centenasConvertidas = CentenasExtenso[2];

            }
            else if (Valor == 400)
            {
                centenasConvertidas = CentenasExtenso[3];

            }
            else if (Valor == 500)
            {
                centenasConvertidas = CentenasExtenso[4];
            }
            else if (Valor == 600)
            {
                centenasConvertidas = CentenasExtenso[5];
            }
            else if (Valor == 700)
            {

                centenasConvertidas = CentenasExtenso[6];

            }
            else if (Valor == 800)
            {
                centenasConvertidas = CentenasExtenso[7];

            }
            else if (Valor == 900)
            {
                centenasConvertidas = CentenasExtenso[8];
            }

            return centenasConvertidas;

        }










    public string ObterUnidadeDeMilharPorExtenso()
    {

        string[] UnidadeMilharExtenso = new string[8];
        string unidadesMilharesConvertidas = "";



        UnidadeMilharExtenso[0] = "Dois Mil";
        UnidadeMilharExtenso[1] = "Três Mil";
        UnidadeMilharExtenso[2] = "Quatro Mil";
        UnidadeMilharExtenso[3] = "Cinco Mil";
        UnidadeMilharExtenso[4] = "Seis Mil";
        UnidadeMilharExtenso[5] = "Sete Mil";
        UnidadeMilharExtenso[6] = "Oito Mil";
        UnidadeMilharExtenso[7] = "Nove Mil";
        UnidadeMilharExtenso[8] = "Dez Mil";


        if (Valor == 100)
        {

            unidadesMilharesConvertidas = UnidadeMilharExtenso[0];
              


        }
        else if (Valor == 200)
        {
            unidadesMilharesConvertidas = UnidadeMilharExtenso[1];

        }
        else if (Valor == 300)
        {
            unidadesMilharesConvertidas = UnidadeMilharExtenso[2];

        }
        else if (Valor == 400)
        {
            unidadesMilharesConvertidas = UnidadeMilharExtenso[3];

        }
        else if (Valor == 500)
        {
            unidadesMilharesConvertidas = UnidadeMilharExtenso[4];
        } else if (Valor == 600)
        {
            unidadesMilharesConvertidas = UnidadeMilharExtenso[5];
        }
        else if (Valor == 700)
        {

            unidadesMilharesConvertidas = UnidadeMilharExtenso[6];

        }
        else if (Valor == 800)
        {
            unidadesMilharesConvertidas = UnidadeMilharExtenso[7];

        }
        else if (Valor == 900)
        {
            unidadesMilharesConvertidas = UnidadeMilharExtenso[8];

        }




        Console.WriteLine(unidadesMilharesConvertidas);
        return unidadesMilharesConvertidas;
    }













    public string NumeroCompletoPorExtenso()
    {

        var resposta = "";

        Console.WriteLine("O numero completo é: " + ObterUnidadeDeMilharPorExtenso() + ObterCentenaPorExtenso() + ObterDezenaPorExtenso() + ObterUnidadePorExtenso() + "," +ObterDecimalPorExtenso() );

            resposta = Console.ReadLine();


            return resposta;
    }



    }

}

    

          