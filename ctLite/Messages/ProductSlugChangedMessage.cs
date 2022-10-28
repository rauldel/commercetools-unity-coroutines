﻿using ctLite.Common;

using Newtonsoft.Json;

namespace ctLite.Messages
{
    /// <summary>
    /// This message is the result of the changeSlug update action.
    /// </summary>
    /// <see href="http://dev.commercetools.com/http-api-projects-messages.html#productslugchanged-message"/>
    public class ProductSlugChangedMessage : Message
    {
        #region Properties

        /// <summary>
        /// Slug
        /// </summary>
        [JsonProperty(PropertyName = "slug")]
        public LocalizedString Slug { get; private set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ctLite.Messages.ProductSlugChangedMessage"/> class.
        /// </summary>
        public ProductSlugChangedMessage() : base() {}

        /// <summary>
        /// Initializes this instance with JSON data from an API response.
        /// </summary>
        /// <param name="data">JSON object</param>
        public ProductSlugChangedMessage(dynamic data)
            : base((object)data)
        {
            if (data == null)
            {
                return;
            }

            this.Slug = new LocalizedString(data.slug);
        }

        #endregion
    }
}
