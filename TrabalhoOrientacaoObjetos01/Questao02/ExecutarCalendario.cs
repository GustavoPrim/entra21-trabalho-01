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
            
            Console.WriteLine($"Mês informado digitado por extenso: {calendario.ObterMesPorExtenso()}");
        }
    }
}
