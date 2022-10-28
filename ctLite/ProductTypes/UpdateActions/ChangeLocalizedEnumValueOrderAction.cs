﻿using System.Collections.Generic;

using ctLite.Common;

using Newtonsoft.Json;

namespace ctLite.ProductTypes.UpdateActions
{
    /// <summary>
    /// This action changes the order of localized enum values in a LocalizableEnumType attribute definition. It can update a LocalizableEnumType attribute definition or a Set of LocalizableEnumType attribute definition.
    /// </summary>
    /// <see href="https://dev.commercetools.com/http-api-projects-productTypes.html#change-the-order-of-localizedenumvalues"/>
    public class ChangeLocalizedEnumValueOrderAction : UpdateAction
    {
        #region Properties

        /// <summary>
        /// Attribute Name
        /// </summary>
        [JsonProperty(PropertyName = "attributeName")]
        public string AttributeName { get; set; }

        /// <summary>
        /// Values
        /// </summary>
        /// <remarks>
        /// The values must be equal to the values of the attribute enum values (except for the order).
        /// </remarks>
        [JsonProperty(PropertyName = "values")]
        public List<LocalizedEnumValue> Values { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:ctLite.ProductTypes.UpdateActions.ChangeLocalizedEnumValueOrderAction"/> class.
        /// </summary>
        public ChangeLocalizedEnumValueOrderAction()
        {
            this.Action = "changeLocalizedEnumValueOrder";
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="attributeName">Attribute Name</param>
        /// <param name="values">Values</param>
        public ChangeLocalizedEnumValueOrderAction(string attributeName, List<LocalizedEnumValue> values)
        {
            this.Action = "changeLocalizedEnumValueOrder";
            this.AttributeName = attributeName;
            this.Values = values;
        }

        #endregion
    }
}
