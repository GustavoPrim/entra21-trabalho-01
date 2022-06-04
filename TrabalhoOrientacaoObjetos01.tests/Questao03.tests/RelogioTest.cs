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


        [Fact]
        public void ObterHoraPorExtenso()
        {

            var relogio = new Relogio();
            relogio.Hora = new DateTime(01);
            var horaRelogio = relogio.ObterHoraPorExtenso();
            horaRelogio.Should().Be("uma hora da manhã");
        }

        [Fact]
        public void ValidarMinutoPorExtenso()
        {
            var relogio = new Relogio();
            relogio.Hora = new DateTime(30);
            var minutoRelogio = relogio.ObterMinutosPorExtenso();
            minutoRelogio.Should().Be("trinta");

        }

        [Fact]
        public void ValidarSegundoPorExtenso()
        {
            var relogio = new Relogio();
            relogio.Hora = new DateTime(01);
            var segundoRelogio = relogio.ObterSegundoExtenso();
            segundoRelogio.Should().Be("uma hora da manhã");

        }

        public void Validar10HorasCompletasPorExtenso()
        {

        }


    }
}
