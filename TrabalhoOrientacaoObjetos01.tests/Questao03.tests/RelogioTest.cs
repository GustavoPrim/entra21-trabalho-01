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
        //Lucas Perez Alves


        [Theory]
        [InlineData(00, "meia noite")]
        [InlineData(01, "uma hora da manhã")]
        [InlineData(02, "duas horas da manhã")]
        [InlineData(03, "três horas da manhã")]
        [InlineData(04, "quatro horas da manhã")]
        [InlineData(05, "cinco horas da manhã")]
        [InlineData(06, "seis horas da manhã")]
        [InlineData(07, "sete horas da manhã")]
        [InlineData(08, "oito horas da manhã")]
        [InlineData(09, "nove horas da manhã")]
        [InlineData(10, "dez horas da manhã")]
        [InlineData(11, "onze horas da manhã")]
        [InlineData(12, "meio dia")]
        [InlineData(13, "uma hora da tarde")]
        [InlineData(14, "duas horas da tarde")]
        [InlineData(15, "três horas da tarde")]
        [InlineData(16, "quatro horas da tarde")]
        [InlineData(17, "cinco horas da tarde")]
        [InlineData(18, "seis horas da noite")]
        [InlineData(19, "sete horas da noite")]
        [InlineData(20, "oito horas da noite")]
        [InlineData(21, "nove horas da noite")]
        [InlineData(22, "dez horas da noite")]
        [InlineData(23, "onze horas da noite")]
        [InlineData(00, "meia noite")]

        public void Validar_ObterHoraPorExtenso(int horaDigitada, string horaEsperadaPorExtenso)
        {
            //Arrange
            var relogio = new Relogio();
            relogio.Hora = DateTime.Today.AddHours(horaDigitada);
            //Act
            var horaRelogio = relogio.ObterHoraPorExtenso();
            //Assert
            horaRelogio.Should().Be(horaEsperadaPorExtenso);
        }

        [Theory]
        [InlineData(01, "um minutos")]
        [InlineData(02, "dois minutos")]
        [InlineData(03, "três minutos")]
        [InlineData(04, "quatro minutos")]
        [InlineData(05, "cinco minutos")]
        [InlineData(07, "sete minutos")]
        [InlineData(08, "oito minutos")]
        [InlineData(09, "nove minutos")]
        [InlineData(10, "dez minutos")]
        [InlineData(11, "onze minutos")]
        [InlineData(12, "doze minutos")]
        [InlineData(13, "treze minutos")]
        [InlineData(14, "quatorze minutos")]
        [InlineData(15, "quinze minutos")]
        [InlineData(16, "dezesseis minutos")]
        [InlineData(17, "dezessete minutos")]
        [InlineData(18, "dezoito minutos")]
        [InlineData(19, "dezenove minutos")]
        [InlineData(20, "vinte minutos")]
        [InlineData(21, "vinte e um minutos")]
        [InlineData(22, "vinte e dois minutos")]
        [InlineData(23, "vinte e três minutos")]
        [InlineData(24, "vinte e quatro minutos")]
        [InlineData(25, "vinte e cinco minutos")]
        [InlineData(26, "vinte e seis minutos")]
        [InlineData(27, "vinte e sete minutos")]
        [InlineData(28, "vinte e oito minutos")]
        [InlineData(29, "vinte e nove minutos")]
        [InlineData(30, "trinta minutos")]
        [InlineData(31, "trinta e um minutos")]
        [InlineData(32, "trinta e dois minutos")]
        [InlineData(33, "trinta e três minutos")]
        [InlineData(34, "trinta e quatro minutos")]
        [InlineData(35, "trinta e cinco minutos")]
        [InlineData(36, "trinta e seis minutos")]
        [InlineData(37, "trinta e sete minutos")]
        [InlineData(38, "trinta e oito minutos")]
        [InlineData(39, "trinta e nove minutos")]
        [InlineData(40, "quarenta minutos")]
        [InlineData(41, "quarenta e um minutos")]
        [InlineData(42, "quarenta e dois minutos")]
        [InlineData(43, "quarenta e três minutos")]
        [InlineData(45, "quarenta e cinco minutos")]
        [InlineData(46, "quarenta e seis minutos")]
        [InlineData(47, "quarenta e sete minutos")]
        [InlineData(48, "quarenta e oito minutos")]
        [InlineData(49, "quarenta e nove minutos")]
        [InlineData(50, "cinquenta minutos")]
        [InlineData(51, "cinquenta e um minutos")]
        [InlineData(52, "cinquenta e dois minutos")]
        [InlineData(53, "cinquenta e três minutos")]
        [InlineData(54, "cinquenta e quatro minutos")]
        [InlineData(55, "cinquenta e cinco minutos")]
        [InlineData(56, "cinquenta e seis minutos")]
        [InlineData(57, "cinquenta e sete minutos")]
        [InlineData(58, "cinquenta e oito minutos")]
        [InlineData(59, "cinquenta e nove minutos")]
        [InlineData(00, "")]

        public void Validar_MinutoPorExtenso(int minutoDigitado, string minutoEsperadoPorExtenso)
        {
            //Arrange
            var relogio = new Relogio();
            relogio.Hora = DateTime.Today.AddMinutes(minutoDigitado);
            //Act
            var minutorelogio = relogio.ObterMinutosPorExtenso();
            //Assert
            minutorelogio.Should().Be(minutoEsperadoPorExtenso);

        }

        [Theory]
        [InlineData(01, "um segundos")]
        [InlineData(02, "dois segundos")]
        [InlineData(03, "três segundos")]
        [InlineData(04, "quatro segundos")]
        [InlineData(05, "cinco segundos")]
        [InlineData(07, "sete segundos")]
        [InlineData(08, "oito segundos")]
        [InlineData(09, "nove segundos")]
        [InlineData(10, "dez segundos")]
        [InlineData(11, "onze segundos")]
        [InlineData(12, "doze segundos")]
        [InlineData(13, "treze segundos")]
        [InlineData(14, "quatorze segundos")]
        [InlineData(15, "quinze segundos")]
        [InlineData(16, "dezesseis segundos")]
        [InlineData(17, "dezessete segundos")]
        [InlineData(18, "dezoito segundos")]
        [InlineData(19, "dezenove segundos")]
        [InlineData(20, "vinte segundos")]
        [InlineData(21, "vinte e um segundos")]
        [InlineData(22, "vinte e dois segundos")]
        [InlineData(23, "vinte e três segundos")]
        [InlineData(24, "vinte e quatro segundos")]
        [InlineData(25, "vinte e cinco segundos")]
        [InlineData(26, "vinte e seis segundos")]
        [InlineData(27, "vinte e sete segundos")]
        [InlineData(28, "vinte e oito segundos")]
        [InlineData(29, "vinte e nove segundos")]
        [InlineData(30, "trinta segundos")]
        [InlineData(31, "trinta e um segundos")]
        [InlineData(32, "trinta e dois segundos")]
        [InlineData(33, "trinta e três segundos")]
        [InlineData(34, "trinta e quatro segundos")]
        [InlineData(35, "trinta e cinco segundos")]
        [InlineData(36, "trinta e seis segundos")]
        [InlineData(37, "trinta e sete segundos")]
        [InlineData(38, "trinta e oito segundos")]
        [InlineData(39, "trinta e nove segundos")]
        [InlineData(40, "quarenta segundos")]
        [InlineData(41, "quarenta e um segundos")]
        [InlineData(42, "quarenta e dois segundos")]
        [InlineData(43, "quarenta e três segundos")]
        [InlineData(45, "quarenta e cinco segundos")]
        [InlineData(46, "quarenta e seis segundos")]
        [InlineData(47, "quarenta e sete segundos")]
        [InlineData(48, "quarenta e oito segundos")]
        [InlineData(49, "quarenta e nove segundos")]
        [InlineData(50, "cinquenta segundos")]
        [InlineData(51, "cinquenta e um segundos")]
        [InlineData(52, "cinquenta e dois segundos")]
        [InlineData(53, "cinquenta e três segundos")]
        [InlineData(54, "cinquenta e quatro segundos")]
        [InlineData(55, "cinquenta e cinco segundos")]
        [InlineData(56, "cinquenta e seis segundos")]
        [InlineData(57, "cinquenta e sete segundos")]
        [InlineData(58, "cinquenta e oito segundos")]
        [InlineData(59, "cinquenta e nove segundos")]
        [InlineData(00, "")]

        public void Validar_SegundosPorExtenso(int segundoDigitado, string segundoEsperadoporExtenso)
        {
            //Arrange
            var relogio = new Relogio();
            relogio.Hora = DateTime.Today.AddSeconds(segundoDigitado);
            //Act
            var segundoRelogio = relogio.ObterSegundosPorExtenso();
            //Assert
            segundoRelogio.Should().Be(segundoEsperadoporExtenso);


        }
    }
}
