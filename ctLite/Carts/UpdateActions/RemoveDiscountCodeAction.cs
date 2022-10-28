﻿using ctLite.Common;

using Newtonsoft.Json;

namespace ctLite.Carts.UpdateActions
{
    /// <summary>
    /// Removes a discount code from the cart.
    /// </summary>
    /// <see href="https://dev.commercetools.com/http-api-projects-carts.html#remove-discountcode"/>
    public class RemoveDiscountCodeAction : UpdateAction
    {
        #region Properties

        /// <summary>
        /// Reference to a DiscountCode.
        /// </summary>
        [JsonProperty(PropertyName = "discountCode")]
        public Reference DiscountCode { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ctLite.Carts.UpdateActions.RemoveDiscountCodeAction"/> class.
        /// </summary>
        public RemoveDiscountCodeAction()
        {
            this.Action = "removeDiscountCode";
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="discountCode">Reference to a DiscountCode.</param>
        public RemoveDiscountCodeAction(Reference discountCode)
        {
            this.Action = "removeDiscountCode";
            this.DiscountCode = discountCode;
        }

        #endregion
    }
}
