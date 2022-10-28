﻿using ctLite.Common;

using Newtonsoft.Json;

namespace ctLite.Orders.UpdateActions
{
    /// <summary>
    /// In order to add a Parcel, there needs to be at least one Delivery with at least one DeliveryItem created before.
    /// </summary>
    /// <see href="http://dev.commercetools.com/http-api-projects-orders.html#add-parcel"/>
    public class AddParcelAction : UpdateAction
    {
        #region Properties

        /// <summary>
        /// ID of the concerning DeliveryItem.
        /// </summary>
        [JsonProperty(PropertyName = "deliveryId")]
        public string DeliveryId { get; set; }

        /// <summary>
        /// Measurements
        /// </summary>
        [JsonProperty(PropertyName = "measurements")]
        public ParcelMeasurements Measurements { get; set; }

        /// <summary>
        /// Tracking data
        /// </summary>
        [JsonProperty(PropertyName = "trackingData")]
        public TrackingData TrackingData { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ctLite.Orders.UpdateActions.AddParcelAction"/> class.
        /// </summary>
        public AddParcelAction()
        {
            this.Action = "addParcelToDelivery";
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="deliveryId">ID of the concerning DeliveryItem.</param>
        public AddParcelAction(string deliveryId)
        {
            this.Action = "addParcelToDelivery";
            this.DeliveryId = deliveryId;
        }

        #endregion
    }
}
