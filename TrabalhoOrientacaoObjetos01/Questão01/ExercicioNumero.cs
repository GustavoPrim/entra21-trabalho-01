
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoOrientacaoObjetos01.Questão01
{
    public class ExercicioNumero
    {

        public void Executar()
        {

            Numero numero = new Numero();
            Console.WriteLine("Informe um valor: ");
            numero.Valor = Convert.ToDouble(Console.ReadLine());

             Console.WriteLine("O número por extenso é: "+ numero.NumeroCompletoPorExtenso());

        }



    }
}
