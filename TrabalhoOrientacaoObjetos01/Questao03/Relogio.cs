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
            
            var horaDigitada = "";

            if (Hora.Hour == 01)
                horaDigitada = "uma hora da manhã";

            else if (Hora.Hour == 02)
                horaDigitada = "duas horas da manhã";

            else if (Hora.Hour == 03)
                horaDigitada = "três horas da manhã";

            else if (Hora.Hour == 04)
                horaDigitada = "quatro horas da manhã";

            else if (Hora.Hour == 05)
                horaDigitada = "cinco horas da manhã";

            else if (Hora.Hour == 06)
                horaDigitada = "seis horas da manhã";

            else if (Hora.Hour == 07)
                horaDigitada = "sete horas da manhã";

            else if (Hora.Hour == 08)
                horaDigitada = "oito horas da manhã";

            else if (Hora.Hour == 09)
                horaDigitada = "nove horas da manhã";

            else if (Hora.Hour == 10)
                horaDigitada = "dez horas da manhã";

            else if (Hora.Hour == 11)
                horaDigitada = "onze horas da manhã";

            else if (Hora.Hour == 12)
                horaDigitada = "meio dia";

            else if (Hora.Hour == 13)
                horaDigitada = "uma hora da tarde";

            else if (Hora.Hour == 14)
                horaDigitada = "duas horas da tarde";

            else if (Hora.Hour == 15)
                horaDigitada = "três horas da tarde";

            else if (Hora.Hour == 16)
                horaDigitada = "quatro horas da tarde";

            else if (Hora.Hour == 17)
                horaDigitada = "cinco horas da tarde";

            else if (Hora.Hour == 18)
                horaDigitada = "seis horas da noite";

            else if (Hora.Hour == 19)
                horaDigitada = "sete horas da noite";

            else if (Hora.Hour == 20)
                horaDigitada = "oito horas da noite";

            else if (Hora.Hour == 21)
                horaDigitada = "nove horas da noite";

            else if (Hora.Hour == 22)
                horaDigitada = "dez horas da noite";

            else if (Hora.Hour == 23)
                horaDigitada = "onze horas da noite";

            else if (Hora.Hour == 00)
                horaDigitada = "meia noite";


            Console.WriteLine(horaDigitada);
            return horaDigitada;
        }

        public string ObterMinutosPorExtenso()
        {
            var minutoDigitado = "";
            

            if (Hora.Minute == 01)
                minutoDigitado = "um";

            else if (Hora.Minute == 02)
                minutoDigitado = "dois";

            else if (Hora.Minute == 03)
                minutoDigitado = "três";

            else if (Hora.Minute == 04)
                minutoDigitado = "quatro";

            else if (Hora.Minute == 05)
                minutoDigitado = "cinco";

            else if (Hora.Minute == 06)
                minutoDigitado = "seis";

            else if (Hora.Minute == 07)
                minutoDigitado = "sete";

            else if (Hora.Minute == 08)
                minutoDigitado = "oito";

            else if (Hora.Minute == 09)
                minutoDigitado = "nove";

            else if (Hora.Minute == 10)
                minutoDigitado = "dez";

            else if (Hora.Minute == 11)
                minutoDigitado = "onze";

            else if (Hora.Minute == 12)
                minutoDigitado = "doze";

            else if (Hora.Minute == 13)
                minutoDigitado = "treze";

            else if (Hora.Minute == 14)
                minutoDigitado = "quatorze";

            else if (Hora.Minute == 15)
                minutoDigitado = "quinze";

            else if (Hora.Minute == 16)
                minutoDigitado = "dezesseis";

            else if (Hora.Minute == 17)
                minutoDigitado = "dezessete";

            else if (Hora.Minute == 18)
                minutoDigitado = "dezoito";

            else if (Hora.Minute == 19)
                minutoDigitado = "dezenove";

            else if (Hora.Minute == 20)
                minutoDigitado = "vinte";

            else if (Hora.Minute == 21)
                minutoDigitado = "vinte e um";

            else if (Hora.Minute == 22)
                minutoDigitado = "vinte e dois";

            else if (Hora.Minute == 23)
                minutoDigitado = "vinte e três";

            else if (Hora.Minute == 24)
                minutoDigitado = "vinte e quatro";

            else if (Hora.Minute == 25)
                minutoDigitado = "vinte e cinco";

            else if (Hora.Minute == 26)
                minutoDigitado = "vinte e seis";

            else if (Hora.Minute == 27)
                minutoDigitado = "vinte e sete";

            else if (Hora.Minute == 28)
                minutoDigitado = "vinte e oito";

            else if (Hora.Minute == 29)
                minutoDigitado = "vinte e nove";

            else if (Hora.Minute == 30)
                minutoDigitado = "trinta";

            else if (Hora.Minute == 31)
                minutoDigitado = "trinta e um";

            else if (Hora.Minute == 32)
                minutoDigitado = "trinta e dois";

            else if (Hora.Minute == 33)
                minutoDigitado = "trinta e três";

            else if (Hora.Minute == 34)
                minutoDigitado = "trinta e quatro";

            else if (Hora.Minute == 35)
                minutoDigitado = "trinta e cinco";

            else if (Hora.Minute == 36)
                minutoDigitado = "trinta e seis";

            else if (Hora.Minute == 37)
                minutoDigitado = "trinta e sete";

            else if (Hora.Minute == 38)
                minutoDigitado = "trinta e oito";

            else if (Hora.Minute == 39)
                minutoDigitado = "trinta e nove";

            else if (Hora.Minute == 40)
                minutoDigitado = "quarenta";

            else if (Hora.Minute == 41)
                minutoDigitado = "quarenta e um";

            else if (Hora.Minute == 42)
                minutoDigitado = "quarenta e dois";

            else if (Hora.Minute == 43)
                minutoDigitado = "quarenta e três";

            else if (Hora.Minute == 44)
                minutoDigitado = "quarenta e quatro";

            else if (Hora.Minute == 45)
                minutoDigitado = "quarenta e cinco";

            else if (Hora.Minute == 46)
                minutoDigitado = "quarenta e seis";

            else if (Hora.Minute == 47)
                minutoDigitado = "quarenta e sete";

            else if (Hora.Minute == 48)
                minutoDigitado = "quarenta e oito";

            else if (Hora.Minute == 49)
                minutoDigitado = "quarenta e nove";

            else if (Hora.Minute == 50)
                minutoDigitado = "cinquenta"; 

            else if (Hora.Minute == 51)
                minutoDigitado = "cinquenta e um";

            else if (Hora.Minute == 52)
                minutoDigitado = "cinquenta e dois";

            else if (Hora.Minute == 53)
                minutoDigitado = "cinquenta e três";

            else if (Hora.Minute == 54)
                minutoDigitado = "cinquenta e quatro";

            else if (Hora.Minute == 55)
                minutoDigitado = "cinquenta e cinco";

            else if (Hora.Minute == 56)
                minutoDigitado = "cinquenta e seis";

            else if (Hora.Minute == 57)
                minutoDigitado = "cinquenta e sete";

            else if (Hora.Minute == 58)
                minutoDigitado = "cinquenta e oito";

            else if (Hora.Minute == 59)
                minutoDigitado = "cinquenta e nove";

            
            var resposta = minutoDigitado + " " + "minutos";
            Console.WriteLine(resposta);

            return resposta;
        }

        public string ObterSegundosPorExtenso()
        {
            
            var segundoDigitado = "";

            if (Hora.Second == 01)
                segundoDigitado = "um";

            else if (Hora.Second == 02)
                segundoDigitado = "dois";

            else if (Hora.Second == 03)
                segundoDigitado = "três";

            else if (Hora.Second == 04)
                segundoDigitado = "quatro";

            else if (Hora.Second == 05)
                segundoDigitado = "cinco";

            else if (Hora.Second == 06)
                segundoDigitado = "seis";

            else if (Hora.Second == 07)
                segundoDigitado = "sete";

            else if (Hora.Second == 08)
                segundoDigitado = "oito";

            else if (Hora.Second == 09)
                segundoDigitado = "nove";

            else if (Hora.Second == 10)
                segundoDigitado = "dez";

            else if (Hora.Second == 11)
                segundoDigitado = "onze";

            else if (Hora.Second == 12)
                segundoDigitado = "doze";

            else if (Hora.Second == 13)
                segundoDigitado = "treze";

            else if (Hora.Second == 14)
                segundoDigitado = "quatorze";

            else if (Hora.Second == 15)
                segundoDigitado = "quinze";

            else if (Hora.Second == 16)
                segundoDigitado = "dezesseis";

            else if (Hora.Second == 17)
                segundoDigitado = "dezessete";

            else if (Hora.Second == 18)
                segundoDigitado = "dezoito";

            else if (Hora.Second == 19)
                segundoDigitado = "dezenove";

            else if (Hora.Second == 20)
                segundoDigitado = "vinte";

            else if (Hora.Second == 21)
                segundoDigitado = "vinte e um";

            else if (Hora.Second == 22)
                segundoDigitado = "vinte e dois";

            else if (Hora.Second == 23)
                segundoDigitado = "vinte e três";

            else if (Hora.Second == 24)
                segundoDigitado = "vinte e quatro";

            else if (Hora.Second == 25)
                segundoDigitado = "vinte e cinco";

            else if (Hora.Second == 26)
                segundoDigitado = "vinte e seis";

            else if (Hora.Second == 27)
                segundoDigitado = "vinte e sete";

            else if (Hora.Second == 28)
                segundoDigitado = "vinte e oito";

            else if (Hora.Second == 29)
                segundoDigitado = "vinte e nove";

            else if (Hora.Second == 30)
                segundoDigitado = "trinta";

            else if (Hora.Second == 31)
                segundoDigitado = "trinta e um";

            else if (Hora.Second == 32)
                segundoDigitado = "trinta e dois";

            else if (Hora.Second == 33)
                segundoDigitado = "trinta e três";

            else if (Hora.Second == 34)
                segundoDigitado = "trinta e quatro";

            else if (Hora.Second == 35)
                segundoDigitado = "trinta e cinco";

            else if (Hora.Second == 36)
                segundoDigitado = "trinta e seis";

            else if (Hora.Second == 37)
                segundoDigitado = "trinta e sete";

            else if (Hora.Second == 38)
                segundoDigitado = "trinta e oito";

            else if (Hora.Second == 39)
                segundoDigitado = "trinta e nove";

            else if (Hora.Second == 40)
                 segundoDigitado = "quarenta";

            else if (Hora.Second == 41)
                segundoDigitado = "quarenta e um";

            else if (Hora.Second == 42)
                segundoDigitado = "quarenta e dois";

            else if (Hora.Second == 43)
                 segundoDigitado = "quarenta e três";

            else if (Hora.Second == 44)
                 segundoDigitado = "quarenta e quatro";

            else if (Hora.Second == 45)
                 segundoDigitado = "quarenta e cinco";

            else if (Hora.Second == 46)
                 segundoDigitado = "quarenta e seis";

            else if (Hora.Second == 47)
                 segundoDigitado = "quarenta e sete";

            else if (Hora.Second == 48)
                 segundoDigitado = "quarenta e oito";

            else if (Hora.Second == 49)
                 segundoDigitado = "quarenta e nove";

            else if (Hora.Second == 50)
                 segundoDigitado = "cinquenta";

            else if (Hora.Second == 51)
                 segundoDigitado = "cinquenta e um";

            else if (Hora.Second == 52)
                 segundoDigitado = "cinquenta e dois";

            else if (Hora.Second == 53)
                 segundoDigitado = "cinquenta e três";

            else if (Hora.Second == 54)
                 segundoDigitado = "cinquenta e quatro";

            else if (Hora.Second == 55)
                 segundoDigitado = "cinquenta e cinco";

            else if (Hora.Second == 56)
                 segundoDigitado = "cinquenta e seis";

            else if (Hora.Second == 57)
                 segundoDigitado = "cinquenta e sete";

            else if (Hora.Second == 58)
                 segundoDigitado = "cinquenta e oito";

            else if (Hora.Second == 59)
                 segundoDigitado = "cinquenta e nove";

            var resposta = segundoDigitado + " " + "segundos";

            Console.WriteLine(resposta);

            return resposta;

        }

        public string ObterHoraCompleta()
        {
            var resposta = "";
            Console.WriteLine("A hora completa é: " + ObterHoraPorExtenso() + " " + "e" + " " +  ObterMinutosPorExtenso() + " " + "e" + " "+ ObterSegundosPorExtenso());
            resposta = Console.ReadLine();

            return resposta.Trim();
        }


    }
}
