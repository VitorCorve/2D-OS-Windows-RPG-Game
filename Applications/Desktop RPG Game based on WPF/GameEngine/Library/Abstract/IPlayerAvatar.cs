﻿using GameEngine.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine.Abstract
{
    public interface IPlayerAvatar
    {
        int ID { get; }
        string Path { get; }
        SPECIALIZATION Specialization { get; }
    }
}