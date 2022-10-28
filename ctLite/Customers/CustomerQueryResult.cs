﻿using System.Collections.Generic;

using ctLite.Common;

using Newtonsoft.Json;

namespace ctLite.Customers
{
    /// <summary>
    /// An implementation of PagedQueryResult that provides access to the results as a List of Customer objects.
    /// </summary>
    /// <see href="https://dev.commercetools.com/http-api.html#pagedqueryresult"/>
    public class CustomerQueryResult : PagedQueryResult
    {
        #region Properties

        /// <summary>
        /// Results
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public List<Customer> Results { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ctLite.Customers.CustomerQueryResult"/> class.
        /// </summary>
        public CustomerQueryResult() : base() {}

        /// <summary>
        /// Initializes this instance with JSON data from an API response.
        /// </summary>
        /// <param name="data">JSON object</param>
        public CustomerQueryResult(dynamic data = null)
            : base((object)data)
        {
            if (data == null)
            {
                return;
            }

            this.Results = Helper.GetListFromJsonArray<Customer>(data.results);
        }

        #endregion
    }
}
