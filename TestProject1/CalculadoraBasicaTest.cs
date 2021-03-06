using System;
using Xunit;
using Calculadora.Library;
using System.Collections.Generic;
using System.Linq;

namespace Calculadora.Tests
{
    public class CalculadoraBasicaTest
    {
        private CalculadoraBasica _calculadoraBasica;

        public CalculadoraBasicaTest() => _calculadoraBasica = new CalculadoraBasica();

        [Fact]
        [Trait("Soma", "Soma dois n?meros")]
        public void SomarDoisNumeros_SomaDoisNumero_ResultadoEsperado3_Antigo()
        {
            //AAA

            //Arrange
            var a = 1;
            var b = 2;
            

            //Act
            var soma = _calculadoraBasica.SomarDoisNumeros(a, b);

            //Assert
            Assert.Equal(a + b, soma);
        }

        [Theory]
        [Trait("Soma", "Soma dois n?meros")]
        [InlineData(1, 2, 3)]
        [InlineData(10, 25, 35)]
        [InlineData(100, 30, 130)]
        [InlineData(6, 8, 14)]
        public void SomarDoisNumeros_SomaDoisNumero_ResultadoEsperadoSoma(int a, int b, int result)
        {
            //AAA

            //Arrange
            

            //Act
            var soma = _calculadoraBasica.SomarDoisNumeros(a, b);

            //Assert
            Assert.Equal(result, soma);
        }


        [Fact(Skip = "Fluxo n?o valido")]
        public void SomarDoisNumeros_Erro_ResultadoEsperadoMenos1()
        {
            //AAA

            //Arrange
            var a = -50;
            var b = 2;
            

            //Act
            var soma = _calculadoraBasica.SomarDoisNumeros(a, b);

            //Assert
            Assert.Equal(-1, soma);
        }

        [Theory]
        [Trait("Soma", "Valida n?meros negativos")]
        [InlineData(-100, -30, "Par?metro inv?lido")]
        [InlineData(-6, -8, "Par?metro inv?lido")]
        public void SomarDoisNumeros_ArgumentosNegativos_RetornaArgumentException(int a, int b, string mensagem)
        {
            //AAA

            //Arrange
            

            //Act
            var ex = Assert.Throws<ArgumentException>(() => _calculadoraBasica.SomarDoisNumeros(a, b));

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
            

            //Act
            var ex = Assert.Throws<ArgumentException>(() => _calculadoraBasica.SomarDoisNumeros(a, b));

            //Assert
            Assert.Equal("O segundo argumento n?o pode ser maior do que 1000", ex.Message);
        }

        [Theory]
        [InlineData(100, 2030, "O segundo argumento n?o pode ser maior do que 1000")]
        [InlineData(6, 1001, "O segundo argumento n?o pode ser maior do que 1000")]
        public void SomarDoisNumeros_ArgumentoInvalidoQuandoArgumentoMaiorQue1000_RetornaArgumentException_Theory(int a, int b, string mensagem)
        {
            //AAA

            //Arrange
            

            //Act
            var ex = Assert.Throws<ArgumentException>(() => _calculadoraBasica.SomarDoisNumeros(a, b));

            //Assert
            Assert.Equal(mensagem, ex.Message);
        }

        [Theory]
        [Trait("Multiplica??o", "Multiplica 3 n?meros")]
        [InlineData(2, 3, 6, 36)]
        [InlineData(1, 2, 3, 6)]
        public void MultiplicarNumeros_MultiplicacaoDe3Numeros_RetornarValorDaMultiplicacao(int a, int b, int c, int valor)
        {
            //AAA

            //Arrange
            

            //Act
            var multiplicacao = _calculadoraBasica.MultiplicarNumeros(a, b, c);

            //Assert
            Assert.Equal(valor, multiplicacao);
        }

        [Theory]
        [Trait("Multiplica??o", "Valida par?metros negativos")]
        [InlineData(-1, 2, 4, "Par?metros inv?lidos")]
        [InlineData(1, -2, 4, "Par?metros inv?lidos")]
        [InlineData(1, 2, -4, "Par?metros inv?lidos")]
        [InlineData(-1, -2, -4, "Par?metros inv?lidos")]
        public void MultiplicarNumeros_ArgumentoInvalidoQuandoAlgumParametroNegativo_RetornaArgumentException(int a, int b, int c, string mensagem)
        {
            //AAA

            //Arrange
            

            //Act
            var ex = Assert.Throws<ArgumentException>(() => _calculadoraBasica.MultiplicarNumeros(a, b, c));

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
            

            //Act
            var divisao = _calculadoraBasica.DividirNumeros(a, b);

            //Assert
            Assert.Equal(valor, divisao);
        }

