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

        //Criar um método que multiplique 3 numeros
        //Validar que todos os numero são maiores do que zero (mostrar exception)



        //Criar um método que divida 2 numeros
        //Validar que todos segundo numero maior do que zero (mostrar exception)
        //Validar que nenhum numero seja negativo


        //Criar um método que divida 2 numeros sendo que o primeiro é o resultado da soma do primeiro metodo
        //Validar que todos segundo numero maior do que zero (mostrar exception)
        //Validar que nenhum numero seja negativo
    }
}