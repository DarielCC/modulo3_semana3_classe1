using System;
using Xunit;
using Calculadora.Library;
using System.Collections.Generic;
using System.Linq;

namespace Calculadora.Tests
{
    public class CalculadoraBasicaTest
    {
        [Fact]
        [Trait("Soma", "Soma dois números")]
        public void SomarDoisNumeros_SomaDoisNumero_ResultadoEsperado3_Antigo()
        {
            //AAA

            //Arrange
            var a = 1;
            var b = 2;
            var class1 = new CalculadoraBasica();

            //Act
            var soma = class1.SomarDoisNumeros(a, b);

            //Assert
            Assert.Equal(a + b, soma);
        }

        [Theory]
        [Trait("Soma", "Soma dois números")]
        [InlineData(1, 2, 3)]
        [InlineData(10, 25, 35)]
        [InlineData(100, 30, 130)]
        [InlineData(6, 8, 14)]
        public void SomarDoisNumeros_SomaDoisNumero_ResultadoEsperadoSoma(int a, int b, int result)
        {
            //AAA

            //Arrange
            var class1 = new CalculadoraBasica();

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
            var class1 = new CalculadoraBasica();

            //Act
            var soma = class1.SomarDoisNumeros(a, b);

            //Assert
            Assert.Equal(-1, soma);
        }

        [Theory]
        [Trait("Soma", "Valida números negativos")]
        [InlineData(-100, -30, "Parámetro inválido")]
        [InlineData(-6, -8, "Parámetro inválido")]
        public void SomarDoisNumeros_ArgumentosNegativos_RetornaArgumentException(int a, int b, string mensagem)
        {
            //AAA

            //Arrange
            var class1 = new CalculadoraBasica();

            //Act
            var ex = Assert.Throws<ArgumentException>(() => class1.SomarDoisNumeros(a, b));

            //Assert
            Assert.Equal(mensagem, ex.Message);
        }

        [Fact]
        [Trait("Soma", "Valida argumento maior do que 1000")]
        public void SomarDoisNumeros_ArgumentoInvalidoQuandoArgumentoMaiorQue1000_RetornaArgumentException_Fact()
        {
            //AAA

            //Arrange
            var a = 1;
            var b = 1001;
            var class1 = new CalculadoraBasica();

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
            var class1 = new CalculadoraBasica();

            //Act
            var ex = Assert.Throws<ArgumentException>(() => class1.SomarDoisNumeros(a, b));

            //Assert
            Assert.Equal(mensagem, ex.Message);
        }

        [Theory]
        [Trait("Multiplicação", "Multiplica 3 números")]
        [InlineData(2, 3, 6, 36)]
        [InlineData(1, 2, 3, 6)]
        public void MultiplicarNumeros_MultiplicacaoDe3Numeros_RetornarValorDaMultiplicacao(int a, int b, int c, int valor)
        {
            //AAA

            //Arrange
            var class1 = new CalculadoraBasica();

            //Act
            var multiplicacao = class1.MultiplicarNumeros(a, b, c);

            //Assert
            Assert.Equal(valor, multiplicacao);
        }

        [Theory]
        [Trait("Multiplicação", "Valida parámetros negativos")]
        [InlineData(-1, 2, 4, "Parámetros inválidos")]
        [InlineData(1, -2, 4, "Parámetros inválidos")]
        [InlineData(1, 2, -4, "Parámetros inválidos")]
        [InlineData(-1, -2, -4, "Parámetros inválidos")]
        public void MultiplicarNumeros_ArgumentoInvalidoQuandoAlgumParametroNegativo_RetornaArgumentException(int a, int b, int c, string mensagem)
        {
            //AAA

            //Arrange
            var class1 = new CalculadoraBasica();

            //Act
            var ex = Assert.Throws<ArgumentException>(() => class1.MultiplicarNumeros(a, b, c));

            //Assert
            Assert.Equal(mensagem, ex.Message);
        }

