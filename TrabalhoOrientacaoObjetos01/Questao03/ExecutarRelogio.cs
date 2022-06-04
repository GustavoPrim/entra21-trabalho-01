using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoOrientacaoObjetos01.Questao03
{
    public class Questao03
    {

        public void Executar()
        {
            //Lucas Perez Alves

            var relogio = new Relogio();

            Console.WriteLine("Digite a hora desejada: ");
            relogio.Hora = Convert.ToDateTime(Console.ReadLine());

            var table = new ConsoleTable("Código", "Opção");

            table.Configure(x => x.EnableCount = false);

            table.AddRow("1", "Hora por extenso")
                 .AddRow("2", "Minuto por extenso")
                 .AddRow("3", "Segundo por extenso")
                 .AddRow("4", "Hora completa")
                 .AddRow("5", "       SAIR       ");

            table.Write();
            int milliseconds = 5000;
            Thread.Sleep(milliseconds);

            Console.Clear();

            Console.WriteLine("Digite a opção desejada: ");
            var opcaoDesejada = Convert.ToInt32(Console.ReadLine());

            if (opcaoDesejada == 1)
            {
                relogio.ObterHoraPorExtenso();
            }
            else if (opcaoDesejada == 2)
            {
                relogio.ObterMinutosPorExtenso();
            }
            else if (opcaoDesejada == 3)
            {
                relogio.ObterSegundosPorExtenso();
            }
            else if (opcaoDesejada == 4)
            {
                relogio.ObterHoraCompleta();
            }
        }
    }
}

