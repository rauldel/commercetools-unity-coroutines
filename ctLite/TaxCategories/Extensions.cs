﻿using ctLite.Common;

namespace ctLite.TaxCategories
{
    /// <summary>
    /// Extensions
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// Creates an instance of the TaxCategoryManager.
        /// </summary>
        /// <returns>TaxCategoryManager</returns>
        public static TaxCategoryManager TaxCategories(this UnityClient client)
        {
            return new TaxCategoryManager(client);
        }
    }
}
