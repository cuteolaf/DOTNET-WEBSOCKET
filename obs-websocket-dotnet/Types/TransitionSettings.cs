﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OBSWebsocketDotNet.Types
{
    /// <summary>
    /// Current transition settings
    /// </summary>
    public class TransitionSettings
    {
        /// <summary>
        /// Transition name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public readonly string Name;

        /// <summary>
        /// Transition duration in milliseconds
        /// </summary>
        [JsonProperty(PropertyName = "duration")]
        public readonly int Duration;

        /// <summary>
        /// Builds the object from the JSON response body
        /// </summary>
        /// <param name="data">JSON response body as a <see cref="JObject"/></param>
        public TransitionSettings(JObject data)
        {
            JsonConvert.PopulateObject(data.ToString(), this);
        }
    }
}
