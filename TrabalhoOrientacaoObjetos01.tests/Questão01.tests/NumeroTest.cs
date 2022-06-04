using TrabalhoOrientacaoObjetos01.Questão01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;

namespace TrabalhoOrientacaoObjetos01.tests.Questão01.tests
{
    public class NumeroTest
    {
        [Fact]
        public void Validar_Numero_Decimal()
        {
            var numero = new Numero();
            numero.Valor = 20.20;
            var decimalNumero = numero.ObterDecimalPorExtenso();
            decimalNumero.Should().Be("");
            
         




        }










        }
}
