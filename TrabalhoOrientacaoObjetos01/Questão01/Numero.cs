using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoOrientacaoObjetos01.Questão01
{
    public class Numero
    {
        public double Valor;

        public string ObterDecimalPorExtenso()
        {
            var valorPorExtenso = Valor.ToString("F");
            var tamanhoValor = valorPorExtenso.Length;
            var decimal1 = valorPorExtenso.Substring(tamanhoValor - 2, 1);
            var decimal2 = valorPorExtenso.Substring(tamanhoValor - 1, 1);
            var numeroDecimalFinal = "";

            if (decimal1 == "0" && decimal2 == "0")
                numeroDecimalFinal = "Zero";

            else if (decimal1 == "0" && decimal2 == "1")
                numeroDecimalFinal = "Zero um";

            else if (decimal1 == "0" && decimal2 == "2")
                numeroDecimalFinal = "Zero dois";

            else if (decimal1 == "0" && decimal2 == "3")
                numeroDecimalFinal = "Zero três";

            else if (decimal1 == "0" && decimal2 == "4")
                numeroDecimalFinal = "Zero quatro";

            else if (decimal1 == "0" && decimal2 == "5")
                numeroDecimalFinal = "Zero cinco";

            else if (decimal1 == "0" && decimal2 == "6")
                numeroDecimalFinal = "Zero seis";

            else if (decimal1 == "0" && decimal2 == "7")
                numeroDecimalFinal = "Zero sete";

            else if (decimal1 == "0" && decimal2 == "8")
                numeroDecimalFinal = "Zero oito";

            else if (decimal1 == "0" && decimal2 == "9")
                numeroDecimalFinal = "Zero nove";

            else if (decimal1 == "1" && decimal2 == "0")
                numeroDecimalFinal = "Dez";

            else if (decimal1 == "2" && decimal1 == "0")
                numeroDecimalFinal = "Vinte";

            else if (decimal1 == "3" && decimal1 == "0")
                numeroDecimalFinal = "Trinta";

            else if (decimal1 == "4" && decimal2 == "0")
                numeroDecimalFinal = "Quarenta";

            else if (decimal1 == "5" && decimal2 == "0")
                numeroDecimalFinal = "Cinquenta";

            else if (decimal1 == "6" && decimal2 == "0")
                numeroDecimalFinal = "Sessenta";

            else if (decimal1 == "7" && decimal2 == "0")
                numeroDecimalFinal = "Setenta";

            else if (decimal1 == "8" && decimal2 == "0")
                numeroDecimalFinal = "Oitenta";

            else if (decimal1 == "9" && decimal2 == "0")
                numeroDecimalFinal = "Noventa";

            Console.WriteLine($"Decimal escrito por extenso é {numeroDecimalFinal}");
            return numeroDecimalFinal;

        }

        public string ObterUnidadePorExtenso()
        {
            var unidadePorExtenso = Valor.ToString("F");
            var tamanhoUnidade = unidadePorExtenso.Length;
            var unidade = unidadePorExtenso.Substring(tamanhoUnidade - 4, 1);
            var unidadeConvertida = "";

            if (unidade == "0")
                unidadeConvertida = "Zero";

            else if (unidade == "1")
                unidadeConvertida = "Um";

            else if (unidade == "2")
                unidadeConvertida = "Dois";

            else if (unidade == "3")
                unidadeConvertida = "Três";

            else if (unidade == "4")
                unidadeConvertida = "Quatro";

            else if (unidade == "5")
                unidadeConvertida = "Cinco";

            else if (unidade == "6")
                unidadeConvertida = "Seis";

            else if (unidade == "7")
                unidadeConvertida = "Sete";

            else if (unidade == "8")
                unidadeConvertida = "Oito";

            else if (unidade == "9")
                unidadeConvertida = "Nove";

            Console.WriteLine($"Unidade por extenso é {unidadeConvertida}");
            return unidadeConvertida;
        }

        public string ObterDezenaPorExtenso()
        {
            var dezenaPorExtenso = Valor.ToString("F");
            var tamanhoUnidade = dezenaPorExtenso.Length;
            var unidade = dezenaPorExtenso.Substring(tamanhoUnidade - 5, 1);
            var dezenaConvertida = "";

            if (unidade == "1")
                dezenaConvertida = "Dez";

            else if (unidade == "1" && ObterUnidadeDeMilharPorExtenso() == "1")
                dezenaConvertida = "Onze";

            else if (unidade == "1" && ObterUnidadeDeMilharPorExtenso() == "1")
                dezenaConvertida = "Doze";

            else if (unidade == "1" && ObterUnidadeDeMilharPorExtenso() == "1")
                dezenaConvertida = "Treze";

            else if (unidade == "1" && ObterUnidadeDeMilharPorExtenso() == "1")
                dezenaConvertida = "Quatorze";

            else if (unidade == "1" && ObterUnidadeDeMilharPorExtenso() == "1")
                dezenaConvertida = "Quinze";

            else if (unidade == "1" && ObterUnidadeDeMilharPorExtenso() == "1")
                dezenaConvertida = "Dezesseis";

            else if (unidade == "1" && ObterUnidadeDeMilharPorExtenso() == "1")
                dezenaConvertida = "Dezessete";

            else if (unidade == "1" && ObterUnidadeDeMilharPorExtenso() == "1")
                dezenaConvertida = "Dezoito";

            else if (unidade == "1" && ObterUnidadeDeMilharPorExtenso() == "1")
                dezenaConvertida = "Dezenove";

            else if (unidade == "2")
                dezenaConvertida = "Vinte";

            else if (unidade == "3")
                dezenaConvertida = "Trinta";

            else if (unidade == "4")
                dezenaConvertida = "Quarenta";

            else if (unidade == "5")
                dezenaConvertida = "Cinquenta";

            else if (unidade == "6")
                dezenaConvertida = "Sessenta";

            else if (unidade == "7")
                dezenaConvertida = "Setenta";

            else if (unidade == "8")
                dezenaConvertida = "Oitenta";

            else if (unidade == "9")
                dezenaConvertida = "Noventa";

            Console.WriteLine($"Dezena por extenso é {dezenaConvertida}");
            return dezenaConvertida;
        }

        public string ObterCentenaPorExtenso()
        {
            var centenaPorExtenso = Valor.ToString("F");
            var tamanhoCentena = centenaPorExtenso.Length;
            var unidade = centenaPorExtenso.Substring(tamanhoCentena - 6, 1);
            var centenasConvertidas = "";

            if (unidade == "1")
                centenasConvertidas = "Cem";

            else if (unidade == "2")
                centenasConvertidas = "Duzentos";

            else if (unidade == "2")
                centenasConvertidas = "Trezentos";

            else if (unidade == "3")
                centenasConvertidas = "Quatrocentos";

            else if (unidade == "5")
                centenasConvertidas = "Quinhentos";

            else if (unidade == "6")
                centenasConvertidas = "Seiscentos";

            else if (unidade == "7")
                centenasConvertidas = "Setecentos";

            else if (unidade == "8")
                centenasConvertidas = "Oitocentos";

            else if (unidade == "9")
                centenasConvertidas = "Novecentos";

            Console.WriteLine($"Centena por extenso é {centenasConvertidas}");
            return centenasConvertidas;
        }

        public string ObterUnidadeDeMilharPorExtenso()
        {
            var unidadeMilharPorExtenso = Valor.ToString("F");
            var tamanhoMilhar = unidadeMilharPorExtenso.Length;
            var unidade = unidadeMilharPorExtenso.Substring(tamanhoMilhar - 7, 1);
            var unidadesMilharesConvertidas = "";

            if (unidade == "1")
                unidadesMilharesConvertidas = "Mil";

            else if (unidade == "2")
                unidadesMilharesConvertidas = "Dois mil";

            else if (unidade == "3")
                unidadesMilharesConvertidas = "Três mil";

            else if (unidade == "4")
                unidadesMilharesConvertidas = "Quatro Mil";

            else if (unidade == "5")
                unidadesMilharesConvertidas = "Cinco mil";

            else if (unidade == "6")
                unidadesMilharesConvertidas = "Seis mil";

            else if (unidade == "7")
                unidadesMilharesConvertidas = "Sete Mil";

            else if (unidade == "8")
                unidadesMilharesConvertidas = "Oito mil";

            else if (unidade == "9")
                unidadesMilharesConvertidas = "Nove mil";

            Console.WriteLine($"Unidade de milhar por extenso é {unidadesMilharesConvertidas}");
            return unidadesMilharesConvertidas;
        }

        public string NumeroCompletoPorExtenso()
        {
            var numeroConvertidoFinal = "";

            numeroConvertidoFinal = ObterUnidadeDeMilharPorExtenso() + ", " + ObterCentenaPorExtenso() + ", " + ObterDezenaPorExtenso() + ", " + ObterUnidadePorExtenso() + ", " + ObterDecimalPorExtenso();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            
            if (Valor > 0 && Valor < 10)
                ObterUnidadePorExtenso();

            else if (Valor > 10 && Valor < 100)
                ObterDezenaPorExtenso();

            else if (Valor > 100 && Valor < 1000)
                ObterCentenaPorExtenso();

            else if (Valor > 1000 && Valor < 10000)
                ObterUnidadeDeMilharPorExtenso();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine($"O número completo por extenso é {numeroConvertidoFinal}");
            return numeroConvertidoFinal;
        }
    }
}


