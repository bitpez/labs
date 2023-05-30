using System;
using System.Collections.Generic;

namespace net60_react.Models;

public partial class Product
{
    public int ProductId { get; set; }

    public string Name { get; set; } = null!;

    public decimal Price { get; set; }
}
