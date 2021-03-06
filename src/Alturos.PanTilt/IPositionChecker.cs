﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alturos.PanTilt
{
    public interface IPositionChecker
    {
        /// <summary>
        /// Check PanTilt Position
        /// </summary>
        /// <param name="position">expect pan tilt position</param>
        /// <param name="tolerance">tolerance to expect position</param>
        /// <param name="retry">retry count</param>
        /// <param name="timeout">Waiting time until the next attempt (milliseconds)</param>
        /// <returns></returns>
        bool ComparePosition(PanTiltPosition position, double tolerance = 0.5, int retry = 5, int timeout = 500);
    }
}
