using PetFolio.Communication.Enums;

namespace PetFolio.Communication.Requests;

public class PetRegisterResponse
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;
}
