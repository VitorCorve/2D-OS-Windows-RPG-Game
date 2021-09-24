using GameEngine.Locations;
using GameOfFrameworks.Models.Armory.MerchantControl.Interfaces;
using System;

namespace GameOfFrameworks.Models.Armory.MerchantControl.Services
{
    public class MerchantViewBuilder : IMerchantViewBuilder
    {
        public MerchantView Build(TOWN town)
        {
            var merchantView = new MerchantView();
            
            switch (town)
            {
                case TOWN.Roughwark:
                    merchantView.AvatarPath = $"{Environment.CurrentDirectory}\\Data\\Images\\characters\\merchants\\RoughwarkMerch.jpg";
                    break;
                case TOWN.Ironhide:
                    merchantView.AvatarPath = $"{Environment.CurrentDirectory}\\Data\\Images\\characters\\merchants\\IronhideMerch.jpg";
                    break;
                case TOWN.Elfinel:
                    merchantView.AvatarPath = $"{Environment.CurrentDirectory}\\Data\\Images\\characters\\merchants\\ElfinelMerch.jpg";
                    break;
                case TOWN.Chartringfall:
                    merchantView.AvatarPath = $"{Environment.CurrentDirectory}\\Data\\Images\\characters\\merchants\\ChartringfallMerch.jpg";
                    break;
                case TOWN.Anvilrest:
                    merchantView.AvatarPath = $"{Environment.CurrentDirectory}\\Data\\Images\\characters\\merchants\\AnvilrestMerch.jpg";
                    break;
                case TOWN.Frozencore:
                    merchantView.AvatarPath = $"{Environment.CurrentDirectory}\\Data\\Images\\characters\\merchants\\FrozencoreMerch.jpg";
                    break;
                case TOWN.Farmild:
                    merchantView.AvatarPath = $"{Environment.CurrentDirectory}\\Data\\Images\\characters\\merchants\\FarmildMerch.jpg";
                    break;
                case TOWN.Dark_Fortress:
                    merchantView.AvatarPath = $"{Environment.CurrentDirectory}\\Data\\Images\\characters\\merchants\\DarkFortressMerch.jpg";
                    break;
            }
            return merchantView;
        }
    }
}
