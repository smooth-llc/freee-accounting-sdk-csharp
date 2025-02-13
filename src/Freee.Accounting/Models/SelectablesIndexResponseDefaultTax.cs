/*
 * freee API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using OpenAPIDateConverter = Freee.Accounting.Client.OpenAPIDateConverter;

namespace Freee.Accounting.Models
{
    /// <summary>
    /// SelectablesIndexResponseDefaultTax
    /// </summary>
    [DataContract(Name = "selectablesIndexResponse_default_tax")]
    public partial class SelectablesIndexResponseDefaultTax : IEquatable<SelectablesIndexResponseDefaultTax>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SelectablesIndexResponseDefaultTax" /> class.
        /// </summary>
        /// <param name="taxRate5">taxRate5.</param>
        /// <param name="taxRate8">taxRate8.</param>
        public SelectablesIndexResponseDefaultTax(SelectablesIndexResponseDefaultTaxTaxRate5 taxRate5 = default(SelectablesIndexResponseDefaultTaxTaxRate5), SelectablesIndexResponseDefaultTaxTaxRate8 taxRate8 = default(SelectablesIndexResponseDefaultTaxTaxRate8))
        {
            this.TaxRate5 = taxRate5;
            this.TaxRate8 = taxRate8;
        }

        /// <summary>
        /// Gets or Sets TaxRate5
        /// </summary>
        [DataMember(Name = "tax_rate_5", EmitDefaultValue = false)]
        public SelectablesIndexResponseDefaultTaxTaxRate5 TaxRate5 { get; set; }

        /// <summary>
        /// Gets or Sets TaxRate8
        /// </summary>
        [DataMember(Name = "tax_rate_8", EmitDefaultValue = false)]
        public SelectablesIndexResponseDefaultTaxTaxRate8 TaxRate8 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SelectablesIndexResponseDefaultTax {\n");
            sb.Append("  TaxRate5: ").Append(TaxRate5).Append("\n");
            sb.Append("  TaxRate8: ").Append(TaxRate8).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as SelectablesIndexResponseDefaultTax);
        }

        /// <summary>
        /// Returns true if SelectablesIndexResponseDefaultTax instances are equal
        /// </summary>
        /// <param name="input">Instance of SelectablesIndexResponseDefaultTax to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SelectablesIndexResponseDefaultTax input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TaxRate5 == input.TaxRate5 ||
                    (this.TaxRate5 != null &&
                    this.TaxRate5.Equals(input.TaxRate5))
                ) && 
                (
                    this.TaxRate8 == input.TaxRate8 ||
                    (this.TaxRate8 != null &&
                    this.TaxRate8.Equals(input.TaxRate8))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.TaxRate5 != null)
                {
                    hashCode = (hashCode * 59) + this.TaxRate5.GetHashCode();
                }
                if (this.TaxRate8 != null)
                {
                    hashCode = (hashCode * 59) + this.TaxRate8.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
