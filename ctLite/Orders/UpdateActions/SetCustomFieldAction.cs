﻿using ctLite.Common;

using Newtonsoft.Json;

namespace ctLite.Orders.UpdateActions
{
    /// <summary>
    /// This action sets, overwrites or removes any existing custom field for an existing order.
    /// </summary>
    /// <see href="http://dev.commercetools.com/http-api-projects-orders.html#set-customfield"/>
    public class SetCustomFieldAction : UpdateAction
    {
        #region Properties

        /// <summary>
        /// Field name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Field value
        /// </summary>
        /// <remarks>
        /// If absent or null, this field is removed if it exists.
        /// </remarks>
        [JsonProperty(PropertyName = "value")]
        public object Value { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ctLite.Orders.UpdateActions.SetCustomFieldAction"/> class.
        /// </summary>
        public SetCustomFieldAction()
        {
            this.Action = "setCustomField";
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="name">Field name</param>
        public SetCustomFieldAction(string name)
        {
            this.Action = "setCustomField";
            this.Name = name;
        }

        #endregion
    }
}
