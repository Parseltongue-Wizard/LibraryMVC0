using System;
using System.Collections.Generic;

namespace LibraryDomain.Model;

public partial class Loan
{
    public int Id { get; set; }

    public int CollectionId { get; set; }

    public int StudentId { get; set; }

    public DateOnly LoanDate { get; set; }

    public DateOnly? ReturnDate { get; set; }

    public virtual Collection Collection { get; set; } = null!;

    public virtual Student Student { get; set; } = null!;
}
