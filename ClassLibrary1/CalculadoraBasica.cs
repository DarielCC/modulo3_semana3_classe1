namespace Calculadora.Library
{
    public class CalculadoraBasica
    {
        public int SomarDoisNumeros(int a, int b)
        {
            if (a < 0 || b < 0)
                throw new ArgumentException("Parámetro inválido");

            if (b > 1000)
                throw new ArgumentException("O segundo argumento não pode ser maior do que 1000");

            return a + b;
        }

        public decimal MultiplicarNumeros(int a, int b, int c)
        {
            if (a < 0 || b < 0 || c < 0)
            {
                throw new ArgumentException("Parámetros inválidos");
            }

            return a * b * c;
        }

        public decimal DividirNumeros(int a, int b)
        {
            if (b == 0)
            {
                throw new ArgumentException("Denominador não pode ser zero");
            }

            if (a < 0 || b < 0)
            {
                throw new ArgumentException("Parámetro inválido");
            }

            return a / b;
        }

        public decimal DividirSoma(int a, int b, int c) 
            => DividirNumeros(SomarDoisNumeros(a, b), c);

        public decimal SomarLista(IEnumerable<int> lista)
        {
            if (!lista.Any())
                throw new ArgumentException("Lista vazía");
            if (!lista.Any(l => l > 0))
                throw new ArgumentException("Lista com elementos inválidos");

            return lista.Sum();
        }
    }
}