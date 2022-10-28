﻿using Newtonsoft.Json;

namespace ctLite.Common
{
    /// <summary>
    /// UpdateAction
    /// </summary>
    public class UpdateAction
    {
        #region Properties

        [JsonProperty(PropertyName = "action")]
        public string Action { get; protected set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Constructor.
        /// </summary>
        public UpdateAction()
        {
        }

        #endregion
    }
}
