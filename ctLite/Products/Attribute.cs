﻿using Newtonsoft.Json;

namespace ctLite.Products
{
    /// <summary>
    /// Attribute
    /// </summary>
    /// <see href="http://dev.commercetools.com/http-api-projects-products.html#attribute"/>
    public class Attribute
    {
        #region Properties

        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        [JsonProperty(PropertyName = "value")]
        public object Value { get; private set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="T:ctLite.Products.Attribute"/> class.
        /// </summary>
        public Attribute() {}

        /// <summary>
        /// Initializes this instance with JSON data from an API response.
        /// </summary>
        /// <param name="data">JSON object</param>
        public Attribute(dynamic data)
        {
            if (data == null)
            {
                return;
            }

            this.Name = data.name;
            this.Value = data.value;
        }

        #endregion
    }
}
