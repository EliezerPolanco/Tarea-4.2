using System;
using System.Globalization;

class Programa
{
    static void Main()
    {
        DateTime fechaActual = DateTime.Now;

        DateTime primerDiaMes = new DateTime(fechaActual.Year, fechaActual.Month, 1);

        string nombreMes = primerDiaMes.ToString("MMMM", new CultureInfo("es-ES"));
        int año = fechaActual.Year;

        Console.WriteLine($"\n{nombreMes.ToUpper()} {año}\n");

        Console.WriteLine("lu ma mi ju vi sá do");

        int diaSemana = (int)primerDiaMes.DayOfWeek;
        if (diaSemana == 0) diaSemana = 7; 

        for (int i = 1; i < diaSemana; i++)
        {
            Console.Write("   ");
        }

        int diasEnMes = DateTime.DaysInMonth(fechaActual.Year, fechaActual.Month);

        for (int dia = 1; dia <= diasEnMes; dia++)
        {
            Console.Write($"{dia,2} ");

            if ((dia + diaSemana - 1) % 7 == 0)
            {
                Console.WriteLine();
            }
        }

        Console.WriteLine(); 
    }
}

