﻿using System;
using System.Collections.Generic;

namespace Test_Push_Pull.Data;

public partial class Book
{
    public int BookId { get; set; }

    public string Title { get; set; } = null!;

    public string? Description { get; set; }

    public string? CoverImagePath { get; set; }

    public int AuthorId { get; set; }

    public virtual Author Author { get; set; } = null!;
}
