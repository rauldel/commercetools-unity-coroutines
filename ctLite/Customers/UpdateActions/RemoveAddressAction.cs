﻿using ctLite.Common;

using Newtonsoft.Json;

namespace ctLite.Customers.UpdateActions
{
    /// <summary>
    /// Removes the address with the given ID from the customer's addresses array.
    /// </summary>
    /// <see href="http://dev.commercetools.com/http-api-projects-customers.html#remove-address"/>
    public class RemoveAddressAction : UpdateAction
    {
        #region Properties

        /// <summary>
        /// Address ID
        /// </summary>
        [JsonProperty(PropertyName = "addressId")]
        public string AddressId { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ctLite.Customers.UpdateActions.RemoveAddressAction"/> class.
        /// </summary>
        public RemoveAddressAction()
        {
            this.Action = "removeAddress";
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="addressId">Address ID</param>
        public RemoveAddressAction(string addressId)
        {
            this.Action = "removeAddress";
            this.AddressId = addressId;
        }

        #endregion
    }
}
