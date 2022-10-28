﻿using ctLite.Common;

using Newtonsoft.Json;

namespace ctLite.Customers.UpdateActions
{
    /// <summary>
    /// SetFirstNameAction
    /// </summary>
    /// <see href="http://dev.commercetools.com/http-api-projects-customers.html#set-first-name"/>
    public class SetFirstNameAction : UpdateAction
    {
        #region Properties

        /// <summary>
        /// First Name
        /// </summary>
        [JsonProperty(PropertyName = "firstName")]
        public string FirstName { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Constructor.
        /// </summary>
        public SetFirstNameAction()
        {
            this.Action = "setFirstName";
        }

        #endregion
    }
}
