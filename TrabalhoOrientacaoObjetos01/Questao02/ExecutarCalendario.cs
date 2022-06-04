using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//GUSTAVO PRIM
namespace TrabalhoOrientacaoObjetos01.Questao02
{
    public class ExecutarCalendario
    {
        public void Executar()
        {
            var calendario = new Calendario();

            Console.Write("Informe uma data(dd/MM/yyyy): ");
            calendario.Data = Convert.ToDateTime(Console.ReadLine());

            var opcaoEscolhida = 0;
            while (opcaoEscolhida != 5)
            {
                var table = new ConsoleTable("Código", "Opção");

                table.Configure(x => x.EnableCount = false);

                table.AddRow("1", "Dia por extenso")
                     .AddRow("2", "Mês por extenso")
                     .AddRow("3", "Ano por extenso")
                     .AddRow("4", "Data completa por extenso")
                     .AddRow("5", "          SAIR       ");

                table.Write();

                var opcaoValida = false;
                while (opcaoValida == false)
                {
                    try
                    {
                        Console.Write("Informe a opção desejada para apresentar: ");
                        opcaoEscolhida = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();

                        if (opcaoEscolhida < 1 || opcaoEscolhida > 5)
                        {
                            Console.WriteLine("Opção digitada não existe, informe uma opção novamente.");
                        }
                        else
                        {
                            opcaoValida = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Opção de menu não é válido, informe a opção novamente.");
                    }
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
    }
}
