using System;
using System.Collections.Generic;

namespace MVC_PetAppStoredProcedure.Models;

public partial class PetCategory
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Pet> Pets { get; set; } = new List<Pet>();
}
