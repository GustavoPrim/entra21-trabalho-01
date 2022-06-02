using TrabalhoOrientacaoObjetos01.Questao02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;

namespace TrabalhoOrientacaoObjetos01.tests.Questao02.tests
{
    public class CalendarioTest
    {
        [Fact]

        public void Validar_Obter_Mes_PorExtenso()
        {
            var calendario = new Calendario();

            calendario.Data = new DateTime(27, 08, 2025);

            var mesPorExtenso = calendario.ObterMesPorExtenso();

            mesPorExtenso.Should().Be("Agosto");
        }

        [Fact]

        public void Validar_Obter_Dia_PorExtenso()
        {
            var calendario = new Calendario();

            calendario.Data = new DateTime(27, 08, 2020);

            var diaPorExtenso = calendario.ObterDiaPorExtenso();

            diaPorExtenso.Should().Be("Vinte e sete");
        }
    }
}
