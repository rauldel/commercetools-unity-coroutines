﻿using ctLite.Common;

namespace ctLite.Customers
{
    /// <summary>
    /// Extensions
    /// </summary>
    public static class Extensions
    {
        /// <summary>
        /// Creates an instance of the CustomerManager.
        /// </summary>
        /// <returns>CustomerManager</returns>
        public static CustomerManager Customers(this UnityClient client)
        {
            return new CustomerManager(client);
        }
    }
}
