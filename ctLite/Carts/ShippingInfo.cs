﻿using System;
using System.Collections.Generic;

using ctLite;
using ctLite.Common;
using ctLite.Orders;
using ctLite.ShippingMethods;
using ctLite.TaxCategories;

using Newtonsoft.Json;

namespace ctLite.Carts
{
    /// <summary>
    /// ShippingInfo
    /// </summary>
    /// <see href="http://dev.commercetools.com/http-api-projects-carts.html#shippinginfo"/>
    public class ShippingInfo
    {
        #region Properties

        [JsonProperty(PropertyName = "shippingMethodName")]
        public string ShippingMethodName { get; private set; }

        [JsonProperty(PropertyName = "price")]
        public Money Price { get; private set; }

        [JsonProperty(PropertyName = "shippingRate")]
        public ShippingRate ShippingRate { get; private set; }

        [JsonProperty(PropertyName = "taxRate")]
        public TaxRate TaxRate { get; private set; }

        [JsonProperty(PropertyName = "taxCategory")]
        public Reference TaxCategory { get; private set; }

        [JsonProperty(PropertyName = "shippingMethod")]
        public Reference ShippingMethod { get; private set; }

        [JsonProperty(PropertyName = "deliveries")]
        public List<Delivery> Deliveries { get; private set; }

        [JsonProperty(PropertyName = "discountedPrice")]
        public DiscountedLineItemPrice DiscountedPrice { get; private set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ctLite.Carts.ShippingInfo"/> class.
        /// </summary>
        public ShippingInfo() {}

        /// <summary>
        /// Initializes this instance with JSON data from an API response.
        /// </summary>
        /// <param name="data">JSON object</param>
        public ShippingInfo(dynamic data)
        {
            if (data == null)
            {
                return;
            }

            this.ShippingMethodName = data.shippingMethodName;
            this.Price = new Money(data.price);
            this.ShippingRate = new ShippingRate(data.shippingRate);
            this.TaxRate = new TaxRate(data.taxRate);
            this.TaxCategory = new Reference(data.taxCategory);
            this.ShippingMethod = new Reference(data.shippingMethod);
            this.Deliveries = Helper.GetListFromJsonArray<Delivery>(data.deliveries);
            this.DiscountedPrice = new DiscountedLineItemPrice(data.discountedPrice);
        }

        #endregion
    }
}
