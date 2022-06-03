using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoOrientacaoObjetos01.Questao03
{
    public class Relogio
    {

        public DateTime relogio;
        public int numeroParaConverter;

        public string ObterHoraPorExtenso()
        {
            return relogio.Hour.ToString();


            if (relogio.Hour == 01)
                return "uma hora";

            else if (relogio.Hour == 02)
                return "duas";

            else if (relogio.Hour == 03)
                return "três";

            else if (relogio.Hour == 04)
                return "quatro";

            else if (relogio.Hour == 05)
                return "cinco";

            else if (relogio.Hour == 06)
                return "seis";

            else if (relogio.Hour == 07)
                return "sete";

            else if (relogio.Hour == 08)
                return "oito";

            else if (relogio.Hour == 09)
                return "nove";

            else if (relogio.Hour == 10)
                return "dez";

            else if (relogio.Hour == 11)
                return "onze";

            else if (relogio.Hour == 12)
                return "doze";

            else if (relogio.Hour == 13)
                return "uma hora";

            else if (relogio.Hour == 14)
                return "duas";

            else if (relogio.Hour == 15)
                return "três";

            else if (relogio.Hour == 16)
                return "quatro";

            else if (relogio.Hour == 17)
                return "cinco";

            else if (relogio.Hour == 18)
                return "seis";

            else if (relogio.Hour == 19)
                return "sete";

            else if (relogio.Hour == 20)
                return "oito";

            else if (relogio.Hour == 21)
                return "nove";

            else if (relogio.Hour == 22)
                return "dez";

            else if (relogio.Hour == 23)
                return "onze";

            else if (relogio.Hour == 00)
                return "meia noite";

        }

        public string ObterSegundoExtenso()
        {
            var valorExt = 0;

            if (valorExt == 01)
                return "um";

            else if (valorExt == 02)
                return "dois";

            else if (valorExt == 03)
                return "três";

            else if (valorExt == 04)
                return "quatro";

            else if (valorExt == 05)
                return "cinco";

            else if (valorExt == 06)
                return "seis";

            else if (valorExt == 07)
                return "sete";

            else if (valorExt == 08)
                return "oito";

            else if (valorExt == 09)
                return "nove";

            else if (valorExt == 10)
                return "dez";

            else if (valorExt == 11)
                return "onze";

            else if (valorExt == 12)
                return "doze";

            else if (valorExt == 13)
                return "treze";

            else if (valorExt == 14)
                return "quatorze";

            else if (valorExt == 15)
                return "quinze";

            else if (valorExt == 16)
                return "dezesseis";

            else if (valorExt == 17)
                return "dezessete";

            else if (valorExt == 18)
                return "dezoito";

            else if (valorExt == 19)
                return "dezenove";

            else if (valorExt == 20)
                return "vinte";

            else if (valorExt == 21)
                return "vinte e um";

            else if (valorExt == 22)
                return "vinte e dois";

            else if (valorExt == 23)
                return "vinte e três";

            else if (valorExt == 24)
                return "vinte e quatro";

            else if (valorExt == 25)
                return "vinte e cinco";

            else if (valorExt == 26)
                return "vinte e seis";

            else if (valorExt == 27)
                return "vinte e sete";

            else if (valorExt == 28)
                return "vinte e oito";

            else if (valorExt == 29)
                return "vinte e nove";

            else if (valorExt == 30)
                return "trinta";

            else if (valorExt == 31)
                return "trinta e um";

            else if (valorExt == 32)
                return "trinta e dois";

            else if (valorExt == 33)
                return "trinta e três";

            else if (valorExt == 34)
                return "trinta e quatro";

            else if (valorExt == 35)
                return "trinta e cinco";

            else if (valorExt == 36)
                return "trinta e seis";

            else if (valorExt == 37)
                return "trinta e sete";

            else if (valorExt == 38)
                return "trinta e oito";

            else if (valorExt == 39)
                return "trinta e nove";

            else if (valorExt == 40)
                return "quarenta";

            else if (valorExt == 41)
                return "quarenta e um";

            else if (valorExt == 42)
                return "quarenta e dois";

            else if (valorExt == 43)
                return "quarenta e três";

            else if (valorExt == 44)
                return "quarenta e quatro";

            else if (valorExt == 45)
                return "quarenta e cinco";

            else if (valorExt == 46)
                return "quarenta e seis";

            else if (valorExt == 47)
                return "quarenta e sete";

            else if (valorExt == 48)
                return "quarenta e oito";

            else if (valorExt == 49)
                return "quarenta e nove";

            else if (valorExt == 50)
                return "cinquenta";

            else if (valorExt == 51)
                return "cinquenta e um";

            else if (valorExt == 52)
                return "cinquenta e dois";

            else if (valorExt == 53)
                return "cinquenta e três";

            else if (valorExt == 54)
                return "cinquenta e quatro";

            else if (valorExt == 55)
                return "cinquenta e cinco";

            else if (valorExt == 56)
                return "cinquenta e seis";

            else if (valorExt == 57)
                return "cinquenta e sete";

            else if (valorExt == 58)
                return "cinquenta e oito";

            else if (valorExt == 59)
                return "cinquenta e nove";

            var resposta = ObterSegundoExtenso + "segundos";

        }

        public string ObterMinutosPorExtenso()
        {
            var valorExt = 0;

            if (valorExt == 01)
                return "um";

            else if (valorExt == 02)
                return "dois";

            else if (valorExt == 03)
                return "três";

            else if (valorExt == 04)
                return "quatro";

            else if (valorExt == 05)
                return "cinco";

            else if (valorExt == 06)
                return "seis";

            else if (valorExt == 07)
                return "sete";

            else if (valorExt == 08)
                return "oito";

            else if (valorExt == 09)
                return "nove";

            else if (valorExt == 10)
                return "dez";

            else if (valorExt == 11)
                return "onze";

            else if (valorExt == 12)
                return "doze";

            else if (valorExt == 13)
                return "treze";

            else if (valorExt == 14)
                return "quatorze";

            else if (valorExt == 15)
                return "quinze";

            else if (valorExt == 16)
                return "dezesseis";

            else if (valorExt == 17)
                return "dezessete";

            else if (valorExt == 18)
                return "dezoito";

            else if (valorExt == 19)
                return "dezenove";

            else if (valorExt == 20)
                return "vinte";

            else if (valorExt == 21)
                return "vinte e um";

            else if (valorExt == 22)
                return "vinte e dois";

            else if (valorExt == 23)
                return "vinte e três";

            else if (valorExt == 24)
                return "vinte e quatro";

            else if (valorExt == 25)
                return "vinte e cinco";

            else if (valorExt == 26)
                return "vinte e seis";

            else if (valorExt == 27)
                return "vinte e sete";

            else if (valorExt == 28)
                return "vinte e oito";

            else if (valorExt == 29)
                return "vinte e nove";

            else if (valorExt == 30)
                return "trinta";

            else if (valorExt == 31)
                return "trinta e um";

            else if (valorExt == 32)
                return "trinta e dois";

            else if (valorExt == 33)
                return "trinta e três";

            else if (valorExt == 34)
                return "trinta e quatro";

            else if (valorExt == 35)
                return "trinta e cinco";

            else if (valorExt == 36)
                return "trinta e seis";

            else if (valorExt == 37)
                return "trinta e sete";

            else if (valorExt == 38)
                return "trinta e oito";

            else if (valorExt == 39)
                return "trinta e nove";

            else if (valorExt == 40)
                return "quarenta";

            else if (valorExt == 41)
                return "quarenta e um";

            else if (valorExt == 42)
                return "quarenta e dois";

            else if (valorExt == 43)
                return "quarenta e três";

            else if (valorExt == 44)
                return "quarenta e quatro";

            else if (valorExt == 45)
                return "quarenta e cinco";

            else if (valorExt == 46)
                return "quarenta e seis";

            else if (valorExt == 47)
                return "quarenta e sete";

            else if (valorExt == 48)
                return "quarenta e oito";

            else if (valorExt == 49)
                return "quarenta e nove";

            else if (valorExt == 50)
                return "cinquenta";

            else if (valorExt == 51)
                return "cinquenta e um";

            else if (valorExt == 52)
                return "cinquenta e dois";

            else if (valorExt == 53)
                return "cinquenta e três";

            else if (valorExt == 54)
                return "cinquenta e quatro";

            else if (valorExt == 55)
                return "cinquenta e cinco";

            else if (valorExt == 56)
                return "cinquenta e seis";

            else if (valorExt == 57)
                return "cinquenta e sete";

            else if (valorExt == 58)
                return "cinquenta e oito";

            else if (valorExt == 59)
                return "cinquenta e nove";

            var resposta = ObterHoraPorExtenso + "minutos";
        }




    }
}
