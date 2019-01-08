/**
 * This file is automatically created by Recurly's OpenAPI generation process
 * and thus any edits you make by hand will be lost. If you wish to make a
 * change to this file, please create a Github issue explaining the changes you
 * need and we will usher them to the appropriate places.
 */
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;

namespace Recurly.Resources {
  [ExcludeFromCodeCoverage] 
  public class BillingInfoCreate : Request {
  
    
    [JsonProperty("address")]
    public Address Address { get; set; }
  
    /// <value>Amazon billing agreement ID</value>
    [JsonProperty("amazon_billing_agreement_id")]
    public string AmazonBillingAgreementId { get; set; }
  
    /// <value>Company name</value>
    [JsonProperty("company")]
    public string Company { get; set; }
  
    /// <value>*STRONGLY RECOMMENDED*</value>
    [JsonProperty("cvv")]
    public string Cvv { get; set; }
  
    /// <value>First name</value>
    [JsonProperty("first_name")]
    public string FirstName { get; set; }
  
    /// <value>*STRONGLY RECOMMENDED* Customer's IP address when updating their billing information.</value>
    [JsonProperty("ip_address")]
    public string IpAddress { get; set; }
  
    /// <value>Last name</value>
    [JsonProperty("last_name")]
    public string LastName { get; set; }
  
    /// <value>Expiration month</value>
    [JsonProperty("month")]
    public string Month { get; set; }
  
    /// <value>Credit card number, spaces and dashes are accepted.</value>
    [JsonProperty("number")]
    public string Number { get; set; }
  
    /// <value>PayPal billing agreement ID</value>
    [JsonProperty("paypal_billing_agreement_id")]
    public string PaypalBillingAgreementId { get; set; }
  
    /// <value>A token [generated by Recurly.js](https://docs.recurly.com/js/#getting-a-token).</value>
    [JsonProperty("token_id")]
    public string TokenId { get; set; }
  
    /// <value>VAT number</value>
    [JsonProperty("vat_number")]
    public string VatNumber { get; set; }
  
    /// <value>Expiration year</value>
    [JsonProperty("year")]
    public string Year { get; set; }
  
  }
}
