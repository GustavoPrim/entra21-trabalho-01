using TrabalhoOrientacaoObjetos01.Questao03;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;

namespace TrabalhoOrientacaoObjetos01.tests
{
    public class RelogioTest
    {
        private Relogio relogio = new Relogio();

        [Fact]
        public void ObterHoraPorExtenso()
        {

            //Arrange
            relogio.relogio = DateTime.Now;
            var resposta = relogio.ObterHoraPorExtenso();
            resposta.Should().Be("Vinte e quatro horas");

            
        }
       

        
    }
}
