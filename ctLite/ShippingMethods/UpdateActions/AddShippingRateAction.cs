﻿using ctLite.Common;

using Newtonsoft.Json;

namespace ctLite.ShippingMethods.UpdateActions
{
    /// <summary>
    /// Add ShippingRate
    /// </summary>
    /// <see href="https://dev.commercetools.com/http-api-projects-shippingMethods.html#add-shippingrate"/>
    public class AddShippingRateAction : UpdateAction
    {
        #region Properties

        /// <summary>
        /// Reference to a Zone
        /// </summary>
        [JsonProperty(PropertyName = "zone")]
        public Reference Zone { get; set; }

        /// <summary>
        /// Shipping Rate
        /// </summary>
        [JsonProperty(PropertyName = "shippingRate")]
        public ShippingRate ShippingRate { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ctLite.ShippingMethods.UpdateActions.AddShippingRateAction"/> class.
        /// </summary>
        public AddShippingRateAction()
        {
            this.Action = "addShippingRate";
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="zone">Reference to a Zone</param>
        /// <param name="shippingRate">Shipping Rate</param>
        public AddShippingRateAction(Reference zone, ShippingRate shippingRate)
        {
            this.Action = "addShippingRate";
            this.Zone = zone;
            this.ShippingRate = shippingRate;
        }

        #endregion
    }
}
