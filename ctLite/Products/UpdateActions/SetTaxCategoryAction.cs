﻿using ctLite.Common;

using Newtonsoft.Json;

namespace ctLite.Products.UpdateActions
{
    /// <summary>
    /// Adds, changes or removes a product’s TaxCategory. 
    /// </summary>
    /// <remarks>
    /// This change can never be staged and is thus immediately visible in published products.
    /// </remarks>
    /// <see href="http://dev.commercetools.com/http-api-projects-products.html#set-taxcategory"/>
    public class SetTaxCategoryAction : UpdateAction
    {
        #region Properties

        /// <summary>
        /// Reference to a TaxCategory 
        /// </summary>
        /// <remarks>
        /// If left blank or set to null, the tax category is unset/removed.
        /// </remarks>
        [JsonProperty(PropertyName = "taxCategory")]
        public Reference TaxCategory { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ctLite.Products.UpdateActions.SetTaxCategoryAction"/> class.
        /// </summary>
        public SetTaxCategoryAction()
        {
            this.Action = "setTaxCategory";
        }

        /// <summary>
        /// Constructor.
        /// </summary>
        public SetTaxCategoryAction(Reference category)
        {
            this.Action = "setTaxCategory";
        }

        #endregion
    }
}
