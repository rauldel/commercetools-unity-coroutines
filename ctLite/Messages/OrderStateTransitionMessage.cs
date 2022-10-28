﻿using ctLite.Common;

using Newtonsoft.Json;

namespace ctLite.Messages
{
    /// <summary>
    /// This message is the result of the transitionState update action.
    /// </summary>
    /// <see href="http://dev.commercetools.com/http-api-projects-messages.html#orderstatetransition-message"/>
    public class OrderStateTransitionMessage : Message
    {
        #region Properties

        /// <summary>
        /// State
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public Reference State { get; private set; }

        /// <summary>
        /// Force
        /// </summary>
        [JsonProperty(PropertyName = "force")]
        public bool? Force { get; private set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ctLite.Messages.OrderStateTransitionMessage"/> class.
        /// </summary>
        public OrderStateTransitionMessage() : base() {}

        /// <summary>
        /// Initializes this instance with JSON data from an API response.
        /// </summary>
        /// <param name="data">JSON object</param>
        public OrderStateTransitionMessage(dynamic data)
            : base((object)data)
        {
            if (data == null)
            {
                return;
            }

            this.State = new Reference(data.state);
            this.Force = data.force;
        }

        #endregion
    }
}