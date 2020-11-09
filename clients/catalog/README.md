# BigCommerce - the C# library for the Catalog

Manage products, brands and categories. To learn more about catalog resources see [Catalog Overview](https://developer.bigcommerce.com/api-docs/catalog/products-overview).  - [Authentication](#authentication) - [Differentiating Variants & Modifiers](#variants-and-modifiers) - [Available Endpoints](#available-endpoints) - [Resources](#resources)  ## Authentication Requests can be authenticated by sending an `access_token` via `X-Auth-Token` HTTP header:  ```http GET /stores/{$$.env.store_hash}/v3/catalog/summary host: api.bigcommerce.com Accept: application/json X-Auth-Token: {access_token} ```  |Header|Parameter|Description| |-|-|-| |`X-Auth-Token`|`access_token `|Obtained by creating an API account or installing an app in a BigCommerce control panel.|  ### OAuth Scopes | UI Name  | Permission | Parameter                     | |- -- -- -- -- -|- -- -- -- -- -- -|- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --| | Products | modify     | `store_v2_products`           | | Products | read-only  | `store_v2_products_read_only` |  For more information on OAuth Scopes, see: [Authentication](https://developer.bigcommerce.com/api-docs/getting-started/authentication).  For more information on Authenticating BigCommerce APIs, see: [Authentication](https://developer.bigcommerce.com/api-docs/getting-started/authentication).  ## Differentiating Variants and Modifiers [Variants](https://support.bigcommerce.com/s/article/Product-Options-v3#variations) represent a physical product made up of [Product Option](https://support.bigcommerce.com/s/article/Product-Options-v3) choices, i.e. a large blue t-shirt. Each variant can have a unique SKU.  Modifiers represent a choice a customer makes about a product that doesn't represent a physical item, i.e. text to be printed on a t-shirt. Assigning a SKU to a modifier will turn it into a variant.  See [Variant Options](https://developer.bigcommerce.com/api-docs/catalog/products-overview#variant-options) and [Modifier Options](https://developer.bigcommerce.com/api-docs/catalog/products-overview#modifier-options) for more information.  ## Available Endpoints | Resource / Endpoint                     | Description                                                             | |- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --|- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --| | Brand Images                            | Create and manage brand images                                          | | Brand Metafields                        | Create and manage brand metafields                                      | | Brands                                  | Create and manage brands                                                | | Catalog                                 | Create and manage store categories, products, and brands                | | Categories                              | Create and manage categorties                                           | | Category Images                         | Create and manage category images                                       | | Category Metafields                     | Create and manage category metafields                                   | | Product Bulk Pricing Rules              | Create and manage product bulk pricing rules                            | | Product Complex Rules                   | Create and manage product complex rules                                 | | Product Custom Fields                   | Create and manage product custom fields                                 | | Product Images                          | Create and manage product images                                        | | Product Metafields                      | Create and manage product meta fields                                   | | Product Modifier Images                 | Create and manage product modifer images                                | | Product Modifier Values                 | Create and manage product modifier values                               | | Product Modifiers                       | Create and manage product midifiers                                     | | Product Reviews                         | Create and manage product reviews                                       | | Product Variant Option Values           | Create and manage product variant option values                         | | Product Variant Options                 | Create and manage product variant options                               | | Product Variants                        | Create and manage product variants                                      | | Product Videos                          | Create and manage product videos                                        | | Products                                | Create and manage products                                              | | ProductVariant Metafields               | Create and manage product meta flields                                  | | Variants                                | Get and update all variants                                             |  ## Resources  ### Webhooks * [Products](/api-docs/getting-started/webhooks/webhook-events#webhook-events_products) * [Categories](/api-docs/getting-started/webhooks/webhook-events#webhook-events_category) * [SKU](/api-docs/getting-started/webhooks/webhook-events#webhook-events_sku)  ### Related Endpoints * [Catalog API](/api-reference/catalog/catalog-api)

This C# SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: 1.0.0
- SDK version: 1.0.0
- Build package: io.swagger.codegen.v3.generators.dotnet.CSharpClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using BigCommerce.Api;
using BigCommerce.Client;
using BigCommerce.Model;
```
<a name="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out BigCommerce.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using BigCommerce.Api;
using BigCommerce.Client;
using BigCommerce.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.ApiKey.Add("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-Auth-Token", "Bearer");

            var apiInstance = new BrandImagesApi();
            var brandId = 56;  // int? | The ID of the `Brand` to which the resource belongs. 
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)
            var imageFile = imageFile_example;  // byte[] |  (optional) 

            try
            {
                // Create a Brand Image
                InlineResponse200 result = apiInstance.CreateBrandImage(brandId, accept, contentType, imageFile);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BrandImagesApi.CreateBrandImage: " + e.Message );
            }
        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.bigcommerce.com/stores/{$$.env.store_hash}/v3*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*BrandImagesApi* | [**CreateBrandImage**](docs/BrandImagesApi.md#createbrandimage) | **POST** /catalog/brands/{brand_id}/image | Create a Brand Image
*BrandImagesApi* | [**DeleteBrandImage**](docs/BrandImagesApi.md#deletebrandimage) | **DELETE** /catalog/brands/{brand_id}/image | Delete a Brand Image
*BrandMetafieldsApi* | [**CreateBrandMetafield**](docs/BrandMetafieldsApi.md#createbrandmetafield) | **POST** /catalog/brands/{brand_id}/metafields | Create a Brand Metafield
*BrandMetafieldsApi* | [**DeleteBrandMetafieldById**](docs/BrandMetafieldsApi.md#deletebrandmetafieldbyid) | **DELETE** /catalog/brands/{brand_id}/metafields/{metafield_id} | Delete a Brand Metafield
*BrandMetafieldsApi* | [**GetBrandMetafieldByBrandId**](docs/BrandMetafieldsApi.md#getbrandmetafieldbybrandid) | **GET** /catalog/brands/{brand_id}/metafields/{metafield_id} | Get a Brand Metafields
*BrandMetafieldsApi* | [**GetBrandMetafieldsByBrandId**](docs/BrandMetafieldsApi.md#getbrandmetafieldsbybrandid) | **GET** /catalog/brands/{brand_id}/metafields | Get All Brand Metafields
*BrandMetafieldsApi* | [**UpdateBrandMetafield**](docs/BrandMetafieldsApi.md#updatebrandmetafield) | **PUT** /catalog/brands/{brand_id}/metafields/{metafield_id} | Update a Brand Metafield
*BrandsApi* | [**CreateBrand**](docs/BrandsApi.md#createbrand) | **POST** /catalog/brands | Create a Brand
*BrandsApi* | [**DeleteBrandById**](docs/BrandsApi.md#deletebrandbyid) | **DELETE** /catalog/brands/{brand_id} | Delete a Brand
*BrandsApi* | [**DeleteBrands**](docs/BrandsApi.md#deletebrands) | **DELETE** /catalog/brands | Delete Brands
*BrandsApi* | [**GetBrandById**](docs/BrandsApi.md#getbrandbyid) | **GET** /catalog/brands/{brand_id} | Get a Brand
*BrandsApi* | [**GetBrands**](docs/BrandsApi.md#getbrands) | **GET** /catalog/brands | Get All Brands
*BrandsApi* | [**UpdateBrand**](docs/BrandsApi.md#updatebrand) | **PUT** /catalog/brands/{brand_id} | Update a Brand
*CatalogApi* | [**DeleteBrands**](docs/CatalogApi.md#deletebrands) | **DELETE** /catalog/brands | Delete Brands
*CatalogApi* | [**DeleteProducts**](docs/CatalogApi.md#deleteproducts) | **DELETE** /catalog/products | Delete Products
*CatalogApi* | [**UpdateVariantsBatch**](docs/CatalogApi.md#updatevariantsbatch) | **PUT** /catalog/variants | Update Variants (Batch)
*CategoryApi* | [**CreateCategory**](docs/CategoryApi.md#createcategory) | **POST** /catalog/categories | Create a Category
*CategoryApi* | [**DeleteCategories**](docs/CategoryApi.md#deletecategories) | **DELETE** /catalog/categories | Delete Categories
*CategoryApi* | [**DeleteCategoryById**](docs/CategoryApi.md#deletecategorybyid) | **DELETE** /catalog/categories/{category_id} | Delete a Category
*CategoryApi* | [**GetCategories**](docs/CategoryApi.md#getcategories) | **GET** /catalog/categories | Get All Categories
*CategoryApi* | [**GetCategoryById**](docs/CategoryApi.md#getcategorybyid) | **GET** /catalog/categories/{category_id} | Get a Category
*CategoryApi* | [**GetCategoryTree**](docs/CategoryApi.md#getcategorytree) | **GET** /catalog/categories/tree | Get Category Tree
*CategoryApi* | [**UpdateCategory**](docs/CategoryApi.md#updatecategory) | **PUT** /catalog/categories/{category_id} | Update a Category
*CategoryImagesApi* | [**CreateCategoryImage**](docs/CategoryImagesApi.md#createcategoryimage) | **POST** /catalog/categories/{category_id}/image | Create a Category Image
*CategoryImagesApi* | [**DeleteCategoryImage**](docs/CategoryImagesApi.md#deletecategoryimage) | **DELETE** /catalog/categories/{category_id}/image | Delete a Category Image
*CategoryMetafieldsApi* | [**CreateCategoryMetafield**](docs/CategoryMetafieldsApi.md#createcategorymetafield) | **POST** /catalog/categories/{category_id}/metafields | Create a Category Metafield
*CategoryMetafieldsApi* | [**DeleteCategoryMetafieldById**](docs/CategoryMetafieldsApi.md#deletecategorymetafieldbyid) | **DELETE** /catalog/categories/{category_id}/metafields/{metafield_id} | Delete a Category Metafield
*CategoryMetafieldsApi* | [**GetCategoryMetafieldByCategoryId**](docs/CategoryMetafieldsApi.md#getcategorymetafieldbycategoryid) | **GET** /catalog/categories/{category_id}/metafields/{metafield_id} | Get a Category Metafield
*CategoryMetafieldsApi* | [**GetCategoryMetafieldsByCategoryId**](docs/CategoryMetafieldsApi.md#getcategorymetafieldsbycategoryid) | **GET** /catalog/categories/{category_id}/metafields | Get All Category Metafields
*CategoryMetafieldsApi* | [**UpdateCategoryMetafield**](docs/CategoryMetafieldsApi.md#updatecategorymetafield) | **PUT** /catalog/categories/{category_id}/metafields/{metafield_id} | Update a Category Metafield
*ProductBulkPricingRulesApi* | [**CreateBulkPricingRule**](docs/ProductBulkPricingRulesApi.md#createbulkpricingrule) | **POST** /catalog/products/{product_id}/bulk-pricing-rules | Creates a Bulk Pricing Rule
*ProductBulkPricingRulesApi* | [**DeleteBulkPricingRuleById**](docs/ProductBulkPricingRulesApi.md#deletebulkpricingrulebyid) | **DELETE** /catalog/products/{product_id}/bulk-pricing-rules/{bulk_pricing_rule_id} | Delete a Bulk Pricing Rule
*ProductBulkPricingRulesApi* | [**GetBulkPricingRuleById**](docs/ProductBulkPricingRulesApi.md#getbulkpricingrulebyid) | **GET** /catalog/products/{product_id}/bulk-pricing-rules/{bulk_pricing_rule_id} | Get a Bulk Pricing Rule
*ProductBulkPricingRulesApi* | [**GetBulkPricingRules**](docs/ProductBulkPricingRulesApi.md#getbulkpricingrules) | **GET** /catalog/products/{product_id}/bulk-pricing-rules | Get All Bulk Pricing Rules
*ProductBulkPricingRulesApi* | [**UpdateBulkPricingRule**](docs/ProductBulkPricingRulesApi.md#updatebulkpricingrule) | **PUT** /catalog/products/{product_id}/bulk-pricing-rules/{bulk_pricing_rule_id} | Update a Bulk Pricing Rule
*ProductComplexRulesApi* | [**CreateComplexRule**](docs/ProductComplexRulesApi.md#createcomplexrule) | **POST** /catalog/products/{product_id}/complex-rules | Create a Complex Rule
*ProductComplexRulesApi* | [**DeleteComplexRuleById**](docs/ProductComplexRulesApi.md#deletecomplexrulebyid) | **DELETE** /catalog/products/{product_id}/complex-rules/{complex_rule_id} | Delete a Complex Rule
*ProductComplexRulesApi* | [**GetComplexRuleById**](docs/ProductComplexRulesApi.md#getcomplexrulebyid) | **GET** /catalog/products/{product_id}/complex-rules/{complex_rule_id} | Get a Complex Rule
*ProductComplexRulesApi* | [**GetComplexRules**](docs/ProductComplexRulesApi.md#getcomplexrules) | **GET** /catalog/products/{product_id}/complex-rules | Get Complex Rules
*ProductComplexRulesApi* | [**UpdateComplexRule**](docs/ProductComplexRulesApi.md#updatecomplexrule) | **PUT** /catalog/products/{product_id}/complex-rules/{complex_rule_id} | Update a Complex Rule
*ProductCustomFieldsApi* | [**CreateCustomField**](docs/ProductCustomFieldsApi.md#createcustomfield) | **POST** /catalog/products/{product_id}/custom-fields | Create a Custom Fields
*ProductCustomFieldsApi* | [**DeleteCustomFieldById**](docs/ProductCustomFieldsApi.md#deletecustomfieldbyid) | **DELETE** /catalog/products/{product_id}/custom-fields/{custom_field_id} | Delete a Custom Field
*ProductCustomFieldsApi* | [**GetCustomFieldById**](docs/ProductCustomFieldsApi.md#getcustomfieldbyid) | **GET** /catalog/products/{product_id}/custom-fields/{custom_field_id} | Get a Custom Field
*ProductCustomFieldsApi* | [**GetCustomFields**](docs/ProductCustomFieldsApi.md#getcustomfields) | **GET** /catalog/products/{product_id}/custom-fields | Get Custom Fields
*ProductCustomFieldsApi* | [**UpdateCustomField**](docs/ProductCustomFieldsApi.md#updatecustomfield) | **PUT** /catalog/products/{product_id}/custom-fields/{custom_field_id} | Update a Custom Field
*ProductImagesApi* | [**CreateProductImage**](docs/ProductImagesApi.md#createproductimage) | **POST** /catalog/products/{product_id}/images | Create a Product Image
*ProductImagesApi* | [**DeleteProductImage**](docs/ProductImagesApi.md#deleteproductimage) | **DELETE** /catalog/products/{product_id}/images/{image_id} | Delete a Product Image
*ProductImagesApi* | [**GetProductImageById**](docs/ProductImagesApi.md#getproductimagebyid) | **GET** /catalog/products/{product_id}/images/{image_id} | Get a Product Image
*ProductImagesApi* | [**GetProductImages**](docs/ProductImagesApi.md#getproductimages) | **GET** /catalog/products/{product_id}/images | Get All Product Images
*ProductImagesApi* | [**UpdateProductImage**](docs/ProductImagesApi.md#updateproductimage) | **PUT** /catalog/products/{product_id}/images/{image_id} | Update a Product Image
*ProductMetafieldsApi* | [**CreateProductMetafield**](docs/ProductMetafieldsApi.md#createproductmetafield) | **POST** /catalog/products/{product_id}/metafields | Create a Product Metafield
*ProductMetafieldsApi* | [**DeleteProductMetafieldById**](docs/ProductMetafieldsApi.md#deleteproductmetafieldbyid) | **DELETE** /catalog/products/{product_id}/metafields/{metafield_id} | Delete a Product Metafield
*ProductMetafieldsApi* | [**GetProductMetafieldByProductId**](docs/ProductMetafieldsApi.md#getproductmetafieldbyproductid) | **GET** /catalog/products/{product_id}/metafields/{metafield_id} | Get a Product Metafield
*ProductMetafieldsApi* | [**GetProductMetafieldsByProductId**](docs/ProductMetafieldsApi.md#getproductmetafieldsbyproductid) | **GET** /catalog/products/{product_id}/metafields | Get All Product Metafields
*ProductMetafieldsApi* | [**UpdateProductMetafield**](docs/ProductMetafieldsApi.md#updateproductmetafield) | **PUT** /catalog/products/{product_id}/metafields/{metafield_id} | Update a Product Metafield
*ProductModifierImagesApi* | [**CreateModifierImage**](docs/ProductModifierImagesApi.md#createmodifierimage) | **POST** /catalog/products/{product_id}/modifiers/{modifier_id}/values/{value_id}/image | Create Modifier Image
*ProductModifierImagesApi* | [**DeleteModifierImage**](docs/ProductModifierImagesApi.md#deletemodifierimage) | **DELETE** /catalog/products/{product_id}/modifiers/{modifier_id}/values/{value_id}/image | Delete Modifier Image
*ProductModifierValuesApi* | [**CreateModifierValue**](docs/ProductModifierValuesApi.md#createmodifiervalue) | **POST** /catalog/products/{product_id}/modifiers/{modifier_id}/values | Create Modifier Value
*ProductModifierValuesApi* | [**DeleteModifierValueById**](docs/ProductModifierValuesApi.md#deletemodifiervaluebyid) | **DELETE** /catalog/products/{product_id}/modifiers/{modifier_id}/values/{value_id} | Delete Modifier Value
*ProductModifierValuesApi* | [**GetModifierValueById**](docs/ProductModifierValuesApi.md#getmodifiervaluebyid) | **GET** /catalog/products/{product_id}/modifiers/{modifier_id}/values/{value_id} | Get a Modifier Value
*ProductModifierValuesApi* | [**GetModifierValues**](docs/ProductModifierValuesApi.md#getmodifiervalues) | **GET** /catalog/products/{product_id}/modifiers/{modifier_id}/values | Get All Modifier Values
*ProductModifierValuesApi* | [**UpdateModifierValue**](docs/ProductModifierValuesApi.md#updatemodifiervalue) | **PUT** /catalog/products/{product_id}/modifiers/{modifier_id}/values/{value_id} | Update a Modifier Value
*ProductModifiersApi* | [**CreateModifier**](docs/ProductModifiersApi.md#createmodifier) | **POST** /catalog/products/{product_id}/modifiers | Create a Product Modifier
*ProductModifiersApi* | [**DeleteModifierById**](docs/ProductModifiersApi.md#deletemodifierbyid) | **DELETE** /catalog/products/{product_id}/modifiers/{modifier_id} | Delete a Modifier
*ProductModifiersApi* | [**GetModifierById**](docs/ProductModifiersApi.md#getmodifierbyid) | **GET** /catalog/products/{product_id}/modifiers/{modifier_id} | Get a Modifier
*ProductModifiersApi* | [**GetModifiers**](docs/ProductModifiersApi.md#getmodifiers) | **GET** /catalog/products/{product_id}/modifiers | Get All Product Modifiers
*ProductModifiersApi* | [**UpdateModifier**](docs/ProductModifiersApi.md#updatemodifier) | **PUT** /catalog/products/{product_id}/modifiers/{modifier_id} | Update a Modifier
*ProductOptionValuesApi* | [**CreateOptionValue**](docs/ProductOptionValuesApi.md#createoptionvalue) | **POST** /catalog/products/{product_id}/options/{option_id}/values | Create Product Option Values
*ProductOptionValuesApi* | [**DeleteOptionValueById**](docs/ProductOptionValuesApi.md#deleteoptionvaluebyid) | **DELETE** /catalog/products/{product_id}/options/{option_id}/values/{value_id} | Delete a Product Option Value
*ProductOptionValuesApi* | [**GetOptionValueById**](docs/ProductOptionValuesApi.md#getoptionvaluebyid) | **GET** /catalog/products/{product_id}/options/{option_id}/values/{value_id} | Get a Product Option Value
*ProductOptionValuesApi* | [**GetOptionValues**](docs/ProductOptionValuesApi.md#getoptionvalues) | **GET** /catalog/products/{product_id}/options/{option_id}/values | Get all Product Option Values
*ProductOptionValuesApi* | [**UpdateOptionValue**](docs/ProductOptionValuesApi.md#updateoptionvalue) | **PUT** /catalog/products/{product_id}/options/{option_id}/values/{value_id} | Update a Product Option Value
*ProductOptionsApi* | [**CreateOption**](docs/ProductOptionsApi.md#createoption) | **POST** /catalog/products/{product_id}/options | Create a Product Option
*ProductOptionsApi* | [**DeleteOptionById**](docs/ProductOptionsApi.md#deleteoptionbyid) | **DELETE** /catalog/products/{product_id}/options/{option_id} | Delete a Product Option
*ProductOptionsApi* | [**GetOptionById**](docs/ProductOptionsApi.md#getoptionbyid) | **GET** /catalog/products/{product_id}/options/{option_id} | Get a Product Option
*ProductOptionsApi* | [**GetOptions**](docs/ProductOptionsApi.md#getoptions) | **GET** /catalog/products/{product_id}/options | Get all Product Options
*ProductOptionsApi* | [**UpdateOption**](docs/ProductOptionsApi.md#updateoption) | **PUT** /catalog/products/{product_id}/options/{option_id} | Update a Product Option
*ProductReviewsApi* | [**CreateProductReview**](docs/ProductReviewsApi.md#createproductreview) | **POST** /catalog/products/{product_id}/reviews | Create a Product Review
*ProductReviewsApi* | [**DeleteProductReview**](docs/ProductReviewsApi.md#deleteproductreview) | **DELETE** /catalog/products/{product_id}/reviews/{review_id} | Delete a Product Review
*ProductReviewsApi* | [**GetProductReviewById**](docs/ProductReviewsApi.md#getproductreviewbyid) | **GET** /catalog/products/{product_id}/reviews/{review_id} | Get a Product Review
*ProductReviewsApi* | [**GetProductReviews**](docs/ProductReviewsApi.md#getproductreviews) | **GET** /catalog/products/{product_id}/reviews | Get Product Reviews
*ProductReviewsApi* | [**UpdateProductReview**](docs/ProductReviewsApi.md#updateproductreview) | **PUT** /catalog/products/{product_id}/reviews/{review_id} | Update a Product Review
*ProductVariantsApi* | [**CreateVariant**](docs/ProductVariantsApi.md#createvariant) | **POST** /catalog/products/{product_id}/variants | Create a Product Variant
*ProductVariantsApi* | [**CreateVariantImage**](docs/ProductVariantsApi.md#createvariantimage) | **POST** /catalog/products/{product_id}/variants/{variant_id}/image | Create a Variant Image
*ProductVariantsApi* | [**DeleteVariantById**](docs/ProductVariantsApi.md#deletevariantbyid) | **DELETE** /catalog/products/{product_id}/variants/{variant_id} | Delete a Product Variant
*ProductVariantsApi* | [**GetVariantById**](docs/ProductVariantsApi.md#getvariantbyid) | **GET** /catalog/products/{product_id}/variants/{variant_id} | Get a Product Variant
*ProductVariantsApi* | [**GetVariantsByProductId**](docs/ProductVariantsApi.md#getvariantsbyproductid) | **GET** /catalog/products/{product_id}/variants | Get All Product Variants
*ProductVariantsApi* | [**UpdateVariant**](docs/ProductVariantsApi.md#updatevariant) | **PUT** /catalog/products/{product_id}/variants/{variant_id} | Update a Product Variant
*ProductVariantsMetafieldsApi* | [**CreateVariantMetafield**](docs/ProductVariantsMetafieldsApi.md#createvariantmetafield) | **POST** /catalog/products/{product_id}/variants/{variant_id}/metafields | Create a Product Variant Metafield
*ProductVariantsMetafieldsApi* | [**DeleteVariantMetafieldById**](docs/ProductVariantsMetafieldsApi.md#deletevariantmetafieldbyid) | **DELETE** /catalog/products/{product_id}/variants/{variant_id}/metafields/{metafield_id} | Delete a Variant Metafield
*ProductVariantsMetafieldsApi* | [**GetVariantMetafieldByProductIdAndVariantId**](docs/ProductVariantsMetafieldsApi.md#getvariantmetafieldbyproductidandvariantid) | **GET** /catalog/products/{product_id}/variants/{variant_id}/metafields/{metafield_id} | Get Product Variant Metafields
*ProductVariantsMetafieldsApi* | [**GetVariantMetafieldsByProductIdAndVariantId**](docs/ProductVariantsMetafieldsApi.md#getvariantmetafieldsbyproductidandvariantid) | **GET** /catalog/products/{product_id}/variants/{variant_id}/metafields | Get Product Variant Metafields
*ProductVariantsMetafieldsApi* | [**UpdateVariantMetafield**](docs/ProductVariantsMetafieldsApi.md#updatevariantmetafield) | **PUT** /catalog/products/{product_id}/variants/{variant_id}/metafields/{metafield_id} | Update Product Variant Metafields
*ProductVideosApi* | [**CreateProductVideo**](docs/ProductVideosApi.md#createproductvideo) | **POST** /catalog/products/{product_id}/videos | Create a Product Video
*ProductVideosApi* | [**DeleteProductVideo**](docs/ProductVideosApi.md#deleteproductvideo) | **DELETE** /catalog/products/{product_id}/videos/{id} | Delete a Product Video
*ProductVideosApi* | [**GetProductVideoById**](docs/ProductVideosApi.md#getproductvideobyid) | **GET** /catalog/products/{product_id}/videos/{id} | Get a Product Video
*ProductVideosApi* | [**GetProductVideos**](docs/ProductVideosApi.md#getproductvideos) | **GET** /catalog/products/{product_id}/videos | Get All Product Videos
*ProductVideosApi* | [**UpdateProductVideo**](docs/ProductVideosApi.md#updateproductvideo) | **PUT** /catalog/products/{product_id}/videos/{id} | Update a Product Video
*ProductsApi* | [**CreateProduct**](docs/ProductsApi.md#createproduct) | **POST** /catalog/products | Create a Product
*ProductsApi* | [**DeleteProductById**](docs/ProductsApi.md#deleteproductbyid) | **DELETE** /catalog/products/{product_id} | Delete a Product
*ProductsApi* | [**DeleteProducts**](docs/ProductsApi.md#deleteproducts) | **DELETE** /catalog/products | Delete Products
*ProductsApi* | [**GetProductById**](docs/ProductsApi.md#getproductbyid) | **GET** /catalog/products/{product_id} | Get a Product
*ProductsApi* | [**GetProducts**](docs/ProductsApi.md#getproducts) | **GET** /catalog/products | Get All Products
*ProductsApi* | [**UpdateProduct**](docs/ProductsApi.md#updateproduct) | **PUT** /catalog/products/{product_id} | Update a Product
*ProductsApi* | [**UpdateProducts**](docs/ProductsApi.md#updateproducts) | **PUT** /catalog/products | Update Products (Batch)
*SummaryApi* | [**GetCatalogSummary**](docs/SummaryApi.md#getcatalogsummary) | **GET** /catalog/summary | Get a Catalog Summary
*VariantsApi* | [**GetVariants**](docs/VariantsApi.md#getvariants) | **GET** /catalog/variants | Get All Variants
*VariantsApi* | [**UpdateVariantsBatch**](docs/VariantsApi.md#updatevariantsbatch) | **PUT** /catalog/variants | Update Variants (Batch)

<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.Adjuster](docs/Adjuster.md)
 - [Model.AdjusterFull](docs/AdjusterFull.md)
 - [Model.AdjustersFull](docs/AdjustersFull.md)
 - [Model.AdjustersFull1](docs/AdjustersFull1.md)
 - [Model.AdjustersFullPurchasingDisabled](docs/AdjustersFullPurchasingDisabled.md)
 - [Model.AllOfMetaFieldCollectionResponseDataItems](docs/AllOfMetaFieldCollectionResponseDataItems.md)
 - [Model.AllOfMetafieldResponse1Data](docs/AllOfMetafieldResponse1Data.md)
 - [Model.AllOfModifierCollectionResponseDataItems](docs/AllOfModifierCollectionResponseDataItems.md)
 - [Model.AllOfModifierResponse1Data](docs/AllOfModifierResponse1Data.md)
 - [Model.AllOfModifierResponseData](docs/AllOfModifierResponseData.md)
 - [Model.AllOfModifierValueCollectionResponseDataItems](docs/AllOfModifierValueCollectionResponseDataItems.md)
 - [Model.AllOfModifierValueResponse1Data](docs/AllOfModifierValueResponse1Data.md)
 - [Model.AllOfModifierValueResponseData](docs/AllOfModifierValueResponseData.md)
 - [Model.AllOfOptionCollectionResponseDataItems](docs/AllOfOptionCollectionResponseDataItems.md)
 - [Model.AllOfOptionResponse1Data](docs/AllOfOptionResponse1Data.md)
 - [Model.AllOfOptionResponse2Data](docs/AllOfOptionResponse2Data.md)
 - [Model.AllOfOptionResponseData](docs/AllOfOptionResponseData.md)
 - [Model.AllOfOptionValueCollectionResponseDataItems](docs/AllOfOptionValueCollectionResponseDataItems.md)
 - [Model.AllOfOptionValueResponseData](docs/AllOfOptionValueResponseData.md)
 - [Model.AllOfProductImageCollectionResponseDataItems](docs/AllOfProductImageCollectionResponseDataItems.md)
 - [Model.AllOfProductImageResponse1Data](docs/AllOfProductImageResponse1Data.md)
 - [Model.AllOfProductImageResponseData](docs/AllOfProductImageResponseData.md)
 - [Model.AllOfProductResponseData](docs/AllOfProductResponseData.md)
 - [Model.AllOfProductReviewCollectionResponseDataItems](docs/AllOfProductReviewCollectionResponseDataItems.md)
 - [Model.AllOfProductReviewResponseData](docs/AllOfProductReviewResponseData.md)
 - [Model.AllOfProductVideoCollectionResponseDataItems](docs/AllOfProductVideoCollectionResponseDataItems.md)
 - [Model.AllOfProductVideoResponse1Data](docs/AllOfProductVideoResponse1Data.md)
 - [Model.AllOfProductVideoResponseData](docs/AllOfProductVideoResponseData.md)
 - [Model.AllOfVariantCollectionResponse1DataItems](docs/AllOfVariantCollectionResponse1DataItems.md)
 - [Model.AllOfVariantCollectionResponse2DataItems](docs/AllOfVariantCollectionResponse2DataItems.md)
 - [Model.AllOfVariantCollectionResponseDataItems](docs/AllOfVariantCollectionResponseDataItems.md)
 - [Model.AllOfVariantResponse1Data](docs/AllOfVariantResponse1Data.md)
 - [Model.AllOfVariantResponseData](docs/AllOfVariantResponseData.md)
 - [Model.AllOfVariantsBatchErrorResponseBatchErrorsItems](docs/AllOfVariantsBatchErrorResponseBatchErrorsItems.md)
 - [Model.AllOfinlineResponse2001DataItems](docs/AllOfinlineResponse2001DataItems.md)
 - [Model.AllOfproductBaseCustomFieldsItems](docs/AllOfproductBaseCustomFieldsItems.md)
 - [Model.AllOfproductBaseImagesItems](docs/AllOfproductBaseImagesItems.md)
 - [Model.AllOfproductBaseVideosItems](docs/AllOfproductBaseVideosItems.md)
 - [Model.AllOfproductOptionBase1OptionValues](docs/AllOfproductOptionBase1OptionValues.md)
 - [Model.AllOfproductOptionBaseOptionValues](docs/AllOfproductOptionBaseOptionValues.md)
 - [Model.AllOfrespProductImageData](docs/AllOfrespProductImageData.md)
 - [Model.AllOfrespProductOptionValueData](docs/AllOfrespProductOptionValueData.md)
 - [Model.AllOfrespProductionOptionData](docs/AllOfrespProductionOptionData.md)
 - [Model.AllOfrespVariantBatchErrorBatchErrorsItems](docs/AllOfrespVariantBatchErrorBatchErrorsItems.md)
 - [Model.Body](docs/Body.md)
 - [Model.Body1](docs/Body1.md)
 - [Model.Body2](docs/Body2.md)
 - [Model.Brand](docs/Brand.md)
 - [Model.Brand1](docs/Brand1.md)
 - [Model.Brand2](docs/Brand2.md)
 - [Model.BrandCollectionResponse](docs/BrandCollectionResponse.md)
 - [Model.BrandFull](docs/BrandFull.md)
 - [Model.BrandFull1](docs/BrandFull1.md)
 - [Model.BrandResponse](docs/BrandResponse.md)
 - [Model.BrandResponse1](docs/BrandResponse1.md)
 - [Model.BulkPricingRule](docs/BulkPricingRule.md)
 - [Model.BulkPricingRuleFull](docs/BulkPricingRuleFull.md)
 - [Model.BulkPricingRuleFull1](docs/BulkPricingRuleFull1.md)
 - [Model.BulkPricingRuleFull2](docs/BulkPricingRuleFull2.md)
 - [Model.BulkPricingRuleFull3](docs/BulkPricingRuleFull3.md)
 - [Model.CatalogSummary](docs/CatalogSummary.md)
 - [Model.CatalogSummaryFull](docs/CatalogSummaryFull.md)
 - [Model.CatalogSummaryResponse](docs/CatalogSummaryResponse.md)
 - [Model.CategoriesTreeNodeFull](docs/CategoriesTreeNodeFull.md)
 - [Model.CategoriesTreeNodeFull1](docs/CategoriesTreeNodeFull1.md)
 - [Model.CategoriesTreeResp](docs/CategoriesTreeResp.md)
 - [Model.CategoriesTreeResp1](docs/CategoriesTreeResp1.md)
 - [Model.CategoriesTreeResp2](docs/CategoriesTreeResp2.md)
 - [Model.Category](docs/Category.md)
 - [Model.Category1](docs/Category1.md)
 - [Model.CategoryBase](docs/CategoryBase.md)
 - [Model.CategoryFull](docs/CategoryFull.md)
 - [Model.CategoryFull1](docs/CategoryFull1.md)
 - [Model.CategoryResponse](docs/CategoryResponse.md)
 - [Model.CategoryResponse1](docs/CategoryResponse1.md)
 - [Model.ComplexRule](docs/ComplexRule.md)
 - [Model.ComplexRule1](docs/ComplexRule1.md)
 - [Model.ComplexRuleBase](docs/ComplexRuleBase.md)
 - [Model.ComplexRuleBase1](docs/ComplexRuleBase1.md)
 - [Model.ComplexRuleCollectionResponse](docs/ComplexRuleCollectionResponse.md)
 - [Model.ComplexRuleCondition](docs/ComplexRuleCondition.md)
 - [Model.ComplexRuleConditionBase](docs/ComplexRuleConditionBase.md)
 - [Model.ConfigFull](docs/ConfigFull.md)
 - [Model.CustomField](docs/CustomField.md)
 - [Model.CustomField1](docs/CustomField1.md)
 - [Model.CustomField2](docs/CustomField2.md)
 - [Model.CustomUrlBrand](docs/CustomUrlBrand.md)
 - [Model.CustomUrlCategory](docs/CustomUrlCategory.md)
 - [Model.CustomUrlFull](docs/CustomUrlFull.md)
 - [Model.DetailedErrors](docs/DetailedErrors.md)
 - [Model.DetailedErrors1](docs/DetailedErrors1.md)
 - [Model.ErrorBase](docs/ErrorBase.md)
 - [Model.ErrorNoContent](docs/ErrorNoContent.md)
 - [Model.ErrorNotFound](docs/ErrorNotFound.md)
 - [Model.ErrorResponse](docs/ErrorResponse.md)
 - [Model.ErrorResponseFull](docs/ErrorResponseFull.md)
 - [Model.GiftCertificateFull](docs/GiftCertificateFull.md)
 - [Model.ImageResponse](docs/ImageResponse.md)
 - [Model.InlineResponse200](docs/InlineResponse200.md)
 - [Model.InlineResponse2001](docs/InlineResponse2001.md)
 - [Model.InlineResponse2002](docs/InlineResponse2002.md)
 - [Model.InlineResponse2003](docs/InlineResponse2003.md)
 - [Model.InlineResponse2004](docs/InlineResponse2004.md)
 - [Model.InlineResponse2005](docs/InlineResponse2005.md)
 - [Model.InlineResponse2006](docs/InlineResponse2006.md)
 - [Model.InlineResponse2007](docs/InlineResponse2007.md)
 - [Model.InlineResponse2008](docs/InlineResponse2008.md)
 - [Model.InlineResponse200Data](docs/InlineResponse200Data.md)
 - [Model.Meta](docs/Meta.md)
 - [Model.MetaCollectionFull](docs/MetaCollectionFull.md)
 - [Model.MetaCollectionFull1](docs/MetaCollectionFull1.md)
 - [Model.MetaEmptyFull](docs/MetaEmptyFull.md)
 - [Model.MetaFieldCollectionResponse](docs/MetaFieldCollectionResponse.md)
 - [Model.MetaFieldCollectionResponse1](docs/MetaFieldCollectionResponse1.md)
 - [Model.Metafield](docs/Metafield.md)
 - [Model.MetafieldBase](docs/MetafieldBase.md)
 - [Model.MetafieldBase1](docs/MetafieldBase1.md)
 - [Model.MetafieldFull](docs/MetafieldFull.md)
 - [Model.MetafieldPost](docs/MetafieldPost.md)
 - [Model.MetafieldPost1](docs/MetafieldPost1.md)
 - [Model.MetafieldPost2](docs/MetafieldPost2.md)
 - [Model.MetafieldPost3](docs/MetafieldPost3.md)
 - [Model.MetafieldPut](docs/MetafieldPut.md)
 - [Model.MetafieldPut1](docs/MetafieldPut1.md)
 - [Model.MetafieldPut2](docs/MetafieldPut2.md)
 - [Model.MetafieldPut3](docs/MetafieldPut3.md)
 - [Model.MetafieldPut4](docs/MetafieldPut4.md)
 - [Model.MetafieldResponse](docs/MetafieldResponse.md)
 - [Model.MetafieldResponse1](docs/MetafieldResponse1.md)
 - [Model.MetafieldResponse2](docs/MetafieldResponse2.md)
 - [Model.MetafieldResponse3](docs/MetafieldResponse3.md)
 - [Model.ModifierCollectionResponse](docs/ModifierCollectionResponse.md)
 - [Model.ModifierPost](docs/ModifierPost.md)
 - [Model.ModifierPut](docs/ModifierPut.md)
 - [Model.ModifierResponse](docs/ModifierResponse.md)
 - [Model.ModifierResponse1](docs/ModifierResponse1.md)
 - [Model.ModifierValueCollectionResponse](docs/ModifierValueCollectionResponse.md)
 - [Model.ModifierValuePost](docs/ModifierValuePost.md)
 - [Model.ModifierValuePut](docs/ModifierValuePut.md)
 - [Model.ModifierValueResponse](docs/ModifierValueResponse.md)
 - [Model.ModifierValueResponse1](docs/ModifierValueResponse1.md)
 - [Model.NotFound](docs/NotFound.md)
 - [Model.OptionCollectionResponse](docs/OptionCollectionResponse.md)
 - [Model.OptionConfig](docs/OptionConfig.md)
 - [Model.OptionPost](docs/OptionPost.md)
 - [Model.OptionPut](docs/OptionPut.md)
 - [Model.OptionResponse](docs/OptionResponse.md)
 - [Model.OptionResponse1](docs/OptionResponse1.md)
 - [Model.OptionResponse2](docs/OptionResponse2.md)
 - [Model.OptionValueCollectionResponse](docs/OptionValueCollectionResponse.md)
 - [Model.OptionValuePost](docs/OptionValuePost.md)
 - [Model.OptionValuePut](docs/OptionValuePut.md)
 - [Model.OptionValueResponse](docs/OptionValueResponse.md)
 - [Model.PaginationFull](docs/PaginationFull.md)
 - [Model.PaginationFull1](docs/PaginationFull1.md)
 - [Model.PaginationFull1Links](docs/PaginationFull1Links.md)
 - [Model.ProductBase](docs/ProductBase.md)
 - [Model.ProductCustomFieldBase](docs/ProductCustomFieldBase.md)
 - [Model.ProductCustomFieldPost](docs/ProductCustomFieldPost.md)
 - [Model.ProductCustomFieldPut](docs/ProductCustomFieldPut.md)
 - [Model.ProductFull](docs/ProductFull.md)
 - [Model.ProductImageBase](docs/ProductImageBase.md)
 - [Model.ProductImageCollectionResponse](docs/ProductImageCollectionResponse.md)
 - [Model.ProductImageFull](docs/ProductImageFull.md)
 - [Model.ProductImagePost](docs/ProductImagePost.md)
 - [Model.ProductImagePost1](docs/ProductImagePost1.md)
 - [Model.ProductImagePut](docs/ProductImagePut.md)
 - [Model.ProductImageResponse](docs/ProductImageResponse.md)
 - [Model.ProductImageResponse1](docs/ProductImageResponse1.md)
 - [Model.ProductModifierBase](docs/ProductModifierBase.md)
 - [Model.ProductModifierFull](docs/ProductModifierFull.md)
 - [Model.ProductModifierOptionValueBase](docs/ProductModifierOptionValueBase.md)
 - [Model.ProductModifierOptionValueFull](docs/ProductModifierOptionValueFull.md)
 - [Model.ProductModifierOptionValuePost](docs/ProductModifierOptionValuePost.md)
 - [Model.ProductModifierOptionValuePut](docs/ProductModifierOptionValuePut.md)
 - [Model.ProductModifierPost](docs/ProductModifierPost.md)
 - [Model.ProductModifierPut](docs/ProductModifierPut.md)
 - [Model.ProductOptionBase](docs/ProductOptionBase.md)
 - [Model.ProductOptionBase1](docs/ProductOptionBase1.md)
 - [Model.ProductOptionConfigFull](docs/ProductOptionConfigFull.md)
 - [Model.ProductOptionFull](docs/ProductOptionFull.md)
 - [Model.ProductOptionOptionValueBase](docs/ProductOptionOptionValueBase.md)
 - [Model.ProductOptionOptionValueFull](docs/ProductOptionOptionValueFull.md)
 - [Model.ProductOptionPost](docs/ProductOptionPost.md)
 - [Model.ProductOptionPut](docs/ProductOptionPut.md)
 - [Model.ProductOptionValuePost](docs/ProductOptionValuePost.md)
 - [Model.ProductOptionValuePostProduct](docs/ProductOptionValuePostProduct.md)
 - [Model.ProductOptionValuePut](docs/ProductOptionValuePut.md)
 - [Model.ProductPost](docs/ProductPost.md)
 - [Model.ProductPost1](docs/ProductPost1.md)
 - [Model.ProductPut](docs/ProductPut.md)
 - [Model.ProductPut1](docs/ProductPut1.md)
 - [Model.ProductPutCollection](docs/ProductPutCollection.md)
 - [Model.ProductResponse](docs/ProductResponse.md)
 - [Model.ProductReviewBase](docs/ProductReviewBase.md)
 - [Model.ProductReviewCollectionResponse](docs/ProductReviewCollectionResponse.md)
 - [Model.ProductReviewFull](docs/ProductReviewFull.md)
 - [Model.ProductReviewPost](docs/ProductReviewPost.md)
 - [Model.ProductReviewPut](docs/ProductReviewPut.md)
 - [Model.ProductReviewResponse](docs/ProductReviewResponse.md)
 - [Model.ProductVariantBase](docs/ProductVariantBase.md)
 - [Model.ProductVariantFull](docs/ProductVariantFull.md)
 - [Model.ProductVariantOptionValueBase](docs/ProductVariantOptionValueBase.md)
 - [Model.ProductVariantOptionValueFull](docs/ProductVariantOptionValueFull.md)
 - [Model.ProductVariantOptionValuePost](docs/ProductVariantOptionValuePost.md)
 - [Model.ProductVariantPost](docs/ProductVariantPost.md)
 - [Model.ProductVariantPostProduct](docs/ProductVariantPostProduct.md)
 - [Model.ProductVariantPut](docs/ProductVariantPut.md)
 - [Model.ProductVariantPut1](docs/ProductVariantPut1.md)
 - [Model.ProductVariantPutProduct](docs/ProductVariantPutProduct.md)
 - [Model.ProductVariantPutProduct1](docs/ProductVariantPutProduct1.md)
 - [Model.ProductVideoBase](docs/ProductVideoBase.md)
 - [Model.ProductVideoCollectionResponse](docs/ProductVideoCollectionResponse.md)
 - [Model.ProductVideoFull](docs/ProductVideoFull.md)
 - [Model.ProductVideoPost](docs/ProductVideoPost.md)
 - [Model.ProductVideoPut](docs/ProductVideoPut.md)
 - [Model.ProductVideoResponse](docs/ProductVideoResponse.md)
 - [Model.ProductVideoResponse1](docs/ProductVideoResponse1.md)
 - [Model.ResourceImage](docs/ResourceImage.md)
 - [Model.ResourceImage1](docs/ResourceImage1.md)
 - [Model.ResourceImage2](docs/ResourceImage2.md)
 - [Model.ResourceImageFull](docs/ResourceImageFull.md)
 - [Model.RespProductImage](docs/RespProductImage.md)
 - [Model.RespProductOptionValue](docs/RespProductOptionValue.md)
 - [Model.RespProductionOption](docs/RespProductionOption.md)
 - [Model.RespVariantBatchError](docs/RespVariantBatchError.md)
 - [Model.VariantBase](docs/VariantBase.md)
 - [Model.VariantCollectionPut](docs/VariantCollectionPut.md)
 - [Model.VariantCollectionResponse](docs/VariantCollectionResponse.md)
 - [Model.VariantCollectionResponse1](docs/VariantCollectionResponse1.md)
 - [Model.VariantCollectionResponse2](docs/VariantCollectionResponse2.md)
 - [Model.VariantPost](docs/VariantPost.md)
 - [Model.VariantPut](docs/VariantPut.md)
 - [Model.VariantResponse](docs/VariantResponse.md)
 - [Model.VariantResponse1](docs/VariantResponse1.md)
 - [Model.VariantsBatchErrorResponse](docs/VariantsBatchErrorResponse.md)

<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="X-Auth-Token"></a>
### X-Auth-Token

- **Type**: API key
- **API key parameter name**: X-Auth-Token
- **Location**: HTTP header

