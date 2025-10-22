# Sistema CRUD de Vehículos 🚗🏍️

Sistema de gestión de vehículos con patrón MVC.

---

## 📁 Estructura del Proyecto

```
MVC-Vehiculos-CROVARA/
├── Models/           → Clases de vehículos (Auto, Moto)
├── Views/            → Presentación en consola
├── Controllers/      → Lógica de control
├── Repository/       → Datos estáticos
└── Program.cs        → Punto de entrada
```

---

## 🚀 Cómo Ejecutar

### 1. Compilar
```bash
dotnet build
```

### 2. Ejecutar
```bash
dotnet run
```

### 3. Interactuar
- El programa se ejecuta automáticamente
- Muestra todas las operaciones CRUD
- Presiona una tecla para avanzar entre operaciones

---

## ✨ Operaciones Implementadas

- ✅ **Listar** todos los vehículos
- ✅ **Buscar** por ID
- ✅ **Filtrar** por tipo (Autos/Motos)
- ✅ **Crear** nuevos vehículos
- ✅ **Actualizar** vehículos existentes
- ✅ **Eliminar** vehículos
- ✅ **Buscar** por marca

---

## 📊 Datos de Ejemplo

El sistema incluye 6 vehículos precargados:
- 3 Autos (Toyota, Ford, Chevrolet)
- 3 Motos (Honda, Yamaha, Kawasaki)

---

## 🎓 Conceptos Aplicados

- Patrón **MVC** (Modelo-Vista-Controlador)
- **Herencia** (Vehiculo → Auto/Moto)
- **Polimorfismo** (métodos abstractos)
- **Encapsulamiento** (propiedades)
- Operaciones **CRUD** completas

---

## 📝 Nota

Los datos son **estáticos** (se pierden al cerrar) y el programa **no tiene menú** (ejecución automática).
