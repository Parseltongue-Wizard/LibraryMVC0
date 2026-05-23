using System;
using System.Collections.Generic;

namespace LibraryDomain.Model;

public partial class Student
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Email { get; set; }

    public virtual ICollection<Loan> Loans { get; set; } = new List<Loan>();
}
