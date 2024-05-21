using System;
using System.Collections.Generic;

namespace Module;

public partial class Achievement
{
    public DateOnly Date { get; set; }

    public string Type { get; set; } = null!;

    public int Id { get; set; }

    public string Description { get; set; } = null!;
}
