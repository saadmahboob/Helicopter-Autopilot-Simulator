#region Copyright

// A�DS - Autonomous Aerial Drone Simulator
// http://anjdreas.spaces.live.com/
//  
// A Master of Science thesis on autonomous flight at the 
// Norwegian University of Science and Technology (NTNU).
//  
// Copyright � 2009-2010 by Andreas Larsen.  All rights reserved.

#endregion

#region Using

using System;
using Control.Common;
using State.Model;

#endregion

namespace Sensors
{
    public interface ISensor
    {
        void Update(PhysicalHeliState startState, PhysicalHeliState endState, JoystickOutput output, TimeSpan startTime, TimeSpan endTime);
    }
}