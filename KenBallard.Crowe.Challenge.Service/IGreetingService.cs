using System;
using System.Collections.Generic;
using System.Text;

namespace KenBallard.Crowe.Challenge.Service
{
    /// <summary>
    /// Service to greet stakeholders.
    /// </summary>
    public interface IGreetingService
    {
        /// <summary>
        /// Gets the acceptable greeting.
        /// </summary>
        /// <returns>The acceptable greeting.</returns>
        string Get();
    }
}
