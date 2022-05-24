using ClassLibrary1;
using System;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void SomarDoisNumeros_SomaDoisNumero_ResultadoEsperado3_Antigo()
        {
            //AAA

            //Arrange
            var a = 1;
            var b = 2;
            var class1 = new Class1();

            //Act
            var soma = class1.SomarDoisNumeros(a, b);

            //Assert
            Assert.Equal(a + b, soma);
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(10, 25, 35)]
        [InlineData(100, 30, 130)]
        [InlineData(6, 8, 14)]
        public void SomarDoisNumeros_SomaDoisNumero_ResultadoEsperadoSoma(int a, int b, int result)
        {
            //AAA

            //Arrange
            var class1 = new Class1();

            //Act
            var soma = class1.SomarDoisNumeros(a, b);

            //Assert
            Assert.Equal(result, soma);
        }


        [Fact(Skip = "Fluxo não valido")]
        public void SomarDoisNumeros_Erro_ResultadoEsperadoMenos1()
        {
            //AAA

            //Arrange
            var a = -50;
            var b = 2;
            var class1 = new Class1();

            //Act
            var soma = class1.SomarDoisNumeros(a, b);

            //Assert
            Assert.Equal(-1, soma);
        }

        [Theory]
        [InlineData(-100, -30, "O segundo argumento não pode ser negativo")]
        [InlineData(-6, -8, "O segundo argumento não pode ser negativo")]
        public void SomarDoisNumeros_ArgumentosNegativos_RetornaArgumentException(int a, int b, string mensagem)
        {
            //AAA

            //Arrange
            var class1 = new Class1();

            //Act
            var ex = Assert.Throws<ArgumentException>(() => class1.SomarDoisNumeros(a, b));

            //Assert
            Assert.Equal(mensagem, ex.Message);
        }

        [Fact]
        public void SomarDoisNumeros_ArgumentoInvalidoQuandoArgumentoMaiorQue1000_RetornaArgumentException_Fact()
        {
            //AAA

            //Arrange
            var a = -1;
            var b = 1001;
            var class1 = new Class1();

            //Act
            var ex = Assert.Throws<ArgumentException>(() => class1.SomarDoisNumeros(a, b));

            //Assert
            Assert.Equal("O segundo argumento não pode ser maior do que 1000", ex.Message);
        }


        [Theory]
        [InlineData(100, 2030, "O segundo argumento não pode ser maior do que 1000")]
        [InlineData(6, 1001, "O segundo argumento não pode ser maior do que 1000")]
        public void SomarDoisNumeros_ArgumentoInvalidoQuandoArgumentoMaiorQue1000_RetornaArgumentException_Theory(int a, int b, string mensagem)
        {
            //AAA

            //Arrange
            var class1 = new Class1();

            //Act
            var ex = Assert.Throws<ArgumentException>(() => class1.SomarDoisNumeros(a, b));

            //Assert
            Assert.Equal(mensagem, ex.Message);
        }
    }
}