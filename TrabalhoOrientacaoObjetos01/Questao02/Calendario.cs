using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoOrientacaoObjetos01.Questao02
{
    public class Calendario
    {
        public DateTime Data;

        public string ObterMesPorExtenso()
        {
            var mesPorExtenso = "";

            if (Data.Month == 1)
                return "Janeiro";

            else if (Data.Month == 2)
                return "Fevereiro";

            else if (Data.Month == 3)
                return "Março";

            else if (Data.Month == 4)
                return "Abril";

            else if (Data.Month == 5)
                return "Maio";

            else if (Data.Month == 6)
                return "Junho";

            else if (Data.Month == 7)
                return "Julho";

            else if (Data.Month == 8)
                return "Agosto";

            else if (Data.Month == 9)
                return "Setembro";

            else if (Data.Month == 10)
                return "Outubro";

            else if (Data.Month == 11)
                return "Novembro";

            else if (Data.Month == 12)
                return "Dezembro";

            return "";
        }

        string[] dezenas = new string[1];
        public string ObterDiaPorExtenso()
        {
            dezenas[1] = "Vinte";
            dezenas[2] = "Trinta";
            dezenas[3] = "Quarenta";
            dezenas[4] = "Cinquenta";
            dezenas[5] = "Sessenta";
            dezenas[6] = "Setenta";
            dezenas[7] = "Oitenta";
            dezenas[8] = "Noventa";

            if (Data.Day == 1)
                return "Um ";

            else if (Data.Day == 2)
                return "Dois ";

            else if (Data.Day == 3)
                return "Três ";

            else if (Data.Day == 4)
                return "Quatro ";

            else if (Data.Day == 5)
                return "Cinco ";

            else if (Data.Day == 6)
                return "Seis ";

            else if (Data.Day == 7)
                return "Sete ";

            else if (Data.Day == 8)
                return "Oito ";

            else if (Data.Day == 9)
                return "Nove ";

            else if (Data.Day == 10)
                return "Dez";

            else if (Data.Day == 11)
                return "Onze";

            else if (Data.Day == 12)
                return "Doze";

            else if (Data.Day == 13)
                return "Treze";

            else if (Data.Day == 14)
                return "Quatorze";

            else if (Data.Day == 15)
                return "Quinze";

            else if (Data.Day == 16)
                return "Dezesseis";

            else if (Data.Day == 17)
                return "Dezessete";

            else if (Data.Day == 18)
                return "Dezoito";

            else if (Data.Day == 19)
                return "Dezenove";

            else if (Data.Day == 20)
                return dezenas[1];

            else if (Data.Day == 21)
                return dezenas[1] + "e um";

            return "";
        }

        public string ObterAnoPorExtenso()
        {
            int[] unidadeDezenas = new int[1];
            return ObterAnoPorExtenso();
        }

        public string ObterDataCompletaPorExtenso()
        {
            var dataCompletaPorExtenso = ObterDiaPorExtenso() + " de " + ObterMesPorExtenso() + " de " + ObterAnoPorExtenso();
            return dataCompletaPorExtenso;
        }
    }
}




