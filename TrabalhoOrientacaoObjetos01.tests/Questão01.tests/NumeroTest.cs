using TrabalhoOrientacaoObjetos01.Questão01;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TrabalhoOrientacaoObjetos01.Questão01
{
    public class NumeroTest
    {

        [Fact]
        public void Validar_Centena_Por_Extenso()
        {
            var numero = new Numero();
            numero.Valor = 100;

            var valorConvertido = numero.ObterCentenaPorExtenso();

            valorConvertido.Should().Be("Cem");

        }










        }
}
