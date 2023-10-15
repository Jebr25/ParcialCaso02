using System;
using System.Collections.Generic;

namespace ParcialCaso02.API.Data;

public partial class Country
{
    public int Id { get; set; }

    public string? Description { get; set; }

    public string? Code { get; set; }

    public string? Currency { get; set; }
}
