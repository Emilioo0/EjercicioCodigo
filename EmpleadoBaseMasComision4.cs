// Fig. 10.14: EmpleadoBaseMasComision4.cs
// EmpleadoBaseMasComision4 hereda de EmpleadoPorComision3 y tiene
// acceso a los datos private de EmpleadoPorComision3 a través de
// sus propiedades public.
public class EmpleadoBaseMasComision4 : EmpleadoPorComision3
{
    private decimal salarioBase; // salario base por semana

    // constructor de la clase derivada con seis parámetros
    // con una llamada al constructor de la clase base EmpleadoPorComision3
    public EmpleadoBaseMasComision4(string nombre, string apellido,
        string nss, decimal ventas, decimal tarifa, decimal salario)
        : base(nombre, apellido, nss, ventas, tarifa)
    {
        SalarioBase = salario; // valida el salario base a través de una propiedad
    } // fin del constructor de EmpleadoBaseMasComision4 con seis parámetros

     // propiedad que obtiene y establece el
     // salario base del empleado por comisión con salario base
    public decimal SalarioBase
    {
        get
        {
            return salarioBase;
        } // fin de get
        set
        {
            salarioBase = (value < 0) ? 0 : value;
        } // fin de set
    } // fin de la propiedad SalarioBase

     // calcula los ingresos
    public override decimal Ingresos()
    {
        return SalarioBase + base.Ingresos();
    } // fin del método Ingresos

      // devuelve representación string de EmpleadoBaseMasComision4
    public override string ToString()
    {
        return string.Format("{0} {1}\n{2}: {3:C}",
            "salario base +", base.ToString(), "salario base", SalarioBase);
    } // fin del método ToString
} // fin de la clase EmpleadoBaseMasComision4
