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
using Catalog.Client;
using Catalog.Model;

namespace Catalog.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public interface IProductsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Create a Product
        /// </summary>
        /// <remarks>
        /// Creates a *Product*. Only one product can be created at a time.  **Required Fields:** - &#x60;name&#x60; - &#x60;type&#x60; - &#x60;weight&#x60; - &#x60;price&#x60;  **Read-Only Fields** - &#x60;id&#x60; - &#x60;date_created&#x60; - &#x60;date_modified&#x60; - &#x60;calculated_price&#x60; - &#x60;base_variant_id&#x60;  **Usage Notes** * &#x60;POST&#x60; requests to &#x60;/products&#x60; accepts a single &#x60;video&#x60; object; to send an array of video objects, see: &#x60;/products/{product_id}/videos&#x60;.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="contentType"></param>
        /// <param name="accept"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <returns>ProductResponse</returns>
        ProductResponse CreateProduct (ProductPost1 body, string contentType, string accept, string includeFields = null);

        /// <summary>
        /// Create a Product
        /// </summary>
        /// <remarks>
        /// Creates a *Product*. Only one product can be created at a time.  **Required Fields:** - &#x60;name&#x60; - &#x60;type&#x60; - &#x60;weight&#x60; - &#x60;price&#x60;  **Read-Only Fields** - &#x60;id&#x60; - &#x60;date_created&#x60; - &#x60;date_modified&#x60; - &#x60;calculated_price&#x60; - &#x60;base_variant_id&#x60;  **Usage Notes** * &#x60;POST&#x60; requests to &#x60;/products&#x60; accepts a single &#x60;video&#x60; object; to send an array of video objects, see: &#x60;/products/{product_id}/videos&#x60;.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="contentType"></param>
        /// <param name="accept"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <returns>ApiResponse of ProductResponse</returns>
        ApiResponse<ProductResponse> CreateProductWithHttpInfo (ProductPost1 body, string contentType, string accept, string includeFields = null);
        /// <summary>
        /// Delete a Product
        /// </summary>
        /// <remarks>
        /// Deletes a *Product*.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns></returns>
        void DeleteProductById (int? productId, string accept, string contentType);

        /// <summary>
        /// Delete a Product
        /// </summary>
        /// <remarks>
        /// Deletes a *Product*.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteProductByIdWithHttpInfo (int? productId, string accept, string contentType);
        /// <summary>
        /// Delete Products
        /// </summary>
        /// <remarks>
        /// To delete *Product* objects, you must include a filter. This prevents inadvertently deleting all *Product* objects in a store.  **Example**: To delete products with the id&#x27;s of 1,2 and 3, use &#x60;DELETE /v3/catalog/products?id:in&#x3D;1,2,3&#x60;.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="name">Filter items by name.  (optional)</param>
        /// <param name="sku">Filter items by sku.  (optional)</param>
        /// <param name="price">Filter items by price.  (optional)</param>
        /// <param name="weight">Filter items by weight.  (optional)</param>
        /// <param name="condition">Filter items by condition.  (optional)</param>
        /// <param name="brandId">Filter items by brand_id.  (optional)</param>
        /// <param name="dateModified">Filter items by date_modified. For example &#x60;v3/catalog/products?date_modified:min&#x3D;2018-06-15&#x60; (optional)</param>
        /// <param name="dateLastImported">Filter items by date_last_imported. For example &#x60;v3/catalog/products?date_last_imported:min&#x3D;2018-06-15&#x60; (optional)</param>
        /// <param name="isVisible">Filter items by if visible on the storefront.  (optional)</param>
        /// <param name="isFeatured">Filter items by is_featured.  (optional)</param>
        /// <param name="inventoryLevel">Filter items by inventory_level.  (optional)</param>
        /// <param name="totalSold">Filter items by total_sold.  (optional)</param>
        /// <param name="type">Filter items by type: &#x60;physical&#x60; or &#x60;digital&#x60;. (optional)</param>
        /// <param name="categories">Filter items by categories.  If a product is in more than one category, using this query will not return the product. Instead use &#x60;categories:in&#x3D;12&#x60;. (optional)</param>
        /// <param name="keyword">Filter items by keywords found in the &#x60;name&#x60;, &#x60;description&#x60;, or &#x60;sku&#x60; fields, or in the brand name.  (optional)</param>
        /// <returns></returns>
        void DeleteProducts (string accept, string contentType, string name = null, string sku = null, decimal? price = null, decimal? weight = null, string condition = null, int? brandId = null, DateTime? dateModified = null, DateTime? dateLastImported = null, bool? isVisible = null, int? isFeatured = null, int? inventoryLevel = null, int? totalSold = null, string type = null, int? categories = null, string keyword = null);

        /// <summary>
        /// Delete Products
        /// </summary>
        /// <remarks>
        /// To delete *Product* objects, you must include a filter. This prevents inadvertently deleting all *Product* objects in a store.  **Example**: To delete products with the id&#x27;s of 1,2 and 3, use &#x60;DELETE /v3/catalog/products?id:in&#x3D;1,2,3&#x60;.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="name">Filter items by name.  (optional)</param>
        /// <param name="sku">Filter items by sku.  (optional)</param>
        /// <param name="price">Filter items by price.  (optional)</param>
        /// <param name="weight">Filter items by weight.  (optional)</param>
        /// <param name="condition">Filter items by condition.  (optional)</param>
        /// <param name="brandId">Filter items by brand_id.  (optional)</param>
        /// <param name="dateModified">Filter items by date_modified. For example &#x60;v3/catalog/products?date_modified:min&#x3D;2018-06-15&#x60; (optional)</param>
        /// <param name="dateLastImported">Filter items by date_last_imported. For example &#x60;v3/catalog/products?date_last_imported:min&#x3D;2018-06-15&#x60; (optional)</param>
        /// <param name="isVisible">Filter items by if visible on the storefront.  (optional)</param>
        /// <param name="isFeatured">Filter items by is_featured.  (optional)</param>
        /// <param name="inventoryLevel">Filter items by inventory_level.  (optional)</param>
        /// <param name="totalSold">Filter items by total_sold.  (optional)</param>
        /// <param name="type">Filter items by type: &#x60;physical&#x60; or &#x60;digital&#x60;. (optional)</param>
        /// <param name="categories">Filter items by categories.  If a product is in more than one category, using this query will not return the product. Instead use &#x60;categories:in&#x3D;12&#x60;. (optional)</param>
        /// <param name="keyword">Filter items by keywords found in the &#x60;name&#x60;, &#x60;description&#x60;, or &#x60;sku&#x60; fields, or in the brand name.  (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteProductsWithHttpInfo (string accept, string contentType, string name = null, string sku = null, decimal? price = null, decimal? weight = null, string condition = null, int? brandId = null, DateTime? dateModified = null, DateTime? dateLastImported = null, bool? isVisible = null, int? isFeatured = null, int? inventoryLevel = null, int? totalSold = null, string type = null, int? categories = null, string keyword = null);
        /// <summary>
        /// Get a Product
        /// </summary>
        /// <remarks>
        /// Returns a single *Product*. Optional parameters can be passed in.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="include">Sub-resources to include on a product, in a comma-separated list. If &#x60;options&#x60; or &#x60;modifiers&#x60; is used, results are limited to 10 per page. (optional)</param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>ProductResponse</returns>
        ProductResponse GetProductById (int? productId, string accept, string contentType, string include = null, string includeFields = null, string excludeFields = null);

        /// <summary>
        /// Get a Product
        /// </summary>
        /// <remarks>
        /// Returns a single *Product*. Optional parameters can be passed in.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="include">Sub-resources to include on a product, in a comma-separated list. If &#x60;options&#x60; or &#x60;modifiers&#x60; is used, results are limited to 10 per page. (optional)</param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>ApiResponse of ProductResponse</returns>
        ApiResponse<ProductResponse> GetProductByIdWithHttpInfo (int? productId, string accept, string contentType, string include = null, string includeFields = null, string excludeFields = null);
        /// <summary>
        /// Get All Products
        /// </summary>
        /// <remarks>
        /// Returns a list of **Products**. Optional filter parameters can be passed in.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Filter items by id.  (optional)</param>
        /// <param name="idin"> (optional)</param>
        /// <param name="idnotIn"> (optional)</param>
        /// <param name="idmin"> (optional)</param>
        /// <param name="idmax"> (optional)</param>
        /// <param name="idgreater"> (optional)</param>
        /// <param name="idless"> (optional)</param>
        /// <param name="name">Filter items by name.  (optional)</param>
        /// <param name="sku">Filter items by sku.  (optional)</param>
        /// <param name="upc">Filter items by upc.  (optional)</param>
        /// <param name="price">Filter items by price.  (optional)</param>
        /// <param name="weight">Filter items by weight.  (optional)</param>
        /// <param name="condition">Filter items by condition.  (optional)</param>
        /// <param name="brandId">Filter items by brand_id.  (optional)</param>
        /// <param name="dateModified">Filter items by &#x60;date_modified&#x60;. For example, &#x60;/v3/catalog/products?date_modified:min&#x3D;2018-06-15&#x60; gets all products modified after &#x60;2018-06-15&#x60; (optional)</param>
        /// <param name="dateLastImported">Filter items by date_last_imported. For example &#x60;v3/catalog/products?date_last_imported:min&#x3D;2018-06-15&#x60; (optional)</param>
        /// <param name="isVisible">Filter items by if visible on the storefront.  (optional)</param>
        /// <param name="isFeatured">Filter items by is_featured. &#x60;0&#x60; for true, &#x60;1&#x60; for false.  (optional)</param>
        /// <param name="isFreeShipping">Filter items by is_free_shipping.  (optional)</param>
        /// <param name="inventoryLevel">Filter items by inventory_level.  (optional)</param>
        /// <param name="inventoryLow">Filter items by inventory_low. Values: 1, 0.  (optional)</param>
        /// <param name="outOfStock">Filter items by out_of_stock. To enable the filter, pass &#x60;out_of_stock&#x60;&#x3D;&#x60;1&#x60;.  (optional)</param>
        /// <param name="totalSold">Filter items by total_sold.  (optional)</param>
        /// <param name="type">Filter items by type: &#x60;physical&#x60; or &#x60;digital&#x60;. (optional)</param>
        /// <param name="categories">Filter items by categories.  If a product is in more than one category, using this query will not return the product. Instead use &#x60;categories:in&#x3D;12&#x60;. (optional)</param>
        /// <param name="keyword">Filter items by keywords found in the &#x60;name&#x60;, &#x60;description&#x60;, or &#x60;sku&#x60; fields, or in the brand name.  (optional)</param>
        /// <param name="keywordContext">Set context used by the search algorithm to return results targeted towards the specified group. Use &#x60;merchant&#x60; to help merchants search their own catalog. Use &#x60;shopper&#x60; to return shopper-facing search results. (optional)</param>
        /// <param name="status">Filter items by status.  (optional)</param>
        /// <param name="include">Sub-resources to include on a product, in a comma-separated list. If &#x60;options&#x60; or &#x60;modifiers&#x60; is used, results are limited to 10 per page. (optional)</param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <param name="availability">Filter items by availability. Values are: available, disabled, preorder.  (optional)</param>
        /// <param name="priceListId">This filter returns the product pricing with the *Price List* pricing instead. To use: &#x60;?price_list_id&#x3D;1&#x60;. If there are variants use: &#x60;?price_list_id&#x3D;1&amp;include&#x3D;variants&#x60; (optional)</param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <param name="direction">Sort direction. Acceptable values are: &#x60;asc&#x60;, &#x60;desc&#x60;.  (optional)</param>
        /// <param name="sort">Field name to sort by. Note: Since &#x60;id&#x60; increments when new products are added, you can use that field to sort by product create date.  (optional)</param>
        /// <returns>InlineResponse2001</returns>
        InlineResponse2001 GetProducts (int? id = null, List<int?> idin = null, List<int?> idnotIn = null, List<int?> idmin = null, List<int?> idmax = null, List<int?> idgreater = null, List<int?> idless = null, string name = null, string sku = null, string upc = null, decimal? price = null, decimal? weight = null, string condition = null, int? brandId = null, DateTime? dateModified = null, DateTime? dateLastImported = null, bool? isVisible = null, int? isFeatured = null, int? isFreeShipping = null, int? inventoryLevel = null, int? inventoryLow = null, int? outOfStock = null, int? totalSold = null, string type = null, int? categories = null, string keyword = null, string keywordContext = null, int? status = null, string include = null, string includeFields = null, string excludeFields = null, string availability = null, int? priceListId = null, int? page = null, int? limit = null, string direction = null, string sort = null);

        /// <summary>
        /// Get All Products
        /// </summary>
        /// <remarks>
        /// Returns a list of **Products**. Optional filter parameters can be passed in.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Filter items by id.  (optional)</param>
        /// <param name="idin"> (optional)</param>
        /// <param name="idnotIn"> (optional)</param>
        /// <param name="idmin"> (optional)</param>
        /// <param name="idmax"> (optional)</param>
        /// <param name="idgreater"> (optional)</param>
        /// <param name="idless"> (optional)</param>
        /// <param name="name">Filter items by name.  (optional)</param>
        /// <param name="sku">Filter items by sku.  (optional)</param>
        /// <param name="upc">Filter items by upc.  (optional)</param>
        /// <param name="price">Filter items by price.  (optional)</param>
        /// <param name="weight">Filter items by weight.  (optional)</param>
        /// <param name="condition">Filter items by condition.  (optional)</param>
        /// <param name="brandId">Filter items by brand_id.  (optional)</param>
        /// <param name="dateModified">Filter items by &#x60;date_modified&#x60;. For example, &#x60;/v3/catalog/products?date_modified:min&#x3D;2018-06-15&#x60; gets all products modified after &#x60;2018-06-15&#x60; (optional)</param>
        /// <param name="dateLastImported">Filter items by date_last_imported. For example &#x60;v3/catalog/products?date_last_imported:min&#x3D;2018-06-15&#x60; (optional)</param>
        /// <param name="isVisible">Filter items by if visible on the storefront.  (optional)</param>
        /// <param name="isFeatured">Filter items by is_featured. &#x60;0&#x60; for true, &#x60;1&#x60; for false.  (optional)</param>
        /// <param name="isFreeShipping">Filter items by is_free_shipping.  (optional)</param>
        /// <param name="inventoryLevel">Filter items by inventory_level.  (optional)</param>
        /// <param name="inventoryLow">Filter items by inventory_low. Values: 1, 0.  (optional)</param>
        /// <param name="outOfStock">Filter items by out_of_stock. To enable the filter, pass &#x60;out_of_stock&#x60;&#x3D;&#x60;1&#x60;.  (optional)</param>
        /// <param name="totalSold">Filter items by total_sold.  (optional)</param>
        /// <param name="type">Filter items by type: &#x60;physical&#x60; or &#x60;digital&#x60;. (optional)</param>
        /// <param name="categories">Filter items by categories.  If a product is in more than one category, using this query will not return the product. Instead use &#x60;categories:in&#x3D;12&#x60;. (optional)</param>
        /// <param name="keyword">Filter items by keywords found in the &#x60;name&#x60;, &#x60;description&#x60;, or &#x60;sku&#x60; fields, or in the brand name.  (optional)</param>
        /// <param name="keywordContext">Set context used by the search algorithm to return results targeted towards the specified group. Use &#x60;merchant&#x60; to help merchants search their own catalog. Use &#x60;shopper&#x60; to return shopper-facing search results. (optional)</param>
        /// <param name="status">Filter items by status.  (optional)</param>
        /// <param name="include">Sub-resources to include on a product, in a comma-separated list. If &#x60;options&#x60; or &#x60;modifiers&#x60; is used, results are limited to 10 per page. (optional)</param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <param name="availability">Filter items by availability. Values are: available, disabled, preorder.  (optional)</param>
        /// <param name="priceListId">This filter returns the product pricing with the *Price List* pricing instead. To use: &#x60;?price_list_id&#x3D;1&#x60;. If there are variants use: &#x60;?price_list_id&#x3D;1&amp;include&#x3D;variants&#x60; (optional)</param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <param name="direction">Sort direction. Acceptable values are: &#x60;asc&#x60;, &#x60;desc&#x60;.  (optional)</param>
        /// <param name="sort">Field name to sort by. Note: Since &#x60;id&#x60; increments when new products are added, you can use that field to sort by product create date.  (optional)</param>
        /// <returns>ApiResponse of InlineResponse2001</returns>
        ApiResponse<InlineResponse2001> GetProductsWithHttpInfo (int? id = null, List<int?> idin = null, List<int?> idnotIn = null, List<int?> idmin = null, List<int?> idmax = null, List<int?> idgreater = null, List<int?> idless = null, string name = null, string sku = null, string upc = null, decimal? price = null, decimal? weight = null, string condition = null, int? brandId = null, DateTime? dateModified = null, DateTime? dateLastImported = null, bool? isVisible = null, int? isFeatured = null, int? isFreeShipping = null, int? inventoryLevel = null, int? inventoryLow = null, int? outOfStock = null, int? totalSold = null, string type = null, int? categories = null, string keyword = null, string keywordContext = null, int? status = null, string include = null, string includeFields = null, string excludeFields = null, string availability = null, int? priceListId = null, int? page = null, int? limit = null, string direction = null, string sort = null);
        /// <summary>
        /// Update a Product
        /// </summary>
        /// <remarks>
        /// Updates a *Product*.  **Read-Only Fields** - id - date_created - date_modified - calculated_price - base_variant_id 
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <returns>ProductResponse</returns>
        ProductResponse UpdateProduct (ProductPut1 body, string accept, string contentType, int? productId, string includeFields = null);

        /// <summary>
        /// Update a Product
        /// </summary>
        /// <remarks>
        /// Updates a *Product*.  **Read-Only Fields** - id - date_created - date_modified - calculated_price - base_variant_id 
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <returns>ApiResponse of ProductResponse</returns>
        ApiResponse<ProductResponse> UpdateProductWithHttpInfo (ProductPut1 body, string accept, string contentType, int? productId, string includeFields = null);
        /// <summary>
        /// Update Products (Batch)
        /// </summary>
        /// <remarks>
        /// Updates products in batches. At the time of writing, batches are limited to 10 products.  **Required Fields** * &#x60;id&#x60; - product &#x60;id&#x60; is required for batch updates to products.  **Read-Only Fields** - &#x60;id&#x60; - &#x60;date_created&#x60; - &#x60;date_modified&#x60; - &#x60;calculated_price&#x60; - &#x60;base_variant_id&#x60;
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="body"> (optional)</param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <returns>InlineResponse2001</returns>
        InlineResponse2001 UpdateProducts (string accept, string contentType, List<Object> body = null, string includeFields = null);

        /// <summary>
        /// Update Products (Batch)
        /// </summary>
        /// <remarks>
        /// Updates products in batches. At the time of writing, batches are limited to 10 products.  **Required Fields** * &#x60;id&#x60; - product &#x60;id&#x60; is required for batch updates to products.  **Read-Only Fields** - &#x60;id&#x60; - &#x60;date_created&#x60; - &#x60;date_modified&#x60; - &#x60;calculated_price&#x60; - &#x60;base_variant_id&#x60;
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="body"> (optional)</param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <returns>ApiResponse of InlineResponse2001</returns>
        ApiResponse<InlineResponse2001> UpdateProductsWithHttpInfo (string accept, string contentType, List<Object> body = null, string includeFields = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Create a Product
        /// </summary>
        /// <remarks>
        /// Creates a *Product*. Only one product can be created at a time.  **Required Fields:** - &#x60;name&#x60; - &#x60;type&#x60; - &#x60;weight&#x60; - &#x60;price&#x60;  **Read-Only Fields** - &#x60;id&#x60; - &#x60;date_created&#x60; - &#x60;date_modified&#x60; - &#x60;calculated_price&#x60; - &#x60;base_variant_id&#x60;  **Usage Notes** * &#x60;POST&#x60; requests to &#x60;/products&#x60; accepts a single &#x60;video&#x60; object; to send an array of video objects, see: &#x60;/products/{product_id}/videos&#x60;.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="contentType"></param>
        /// <param name="accept"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <returns>Task of ProductResponse</returns>
        System.Threading.Tasks.Task<ProductResponse> CreateProductAsync (ProductPost1 body, string contentType, string accept, string includeFields = null);

        /// <summary>
        /// Create a Product
        /// </summary>
        /// <remarks>
        /// Creates a *Product*. Only one product can be created at a time.  **Required Fields:** - &#x60;name&#x60; - &#x60;type&#x60; - &#x60;weight&#x60; - &#x60;price&#x60;  **Read-Only Fields** - &#x60;id&#x60; - &#x60;date_created&#x60; - &#x60;date_modified&#x60; - &#x60;calculated_price&#x60; - &#x60;base_variant_id&#x60;  **Usage Notes** * &#x60;POST&#x60; requests to &#x60;/products&#x60; accepts a single &#x60;video&#x60; object; to send an array of video objects, see: &#x60;/products/{product_id}/videos&#x60;.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="contentType"></param>
        /// <param name="accept"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <returns>Task of ApiResponse (ProductResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ProductResponse>> CreateProductAsyncWithHttpInfo (ProductPost1 body, string contentType, string accept, string includeFields = null);
        /// <summary>
        /// Delete a Product
        /// </summary>
        /// <remarks>
        /// Deletes a *Product*.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteProductByIdAsync (int? productId, string accept, string contentType);

        /// <summary>
        /// Delete a Product
        /// </summary>
        /// <remarks>
        /// Deletes a *Product*.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteProductByIdAsyncWithHttpInfo (int? productId, string accept, string contentType);
        /// <summary>
        /// Delete Products
        /// </summary>
        /// <remarks>
        /// To delete *Product* objects, you must include a filter. This prevents inadvertently deleting all *Product* objects in a store.  **Example**: To delete products with the id&#x27;s of 1,2 and 3, use &#x60;DELETE /v3/catalog/products?id:in&#x3D;1,2,3&#x60;.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="name">Filter items by name.  (optional)</param>
        /// <param name="sku">Filter items by sku.  (optional)</param>
        /// <param name="price">Filter items by price.  (optional)</param>
        /// <param name="weight">Filter items by weight.  (optional)</param>
        /// <param name="condition">Filter items by condition.  (optional)</param>
        /// <param name="brandId">Filter items by brand_id.  (optional)</param>
        /// <param name="dateModified">Filter items by date_modified. For example &#x60;v3/catalog/products?date_modified:min&#x3D;2018-06-15&#x60; (optional)</param>
        /// <param name="dateLastImported">Filter items by date_last_imported. For example &#x60;v3/catalog/products?date_last_imported:min&#x3D;2018-06-15&#x60; (optional)</param>
        /// <param name="isVisible">Filter items by if visible on the storefront.  (optional)</param>
        /// <param name="isFeatured">Filter items by is_featured.  (optional)</param>
        /// <param name="inventoryLevel">Filter items by inventory_level.  (optional)</param>
        /// <param name="totalSold">Filter items by total_sold.  (optional)</param>
        /// <param name="type">Filter items by type: &#x60;physical&#x60; or &#x60;digital&#x60;. (optional)</param>
        /// <param name="categories">Filter items by categories.  If a product is in more than one category, using this query will not return the product. Instead use &#x60;categories:in&#x3D;12&#x60;. (optional)</param>
        /// <param name="keyword">Filter items by keywords found in the &#x60;name&#x60;, &#x60;description&#x60;, or &#x60;sku&#x60; fields, or in the brand name.  (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteProductsAsync (string accept, string contentType, string name = null, string sku = null, decimal? price = null, decimal? weight = null, string condition = null, int? brandId = null, DateTime? dateModified = null, DateTime? dateLastImported = null, bool? isVisible = null, int? isFeatured = null, int? inventoryLevel = null, int? totalSold = null, string type = null, int? categories = null, string keyword = null);

        /// <summary>
        /// Delete Products
        /// </summary>
        /// <remarks>
        /// To delete *Product* objects, you must include a filter. This prevents inadvertently deleting all *Product* objects in a store.  **Example**: To delete products with the id&#x27;s of 1,2 and 3, use &#x60;DELETE /v3/catalog/products?id:in&#x3D;1,2,3&#x60;.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="name">Filter items by name.  (optional)</param>
        /// <param name="sku">Filter items by sku.  (optional)</param>
        /// <param name="price">Filter items by price.  (optional)</param>
        /// <param name="weight">Filter items by weight.  (optional)</param>
        /// <param name="condition">Filter items by condition.  (optional)</param>
        /// <param name="brandId">Filter items by brand_id.  (optional)</param>
        /// <param name="dateModified">Filter items by date_modified. For example &#x60;v3/catalog/products?date_modified:min&#x3D;2018-06-15&#x60; (optional)</param>
        /// <param name="dateLastImported">Filter items by date_last_imported. For example &#x60;v3/catalog/products?date_last_imported:min&#x3D;2018-06-15&#x60; (optional)</param>
        /// <param name="isVisible">Filter items by if visible on the storefront.  (optional)</param>
        /// <param name="isFeatured">Filter items by is_featured.  (optional)</param>
        /// <param name="inventoryLevel">Filter items by inventory_level.  (optional)</param>
        /// <param name="totalSold">Filter items by total_sold.  (optional)</param>
        /// <param name="type">Filter items by type: &#x60;physical&#x60; or &#x60;digital&#x60;. (optional)</param>
        /// <param name="categories">Filter items by categories.  If a product is in more than one category, using this query will not return the product. Instead use &#x60;categories:in&#x3D;12&#x60;. (optional)</param>
        /// <param name="keyword">Filter items by keywords found in the &#x60;name&#x60;, &#x60;description&#x60;, or &#x60;sku&#x60; fields, or in the brand name.  (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteProductsAsyncWithHttpInfo (string accept, string contentType, string name = null, string sku = null, decimal? price = null, decimal? weight = null, string condition = null, int? brandId = null, DateTime? dateModified = null, DateTime? dateLastImported = null, bool? isVisible = null, int? isFeatured = null, int? inventoryLevel = null, int? totalSold = null, string type = null, int? categories = null, string keyword = null);
        /// <summary>
        /// Get a Product
        /// </summary>
        /// <remarks>
        /// Returns a single *Product*. Optional parameters can be passed in.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="include">Sub-resources to include on a product, in a comma-separated list. If &#x60;options&#x60; or &#x60;modifiers&#x60; is used, results are limited to 10 per page. (optional)</param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of ProductResponse</returns>
        System.Threading.Tasks.Task<ProductResponse> GetProductByIdAsync (int? productId, string accept, string contentType, string include = null, string includeFields = null, string excludeFields = null);

        /// <summary>
        /// Get a Product
        /// </summary>
        /// <remarks>
        /// Returns a single *Product*. Optional parameters can be passed in.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="include">Sub-resources to include on a product, in a comma-separated list. If &#x60;options&#x60; or &#x60;modifiers&#x60; is used, results are limited to 10 per page. (optional)</param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of ApiResponse (ProductResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ProductResponse>> GetProductByIdAsyncWithHttpInfo (int? productId, string accept, string contentType, string include = null, string includeFields = null, string excludeFields = null);
        /// <summary>
        /// Get All Products
        /// </summary>
        /// <remarks>
        /// Returns a list of **Products**. Optional filter parameters can be passed in.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Filter items by id.  (optional)</param>
        /// <param name="idin"> (optional)</param>
        /// <param name="idnotIn"> (optional)</param>
        /// <param name="idmin"> (optional)</param>
        /// <param name="idmax"> (optional)</param>
        /// <param name="idgreater"> (optional)</param>
        /// <param name="idless"> (optional)</param>
        /// <param name="name">Filter items by name.  (optional)</param>
        /// <param name="sku">Filter items by sku.  (optional)</param>
        /// <param name="upc">Filter items by upc.  (optional)</param>
        /// <param name="price">Filter items by price.  (optional)</param>
        /// <param name="weight">Filter items by weight.  (optional)</param>
        /// <param name="condition">Filter items by condition.  (optional)</param>
        /// <param name="brandId">Filter items by brand_id.  (optional)</param>
        /// <param name="dateModified">Filter items by &#x60;date_modified&#x60;. For example, &#x60;/v3/catalog/products?date_modified:min&#x3D;2018-06-15&#x60; gets all products modified after &#x60;2018-06-15&#x60; (optional)</param>
        /// <param name="dateLastImported">Filter items by date_last_imported. For example &#x60;v3/catalog/products?date_last_imported:min&#x3D;2018-06-15&#x60; (optional)</param>
        /// <param name="isVisible">Filter items by if visible on the storefront.  (optional)</param>
        /// <param name="isFeatured">Filter items by is_featured. &#x60;0&#x60; for true, &#x60;1&#x60; for false.  (optional)</param>
        /// <param name="isFreeShipping">Filter items by is_free_shipping.  (optional)</param>
        /// <param name="inventoryLevel">Filter items by inventory_level.  (optional)</param>
        /// <param name="inventoryLow">Filter items by inventory_low. Values: 1, 0.  (optional)</param>
        /// <param name="outOfStock">Filter items by out_of_stock. To enable the filter, pass &#x60;out_of_stock&#x60;&#x3D;&#x60;1&#x60;.  (optional)</param>
        /// <param name="totalSold">Filter items by total_sold.  (optional)</param>
        /// <param name="type">Filter items by type: &#x60;physical&#x60; or &#x60;digital&#x60;. (optional)</param>
        /// <param name="categories">Filter items by categories.  If a product is in more than one category, using this query will not return the product. Instead use &#x60;categories:in&#x3D;12&#x60;. (optional)</param>
        /// <param name="keyword">Filter items by keywords found in the &#x60;name&#x60;, &#x60;description&#x60;, or &#x60;sku&#x60; fields, or in the brand name.  (optional)</param>
        /// <param name="keywordContext">Set context used by the search algorithm to return results targeted towards the specified group. Use &#x60;merchant&#x60; to help merchants search their own catalog. Use &#x60;shopper&#x60; to return shopper-facing search results. (optional)</param>
        /// <param name="status">Filter items by status.  (optional)</param>
        /// <param name="include">Sub-resources to include on a product, in a comma-separated list. If &#x60;options&#x60; or &#x60;modifiers&#x60; is used, results are limited to 10 per page. (optional)</param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <param name="availability">Filter items by availability. Values are: available, disabled, preorder.  (optional)</param>
        /// <param name="priceListId">This filter returns the product pricing with the *Price List* pricing instead. To use: &#x60;?price_list_id&#x3D;1&#x60;. If there are variants use: &#x60;?price_list_id&#x3D;1&amp;include&#x3D;variants&#x60; (optional)</param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <param name="direction">Sort direction. Acceptable values are: &#x60;asc&#x60;, &#x60;desc&#x60;.  (optional)</param>
        /// <param name="sort">Field name to sort by. Note: Since &#x60;id&#x60; increments when new products are added, you can use that field to sort by product create date.  (optional)</param>
        /// <returns>Task of InlineResponse2001</returns>
        System.Threading.Tasks.Task<InlineResponse2001> GetProductsAsync (int? id = null, List<int?> idin = null, List<int?> idnotIn = null, List<int?> idmin = null, List<int?> idmax = null, List<int?> idgreater = null, List<int?> idless = null, string name = null, string sku = null, string upc = null, decimal? price = null, decimal? weight = null, string condition = null, int? brandId = null, DateTime? dateModified = null, DateTime? dateLastImported = null, bool? isVisible = null, int? isFeatured = null, int? isFreeShipping = null, int? inventoryLevel = null, int? inventoryLow = null, int? outOfStock = null, int? totalSold = null, string type = null, int? categories = null, string keyword = null, string keywordContext = null, int? status = null, string include = null, string includeFields = null, string excludeFields = null, string availability = null, int? priceListId = null, int? page = null, int? limit = null, string direction = null, string sort = null);

        /// <summary>
        /// Get All Products
        /// </summary>
        /// <remarks>
        /// Returns a list of **Products**. Optional filter parameters can be passed in.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Filter items by id.  (optional)</param>
        /// <param name="idin"> (optional)</param>
        /// <param name="idnotIn"> (optional)</param>
        /// <param name="idmin"> (optional)</param>
        /// <param name="idmax"> (optional)</param>
        /// <param name="idgreater"> (optional)</param>
        /// <param name="idless"> (optional)</param>
        /// <param name="name">Filter items by name.  (optional)</param>
        /// <param name="sku">Filter items by sku.  (optional)</param>
        /// <param name="upc">Filter items by upc.  (optional)</param>
        /// <param name="price">Filter items by price.  (optional)</param>
        /// <param name="weight">Filter items by weight.  (optional)</param>
        /// <param name="condition">Filter items by condition.  (optional)</param>
        /// <param name="brandId">Filter items by brand_id.  (optional)</param>
        /// <param name="dateModified">Filter items by &#x60;date_modified&#x60;. For example, &#x60;/v3/catalog/products?date_modified:min&#x3D;2018-06-15&#x60; gets all products modified after &#x60;2018-06-15&#x60; (optional)</param>
        /// <param name="dateLastImported">Filter items by date_last_imported. For example &#x60;v3/catalog/products?date_last_imported:min&#x3D;2018-06-15&#x60; (optional)</param>
        /// <param name="isVisible">Filter items by if visible on the storefront.  (optional)</param>
        /// <param name="isFeatured">Filter items by is_featured. &#x60;0&#x60; for true, &#x60;1&#x60; for false.  (optional)</param>
        /// <param name="isFreeShipping">Filter items by is_free_shipping.  (optional)</param>
        /// <param name="inventoryLevel">Filter items by inventory_level.  (optional)</param>
        /// <param name="inventoryLow">Filter items by inventory_low. Values: 1, 0.  (optional)</param>
        /// <param name="outOfStock">Filter items by out_of_stock. To enable the filter, pass &#x60;out_of_stock&#x60;&#x3D;&#x60;1&#x60;.  (optional)</param>
        /// <param name="totalSold">Filter items by total_sold.  (optional)</param>
        /// <param name="type">Filter items by type: &#x60;physical&#x60; or &#x60;digital&#x60;. (optional)</param>
        /// <param name="categories">Filter items by categories.  If a product is in more than one category, using this query will not return the product. Instead use &#x60;categories:in&#x3D;12&#x60;. (optional)</param>
        /// <param name="keyword">Filter items by keywords found in the &#x60;name&#x60;, &#x60;description&#x60;, or &#x60;sku&#x60; fields, or in the brand name.  (optional)</param>
        /// <param name="keywordContext">Set context used by the search algorithm to return results targeted towards the specified group. Use &#x60;merchant&#x60; to help merchants search their own catalog. Use &#x60;shopper&#x60; to return shopper-facing search results. (optional)</param>
        /// <param name="status">Filter items by status.  (optional)</param>
        /// <param name="include">Sub-resources to include on a product, in a comma-separated list. If &#x60;options&#x60; or &#x60;modifiers&#x60; is used, results are limited to 10 per page. (optional)</param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <param name="availability">Filter items by availability. Values are: available, disabled, preorder.  (optional)</param>
        /// <param name="priceListId">This filter returns the product pricing with the *Price List* pricing instead. To use: &#x60;?price_list_id&#x3D;1&#x60;. If there are variants use: &#x60;?price_list_id&#x3D;1&amp;include&#x3D;variants&#x60; (optional)</param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <param name="direction">Sort direction. Acceptable values are: &#x60;asc&#x60;, &#x60;desc&#x60;.  (optional)</param>
        /// <param name="sort">Field name to sort by. Note: Since &#x60;id&#x60; increments when new products are added, you can use that field to sort by product create date.  (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse2001)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2001>> GetProductsAsyncWithHttpInfo (int? id = null, List<int?> idin = null, List<int?> idnotIn = null, List<int?> idmin = null, List<int?> idmax = null, List<int?> idgreater = null, List<int?> idless = null, string name = null, string sku = null, string upc = null, decimal? price = null, decimal? weight = null, string condition = null, int? brandId = null, DateTime? dateModified = null, DateTime? dateLastImported = null, bool? isVisible = null, int? isFeatured = null, int? isFreeShipping = null, int? inventoryLevel = null, int? inventoryLow = null, int? outOfStock = null, int? totalSold = null, string type = null, int? categories = null, string keyword = null, string keywordContext = null, int? status = null, string include = null, string includeFields = null, string excludeFields = null, string availability = null, int? priceListId = null, int? page = null, int? limit = null, string direction = null, string sort = null);
        /// <summary>
        /// Update a Product
        /// </summary>
        /// <remarks>
        /// Updates a *Product*.  **Read-Only Fields** - id - date_created - date_modified - calculated_price - base_variant_id 
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <returns>Task of ProductResponse</returns>
        System.Threading.Tasks.Task<ProductResponse> UpdateProductAsync (ProductPut1 body, string accept, string contentType, int? productId, string includeFields = null);

        /// <summary>
        /// Update a Product
        /// </summary>
        /// <remarks>
        /// Updates a *Product*.  **Read-Only Fields** - id - date_created - date_modified - calculated_price - base_variant_id 
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <returns>Task of ApiResponse (ProductResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ProductResponse>> UpdateProductAsyncWithHttpInfo (ProductPut1 body, string accept, string contentType, int? productId, string includeFields = null);
        /// <summary>
        /// Update Products (Batch)
        /// </summary>
        /// <remarks>
        /// Updates products in batches. At the time of writing, batches are limited to 10 products.  **Required Fields** * &#x60;id&#x60; - product &#x60;id&#x60; is required for batch updates to products.  **Read-Only Fields** - &#x60;id&#x60; - &#x60;date_created&#x60; - &#x60;date_modified&#x60; - &#x60;calculated_price&#x60; - &#x60;base_variant_id&#x60;
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="body"> (optional)</param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <returns>Task of InlineResponse2001</returns>
        System.Threading.Tasks.Task<InlineResponse2001> UpdateProductsAsync (string accept, string contentType, List<Object> body = null, string includeFields = null);

        /// <summary>
        /// Update Products (Batch)
        /// </summary>
        /// <remarks>
        /// Updates products in batches. At the time of writing, batches are limited to 10 products.  **Required Fields** * &#x60;id&#x60; - product &#x60;id&#x60; is required for batch updates to products.  **Read-Only Fields** - &#x60;id&#x60; - &#x60;date_created&#x60; - &#x60;date_modified&#x60; - &#x60;calculated_price&#x60; - &#x60;base_variant_id&#x60;
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="body"> (optional)</param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse2001)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2001>> UpdateProductsAsyncWithHttpInfo (string accept, string contentType, List<Object> body = null, string includeFields = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public partial class ProductsApi : IProductsApi
    {
        private Catalog.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ProductsApi(String basePath)
        {
            this.Configuration = new Catalog.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Catalog.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductsApi"/> class
        /// </summary>
        /// <returns></returns>
        public ProductsApi()
        {
            this.Configuration = Catalog.Client.Configuration.Default;

            ExceptionFactory = Catalog.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ProductsApi(Catalog.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Catalog.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Catalog.Client.Configuration.DefaultExceptionFactory;
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
        public Catalog.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Catalog.Client.ExceptionFactory ExceptionFactory
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
        /// Create a Product Creates a *Product*. Only one product can be created at a time.  **Required Fields:** - &#x60;name&#x60; - &#x60;type&#x60; - &#x60;weight&#x60; - &#x60;price&#x60;  **Read-Only Fields** - &#x60;id&#x60; - &#x60;date_created&#x60; - &#x60;date_modified&#x60; - &#x60;calculated_price&#x60; - &#x60;base_variant_id&#x60;  **Usage Notes** * &#x60;POST&#x60; requests to &#x60;/products&#x60; accepts a single &#x60;video&#x60; object; to send an array of video objects, see: &#x60;/products/{product_id}/videos&#x60;.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="contentType"></param>
        /// <param name="accept"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <returns>ProductResponse</returns>
        public ProductResponse CreateProduct (ProductPost1 body, string contentType, string accept, string includeFields = null)
        {
             ApiResponse<ProductResponse> localVarResponse = CreateProductWithHttpInfo(body, contentType, accept, includeFields);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a Product Creates a *Product*. Only one product can be created at a time.  **Required Fields:** - &#x60;name&#x60; - &#x60;type&#x60; - &#x60;weight&#x60; - &#x60;price&#x60;  **Read-Only Fields** - &#x60;id&#x60; - &#x60;date_created&#x60; - &#x60;date_modified&#x60; - &#x60;calculated_price&#x60; - &#x60;base_variant_id&#x60;  **Usage Notes** * &#x60;POST&#x60; requests to &#x60;/products&#x60; accepts a single &#x60;video&#x60; object; to send an array of video objects, see: &#x60;/products/{product_id}/videos&#x60;.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="contentType"></param>
        /// <param name="accept"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <returns>ApiResponse of ProductResponse</returns>
        public ApiResponse< ProductResponse > CreateProductWithHttpInfo (ProductPost1 body, string contentType, string accept, string includeFields = null)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ProductsApi->CreateProduct");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductsApi->CreateProduct");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductsApi->CreateProduct");

            var localVarPath = "/catalog/products";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (includeFields != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "include_fields", includeFields)); // query parameter
            if (contentType != null) localVarHeaderParams.Add("Content-Type", this.Configuration.ApiClient.ParameterToString(contentType)); // header parameter
            if (accept != null) localVarHeaderParams.Add("Accept", this.Configuration.ApiClient.ParameterToString(accept)); // header parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
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
                Exception exception = ExceptionFactory("CreateProduct", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ProductResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ProductResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ProductResponse)));
        }

        /// <summary>
        /// Create a Product Creates a *Product*. Only one product can be created at a time.  **Required Fields:** - &#x60;name&#x60; - &#x60;type&#x60; - &#x60;weight&#x60; - &#x60;price&#x60;  **Read-Only Fields** - &#x60;id&#x60; - &#x60;date_created&#x60; - &#x60;date_modified&#x60; - &#x60;calculated_price&#x60; - &#x60;base_variant_id&#x60;  **Usage Notes** * &#x60;POST&#x60; requests to &#x60;/products&#x60; accepts a single &#x60;video&#x60; object; to send an array of video objects, see: &#x60;/products/{product_id}/videos&#x60;.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="contentType"></param>
        /// <param name="accept"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <returns>Task of ProductResponse</returns>
        public async System.Threading.Tasks.Task<ProductResponse> CreateProductAsync (ProductPost1 body, string contentType, string accept, string includeFields = null)
        {
             ApiResponse<ProductResponse> localVarResponse = await CreateProductAsyncWithHttpInfo(body, contentType, accept, includeFields);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a Product Creates a *Product*. Only one product can be created at a time.  **Required Fields:** - &#x60;name&#x60; - &#x60;type&#x60; - &#x60;weight&#x60; - &#x60;price&#x60;  **Read-Only Fields** - &#x60;id&#x60; - &#x60;date_created&#x60; - &#x60;date_modified&#x60; - &#x60;calculated_price&#x60; - &#x60;base_variant_id&#x60;  **Usage Notes** * &#x60;POST&#x60; requests to &#x60;/products&#x60; accepts a single &#x60;video&#x60; object; to send an array of video objects, see: &#x60;/products/{product_id}/videos&#x60;.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="contentType"></param>
        /// <param name="accept"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <returns>Task of ApiResponse (ProductResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ProductResponse>> CreateProductAsyncWithHttpInfo (ProductPost1 body, string contentType, string accept, string includeFields = null)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ProductsApi->CreateProduct");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductsApi->CreateProduct");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductsApi->CreateProduct");

            var localVarPath = "/catalog/products";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (includeFields != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "include_fields", includeFields)); // query parameter
            if (contentType != null) localVarHeaderParams.Add("Content-Type", this.Configuration.ApiClient.ParameterToString(contentType)); // header parameter
            if (accept != null) localVarHeaderParams.Add("Accept", this.Configuration.ApiClient.ParameterToString(accept)); // header parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
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
                Exception exception = ExceptionFactory("CreateProduct", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ProductResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ProductResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ProductResponse)));
        }

        /// <summary>
        /// Delete a Product Deletes a *Product*.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns></returns>
        public void DeleteProductById (int? productId, string accept, string contentType)
        {
             DeleteProductByIdWithHttpInfo(productId, accept, contentType);
        }

        /// <summary>
        /// Delete a Product Deletes a *Product*.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteProductByIdWithHttpInfo (int? productId, string accept, string contentType)
        {
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductsApi->DeleteProductById");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductsApi->DeleteProductById");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductsApi->DeleteProductById");

            var localVarPath = "/catalog/products/{product_id}";
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
                Exception exception = ExceptionFactory("DeleteProductById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Delete a Product Deletes a *Product*.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteProductByIdAsync (int? productId, string accept, string contentType)
        {
             await DeleteProductByIdAsyncWithHttpInfo(productId, accept, contentType);

        }

        /// <summary>
        /// Delete a Product Deletes a *Product*.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteProductByIdAsyncWithHttpInfo (int? productId, string accept, string contentType)
        {
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductsApi->DeleteProductById");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductsApi->DeleteProductById");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductsApi->DeleteProductById");

            var localVarPath = "/catalog/products/{product_id}";
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
                Exception exception = ExceptionFactory("DeleteProductById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Delete Products To delete *Product* objects, you must include a filter. This prevents inadvertently deleting all *Product* objects in a store.  **Example**: To delete products with the id&#x27;s of 1,2 and 3, use &#x60;DELETE /v3/catalog/products?id:in&#x3D;1,2,3&#x60;.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="name">Filter items by name.  (optional)</param>
        /// <param name="sku">Filter items by sku.  (optional)</param>
        /// <param name="price">Filter items by price.  (optional)</param>
        /// <param name="weight">Filter items by weight.  (optional)</param>
        /// <param name="condition">Filter items by condition.  (optional)</param>
        /// <param name="brandId">Filter items by brand_id.  (optional)</param>
        /// <param name="dateModified">Filter items by date_modified. For example &#x60;v3/catalog/products?date_modified:min&#x3D;2018-06-15&#x60; (optional)</param>
        /// <param name="dateLastImported">Filter items by date_last_imported. For example &#x60;v3/catalog/products?date_last_imported:min&#x3D;2018-06-15&#x60; (optional)</param>
        /// <param name="isVisible">Filter items by if visible on the storefront.  (optional)</param>
        /// <param name="isFeatured">Filter items by is_featured.  (optional)</param>
        /// <param name="inventoryLevel">Filter items by inventory_level.  (optional)</param>
        /// <param name="totalSold">Filter items by total_sold.  (optional)</param>
        /// <param name="type">Filter items by type: &#x60;physical&#x60; or &#x60;digital&#x60;. (optional)</param>
        /// <param name="categories">Filter items by categories.  If a product is in more than one category, using this query will not return the product. Instead use &#x60;categories:in&#x3D;12&#x60;. (optional)</param>
        /// <param name="keyword">Filter items by keywords found in the &#x60;name&#x60;, &#x60;description&#x60;, or &#x60;sku&#x60; fields, or in the brand name.  (optional)</param>
        /// <returns></returns>
        public void DeleteProducts (string accept, string contentType, string name = null, string sku = null, decimal? price = null, decimal? weight = null, string condition = null, int? brandId = null, DateTime? dateModified = null, DateTime? dateLastImported = null, bool? isVisible = null, int? isFeatured = null, int? inventoryLevel = null, int? totalSold = null, string type = null, int? categories = null, string keyword = null)
        {
             DeleteProductsWithHttpInfo(accept, contentType, name, sku, price, weight, condition, brandId, dateModified, dateLastImported, isVisible, isFeatured, inventoryLevel, totalSold, type, categories, keyword);
        }

        /// <summary>
        /// Delete Products To delete *Product* objects, you must include a filter. This prevents inadvertently deleting all *Product* objects in a store.  **Example**: To delete products with the id&#x27;s of 1,2 and 3, use &#x60;DELETE /v3/catalog/products?id:in&#x3D;1,2,3&#x60;.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="name">Filter items by name.  (optional)</param>
        /// <param name="sku">Filter items by sku.  (optional)</param>
        /// <param name="price">Filter items by price.  (optional)</param>
        /// <param name="weight">Filter items by weight.  (optional)</param>
        /// <param name="condition">Filter items by condition.  (optional)</param>
        /// <param name="brandId">Filter items by brand_id.  (optional)</param>
        /// <param name="dateModified">Filter items by date_modified. For example &#x60;v3/catalog/products?date_modified:min&#x3D;2018-06-15&#x60; (optional)</param>
        /// <param name="dateLastImported">Filter items by date_last_imported. For example &#x60;v3/catalog/products?date_last_imported:min&#x3D;2018-06-15&#x60; (optional)</param>
        /// <param name="isVisible">Filter items by if visible on the storefront.  (optional)</param>
        /// <param name="isFeatured">Filter items by is_featured.  (optional)</param>
        /// <param name="inventoryLevel">Filter items by inventory_level.  (optional)</param>
        /// <param name="totalSold">Filter items by total_sold.  (optional)</param>
        /// <param name="type">Filter items by type: &#x60;physical&#x60; or &#x60;digital&#x60;. (optional)</param>
        /// <param name="categories">Filter items by categories.  If a product is in more than one category, using this query will not return the product. Instead use &#x60;categories:in&#x3D;12&#x60;. (optional)</param>
        /// <param name="keyword">Filter items by keywords found in the &#x60;name&#x60;, &#x60;description&#x60;, or &#x60;sku&#x60; fields, or in the brand name.  (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteProductsWithHttpInfo (string accept, string contentType, string name = null, string sku = null, decimal? price = null, decimal? weight = null, string condition = null, int? brandId = null, DateTime? dateModified = null, DateTime? dateLastImported = null, bool? isVisible = null, int? isFeatured = null, int? inventoryLevel = null, int? totalSold = null, string type = null, int? categories = null, string keyword = null)
        {
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductsApi->DeleteProducts");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductsApi->DeleteProducts");

            var localVarPath = "/catalog/products";
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

            if (name != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "name", name)); // query parameter
            if (sku != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "sku", sku)); // query parameter
            if (price != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "price", price)); // query parameter
            if (weight != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "weight", weight)); // query parameter
            if (condition != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "condition", condition)); // query parameter
            if (brandId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "brand_id", brandId)); // query parameter
            if (dateModified != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "date_modified", dateModified)); // query parameter
            if (dateLastImported != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "date_last_imported", dateLastImported)); // query parameter
            if (isVisible != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "is_visible", isVisible)); // query parameter
            if (isFeatured != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "is_featured", isFeatured)); // query parameter
            if (inventoryLevel != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "inventory_level", inventoryLevel)); // query parameter
            if (totalSold != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "total_sold", totalSold)); // query parameter
            if (type != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "type", type)); // query parameter
            if (categories != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "categories", categories)); // query parameter
            if (keyword != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "keyword", keyword)); // query parameter
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
                Exception exception = ExceptionFactory("DeleteProducts", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Delete Products To delete *Product* objects, you must include a filter. This prevents inadvertently deleting all *Product* objects in a store.  **Example**: To delete products with the id&#x27;s of 1,2 and 3, use &#x60;DELETE /v3/catalog/products?id:in&#x3D;1,2,3&#x60;.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="name">Filter items by name.  (optional)</param>
        /// <param name="sku">Filter items by sku.  (optional)</param>
        /// <param name="price">Filter items by price.  (optional)</param>
        /// <param name="weight">Filter items by weight.  (optional)</param>
        /// <param name="condition">Filter items by condition.  (optional)</param>
        /// <param name="brandId">Filter items by brand_id.  (optional)</param>
        /// <param name="dateModified">Filter items by date_modified. For example &#x60;v3/catalog/products?date_modified:min&#x3D;2018-06-15&#x60; (optional)</param>
        /// <param name="dateLastImported">Filter items by date_last_imported. For example &#x60;v3/catalog/products?date_last_imported:min&#x3D;2018-06-15&#x60; (optional)</param>
        /// <param name="isVisible">Filter items by if visible on the storefront.  (optional)</param>
        /// <param name="isFeatured">Filter items by is_featured.  (optional)</param>
        /// <param name="inventoryLevel">Filter items by inventory_level.  (optional)</param>
        /// <param name="totalSold">Filter items by total_sold.  (optional)</param>
        /// <param name="type">Filter items by type: &#x60;physical&#x60; or &#x60;digital&#x60;. (optional)</param>
        /// <param name="categories">Filter items by categories.  If a product is in more than one category, using this query will not return the product. Instead use &#x60;categories:in&#x3D;12&#x60;. (optional)</param>
        /// <param name="keyword">Filter items by keywords found in the &#x60;name&#x60;, &#x60;description&#x60;, or &#x60;sku&#x60; fields, or in the brand name.  (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteProductsAsync (string accept, string contentType, string name = null, string sku = null, decimal? price = null, decimal? weight = null, string condition = null, int? brandId = null, DateTime? dateModified = null, DateTime? dateLastImported = null, bool? isVisible = null, int? isFeatured = null, int? inventoryLevel = null, int? totalSold = null, string type = null, int? categories = null, string keyword = null)
        {
             await DeleteProductsAsyncWithHttpInfo(accept, contentType, name, sku, price, weight, condition, brandId, dateModified, dateLastImported, isVisible, isFeatured, inventoryLevel, totalSold, type, categories, keyword);

        }

        /// <summary>
        /// Delete Products To delete *Product* objects, you must include a filter. This prevents inadvertently deleting all *Product* objects in a store.  **Example**: To delete products with the id&#x27;s of 1,2 and 3, use &#x60;DELETE /v3/catalog/products?id:in&#x3D;1,2,3&#x60;.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="name">Filter items by name.  (optional)</param>
        /// <param name="sku">Filter items by sku.  (optional)</param>
        /// <param name="price">Filter items by price.  (optional)</param>
        /// <param name="weight">Filter items by weight.  (optional)</param>
        /// <param name="condition">Filter items by condition.  (optional)</param>
        /// <param name="brandId">Filter items by brand_id.  (optional)</param>
        /// <param name="dateModified">Filter items by date_modified. For example &#x60;v3/catalog/products?date_modified:min&#x3D;2018-06-15&#x60; (optional)</param>
        /// <param name="dateLastImported">Filter items by date_last_imported. For example &#x60;v3/catalog/products?date_last_imported:min&#x3D;2018-06-15&#x60; (optional)</param>
        /// <param name="isVisible">Filter items by if visible on the storefront.  (optional)</param>
        /// <param name="isFeatured">Filter items by is_featured.  (optional)</param>
        /// <param name="inventoryLevel">Filter items by inventory_level.  (optional)</param>
        /// <param name="totalSold">Filter items by total_sold.  (optional)</param>
        /// <param name="type">Filter items by type: &#x60;physical&#x60; or &#x60;digital&#x60;. (optional)</param>
        /// <param name="categories">Filter items by categories.  If a product is in more than one category, using this query will not return the product. Instead use &#x60;categories:in&#x3D;12&#x60;. (optional)</param>
        /// <param name="keyword">Filter items by keywords found in the &#x60;name&#x60;, &#x60;description&#x60;, or &#x60;sku&#x60; fields, or in the brand name.  (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteProductsAsyncWithHttpInfo (string accept, string contentType, string name = null, string sku = null, decimal? price = null, decimal? weight = null, string condition = null, int? brandId = null, DateTime? dateModified = null, DateTime? dateLastImported = null, bool? isVisible = null, int? isFeatured = null, int? inventoryLevel = null, int? totalSold = null, string type = null, int? categories = null, string keyword = null)
        {
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductsApi->DeleteProducts");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductsApi->DeleteProducts");

            var localVarPath = "/catalog/products";
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

            if (name != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "name", name)); // query parameter
            if (sku != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "sku", sku)); // query parameter
            if (price != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "price", price)); // query parameter
            if (weight != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "weight", weight)); // query parameter
            if (condition != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "condition", condition)); // query parameter
            if (brandId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "brand_id", brandId)); // query parameter
            if (dateModified != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "date_modified", dateModified)); // query parameter
            if (dateLastImported != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "date_last_imported", dateLastImported)); // query parameter
            if (isVisible != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "is_visible", isVisible)); // query parameter
            if (isFeatured != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "is_featured", isFeatured)); // query parameter
            if (inventoryLevel != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "inventory_level", inventoryLevel)); // query parameter
            if (totalSold != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "total_sold", totalSold)); // query parameter
            if (type != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "type", type)); // query parameter
            if (categories != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "categories", categories)); // query parameter
            if (keyword != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "keyword", keyword)); // query parameter
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
                Exception exception = ExceptionFactory("DeleteProducts", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Get a Product Returns a single *Product*. Optional parameters can be passed in.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="include">Sub-resources to include on a product, in a comma-separated list. If &#x60;options&#x60; or &#x60;modifiers&#x60; is used, results are limited to 10 per page. (optional)</param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>ProductResponse</returns>
        public ProductResponse GetProductById (int? productId, string accept, string contentType, string include = null, string includeFields = null, string excludeFields = null)
        {
             ApiResponse<ProductResponse> localVarResponse = GetProductByIdWithHttpInfo(productId, accept, contentType, include, includeFields, excludeFields);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Product Returns a single *Product*. Optional parameters can be passed in.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="include">Sub-resources to include on a product, in a comma-separated list. If &#x60;options&#x60; or &#x60;modifiers&#x60; is used, results are limited to 10 per page. (optional)</param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>ApiResponse of ProductResponse</returns>
        public ApiResponse< ProductResponse > GetProductByIdWithHttpInfo (int? productId, string accept, string contentType, string include = null, string includeFields = null, string excludeFields = null)
        {
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductsApi->GetProductById");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductsApi->GetProductById");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductsApi->GetProductById");

            var localVarPath = "/catalog/products/{product_id}";
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
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (productId != null) localVarPathParams.Add("product_id", this.Configuration.ApiClient.ParameterToString(productId)); // path parameter
            if (include != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "include", include)); // query parameter
            if (includeFields != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "include_fields", includeFields)); // query parameter
            if (excludeFields != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "exclude_fields", excludeFields)); // query parameter
            if (accept != null) localVarHeaderParams.Add("Accept", this.Configuration.ApiClient.ParameterToString(accept)); // header parameter
            if (contentType != null) localVarHeaderParams.Add("Content-Type", this.Configuration.ApiClient.ParameterToString(contentType)); // header parameter
            // authentication (X-Auth-Token) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-Auth-Token")))
            {
                localVarHeaderParams["X-Auth-Token"] = this.Configuration.GetApiKeyWithPrefix("X-Auth-Token");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetProductById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ProductResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ProductResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ProductResponse)));
        }

        /// <summary>
        /// Get a Product Returns a single *Product*. Optional parameters can be passed in.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="include">Sub-resources to include on a product, in a comma-separated list. If &#x60;options&#x60; or &#x60;modifiers&#x60; is used, results are limited to 10 per page. (optional)</param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of ProductResponse</returns>
        public async System.Threading.Tasks.Task<ProductResponse> GetProductByIdAsync (int? productId, string accept, string contentType, string include = null, string includeFields = null, string excludeFields = null)
        {
             ApiResponse<ProductResponse> localVarResponse = await GetProductByIdAsyncWithHttpInfo(productId, accept, contentType, include, includeFields, excludeFields);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a Product Returns a single *Product*. Optional parameters can be passed in.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="include">Sub-resources to include on a product, in a comma-separated list. If &#x60;options&#x60; or &#x60;modifiers&#x60; is used, results are limited to 10 per page. (optional)</param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of ApiResponse (ProductResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ProductResponse>> GetProductByIdAsyncWithHttpInfo (int? productId, string accept, string contentType, string include = null, string includeFields = null, string excludeFields = null)
        {
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductsApi->GetProductById");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductsApi->GetProductById");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductsApi->GetProductById");

            var localVarPath = "/catalog/products/{product_id}";
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
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (productId != null) localVarPathParams.Add("product_id", this.Configuration.ApiClient.ParameterToString(productId)); // path parameter
            if (include != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "include", include)); // query parameter
            if (includeFields != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "include_fields", includeFields)); // query parameter
            if (excludeFields != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "exclude_fields", excludeFields)); // query parameter
            if (accept != null) localVarHeaderParams.Add("Accept", this.Configuration.ApiClient.ParameterToString(accept)); // header parameter
            if (contentType != null) localVarHeaderParams.Add("Content-Type", this.Configuration.ApiClient.ParameterToString(contentType)); // header parameter
            // authentication (X-Auth-Token) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-Auth-Token")))
            {
                localVarHeaderParams["X-Auth-Token"] = this.Configuration.GetApiKeyWithPrefix("X-Auth-Token");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetProductById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ProductResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ProductResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ProductResponse)));
        }

        /// <summary>
        /// Get All Products Returns a list of **Products**. Optional filter parameters can be passed in.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Filter items by id.  (optional)</param>
        /// <param name="idin"> (optional)</param>
        /// <param name="idnotIn"> (optional)</param>
        /// <param name="idmin"> (optional)</param>
        /// <param name="idmax"> (optional)</param>
        /// <param name="idgreater"> (optional)</param>
        /// <param name="idless"> (optional)</param>
        /// <param name="name">Filter items by name.  (optional)</param>
        /// <param name="sku">Filter items by sku.  (optional)</param>
        /// <param name="upc">Filter items by upc.  (optional)</param>
        /// <param name="price">Filter items by price.  (optional)</param>
        /// <param name="weight">Filter items by weight.  (optional)</param>
        /// <param name="condition">Filter items by condition.  (optional)</param>
        /// <param name="brandId">Filter items by brand_id.  (optional)</param>
        /// <param name="dateModified">Filter items by &#x60;date_modified&#x60;. For example, &#x60;/v3/catalog/products?date_modified:min&#x3D;2018-06-15&#x60; gets all products modified after &#x60;2018-06-15&#x60; (optional)</param>
        /// <param name="dateLastImported">Filter items by date_last_imported. For example &#x60;v3/catalog/products?date_last_imported:min&#x3D;2018-06-15&#x60; (optional)</param>
        /// <param name="isVisible">Filter items by if visible on the storefront.  (optional)</param>
        /// <param name="isFeatured">Filter items by is_featured. &#x60;0&#x60; for true, &#x60;1&#x60; for false.  (optional)</param>
        /// <param name="isFreeShipping">Filter items by is_free_shipping.  (optional)</param>
        /// <param name="inventoryLevel">Filter items by inventory_level.  (optional)</param>
        /// <param name="inventoryLow">Filter items by inventory_low. Values: 1, 0.  (optional)</param>
        /// <param name="outOfStock">Filter items by out_of_stock. To enable the filter, pass &#x60;out_of_stock&#x60;&#x3D;&#x60;1&#x60;.  (optional)</param>
        /// <param name="totalSold">Filter items by total_sold.  (optional)</param>
        /// <param name="type">Filter items by type: &#x60;physical&#x60; or &#x60;digital&#x60;. (optional)</param>
        /// <param name="categories">Filter items by categories.  If a product is in more than one category, using this query will not return the product. Instead use &#x60;categories:in&#x3D;12&#x60;. (optional)</param>
        /// <param name="keyword">Filter items by keywords found in the &#x60;name&#x60;, &#x60;description&#x60;, or &#x60;sku&#x60; fields, or in the brand name.  (optional)</param>
        /// <param name="keywordContext">Set context used by the search algorithm to return results targeted towards the specified group. Use &#x60;merchant&#x60; to help merchants search their own catalog. Use &#x60;shopper&#x60; to return shopper-facing search results. (optional)</param>
        /// <param name="status">Filter items by status.  (optional)</param>
        /// <param name="include">Sub-resources to include on a product, in a comma-separated list. If &#x60;options&#x60; or &#x60;modifiers&#x60; is used, results are limited to 10 per page. (optional)</param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <param name="availability">Filter items by availability. Values are: available, disabled, preorder.  (optional)</param>
        /// <param name="priceListId">This filter returns the product pricing with the *Price List* pricing instead. To use: &#x60;?price_list_id&#x3D;1&#x60;. If there are variants use: &#x60;?price_list_id&#x3D;1&amp;include&#x3D;variants&#x60; (optional)</param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <param name="direction">Sort direction. Acceptable values are: &#x60;asc&#x60;, &#x60;desc&#x60;.  (optional)</param>
        /// <param name="sort">Field name to sort by. Note: Since &#x60;id&#x60; increments when new products are added, you can use that field to sort by product create date.  (optional)</param>
        /// <returns>InlineResponse2001</returns>
        public InlineResponse2001 GetProducts (int? id = null, List<int?> idin = null, List<int?> idnotIn = null, List<int?> idmin = null, List<int?> idmax = null, List<int?> idgreater = null, List<int?> idless = null, string name = null, string sku = null, string upc = null, decimal? price = null, decimal? weight = null, string condition = null, int? brandId = null, DateTime? dateModified = null, DateTime? dateLastImported = null, bool? isVisible = null, int? isFeatured = null, int? isFreeShipping = null, int? inventoryLevel = null, int? inventoryLow = null, int? outOfStock = null, int? totalSold = null, string type = null, int? categories = null, string keyword = null, string keywordContext = null, int? status = null, string include = null, string includeFields = null, string excludeFields = null, string availability = null, int? priceListId = null, int? page = null, int? limit = null, string direction = null, string sort = null)
        {
             ApiResponse<InlineResponse2001> localVarResponse = GetProductsWithHttpInfo(id, idin, idnotIn, idmin, idmax, idgreater, idless, name, sku, upc, price, weight, condition, brandId, dateModified, dateLastImported, isVisible, isFeatured, isFreeShipping, inventoryLevel, inventoryLow, outOfStock, totalSold, type, categories, keyword, keywordContext, status, include, includeFields, excludeFields, availability, priceListId, page, limit, direction, sort);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get All Products Returns a list of **Products**. Optional filter parameters can be passed in.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Filter items by id.  (optional)</param>
        /// <param name="idin"> (optional)</param>
        /// <param name="idnotIn"> (optional)</param>
        /// <param name="idmin"> (optional)</param>
        /// <param name="idmax"> (optional)</param>
        /// <param name="idgreater"> (optional)</param>
        /// <param name="idless"> (optional)</param>
        /// <param name="name">Filter items by name.  (optional)</param>
        /// <param name="sku">Filter items by sku.  (optional)</param>
        /// <param name="upc">Filter items by upc.  (optional)</param>
        /// <param name="price">Filter items by price.  (optional)</param>
        /// <param name="weight">Filter items by weight.  (optional)</param>
        /// <param name="condition">Filter items by condition.  (optional)</param>
        /// <param name="brandId">Filter items by brand_id.  (optional)</param>
        /// <param name="dateModified">Filter items by &#x60;date_modified&#x60;. For example, &#x60;/v3/catalog/products?date_modified:min&#x3D;2018-06-15&#x60; gets all products modified after &#x60;2018-06-15&#x60; (optional)</param>
        /// <param name="dateLastImported">Filter items by date_last_imported. For example &#x60;v3/catalog/products?date_last_imported:min&#x3D;2018-06-15&#x60; (optional)</param>
        /// <param name="isVisible">Filter items by if visible on the storefront.  (optional)</param>
        /// <param name="isFeatured">Filter items by is_featured. &#x60;0&#x60; for true, &#x60;1&#x60; for false.  (optional)</param>
        /// <param name="isFreeShipping">Filter items by is_free_shipping.  (optional)</param>
        /// <param name="inventoryLevel">Filter items by inventory_level.  (optional)</param>
        /// <param name="inventoryLow">Filter items by inventory_low. Values: 1, 0.  (optional)</param>
        /// <param name="outOfStock">Filter items by out_of_stock. To enable the filter, pass &#x60;out_of_stock&#x60;&#x3D;&#x60;1&#x60;.  (optional)</param>
        /// <param name="totalSold">Filter items by total_sold.  (optional)</param>
        /// <param name="type">Filter items by type: &#x60;physical&#x60; or &#x60;digital&#x60;. (optional)</param>
        /// <param name="categories">Filter items by categories.  If a product is in more than one category, using this query will not return the product. Instead use &#x60;categories:in&#x3D;12&#x60;. (optional)</param>
        /// <param name="keyword">Filter items by keywords found in the &#x60;name&#x60;, &#x60;description&#x60;, or &#x60;sku&#x60; fields, or in the brand name.  (optional)</param>
        /// <param name="keywordContext">Set context used by the search algorithm to return results targeted towards the specified group. Use &#x60;merchant&#x60; to help merchants search their own catalog. Use &#x60;shopper&#x60; to return shopper-facing search results. (optional)</param>
        /// <param name="status">Filter items by status.  (optional)</param>
        /// <param name="include">Sub-resources to include on a product, in a comma-separated list. If &#x60;options&#x60; or &#x60;modifiers&#x60; is used, results are limited to 10 per page. (optional)</param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <param name="availability">Filter items by availability. Values are: available, disabled, preorder.  (optional)</param>
        /// <param name="priceListId">This filter returns the product pricing with the *Price List* pricing instead. To use: &#x60;?price_list_id&#x3D;1&#x60;. If there are variants use: &#x60;?price_list_id&#x3D;1&amp;include&#x3D;variants&#x60; (optional)</param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <param name="direction">Sort direction. Acceptable values are: &#x60;asc&#x60;, &#x60;desc&#x60;.  (optional)</param>
        /// <param name="sort">Field name to sort by. Note: Since &#x60;id&#x60; increments when new products are added, you can use that field to sort by product create date.  (optional)</param>
        /// <returns>ApiResponse of InlineResponse2001</returns>
        public ApiResponse< InlineResponse2001 > GetProductsWithHttpInfo (int? id = null, List<int?> idin = null, List<int?> idnotIn = null, List<int?> idmin = null, List<int?> idmax = null, List<int?> idgreater = null, List<int?> idless = null, string name = null, string sku = null, string upc = null, decimal? price = null, decimal? weight = null, string condition = null, int? brandId = null, DateTime? dateModified = null, DateTime? dateLastImported = null, bool? isVisible = null, int? isFeatured = null, int? isFreeShipping = null, int? inventoryLevel = null, int? inventoryLow = null, int? outOfStock = null, int? totalSold = null, string type = null, int? categories = null, string keyword = null, string keywordContext = null, int? status = null, string include = null, string includeFields = null, string excludeFields = null, string availability = null, int? priceListId = null, int? page = null, int? limit = null, string direction = null, string sort = null)
        {

            var localVarPath = "/catalog/products";
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
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "id", id)); // query parameter
            if (idin != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("csv", "id:in", idin)); // query parameter
            if (idnotIn != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("csv", "id:not_in", idnotIn)); // query parameter
            if (idmin != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("csv", "id:min", idmin)); // query parameter
            if (idmax != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("csv", "id:max", idmax)); // query parameter
            if (idgreater != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("csv", "id:greater", idgreater)); // query parameter
            if (idless != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("csv", "id:less", idless)); // query parameter
            if (name != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "name", name)); // query parameter
            if (sku != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "sku", sku)); // query parameter
            if (upc != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "upc", upc)); // query parameter
            if (price != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "price", price)); // query parameter
            if (weight != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "weight", weight)); // query parameter
            if (condition != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "condition", condition)); // query parameter
            if (brandId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "brand_id", brandId)); // query parameter
            if (dateModified != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "date_modified", dateModified)); // query parameter
            if (dateLastImported != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "date_last_imported", dateLastImported)); // query parameter
            if (isVisible != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "is_visible", isVisible)); // query parameter
            if (isFeatured != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "is_featured", isFeatured)); // query parameter
            if (isFreeShipping != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "is_free_shipping", isFreeShipping)); // query parameter
            if (inventoryLevel != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "inventory_level", inventoryLevel)); // query parameter
            if (inventoryLow != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "inventory_low", inventoryLow)); // query parameter
            if (outOfStock != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "out_of_stock", outOfStock)); // query parameter
            if (totalSold != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "total_sold", totalSold)); // query parameter
            if (type != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "type", type)); // query parameter
            if (categories != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "categories", categories)); // query parameter
            if (keyword != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "keyword", keyword)); // query parameter
            if (keywordContext != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "keyword_context", keywordContext)); // query parameter
            if (status != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "status", status)); // query parameter
            if (include != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "include", include)); // query parameter
            if (includeFields != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "include_fields", includeFields)); // query parameter
            if (excludeFields != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "exclude_fields", excludeFields)); // query parameter
            if (availability != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "availability", availability)); // query parameter
            if (priceListId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "price_list_id", priceListId)); // query parameter
            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter
            if (direction != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "direction", direction)); // query parameter
            if (sort != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "sort", sort)); // query parameter
            // authentication (X-Auth-Token) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-Auth-Token")))
            {
                localVarHeaderParams["X-Auth-Token"] = this.Configuration.GetApiKeyWithPrefix("X-Auth-Token");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetProducts", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2001>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (InlineResponse2001) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2001)));
        }

        /// <summary>
        /// Get All Products Returns a list of **Products**. Optional filter parameters can be passed in.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Filter items by id.  (optional)</param>
        /// <param name="idin"> (optional)</param>
        /// <param name="idnotIn"> (optional)</param>
        /// <param name="idmin"> (optional)</param>
        /// <param name="idmax"> (optional)</param>
        /// <param name="idgreater"> (optional)</param>
        /// <param name="idless"> (optional)</param>
        /// <param name="name">Filter items by name.  (optional)</param>
        /// <param name="sku">Filter items by sku.  (optional)</param>
        /// <param name="upc">Filter items by upc.  (optional)</param>
        /// <param name="price">Filter items by price.  (optional)</param>
        /// <param name="weight">Filter items by weight.  (optional)</param>
        /// <param name="condition">Filter items by condition.  (optional)</param>
        /// <param name="brandId">Filter items by brand_id.  (optional)</param>
        /// <param name="dateModified">Filter items by &#x60;date_modified&#x60;. For example, &#x60;/v3/catalog/products?date_modified:min&#x3D;2018-06-15&#x60; gets all products modified after &#x60;2018-06-15&#x60; (optional)</param>
        /// <param name="dateLastImported">Filter items by date_last_imported. For example &#x60;v3/catalog/products?date_last_imported:min&#x3D;2018-06-15&#x60; (optional)</param>
        /// <param name="isVisible">Filter items by if visible on the storefront.  (optional)</param>
        /// <param name="isFeatured">Filter items by is_featured. &#x60;0&#x60; for true, &#x60;1&#x60; for false.  (optional)</param>
        /// <param name="isFreeShipping">Filter items by is_free_shipping.  (optional)</param>
        /// <param name="inventoryLevel">Filter items by inventory_level.  (optional)</param>
        /// <param name="inventoryLow">Filter items by inventory_low. Values: 1, 0.  (optional)</param>
        /// <param name="outOfStock">Filter items by out_of_stock. To enable the filter, pass &#x60;out_of_stock&#x60;&#x3D;&#x60;1&#x60;.  (optional)</param>
        /// <param name="totalSold">Filter items by total_sold.  (optional)</param>
        /// <param name="type">Filter items by type: &#x60;physical&#x60; or &#x60;digital&#x60;. (optional)</param>
        /// <param name="categories">Filter items by categories.  If a product is in more than one category, using this query will not return the product. Instead use &#x60;categories:in&#x3D;12&#x60;. (optional)</param>
        /// <param name="keyword">Filter items by keywords found in the &#x60;name&#x60;, &#x60;description&#x60;, or &#x60;sku&#x60; fields, or in the brand name.  (optional)</param>
        /// <param name="keywordContext">Set context used by the search algorithm to return results targeted towards the specified group. Use &#x60;merchant&#x60; to help merchants search their own catalog. Use &#x60;shopper&#x60; to return shopper-facing search results. (optional)</param>
        /// <param name="status">Filter items by status.  (optional)</param>
        /// <param name="include">Sub-resources to include on a product, in a comma-separated list. If &#x60;options&#x60; or &#x60;modifiers&#x60; is used, results are limited to 10 per page. (optional)</param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <param name="availability">Filter items by availability. Values are: available, disabled, preorder.  (optional)</param>
        /// <param name="priceListId">This filter returns the product pricing with the *Price List* pricing instead. To use: &#x60;?price_list_id&#x3D;1&#x60;. If there are variants use: &#x60;?price_list_id&#x3D;1&amp;include&#x3D;variants&#x60; (optional)</param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <param name="direction">Sort direction. Acceptable values are: &#x60;asc&#x60;, &#x60;desc&#x60;.  (optional)</param>
        /// <param name="sort">Field name to sort by. Note: Since &#x60;id&#x60; increments when new products are added, you can use that field to sort by product create date.  (optional)</param>
        /// <returns>Task of InlineResponse2001</returns>
        public async System.Threading.Tasks.Task<InlineResponse2001> GetProductsAsync (int? id = null, List<int?> idin = null, List<int?> idnotIn = null, List<int?> idmin = null, List<int?> idmax = null, List<int?> idgreater = null, List<int?> idless = null, string name = null, string sku = null, string upc = null, decimal? price = null, decimal? weight = null, string condition = null, int? brandId = null, DateTime? dateModified = null, DateTime? dateLastImported = null, bool? isVisible = null, int? isFeatured = null, int? isFreeShipping = null, int? inventoryLevel = null, int? inventoryLow = null, int? outOfStock = null, int? totalSold = null, string type = null, int? categories = null, string keyword = null, string keywordContext = null, int? status = null, string include = null, string includeFields = null, string excludeFields = null, string availability = null, int? priceListId = null, int? page = null, int? limit = null, string direction = null, string sort = null)
        {
             ApiResponse<InlineResponse2001> localVarResponse = await GetProductsAsyncWithHttpInfo(id, idin, idnotIn, idmin, idmax, idgreater, idless, name, sku, upc, price, weight, condition, brandId, dateModified, dateLastImported, isVisible, isFeatured, isFreeShipping, inventoryLevel, inventoryLow, outOfStock, totalSold, type, categories, keyword, keywordContext, status, include, includeFields, excludeFields, availability, priceListId, page, limit, direction, sort);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get All Products Returns a list of **Products**. Optional filter parameters can be passed in.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Filter items by id.  (optional)</param>
        /// <param name="idin"> (optional)</param>
        /// <param name="idnotIn"> (optional)</param>
        /// <param name="idmin"> (optional)</param>
        /// <param name="idmax"> (optional)</param>
        /// <param name="idgreater"> (optional)</param>
        /// <param name="idless"> (optional)</param>
        /// <param name="name">Filter items by name.  (optional)</param>
        /// <param name="sku">Filter items by sku.  (optional)</param>
        /// <param name="upc">Filter items by upc.  (optional)</param>
        /// <param name="price">Filter items by price.  (optional)</param>
        /// <param name="weight">Filter items by weight.  (optional)</param>
        /// <param name="condition">Filter items by condition.  (optional)</param>
        /// <param name="brandId">Filter items by brand_id.  (optional)</param>
        /// <param name="dateModified">Filter items by &#x60;date_modified&#x60;. For example, &#x60;/v3/catalog/products?date_modified:min&#x3D;2018-06-15&#x60; gets all products modified after &#x60;2018-06-15&#x60; (optional)</param>
        /// <param name="dateLastImported">Filter items by date_last_imported. For example &#x60;v3/catalog/products?date_last_imported:min&#x3D;2018-06-15&#x60; (optional)</param>
        /// <param name="isVisible">Filter items by if visible on the storefront.  (optional)</param>
        /// <param name="isFeatured">Filter items by is_featured. &#x60;0&#x60; for true, &#x60;1&#x60; for false.  (optional)</param>
        /// <param name="isFreeShipping">Filter items by is_free_shipping.  (optional)</param>
        /// <param name="inventoryLevel">Filter items by inventory_level.  (optional)</param>
        /// <param name="inventoryLow">Filter items by inventory_low. Values: 1, 0.  (optional)</param>
        /// <param name="outOfStock">Filter items by out_of_stock. To enable the filter, pass &#x60;out_of_stock&#x60;&#x3D;&#x60;1&#x60;.  (optional)</param>
        /// <param name="totalSold">Filter items by total_sold.  (optional)</param>
        /// <param name="type">Filter items by type: &#x60;physical&#x60; or &#x60;digital&#x60;. (optional)</param>
        /// <param name="categories">Filter items by categories.  If a product is in more than one category, using this query will not return the product. Instead use &#x60;categories:in&#x3D;12&#x60;. (optional)</param>
        /// <param name="keyword">Filter items by keywords found in the &#x60;name&#x60;, &#x60;description&#x60;, or &#x60;sku&#x60; fields, or in the brand name.  (optional)</param>
        /// <param name="keywordContext">Set context used by the search algorithm to return results targeted towards the specified group. Use &#x60;merchant&#x60; to help merchants search their own catalog. Use &#x60;shopper&#x60; to return shopper-facing search results. (optional)</param>
        /// <param name="status">Filter items by status.  (optional)</param>
        /// <param name="include">Sub-resources to include on a product, in a comma-separated list. If &#x60;options&#x60; or &#x60;modifiers&#x60; is used, results are limited to 10 per page. (optional)</param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <param name="availability">Filter items by availability. Values are: available, disabled, preorder.  (optional)</param>
        /// <param name="priceListId">This filter returns the product pricing with the *Price List* pricing instead. To use: &#x60;?price_list_id&#x3D;1&#x60;. If there are variants use: &#x60;?price_list_id&#x3D;1&amp;include&#x3D;variants&#x60; (optional)</param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <param name="direction">Sort direction. Acceptable values are: &#x60;asc&#x60;, &#x60;desc&#x60;.  (optional)</param>
        /// <param name="sort">Field name to sort by. Note: Since &#x60;id&#x60; increments when new products are added, you can use that field to sort by product create date.  (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse2001)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2001>> GetProductsAsyncWithHttpInfo (int? id = null, List<int?> idin = null, List<int?> idnotIn = null, List<int?> idmin = null, List<int?> idmax = null, List<int?> idgreater = null, List<int?> idless = null, string name = null, string sku = null, string upc = null, decimal? price = null, decimal? weight = null, string condition = null, int? brandId = null, DateTime? dateModified = null, DateTime? dateLastImported = null, bool? isVisible = null, int? isFeatured = null, int? isFreeShipping = null, int? inventoryLevel = null, int? inventoryLow = null, int? outOfStock = null, int? totalSold = null, string type = null, int? categories = null, string keyword = null, string keywordContext = null, int? status = null, string include = null, string includeFields = null, string excludeFields = null, string availability = null, int? priceListId = null, int? page = null, int? limit = null, string direction = null, string sort = null)
        {

            var localVarPath = "/catalog/products";
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
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "id", id)); // query parameter
            if (idin != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("csv", "id:in", idin)); // query parameter
            if (idnotIn != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("csv", "id:not_in", idnotIn)); // query parameter
            if (idmin != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("csv", "id:min", idmin)); // query parameter
            if (idmax != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("csv", "id:max", idmax)); // query parameter
            if (idgreater != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("csv", "id:greater", idgreater)); // query parameter
            if (idless != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("csv", "id:less", idless)); // query parameter
            if (name != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "name", name)); // query parameter
            if (sku != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "sku", sku)); // query parameter
            if (upc != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "upc", upc)); // query parameter
            if (price != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "price", price)); // query parameter
            if (weight != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "weight", weight)); // query parameter
            if (condition != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "condition", condition)); // query parameter
            if (brandId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "brand_id", brandId)); // query parameter
            if (dateModified != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "date_modified", dateModified)); // query parameter
            if (dateLastImported != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "date_last_imported", dateLastImported)); // query parameter
            if (isVisible != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "is_visible", isVisible)); // query parameter
            if (isFeatured != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "is_featured", isFeatured)); // query parameter
            if (isFreeShipping != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "is_free_shipping", isFreeShipping)); // query parameter
            if (inventoryLevel != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "inventory_level", inventoryLevel)); // query parameter
            if (inventoryLow != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "inventory_low", inventoryLow)); // query parameter
            if (outOfStock != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "out_of_stock", outOfStock)); // query parameter
            if (totalSold != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "total_sold", totalSold)); // query parameter
            if (type != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "type", type)); // query parameter
            if (categories != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "categories", categories)); // query parameter
            if (keyword != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "keyword", keyword)); // query parameter
            if (keywordContext != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "keyword_context", keywordContext)); // query parameter
            if (status != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "status", status)); // query parameter
            if (include != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "include", include)); // query parameter
            if (includeFields != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "include_fields", includeFields)); // query parameter
            if (excludeFields != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "exclude_fields", excludeFields)); // query parameter
            if (availability != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "availability", availability)); // query parameter
            if (priceListId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "price_list_id", priceListId)); // query parameter
            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter
            if (direction != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "direction", direction)); // query parameter
            if (sort != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "sort", sort)); // query parameter
            // authentication (X-Auth-Token) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-Auth-Token")))
            {
                localVarHeaderParams["X-Auth-Token"] = this.Configuration.GetApiKeyWithPrefix("X-Auth-Token");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetProducts", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2001>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (InlineResponse2001) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2001)));
        }

        /// <summary>
        /// Update a Product Updates a *Product*.  **Read-Only Fields** - id - date_created - date_modified - calculated_price - base_variant_id 
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <returns>ProductResponse</returns>
        public ProductResponse UpdateProduct (ProductPut1 body, string accept, string contentType, int? productId, string includeFields = null)
        {
             ApiResponse<ProductResponse> localVarResponse = UpdateProductWithHttpInfo(body, accept, contentType, productId, includeFields);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a Product Updates a *Product*.  **Read-Only Fields** - id - date_created - date_modified - calculated_price - base_variant_id 
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <returns>ApiResponse of ProductResponse</returns>
        public ApiResponse< ProductResponse > UpdateProductWithHttpInfo (ProductPut1 body, string accept, string contentType, int? productId, string includeFields = null)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ProductsApi->UpdateProduct");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductsApi->UpdateProduct");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductsApi->UpdateProduct");
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductsApi->UpdateProduct");

            var localVarPath = "/catalog/products/{product_id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
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
            if (includeFields != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "include_fields", includeFields)); // query parameter
            if (accept != null) localVarHeaderParams.Add("Accept", this.Configuration.ApiClient.ParameterToString(accept)); // header parameter
            if (contentType != null) localVarHeaderParams.Add("Content-Type", this.Configuration.ApiClient.ParameterToString(contentType)); // header parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
            // authentication (X-Auth-Token) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-Auth-Token")))
            {
                localVarHeaderParams["X-Auth-Token"] = this.Configuration.GetApiKeyWithPrefix("X-Auth-Token");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdateProduct", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ProductResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ProductResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ProductResponse)));
        }

        /// <summary>
        /// Update a Product Updates a *Product*.  **Read-Only Fields** - id - date_created - date_modified - calculated_price - base_variant_id 
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <returns>Task of ProductResponse</returns>
        public async System.Threading.Tasks.Task<ProductResponse> UpdateProductAsync (ProductPut1 body, string accept, string contentType, int? productId, string includeFields = null)
        {
             ApiResponse<ProductResponse> localVarResponse = await UpdateProductAsyncWithHttpInfo(body, accept, contentType, productId, includeFields);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a Product Updates a *Product*.  **Read-Only Fields** - id - date_created - date_modified - calculated_price - base_variant_id 
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <returns>Task of ApiResponse (ProductResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ProductResponse>> UpdateProductAsyncWithHttpInfo (ProductPut1 body, string accept, string contentType, int? productId, string includeFields = null)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ProductsApi->UpdateProduct");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductsApi->UpdateProduct");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductsApi->UpdateProduct");
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductsApi->UpdateProduct");

            var localVarPath = "/catalog/products/{product_id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
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
            if (includeFields != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "include_fields", includeFields)); // query parameter
            if (accept != null) localVarHeaderParams.Add("Accept", this.Configuration.ApiClient.ParameterToString(accept)); // header parameter
            if (contentType != null) localVarHeaderParams.Add("Content-Type", this.Configuration.ApiClient.ParameterToString(contentType)); // header parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
            // authentication (X-Auth-Token) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-Auth-Token")))
            {
                localVarHeaderParams["X-Auth-Token"] = this.Configuration.GetApiKeyWithPrefix("X-Auth-Token");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdateProduct", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ProductResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ProductResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ProductResponse)));
        }

        /// <summary>
        /// Update Products (Batch) Updates products in batches. At the time of writing, batches are limited to 10 products.  **Required Fields** * &#x60;id&#x60; - product &#x60;id&#x60; is required for batch updates to products.  **Read-Only Fields** - &#x60;id&#x60; - &#x60;date_created&#x60; - &#x60;date_modified&#x60; - &#x60;calculated_price&#x60; - &#x60;base_variant_id&#x60;
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="body"> (optional)</param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <returns>InlineResponse2001</returns>
        public InlineResponse2001 UpdateProducts (string accept, string contentType, List<Object> body = null, string includeFields = null)
        {
             ApiResponse<InlineResponse2001> localVarResponse = UpdateProductsWithHttpInfo(accept, contentType, body, includeFields);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update Products (Batch) Updates products in batches. At the time of writing, batches are limited to 10 products.  **Required Fields** * &#x60;id&#x60; - product &#x60;id&#x60; is required for batch updates to products.  **Read-Only Fields** - &#x60;id&#x60; - &#x60;date_created&#x60; - &#x60;date_modified&#x60; - &#x60;calculated_price&#x60; - &#x60;base_variant_id&#x60;
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="body"> (optional)</param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <returns>ApiResponse of InlineResponse2001</returns>
        public ApiResponse< InlineResponse2001 > UpdateProductsWithHttpInfo (string accept, string contentType, List<Object> body = null, string includeFields = null)
        {
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductsApi->UpdateProducts");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductsApi->UpdateProducts");

            var localVarPath = "/catalog/products";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (includeFields != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "include_fields", includeFields)); // query parameter
            if (accept != null) localVarHeaderParams.Add("Accept", this.Configuration.ApiClient.ParameterToString(accept)); // header parameter
            if (contentType != null) localVarHeaderParams.Add("Content-Type", this.Configuration.ApiClient.ParameterToString(contentType)); // header parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
            // authentication (X-Auth-Token) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-Auth-Token")))
            {
                localVarHeaderParams["X-Auth-Token"] = this.Configuration.GetApiKeyWithPrefix("X-Auth-Token");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdateProducts", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2001>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (InlineResponse2001) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2001)));
        }

        /// <summary>
        /// Update Products (Batch) Updates products in batches. At the time of writing, batches are limited to 10 products.  **Required Fields** * &#x60;id&#x60; - product &#x60;id&#x60; is required for batch updates to products.  **Read-Only Fields** - &#x60;id&#x60; - &#x60;date_created&#x60; - &#x60;date_modified&#x60; - &#x60;calculated_price&#x60; - &#x60;base_variant_id&#x60;
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="body"> (optional)</param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <returns>Task of InlineResponse2001</returns>
        public async System.Threading.Tasks.Task<InlineResponse2001> UpdateProductsAsync (string accept, string contentType, List<Object> body = null, string includeFields = null)
        {
             ApiResponse<InlineResponse2001> localVarResponse = await UpdateProductsAsyncWithHttpInfo(accept, contentType, body, includeFields);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update Products (Batch) Updates products in batches. At the time of writing, batches are limited to 10 products.  **Required Fields** * &#x60;id&#x60; - product &#x60;id&#x60; is required for batch updates to products.  **Read-Only Fields** - &#x60;id&#x60; - &#x60;date_created&#x60; - &#x60;date_modified&#x60; - &#x60;calculated_price&#x60; - &#x60;base_variant_id&#x60;
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="body"> (optional)</param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse2001)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2001>> UpdateProductsAsyncWithHttpInfo (string accept, string contentType, List<Object> body = null, string includeFields = null)
        {
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductsApi->UpdateProducts");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductsApi->UpdateProducts");

            var localVarPath = "/catalog/products";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (includeFields != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "include_fields", includeFields)); // query parameter
            if (accept != null) localVarHeaderParams.Add("Accept", this.Configuration.ApiClient.ParameterToString(accept)); // header parameter
            if (contentType != null) localVarHeaderParams.Add("Content-Type", this.Configuration.ApiClient.ParameterToString(contentType)); // header parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
            // authentication (X-Auth-Token) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-Auth-Token")))
            {
                localVarHeaderParams["X-Auth-Token"] = this.Configuration.GetApiKeyWithPrefix("X-Auth-Token");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdateProducts", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2001>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (InlineResponse2001) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2001)));
        }

    }
}
