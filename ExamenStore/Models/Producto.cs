using System;
using System.Collections.Generic;

namespace ExamenStore.Models;

public partial class Producto
{
    public int IdProducto { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public double? Precio { get; set; }

    public string? Imagen { get; set; }

    public string? Categoria { get; set; }
}
