/* 
 * Catalog
 *
 * Manage products, brands and categories. To learn more about catalog resources see [Catalog Overview](https://developer.bigcommerce.com/api-docs/catalog/products-overview).  - [Authentication](#authentication) - [Differentiating Variants & Modifiers](#variants-and-modifiers) - [Available Endpoints](#available-endpoints) - [Resources](#resources)  ## Authentication Requests can be authenticated by sending an `access_token` via `X-Auth-Token` HTTP header:  ```http GET /stores/{$$.env.store_hash}/v3/catalog/summary host: api.bigcommerce.com Accept: application/json X-Auth-Token: {access_token} ```  |Header|Parameter|Description| |-|-|-| |`X-Auth-Token`|`access_token `|Obtained by creating an API account or installing an app in a BigCommerce control panel.|  ### OAuth Scopes | UI Name  | Permission | Parameter                     | |- -- -- -- -- -|- -- -- -- -- -- -|- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --| | Products | modify     | `store_v2_products`           | | Products | read-only  | `store_v2_products_read_only` |  For more information on OAuth Scopes, see: [Authentication](https://developer.bigcommerce.com/api-docs/getting-started/authentication).  For more information on Authenticating BigCommerce APIs, see: [Authentication](https://developer.bigcommerce.com/api-docs/getting-started/authentication).  ## Differentiating Variants and Modifiers [Variants](https://support.bigcommerce.com/s/article/Product-Options-v3#variations) represent a physical product made up of [Product Option](https://support.bigcommerce.com/s/article/Product-Options-v3) choices, i.e. a large blue t-shirt. Each variant can have a unique SKU.  Modifiers represent a choice a customer makes about a product that doesn't represent a physical item, i.e. text to be printed on a t-shirt. Assigning a SKU to a modifier will turn it into a variant.  See [Variant Options](https://developer.bigcommerce.com/api-docs/catalog/products-overview#variant-options) and [Modifier Options](https://developer.bigcommerce.com/api-docs/catalog/products-overview#modifier-options) for more information.  ## Available Endpoints | Resource / Endpoint                     | Description                                                             | |- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --|- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --| | Brand Images                            | Create and manage brand images                                          | | Brand Metafields                        | Create and manage brand metafields                                      | | Brands                                  | Create and manage brands                                                | | Catalog                                 | Create and manage store categories, products, and brands                | | Categories                              | Create and manage categorties                                           | | Category Images                         | Create and manage category images                                       | | Category Metafields                     | Create and manage category metafields                                   | | Product Bulk Pricing Rules              | Create and manage product bulk pricing rules                            | | Product Complex Rules                   | Create and manage product complex rules                                 | | Product Custom Fields                   | Create and manage product custom fields                                 | | Product Images                          | Create and manage product images                                        | | Product Metafields                      | Create and manage product meta fields                                   | | Product Modifier Images                 | Create and manage product modifer images                                | | Product Modifier Values                 | Create and manage product modifier values                               | | Product Modifiers                       | Create and manage product midifiers                                     | | Product Reviews                         | Create and manage product reviews                                       | | Product Variant Option Values           | Create and manage product variant option values                         | | Product Variant Options                 | Create and manage product variant options                               | | Product Variants                        | Create and manage product variants                                      | | Product Videos                          | Create and manage product videos                                        | | Products                                | Create and manage products                                              | | ProductVariant Metafields               | Create and manage product meta flields                                  | | Variants                                | Get and update all variants                                             |  ## Resources  ### Webhooks * [Products](/api-docs/getting-started/webhooks/webhook-events#webhook-events_products) * [Categories](/api-docs/getting-started/webhooks/webhook-events#webhook-events_category) * [SKU](/api-docs/getting-started/webhooks/webhook-events#webhook-events_sku)  ### Related Endpoints * [Catalog API](/api-reference/catalog/catalog-api)
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using BigCommerce.Client;
using BigCommerce.Model;

namespace BigCommerce.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public interface IProductModifierImagesApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Create Modifier Image
        /// </summary>
        /// <remarks>
        /// Creates a *Modifier Image*.  The image will show on the storefront when the value is selected.   **Required Fields** - image_file: Form posts are the only accepted upload option.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="modifierId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <param name="valueId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <returns>ImageResponse</returns>
        ImageResponse CreateModifierImage (string accept, string contentType, int? productId, int? modifierId, int? valueId);

        /// <summary>
        /// Create Modifier Image
        /// </summary>
        /// <remarks>
        /// Creates a *Modifier Image*.  The image will show on the storefront when the value is selected.   **Required Fields** - image_file: Form posts are the only accepted upload option.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="modifierId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <param name="valueId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <returns>ApiResponse of ImageResponse</returns>
        ApiResponse<ImageResponse> CreateModifierImageWithHttpInfo (string accept, string contentType, int? productId, int? modifierId, int? valueId);
        /// <summary>
        /// Delete Modifier Image
        /// </summary>
        /// <remarks>
        /// Deletes a *Modifier Image*.  Deletes the image that was set to show when the modifier value is selected.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="modifierId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <param name="valueId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns></returns>
        void DeleteModifierImage (int? productId, int? modifierId, int? valueId, string accept, string contentType);

        /// <summary>
        /// Delete Modifier Image
        /// </summary>
        /// <remarks>
        /// Deletes a *Modifier Image*.  Deletes the image that was set to show when the modifier value is selected.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="modifierId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <param name="valueId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteModifierImageWithHttpInfo (int? productId, int? modifierId, int? valueId, string accept, string contentType);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Create Modifier Image
        /// </summary>
        /// <remarks>
        /// Creates a *Modifier Image*.  The image will show on the storefront when the value is selected.   **Required Fields** - image_file: Form posts are the only accepted upload option.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="modifierId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <param name="valueId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <returns>Task of ImageResponse</returns>
        System.Threading.Tasks.Task<ImageResponse> CreateModifierImageAsync (string accept, string contentType, int? productId, int? modifierId, int? valueId);

        /// <summary>
        /// Create Modifier Image
        /// </summary>
        /// <remarks>
        /// Creates a *Modifier Image*.  The image will show on the storefront when the value is selected.   **Required Fields** - image_file: Form posts are the only accepted upload option.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="modifierId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <param name="valueId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <returns>Task of ApiResponse (ImageResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ImageResponse>> CreateModifierImageAsyncWithHttpInfo (string accept, string contentType, int? productId, int? modifierId, int? valueId);
        /// <summary>
        /// Delete Modifier Image
        /// </summary>
        /// <remarks>
        /// Deletes a *Modifier Image*.  Deletes the image that was set to show when the modifier value is selected.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="modifierId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <param name="valueId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteModifierImageAsync (int? productId, int? modifierId, int? valueId, string accept, string contentType);

        /// <summary>
        /// Delete Modifier Image
        /// </summary>
        /// <remarks>
        /// Deletes a *Modifier Image*.  Deletes the image that was set to show when the modifier value is selected.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="modifierId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <param name="valueId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteModifierImageAsyncWithHttpInfo (int? productId, int? modifierId, int? valueId, string accept, string contentType);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public partial class ProductModifierImagesApi : IProductModifierImagesApi
    {
        private BigCommerce.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductModifierImagesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ProductModifierImagesApi(String basePath)
        {
            this.Configuration = new BigCommerce.Client.Configuration { BasePath = basePath };

            ExceptionFactory = BigCommerce.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductModifierImagesApi"/> class
        /// </summary>
        /// <returns></returns>
        public ProductModifierImagesApi()
        {
            this.Configuration = BigCommerce.Client.Configuration.Default;

            ExceptionFactory = BigCommerce.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductModifierImagesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ProductModifierImagesApi(BigCommerce.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = BigCommerce.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = BigCommerce.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public BigCommerce.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public BigCommerce.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Create Modifier Image Creates a *Modifier Image*.  The image will show on the storefront when the value is selected.   **Required Fields** - image_file: Form posts are the only accepted upload option.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="modifierId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <param name="valueId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <returns>ImageResponse</returns>
        public ImageResponse CreateModifierImage (string accept, string contentType, int? productId, int? modifierId, int? valueId)
        {
             ApiResponse<ImageResponse> localVarResponse = CreateModifierImageWithHttpInfo(accept, contentType, productId, modifierId, valueId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create Modifier Image Creates a *Modifier Image*.  The image will show on the storefront when the value is selected.   **Required Fields** - image_file: Form posts are the only accepted upload option.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="modifierId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <param name="valueId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <returns>ApiResponse of ImageResponse</returns>
        public ApiResponse< ImageResponse > CreateModifierImageWithHttpInfo (string accept, string contentType, int? productId, int? modifierId, int? valueId)
        {
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductModifierImagesApi->CreateModifierImage");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductModifierImagesApi->CreateModifierImage");
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductModifierImagesApi->CreateModifierImage");
            // verify the required parameter 'modifierId' is set
            if (modifierId == null)
                throw new ApiException(400, "Missing required parameter 'modifierId' when calling ProductModifierImagesApi->CreateModifierImage");
            // verify the required parameter 'valueId' is set
            if (valueId == null)
                throw new ApiException(400, "Missing required parameter 'valueId' when calling ProductModifierImagesApi->CreateModifierImage");

            var localVarPath = "/catalog/products/{product_id}/modifiers/{modifier_id}/values/{value_id}/image";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "multipart/form-data"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (productId != null) localVarPathParams.Add("product_id", this.Configuration.ApiClient.ParameterToString(productId)); // path parameter
            if (modifierId != null) localVarPathParams.Add("modifier_id", this.Configuration.ApiClient.ParameterToString(modifierId)); // path parameter
            if (valueId != null) localVarPathParams.Add("value_id", this.Configuration.ApiClient.ParameterToString(valueId)); // path parameter
            if (accept != null) localVarHeaderParams.Add("Accept", this.Configuration.ApiClient.ParameterToString(accept)); // header parameter
            if (contentType != null) localVarHeaderParams.Add("Content-Type", this.Configuration.ApiClient.ParameterToString(contentType)); // header parameter
            if (imageFile != null) localVarFileParams.Add("image_file", this.Configuration.ApiClient.ParameterToFile("image_file", imageFile));
            // authentication (X-Auth-Token) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-Auth-Token")))
            {
                localVarHeaderParams["X-Auth-Token"] = this.Configuration.GetApiKeyWithPrefix("X-Auth-Token");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateModifierImage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ImageResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ImageResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ImageResponse)));
        }

        /// <summary>
        /// Create Modifier Image Creates a *Modifier Image*.  The image will show on the storefront when the value is selected.   **Required Fields** - image_file: Form posts are the only accepted upload option.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="modifierId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <param name="valueId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <returns>Task of ImageResponse</returns>
        public async System.Threading.Tasks.Task<ImageResponse> CreateModifierImageAsync (string accept, string contentType, int? productId, int? modifierId, int? valueId)
        {
             ApiResponse<ImageResponse> localVarResponse = await CreateModifierImageAsyncWithHttpInfo(accept, contentType, productId, modifierId, valueId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create Modifier Image Creates a *Modifier Image*.  The image will show on the storefront when the value is selected.   **Required Fields** - image_file: Form posts are the only accepted upload option.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="modifierId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <param name="valueId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <returns>Task of ApiResponse (ImageResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ImageResponse>> CreateModifierImageAsyncWithHttpInfo (string accept, string contentType, int? productId, int? modifierId, int? valueId)
        {
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductModifierImagesApi->CreateModifierImage");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductModifierImagesApi->CreateModifierImage");
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductModifierImagesApi->CreateModifierImage");
            // verify the required parameter 'modifierId' is set
            if (modifierId == null)
                throw new ApiException(400, "Missing required parameter 'modifierId' when calling ProductModifierImagesApi->CreateModifierImage");
            // verify the required parameter 'valueId' is set
            if (valueId == null)
                throw new ApiException(400, "Missing required parameter 'valueId' when calling ProductModifierImagesApi->CreateModifierImage");

            var localVarPath = "/catalog/products/{product_id}/modifiers/{modifier_id}/values/{value_id}/image";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "multipart/form-data"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (productId != null) localVarPathParams.Add("product_id", this.Configuration.ApiClient.ParameterToString(productId)); // path parameter
            if (modifierId != null) localVarPathParams.Add("modifier_id", this.Configuration.ApiClient.ParameterToString(modifierId)); // path parameter
            if (valueId != null) localVarPathParams.Add("value_id", this.Configuration.ApiClient.ParameterToString(valueId)); // path parameter
            if (accept != null) localVarHeaderParams.Add("Accept", this.Configuration.ApiClient.ParameterToString(accept)); // header parameter
            if (contentType != null) localVarHeaderParams.Add("Content-Type", this.Configuration.ApiClient.ParameterToString(contentType)); // header parameter
            if (imageFile != null) localVarFileParams.Add("image_file", this.Configuration.ApiClient.ParameterToFile("image_file", imageFile));
            // authentication (X-Auth-Token) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-Auth-Token")))
            {
                localVarHeaderParams["X-Auth-Token"] = this.Configuration.GetApiKeyWithPrefix("X-Auth-Token");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateModifierImage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ImageResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ImageResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ImageResponse)));
        }

        /// <summary>
        /// Delete Modifier Image Deletes a *Modifier Image*.  Deletes the image that was set to show when the modifier value is selected.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="modifierId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <param name="valueId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns></returns>
        public void DeleteModifierImage (int? productId, int? modifierId, int? valueId, string accept, string contentType)
        {
             DeleteModifierImageWithHttpInfo(productId, modifierId, valueId, accept, contentType);
        }

        /// <summary>
        /// Delete Modifier Image Deletes a *Modifier Image*.  Deletes the image that was set to show when the modifier value is selected.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="modifierId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <param name="valueId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteModifierImageWithHttpInfo (int? productId, int? modifierId, int? valueId, string accept, string contentType)
        {
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductModifierImagesApi->DeleteModifierImage");
            // verify the required parameter 'modifierId' is set
            if (modifierId == null)
                throw new ApiException(400, "Missing required parameter 'modifierId' when calling ProductModifierImagesApi->DeleteModifierImage");
            // verify the required parameter 'valueId' is set
            if (valueId == null)
                throw new ApiException(400, "Missing required parameter 'valueId' when calling ProductModifierImagesApi->DeleteModifierImage");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductModifierImagesApi->DeleteModifierImage");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductModifierImagesApi->DeleteModifierImage");

            var localVarPath = "/catalog/products/{product_id}/modifiers/{modifier_id}/values/{value_id}/image";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (productId != null) localVarPathParams.Add("product_id", this.Configuration.ApiClient.ParameterToString(productId)); // path parameter
            if (modifierId != null) localVarPathParams.Add("modifier_id", this.Configuration.ApiClient.ParameterToString(modifierId)); // path parameter
            if (valueId != null) localVarPathParams.Add("value_id", this.Configuration.ApiClient.ParameterToString(valueId)); // path parameter
            if (accept != null) localVarHeaderParams.Add("Accept", this.Configuration.ApiClient.ParameterToString(accept)); // header parameter
            if (contentType != null) localVarHeaderParams.Add("Content-Type", this.Configuration.ApiClient.ParameterToString(contentType)); // header parameter
            // authentication (X-Auth-Token) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-Auth-Token")))
            {
                localVarHeaderParams["X-Auth-Token"] = this.Configuration.GetApiKeyWithPrefix("X-Auth-Token");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteModifierImage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Delete Modifier Image Deletes a *Modifier Image*.  Deletes the image that was set to show when the modifier value is selected.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="modifierId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <param name="valueId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteModifierImageAsync (int? productId, int? modifierId, int? valueId, string accept, string contentType)
        {
             await DeleteModifierImageAsyncWithHttpInfo(productId, modifierId, valueId, accept, contentType);

        }

        /// <summary>
        /// Delete Modifier Image Deletes a *Modifier Image*.  Deletes the image that was set to show when the modifier value is selected.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="modifierId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <param name="valueId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteModifierImageAsyncWithHttpInfo (int? productId, int? modifierId, int? valueId, string accept, string contentType)
        {
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductModifierImagesApi->DeleteModifierImage");
            // verify the required parameter 'modifierId' is set
            if (modifierId == null)
                throw new ApiException(400, "Missing required parameter 'modifierId' when calling ProductModifierImagesApi->DeleteModifierImage");
            // verify the required parameter 'valueId' is set
            if (valueId == null)
                throw new ApiException(400, "Missing required parameter 'valueId' when calling ProductModifierImagesApi->DeleteModifierImage");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductModifierImagesApi->DeleteModifierImage");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductModifierImagesApi->DeleteModifierImage");

            var localVarPath = "/catalog/products/{product_id}/modifiers/{modifier_id}/values/{value_id}/image";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (productId != null) localVarPathParams.Add("product_id", this.Configuration.ApiClient.ParameterToString(productId)); // path parameter
            if (modifierId != null) localVarPathParams.Add("modifier_id", this.Configuration.ApiClient.ParameterToString(modifierId)); // path parameter
            if (valueId != null) localVarPathParams.Add("value_id", this.Configuration.ApiClient.ParameterToString(valueId)); // path parameter
            if (accept != null) localVarHeaderParams.Add("Accept", this.Configuration.ApiClient.ParameterToString(accept)); // header parameter
            if (contentType != null) localVarHeaderParams.Add("Content-Type", this.Configuration.ApiClient.ParameterToString(contentType)); // header parameter
            // authentication (X-Auth-Token) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-Auth-Token")))
            {
                localVarHeaderParams["X-Auth-Token"] = this.Configuration.GetApiKeyWithPrefix("X-Auth-Token");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteModifierImage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

    }
}
