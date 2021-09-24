using GameEngine.Locations;

namespace GameOfFrameworks.Models.Armory.MerchantControl.Interfaces
{
    public interface IMerchantViewBuilder
    {
        MerchantView Build(TOWN town);
    }
}
