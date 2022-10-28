﻿using ctLite.Common;
using Newtonsoft.Json;

namespace ctLite.CartDiscounts.UpdateActions
{
    public class ChangeCartPredicateAction : UpdateAction
    {
        #region Properties

        [JsonProperty(PropertyName = "cartPredicate")]
        public string CartPredicate { get; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:ctLite.CartDiscounts.UpdateActions.ChangeCartPredicateAction"/> class.
        /// </summary>
        public ChangeCartPredicateAction()
        {
            this.Action = "changeCartPredicate";
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:ctLite.CartDiscounts.UpdateActions.ChangeCartPredicateAction"/> class.
        /// </summary>
        /// <param name="cartPredicate">Cart predicate.</param>
        public ChangeCartPredicateAction(string cartPredicate)
        {
            this.Action = "changeCartPredicate";
            this.CartPredicate = cartPredicate;
        }

        #endregion
    }
}
