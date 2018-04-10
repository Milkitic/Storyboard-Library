﻿using LibOsb.EventClass;
using LibOsb.Model.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibOsb.Model.EventType
{
    class MoveY : EventSingle
    {
        public MoveY(EasingType easing, int startTime, int endTime, double preParam, double postParam)
        => Init("MY", easing, startTime, endTime, preParam, postParam);

        internal void _Adjust(double y)
        {
            P1_1 += y;
            P2_1 += y;
            BuildParams();
        }
    }

}