        [Theory]
        [InlineData(3, 1, 3)]
        [InlineData(6, 2, 3)]
        [InlineData(15, 3, 5)]
        public void DividirNumeros_DivisaoDe2Numeros_RetornarValorDaDivisao(int a, int b, int valor)
        {
            //AAA

            //Arrange
            var class1 = new CalculadoraBasica();

            //Act
            var divisao = class1.DividirNumeros(a, b);

            //Assert
            Assert.Equal(valor, divisao);
        }

        [Theory]
        [InlineData(1, 0, "Denominador não pode ser zero")]
        public void DividirNumeros_ArgumentoInvalidoQuandoSegundoParametroZero_RetornaArgumentException(int a, int b, string mensagem)
        {
            //AAA

            //Arrange
            var class1 = new CalculadoraBasica();

            //Act
            var ex = Assert.Throws<ArgumentException>(() => class1.DividirNumeros(a, b));

            //Assert
            Assert.Equal(mensagem, ex.Message);
        }

        [Theory]
        [InlineData(-1, 3, "Parámetro inválido")]
        [InlineData(1, -1, "Parámetro inválido")]
        [InlineData(-1, -3, "Parámetro inválido")]
        public void DividirNumeros_ArgumentoInvalidoQuandoAlgumParametroNegativo_RetornaArgumentException(int a, int b, string mensagem)
        {
            //AAA

            //Arrange
            var class1 = new CalculadoraBasica();

            //Act
            var ex = Assert.Throws<ArgumentException>(() => class1.DividirNumeros(a, b));

            //Assert
            Assert.Equal(mensagem, ex.Message);
        }

        [Theory]
        [InlineData(2, 1, 3, 1)]
        [InlineData(6, 2, 2, 4)]
        [InlineData(5, 5, 5, 2)]
        public void DividirSoma_DivisaoDaSomaDe2NumerosComOutroNumero_RetornarValorDaDivisao(int a, int b, int c, int valor)
        {
            //AAA

            //Arrange
            var class1 = new CalculadoraBasica();

            //Act
            var divisao = class1.DividirSoma(a, b, c);

            //Assert
            Assert.Equal(valor, divisao);
        }

        [Fact]
        public void SomarLista_SomaDosNumerosDeUmaLista_RetornarSoma()
        {
            //Arrange
            var lista = new List<int> { 1, 2, 3 };
            var class1 = new CalculadoraBasica();

            //Act
            var soma = class1.SomarLista(lista);

            //Assert
            Assert.Equal(lista.Sum(), soma);
        }

        [Fact]
        public void SomarLista_ArgumentoInvalidoQuandoListaVazia_RetornaArgumentException()
        {
            //Arrange
            var lista = new List<int> { };
            var class1 = new CalculadoraBasica();

            //Act
            var ex = Assert.Throws<ArgumentException>(() => class1.SomarLista(lista));

            //Assert
            Assert.Equal("Lista vazía", ex.Message);
        }


        [Fact]
        public void SomarLista_ArgumentoInvalidoQuandoNumerosDaListaEmZero_RetornaArgumentException()
        {
            //Arrange
            var lista = new List<int> { 0, 0 };
            var class1 = new CalculadoraBasica();

            //Act
            var ex = Assert.Throws<ArgumentException>(() => class1.SomarLista(lista));

            //Assert
            Assert.Equal("Lista com elementos inválidos", ex.Message);
        }

        [Theory]
        [MemberData(nameof(ListaDeNumeros))]
        public void SomarLista_SomaValoresDeUmaLista_RetornarSoma(IEnumerable<int> lista, int valor)
        {
            //AAA

            //Arrange
            var class1 = new CalculadoraBasica();

            //Act
            var soma = class1.SomarLista(lista);

            //Assert
            Assert.Equal(valor, soma);
        }

        private static IEnumerable<object[]> ListaDeNumeros()
        {
            yield return new object[] { new List<int> { 1, 2, 3 }, 6 };
            yield return new object[] { new List<int> { 4, 5, 6 }, 15 };
            yield return new object[] { new List<int> { 7, 8, 9 }, 24 };
            yield return new object[] { new List<int> { 0, 0, 9 }, 9 };
        }
    }
}