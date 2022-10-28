﻿using ctLite.Payments;

using Newtonsoft.Json;

namespace ctLite.Messages
{
    /// <summary>
    /// This message is the result of a create action.
    /// </summary>
    /// <see href="http://dev.commercetools.com/http-api-projects-messages.html#paymentcreated-message"/>
    public class PaymentCreatedMessage : Message
    {
        #region Properties

        /// <summary>
        /// Payment
        /// </summary>
        [JsonProperty(PropertyName = "payment")]
        public Payment Payment { get; private set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ctLite.Messages.PaymentCreatedMessage"/> class.
        /// </summary>
        public PaymentCreatedMessage() : base() {}

        /// <summary>
        /// Initializes this instance with JSON data from an API response.
        /// </summary>
        /// <param name="data">JSON object</param>
        public PaymentCreatedMessage(dynamic data)
            : base((object)data)
        {
            if (data == null)
            {
                return;
            }

            this.Payment = new Payment(data.payment);
        }

        #endregion
    }
}
