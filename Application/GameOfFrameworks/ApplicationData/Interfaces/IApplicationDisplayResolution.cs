using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfFrameworks.ApplicationData.Interfaces
{
    public interface IApplicationDisplayResolution
    {
        int Height { get; }
        int Width { get; }
        void SetNextResolution();
        void SetPreviousResolution();
    }
}
