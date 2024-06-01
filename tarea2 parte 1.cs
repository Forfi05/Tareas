using System;

class Program
{
    static void Main()
    {
        const int numEmpleados = 100; 
        string[,] empleados = new string[numEmpleados, 5]; 

        int contador = 0; 

        string continuar = "S"; 

        while (continuar.ToUpper() == "S" && contador < numEmpleados) 
        {
            
            Console.Write("Número de cédula: ");
            empleados[contador, 0] = Console.ReadLine();

            Console.Write("Nombre del empleado: ");
            empleados[contador, 1] = Console.ReadLine();

            Console.Write("Tipo de empleado (1-Operario, 2-Técnico, 3-Profesional): ");
            empleados[contador, 2] = Console.ReadLine();

            Console.Write("Cantidad de horas laboradas: ");
            empleados[contador, 3] = Console.ReadLine();

            Console.Write("Precio por hora: ");
            empleados[contador, 4] = Console.ReadLine();

            contador++; 

            
            Console.Write("¿Desea continuar agregando empleados? (S/N): ");
            continuar = Console.ReadLine();
        }

        
        Console.WriteLine("\nLista de empleados:");
        for (int i = 0; i < contador; i++)
        {
            Console.WriteLine($"Cédula: {empleados[i, 0]}");
            Console.WriteLine($"Nombre: {empleados[i, 1]}");
            Console.WriteLine($"Tipo de Empleado: {empleados[i, 2]}");
            Console.WriteLine($"Horas Laboradas: {empleados[i, 3]}");
            Console.WriteLine($"Precio por Hora: {empleados[i, 4]}");

            int horasLaboradas = int.Parse(empleados[i, 3]);
            int precioPorHora = int.Parse(empleados[i, 4]);
            int salarioBase = horasLaboradas * precioPorHora;

            float aumento = 0;

            if (empleados[i, 2] == "1")
            {
                aumento = salarioBase * 0.15f;
            }
            else if (empleados[i, 2] == "2")
            {
                aumento = salarioBase * 0.10f;
            }
            else if (empleados[i, 2] == "3")
            {
                aumento = salarioBase * 0.05f;
            }

            float salarioBruto = salarioBase + aumento;
            float deduccion = salarioBruto * 0.0917f;
            float salarioNeto = salarioBruto - deduccion;

            Console.WriteLine($"Salario Base: {salarioBase}");
            Console.WriteLine($"Aumento: {aumento}");
            Console.WriteLine($"Salario Bruto: {salarioBruto}");
            Console.WriteLine($"Deducción: {deduccion}");
            Console.WriteLine($"Salario Neto: {salarioNeto}");
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}
