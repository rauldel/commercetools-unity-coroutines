﻿using System.Collections.Generic;

using ctLite.Common;

using Newtonsoft.Json;

namespace ctLite.Carts
{
    /// <summary>
    /// An implementation of PagedQueryResult that provides access to the results as a List of Cart objects.
    /// </summary>
    /// <see href="https://dev.commercetools.com/http-api.html#pagedqueryresult"/>
    public class CartQueryResult : PagedQueryResult
    {
        #region Properties

        /// <summary>
        /// Results
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public List<Cart> Results { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ctLite.Carts.CartQueryResult"/> class.
        /// </summary>
        public CartQueryResult() {}

        /// <summary>
        /// Initializes this instance with JSON data from an API response.
        /// </summary>
        /// <param name="data">JSON object</param>
        public CartQueryResult(dynamic data)
            : base((object)data)
        {
            if (data == null)
            {
                return;
            }

            this.Results = Helper.GetListFromJsonArray<Cart>(data.results);
        }

        #endregion
    }
}
