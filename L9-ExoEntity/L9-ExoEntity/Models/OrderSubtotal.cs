using System;
using System.Collections.Generic;

namespace L9_ExoEntity.Models;

public partial class OrderSubtotal
{
    public int OrderId { get; set; }

    public decimal? Subtotal { get; set; }
}
