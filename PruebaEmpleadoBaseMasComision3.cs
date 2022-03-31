// Fig. 10.12: PruebaEmpleadoBaseMasComision3.cs
// Prueba de la clase EmpleadoBaseMasComision3.
using System;
public class PruebaEmpleadoBaseMasComision3
{
    public static void Main1(string[] args)
    {
        // crea instancia de un objeto EmpleadoBaseMasComision3
        EmpleadoBaseMasComision3 empleadoBaseMasComision =
            new EmpleadoBaseMasComision3("Bob", "Lewis",
            "333-33-3333", 5000.00M, .04M, 300.00M);
        
        // muestra en pantalla los datos del empleado por comisión con salario base
        Console.WriteLine("Información del empleado obtenida por las propiedades y los métodos: \n");
        Console.WriteLine("{0} {1}", "El primer nombre es",
            empleadoBaseMasComision.PrimerNombre);
        Console.WriteLine("{0} {1}", "El apellido paterno es",
            empleadoBaseMasComision.ApellidoPaterno);
        Console.WriteLine("{0} {1}", "El número de seguro social es",
            empleadoBaseMasComision.NumeroSeguroSocial);
        Console.WriteLine("{0} {1:C}", "Las ventas brutas son",
            empleadoBaseMasComision.VentasBrutas);
        Console.WriteLine("{0} {1:F2}", "La tarifa de comisión es",
            empleadoBaseMasComision.TarifaComision);
        Console.WriteLine("{0} {1:C}", "Los ingresos son",
            empleadoBaseMasComision.Ingresos());
        Console.WriteLine("{0} {1:C}", "El salario base es",
            empleadoBaseMasComision.SalarioBase);
        
            empleadoBaseMasComision.SalarioBase = 1000.00M; // establece el salario base
        
        Console.WriteLine("\n{0}:\n\n{1}",
            "Información actualizada del empleado, obtenida por ToString",
            empleadoBaseMasComision);
        Console.WriteLine("ingresos: {0:C}",
            empleadoBaseMasComision.Ingresos());

        Console.ReadKey();
    } // fin de Main
} // fin de la clase PruebaEmpleadoBaseMasComision3
