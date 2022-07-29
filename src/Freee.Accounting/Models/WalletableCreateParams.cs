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
    /// WalletableCreateParams
    /// </summary>
    [DataContract(Name = "walletableCreateParams")]
    public partial class WalletableCreateParams : IEquatable<WalletableCreateParams>
    {
        /// <summary>
        /// 口座種別（bank_account : 銀行口座, credit_card : クレジットカード, wallet : その他の決済口座）
        /// </summary>
        /// <value>口座種別（bank_account : 銀行口座, credit_card : クレジットカード, wallet : その他の決済口座）</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum BankAccount for value: bank_account
            /// </summary>
            [EnumMember(Value = "bank_account")]
            BankAccount = 1,

            /// <summary>
            /// Enum CreditCard for value: credit_card
            /// </summary>
            [EnumMember(Value = "credit_card")]
            CreditCard = 2,

            /// <summary>
            /// Enum Wallet for value: wallet
            /// </summary>
            [EnumMember(Value = "wallet")]
            Wallet = 3

        }


        /// <summary>
        /// 口座種別（bank_account : 銀行口座, credit_card : クレジットカード, wallet : その他の決済口座）
        /// </summary>
        /// <value>口座種別（bank_account : 銀行口座, credit_card : クレジットカード, wallet : その他の決済口座）</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WalletableCreateParams" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WalletableCreateParams() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WalletableCreateParams" /> class.
        /// </summary>
        /// <param name="bankId">連携サービスID（typeにbank_account、credit_cardを指定する場合は必須）.</param>
        /// <param name="companyId">事業所ID (required).</param>
        /// <param name="isAsset">口座を資産口座とするか負債口座とするか（true: 資産口座 (デフォルト), false: 負債口座）&lt;br&gt; bank_idを指定しない場合にのみ使われます。&lt;br&gt; bank_idを指定する場合には資産口座か負債口座かはbank_idに指定したサービスに応じて決定され、is_assetに指定した値は無視されます。 .</param>
        /// <param name="name">口座名 (255文字以内) (required).</param>
        /// <param name="type">口座種別（bank_account : 銀行口座, credit_card : クレジットカード, wallet : その他の決済口座） (required).</param>
        public WalletableCreateParams(int bankId = default(int), int companyId = default(int), bool isAsset = default(bool), string name = default(string), TypeEnum type = default(TypeEnum))
        {
            this.CompanyId = companyId;
            // to ensure "name" is required (not null)
            if (name == null) {
                throw new ArgumentNullException("name is a required property for WalletableCreateParams and cannot be null");
            }
            this.Name = name;
            this.Type = type;
            this.BankId = bankId;
            this.IsAsset = isAsset;
        }

        /// <summary>
        /// 連携サービスID（typeにbank_account、credit_cardを指定する場合は必須）
        /// </summary>
        /// <value>連携サービスID（typeにbank_account、credit_cardを指定する場合は必須）</value>
        [DataMember(Name = "bank_id", EmitDefaultValue = false)]
        public int BankId { get; set; }

        /// <summary>
        /// 事業所ID
        /// </summary>
        /// <value>事業所ID</value>
        [DataMember(Name = "company_id", IsRequired = true, EmitDefaultValue = false)]
        public int CompanyId { get; set; }

        /// <summary>
        /// 口座を資産口座とするか負債口座とするか（true: 資産口座 (デフォルト), false: 負債口座）&lt;br&gt; bank_idを指定しない場合にのみ使われます。&lt;br&gt; bank_idを指定する場合には資産口座か負債口座かはbank_idに指定したサービスに応じて決定され、is_assetに指定した値は無視されます。 
        /// </summary>
        /// <value>口座を資産口座とするか負債口座とするか（true: 資産口座 (デフォルト), false: 負債口座）&lt;br&gt; bank_idを指定しない場合にのみ使われます。&lt;br&gt; bank_idを指定する場合には資産口座か負債口座かはbank_idに指定したサービスに応じて決定され、is_assetに指定した値は無視されます。 </value>
        [DataMember(Name = "is_asset", EmitDefaultValue = true)]
        public bool IsAsset { get; set; }

        /// <summary>
        /// 口座名 (255文字以内)
        /// </summary>
        /// <value>口座名 (255文字以内)</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WalletableCreateParams {\n");
            sb.Append("  BankId: ").Append(BankId).Append("\n");
            sb.Append("  CompanyId: ").Append(CompanyId).Append("\n");
            sb.Append("  IsAsset: ").Append(IsAsset).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as WalletableCreateParams);
        }

        /// <summary>
        /// Returns true if WalletableCreateParams instances are equal
        /// </summary>
        /// <param name="input">Instance of WalletableCreateParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WalletableCreateParams input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BankId == input.BankId ||
                    this.BankId.Equals(input.BankId)
                ) && 
                (
                    this.CompanyId == input.CompanyId ||
                    this.CompanyId.Equals(input.CompanyId)
                ) && 
                (
                    this.IsAsset == input.IsAsset ||
                    this.IsAsset.Equals(input.IsAsset)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
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
                hashCode = (hashCode * 59) + this.BankId.GetHashCode();
                hashCode = (hashCode * 59) + this.CompanyId.GetHashCode();
                hashCode = (hashCode * 59) + this.IsAsset.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                return hashCode;
            }
        }

    }

}
