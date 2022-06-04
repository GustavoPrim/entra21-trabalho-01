using TrabalhoOrientacaoObjetos01.Questao02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using FluentAssertions;

////GUSTAVO PRIM
namespace TrabalhoOrientacaoObjetos01.tests.Questao02.tests
{
    public class CalendarioTest
    {
        [Fact]
        public void Validar_Dia_Extenso()
        {
            var calendario = new Calendario();
            calendario.Data = new DateTime(2020, 08, 18);

            var diaPorExtenso = calendario.ObterDiaPorExtenso();

            diaPorExtenso.Should().Be("Dezoito ");
        }

        [Fact]
        public void Validar_Mes_Extenso()
        {
            var calendario = new Calendario();
            calendario.Data = new DateTime(2005, 05, 19);

            var mesPorExtenso = calendario.ObterMesPorExtenso();

            mesPorExtenso.Should().Be("Maio");
        }

        [Fact]
        public void Validar_Ano_Extenso()
        {
            var calendario = new Calendario();
            calendario.Data = new DateTime(1989, 07, 31);

            var anoPorExtenso = calendario.ObterAnoPorExtenso();

            anoPorExtenso.Should().Be("Mil novecentos e oitenta e nove");
        }

        [Fact]
        public void Validar_Data_Completa_Extenso()
        {
            var calendario = new Calendario();
            calendario.Data = new DateTime(1979, 08, 31);

            var dataCompletaPorExtenso = calendario.ObterDataCompletaPorExtenso();

            dataCompletaPorExtenso.Should().Be("Trinta e um de Agosto de Mil novecentos e setenta e nove");
        }
    }
}