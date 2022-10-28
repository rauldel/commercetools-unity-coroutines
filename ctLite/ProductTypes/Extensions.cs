﻿using ctLite.Common;

namespace ctLite.ProductTypes
{
    /// <summary>
    /// Extensions
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// Creates an instance of the ProductTypeManager.
        /// </summary>
        /// <returns>ProductTypeManager</returns>
        public static ProductTypeManager ProductTypes(this UnityClient client)
        {
            return new ProductTypeManager(client);
        }
    }
}
