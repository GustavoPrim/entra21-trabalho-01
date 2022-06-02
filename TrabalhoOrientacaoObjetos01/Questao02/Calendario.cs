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

        public string ObterDiaPorExtenso()
        {
            //(18)
            var dia = Convert.ToString(Data.Day);

            if (Data.Day == 1)
                return "Um de";

            else if (Data.Day == 2)
                return "Dois de";

            else if (Data.Day == 3)
                return "Três de";

            else if (Data.Day == 4)
                return "Quatro de";

            else if (Data.Day == 5)
                return "Cinco de";

            else if (Data.Day == 6)
                return "Seis de";

            else if (Data.Day == 7)
                return "Sete de";

            else if (Data.Day == 8)
                return "Oito de";

            else if (Data.Day == 9)
                return "Nove de";

            return "";
        }

        //public string ObterAnoPorExtenso()
        //{

        //}

        //public string ApresentarInformacoes()
        //{
        //    if (OpcaoDesejada == 1)
        //        return ObterDiaPorExtenso();

        //    else if (OpcaoDesejada == 2)
        //        return ObterMesPorExtenso();

        //    else if (OpcaoDesejada == 3)
        //        //return ObterAnoPorExtenso();
    }
}




