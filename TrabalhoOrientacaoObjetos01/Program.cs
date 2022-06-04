using ConsoleTables;
using TrabalhoOrientacaoObjetos01.Questão01;
using TrabalhoOrientacaoObjetos01.Questao02;
using TrabalhoOrientacaoObjetos01.Questao03;

var opcaoDesejada = 0;
while (opcaoDesejada != 4)
{
    var table = new ConsoleTable("Código", "Questões");

    table.Configure(x => x.EnableCount = false);

    table.AddRow("1", "Questão 01")
         .AddRow("2", "Questão 02")
         .AddRow("3", "Questão 03")
         .AddRow("4", "   SAIR ");

    table.Write();

    var opcaoValida = false;
    while (opcaoValida == false)
    {
        try
        {
            Console.Write("Digite a opção desejada: ");
            opcaoDesejada = Convert.ToInt32(Console.ReadLine());

            if (opcaoDesejada < 1 || opcaoDesejada > 4)
            {
                Console.WriteLine("Opção digitada de menu não existe, digite a opção novamente.");
            }
            else
            {
                opcaoValida = true;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Opção do menu digitada não é válida, digite a opção novamente");
        }

        if (opcaoDesejada == 1)
        {
            ExercicioNumero numero = new ExercicioNumero();
            numero.Executar();
        }
        else if (opcaoDesejada == 2)
        {
            ExecutarCalendario calendario = new ExecutarCalendario();
            calendario.Executar();
        }
        else if (opcaoDesejada == 3)
        {
            Questao03 questao03 = new Questao03();
            questao03.Executar();
        }
    }
}