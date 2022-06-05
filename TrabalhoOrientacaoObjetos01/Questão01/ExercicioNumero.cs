
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleTables;

namespace TrabalhoOrientacaoObjetos01.Questão01
{
    public class ExercicioNumero
    {

        public void Executar()
        {

            Numero numero = new Numero();
            Console.Write("Informe um valor: ");
            numero.Valor = Convert.ToDouble(Console.ReadLine());

            var table = new ConsoleTable("Código", "Opção");

            table.Configure(x => x.EnableCount = false);

            table.AddRow("1", " Número completo por extenso")
                 .AddRow("2", " Decimal por extenso")
                 .AddRow("3", " Unidade por extenso")
                 .AddRow("4", " Dezena por extenso")
                 .AddRow("5", " Centena por extenso")
                 .AddRow("6", " Milhar por extenso");

            table.Write();
            numero.NumeroCompletoPorExtenso();
        }
    }
}
