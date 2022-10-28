﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;

using ctLite.Common;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ctLite.Products
{
  /// <summary>
  /// Provides access to the functions in the Products section of the API.
  /// </summary>
  /// <see href="http://dev.commercetools.com/http-api-projects-products.html"/>
  public class ProductManager
  {
    #region Constants

    private const string ENDPOINT_PREFIX = "/products";

    #endregion

    #region Member Variables

    private readonly UnityClient _client;

    #endregion

    #region Constructors

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="client">Client</param>
    public ProductManager(UnityClient client)
    {
      _client = client;
    }

    #endregion

    #region API Methods

    /// <summary>
    /// Gets the full representation of a product by ID.
    /// </summary>
    /// <param name="productId">Product ID</param>
    /// <param name="priceCurrency">The currency code compliant to ISO 4217. Enables price selection.</param>
    /// <param name="priceCountry">A two-digit country code as per ISO 3166-1 alpha-2. Enables price selection. Can only be used in conjunction with the priceCurrency parameter.</param>
    /// <param name="priceCustomerGroup">Enables price selection. Can only be used in conjunction with the priceCurrency parameter.</param>
    /// <param name="priceChannel">Enables price selection. Can only be used in conjunction with the priceCurrency parameter.</param>
    /// <returns>Product</returns>
    /// <see href="http://dev.commercetools.com/http-api-projects-products.html#get-product-by-id"/>
    public IEnumerator GetProductByIdAsync(string productId, Action<Response<Product>> onSuccess, Action<Response<Product>> onError, string priceCurrency = null, string priceCountry = null, Guid priceCustomerGroup = new Guid(), Guid priceChannel = new Guid())
    {
      if (string.IsNullOrWhiteSpace(productId))
      {
        throw new ArgumentException("productId is required");
      }

      string endpoint = string.Concat(ENDPOINT_PREFIX, "/", productId);
      return GetProductAsync(endpoint, onSuccess, onError, priceCurrency, priceCountry, priceCustomerGroup, priceChannel);
    }

    /// <summary>
    /// Gets the full representation of a product by Key.
    /// </summary>
    /// <param name="key">Product key</param>
    /// <param name="priceCurrency">The currency code compliant to ISO 4217. Enables price selection.</param>
    /// <param name="priceCountry">A two-digit country code as per ISO 3166-1 alpha-2. Enables price selection. Can only be used in conjunction with the priceCurrency parameter.</param>
    /// <param name="priceCustomerGroup">Enables price selection. Can only be used in conjunction with the priceCurrency parameter.</param>
    /// <param name="priceChannel">Enables price selection. Can only be used in conjunction with the priceCurrency parameter.</param>
    /// <returns>Product</returns>
    /// <see href="http://dev.commercetools.com/http-api-projects-products.html#get-product-by-key"/>
    public IEnumerator GetProductByKeyAsync(string key, Action<Response<Product>> onSuccess, Action<Response<Product>> onError, string priceCurrency = null, string priceCountry = null, Guid priceCustomerGroup = new Guid(), Guid priceChannel = new Guid())
    {
      if (string.IsNullOrWhiteSpace(key))
      {
        throw new ArgumentException("key is required");
      }

      string endpoint = string.Concat(ENDPOINT_PREFIX, "/key=", key);
      return GetProductAsync(endpoint, onSuccess, onError, priceCurrency, priceCountry, priceCustomerGroup, priceChannel);
    }

    /// <summary>
    /// Private worker method for GetProductByIdAsync and GetProductByKeyAsync.
    /// </summary>
    /// <param name="endpoint">Request endpoint</param>
    /// <param name="priceCurrency">The currency code compliant to ISO 4217. Enables price selection.</param>
    /// <param name="priceCountry">A two-digit country code as per ISO 3166-1 alpha-2. Enables price selection. Can only be used in conjunction with the priceCurrency parameter.</param>
    /// <param name="priceCustomerGroup">Enables price selection. Can only be used in conjunction with the priceCurrency parameter.</param>
    /// <param name="priceChannel">Enables price selection. Can only be used in conjunction with the priceCurrency parameter.</param>
    /// <returns>Product</returns>
    /// <see href="http://dev.commercetools.com/http-api-projects-products.html#get-product"/>
    private IEnumerator GetProductAsync(string endpoint, Action<Response<Product>> onSuccess, Action<Response<Product>> onError, string priceCurrency = null, string priceCountry = null, Guid priceCustomerGroup = new Guid(), Guid priceChannel = new Guid())
    {
      NameValueCollection values = new NameValueCollection();

      if (!string.IsNullOrWhiteSpace(priceCurrency))
      {
        values.Add("priceCurrency", priceCurrency);

        if (!string.IsNullOrWhiteSpace(priceCountry))
        {
          values.Add("priceCountry", priceCountry);
        }

        if (priceCustomerGroup != Guid.Empty)
        {
          values.Add("priceCustomerGroup", priceCustomerGroup.ToString());
        }

        if (priceChannel != Guid.Empty)
        {
          values.Add("priceChannel", priceChannel.ToString());
        }
      }

      return _client.GetAsync<Product>(endpoint, onSuccess, onError, values);
    }

    /// <summary>
    /// Queries for Products.
    /// </summary>
    /// <param name="where">Where</param>
    /// <param name="sort">Sort</param>
    /// <param name="limit">Limit</param>
    /// <param name="offset">Offset</param>
    /// <param name="priceCurrency">Enables price selection</param>
    /// <param name="priceCountry">Enables price selection. Can only be used in conjunction with the priceCurrency parameter</param>
    /// <param name="priceCustomerGroup">Enables price selection. Can only be used in conjunction with the priceCurrency parameter</param>
    /// <param name="priceChannel">Enables price selection. Can only be used in conjunction with the priceCurrency parameter</param>
    /// <returns>ProductQueryResult</returns>
    /// <see href="http://dev.commercetools.com/http-api-projects-products.html#products-by-query"/>
    public IEnumerator QueryProductsAsync(
        Action<Response<ProductQueryResult>> onSuccess,
        Action<Response<ProductQueryResult>> onError,
        string where = null,
        string sort = null,
        int limit = -1,
        int offset = -1,
        string priceCurrency = null,
        string priceCountry = null,
        string priceCustomerGroup = null,
        string priceChannel = null)
    {
      NameValueCollection values = new NameValueCollection();

      if (!string.IsNullOrWhiteSpace(where))
      {
        values.Add("where", where);
      }

      if (!string.IsNullOrWhiteSpace(sort))
      {
        values.Add("sort", sort);
      }

      if (limit > 0)
      {
        values.Add("limit", limit.ToString());
      }

      if (offset >= 0)
      {
        values.Add("offset", offset.ToString());
      }

      if (!string.IsNullOrWhiteSpace(priceCurrency))
      {
        values.Add("priceCurrency", priceCurrency);

        if (!string.IsNullOrWhiteSpace(priceCountry))
        {
          values.Add("priceCountry", priceCountry);
        }

        if (!string.IsNullOrWhiteSpace(priceCustomerGroup))
        {
          values.Add("priceCustomerGroup", priceCustomerGroup);
        }

        if (!string.IsNullOrWhiteSpace(priceChannel))
        {
          values.Add("priceChannel", priceChannel);
        }
      }
      return _client.GetAsync<ProductQueryResult>(ENDPOINT_PREFIX,onSuccess, onError, values);
    }

    /// <summary>
    /// Creates a new Product.
    /// </summary>
    /// <param name="productDraft">ProductDraft</param>
    /// <returns>Product</returns>
    /// <see href="http://dev.commercetools.com/http-api-projects-products.html#create-product"/>
    public IEnumerator CreateProductAsync(ProductDraft productDraft, Action<Response<Product>> onSuccess, Action<Response<Product>> onError)
    {
      if (productDraft.Name == null || productDraft.Name.IsEmpty())
      {
        throw new ArgumentException("name is required");
      }

      if (productDraft.ProductType == null)
      {
        throw new ArgumentException("productType is required");
      }

      if (productDraft.Slug == null || productDraft.Slug.IsEmpty())
      {
        throw new ArgumentException("slug is required");
      }

      string payload = JsonConvert.SerializeObject(productDraft, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
      return _client.PostAsync<Product>(ENDPOINT_PREFIX, payload, onSuccess, onError);
    }

    /// <summary>
    /// (Partial) updates are made to an existing product by sending a list of actions to be applied. The actions are applied in the given order. If price selection query parameters are provided, the selected prices will be added to the response.
    /// </summary>
    /// <param name="product">Product</param>
    /// <param name="action">The update action to apply to the product.</param>
    /// <param name="priceCurrency">The currency code compliant to ISO 4217. Enables price selection.</param>
    /// <param name="priceCountry">A two-digit country code as per ISO 3166-1 alpha-2. Enables price selection. Can only be used in conjunction with the priceCurrency parameter.</param>
    /// <param name="priceCustomerGroup">Enables price selection. Can only be used in conjunction with the priceCurrency parameter.</param>
    /// <param name="priceChannel">Enables price selection. Can only be used in conjunction with the priceCurrency parameter.</param>
    /// <returns>Product</returns>
    /// <see href="http://dev.commercetools.com/http-api-projects-products.html#update-product"/>
    public IEnumerator UpdateProductAsync(Product product, UpdateAction action, Action<Response<Product>> onSuccess, Action<Response<Product>> onError, string priceCurrency = null, string priceCountry = null, Guid priceCustomerGroup = new Guid(), Guid priceChannel = new Guid())
    {
      return UpdateProductByIdAsync(product.Id, product.Version, new List<UpdateAction> { action }, onSuccess, onError, priceCurrency, priceCountry, priceCustomerGroup, priceChannel);
    }

    /// <summary>
    /// (Partial) updates are made to an existing product by sending a list of actions to be applied. The actions are applied in the given order. If price selection query parameters are provided, the selected prices will be added to the response.
    /// </summary>
    /// <param name="product">Product</param>
    /// <param name="actions">The list of update actions to apply to the product.</param>
    /// <param name="priceCurrency">The currency code compliant to ISO 4217. Enables price selection.</param>
    /// <param name="priceCountry">A two-digit country code as per ISO 3166-1 alpha-2. Enables price selection. Can only be used in conjunction with the priceCurrency parameter.</param>
    /// <param name="priceCustomerGroup">Enables price selection. Can only be used in conjunction with the priceCurrency parameter.</param>
    /// <param name="priceChannel">Enables price selection. Can only be used in conjunction with the priceCurrency parameter.</param>
    /// <returns>Product</returns>
    /// <see href="http://dev.commercetools.com/http-api-projects-products.html#update-product"/>
    public IEnumerator UpdateProductAsync(Product product, List<UpdateAction> actions, Action<Response<Product>> onSuccess, Action<Response<Product>> onError, string priceCurrency = null, string priceCountry = null, Guid priceCustomerGroup = new Guid(), Guid priceChannel = new Guid())
    {
      return UpdateProductByIdAsync(product.Id, product.Version, actions, onSuccess, onError, priceCurrency, priceCountry, priceCustomerGroup, priceChannel);
    }

    /// <summary>
    /// (Partial) updates are made to an existing product by sending a list of actions to be applied. The actions are applied in the given order. If price selection query parameters are provided, the selected prices will be added to the response.
    /// </summary>
    /// <param name="productId">ID of the product</param>
    /// <param name="version">The expected version of the product on which the changes should be applied.</param>
    /// <param name="actions">The list of update actions to apply to the product.</param>
    /// <param name="priceCurrency">The currency code compliant to ISO 4217. Enables price selection.</param>
    /// <param name="priceCountry">A two-digit country code as per ISO 3166-1 alpha-2. Enables price selection. Can only be used in conjunction with the priceCurrency parameter.</param>
    /// <param name="priceCustomerGroup">Enables price selection. Can only be used in conjunction with the priceCurrency parameter.</param>
    /// <param name="priceChannel">Enables price selection. Can only be used in conjunction with the priceCurrency parameter.</param>
    /// <returns>Product</returns>
    /// <see href="http://dev.commercetools.com/http-api-projects-products.html#update-product"/>
    public IEnumerator UpdateProductByIdAsync(string productId, int version, List<UpdateAction> actions, Action<Response<Product>> onSuccess, Action<Response<Product>> onError, string priceCurrency = null, string priceCountry = null, Guid priceCustomerGroup = new Guid(), Guid priceChannel = new Guid())
    {
      if (string.IsNullOrWhiteSpace(productId))
      {
        throw new ArgumentException("Product ID is required");
      }

      string endpoint = string.Concat(ENDPOINT_PREFIX, "/", productId);
      return UpdateProductAsync(endpoint, version, actions, onSuccess, onError, priceCurrency, priceCountry, priceCustomerGroup, priceChannel);
    }

    /// <summary>
    /// Update a product found by its Key.
    /// </summary>
    /// <param name="key">Product key</param>
    /// <param name="version">The expected version of the product on which the changes should be applied.</param>
    /// <param name="actions">The list of update actions to apply to the product.</param>
    /// <param name="priceCurrency">The currency code compliant to ISO 4217. Enables price selection.</param>
    /// <param name="priceCountry">A two-digit country code as per ISO 3166-1 alpha-2. Enables price selection. Can only be used in conjunction with the priceCurrency parameter.</param>
    /// <param name="priceCustomerGroup">Enables price selection. Can only be used in conjunction with the priceCurrency parameter.</param>
    /// <param name="priceChannel">Enables price selection. Can only be used in conjunction with the priceCurrency parameter.</param>
    /// <returns>Product</returns>
    /// <see href="http://dev.commercetools.com/http-api-projects-products.html#update-product"/>
    public IEnumerator UpdateProductByKeyAsync(string key, int version, List<UpdateAction> actions, Action<Response<Product>> onSuccess, Action<Response<Product>> onError, string priceCurrency = null, string priceCountry = null, Guid priceCustomerGroup = new Guid(), Guid priceChannel = new Guid())
    {
      if (string.IsNullOrWhiteSpace(key))
      {
        throw new ArgumentException("Product key is required");
      }

      string endpoint = string.Concat(ENDPOINT_PREFIX, "/key=", key);
      return UpdateProductAsync(endpoint, version, actions, onSuccess, onError, priceCurrency, priceCountry, priceCustomerGroup, priceChannel);
    }

    /// <summary>
    /// Private worker method for UpdateProductByIdAsync and UpdateProductByKeyAsync.
    /// </summary>
    /// <param name="endpoint">Request endpoint</param>
    /// <param name="version">The expected version of the product on which the changes should be applied.</param>
    /// <param name="actions">The list of update actions to apply to the product.</param>
    /// <param name="priceCurrency">The currency code compliant to ISO 4217. Enables price selection.</param>
    /// <param name="priceCountry">A two-digit country code as per ISO 3166-1 alpha-2. Enables price selection. Can only be used in conjunction with the priceCurrency parameter.</param>
    /// <param name="priceCustomerGroup">Enables price selection. Can only be used in conjunction with the priceCurrency parameter.</param>
    /// <param name="priceChannel">Enables price selection. Can only be used in conjunction with the priceCurrency parameter.</param>
    /// <returns>Product</returns>
    /// <see href="http://dev.commercetools.com/http-api-projects-products.html#update-product"/>
    private IEnumerator UpdateProductAsync(string endpoint, int version, List<UpdateAction> actions, Action<Response<Product>> onSuccess, Action<Response<Product>> onError, string priceCurrency = null, string priceCountry = null, Guid priceCustomerGroup = new Guid(), Guid priceChannel = new Guid())
    {
      if (version < 1)
      {
        throw new ArgumentException("Version is required");
      }

      if (actions == null || actions.Count < 1)
      {
        throw new ArgumentException("One or more update actions is required");
      }

      JObject data = JObject.FromObject(new
      {
        version = version,
        actions = JArray.FromObject(actions, new JsonSerializer { NullValueHandling = NullValueHandling.Ignore })
      });

      if (!string.IsNullOrWhiteSpace(priceCurrency))
      {
        data.Add(new JProperty("priceCurrency", priceCurrency));

        if (!string.IsNullOrWhiteSpace(priceCountry))
        {
          data.Add(new JProperty("priceCountry", priceCountry));
        }

        if (priceCustomerGroup != Guid.Empty)
        {
          data.Add(new JProperty("priceCustomerGroup", priceCustomerGroup));
        }

        if (priceChannel != Guid.Empty)
        {
          data.Add(new JProperty("priceChannel", priceChannel));
        }
      }

      return _client.PostAsync<Product>(endpoint, data.ToString(), onSuccess, onError);
    }

    /// <summary>
    /// Deletes a Product.
    /// </summary>
    /// <param name="product">Product</param>
    /// <returns>Product</returns>
    /// <see href="http://dev.commercetools.com/http-api-projects-products.html#delete-product"/>
    public IEnumerator DeleteProductAsync(Product product, Action<Response<Product>> onSuccess, Action<Response<Product>> onError)
    {
      return DeleteProductAsync(product.Id, product.Version, onSuccess, onError);
    }

    /// <summary>
    /// Deletes a Product.
    /// </summary>
    /// <param name="productId">Product ID</param>
    /// <param name="version">Product version</param>
    /// <returns>Product</returns>
    /// <see href="http://dev.commercetools.com/http-api-projects-products.html#delete-product"/>
    public IEnumerator DeleteProductAsync(string productId, int version, Action<Response<Product>> onSuccess, Action<Response<Product>> onError)
    {
      if (string.IsNullOrWhiteSpace(productId))
      {
        throw new ArgumentException("Product ID is required");
      }

      if (version < 1)
      {
        throw new ArgumentException("Version is required");
      }

      var values = new NameValueCollection
            {
                { "version", version.ToString() }
            };

      string endpoint = string.Concat(ENDPOINT_PREFIX, "/", productId);
      return _client.DeleteAsync<Product>(endpoint, onSuccess, onError, values);
    }

    #endregion
  }
}
