using TrabalhoOrientacaoObjetos01.Questão01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleTables;

namespace TrabalhoOrientacaoObjetos01.Questão01
{
    public class ExecutarNumero
    {

        public void Executar()
        {

            var numero = new Numero();
            Console.Write("Informe um valor: ");
            numero.Valor = Convert.ToDouble(Console.ReadLine());

            var opcaoEscolhida = 0;
            while (opcaoEscolhida != 7)
            {
                var table = new ConsoleTable("Código", "Opção");

                table.Configure(x => x.EnableCount = false);

                table.AddRow("1", " Número completo por extenso")
                     .AddRow("2", " Unidade por extenso")
                     .AddRow("3", " Dezena por extenso")
                     .AddRow("4", " Centena por extenso")
                     .AddRow("5", " Milhar por extenso")
                     .AddRow("6", " Decimal por extenso")
                     .AddRow("7", "      SAIR       ");

                table.Write();


                var opcaoValida = false;
                while (opcaoValida == false)
                {
                    try
                    {
                        Console.Write("Informe a opção desejada para apresentar: ");
                        opcaoEscolhida = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();

                        if (opcaoEscolhida < 1 || opcaoEscolhida > 7)
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
                        numero.NumeroCompletoPorExtenso();

                    else if (opcaoEscolhida == 2)
                        numero.ObterUnidadePorExtenso();

                    else if (opcaoEscolhida == 3)
                        numero.ObterDezenaPorExtenso();

                    else if (opcaoEscolhida == 4)
                        numero.ObterCentenaPorExtenso();

                    else if (opcaoEscolhida == 5)
                        numero.ObterUnidadeDeMilharPorExtenso();

                    else if (opcaoEscolhida == 6)
                        numero.ObterDecimalPorExtenso();
                }
            }
        }
    }
}
