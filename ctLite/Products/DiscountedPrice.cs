﻿using System;

using ctLite.Common;

using Newtonsoft.Json;

namespace ctLite.Products
{
    /// <summary>
    /// DiscountedPrice
    /// </summary>
    /// <see href="http://dev.commercetools.com/http-api-projects-products.html#discountedprice"/>
    public class DiscountedPrice
    {
        #region Properties

        [JsonProperty(PropertyName = "value")]
        public Money Value { get; private set; }

        [JsonProperty(PropertyName = "discount")]
        public Reference Discount { get; private set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ctLite.Products.DiscountedPrice"/> class.
        /// </summary>
        public DiscountedPrice() {}

        /// <summary>
        /// Initializes this instance with JSON data from an API response.
        /// </summary>
        /// <param name="data">JSON object</param>
        public DiscountedPrice(dynamic data)
        {
            if (data == null)
            {
                return;
            }

            this.Value = data.value != null ? new Money(data.value) : null;
            this.Discount = data.discount != null ? new Reference(data.discount) : null;
        }

        #endregion
    }
}
