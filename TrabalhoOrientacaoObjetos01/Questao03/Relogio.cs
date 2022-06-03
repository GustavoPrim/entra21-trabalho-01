using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoOrientacaoObjetos01.Questao03
{
    public class Relogio
    {

        public DateTime Hora;
        public int numeroParaConverter;

        public string ObterHoraPorExtenso()
        {
            return Hora.Hour.ToString();
            var horaDigitada = "";

            if (Hora.Hour == 01)
                horaDigitada = "uma hora";

            else if (Hora.Hour == 02)
                horaDigitada = "duas";

            else if (Hora.Hour == 03)
                horaDigitada =  "três";

            else if (Hora.Hour == 04)
                horaDigitada = "quatro";

            else if (Hora.Hour == 05)
                horaDigitada = "cinco";

            else if (Hora.Hour == 06)
                horaDigitada = "seis";

            else if (Hora.Hour == 07)
                horaDigitada = "sete";

            else if (Hora.Hour == 08)
                horaDigitada = "oito";

            else if (Hora.Hour == 09)
                horaDigitada = "nove";

            else if (Hora.Hour == 10)
                horaDigitada = "dez";

            else if (Hora.Hour == 11)
                horaDigitada = "onze";

            else if (Hora.Hour == 12)
                horaDigitada = "doze";

            else if (Hora.Hour == 13)
                horaDigitada = "uma hora";

            else if (Hora.Hour == 14)
                horaDigitada = "duas";

            else if (Hora.Hour == 15)
                horaDigitada = "três";

            else if (Hora.Hour == 16)
                horaDigitada = "quatro";

            else if (Hora.Hour == 17)
                horaDigitada = "cinco";

            else if (Hora.Hour == 18)
                horaDigitada = "seis";

            else if (Hora.Hour == 19)
                horaDigitada = "sete";

            else if (Hora.Hour == 20)
                horaDigitada = "oito";

            else if (Hora.Hour == 21)
                horaDigitada = "nove";

            else if (Hora.Hour == 22)
                horaDigitada = "dez";

            else if (Hora.Hour == 23)
                horaDigitada = "onze";

            else if (Hora.Hour == 00)
                horaDigitada = "meia noite";

            Console.WriteLine();
        }

        public string ObterSegundoExtenso()
        {
            var valorExt = 0;
            var segundoDigitado = "";

            if (valorExt == 01)
                segundoDigitado = "um";

            else if (valorExt == 02)
                segundoDigitado = "dois";

            else if (valorExt == 03)
                segundoDigitado = "três";

            else if (valorExt == 04)
                segundoDigitado = "quatro";

            else if (valorExt == 05)
                segundoDigitado = "cinco";

            else if (valorExt == 06)
                segundoDigitado = "seis";

            else if (valorExt == 07)
                segundoDigitado = "sete";

            else if (valorExt == 08)
                segundoDigitado = "oito";

            else if (valorExt == 09)
                segundoDigitado = "nove";

            else if (valorExt == 10)
                segundoDigitado = "dez";

            else if (valorExt == 11)
                segundoDigitado = "onze";

            else if (valorExt == 12)
                segundoDigitado = "doze";

            else if (valorExt == 13)
                segundoDigitado = "treze";

            else if (valorExt == 14)
                segundoDigitado = "quatorze";

            else if (valorExt == 15)
                segundoDigitado = "quinze";

            else if (valorExt == 16)
                segundoDigitado = "dezesseis";

            else if (valorExt == 17)
                segundoDigitado = "dezessete";

            else if (valorExt == 18)
                segundoDigitado = "dezoito";

            else if (valorExt == 19)
                segundoDigitado = "dezenove";

            else if (valorExt == 20)
                segundoDigitado = "vinte";

            else if (valorExt == 21)
                segundoDigitado = "vinte e um";

            else if (valorExt == 22)
                segundoDigitado = "vinte e dois";

            else if (valorExt == 23)
                segundoDigitado = "vinte e três";

            else if (valorExt == 24)
                segundoDigitado = "vinte e quatro";

            else if (valorExt == 25)
                segundoDigitado = "vinte e cinco";

            else if (valorExt == 26)
                segundoDigitado = "vinte e seis";

            else if (valorExt == 27)
                segundoDigitado = "vinte e sete";

            else if (valorExt == 28)
                segundoDigitado = "vinte e oito";

            else if (valorExt == 29)
                segundoDigitado = "vinte e nove";

            else if (valorExt == 30)
                segundoDigitado = "trinta";

            else if (valorExt == 31)
                segundoDigitado = "trinta e um";

            else if (valorExt == 32)
                segundoDigitado = "trinta e dois";

            else if (valorExt == 33)
                segundoDigitado = "trinta e três";

            else if (valorExt == 34)
                segundoDigitado = "trinta e quatro";

            else if (valorExt == 35)
                segundoDigitado = "trinta e cinco";

            else if (valorExt == 36)
                segundoDigitado = "trinta e seis";

            else if (valorExt == 37)
                segundoDigitado = "trinta e sete";

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

            var resposta = valorExt + "segundos";

            return resposta;

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

            var resposta = valorExt + "minutos";
            return resposta;
        }

        public string ObterHoraCompleta()
        {
            var resposta = "";
            Console.WriteLine("A hora completa é: " + ObterHoraPorExtenso + ":" +  ObterMinutosPorExtenso + ":" + ObterSegundoExtenso);
            resposta = Console.ReadLine();

            return resposta.Trim();
        }


    }
}
