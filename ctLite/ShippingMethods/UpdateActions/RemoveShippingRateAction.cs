﻿using ctLite.Common;

using Newtonsoft.Json;

namespace ctLite.ShippingMethods.UpdateActions
{
    /// <summary>
    /// Remove ShippingRate
    /// </summary>
    /// <see href="https://dev.commercetools.com/http-api-projects-shippingMethods.html#remove-shippingrate"/>
    public class RemoveShippingRateAction : UpdateAction
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
        /// Initializes a new instance of the
        /// <see cref="T:ctLite.ShippingMethods.UpdateActions.RemoveShippingRateAction"/> class.
        /// </summary>
        public RemoveShippingRateAction()
        {
            this.Action = "removeShippingRate";
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="zone">Reference to a Zone</param>
        /// <param name="shippingRate">Shipping Rate</param>
        public RemoveShippingRateAction(Reference zone, ShippingRate shippingRate)
        {
            this.Action = "removeShippingRate";
            this.Zone = zone;
            this.ShippingRate = shippingRate;
        }

        #endregion
    }
}
