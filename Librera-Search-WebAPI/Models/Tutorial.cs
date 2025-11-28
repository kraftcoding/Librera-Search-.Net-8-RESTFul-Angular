using System;
using System.Collections.Generic;

namespace ASP.NETCore.ArticlesWebAPI.Models;

public partial class Tutorial
{
    public int? id { get; set; }

    public string? title { get; set; }

    public string? description { get; set; }

    public bool? published { get; set; }

}
