using Calculadora.Library;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
