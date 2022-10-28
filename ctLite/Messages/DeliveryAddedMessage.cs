﻿using ctLite.Orders;

using Newtonsoft.Json;

namespace ctLite.Messages
{
    /// <summary>
    /// This message is the result of the addDelivery update action.
    /// </summary>
    /// <see href="http://dev.commercetools.com/http-api-projects-messages.html#deliveryadded-message"/>
    public class DeliveryAddedMessage : Message
    {
        #region Properties

        [JsonProperty(PropertyName = "delivery")]
        public Delivery Delivery { get; private set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ctLite.Messages.DeliveryAddedMessage"/> class.
        /// </summary>
        public DeliveryAddedMessage() : base() {}

        /// <summary>
        /// Initializes this instance with JSON data from an API response.
        /// </summary>
        /// <param name="data">JSON object</param>
        public DeliveryAddedMessage(dynamic data) 
            : base((object)data)
        {
            if (data == null)
            {
                return;
            }

            this.Delivery = new Delivery(data.delivery);
        }

        #endregion
    }
}
