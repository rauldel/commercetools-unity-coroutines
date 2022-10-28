﻿using ctLite.Common;

using Newtonsoft.Json;

namespace ctLite.Customers.UpdateActions
{
    /// <summary>
    /// SetMiddleNameAction
    /// </summary>
    /// <see href="http://dev.commercetools.com/http-api-projects-customers.html#set-middle-name"/>
    public class SetMiddleNameAction : UpdateAction
    {
        #region Properties

        /// <summary>
        /// Middle name
        /// </summary>
        [JsonProperty(PropertyName = "middleName")]
        public string MiddleName { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Constructor.
        /// </summary>
        public SetMiddleNameAction()
        {
            this.Action = "setMiddleName";
        }

        #endregion
    }
}
