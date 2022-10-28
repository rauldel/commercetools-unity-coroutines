﻿using ctLite.Common;

using Newtonsoft.Json;

namespace ctLite.Messages
{
    /// <summary>
    /// This message is created when the billing address of an existing order is modified.
    /// </summary>
    /// <see href="http://dev.commercetools.com/http-api-projects-messages.html#orderbillingaddressset-message"/>
    public class OrderBillingAddressSetMessage : Message
    {
        #region Properties

        /// <summary>
        /// Address
        /// </summary>
        [JsonProperty(PropertyName = "address")]
        public Address Address { get; private set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ctLite.Messages.OrderBillingAddressSetMessage"/> class.
        /// </summary>
        public OrderBillingAddressSetMessage() : base() {}

        /// <summary>
        /// Initializes this instance with JSON data from an API response.
        /// </summary>
        /// <param name="data">JSON object</param>
        public OrderBillingAddressSetMessage(dynamic data)
            : base((object)data)
        {
            if (data == null)
            {
                return;
            }

            this.Address = new Address(data.address);
        }

        #endregion
    }
}

