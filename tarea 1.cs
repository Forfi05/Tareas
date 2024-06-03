using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Dictionary<string, string>> empleados = new List<Dictionary<string, string>>(); 
        string continuar = "S"; 

        while (continuar.ToUpper() == "S") 
        {
            
            Dictionary<string, string> empleado = new Dictionary<string, string>();

            
            Console.Write("Número de cédula: ");
            empleado["Cedula"] = Console.ReadLine();

            Console.Write("Nombre del empleado: ");
            empleado["Nombre"] = Console.ReadLine();

            Console.Write("Tipo de empleado (1-Operario, 2-Técnico, 3-Profesional): ");
            empleado["TipoEmpleado"] = Console.ReadLine();

            Console.Write("Cantidad de horas laboradas: ");
            empleado["HorasLaboradas"] = Console.ReadLine();

            Console.Write("Precio por hora: ");
            empleado["PrecioPorHora"] = Console.ReadLine();

            empleados.Add(empleado);

            Console.Write("¿Desea continuar agregando empleados? (S/N): ");
            continuar = Console.ReadLine();
        }

        Console.WriteLine("\nLista de empleados:");
        foreach (var emp in empleados)
        {
            Console.WriteLine($"Cédula: {emp["Cedula"]}");
            Console.WriteLine($"Nombre: {emp["Nombre"]}");
            Console.WriteLine($"Tipo de Empleado: {emp["TipoEmpleado"]}");
            Console.WriteLine($"Horas Laboradas: {emp["HorasLaboradas"]}");
            Console.WriteLine($"Precio por Hora: {emp["PrecioPorHora"]}");

            int horasLaboradas = int.Parse(emp["HorasLaboradas"]);
            int precioPorHora = int.Parse(emp["PrecioPorHora"]);
            int salarioBase = horasLaboradas * precioPorHora;

            float aumento = 0;

            if (emp["TipoEmpleado"] == "1")
            {
                aumento = salarioBase * 0.15f;
            }
            else if (emp["TipoEmpleado"] == "2")
            {
                aumento = salarioBase * 0.10f;
            }
            else if (emp["TipoEmpleado"] == "3")
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