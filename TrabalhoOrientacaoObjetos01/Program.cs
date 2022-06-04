using TrabalhoOrientacaoObjetos01.Questão01;
using TrabalhoOrientacaoObjetos01.Questao02;
using TrabalhoOrientacaoObjetos01.Questao03;


var opcaoSelecionada = 0;
while(opcaoSelecionada != 4)
{
    Console.WriteLine(@"           Menu         
01 - Exercício 01
02 - Exercício 02
03 - Exercício 03
04 -    SAIR  ");

    var opcaoValida = false;
    while(opcaoValida == false)
    {
        try
        {
            Console.Write("Digite a opção desejada: ");
            opcaoSelecionada = Convert.ToInt32(Console.ReadLine());
            if (opcaoSelecionada < 1 || opcaoSelecionada > 4)
            {
                Console.WriteLine("Opção do menu digitada não existe, digite a opção novamente.");
            }
            else
            {
                opcaoValida = true;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Digite uma opção de menu válida, informe o menu desejado novamente.");
        }
        if (opcaoSelecionada == 1)
        {
            ExercicioNumero numero = new ExercicioNumero();
            numero.Executar();
        }
        else if (opcaoSelecionada == 2)
        {
            ExecutarCalendario calendario = new ExecutarCalendario();
            calendario.Executar();
        }
        else if (opcaoSelecionada == 3)
        {
            Questao03 questao03 = new Questao03();
            questao03.Executar();
        }
    }
}