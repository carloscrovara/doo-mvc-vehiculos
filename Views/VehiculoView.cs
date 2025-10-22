using MVC_Vehiculos_CROVARA.Models;

namespace MVC_Vehiculos_CROVARA.Views;

/// <summary>
/// Vista para mostrar información de vehículos en consola
/// Responsable de la presentación de datos
/// </summary>
public class VehiculoView
{
    /// <summary>
    /// Muestra un vehículo individual
    /// </summary>
    public void MostrarVehiculo(Vehiculo? vehiculo, string titulo)
    {
        Console.WriteLine();
        MostrarEncabezado(titulo);

        if (vehiculo == null)
        {
            MostrarMensajeError("No se encontró el vehículo");
            return;
        }

        Console.WriteLine($"  Tipo: {vehiculo.ObtenerTipo()}");
        Console.WriteLine($"  {vehiculo}");
        Console.WriteLine(new string('-', 80));
    }

    /// <summary>
    /// Muestra una lista de vehículos
    /// </summary>
    public void MostrarListaVehiculos(List<Vehiculo> vehiculos, string titulo)
    {
        Console.WriteLine();
        MostrarEncabezado(titulo);

        if (vehiculos == null || vehiculos.Count == 0)
        {
            Console.WriteLine("  No hay vehículos para mostrar.");
            Console.WriteLine(new string('-', 80));
            return;
        }

        Console.WriteLine($"  Total de vehículos: {vehiculos.Count}");
        Console.WriteLine();

        foreach (var vehiculo in vehiculos)
        {
            Console.WriteLine($"  [{vehiculo.ObtenerTipo()}] {vehiculo}");
        }

        Console.WriteLine(new string('-', 80));
    }

    /// <summary>
    /// Muestra un mensaje de éxito
    /// </summary>
    public void MostrarMensajeExito(string mensaje)
    {
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"  ✓ {mensaje}");
        Console.ResetColor();
    }

    /// <summary>
    /// Muestra un mensaje de error
    /// </summary>
    public void MostrarMensajeError(string mensaje)
    {
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"  ✗ {mensaje}");
        Console.ResetColor();
    }

    /// <summary>
    /// Muestra un encabezado con formato
    /// </summary>
    private void MostrarEncabezado(string titulo)
    {
        Console.WriteLine(new string('=', 80));
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"  {titulo}");
        Console.ResetColor();
        Console.WriteLine(new string('=', 80));
    }

    /// <summary>
    /// Muestra el separador de operaciones
    /// </summary>
    public void MostrarSeparador()
    {
        Console.WriteLine();
        Console.WriteLine(new string('*', 80));
        Console.WriteLine();
    }
}
