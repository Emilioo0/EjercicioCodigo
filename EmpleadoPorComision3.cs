// Fig. 10.13: EmpleadoPorComision3.cs
// La clase EmpleadoPorComision3 representa a un empleado por comisión.

public class EmpleadoPorComision3
{

    private string primerNombre;
    private string apellidoPaterno;
    private string numeroSeguroSocial;
    private decimal ventasBrutas; // ventas semanales totales
    private decimal tarifaComision; // porcentaje de comisión

    // constructor con cinco parámetros
    public EmpleadoPorComision3(string nombre, string apellido, string nss,
        decimal ventas, decimal tarifa)
    {
        // la llamada implícita al constructor de object se realiza aquí
        primerNombre = nombre;
        apellidoPaterno = apellido;
        numeroSeguroSocial = nss;
        VentasBrutas = ventas; // valida las ventas brutas a través de una propiedad
        TarifaComision = tarifa; // valida la tarifa de comisión a través de una propiedad
    } // fin del constructor de EmpleadoPorComision3 con cinco parámetros

    // propiedad de sólo lectura que obtiene el primer nombre del empleado por comisión
    public string PrimerNombre
    {
        get
        {
            return primerNombre;
        } // fin de get
    } // fin de la propiedad PrimerNombre

     // propiedad de sólo lectura que obtiene el apellido paterno del empleado por comisión
     public string ApellidoPaterno
     {
        get
        {
            return apellidoPaterno;
        } // fin de get
     } // fin de la propiedad ApellidoPaterno

      // propiedad de sólo lectura que obtiene el
      // número de seguro social del empleado por comisión
     public string NumeroSeguroSocial
     {
        get
        {
            return numeroSeguroSocial;
        } // fin de get
     } // fin de la propiedad NumeroSeguroSocial

      // propiedad que obtiene y establece las ventas brutas del empleado por comisión
     public decimal VentasBrutas
     {
        get
        {
            return ventasBrutas;
        } // fin de get
        set
        {
            ventasBrutas = (value < 0) ? 0 : value;
        } // fin de set
     } // fin de la propiedad VentasBrutas

        // propiedad que obtiene y establece la tarifa de comisión del empleado por comisión
     public decimal TarifaComision
     {
        get
        {
            return tarifaComision;
        } // fin de get
        set
        {
            tarifaComision = (value > 0 && value < 1) ? value : 0;
        } // fin de set
     } // fin de la propiedad TarifaComision

       // calcula el salario del empleado por comisión
     public virtual decimal Ingresos()
     {
        return TarifaComision * VentasBrutas;
     } // fin del método Ingresos

        // devuelve representación string del objeto EmpleadoPorComision
     public override string ToString()
     {
        return string.Format(
        "{0}: {1} {2}\n{3}: {4}\n{5}: {6:C}\n{7}: {8:F2}",
        "empleado por comisión", PrimerNombre, ApellidoPaterno,
        "número de seguro social", NumeroSeguroSocial,
        "ventas brutas", VentasBrutas, "tarifa de comisión", TarifaComision);
     } // fin del método ToString
 } // fin de la clase EmpleadoPorComision3