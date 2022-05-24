namespace ClassLibrary1
{
    public class Class1
    {
        public int SomarDoisNumeros(int a, int b)
        {
            if(a < 0 && b < 0)
                throw new ArgumentException("O segundo argumento não pode ser negativo"); 
            
            if (b > 1000)
                throw new ArgumentException("O segundo argumento não pode ser maior do que 1000");

            return a + b;
        }
    }
}