﻿using ctLite.Common;

using Newtonsoft.Json;

namespace ctLite.Payments.UpdateActions
{
    /// <summary>
    /// This action sets, overwrites or removes any existing custom field for an existing payment.
    /// </summary>
    /// <see href="https://dev.commercetools.com/http-api-projects-payments.html#set-customfield"/>
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
        /// If absent or null, this field is removed if it exists. If value is provided, set the value of the field defined by the name.
        /// </remarks>
        [JsonProperty(PropertyName = "value")]
        public object Value { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ctLite.Payments.UpdateActions.SetCustomFieldAction"/> class.
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
