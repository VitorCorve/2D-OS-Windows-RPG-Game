using GameEngine.Locations.Interfaces.Services;
using GameEngine.Player;

namespace GameEngine.Locations.Services
{
    public class LocationEconomicValidationService : ILocationEconomicValidationService
    {
        public int Validate(PlayerModelData playerModel)
        {
            switch (playerModel.CurrentTown)
            {
                case TOWN.Roughwark:
                    return 1;
                case TOWN.Ironhide:
                    return 2;
                case TOWN.Elfinel:
                    return 3;
                case TOWN.Chartringfall:
                    return 2;
                case TOWN.Anvilrest:
                    return 2;
                case TOWN.Frozencore:
                    return 1;
                case TOWN.Farmild:
                    return 1;
                case TOWN.Dark_Fortress:
                    return 3;
                default:
                    return 1;
            }
        }
    }
}
