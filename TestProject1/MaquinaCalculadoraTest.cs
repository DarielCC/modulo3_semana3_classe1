using Calculadora.Library;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Calculadora.Tests
{
    public class MaquinaCalculadoraTest
    {
        private Mock<ICalculadoraBasica> _mockCalculadoraBasica;
        private MaquinaCalculadora _maquinaCalculadora;

        public MaquinaCalculadoraTest()
        {
            _mockCalculadoraBasica = new Mock<ICalculadoraBasica>();
            _maquinaCalculadora = new MaquinaCalculadora(_mockCalculadoraBasica.Object);
        }

        [Fact]
        public void Somar_SomarDoisNumeros_Soma()
        {
            //Arrage
            var a = 10;
            var b = 2;
            _mockCalculadoraBasica.SetupSequence(m => m.SomarDoisNumeros(a, b))
                .Returns(a + b)
                .Returns((a += b) + b);

            //Act
            var soma = _maquinaCalculadora.Somar(a, b);

            //Assert
            Assert.Equal((a += b) + b, soma);
            _mockCalculadoraBasica.Verify(m => m.SomarDoisNumeros(a, b), Times.Once());
        }


        [Fact]
        public void Somar_SomarDoisNumeros_ZeroQuandoSomaMenorQueZero()
        {
            //Arrage
            var a = 1;
            var b = 2;
            _mockCalculadoraBasica.Setup(m => m.SomarDoisNumeros(a, b)).Returns(a + b);

            //Act
            var soma = _maquinaCalculadora.Somar(a, b);

            //Assert
            Assert.Equal(0, soma);
            _mockCalculadoraBasica.Verify(m => m.SomarDoisNumeros(a, b), Times.Once());
        }

        [Fact]
        public void Somar_SomarDoisNumeros_MenosUmQuandoAMaiorQueB()
        {
            //Arrage
            var a = 10;
            var b = 2;
            _mockCalculadoraBasica.Setup(m => m.SomarDoisNumeros(a, b)).Returns(a + b);

            //Act
            var soma = _maquinaCalculadora.Somar(a, b);

            //Assert
            Assert.Equal(-1, soma);
            Assert.NotNull(soma);
            _mockCalculadoraBasica.Verify(m => m.SomarDoisNumeros(a, b), Times.Never());
        }

        [Fact]
        public void Multiplicar_MultiplicaTresNumeros_Multiplicacao()
        {
            //Arrage
            var a = 1;
            var b = 2;
            var c = 3;

            _mockCalculadoraBasica.Setup(m => m.MultiplicarNumeros(a, b, c))
                .Returns(a * b * c);

            //Act
            var multiplicacao = _maquinaCalculadora.Multiplicar(a, b, c);

            //Assert
            Assert.Equal(a * b * c, multiplicacao);
            _mockCalculadoraBasica.Verify(m => m.MultiplicarNumeros(a, b, c), Times.Once());
        }
    }
}
