using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoOrientacaoObjetos01.Questao02
{
    public class ExecutarCalendario
    {
        public void Executar()
        {
            var calendario = new Calendario();

            Console.Write("Informe uma data(dd/MM/yyyy): ");
            calendario.Data = Convert.ToDateTime(Console.ReadLine());

            Console.Clear();

            var table = new ConsoleTable("Código", "Opção");

            table.Configure(x => x.EnableCount = false);

            table.AddRow("1", "Dia por extenso")
                 .AddRow("2", "Mês por extenso")
                 .AddRow("3", "Ano por extenso")
                 .AddRow("4", "Data completa por extenso")
                 .AddRow("5", "       SAIR       ");

            table.Write();
            Console.WriteLine();

            Console.Write("Informe a opção desejada para apresentar: ");
            var opcaoEscolhida = Convert.ToInt32(Console.ReadLine());

            if (opcaoEscolhida == 1)
                calendario.ObterDiaPorExtenso();

            else if (opcaoEscolhida == 2)
                calendario.ObterMesPorExtenso();

            else if (opcaoEscolhida == 3)
                calendario.ObterAnoPorExtenso();

            else if (opcaoEscolhida == 4)
                calendario.ObterDataCompletaPorExtenso();
        }
    }
}
