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

            Console.Clear();
            Console.WriteLine(mesPorExtenso);
            return mesPorExtenso;
        }

        string[] dezenas = new string[8];
        string[] unidades = new string[9];

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


            var diaPorExtenso = "";
            if (Data.Day == 1)
                diaPorExtenso = "Um ";

            else if (Data.Day == 2)
                diaPorExtenso = "Dois ";

            else if (Data.Day == 3)
                diaPorExtenso = "Três ";

            else if (Data.Day == 4)
                diaPorExtenso = "Quatro ";

            else if (Data.Day == 5)
                diaPorExtenso = "Cinco ";

            else if (Data.Day == 6)
                diaPorExtenso = "Seis ";

            else if (Data.Day == 7)
                diaPorExtenso = "Sete ";

            else if (Data.Day == 8)
                diaPorExtenso = "Oito ";

            else if (Data.Day == 9)
                diaPorExtenso = "Nove ";

            else if (Data.Day == 10)
                diaPorExtenso = "Dez";

            else if (Data.Day == 11)
                diaPorExtenso = "Onze";

            else if (Data.Day == 12)
                diaPorExtenso = "Doze";

            else if (Data.Day == 13)
                diaPorExtenso = "Treze";

            else if (Data.Day == 14)
                diaPorExtenso = "Quatorze";

            else if (Data.Day == 15)
                diaPorExtenso = "Quinze";

            else if (Data.Day == 16)
                diaPorExtenso = "Dezesseis";

            else if (Data.Day == 17)
                diaPorExtenso = "Dezessete";

            else if (Data.Day == 18)
                diaPorExtenso = "Dezoito";

            else if (Data.Day == 19)
                diaPorExtenso = "Dezenove";

            else if (Data.Day == 20)
                diaPorExtenso = dezenas[1];

            else if (Data.Day == 21)
                diaPorExtenso = dezenas[0] + unidades[0];

            else if (Data.Day == 22)
                diaPorExtenso = dezenas[0] + unidades[1];

            else if (Data.Day == 23)
                diaPorExtenso = dezenas[0] + unidades[2];

            else if (Data.Day == 24)
                diaPorExtenso = dezenas[0] + unidades[3];

            else if (Data.Day == 25)
                diaPorExtenso = dezenas[0] + unidades[4];

            else if (Data.Day == 26)
                diaPorExtenso = dezenas[0] + unidades[5];

            else if (Data.Day == 27)
                diaPorExtenso = dezenas[0] + unidades[6];

            else if (Data.Day == 28)
                diaPorExtenso = dezenas[0] + unidades[7];

            else if (Data.Day == 29)
                diaPorExtenso = dezenas[0] + unidades[8];

            else if (Data.Day == 30)
                diaPorExtenso = dezenas[1];

            else if (Data.Day == 31)
                diaPorExtenso = dezenas[1] + unidades[0];

            Console.Clear();
            Console.WriteLine(diaPorExtenso);
            return diaPorExtenso;
        }


        public string ObterAnoPorExtenso()
        {
            var ano = 2030;
            var anoNomesExtenso = "";

            if (Data.Year == ano)
                anoNomesExtenso = "Dois mil e trinta";

            else if (Data.Year == ano - 1)
                anoNomesExtenso = "Dois mil e vinte e nove";

            else if (Data.Year == ano - 2)
                anoNomesExtenso = "Dois mil e vinte e oito";

            else if (Data.Year == ano - 3)
                anoNomesExtenso = "Dois mil e vinte e sete";

            else if (Data.Year == ano - 4)
                anoNomesExtenso = "Dois mil e vinte e seis";

            else if (Data.Year == ano - 5)
                anoNomesExtenso = "Dois mil e vinte e cinco";

            else if (Data.Year == ano - 6)
                anoNomesExtenso = "Dois mil e vinte e quatro";

            else if (Data.Year == ano - 7)
                anoNomesExtenso = "Dois mil e vinte e três";

            else if (Data.Year == ano - 8)
                anoNomesExtenso = "Dois mil e vinte e dois";

            else if (Data.Year == ano - 9)
                anoNomesExtenso = "Dois mil e vinte e um";

            else if (Data.Year == ano - 10)
                anoNomesExtenso = "Dois mil e vinte";

            else if (Data.Year == ano - 11)
                anoNomesExtenso = "Dois mil e dezenove";

            else if (Data.Year == ano - 12)
                anoNomesExtenso = "Dois mil e dezoito";

            else if (Data.Year == ano - 13)
                anoNomesExtenso = "Dois mil e dezessete";

            else if (Data.Year == ano - 14)
                anoNomesExtenso = "Dois mil e dezesseis";

            else if (Data.Year == ano - 15)
                anoNomesExtenso = "Dois mil e quinze";

            else if (Data.Year == ano - 16)
                anoNomesExtenso = "Dois mil e quatorze";

            else if (Data.Year == ano - 17)
                anoNomesExtenso = "Dois mil e treze";

            else if (Data.Year == ano - 18)
                anoNomesExtenso = "Dois mil e doze";

            else if (Data.Year == ano - 19)
                anoNomesExtenso = "Dois mil e onze";

            else if (Data.Year == ano - 20)
                anoNomesExtenso = "Dois mil e dez";

            else if (Data.Year == ano - 21)
                anoNomesExtenso = "Dois mil e nove";

            else if (Data.Year == ano - 22)
                anoNomesExtenso = "Dois mil e oito";

            else if (Data.Year == ano - 23)
                anoNomesExtenso = "Dois mil e sete";

            else if (Data.Year == ano - 24)
                anoNomesExtenso = "Dois mil e seis";

            else if (Data.Year == ano - 25)
                anoNomesExtenso = "Dois mil e cinco";

            else if (Data.Year == ano - 26)
                anoNomesExtenso = "Dois mil e quatro";

            else if (Data.Year == ano - 27)
                anoNomesExtenso = "Dois mil e três";

            else if (Data.Year == ano - 28)
                anoNomesExtenso = "Dois mil e dois";

            else if (Data.Year == ano - 29)
                anoNomesExtenso = "Dois mil e um";

            else if (Data.Year == ano - 30)
                anoNomesExtenso = "Dois mil";

            else if (Data.Year == ano - 31)
                anoNomesExtenso = "Mil novecentos e noventa e nove";

            else if (Data.Year == ano - 32)
                anoNomesExtenso = "Mil novecentos e noventa e oito";

            else if (Data.Year == ano - 33)
                anoNomesExtenso = "Mil novecentos e noventa e sete";

            else if (Data.Year == ano - 34)
                anoNomesExtenso = "Mil novecentos e noventa e seis";

            else if (Data.Year == ano - 35)
                anoNomesExtenso = "Mil novecentos e noventa e cinco";

            else if (Data.Year == ano - 36)
                anoNomesExtenso = "Mil novecentos e noventa e quatro";

            else if (Data.Year == ano - 37)
                anoNomesExtenso = "Mil novecentos e noventa e três";

            else if (Data.Year == ano - 38)
                anoNomesExtenso = "Mil novecentos e noventa e dois";

            else if (Data.Year == ano - 39)
                anoNomesExtenso = "Mil novecentos e noventa e um";

            else if (Data.Year == ano - 40)
                anoNomesExtenso = "Mil novecentos e noventa";

            else if (Data.Year == ano - 41)
                anoNomesExtenso = "Mil novecentos e oitenta e nove";

            else if (Data.Year == ano - 42)
                anoNomesExtenso = "Mil novecentos e oitenta e oito";

            else if (Data.Year == ano - 43)
                anoNomesExtenso = "Mil novecentos e oitenta e sete";

            else if (Data.Year == ano - 44)
                anoNomesExtenso = "Mil novecentos e oitenta e seis";

            else if (Data.Year == ano - 45)
                anoNomesExtenso = "Mil novecentos e oitenta e cinco";

            else if (Data.Year == ano - 46)
                anoNomesExtenso = "Mil novecentos e oitenta e quatro";

            else if (Data.Year == ano - 47)
                anoNomesExtenso = "Mil novecentos e oitenta e três";

            else if (Data.Year == ano - 48)
                anoNomesExtenso = "Mil novecentos e oitenta e dois";

            else if (Data.Year == ano - 49)
                anoNomesExtenso = "Mil novecentos e oitenta e um";

            else if (Data.Year == ano - 50)
                anoNomesExtenso = "Mil novecentos e oitenta";

            else if (Data.Year == ano - 51)
                anoNomesExtenso = "Mil novecentos e setenta e nove";

            else if (Data.Year == ano - 52)
                anoNomesExtenso = "Mil novecentos e setenta e oito";

            else if (Data.Year == ano - 53)
                anoNomesExtenso = "Mil novecentos e setenta e sete";

            else if (Data.Year == ano - 54)
                anoNomesExtenso = "Mil novecentos e setenta e seis";

            else if (Data.Year == ano - 55)
                anoNomesExtenso = "Mil novecentos e setenta e cinco";

            else if (Data.Year == ano - 56)
                anoNomesExtenso = "Mil novecentos e setenta e quatro";

            else if (Data.Year == ano - 57)
                anoNomesExtenso = "Mil novecentos e setenta e três";

            else if (Data.Year == ano - 58)
                anoNomesExtenso = "Mil novecentos e setenta e dois";

            else if (Data.Year == ano - 59)
                anoNomesExtenso = "Mil novecentos e setenta e um";

            else if (Data.Year == ano - 60)
                anoNomesExtenso = "Mil novecentos e setenta";

            Console.Clear();
            Console.WriteLine(anoNomesExtenso);
            return anoNomesExtenso;
        }

        public string ObterDataCompletaPorExtenso()
        {
            var dataCompletaPorExtenso = ObterDiaPorExtenso() + " de " + ObterMesPorExtenso() + " de " + ObterAnoPorExtenso();
            Console.Clear();
            Console.WriteLine(dataCompletaPorExtenso);
            return dataCompletaPorExtenso;
        }
    }
}




