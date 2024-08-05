using PetFolio.Communication.Enums;

namespace PetFolio.Communication.Responses;

public class ShortPetResponse
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public PetType Type { get; set; }
}
