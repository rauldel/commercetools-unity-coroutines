﻿using ctLite.Common;
using Newtonsoft.Json;

namespace ctLite.CartDiscounts.UpdateActions
{
    public class ChangeSortOrderAction : UpdateAction
    {
        #region Properties

        [JsonProperty(PropertyName = "sortOrder")]
        public string SortOrder { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ctLite.CartDiscounts.UpdateActions.ChangeSortOrderAction"/> class.
        /// </summary>
        public ChangeSortOrderAction()
        {
            this.Action = "changeSortOrder";
        }

        /// <summary>
        /// Constructor with parameters.
        /// </summary>
        /// <param name="sortOrder">Sort order.</param>
        public ChangeSortOrderAction(string sortOrder)
        {
            this.Action = "changeSortOrder";
            this.SortOrder = sortOrder;
        }

        #endregion
    }
}
