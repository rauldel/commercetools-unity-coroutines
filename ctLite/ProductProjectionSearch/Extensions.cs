﻿using ctLite.Common;

namespace ctLite.ProductProjectionSearch
{
    /// <summary>
    /// Extensions
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// Creates an instance of the ProductProjectionSearchManager.
        /// </summary>
        /// <returns>ProductProjectionSearchManager</returns>
        public static ProductProjectionSearchManager ProductProjectionSearch(this UnityClient client)
        {
            return new ProductProjectionSearchManager(client);
        }
    }
}
