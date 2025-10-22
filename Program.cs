using MVC_Vehiculos_CROVARA.Controllers;

namespace MVC_Vehiculos_CROVARA;

/// <summary>
/// Programa principal que demuestra las operaciones CRUD de vehículos
/// Estructura MVC - Modelo Vista Controlador
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.Title = "Sistema CRUD de Vehículos - Estructura MVC";

        var controller = new VehiculoController();

        Console.WriteLine("\n╔════════════════════════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║         SISTEMA CRUD DE VEHÍCULOS - ESTRUCTURA MVC (Patrón REST)              ║");
        Console.WriteLine("║              Desarrollo Orientado a Objetos - 1er Año                         ║");
        Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════╝\n");

        // ==================== READ - GET ALL ====================
        Console.WriteLine("\n📋 OPERACIÓN: GET ALL - Obtener todos los vehículos");
        controller.ObtenerTodos();
        PausarEjecucion();

        // ==================== READ - GET AUTOS ====================
        Console.WriteLine("\n🚗 OPERACIÓN: GET AUTOS - Obtener todos los autos");
        controller.ObtenerAutos();
        PausarEjecucion();

        // ==================== READ - GET MOTOS ====================
        Console.WriteLine("\n🏍️  OPERACIÓN: GET MOTOS - Obtener todas las motos");
        controller.ObtenerMotos();
        PausarEjecucion();

        // ==================== READ - GET BY ID ====================
        Console.WriteLine("\n🔍 OPERACIÓN: GET BY ID - Obtener vehículo por ID (ID = 3)");
        controller.ObtenerPorId(3);
        PausarEjecucion();

        // ==================== CREATE - POST AUTO ====================
        Console.WriteLine("\n➕ OPERACIÓN: POST - Crear nuevo auto");
        controller.CrearAuto(
            marca: "Volkswagen",
            modelo: "Golf GTI",
            anio: 2024,
            color: "Gris",
            precio: 32000m,
            cantidadPuertas: 5,
            tipoCombustible: "Nafta Premium"
        );
        PausarEjecucion();

        // ==================== CREATE - POST MOTO ====================
        Console.WriteLine("\n➕ OPERACIÓN: POST - Crear nueva moto");
        controller.CrearMoto(
            marca: "Ducati",
            modelo: "Panigale V2",
            anio: 2024,
            color: "Rojo",
            precio: 18000m,
            cilindrada: 955,
            tipoMoto: "Deportiva"
        );
        PausarEjecucion();

        // Mostrar todos después de crear
        Console.WriteLine("\n📋 Verificando vehículos después de crear...");
        controller.ObtenerTodos();
        PausarEjecucion();

        // ==================== UPDATE - PUT AUTO ====================
        Console.WriteLine("\n✏️  OPERACIÓN: PUT - Actualizar auto (ID = 1)");
        controller.ActualizarAuto(
            id: 1,
            marca: "Toyota",
            modelo: "Corolla Cross",
            anio: 2024,
            color: "Blanco Perlado",
            precio: 29000m,
            cantidadPuertas: 5,
            tipoCombustible: "Híbrido"
        );
        PausarEjecucion();

        // ==================== UPDATE - PUT MOTO ====================
        Console.WriteLine("\n✏️  OPERACIÓN: PUT - Actualizar moto (ID = 5)");
        controller.ActualizarMoto(
            id: 5,
            marca: "Yamaha",
            modelo: "MT-07 ABS",
            anio: 2024,
            color: "Azul Metálico",
            precio: 11500m,
            cilindrada: 689,
            tipoMoto: "Naked Sport"
        );
        PausarEjecucion();

        // ==================== SEARCH - GET BY MARCA ====================
        Console.WriteLine("\n🔎 OPERACIÓN: SEARCH - Buscar por marca (Yamaha)");
        controller.BuscarPorMarca("Yamaha");
        PausarEjecucion();

        // ==================== DELETE - DELETE BY ID ====================
        Console.WriteLine("\n🗑️  OPERACIÓN: DELETE - Eliminar vehículo (ID = 2)");
        controller.Eliminar(2);
        PausarEjecucion();

        // Mostrar todos después de eliminar
        Console.WriteLine("\n📋 Verificando vehículos después de eliminar...");
        controller.ObtenerTodos();
        PausarEjecucion();

        // ==================== ERROR HANDLING ====================
        Console.WriteLine("\n⚠️  OPERACIÓN: GET BY ID - Intentar obtener vehículo inexistente (ID = 999)");
        controller.ObtenerPorId(999);
        PausarEjecucion();

        Console.WriteLine("\n⚠️  OPERACIÓN: DELETE - Intentar eliminar vehículo inexistente (ID = 999)");
        controller.Eliminar(999);
        PausarEjecucion();

        // ==================== RESUMEN FINAL ====================
        Console.WriteLine("\n╔════════════════════════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║                           RESUMEN DE OPERACIONES                              ║");
        Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════╝");
        Console.WriteLine("\n  ✓ GET ALL     - Listar todos los vehículos");
        Console.WriteLine("  ✓ GET BY ID   - Obtener vehículo específico");
        Console.WriteLine("  ✓ GET AUTOS   - Filtrar por tipo (Autos)");
        Console.WriteLine("  ✓ GET MOTOS   - Filtrar por tipo (Motos)");
        Console.WriteLine("  ✓ POST        - Crear nuevos vehículos (Auto y Moto)");
        Console.WriteLine("  ✓ PUT         - Actualizar vehículos existentes");
        Console.WriteLine("  ✓ DELETE      - Eliminar vehículos");
        Console.WriteLine("  ✓ SEARCH      - Buscar por marca");
        Console.WriteLine("  ✓ ERROR       - Manejo de errores (recursos inexistentes)\n");

        Console.WriteLine("\n╔════════════════════════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║                        Estado final del sistema                               ║");
        Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════╝");
        controller.ObtenerTodos();

        Console.WriteLine("\n\n✅ Demostración completada. Presione cualquier tecla para salir...");
        Console.ReadKey();
    }

    /// <summary>
    /// Pausa la ejecución y espera que el usuario presione una tecla
    /// </summary>
    static void PausarEjecucion()
    {
        Console.WriteLine("\n  ⏸️  Presione cualquier tecla para continuar...");
        Console.ReadKey();
        Console.WriteLine("\n" + new string('━', 80) + "\n");
    }
}
