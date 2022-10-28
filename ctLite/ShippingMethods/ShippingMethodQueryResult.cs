﻿using System.Collections.Generic;

using ctLite.Common;

using Newtonsoft.Json;

namespace ctLite.ShippingMethods
{
    /// <summary>
    /// An implementation of PagedQueryResult that provides access to the results as a List of ShippingMethod objects.
    /// </summary>
    /// <see href="http://dev.commercetools.com/http-api.html#pagedqueryresult"/>
    public class ShippingMethodQueryResult : PagedQueryResult
    {
        #region Properties

        /// <summary>
        /// Results
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public List<ShippingMethod> Results { get; private set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ctLite.ShippingMethods.ShippingMethodQueryResult"/> class.
        /// </summary>
        public ShippingMethodQueryResult() : base() {}

        /// <summary>
        /// Initializes this instance with JSON data from an API response.
        /// </summary>
        /// <param name="data">JSON object</param>
        public ShippingMethodQueryResult(dynamic data)
            : base((object)data)
        {
            if (data == null)
            {
                return;
            }

            this.Results = Helper.GetListFromJsonArray<ShippingMethod>(data.results);
        }

        #endregion
    }
}
