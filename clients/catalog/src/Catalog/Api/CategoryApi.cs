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
        public interface ICategoryApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Create a Category
        /// </summary>
        /// <remarks>
        /// Creates a *Category*.  **Required Fields**: - parent_id:   - To create a child category, set the parent_id to the parent category.  - To create a top level category, set the parent_id to 0. - name  **Read-Only Fields**: - id
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>CategoryResponse</returns>
        CategoryResponse CreateCategory (Category body, string accept, string contentType);

        /// <summary>
        /// Create a Category
        /// </summary>
        /// <remarks>
        /// Creates a *Category*.  **Required Fields**: - parent_id:   - To create a child category, set the parent_id to the parent category.  - To create a top level category, set the parent_id to 0. - name  **Read-Only Fields**: - id
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>ApiResponse of CategoryResponse</returns>
        ApiResponse<CategoryResponse> CreateCategoryWithHttpInfo (Category body, string accept, string contentType);
        /// <summary>
        /// Delete Categories
        /// </summary>
        /// <remarks>
        /// By default, it deletes all *Category* objects. A filter should be added to avoid deleting all *Category* objects in a store.  Sending a &#x60;DELETE&#x60; to this endpoint will result in a &#x60;422&#x60; error. Move products to a new category by sending a &#x60;PUT&#x60; to the &#x60;/catalog/products/{product_id}&#x60; endpoint before deleting a category.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="name">Filter items by name.  (optional)</param>
        /// <param name="parentId">Filter items by parent_id. If the category is a child or sub category it can be filtered with the parent_id.  (optional)</param>
        /// <param name="pageTitle">Filter items by page_title.  (optional)</param>
        /// <param name="keyword">Filter items by keywords. eg. new, towel, bath (optional)</param>
        /// <param name="isVisible">Filter items by if visible on the storefront.  (optional)</param>
        /// <returns></returns>
        void DeleteCategories (string accept, string contentType, string name = null, int? parentId = null, string pageTitle = null, string keyword = null, bool? isVisible = null);

        /// <summary>
        /// Delete Categories
        /// </summary>
        /// <remarks>
        /// By default, it deletes all *Category* objects. A filter should be added to avoid deleting all *Category* objects in a store.  Sending a &#x60;DELETE&#x60; to this endpoint will result in a &#x60;422&#x60; error. Move products to a new category by sending a &#x60;PUT&#x60; to the &#x60;/catalog/products/{product_id}&#x60; endpoint before deleting a category.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="name">Filter items by name.  (optional)</param>
        /// <param name="parentId">Filter items by parent_id. If the category is a child or sub category it can be filtered with the parent_id.  (optional)</param>
        /// <param name="pageTitle">Filter items by page_title.  (optional)</param>
        /// <param name="keyword">Filter items by keywords. eg. new, towel, bath (optional)</param>
        /// <param name="isVisible">Filter items by if visible on the storefront.  (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteCategoriesWithHttpInfo (string accept, string contentType, string name = null, int? parentId = null, string pageTitle = null, string keyword = null, bool? isVisible = null);
        /// <summary>
        /// Delete a Category
        /// </summary>
        /// <remarks>
        /// Deletes a *Category*.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId">The ID of the &#x60;Category&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns></returns>
        void DeleteCategoryById (int? categoryId, string accept, string contentType);

        /// <summary>
        /// Delete a Category
        /// </summary>
        /// <remarks>
        /// Deletes a *Category*.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId">The ID of the &#x60;Category&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteCategoryByIdWithHttpInfo (int? categoryId, string accept, string contentType);
        /// <summary>
        /// Get All Categories
        /// </summary>
        /// <remarks>
        /// Returns a list of *Categories*. Optional filter parameters can be passed in.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="id">Filter items by id.  (optional)</param>
        /// <param name="idin"> (optional)</param>
        /// <param name="idnotIn"> (optional)</param>
        /// <param name="idmin"> (optional)</param>
        /// <param name="idmax"> (optional)</param>
        /// <param name="idgreater"> (optional)</param>
        /// <param name="idless"> (optional)</param>
        /// <param name="name">Filter items by name.  (optional)</param>
        /// <param name="parentId">Filter items by parent_id. If the category is a child or sub category it can be filtered with the parent_id.  (optional)</param>
        /// <param name="pageTitle">Filter items by page_title.  (optional)</param>
        /// <param name="keyword">Filter items by keywords. eg. new, towel, bath (optional)</param>
        /// <param name="isVisible">Filter items by if visible on the storefront.  (optional)</param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>CategoryBase</returns>
        CategoryBase GetCategories (string accept, string contentType, int? id = null, List<int?> idin = null, List<int?> idnotIn = null, List<int?> idmin = null, List<int?> idmax = null, List<int?> idgreater = null, List<int?> idless = null, string name = null, int? parentId = null, string pageTitle = null, string keyword = null, bool? isVisible = null, int? page = null, int? limit = null, string includeFields = null, string excludeFields = null);

        /// <summary>
        /// Get All Categories
        /// </summary>
        /// <remarks>
        /// Returns a list of *Categories*. Optional filter parameters can be passed in.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="id">Filter items by id.  (optional)</param>
        /// <param name="idin"> (optional)</param>
        /// <param name="idnotIn"> (optional)</param>
        /// <param name="idmin"> (optional)</param>
        /// <param name="idmax"> (optional)</param>
        /// <param name="idgreater"> (optional)</param>
        /// <param name="idless"> (optional)</param>
        /// <param name="name">Filter items by name.  (optional)</param>
        /// <param name="parentId">Filter items by parent_id. If the category is a child or sub category it can be filtered with the parent_id.  (optional)</param>
        /// <param name="pageTitle">Filter items by page_title.  (optional)</param>
        /// <param name="keyword">Filter items by keywords. eg. new, towel, bath (optional)</param>
        /// <param name="isVisible">Filter items by if visible on the storefront.  (optional)</param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>ApiResponse of CategoryBase</returns>
        ApiResponse<CategoryBase> GetCategoriesWithHttpInfo (string accept, string contentType, int? id = null, List<int?> idin = null, List<int?> idnotIn = null, List<int?> idmin = null, List<int?> idmax = null, List<int?> idgreater = null, List<int?> idless = null, string name = null, int? parentId = null, string pageTitle = null, string keyword = null, bool? isVisible = null, int? page = null, int? limit = null, string includeFields = null, string excludeFields = null);
        /// <summary>
        /// Get a Category
        /// </summary>
        /// <remarks>
        /// Returns a single *Category*. Optional parameters can be passed in.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId">The ID of the &#x60;Category&#x60; to which the resource belongs. </param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>CategoryResponse</returns>
        CategoryResponse GetCategoryById (int? categoryId, string includeFields = null, string excludeFields = null);

        /// <summary>
        /// Get a Category
        /// </summary>
        /// <remarks>
        /// Returns a single *Category*. Optional parameters can be passed in.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId">The ID of the &#x60;Category&#x60; to which the resource belongs. </param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>ApiResponse of CategoryResponse</returns>
        ApiResponse<CategoryResponse> GetCategoryByIdWithHttpInfo (int? categoryId, string includeFields = null, string excludeFields = null);
        /// <summary>
        /// Get Category Tree
        /// </summary>
        /// <remarks>
        /// Returns the categories tree, a nested lineage of the categories with parent-&gt;child relationship. The Category objects returned are simplified versions of the category objects returned in the rest of this API.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>CategoriesTreeResp1</returns>
        CategoriesTreeResp1 GetCategoryTree (string accept, string contentType);

        /// <summary>
        /// Get Category Tree
        /// </summary>
        /// <remarks>
        /// Returns the categories tree, a nested lineage of the categories with parent-&gt;child relationship. The Category objects returned are simplified versions of the category objects returned in the rest of this API.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>ApiResponse of CategoriesTreeResp1</returns>
        ApiResponse<CategoriesTreeResp1> GetCategoryTreeWithHttpInfo (string accept, string contentType);
        /// <summary>
        /// Update a Category
        /// </summary>
        /// <remarks>
        /// Updates a *Category*.  **Required Fields** * none  **Read-Only Fields** - id
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="categoryId">The ID of the &#x60;Category&#x60; to which the resource belongs. </param>
        /// <returns>CategoryResponse1</returns>
        CategoryResponse1 UpdateCategory (Category1 body, string accept, string contentType, int? categoryId);

        /// <summary>
        /// Update a Category
        /// </summary>
        /// <remarks>
        /// Updates a *Category*.  **Required Fields** * none  **Read-Only Fields** - id
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="categoryId">The ID of the &#x60;Category&#x60; to which the resource belongs. </param>
        /// <returns>ApiResponse of CategoryResponse1</returns>
        ApiResponse<CategoryResponse1> UpdateCategoryWithHttpInfo (Category1 body, string accept, string contentType, int? categoryId);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Create a Category
        /// </summary>
        /// <remarks>
        /// Creates a *Category*.  **Required Fields**: - parent_id:   - To create a child category, set the parent_id to the parent category.  - To create a top level category, set the parent_id to 0. - name  **Read-Only Fields**: - id
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>Task of CategoryResponse</returns>
        System.Threading.Tasks.Task<CategoryResponse> CreateCategoryAsync (Category body, string accept, string contentType);

        /// <summary>
        /// Create a Category
        /// </summary>
        /// <remarks>
        /// Creates a *Category*.  **Required Fields**: - parent_id:   - To create a child category, set the parent_id to the parent category.  - To create a top level category, set the parent_id to 0. - name  **Read-Only Fields**: - id
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>Task of ApiResponse (CategoryResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CategoryResponse>> CreateCategoryAsyncWithHttpInfo (Category body, string accept, string contentType);
        /// <summary>
        /// Delete Categories
        /// </summary>
        /// <remarks>
        /// By default, it deletes all *Category* objects. A filter should be added to avoid deleting all *Category* objects in a store.  Sending a &#x60;DELETE&#x60; to this endpoint will result in a &#x60;422&#x60; error. Move products to a new category by sending a &#x60;PUT&#x60; to the &#x60;/catalog/products/{product_id}&#x60; endpoint before deleting a category.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="name">Filter items by name.  (optional)</param>
        /// <param name="parentId">Filter items by parent_id. If the category is a child or sub category it can be filtered with the parent_id.  (optional)</param>
        /// <param name="pageTitle">Filter items by page_title.  (optional)</param>
        /// <param name="keyword">Filter items by keywords. eg. new, towel, bath (optional)</param>
        /// <param name="isVisible">Filter items by if visible on the storefront.  (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteCategoriesAsync (string accept, string contentType, string name = null, int? parentId = null, string pageTitle = null, string keyword = null, bool? isVisible = null);

        /// <summary>
        /// Delete Categories
        /// </summary>
        /// <remarks>
        /// By default, it deletes all *Category* objects. A filter should be added to avoid deleting all *Category* objects in a store.  Sending a &#x60;DELETE&#x60; to this endpoint will result in a &#x60;422&#x60; error. Move products to a new category by sending a &#x60;PUT&#x60; to the &#x60;/catalog/products/{product_id}&#x60; endpoint before deleting a category.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="name">Filter items by name.  (optional)</param>
        /// <param name="parentId">Filter items by parent_id. If the category is a child or sub category it can be filtered with the parent_id.  (optional)</param>
        /// <param name="pageTitle">Filter items by page_title.  (optional)</param>
        /// <param name="keyword">Filter items by keywords. eg. new, towel, bath (optional)</param>
        /// <param name="isVisible">Filter items by if visible on the storefront.  (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteCategoriesAsyncWithHttpInfo (string accept, string contentType, string name = null, int? parentId = null, string pageTitle = null, string keyword = null, bool? isVisible = null);
        /// <summary>
        /// Delete a Category
        /// </summary>
        /// <remarks>
        /// Deletes a *Category*.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId">The ID of the &#x60;Category&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteCategoryByIdAsync (int? categoryId, string accept, string contentType);

        /// <summary>
        /// Delete a Category
        /// </summary>
        /// <remarks>
        /// Deletes a *Category*.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId">The ID of the &#x60;Category&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteCategoryByIdAsyncWithHttpInfo (int? categoryId, string accept, string contentType);
        /// <summary>
        /// Get All Categories
        /// </summary>
        /// <remarks>
        /// Returns a list of *Categories*. Optional filter parameters can be passed in.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="id">Filter items by id.  (optional)</param>
        /// <param name="idin"> (optional)</param>
        /// <param name="idnotIn"> (optional)</param>
        /// <param name="idmin"> (optional)</param>
        /// <param name="idmax"> (optional)</param>
        /// <param name="idgreater"> (optional)</param>
        /// <param name="idless"> (optional)</param>
        /// <param name="name">Filter items by name.  (optional)</param>
        /// <param name="parentId">Filter items by parent_id. If the category is a child or sub category it can be filtered with the parent_id.  (optional)</param>
        /// <param name="pageTitle">Filter items by page_title.  (optional)</param>
        /// <param name="keyword">Filter items by keywords. eg. new, towel, bath (optional)</param>
        /// <param name="isVisible">Filter items by if visible on the storefront.  (optional)</param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of CategoryBase</returns>
        System.Threading.Tasks.Task<CategoryBase> GetCategoriesAsync (string accept, string contentType, int? id = null, List<int?> idin = null, List<int?> idnotIn = null, List<int?> idmin = null, List<int?> idmax = null, List<int?> idgreater = null, List<int?> idless = null, string name = null, int? parentId = null, string pageTitle = null, string keyword = null, bool? isVisible = null, int? page = null, int? limit = null, string includeFields = null, string excludeFields = null);

        /// <summary>
        /// Get All Categories
        /// </summary>
        /// <remarks>
        /// Returns a list of *Categories*. Optional filter parameters can be passed in.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="id">Filter items by id.  (optional)</param>
        /// <param name="idin"> (optional)</param>
        /// <param name="idnotIn"> (optional)</param>
        /// <param name="idmin"> (optional)</param>
        /// <param name="idmax"> (optional)</param>
        /// <param name="idgreater"> (optional)</param>
        /// <param name="idless"> (optional)</param>
        /// <param name="name">Filter items by name.  (optional)</param>
        /// <param name="parentId">Filter items by parent_id. If the category is a child or sub category it can be filtered with the parent_id.  (optional)</param>
        /// <param name="pageTitle">Filter items by page_title.  (optional)</param>
        /// <param name="keyword">Filter items by keywords. eg. new, towel, bath (optional)</param>
        /// <param name="isVisible">Filter items by if visible on the storefront.  (optional)</param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of ApiResponse (CategoryBase)</returns>
        System.Threading.Tasks.Task<ApiResponse<CategoryBase>> GetCategoriesAsyncWithHttpInfo (string accept, string contentType, int? id = null, List<int?> idin = null, List<int?> idnotIn = null, List<int?> idmin = null, List<int?> idmax = null, List<int?> idgreater = null, List<int?> idless = null, string name = null, int? parentId = null, string pageTitle = null, string keyword = null, bool? isVisible = null, int? page = null, int? limit = null, string includeFields = null, string excludeFields = null);
        /// <summary>
        /// Get a Category
        /// </summary>
        /// <remarks>
        /// Returns a single *Category*. Optional parameters can be passed in.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId">The ID of the &#x60;Category&#x60; to which the resource belongs. </param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of CategoryResponse</returns>
        System.Threading.Tasks.Task<CategoryResponse> GetCategoryByIdAsync (int? categoryId, string includeFields = null, string excludeFields = null);

        /// <summary>
        /// Get a Category
        /// </summary>
        /// <remarks>
        /// Returns a single *Category*. Optional parameters can be passed in.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId">The ID of the &#x60;Category&#x60; to which the resource belongs. </param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of ApiResponse (CategoryResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CategoryResponse>> GetCategoryByIdAsyncWithHttpInfo (int? categoryId, string includeFields = null, string excludeFields = null);
        /// <summary>
        /// Get Category Tree
        /// </summary>
        /// <remarks>
        /// Returns the categories tree, a nested lineage of the categories with parent-&gt;child relationship. The Category objects returned are simplified versions of the category objects returned in the rest of this API.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>Task of CategoriesTreeResp1</returns>
        System.Threading.Tasks.Task<CategoriesTreeResp1> GetCategoryTreeAsync (string accept, string contentType);

        /// <summary>
        /// Get Category Tree
        /// </summary>
        /// <remarks>
        /// Returns the categories tree, a nested lineage of the categories with parent-&gt;child relationship. The Category objects returned are simplified versions of the category objects returned in the rest of this API.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>Task of ApiResponse (CategoriesTreeResp1)</returns>
        System.Threading.Tasks.Task<ApiResponse<CategoriesTreeResp1>> GetCategoryTreeAsyncWithHttpInfo (string accept, string contentType);
        /// <summary>
        /// Update a Category
        /// </summary>
        /// <remarks>
        /// Updates a *Category*.  **Required Fields** * none  **Read-Only Fields** - id
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="categoryId">The ID of the &#x60;Category&#x60; to which the resource belongs. </param>
        /// <returns>Task of CategoryResponse1</returns>
        System.Threading.Tasks.Task<CategoryResponse1> UpdateCategoryAsync (Category1 body, string accept, string contentType, int? categoryId);

        /// <summary>
        /// Update a Category
        /// </summary>
        /// <remarks>
        /// Updates a *Category*.  **Required Fields** * none  **Read-Only Fields** - id
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="categoryId">The ID of the &#x60;Category&#x60; to which the resource belongs. </param>
        /// <returns>Task of ApiResponse (CategoryResponse1)</returns>
        System.Threading.Tasks.Task<ApiResponse<CategoryResponse1>> UpdateCategoryAsyncWithHttpInfo (Category1 body, string accept, string contentType, int? categoryId);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public partial class CategoryApi : ICategoryApi
    {
        private Catalog.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CategoryApi(String basePath)
        {
            this.Configuration = new Catalog.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Catalog.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryApi"/> class
        /// </summary>
        /// <returns></returns>
        public CategoryApi()
        {
            this.Configuration = Catalog.Client.Configuration.Default;

            ExceptionFactory = Catalog.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CategoryApi(Catalog.Client.Configuration configuration = null)
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
        /// Create a Category Creates a *Category*.  **Required Fields**: - parent_id:   - To create a child category, set the parent_id to the parent category.  - To create a top level category, set the parent_id to 0. - name  **Read-Only Fields**: - id
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>CategoryResponse</returns>
        public CategoryResponse CreateCategory (Category body, string accept, string contentType)
        {
             ApiResponse<CategoryResponse> localVarResponse = CreateCategoryWithHttpInfo(body, accept, contentType);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a Category Creates a *Category*.  **Required Fields**: - parent_id:   - To create a child category, set the parent_id to the parent category.  - To create a top level category, set the parent_id to 0. - name  **Read-Only Fields**: - id
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>ApiResponse of CategoryResponse</returns>
        public ApiResponse< CategoryResponse > CreateCategoryWithHttpInfo (Category body, string accept, string contentType)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling CategoryApi->CreateCategory");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling CategoryApi->CreateCategory");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling CategoryApi->CreateCategory");

            var localVarPath = "/catalog/categories";
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateCategory", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CategoryResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (CategoryResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CategoryResponse)));
        }

        /// <summary>
        /// Create a Category Creates a *Category*.  **Required Fields**: - parent_id:   - To create a child category, set the parent_id to the parent category.  - To create a top level category, set the parent_id to 0. - name  **Read-Only Fields**: - id
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>Task of CategoryResponse</returns>
        public async System.Threading.Tasks.Task<CategoryResponse> CreateCategoryAsync (Category body, string accept, string contentType)
        {
             ApiResponse<CategoryResponse> localVarResponse = await CreateCategoryAsyncWithHttpInfo(body, accept, contentType);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a Category Creates a *Category*.  **Required Fields**: - parent_id:   - To create a child category, set the parent_id to the parent category.  - To create a top level category, set the parent_id to 0. - name  **Read-Only Fields**: - id
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>Task of ApiResponse (CategoryResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CategoryResponse>> CreateCategoryAsyncWithHttpInfo (Category body, string accept, string contentType)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling CategoryApi->CreateCategory");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling CategoryApi->CreateCategory");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling CategoryApi->CreateCategory");

            var localVarPath = "/catalog/categories";
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateCategory", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CategoryResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (CategoryResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CategoryResponse)));
        }

        /// <summary>
        /// Delete Categories By default, it deletes all *Category* objects. A filter should be added to avoid deleting all *Category* objects in a store.  Sending a &#x60;DELETE&#x60; to this endpoint will result in a &#x60;422&#x60; error. Move products to a new category by sending a &#x60;PUT&#x60; to the &#x60;/catalog/products/{product_id}&#x60; endpoint before deleting a category.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="name">Filter items by name.  (optional)</param>
        /// <param name="parentId">Filter items by parent_id. If the category is a child or sub category it can be filtered with the parent_id.  (optional)</param>
        /// <param name="pageTitle">Filter items by page_title.  (optional)</param>
        /// <param name="keyword">Filter items by keywords. eg. new, towel, bath (optional)</param>
        /// <param name="isVisible">Filter items by if visible on the storefront.  (optional)</param>
        /// <returns></returns>
        public void DeleteCategories (string accept, string contentType, string name = null, int? parentId = null, string pageTitle = null, string keyword = null, bool? isVisible = null)
        {
             DeleteCategoriesWithHttpInfo(accept, contentType, name, parentId, pageTitle, keyword, isVisible);
        }

        /// <summary>
        /// Delete Categories By default, it deletes all *Category* objects. A filter should be added to avoid deleting all *Category* objects in a store.  Sending a &#x60;DELETE&#x60; to this endpoint will result in a &#x60;422&#x60; error. Move products to a new category by sending a &#x60;PUT&#x60; to the &#x60;/catalog/products/{product_id}&#x60; endpoint before deleting a category.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="name">Filter items by name.  (optional)</param>
        /// <param name="parentId">Filter items by parent_id. If the category is a child or sub category it can be filtered with the parent_id.  (optional)</param>
        /// <param name="pageTitle">Filter items by page_title.  (optional)</param>
        /// <param name="keyword">Filter items by keywords. eg. new, towel, bath (optional)</param>
        /// <param name="isVisible">Filter items by if visible on the storefront.  (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteCategoriesWithHttpInfo (string accept, string contentType, string name = null, int? parentId = null, string pageTitle = null, string keyword = null, bool? isVisible = null)
        {
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling CategoryApi->DeleteCategories");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling CategoryApi->DeleteCategories");

            var localVarPath = "/catalog/categories";
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
            if (parentId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "parent_id", parentId)); // query parameter
            if (pageTitle != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page_title", pageTitle)); // query parameter
            if (keyword != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "keyword", keyword)); // query parameter
            if (isVisible != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "is_visible", isVisible)); // query parameter
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
                Exception exception = ExceptionFactory("DeleteCategories", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Delete Categories By default, it deletes all *Category* objects. A filter should be added to avoid deleting all *Category* objects in a store.  Sending a &#x60;DELETE&#x60; to this endpoint will result in a &#x60;422&#x60; error. Move products to a new category by sending a &#x60;PUT&#x60; to the &#x60;/catalog/products/{product_id}&#x60; endpoint before deleting a category.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="name">Filter items by name.  (optional)</param>
        /// <param name="parentId">Filter items by parent_id. If the category is a child or sub category it can be filtered with the parent_id.  (optional)</param>
        /// <param name="pageTitle">Filter items by page_title.  (optional)</param>
        /// <param name="keyword">Filter items by keywords. eg. new, towel, bath (optional)</param>
        /// <param name="isVisible">Filter items by if visible on the storefront.  (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteCategoriesAsync (string accept, string contentType, string name = null, int? parentId = null, string pageTitle = null, string keyword = null, bool? isVisible = null)
        {
             await DeleteCategoriesAsyncWithHttpInfo(accept, contentType, name, parentId, pageTitle, keyword, isVisible);

        }

        /// <summary>
        /// Delete Categories By default, it deletes all *Category* objects. A filter should be added to avoid deleting all *Category* objects in a store.  Sending a &#x60;DELETE&#x60; to this endpoint will result in a &#x60;422&#x60; error. Move products to a new category by sending a &#x60;PUT&#x60; to the &#x60;/catalog/products/{product_id}&#x60; endpoint before deleting a category.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="name">Filter items by name.  (optional)</param>
        /// <param name="parentId">Filter items by parent_id. If the category is a child or sub category it can be filtered with the parent_id.  (optional)</param>
        /// <param name="pageTitle">Filter items by page_title.  (optional)</param>
        /// <param name="keyword">Filter items by keywords. eg. new, towel, bath (optional)</param>
        /// <param name="isVisible">Filter items by if visible on the storefront.  (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteCategoriesAsyncWithHttpInfo (string accept, string contentType, string name = null, int? parentId = null, string pageTitle = null, string keyword = null, bool? isVisible = null)
        {
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling CategoryApi->DeleteCategories");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling CategoryApi->DeleteCategories");

            var localVarPath = "/catalog/categories";
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
            if (parentId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "parent_id", parentId)); // query parameter
            if (pageTitle != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page_title", pageTitle)); // query parameter
            if (keyword != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "keyword", keyword)); // query parameter
            if (isVisible != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "is_visible", isVisible)); // query parameter
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
                Exception exception = ExceptionFactory("DeleteCategories", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Delete a Category Deletes a *Category*.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId">The ID of the &#x60;Category&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns></returns>
        public void DeleteCategoryById (int? categoryId, string accept, string contentType)
        {
             DeleteCategoryByIdWithHttpInfo(categoryId, accept, contentType);
        }

        /// <summary>
        /// Delete a Category Deletes a *Category*.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId">The ID of the &#x60;Category&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteCategoryByIdWithHttpInfo (int? categoryId, string accept, string contentType)
        {
            // verify the required parameter 'categoryId' is set
            if (categoryId == null)
                throw new ApiException(400, "Missing required parameter 'categoryId' when calling CategoryApi->DeleteCategoryById");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling CategoryApi->DeleteCategoryById");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling CategoryApi->DeleteCategoryById");

            var localVarPath = "/catalog/categories/{category_id}";
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

            if (categoryId != null) localVarPathParams.Add("category_id", this.Configuration.ApiClient.ParameterToString(categoryId)); // path parameter
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
                Exception exception = ExceptionFactory("DeleteCategoryById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Delete a Category Deletes a *Category*.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId">The ID of the &#x60;Category&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteCategoryByIdAsync (int? categoryId, string accept, string contentType)
        {
             await DeleteCategoryByIdAsyncWithHttpInfo(categoryId, accept, contentType);

        }

        /// <summary>
        /// Delete a Category Deletes a *Category*.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId">The ID of the &#x60;Category&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteCategoryByIdAsyncWithHttpInfo (int? categoryId, string accept, string contentType)
        {
            // verify the required parameter 'categoryId' is set
            if (categoryId == null)
                throw new ApiException(400, "Missing required parameter 'categoryId' when calling CategoryApi->DeleteCategoryById");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling CategoryApi->DeleteCategoryById");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling CategoryApi->DeleteCategoryById");

            var localVarPath = "/catalog/categories/{category_id}";
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

            if (categoryId != null) localVarPathParams.Add("category_id", this.Configuration.ApiClient.ParameterToString(categoryId)); // path parameter
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
                Exception exception = ExceptionFactory("DeleteCategoryById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Get All Categories Returns a list of *Categories*. Optional filter parameters can be passed in.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="id">Filter items by id.  (optional)</param>
        /// <param name="idin"> (optional)</param>
        /// <param name="idnotIn"> (optional)</param>
        /// <param name="idmin"> (optional)</param>
        /// <param name="idmax"> (optional)</param>
        /// <param name="idgreater"> (optional)</param>
        /// <param name="idless"> (optional)</param>
        /// <param name="name">Filter items by name.  (optional)</param>
        /// <param name="parentId">Filter items by parent_id. If the category is a child or sub category it can be filtered with the parent_id.  (optional)</param>
        /// <param name="pageTitle">Filter items by page_title.  (optional)</param>
        /// <param name="keyword">Filter items by keywords. eg. new, towel, bath (optional)</param>
        /// <param name="isVisible">Filter items by if visible on the storefront.  (optional)</param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>CategoryBase</returns>
        public CategoryBase GetCategories (string accept, string contentType, int? id = null, List<int?> idin = null, List<int?> idnotIn = null, List<int?> idmin = null, List<int?> idmax = null, List<int?> idgreater = null, List<int?> idless = null, string name = null, int? parentId = null, string pageTitle = null, string keyword = null, bool? isVisible = null, int? page = null, int? limit = null, string includeFields = null, string excludeFields = null)
        {
             ApiResponse<CategoryBase> localVarResponse = GetCategoriesWithHttpInfo(accept, contentType, id, idin, idnotIn, idmin, idmax, idgreater, idless, name, parentId, pageTitle, keyword, isVisible, page, limit, includeFields, excludeFields);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get All Categories Returns a list of *Categories*. Optional filter parameters can be passed in.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="id">Filter items by id.  (optional)</param>
        /// <param name="idin"> (optional)</param>
        /// <param name="idnotIn"> (optional)</param>
        /// <param name="idmin"> (optional)</param>
        /// <param name="idmax"> (optional)</param>
        /// <param name="idgreater"> (optional)</param>
        /// <param name="idless"> (optional)</param>
        /// <param name="name">Filter items by name.  (optional)</param>
        /// <param name="parentId">Filter items by parent_id. If the category is a child or sub category it can be filtered with the parent_id.  (optional)</param>
        /// <param name="pageTitle">Filter items by page_title.  (optional)</param>
        /// <param name="keyword">Filter items by keywords. eg. new, towel, bath (optional)</param>
        /// <param name="isVisible">Filter items by if visible on the storefront.  (optional)</param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>ApiResponse of CategoryBase</returns>
        public ApiResponse< CategoryBase > GetCategoriesWithHttpInfo (string accept, string contentType, int? id = null, List<int?> idin = null, List<int?> idnotIn = null, List<int?> idmin = null, List<int?> idmax = null, List<int?> idgreater = null, List<int?> idless = null, string name = null, int? parentId = null, string pageTitle = null, string keyword = null, bool? isVisible = null, int? page = null, int? limit = null, string includeFields = null, string excludeFields = null)
        {
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling CategoryApi->GetCategories");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling CategoryApi->GetCategories");

            var localVarPath = "/catalog/categories";
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
            if (parentId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "parent_id", parentId)); // query parameter
            if (pageTitle != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page_title", pageTitle)); // query parameter
            if (keyword != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "keyword", keyword)); // query parameter
            if (isVisible != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "is_visible", isVisible)); // query parameter
            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter
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
                Exception exception = ExceptionFactory("GetCategories", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CategoryBase>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (CategoryBase) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CategoryBase)));
        }

        /// <summary>
        /// Get All Categories Returns a list of *Categories*. Optional filter parameters can be passed in.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="id">Filter items by id.  (optional)</param>
        /// <param name="idin"> (optional)</param>
        /// <param name="idnotIn"> (optional)</param>
        /// <param name="idmin"> (optional)</param>
        /// <param name="idmax"> (optional)</param>
        /// <param name="idgreater"> (optional)</param>
        /// <param name="idless"> (optional)</param>
        /// <param name="name">Filter items by name.  (optional)</param>
        /// <param name="parentId">Filter items by parent_id. If the category is a child or sub category it can be filtered with the parent_id.  (optional)</param>
        /// <param name="pageTitle">Filter items by page_title.  (optional)</param>
        /// <param name="keyword">Filter items by keywords. eg. new, towel, bath (optional)</param>
        /// <param name="isVisible">Filter items by if visible on the storefront.  (optional)</param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of CategoryBase</returns>
        public async System.Threading.Tasks.Task<CategoryBase> GetCategoriesAsync (string accept, string contentType, int? id = null, List<int?> idin = null, List<int?> idnotIn = null, List<int?> idmin = null, List<int?> idmax = null, List<int?> idgreater = null, List<int?> idless = null, string name = null, int? parentId = null, string pageTitle = null, string keyword = null, bool? isVisible = null, int? page = null, int? limit = null, string includeFields = null, string excludeFields = null)
        {
             ApiResponse<CategoryBase> localVarResponse = await GetCategoriesAsyncWithHttpInfo(accept, contentType, id, idin, idnotIn, idmin, idmax, idgreater, idless, name, parentId, pageTitle, keyword, isVisible, page, limit, includeFields, excludeFields);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get All Categories Returns a list of *Categories*. Optional filter parameters can be passed in.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="id">Filter items by id.  (optional)</param>
        /// <param name="idin"> (optional)</param>
        /// <param name="idnotIn"> (optional)</param>
        /// <param name="idmin"> (optional)</param>
        /// <param name="idmax"> (optional)</param>
        /// <param name="idgreater"> (optional)</param>
        /// <param name="idless"> (optional)</param>
        /// <param name="name">Filter items by name.  (optional)</param>
        /// <param name="parentId">Filter items by parent_id. If the category is a child or sub category it can be filtered with the parent_id.  (optional)</param>
        /// <param name="pageTitle">Filter items by page_title.  (optional)</param>
        /// <param name="keyword">Filter items by keywords. eg. new, towel, bath (optional)</param>
        /// <param name="isVisible">Filter items by if visible on the storefront.  (optional)</param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of ApiResponse (CategoryBase)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CategoryBase>> GetCategoriesAsyncWithHttpInfo (string accept, string contentType, int? id = null, List<int?> idin = null, List<int?> idnotIn = null, List<int?> idmin = null, List<int?> idmax = null, List<int?> idgreater = null, List<int?> idless = null, string name = null, int? parentId = null, string pageTitle = null, string keyword = null, bool? isVisible = null, int? page = null, int? limit = null, string includeFields = null, string excludeFields = null)
        {
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling CategoryApi->GetCategories");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling CategoryApi->GetCategories");

            var localVarPath = "/catalog/categories";
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
            if (parentId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "parent_id", parentId)); // query parameter
            if (pageTitle != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page_title", pageTitle)); // query parameter
            if (keyword != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "keyword", keyword)); // query parameter
            if (isVisible != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "is_visible", isVisible)); // query parameter
            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter
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
                Exception exception = ExceptionFactory("GetCategories", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CategoryBase>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (CategoryBase) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CategoryBase)));
        }

        /// <summary>
        /// Get a Category Returns a single *Category*. Optional parameters can be passed in.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId">The ID of the &#x60;Category&#x60; to which the resource belongs. </param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>CategoryResponse</returns>
        public CategoryResponse GetCategoryById (int? categoryId, string includeFields = null, string excludeFields = null)
        {
             ApiResponse<CategoryResponse> localVarResponse = GetCategoryByIdWithHttpInfo(categoryId, includeFields, excludeFields);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Category Returns a single *Category*. Optional parameters can be passed in.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId">The ID of the &#x60;Category&#x60; to which the resource belongs. </param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>ApiResponse of CategoryResponse</returns>
        public ApiResponse< CategoryResponse > GetCategoryByIdWithHttpInfo (int? categoryId, string includeFields = null, string excludeFields = null)
        {
            // verify the required parameter 'categoryId' is set
            if (categoryId == null)
                throw new ApiException(400, "Missing required parameter 'categoryId' when calling CategoryApi->GetCategoryById");

            var localVarPath = "/catalog/categories/{category_id}";
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

            if (categoryId != null) localVarPathParams.Add("category_id", this.Configuration.ApiClient.ParameterToString(categoryId)); // path parameter
            if (includeFields != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "include_fields", includeFields)); // query parameter
            if (excludeFields != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "exclude_fields", excludeFields)); // query parameter
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
                Exception exception = ExceptionFactory("GetCategoryById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CategoryResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (CategoryResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CategoryResponse)));
        }

        /// <summary>
        /// Get a Category Returns a single *Category*. Optional parameters can be passed in.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId">The ID of the &#x60;Category&#x60; to which the resource belongs. </param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of CategoryResponse</returns>
        public async System.Threading.Tasks.Task<CategoryResponse> GetCategoryByIdAsync (int? categoryId, string includeFields = null, string excludeFields = null)
        {
             ApiResponse<CategoryResponse> localVarResponse = await GetCategoryByIdAsyncWithHttpInfo(categoryId, includeFields, excludeFields);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a Category Returns a single *Category*. Optional parameters can be passed in.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="categoryId">The ID of the &#x60;Category&#x60; to which the resource belongs. </param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of ApiResponse (CategoryResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CategoryResponse>> GetCategoryByIdAsyncWithHttpInfo (int? categoryId, string includeFields = null, string excludeFields = null)
        {
            // verify the required parameter 'categoryId' is set
            if (categoryId == null)
                throw new ApiException(400, "Missing required parameter 'categoryId' when calling CategoryApi->GetCategoryById");

            var localVarPath = "/catalog/categories/{category_id}";
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

            if (categoryId != null) localVarPathParams.Add("category_id", this.Configuration.ApiClient.ParameterToString(categoryId)); // path parameter
            if (includeFields != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "include_fields", includeFields)); // query parameter
            if (excludeFields != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "exclude_fields", excludeFields)); // query parameter
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
                Exception exception = ExceptionFactory("GetCategoryById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CategoryResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (CategoryResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CategoryResponse)));
        }

        /// <summary>
        /// Get Category Tree Returns the categories tree, a nested lineage of the categories with parent-&gt;child relationship. The Category objects returned are simplified versions of the category objects returned in the rest of this API.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>CategoriesTreeResp1</returns>
        public CategoriesTreeResp1 GetCategoryTree (string accept, string contentType)
        {
             ApiResponse<CategoriesTreeResp1> localVarResponse = GetCategoryTreeWithHttpInfo(accept, contentType);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Category Tree Returns the categories tree, a nested lineage of the categories with parent-&gt;child relationship. The Category objects returned are simplified versions of the category objects returned in the rest of this API.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>ApiResponse of CategoriesTreeResp1</returns>
        public ApiResponse< CategoriesTreeResp1 > GetCategoryTreeWithHttpInfo (string accept, string contentType)
        {
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling CategoryApi->GetCategoryTree");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling CategoryApi->GetCategoryTree");

            var localVarPath = "/catalog/categories/tree";
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
                Exception exception = ExceptionFactory("GetCategoryTree", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CategoriesTreeResp1>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (CategoriesTreeResp1) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CategoriesTreeResp1)));
        }

        /// <summary>
        /// Get Category Tree Returns the categories tree, a nested lineage of the categories with parent-&gt;child relationship. The Category objects returned are simplified versions of the category objects returned in the rest of this API.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>Task of CategoriesTreeResp1</returns>
        public async System.Threading.Tasks.Task<CategoriesTreeResp1> GetCategoryTreeAsync (string accept, string contentType)
        {
             ApiResponse<CategoriesTreeResp1> localVarResponse = await GetCategoryTreeAsyncWithHttpInfo(accept, contentType);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Category Tree Returns the categories tree, a nested lineage of the categories with parent-&gt;child relationship. The Category objects returned are simplified versions of the category objects returned in the rest of this API.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>Task of ApiResponse (CategoriesTreeResp1)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CategoriesTreeResp1>> GetCategoryTreeAsyncWithHttpInfo (string accept, string contentType)
        {
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling CategoryApi->GetCategoryTree");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling CategoryApi->GetCategoryTree");

            var localVarPath = "/catalog/categories/tree";
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
                Exception exception = ExceptionFactory("GetCategoryTree", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CategoriesTreeResp1>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (CategoriesTreeResp1) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CategoriesTreeResp1)));
        }

        /// <summary>
        /// Update a Category Updates a *Category*.  **Required Fields** * none  **Read-Only Fields** - id
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="categoryId">The ID of the &#x60;Category&#x60; to which the resource belongs. </param>
        /// <returns>CategoryResponse1</returns>
        public CategoryResponse1 UpdateCategory (Category1 body, string accept, string contentType, int? categoryId)
        {
             ApiResponse<CategoryResponse1> localVarResponse = UpdateCategoryWithHttpInfo(body, accept, contentType, categoryId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a Category Updates a *Category*.  **Required Fields** * none  **Read-Only Fields** - id
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="categoryId">The ID of the &#x60;Category&#x60; to which the resource belongs. </param>
        /// <returns>ApiResponse of CategoryResponse1</returns>
        public ApiResponse< CategoryResponse1 > UpdateCategoryWithHttpInfo (Category1 body, string accept, string contentType, int? categoryId)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling CategoryApi->UpdateCategory");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling CategoryApi->UpdateCategory");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling CategoryApi->UpdateCategory");
            // verify the required parameter 'categoryId' is set
            if (categoryId == null)
                throw new ApiException(400, "Missing required parameter 'categoryId' when calling CategoryApi->UpdateCategory");

            var localVarPath = "/catalog/categories/{category_id}";
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

            if (categoryId != null) localVarPathParams.Add("category_id", this.Configuration.ApiClient.ParameterToString(categoryId)); // path parameter
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
                Exception exception = ExceptionFactory("UpdateCategory", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CategoryResponse1>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (CategoryResponse1) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CategoryResponse1)));
        }

        /// <summary>
        /// Update a Category Updates a *Category*.  **Required Fields** * none  **Read-Only Fields** - id
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="categoryId">The ID of the &#x60;Category&#x60; to which the resource belongs. </param>
        /// <returns>Task of CategoryResponse1</returns>
        public async System.Threading.Tasks.Task<CategoryResponse1> UpdateCategoryAsync (Category1 body, string accept, string contentType, int? categoryId)
        {
             ApiResponse<CategoryResponse1> localVarResponse = await UpdateCategoryAsyncWithHttpInfo(body, accept, contentType, categoryId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a Category Updates a *Category*.  **Required Fields** * none  **Read-Only Fields** - id
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="categoryId">The ID of the &#x60;Category&#x60; to which the resource belongs. </param>
        /// <returns>Task of ApiResponse (CategoryResponse1)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CategoryResponse1>> UpdateCategoryAsyncWithHttpInfo (Category1 body, string accept, string contentType, int? categoryId)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling CategoryApi->UpdateCategory");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling CategoryApi->UpdateCategory");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling CategoryApi->UpdateCategory");
            // verify the required parameter 'categoryId' is set
            if (categoryId == null)
                throw new ApiException(400, "Missing required parameter 'categoryId' when calling CategoryApi->UpdateCategory");

            var localVarPath = "/catalog/categories/{category_id}";
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

            if (categoryId != null) localVarPathParams.Add("category_id", this.Configuration.ApiClient.ParameterToString(categoryId)); // path parameter
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
                Exception exception = ExceptionFactory("UpdateCategory", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CategoryResponse1>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (CategoryResponse1) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(CategoryResponse1)));
        }

    }
}
