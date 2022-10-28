﻿using ctLite.Common;

using Newtonsoft.Json;

namespace ctLite.Payments.UpdateActions
{
    /// <summary>
    /// Sets the interface that handles the payment (usually a PSP).
    /// </summary>
    /// <remarks>
    /// Cannot be changed once it has been set. The combination of Payment interfaceId and PaymentMethodInfo paymentInterface must be unique.
    /// </remarks>
    /// <see href="https://dev.commercetools.com/http-api-projects-payments.html#set-methodinfointerface"/>
    public class SetMethodInfoInterfaceAction : UpdateAction
    {
        #region Properties

        /// <summary>
        /// Interface
        /// </summary>
        [JsonProperty(PropertyName = "interface")]
        public string Interface { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ctLite.Payments.UpdateActions.SetMethodInfoInterfaceAction"/> class.
        /// </summary>
        public SetMethodInfoInterfaceAction()
        {
            this.Action = "setMethodInfoInterface";
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="methodInfoInterface">Interface</param>
        public SetMethodInfoInterfaceAction(string methodInfoInterface)
        {
            this.Action = "setMethodInfoInterface";
            this.Interface = methodInfoInterface;
        }

        #endregion
    }
}
