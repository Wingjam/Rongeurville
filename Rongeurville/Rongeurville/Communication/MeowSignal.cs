﻿using System;

namespace Rongeurville.Communication
{
    [Serializable]
    public class MeowSignal : Signal
    {
        public Coordinates MeowLocation;
    }
}