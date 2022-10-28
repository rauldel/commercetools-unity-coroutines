﻿using ctLite.Common;

using Newtonsoft.Json;

namespace ctLite.Categories.UpdateActions
{
    /// <summary>
    /// SetMetaTitleAction
    /// </summary>
    /// <see href="http://dev.commercetools.com/http-api-projects-categories.html#set-meta-title"/>
    public class SetMetaTitleAction : UpdateAction
    {
        #region Properties

        /// <summary>
        /// Meta Title
        /// </summary>
        [JsonProperty(PropertyName = "metaTitle")]
        public LocalizedString MetaTitle { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Constructor.
        /// </summary>
        public SetMetaTitleAction()
        {
            this.Action = "setMetaTitle";
        }

        #endregion
    }
}
