using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfFrameworks.ApplicationData.Interfaces
{
    public interface IApplicationSettings
    {
        public IApplicationDisplayResolution Resolution { get; set; }
        public IApplicationDisplayWindowStyle WindowStyle { get; set; }
        public IGeneralSoundVolume GeneralSoundVolume { get; set; }
        public IMusicVolume MusicVolume { get; set; }
        public ISoundEffectsVolume SoundEffectsVolume { get; set; }
    }
}
