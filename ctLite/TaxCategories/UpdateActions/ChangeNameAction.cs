﻿using ctLite.Common;

using Newtonsoft.Json;

namespace ctLite.TaxCategories.UpdateActions
{
    /// <summary>
    /// Change Name
    /// </summary>
    /// <see href="https://dev.commercetools.com/http-api-projects-taxCategories.html#change-name"/>
    public class ChangeNameAction : UpdateAction
    {
        #region Properties

        /// <summary>
        /// Name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ctLite.TaxCategories.UpdateActions.ChangeNameAction"/> class.
        /// </summary>
        public ChangeNameAction()
        {
            this.Action = "changeName";
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="name">Name</param>
        public ChangeNameAction(string name)
        {
            this.Action = "changeName";
            this.Name = name;
        }

        #endregion
    }
}