        [Theory]
        [InlineData(1, 0, "Denominador n?o pode ser zero")]
        public void DividirNumeros_ArgumentoInvalidoQuandoSegundoParametroZero_RetornaArgumentException(int a, int b, string mensagem)
        {
            //AAA

            //Arrange
            

            //Act
            var ex = Assert.Throws<ArgumentException>(() => _calculadoraBasica.DividirNumeros(a, b));

            //Assert
            Assert.Equal(mensagem, ex.Message);
        }

        [Theory]
        [InlineData(-1, 3, "Par?metro inv?lido")]
        [InlineData(1, -1, "Par?metro inv?lido")]
        [InlineData(-1, -3, "Par?metro inv?lido")]
        public void DividirNumeros_ArgumentoInvalidoQuandoAlgumParametroNegativo_RetornaArgumentException(int a, int b, string mensagem)
        {
            //AAA

            //Arrange
            

            //Act
            var ex = Assert.Throws<ArgumentException>(() => _calculadoraBasica.DividirNumeros(a, b));

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
            

            //Act
            var divisao = _calculadoraBasica.DividirSoma(a, b, c);

            //Assert
            Assert.Equal(valor, divisao);
        }

        [Fact]
        public void SomarLista_SomaDosNumerosDeUmaLista_RetornarSoma()
        {
            //Arrange
            var lista = new List<int> { 1, 2, 3 };
            

            //Act
            var soma = _calculadoraBasica.SomarLista(lista);

            //Assert
            Assert.Equal(lista.Sum(), soma);
        }

        [Fact]
        public void SomarLista_ArgumentoInvalidoQuandoListaVazia_RetornaArgumentException()
        {
            //Arrange
            var lista = new List<int> { };
            

            //Act
            var ex = Assert.Throws<ArgumentException>(() => _calculadoraBasica.SomarLista(lista));

            //Assert
            Assert.Equal("Lista vaz?a", ex.Message);
        }


        [Fact]
        public void SomarLista_ArgumentoInvalidoQuandoNumerosDaListaEmZero_RetornaArgumentException()
        {
            //Arrange
            var lista = new List<int> { 0, 0 };
            

            //Act
            var ex = Assert.Throws<ArgumentException>(() => _calculadoraBasica.SomarLista(lista));

            //Assert
            Assert.Equal("Lista com elementos inv?lidos", ex.Message);
        }

        [Theory]
        [MemberData(nameof(ListaDeNumeros))]
        public void SomarLista_SomaValoresDeUmaLista_RetornarSoma(IEnumerable<int> lista, int valor)
        {
            //AAA

            //Arrange
            

            //Act
            var soma = _calculadoraBasica.SomarLista(lista);

            //Assert
            Assert.Equal(valor, soma);
        }

        [Fact]
        public void SubtrairNumeros_SubtraiDoisNumeros_RetornaSubtracao()
        {
            //Arrange
            

            //Act
            var subtracao = _calculadoraBasica.SubtrairNumeros(2, 105);

            //Assert
            Assert.Equal(103, subtracao);
        }


        [Fact]
        public void SubtrairNumeros_SubtraiDoisNumerosDeveEstarNoIntervalo_RetornaSubtracao()
        {
            //Arrange
            

            //Act
            var subtracao = _calculadoraBasica.SubtrairNumeros(2, 300);

            //Assert
            Assert.InRange(subtracao, 1, 500);
        }


        [Theory]
        [InlineData(3, 1, "Par?metro inv?lido")]
        [InlineData(100, 99, "Par?metro inv?lido")]
        public void SubtrairNumeros_ArgumentoInvalidoQuandoSegundoParametroMenorDoQuePrimeiro_RetornaArgumentException(int a, int b, string mensagem)
        {
            //AAA

            //Arrange
            

            //Act
            var ex = Assert.Throws<ArgumentException>(() => _calculadoraBasica.SubtrairNumeros(a, b));

            //Assert
            Assert.Equal(mensagem, ex.Message);
        }


        [Theory]
        [InlineData(-3, 5, "Par?metro inv?lido")]
        [InlineData(-2, -1, "Par?metro inv?lido")]
        public void SubtrairNumeros_ArgumentoInvalidoQuandoParametroNegativo_RetornaArgumentException(int a, int b, string mensagem)
        {
            //AAA

            //Arrange
            

            //Act
            var ex = Assert.Throws<ArgumentException>(() => _calculadoraBasica.SubtrairNumeros(a, b));

            //Assert
            Assert.Equal(mensagem, ex.Message);
        }


        [Theory]
        [InlineData(1500, 1600, "Par?metro inv?lido")]
        [InlineData(80, 99, "Par?metro inv?lido")]
        public void SubtrairNumeros_ArgumentoInvalidoQuandoSegundoParametroForaDoIntervalo_RetornaArgumentException(int a, int b, string mensagem)
        {
            //AAA

            //Arrange
            

            //Act
            var ex = Assert.Throws<ArgumentException>(() => _calculadoraBasica.SubtrairNumeros(a, b));

            //Assert
            Assert.Equal(mensagem, ex.Message);
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