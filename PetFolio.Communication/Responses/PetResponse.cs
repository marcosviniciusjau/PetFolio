﻿using PetFolio.Communication.Enums;

namespace PetFolio.Communication.Requests;

public class PetResponse
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public DateTime Birthday { get; set; }
    public PetType Type { get; set; }
}
