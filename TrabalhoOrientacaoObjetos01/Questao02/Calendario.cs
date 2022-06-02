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
                mesPorExtenso = "Janeiro";

            else if (Data.Month == 2)
                mesPorExtenso = "Fevereiro";

            else if (Data.Month == 3)
                mesPorExtenso = "Março";

            else if (Data.Month == 4)
                mesPorExtenso = "Abril";

            else if (Data.Month == 5)
                mesPorExtenso = "Maio";

            else if (Data.Month == 6)
                mesPorExtenso = "Junho";

            else if (Data.Month == 7)
                mesPorExtenso = "Julho";

            else if (Data.Month == 8)
                mesPorExtenso = "Agosto";

            else if (Data.Month == 9)
                mesPorExtenso = "Setembro";

            else if (Data.Month == 10)
                mesPorExtenso = "Outubro";

            else if (Data.Month == 11)
                mesPorExtenso = "Novembro";

            else if (Data.Month == 12)
                mesPorExtenso = "Dezembro";

            return mesPorExtenso;
        }

        string[] dezenas = new string[8];
        string[] unidades = new string[9];
        string[] milhares = new string[2];
        public string ObterDiaPorExtenso()
        {
            unidades[0] = " e um";
            unidades[1] = " e dois";
            unidades[2] = " e três";
            unidades[3] = " e quatro";
            unidades[4] = " e cinco";
            unidades[5] = " e seis";
            unidades[6] = " e sete";
            unidades[7] = " e oito";
            unidades[8] = " e nove";
            dezenas[0] = "Vinte";
            dezenas[1] = "Trinta";


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
                return dezenas[0] + unidades[0];

            else if (Data.Day == 22)
                return dezenas[0] + unidades[1];

            else if (Data.Day == 23)
                return dezenas[0] + unidades[2];

            else if (Data.Day == 24)
                return dezenas[0] + unidades[3];

            else if (Data.Day == 25)
                return dezenas[0] + unidades[4];

            else if (Data.Day == 26)
                return dezenas[0] + unidades[5];

            else if (Data.Day == 27)
                return dezenas[0] + unidades[6];

            else if (Data.Day == 28)
                return dezenas[0] + unidades[7];

            else if (Data.Day == 29)
                return dezenas[0] + unidades[8];

            else if (Data.Day == 30)
                return dezenas[1];

            else if (Data.Day == 31)
                return dezenas[1] + unidades[0];

            return "";
        }

        public string ObterAnoPorExtenso()
        {
            return ObterAnoPorExtenso();
        }

        public string ObterDataCompletaPorExtenso()
        {
            var dataCompletaPorExtenso = ObterDiaPorExtenso() + " de " + ObterMesPorExtenso() + " de " + ObterAnoPorExtenso();
            return dataCompletaPorExtenso;
        }
    }
}




