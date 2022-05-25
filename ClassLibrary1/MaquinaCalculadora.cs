namespace Calculadora.Library
{
    public class MaquinaCalculadora
    {
        private ICalculadoraBasica _calculadoraBasica;

        public MaquinaCalculadora(ICalculadoraBasica calculadoraBasica) => _calculadoraBasica = calculadoraBasica;

        public int? Somar(int a, int b)
        {
            if(a > b)
                return -1;

            if (b > a)
                return null;

            var soma = _calculadoraBasica.SomarDoisNumeros(a, b);

            if(soma <= 10)
                return 0;

            a += b;

            soma = _calculadoraBasica.SomarDoisNumeros(a, b);

            return soma;
        }

        public decimal Multiplicar(int a, int b, int c) => _calculadoraBasica.MultiplicarNumeros(a, b, c);

        public decimal Dividir(int a, int b) => _calculadoraBasica.DividirNumeros(a, b);

        public decimal Subtrair(int a, int b) => _calculadoraBasica.SubtrairNumeros(a, b);
    }
}
