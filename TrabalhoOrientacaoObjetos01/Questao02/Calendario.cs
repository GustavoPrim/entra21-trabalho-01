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
            
            if(Data.Day == 1)

        }
    }


    
}
