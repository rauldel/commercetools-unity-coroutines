﻿using ctLite.Common;

using Newtonsoft.Json;

namespace ctLite.Zones.UpdateActions
{
    /// <summary>
    /// SetDescriptionAction
    /// </summary>
    /// <see href="https://dev.commercetools.com/http-api-projects-zones.html#set-description"/>
    public class SetDescriptionAction : UpdateAction
    {
        #region Properties

        /// <summary>
        /// Description
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Constructor.
        /// </summary>
        public SetDescriptionAction()
        {
            this.Action = "setDescription";
        }

        #endregion
    }
}
