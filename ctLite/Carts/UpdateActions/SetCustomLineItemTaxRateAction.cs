﻿using ctLite.Common;

using Newtonsoft.Json;

namespace ctLite.Carts.UpdateActions
{
    /// <summary>
    /// A custom line item tax rate can be set if the cart has the External TaxMode.
    /// </summary>
    /// <see href="https://dev.commercetools.com/http-api-projects-carts.html#set-customlineitem-taxrate"/>
    public class SetCustomLineItemTaxRateAction : UpdateAction
    {
        #region Properties

        /// <summary>
        /// CustomLineItemId
        /// </summary>
        [JsonProperty(PropertyName = "customLineItemId")]
        public string CustomLineItemId  { get; set; }

        /// <summary>
        /// An external tax rate can be set if the cart has the External TaxMode.
        /// </summary>
        [JsonProperty(PropertyName = "externalTaxRate")]
        public ExternalTaxRateDraft ExternalTaxRate { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ctLite.Carts.UpdateActions.SetCustomLineItemTaxRateAction"/> class.
        /// </summary>
        public SetCustomLineItemTaxRateAction()
        {
            this.Action = "setCustomLineItemTaxRate";
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="customLineItemId">CustomLineItemId</param>
        public SetCustomLineItemTaxRateAction(string customLineItemId)
        {
            this.Action = "setCustomLineItemTaxRate";
            this.CustomLineItemId = customLineItemId;
        }

        #endregion
    }
}
