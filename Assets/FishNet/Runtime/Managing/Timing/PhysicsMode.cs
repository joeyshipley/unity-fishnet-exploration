﻿namespace FishNet.Managing.Timing
{
    /// <summary>
    /// How to simulate physics.
    /// </summary>
    public enum PhysicsMode
    {
        /// <summary>
        /// Unity performs physics every FixedUpdate.
        /// </summary>
        Unity,
        /// <summary>
        /// TimeManager performs physics each tick.
        /// </summary>
        TimeManager
    }


}