# StoreInfo.Model.StoreInformation
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique store identifier. | [optional] 
**Domain** | **string** | Primary domain name. | [optional] 
**SecureURL** | **string** | Store’s current HTTPS URL. | [optional] 
**ControlPanelBaseUrl** | **string** | The secure hostname of the control panel. | [optional] 
**Name** | **string** | Store&#x27;s name. | [optional] 
**FirstName** | **string** | Primary contact’s first name (as defined during the store sign-up process). | [optional] 
**LastName** | **string** | Primary contact’s last name (as defined during the store sign-up process). | [optional] 
**Address** | **string** | Display address. | [optional] 
**Country** | **string** | Country where the store is located (as defined during the store sign-up process). | [optional] 
**Phone** | **string** | Display phone number. | [optional] 
**AdminEmail** | **string** | Email address of the store administrator/owner. | [optional] 
**OrderEmail** | **string** | Email address for orders and fulfillment. | [optional] 
**Timezone** | [**TimeZone**](TimeZone.md) |  | [optional] 
**Language** | **string** | Default language code. | [optional] 
**Currency** | **string** | Default currency code | [optional] 
**CurrencySymbol** | **string** | Default symbol for values in the currency. | [optional] 
**DecimalSeparator** | **string** | Default decimal separator for values in the currency. | [optional] 
**ThousandsSeparator** | **string** | Default thousands separator for values in the currency. | [optional] 
**DecimalPlaces** | **int?** | Default decimal places for values in the currency. | [optional] 
**CurrencySymbolLocation** | **string** | Default position of the currency symbol (left or right). | [optional] 
**WeightUnits** | **string** | Default weight units (metric or imperial). | [optional] 
**DimensionUnits** | **string** | Default dimension units (metric or imperial). | [optional] 
**DimensionDecimalPlaces** | **int?** | The number of decimal places. | [optional] 
**DimensionDecimalToken** | **string** | The symbol that separates the whole numbers from the decimal points. | [optional] 
**DimensionThousandsToken** | **string** | The symbol used to denote thousands. | [optional] 
**PlanName** | **string** | Name of the BigCommerce plan to which this store is subscribed. | [optional] 
**PlanLevel** | **string** | Level of the BigCommerce plan to which this store is subscribed. | [optional] 
**Industry** | **string** | Industry, or vertical category, in which the business operates. (As selected from drop-down list during the store sign-up process.) | [optional] 
**Logo** | [**StoreInformationLogo**](StoreInformationLogo.md) |  | [optional] 
**IsPriceEnteredWithTax** | **bool?** | A Boolean value that indicates whether or not prices are entered with tax. | [optional] 
**ActiveComparisonModules** | **List&lt;Object&gt;** |  | [optional] 
**Features** | [**StoreInformationFeatures**](StoreInformationFeatures.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

