using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Demo.Tests
{
    public class CalculadoraTests
    {
        [Fact]
        public void Calculadora_Somar_RetornarValorSoma()
        {
            //Arrange
            var calculadora = new Calculadora();

            //Act
            var resultado = calculadora.Somar(2,2);

            //Assert
            Assert.Equal(4, resultado);
        }
        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(4, 1, 5)]
        [InlineData(10, 1, 11)]
        [InlineData(-11, 1, -10)]
        [InlineData(43, 7, 50)]
        public void Calculadora_Somar_RetornarValoresSomaCorrectos(double v1, double v2, double total)
        {
            //Arrange
            var calculadora = new Calculadora();
            //Act
            var resultado = calculadora.Somar(v1, v2);
            //Assert
            Assert.Equal(total, resultado);

        }
    }
}
