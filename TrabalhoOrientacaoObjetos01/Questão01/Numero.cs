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

        //Método 1

        public string ObterDecimalPorExtenso()
        {



            int numeroPositivo = 0;
            var numeroDecimalExtenso = "";

            if (Valor * 100 > numeroPositivo)
            {

                numeroDecimalExtenso = ObterDezenaPorExtenso() + ObterUnidadePorExtenso() + "Décimos";

            }

            return numeroDecimalExtenso;
        }


        // Método 2

        public string ObterUnidadePorExtenso()
        {
            //string[] unidadesExtenso = new string[9];

            string unidadeConvertida = "";

            //unidadesExtenso[0] = "Um";
            //unidadesExtenso[1] = "Dois";
            //unidadesExtenso[2] = "Três";
            //unidadesExtenso[3] = "Quatro";
            //unidadesExtenso[4] = "Cinco";
            //unidadesExtenso[5] = "Seis";
            //unidadesExtenso[6] = "Sete";
            //unidadesExtenso[7] = "Oito";
            //unidadesExtenso[8] = "Nove";

            if (Valor == 1)
            {
                unidadeConvertida = "Um";
            }
            else if (Valor == 2)
            {
                unidadeConvertida = "Dois";
            }
            else if (Valor == 3)
            {
                unidadeConvertida = "Três";
            }
            else if (Valor == 4)
            {
                unidadeConvertida = "Quatro";
            }
            else if (Valor == 5)
            {
                unidadeConvertida = "Cinco";
            }
            else if (Valor == 6)
            {
                unidadeConvertida = "Seis";
            }
            else if (Valor == 7)
            {
                unidadeConvertida = "Sete";
            }
            else if (Valor == 8)
            {
                unidadeConvertida = "Oito";
            }
            else if (Valor == 9)
            {
                unidadeConvertida = "Nove";
            }

            return unidadeConvertida;
        }

        //Método 3

        public string ObterDezenaPorExtenso()
        {
            //string[] dezenasExtenso = new string[8];
            string dezenaConvertida = "";

            //dezenasExtenso[0] = "Dez";
            //dezenasExtenso[1] = "Vinte";
            //dezenasExtenso[2] = "Trinta";
            //dezenasExtenso[3] = "Quarenta";
            //dezenasExtenso[4] = "Cinquenta";
            //dezenasExtenso[5] = "Sessenta";
            //dezenasExtenso[6] = "Setenta";
            //dezenasExtenso[7] = "Oitenta";
            //dezenasExtenso[8] = "Noventa";


            if (Valor == 10)
            {
                dezenaConvertida = "Dez";

            }
            else if (Valor == 11)
            {


                dezenaConvertida = "Onze";

            }
            else if (Valor == 12)
            {


                dezenaConvertida = "Doze";

            }
            else if (Valor== 13)
            {
 
                dezenaConvertida = "Treze";


            }
            else if (Valor == 14)
            {

                dezenaConvertida = "Quatorze";
            }
            else if (Valor == 15)
            {

                dezenaConvertida = "Quinze";



            }
            else if (Valor == 16)
            {
                dezenaConvertida = "Dezesseis";


            }
            else if (Valor == 17)
            {

                dezenaConvertida = "Dezessete";


            }
            else if (Valor == 18)
            {

                dezenaConvertida = "Dezoito";


            }
            else if (Valor == 19) {

                dezenaConvertida = "Dezenove";


            }
            else if (Valor >= 20)
            {
                dezenaConvertida = "Vinte";

            }
            else if (Valor >= 30)
            {
                dezenaConvertida = "Trinta";

            }
            else if (Valor >= 40)
            {
                dezenaConvertida = "Quarenta";

            }
            else if (Valor >= 50)
            {
                dezenaConvertida = "Cinquenta";

            }
            else if (Valor >= 60)
            {
                dezenaConvertida = "Sessenta";
            }
            else if (Valor >= 70)
            {

                dezenaConvertida = "Setenta";

            }
            else if (Valor >= 80)
            {
                dezenaConvertida = "Oitenta";

            }
            else if (Valor >= 90)
            {
                dezenaConvertida = "Noventa";
            }



            return dezenaConvertida;


        }

        // Método 4

        public string ObterCentenaPorExtenso()
        {
            //string[] CentenasExtenso = new string[8];
            string centenasConvertidas = "";

            //CentenasExtenso[0] = "Cem";
            //CentenasExtenso[1] = "Duzentos";
            //CentenasExtenso[2] = "Trezentos";
            //CentenasExtenso[3] = "Quatrocentos";
            //CentenasExtenso[4] = "Quinhentos";
            //CentenasExtenso[5] = "Seiscentos";
            //CentenasExtenso[6] = "Setecentos";
            //CentenasExtenso[7] = "Oitocentos";
            //CentenasExtenso[8] = "Novecentos";

            if (Valor >= 100 && Valor < 200)
            {
                centenasConvertidas = "Cem";
            }
            else if (Valor >= 200 && Valor < 300)
            {
                centenasConvertidas = "Duzentos";
            }
            else if (Valor >= 300 && Valor < 400)
            {
                centenasConvertidas = "Trezentos";
            }
            else if (Valor >= 400 )
            {
                centenasConvertidas = "Quatrocentos";
            }
            else if (Valor >= 500)
            {
                centenasConvertidas = "Quinhentos";
            }
            else if (Valor >= 600)
            {
                centenasConvertidas = "Seiscentos";
            }
            else if (Valor >= 700)
            {
                centenasConvertidas = "Setecentos";
            }
            else if (Valor >= 800)
            {
                centenasConvertidas = "Oitocentos";
            }
            else if (Valor >= 900)
            {
                centenasConvertidas = "Novecentos";
            }

            return centenasConvertidas;
        }

        //Método 5

        public string ObterUnidadeDeMilharPorExtenso()
        {

            //string[] UnidadeMilharExtenso = new string[8];
            string unidadesMilharesConvertidas = "";



            //UnidadeMilharExtenso[0] = " Mil";
            //UnidadeMilharExtenso[1] = "Dois Mil";
            //UnidadeMilharExtenso[2] = "Três Mil";
            //UnidadeMilharExtenso[3] = "Quatro Mil";
            //UnidadeMilharExtenso[4] = "Cinco Mil";
            //UnidadeMilharExtenso[5] = "Seis Mil";
            //UnidadeMilharExtenso[6] = "Sete Mil";
            //UnidadeMilharExtenso[7] = "Oito Mil";
            //UnidadeMilharExtenso[8] = "Nove Mil";

            if (Valor >= 1000)
            {
                unidadesMilharesConvertidas = "Mil";
            }
            else if (Valor >= 2000)
            {
                unidadesMilharesConvertidas = "Dois mil";
            }
            else if (Valor >= 3000)
            {
                unidadesMilharesConvertidas = "Três mil";
            }
            else if (Valor >= 4000)
            {
                unidadesMilharesConvertidas = "Quatro Mil";
            }
            else if (Valor >= 5000)
            {
                unidadesMilharesConvertidas = "Cinco mil";
            }
            else if (Valor >= 6000)
            {
                unidadesMilharesConvertidas = "Seis mil";
            }
            else if (Valor >= 7000)
            {
                unidadesMilharesConvertidas = "Sete Mil";
            }
            else if (Valor >= 8000)
            {
                unidadesMilharesConvertidas = "Oito mil";
            }
            else if (Valor >= 9000)
            {
                unidadesMilharesConvertidas = "Nove mil";
            }

        Console.WriteLine(unidadesMilharesConvertidas);
        return unidadesMilharesConvertidas;
    }

        //Método 6

    public string NumeroCompletoPorExtenso()
    {


            var numeroExtenso = "";


            if (Valor <= 10)
            {

                numeroExtenso = ObterUnidadePorExtenso();


            }
            else if (Valor <= 100)
            {

                numeroExtenso = ObterDezenaPorExtenso() + ObterUnidadePorExtenso();

            }
            else if (Valor <= 1000)
            {

                numeroExtenso = ObterCentenaPorExtenso() + ObterDezenaPorExtenso() + ObterUnidadePorExtenso();


            }
            else if (Valor <= 10000) {

                numeroExtenso = ObterUnidadeDeMilharPorExtenso() + ObterCentenaPorExtenso() + ObterDezenaPorExtenso() + ObterUnidadePorExtenso();



            }
            Console.WriteLine($"O número completo por extenso é {numeroExtenso}");
            return numeroExtenso;

            ////var resposta = ObterUnidadePorExtenso() + ObterDezenaPorExtenso() + ObterCentenaPorExtenso() + ObterUnidadeDeMilharPorExtenso();
            ////Valor = Convert.ToDouble(Console.ReadLine());
            ////Console.WriteLine(resposta);

            ////return resposta;
     }












  }
}

