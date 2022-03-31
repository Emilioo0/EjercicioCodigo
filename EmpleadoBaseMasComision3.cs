// Fig. 10.11: EmpleadoBaseMasComision3.cs
// EmpleadoBaseMasComision3 hereda de EmpleadoPorComision2 y tiene
// acceso a los miembros protected de EmpleadoPorComision2.
public class EmpleadoBaseMasComision3 : EmpleadoPorComision2
{
    private decimal salarioBase; // salario base por semana
 
    // constructor de la clase derivada con seis parámetros
    // con una llamada al constructor de la clase bases EmpleadoPorComision
    public EmpleadoBaseMasComision3(string nombre, string apellido,
       string nss, decimal ventas, decimal tarifa, decimal salario)
       : base(nombre, apellido, nss, ventas, tarifa)
    {
       SalarioBase = salario; // valida el salario base a través de una propiedad
    } // fin del constructor de EmpleadoBaseMasComision3 con seis parámetros
 
    // propiedad que obtiene y establece
    // el salario base del empleado por comisión con salario base
    public decimal SalarioBase
    {
        get
        {
            return salarioBase;
        } // fin de get
        set
        {
            salarioBase = (value< 0 ) ? 0 : value;
        } // fin de set
    } // fin de la propiedad SalarioBase
 
      // calcula los ingresos
     public override decimal Ingresos()
     {
        return salarioBase + (tarifaComision * ventasBrutas);
     } // fin del método Ingresos

     // devuelve representación string de EmpleadoBaseMasComision3
     public override string ToString()
     {
        return string.Format(
        "{0}: {1} {2}\n{3}: {4}\n{5}: {6:C}\n{7}: {8:F2}\n{9}: {10:C}",
        "empleado por comisión con salario base", primerNombre, apellidoPaterno,
        "número de seguro social", numeroSeguroSocial,
        "ventas brutas", ventasBrutas, "tarifa de comisión", tarifaComision,
        "salario base", salarioBase);
     } // fin del método ToString
} // fin de la clase EmpleadoBaseMasComision3
