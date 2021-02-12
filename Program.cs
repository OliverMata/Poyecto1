using System;

namespace Poyecto1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear un programa que pida números positivos al usuario, y vaya calculando la suma de todos ellos (terminará cuando se teclea un número negativo o cero).
            int num=0, sum=0;
            while (true)
            {
                Console.WriteLine("Introduzca numero que sean positivos: ");
                num = int.Parse(Console.ReadLine());
                if (num <= 0)
                {
                    Console.WriteLine("Se intodujo un numero que no es positivo, se detuvo el conteo");
                    break;
                }
                sum=sum+num;
                Console.WriteLine("La suma de los numeros introducidos es: {0}", sum);
            
            }
            
        }
    }
}
