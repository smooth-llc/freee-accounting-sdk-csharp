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
    /// CompanyResponseCompanyTaxes
    /// </summary>
    [DataContract(Name = "companyResponse_company_taxes")]
    public partial class CompanyResponseCompanyTaxes : IEquatable<CompanyResponseCompanyTaxes>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyResponseCompanyTaxes" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CompanyResponseCompanyTaxes() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyResponseCompanyTaxes" /> class.
        /// </summary>
        /// <param name="id">税区分ID（廃止予定。tax_codeを使用してください。） (required).</param>
        /// <param name="name">税区分名 (required).</param>
        public CompanyResponseCompanyTaxes(int id = default(int), string name = default(string))
        {
            this.Id = id;
            // to ensure "name" is required (not null)
            if (name == null) {
                throw new ArgumentNullException("name is a required property for CompanyResponseCompanyTaxes and cannot be null");
            }
            this.Name = name;
        }

        /// <summary>
        /// 税区分ID（廃止予定。tax_codeを使用してください。）
        /// </summary>
        /// <value>税区分ID（廃止予定。tax_codeを使用してください。）</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// 税区分名
        /// </summary>
        /// <value>税区分名</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CompanyResponseCompanyTaxes {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as CompanyResponseCompanyTaxes);
        }

        /// <summary>
        /// Returns true if CompanyResponseCompanyTaxes instances are equal
        /// </summary>
        /// <param name="input">Instance of CompanyResponseCompanyTaxes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompanyResponseCompanyTaxes input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                hashCode = (hashCode * 59) + this.Id.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
