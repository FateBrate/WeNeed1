using System;
using System.Collections.Generic;

namespace WeNeed1.Service.Database;

public partial class Review
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public int SportsCenterId { get; set; }

    public string? Content { get; set; }

    public decimal Rating { get; set; }

    public DateTime Created { get; set; }

    public virtual SportsCenter? SportsCenter { get; set; }
}
