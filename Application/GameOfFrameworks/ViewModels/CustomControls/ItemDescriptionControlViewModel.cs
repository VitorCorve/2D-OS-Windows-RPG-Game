using GameOfFrameworks.Models.Services;
using GameOfFrameworks.Models.Temporary;
using GameOfFrameworks.ViewModels.Base;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace GameOfFrameworks.ViewModels.CustomControls
{
    public class ItemDescriptionControlViewModel : ViewModel
    {
        private Dictionary<string, string> _ItemDescription;
        public Dictionary<string, string> ItemDescription { get => _ItemDescription; set => Set(ref _ItemDescription, value); }

    }
}
