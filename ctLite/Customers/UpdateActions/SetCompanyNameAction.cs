﻿using ctLite.Common;

using Newtonsoft.Json;

namespace ctLite.Customers.UpdateActions
{
    /// <summary>
    /// SetCompanyNameAction
    /// </summary>
    /// <see href="http://dev.commercetools.com/http-api-projects-customers.html#set-company-name"/>
    public class SetCompanyNameAction : UpdateAction
    {
        #region Properties

        /// <summary>
        /// Company Name
        /// </summary>
        [JsonProperty(PropertyName = "companyName")]
        public string CompanyName { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Constructor.
        /// </summary>
        public SetCompanyNameAction()
        {
            this.Action = "setCompanyName";
        }

        #endregion
    }
}
