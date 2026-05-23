using System;
using System.Collections.Generic;

namespace LibraryDomain.Model;

public partial class Collection
{
    public int Id { get; set; }

    public int BookId { get; set; }

    public string InventoryNumber { get; set; } = null!;

    public bool? IsAvailable { get; set; }

    public virtual Book Book { get; set; } = null!;

    public virtual ICollection<Loan> Loans { get; set; } = new List<Loan>();
}
