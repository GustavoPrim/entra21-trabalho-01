using TrabalhoOrientacaoObjetos01;

Console.WriteLine(@" ----------Menu----------
1 - Exercício 01
2 - Exercício 02
3 - Exercício 03");

Console.Write("Digite a opção desejada: ");
var OpcaoDesejada = Convert.ToInt32(Console.ReadLine());

if (OpcaoDesejada == 1)
{
    ExercicioNumero numero = new ExercicioNumero();
    numero.Executar();
}
else if (OpcaoDesejada == 2)
{
    ExecutarCalendario calendario = new ExecutarCalendario();
    calendario.Executar();
}
else if (OpcaoDesejada == 3)
{
    ExecutarRelogio relogio = new ExecutarRelogio;
    relogio.Executar();
}