﻿using ctLite.Common;

using Newtonsoft.Json;

namespace ctLite.Customers.UpdateActions
{
    /// <summary>
    /// Removes an existing billing address from the Customer’s billingAddressesIds.
    /// </summary>
    /// <remarks>
    /// If the billing address is the Customer’s default billing address the Customer’s defaultBillingAddressId will be unset.
    /// </remarks>
    /// <see href="http://dev.commercetools.com/http-api-projects-customers.html#remove-billing-address-id"/>
    public class RemoveBillingAddressIdAction : UpdateAction
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
        /// Initializes a new instance of the
        /// <see cref="T:ctLite.Customers.UpdateActions.RemoveBillingAddressIdAction"/> class.
        /// </summary>
        public RemoveBillingAddressIdAction()
        {
            this.Action = "removeBillingAddressId";
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="addressId">Address ID</param>
        public RemoveBillingAddressIdAction(string addressId)
        {
            this.Action = "removeBillingAddressId";
            this.AddressId = addressId;
        }

        #endregion
    }
}
