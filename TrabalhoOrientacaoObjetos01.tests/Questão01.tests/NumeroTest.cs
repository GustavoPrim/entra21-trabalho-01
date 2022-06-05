using TrabalhoOrientacaoObjetos01.Questão01;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;

namespace TrabalhoOrientacaoObjetos01.Questão01
{
    public class NumeroTest
    {

        [Theory]
        [InlineData(100, "Cem")]
        [InlineData(200, "Duzentos")]
        [InlineData(302, "Trezentos")]
        [InlineData(403, "Quatrocentos")]
        [InlineData(504, "Quinhentos")]
        [InlineData(605, "Seiscentos")]
        [InlineData(706, "Setecentos")]
        [InlineData(807, "Oitocentos")]
        [InlineData(908, "Novecentos")]

        public void Validar_10Numeros_Extenso(int numero, string numeroExtenso)
        {
            var numeros = new Numero();
            numeros.Valor = numero;

            var numeroConvertido = numeros.ObterCentenaPorExtenso();

            numeroConvertido.Should().Be(numeroExtenso);
        }
    }
}

