﻿using ctLite.Common;

using Newtonsoft.Json;

namespace ctLite.Orders.UpdateActions
{
    /// <summary>
    /// Sets a string that uniquely identifies an order. It can be used to create more human-readable (in contrast to ID) identifier for the order.
    /// </summary>>
    /// <see href="http://dev.commercetools.com/http-api-projects-orders.html#set-order-number"/>
    public class SetOrderNumberAction : UpdateAction
    {
        #region Properties

        /// <summary>
        /// It should be unique across a project. Once it's set, it cannot be changed.
        /// </summary>
        [JsonProperty(PropertyName = "orderNumber")]
        public string OrderNumber { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ctLite.Orders.UpdateActions.SetOrderNumberAction"/> class.
        /// </summary>
        public SetOrderNumberAction()
        {
            this.Action = "setOrderNumber";
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="orderNumber">It should be unique across a project. Once it's set, it cannot be changed.</param>
        public SetOrderNumberAction(string orderNumber)
        {
            this.Action = "setOrderNumber";
            this.OrderNumber = orderNumber;
        }

        #endregion
    }
}
