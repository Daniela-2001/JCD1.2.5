namespace JCD1._2._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            //Calcular o resultado da multiplicação

            int result = number1 * number2;

            //Verificar se o resultado é par ou ímpar

            if (result % 2 == 0) 
            {
                //Se for par, imprimir "BIZZ"
                Console.WriteLine("BIZZ");
            }
            else
            {
                //Se for ímpar, imprimir "BUZZ"
                Console.WriteLine("BUZZ");
            }
        }
    }
}