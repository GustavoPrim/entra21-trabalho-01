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
            return this.relogio.Hour.ToString();


            if (relogio.Hour == 1)
                return "uma hora";

            else if (relogio.Hour == 2)
                return "duas";

            else if (relogio.Hour == 3)
                return "três";

            else if (relogio.Hour == 4)
                return "quatro";

            else if (relogio.Hour == 5)
                return "cinco";

            else if (relogio.Hour == 6)
                return "seis";

            else if (relogio.Hour == 7)
                return "sete";

            else if (relogio.Hour == 8)
                return "oito";

            else if (relogio.Hour == 9)
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
                return "quatorze";

            
        }

        public string ObterPorExtenso()
        {
            return ObterPorExtenso();
        }

        public string ObterMinutosPorExtenso()
        {
            var resposta = ObterPorExtenso();
            return resposta;
        }




    }
}
