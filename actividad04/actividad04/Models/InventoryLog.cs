using System;
using System.Collections.Generic;

namespace actividad04.Models;

public partial class InventoryLog
{
    public int Id { get; set; }

    public int ProductId { get; set; }

    public string Type { get; set; } = null!;

    public int Quantity { get; set; }

    public string? Reason { get; set; }

    public DateTime? LogDate { get; set; }

    public virtual Product Product { get; set; } = null!;
}
