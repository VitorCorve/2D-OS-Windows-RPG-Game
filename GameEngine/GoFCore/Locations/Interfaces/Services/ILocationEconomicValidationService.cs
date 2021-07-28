using GameEngine.Player;

namespace GameEngine.Locations.Interfaces.Services
{
    public interface ILocationEconomicValidationService
    {
        int Validate(PlayerModelData playerModel);
    }
}
