using GameEngine.Player;

namespace GameEngine.Locations
{
    public class LocationManager
    {
        public void ChangeLocation(LAND land, PlayerModelData playerModel)
        {
            playerModel.CurrentLand = land;
        }
        public void ChangeLocation(TOWN town, PlayerModelData playerModel)
        {
            playerModel.CurrentTown = town;
        }
    }
}
