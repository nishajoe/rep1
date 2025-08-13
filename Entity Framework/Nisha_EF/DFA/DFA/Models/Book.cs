using System;
using System.Collections.Generic;

namespace DFA.Models;

public partial class Book
{
    public int BookId { get; set; }

    public string BookTitle { get; set; } = null!;

    public string BookAuthor { get; set; } = null!;

    public int BookPrice { get; set; }
}
