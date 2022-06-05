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
        [Theory]
        [InlineData(01, "Janeiro")]
        [InlineData(02, "Fevereiro")]
        [InlineData(03, "Março")]
        [InlineData(04, "Abril")]
        [InlineData(05, "Maio")]
        [InlineData(06, "Junho")]
        [InlineData(07, "Julho")]
        [InlineData(08, "Agosto")]
        [InlineData(09, "Setembro")]
        [InlineData(10, "Outubro")]
        [InlineData(11, "Novembro")]
        [InlineData(12, "Dezembro")]

        public void Validar_Meses_Extenso(int mes, string mesPorExtenso)
        {
            //Arrange
            var calendario = new Calendario();
            calendario.Data = new DateTime(2022, mes, 01);

            //Act
            var mesesPorExtenso = calendario.ObterMesPorExtenso();

            //Assert
            mesesPorExtenso.Should().Be(mesPorExtenso);
        }

        [Theory]
        [InlineData(01, "Um ")]
        [InlineData(02, "Dois ")]
        [InlineData(03, "Três ")]
        [InlineData(04, "Quatro ")]
        [InlineData(05, "Cinco ")]
        [InlineData(06, "Seis ")]
        [InlineData(07, "Sete ")]
        [InlineData(08, "Oito ")]
        [InlineData(09, "Nove ")]
        [InlineData(10, "Dez ")]
        [InlineData(11, "Onze ")]
        [InlineData(12, "Doze ")]
        [InlineData(13, "Treze ")]
        [InlineData(14, "Quatorze ")]
        [InlineData(15, "Quinze ")]
        [InlineData(16, "Dezesseis ")]
        [InlineData(17, "Dezessete ")]
        [InlineData(18, "Dezoito ")]
        [InlineData(19, "Dezenove ")]
        [InlineData(20, "Vinte")]
        [InlineData(21, "Vinte e um")]
        [InlineData(22, "Vinte e dois")]
        [InlineData(23, "Vinte e três")]
        [InlineData(24, "Vinte e quatro")]
        [InlineData(25, "Vinte e cinco")]
        [InlineData(26, "Vinte e seis")]
        [InlineData(27, "Vinte e sete")]
        [InlineData(28, "Vinte e oito")]
        [InlineData(29, "Vinte e nove")]
        [InlineData(30, "Trinta")]
        [InlineData(31, "Trinta e um")]

        public void Validar_Dias_Extenso(int dia, string diaExtenso)
        {
            //Arrange
            var calendario = new Calendario();
            calendario.Data = new DateTime(2022, 12, dia);

            //Act
            var diaPorExtenso = calendario.ObterDiaPorExtenso();

            //Assert
            diaPorExtenso.Should().Be(diaExtenso);
        }

        [Theory]
        [InlineData(1970, "Mil novecentos e setenta")]
        [InlineData(1971, "Mil novecentos e setenta e um")]
        [InlineData(1972, "Mil novecentos e setenta e dois")]
        [InlineData(1973, "Mil novecentos e setenta e três")]
        [InlineData(1974, "Mil novecentos e setenta e quatro")]
        [InlineData(1975, "Mil novecentos e setenta e cinco")]
        [InlineData(1976, "Mil novecentos e setenta e seis")]
        [InlineData(1977, "Mil novecentos e setenta e sete")]
        [InlineData(1978, "Mil novecentos e setenta e oito")]
        [InlineData(1979, "Mil novecentos e setenta e nove")]
        [InlineData(1980, "Mil novecentos e oitenta")]
        [InlineData(1981, "Mil novecentos e oitenta e um")]
        [InlineData(1982, "Mil novecentos e oitenta e dois")]
        [InlineData(1983, "Mil novecentos e oitenta e três")]
        [InlineData(1984, "Mil novecentos e oitenta e quatro")]
        [InlineData(1985, "Mil novecentos e oitenta e cinco")]
        [InlineData(1986, "Mil novecentos e oitenta e seis")]
        [InlineData(1987, "Mil novecentos e oitenta e sete")]
        [InlineData(1988, "Mil novecentos e oitenta e oito")]
        [InlineData(1989, "Mil novecentos e oitenta e nove")]
        [InlineData(1990, "Mil novecentos e noventa")]
        [InlineData(1991, "Mil novecentos e noventa e um")]
        [InlineData(1992, "Mil novecentos e noventa e dois")]
        [InlineData(1993, "Mil novecentos e noventa e três")]
        [InlineData(1994, "Mil novecentos e noventa e quatro")]
        [InlineData(1995, "Mil novecentos e noventa e cinco")]
        [InlineData(1996, "Mil novecentos e noventa e seis")]
        [InlineData(1997, "Mil novecentos e noventa e sete")]
        [InlineData(1998, "Mil novecentos e noventa e oito")]
        [InlineData(1999, "Mil novecentos e noventa e nove")]
        [InlineData(2000, "Dois mil")]
        [InlineData(2001, "Dois mil e um")]
        [InlineData(2002, "Dois mil e dois")]
        [InlineData(2003, "Dois mil e três")]
        [InlineData(2004, "Dois mil e quatro")]
        [InlineData(2005, "Dois mil e cinco")]
        [InlineData(2006, "Dois mil e seis")]
        [InlineData(2007, "Dois mil e sete")]
        [InlineData(2008, "Dois mil e oito")]
        [InlineData(2009, "Dois mil e nove")]
        [InlineData(2010, "Dois mil e dez")]
        [InlineData(2011, "Dois mil e onze")]
        [InlineData(2012, "Dois mil e doze")]
        [InlineData(2013, "Dois mil e treze")]
        [InlineData(2014, "Dois mil e quatorze")]
        [InlineData(2015, "Dois mil e quinze")]
        [InlineData(2016, "Dois mil e dezesseis")]
        [InlineData(2017, "Dois mil e dezessete")]
        [InlineData(2018, "Dois mil e dezoito")]
        [InlineData(2019, "Dois mil e dezenove")]
        [InlineData(2020, "Dois mil e vinte")]
        [InlineData(2021, "Dois mil e vinte e um")]
        [InlineData(2022, "Dois mil e vinte e dois")]
        [InlineData(2023, "Dois mil e vinte e três")]
        [InlineData(2024, "Dois mil e vinte e quatro")]
        [InlineData(2025, "Dois mil e vinte e cinco")]
        [InlineData(2026, "Dois mil e vinte e seis")]
        [InlineData(2027, "Dois mil e vinte e sete")]
        [InlineData(2028, "Dois mil e vinte e oito")]
        [InlineData(2029, "Dois mil e vinte e nove")]
        [InlineData(2030, "Dois mil e trinta")]

        public void Validar_Anos_Extenso(int ano, string anoExtenso)
        {
            //Arrange
            var calendario = new Calendario();
            calendario.Data = new DateTime(ano, 08, 18);

            //Act
            var anoPorExtenso = calendario.ObterAnoPorExtenso();

            //Assert
            anoPorExtenso.Should().Be(anoExtenso);
        }

        [Theory]
        [InlineData(19, 09, 2004, "Dezenove  de Setembro de Dois mil e quatro")]
        [InlineData(25, 05, 2005, "Vinte e cinco de Maio de Dois mil e cinco")]
        [InlineData(18, 08, 2005, "Dezoito  de Agosto de Dois mil e cinco")]
        [InlineData(15, 02, 2007, "Quinze  de Fevereiro de Dois mil e sete")]
        [InlineData(01, 01, 1989, "Um  de Janeiro de Mil novecentos e oitenta e nove")]
        [InlineData(25, 12, 1979, "Vinte e cinco de Dezembro de Mil novecentos e setenta e nove")]
        [InlineData(11, 11, 2030, "Onze  de Novembro de Dois mil e trinta")]
        [InlineData(10, 10, 1999, "Dez  de Outubro de Mil novecentos e noventa e nove")]
        [InlineData(03, 03, 2003, "Três  de Março de Dois mil e três")]
        [InlineData(24, 04, 1994, "Vinte e quatro de Abril de Mil novecentos e noventa e quatro")]
        [InlineData(16, 06, 2006, "Dezesseis  de Junho de Dois mil e seis")]
        [InlineData(08, 07, 1977, "Oito  de Julho de Mil novecentos e setenta e sete")]

        public void Validar_Datas_Diferentes(int dia, int mes, int ano, string dataPorExtenso)
        {
            //Arrange
            var calendario = new Calendario();
            calendario.Data = new DateTime(ano, mes, dia);

            //Act
            var dataCompletaPorExtenso = calendario.ObterDataCompletaPorExtenso();

            //Assert
            dataCompletaPorExtenso.Should().Be(dataPorExtenso);
        }
    }
}