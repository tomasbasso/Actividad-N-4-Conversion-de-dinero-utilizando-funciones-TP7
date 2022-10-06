//4.- Realizar una aplicación que permita realizar la conversión de monedas DÓLAR y EURO a
//PESO ARGENTINO. En primer lugar se debe solicitar el tipo de moneda origen (Dólar o Euro) y
//la cantidad de la misma, luego se debe mostrar el monto correspondiente en Pesos Argentinos
//y que se presione una tecla para permitir realizar una nueva conversión. Al momento de
//seleccionar la moneda, también se debe brindar una opción para finalizar el programa.

using System;

namespace Actividad_4__Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Clear();
            int seleccion;
            string final = "";
            Console.WriteLine("Teclee la moneda a connvertir a pesos argetinos");
            Console.WriteLine("1)Dolar");
            Console.WriteLine("2)Euro");
            seleccion = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            if (seleccion == 1)
            {
                dolares();
            }
            else if (seleccion == 2)
            {
                 euros();
            }
            else
                Error();

            switch (final)
            {
                case "x" or "X":
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "Y" or "y":
                    
                    break;

            }
        }
        static void dolares()
        {
            int monto,resultado;
            Console.WriteLine("Ingrese monto a convertir");
            monto = Convert.ToInt32(Console.ReadLine());
            resultado = monto * 280;
            Console.Write("Su monto en pesos es {0}$", resultado);
            
        }
        static void euros()
        {
             int monto,resultado;
            Console.WriteLine("Ingrese monto a convertir");
            monto = Convert.ToInt32(Console.ReadLine());
            resultado = monto * 290;
            Console.Write("Su monto en pesos es {0}$", resultado);
        }
        static void Error() {
            Console.WriteLine("El numero ingresado es incorrecto");

            Console.WriteLine("Si desea termina el programa presione x");
            Console.WriteLine("Si desea reiniciar el programa presione y");

        }
    }
}







