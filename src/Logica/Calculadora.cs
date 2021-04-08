using System;

namespace Logica
{
    public class Calculadora
    {
        public static int Sumar(string num1, string num2)
        {
            int val1;
            if (!Int32.TryParse(num1, out val1))
            {
                //Console.WriteLine("Ingresó un nro inválido");
                throw new ArgumentException("Ingresó un nro inválido");
            }

            int val2;
            if (!Int32.TryParse(num2, out val2))
            {
                throw new ArgumentException("Ingresó un nro inválido");
            }

            return val1 + val2;
        }

        public static int Restar(string num1, string num2)
        {
            int val1;
            if (!Int32.TryParse(num1, out val1))
            {
                //Console.WriteLine("Ingresó un nro inválido");
                throw new ArgumentException("Ingresó un nro inválido");
            }

            int val2;
            if (!Int32.TryParse(num2, out val2))
            {
                throw new ArgumentException("Ingresó un nro inválido");
            }

            return val1 - val2;
        }
    }
}
