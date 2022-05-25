using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Library
{
    public interface ICalculadoraBasica
    {
        public int SomarDoisNumeros(int a, int b);

        public decimal MultiplicarNumeros(int a, int b, int c);

        public decimal DividirNumeros(int a, int b);

        public decimal DividirSoma(int a, int b, int c);

        public decimal SomarLista(IEnumerable<int> lista);
        
        public decimal SubtrairNumeros(int a, int b);
    }
}
