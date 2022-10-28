﻿using System.Collections.Generic;

using Newtonsoft.Json;

namespace ctLite.ProductProjectionSearch
{
    /// <summary>
    /// The term type facets provide the counts for each of the different values the query parameter happens to have.
    /// </summary>
    /// <remarks>
    /// This is useful for, e.g., obtaining all possible values of a product attribute to provide filters for those values on the frontend.
    /// </remarks>
    /// <see href="https://dev.commercetools.com/http-api-projects-products-search.html#term-type"/>
    public class TermFacet : Facet
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ctLite.ProductProjectionSearch.TermFacet"/> class.
        /// </summary>
        public TermFacet() : base() {}

        /// <summary>
        /// Initializes this instance with JSON data from an API response.
        /// </summary>
        /// <param name="data">JSON object</param>
        public TermFacet(dynamic data)
            : base((object)data)
        {
        }

        #endregion
    }
}
