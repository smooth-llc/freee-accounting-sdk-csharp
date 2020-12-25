/*
 * freee API
 *
 *  <h1 id=\"freee_api\">freee API</h1> <hr /> <h2 id=\"start_guide\">スタートガイド</h2>  <p>freee API開発がはじめての方は<a href=\"https://developer.freee.co.jp/getting-started\">freee API スタートガイド</a>を参照してください。</p>  <hr /> <h2 id=\"specification\">仕様</h2>  <pre><code>【重要】会計freee APIの新バージョンについて 2020年12月まで、2つのバージョンが利用できる状態です。古いものは2020年12月に利用不可となります。<br> 新しいAPIを利用するにはリクエストヘッダーに以下を指定します。 X-Api-Version: 2020-06-15<br> 指定がない場合は2020年12月に廃止予定のAPIを利用することとなります。<br> 【重要】APIのバージョン指定をせずに利用し続ける場合 2020年12月に新しいバージョンのAPIに自動的に切り替わります。 詳細は、<a href=\"https://developer.freee.co.jp/release-note/2948\" target=\"_blank\">リリースノート</a>をご覧ください。<br> 旧バージョンのAPIリファレンスを確認したい場合は、<a href=\"https://freee.github.io/freee-api-schema/\" target=\"_blank\">旧バージョンのAPIリファレンスページ</a>をご覧ください。 </code></pre>  <h3 id=\"api_endpoint\">APIエンドポイント</h3>  <p>https://api.freee.co.jp/ (httpsのみ)</p>  <h3 id=\"about_authorize\">認証について</h3> <p>OAuth2.0を利用します。詳細は<a href=\"https://developer.freee.co.jp/docs\" target=\"_blank\">ドキュメントの認証</a>パートを参照してください。</p>  <h3 id=\"data_format\">データフォーマット</h3>  <p>リクエスト、レスポンスともにJSON形式をサポートしていますが、詳細は、API毎の説明欄（application/jsonなど）を確認してください。</p>  <h3 id=\"compatibility\">後方互換性ありの変更</h3>  <p>freeeでは、APIを改善していくために以下のような変更は後方互換性ありとして通知なく変更を入れることがあります。アプリケーション実装者は以下を踏まえて開発を行ってください。</p>  <ul> <li>新しいAPIリソース・エンドポイントの追加</li> <li>既存のAPIに対して必須ではない新しいリクエストパラメータの追加</li> <li>既存のAPIレスポンスに対する新しいプロパティの追加</li> <li>既存のAPIレスポンスに対するプロパティの順番の入れ変え</li> <li>keyとなっているidやcodeの長さの変更（長くする）</li> </ul>  <h3 id=\"common_response_header\">共通レスポンスヘッダー</h3>  <p>すべてのAPIのレスポンスには以下のHTTPヘッダーが含まれます。</p>  <ul> <li> <p>X-Freee-Request-ID</p> <ul> <li>各リクエスト毎に発行されるID</li> </ul> </li> </ul>  <h3 id=\"common_error_response\">共通エラーレスポンス</h3>  <ul> <li> <p>ステータスコードはレスポンス内のJSONに含まれる他、HTTPヘッダにも含まれる</p> </li> <li> <p>一部のエラーレスポンスにはエラーコードが含まれます。<br>詳細は、<a href=\"https://developer.freee.co.jp/tips/faq/40x-checkpoint\">HTTPステータスコード400台エラー時のチェックポイント</a>を参照してください</p> </li> <p>type</p>  <ul> <li>status : HTTPステータスコードの説明</li>  <li>validation : エラーの詳細の説明（開発者向け）</li> </ul> </li> </ul>  <p>レスポンスの例</p>  <pre><code>  {     &quot;status_code&quot; : 400,     &quot;errors&quot; : [       {         &quot;type&quot; : &quot;status&quot;,         &quot;messages&quot; : [&quot;不正なリクエストです。&quot;]       },       {         &quot;type&quot; : &quot;validation&quot;,         &quot;messages&quot; : [&quot;Date は不正な日付フォーマットです。入力例：2013-01-01&quot;]       }     ]   }</code></pre>  </br>  <h3 id=\"api_rate_limit\">API使用制限</h3>    <p>freeeは一定期間に過度のアクセスを検知した場合、APIアクセスをコントロールする場合があります。</p>   <p>その際のhttp status codeは403となります。制限がかかってから10分程度が過ぎると再度使用することができるようになります。</p>  <h4 id=\"reports_api_endpoint\">/reportsエンドポイント</h4>  <p>freeeは/reportsエンドポイントに対して1秒間に10以上のアクセスを検知した場合、APIアクセスをコントロールする場合があります。その際のhttp status codeは429（too many requests）となります。</p>  <p>レスポンスボディのmetaプロパティに以下を含めます。</p>  <ul>   <li>設定されている上限値</li>   <li>上限に達するまでの使用可能回数</li>   <li>（上限値に達した場合）使用回数がリセットされる時刻</li> </ul>  <h3 id=\"plan_api_rate_limit\">プラン別のAPI Rate Limit</h3>   <table border=\"1\">     <tbody>       <tr>         <th style=\"padding: 10px\"><strong>会計freeeプラン名</strong></th>         <th style=\"padding: 10px\"><strong>事業所とアプリケーション毎に1日でのAPIコール数</strong></th>       </tr>       <tr>         <td style=\"padding: 10px\">エンタープライズ</td>         <td style=\"padding: 10px\">10,000</td>       </tr>       <tr>         <td style=\"padding: 10px\">プロフェッショナル</td>         <td style=\"padding: 10px\">5,000</td>       </tr>       <tr>         <td style=\"padding: 10px\">ベーシック</td>         <td style=\"padding: 10px\">3,000</td>       </tr>       <tr>         <td style=\"padding: 10px\">ミニマム</td>         <td style=\"padding: 10px\">3,000</td>       </tr>       <tr>         <td style=\"padding: 10px\">上記以外</td>         <td style=\"padding: 10px\">3,000</td>       </tr>     </tbody>   </table>  <h3 id=\"webhook\">Webhookについて</h3>  <p>詳細は<a href=\"https://developer.freee.co.jp/docs/accounting/webhook\" target=\"_blank\">会計Webhook概要</a>を参照してください。</p>  <hr /> <h2 id=\"contact\">連絡先</h2>  <p>ご不明点、ご要望等は <a href=\"https://support.freee.co.jp/hc/ja/requests/new\">freee サポートデスクへのお問い合わせフォーム</a> からご連絡ください。</p> <hr />&copy; Since 2013 freee K.K.
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
using OpenAPIDateConverter = Freee.Accounting.Client.OpenAPIDateConverter;

namespace Freee.Accounting.Models
{
    /// <summary>
    /// PartnersResponsePartners
    /// </summary>
    [DataContract(Name = "partnersResponse_partners")]
    public partial class PartnersResponsePartners : IEquatable<PartnersResponsePartners>
    {
        /// <summary>
        /// 口座種別(ordinary:普通、checking:当座、earmarked:納税準備預金、savings:貯蓄、other:その他)
        /// </summary>
        /// <value>口座種別(ordinary:普通、checking:当座、earmarked:納税準備預金、savings:貯蓄、other:その他)</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PartnerBankAccountAttributesAccountTypeEnum
        {
            /// <summary>
            /// Enum Ordinary for value: ordinary
            /// </summary>
            [EnumMember(Value = "ordinary")]
            Ordinary = 1,

            /// <summary>
            /// Enum Checking for value: checking
            /// </summary>
            [EnumMember(Value = "checking")]
            Checking = 2,

            /// <summary>
            /// Enum Earmarked for value: earmarked
            /// </summary>
            [EnumMember(Value = "earmarked")]
            Earmarked = 3,

            /// <summary>
            /// Enum Savings for value: savings
            /// </summary>
            [EnumMember(Value = "savings")]
            Savings = 4,

            /// <summary>
            /// Enum Other for value: other
            /// </summary>
            [EnumMember(Value = "other")]
            Other = 5

        }

        /// <summary>
        /// 口座種別(ordinary:普通、checking:当座、earmarked:納税準備預金、savings:貯蓄、other:その他)
        /// </summary>
        /// <value>口座種別(ordinary:普通、checking:当座、earmarked:納税準備預金、savings:貯蓄、other:その他)</value>
        [DataMember(Name = "partner_bank_account_attributes[account_type]", EmitDefaultValue = true)]
        public PartnerBankAccountAttributesAccountTypeEnum? PartnerBankAccountAttributesAccountType { get; set; }
        /// <summary>
        /// 請求書送付方法(mail:メール、posting:郵送、mail_and_posting:メールと郵送)
        /// </summary>
        /// <value>請求書送付方法(mail:メール、posting:郵送、mail_and_posting:メールと郵送)</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PartnerDocSettingAttributesSendingMethodEnum
        {
            /// <summary>
            /// Enum Mail for value: mail
            /// </summary>
            [EnumMember(Value = "mail")]
            Mail = 1,

            /// <summary>
            /// Enum Posting for value: posting
            /// </summary>
            [EnumMember(Value = "posting")]
            Posting = 2,

            /// <summary>
            /// Enum Mainandposting for value: main_and_posting
            /// </summary>
            [EnumMember(Value = "main_and_posting")]
            Mainandposting = 3

        }

        /// <summary>
        /// 請求書送付方法(mail:メール、posting:郵送、mail_and_posting:メールと郵送)
        /// </summary>
        /// <value>請求書送付方法(mail:メール、posting:郵送、mail_and_posting:メールと郵送)</value>
        [DataMember(Name = "partner_doc_setting_attributes[sending_method]", EmitDefaultValue = true)]
        public PartnerDocSettingAttributesSendingMethodEnum? PartnerDocSettingAttributesSendingMethod { get; set; }
        /// <summary>
        /// 振込手数料負担（一括振込ファイル用）: (振込元(当方): payer, 振込先(先方): payee)
        /// </summary>
        /// <value>振込手数料負担（一括振込ファイル用）: (振込元(当方): payer, 振込先(先方): payee)</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TransferFeeHandlingSideEnum
        {
            /// <summary>
            /// Enum Payer for value: payer
            /// </summary>
            [EnumMember(Value = "payer")]
            Payer = 1,

            /// <summary>
            /// Enum Payee for value: payee
            /// </summary>
            [EnumMember(Value = "payee")]
            Payee = 2

        }

        /// <summary>
        /// 振込手数料負担（一括振込ファイル用）: (振込元(当方): payer, 振込先(先方): payee)
        /// </summary>
        /// <value>振込手数料負担（一括振込ファイル用）: (振込元(当方): payer, 振込先(先方): payee)</value>
        [DataMember(Name = "transfer_fee_handling_side", EmitDefaultValue = false)]
        public TransferFeeHandlingSideEnum? TransferFeeHandlingSide { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PartnersResponsePartners" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PartnersResponsePartners() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PartnersResponsePartners" /> class.
        /// </summary>
        /// <param name="addressAttributes">addressAttributes.</param>
        /// <param name="code">取引先コード (required).</param>
        /// <param name="companyId">事業所ID (required).</param>
        /// <param name="contactName">担当者 氏名.</param>
        /// <param name="countryCode">地域（JP: 国内、ZZ:国外）.</param>
        /// <param name="defaultTitle">敬称（御中、様、(空白)の3つから選択）.</param>
        /// <param name="email">担当者 メールアドレス.</param>
        /// <param name="id">取引先ID (required).</param>
        /// <param name="longName">正式名称（255文字以内）.</param>
        /// <param name="name">取引先名 (required).</param>
        /// <param name="nameKana">カナ名称（255文字以内）.</param>
        /// <param name="orgCode">事業所種別（null: 未設定、1: 法人、2: 個人）.</param>
        /// <param name="partnerBankAccountAttributesAccountName">受取人名（カナ）.</param>
        /// <param name="partnerBankAccountAttributesAccountNumber">口座番号.</param>
        /// <param name="partnerBankAccountAttributesAccountType">口座種別(ordinary:普通、checking:当座、earmarked:納税準備預金、savings:貯蓄、other:その他).</param>
        /// <param name="partnerBankAccountAttributesBankCode">銀行番号.</param>
        /// <param name="partnerBankAccountAttributesBankName">銀行名.</param>
        /// <param name="partnerBankAccountAttributesBankNameKana">銀行名（カナ）.</param>
        /// <param name="partnerBankAccountAttributesBranchCode">支店番号.</param>
        /// <param name="partnerBankAccountAttributesBranchKana">支店名（カナ）.</param>
        /// <param name="partnerBankAccountAttributesBranchName">支店名.</param>
        /// <param name="partnerBankAccountAttributesLongAccountName">受取人名.</param>
        /// <param name="partnerDocSettingAttributesSendingMethod">請求書送付方法(mail:メール、posting:郵送、mail_and_posting:メールと郵送).</param>
        /// <param name="payerWalletableId">振込元口座ID（一括振込ファイル用）:（未設定の場合は、nullです。）.</param>
        /// <param name="phone">電話番号.</param>
        /// <param name="shortcut1">ショートカット1 (20文字以内).</param>
        /// <param name="shortcut2">ショートカット2 (20文字以内).</param>
        /// <param name="transferFeeHandlingSide">振込手数料負担（一括振込ファイル用）: (振込元(当方): payer, 振込先(先方): payee).</param>
        public PartnersResponsePartners(PartnerResponsePartnerAddressAttributes addressAttributes = default(PartnerResponsePartnerAddressAttributes), string code = default(string), int companyId = default(int), string contactName = default(string), string countryCode = default(string), string defaultTitle = default(string), string email = default(string), int id = default(int), string longName = default(string), string name = default(string), string nameKana = default(string), int? orgCode = default(int?), string partnerBankAccountAttributesAccountName = default(string), string partnerBankAccountAttributesAccountNumber = default(string), PartnerBankAccountAttributesAccountTypeEnum? partnerBankAccountAttributesAccountType = default(PartnerBankAccountAttributesAccountTypeEnum?), string partnerBankAccountAttributesBankCode = default(string), string partnerBankAccountAttributesBankName = default(string), string partnerBankAccountAttributesBankNameKana = default(string), string partnerBankAccountAttributesBranchCode = default(string), string partnerBankAccountAttributesBranchKana = default(string), string partnerBankAccountAttributesBranchName = default(string), string partnerBankAccountAttributesLongAccountName = default(string), PartnerDocSettingAttributesSendingMethodEnum? partnerDocSettingAttributesSendingMethod = default(PartnerDocSettingAttributesSendingMethodEnum?), int? payerWalletableId = default(int?), string phone = default(string), string shortcut1 = default(string), string shortcut2 = default(string), TransferFeeHandlingSideEnum? transferFeeHandlingSide = default(TransferFeeHandlingSideEnum?))
        {
            // to ensure "code" is required (not null)
            this.Code = code ?? throw new ArgumentNullException("code is a required property for PartnersResponsePartners and cannot be null");
            this.CompanyId = companyId;
            this.Id = id;
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for PartnersResponsePartners and cannot be null");
            this.AddressAttributes = addressAttributes;
            this.ContactName = contactName;
            this.CountryCode = countryCode;
            this.DefaultTitle = defaultTitle;
            this.Email = email;
            this.LongName = longName;
            this.NameKana = nameKana;
            this.OrgCode = orgCode;
            this.PartnerBankAccountAttributesAccountName = partnerBankAccountAttributesAccountName;
            this.PartnerBankAccountAttributesAccountNumber = partnerBankAccountAttributesAccountNumber;
            this.PartnerBankAccountAttributesAccountType = partnerBankAccountAttributesAccountType;
            this.PartnerBankAccountAttributesBankCode = partnerBankAccountAttributesBankCode;
            this.PartnerBankAccountAttributesBankName = partnerBankAccountAttributesBankName;
            this.PartnerBankAccountAttributesBankNameKana = partnerBankAccountAttributesBankNameKana;
            this.PartnerBankAccountAttributesBranchCode = partnerBankAccountAttributesBranchCode;
            this.PartnerBankAccountAttributesBranchKana = partnerBankAccountAttributesBranchKana;
            this.PartnerBankAccountAttributesBranchName = partnerBankAccountAttributesBranchName;
            this.PartnerBankAccountAttributesLongAccountName = partnerBankAccountAttributesLongAccountName;
            this.PartnerDocSettingAttributesSendingMethod = partnerDocSettingAttributesSendingMethod;
            this.PayerWalletableId = payerWalletableId;
            this.Phone = phone;
            this.Shortcut1 = shortcut1;
            this.Shortcut2 = shortcut2;
            this.TransferFeeHandlingSide = transferFeeHandlingSide;
        }

        /// <summary>
        /// Gets or Sets AddressAttributes
        /// </summary>
        [DataMember(Name = "address_attributes", EmitDefaultValue = false)]
        public PartnerResponsePartnerAddressAttributes AddressAttributes { get; set; }

        /// <summary>
        /// 取引先コード
        /// </summary>
        /// <value>取引先コード</value>
        [DataMember(Name = "code", EmitDefaultValue = true)]
        public string Code { get; set; }

        /// <summary>
        /// 事業所ID
        /// </summary>
        /// <value>事業所ID</value>
        [DataMember(Name = "company_id", EmitDefaultValue = false)]
        public int CompanyId { get; set; }

        /// <summary>
        /// 担当者 氏名
        /// </summary>
        /// <value>担当者 氏名</value>
        [DataMember(Name = "contact_name", EmitDefaultValue = true)]
        public string ContactName { get; set; }

        /// <summary>
        /// 地域（JP: 国内、ZZ:国外）
        /// </summary>
        /// <value>地域（JP: 国内、ZZ:国外）</value>
        [DataMember(Name = "country_code", EmitDefaultValue = false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// 敬称（御中、様、(空白)の3つから選択）
        /// </summary>
        /// <value>敬称（御中、様、(空白)の3つから選択）</value>
        [DataMember(Name = "default_title", EmitDefaultValue = true)]
        public string DefaultTitle { get; set; }

        /// <summary>
        /// 担当者 メールアドレス
        /// </summary>
        /// <value>担当者 メールアドレス</value>
        [DataMember(Name = "email", EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// 取引先ID
        /// </summary>
        /// <value>取引先ID</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// 正式名称（255文字以内）
        /// </summary>
        /// <value>正式名称（255文字以内）</value>
        [DataMember(Name = "long_name", EmitDefaultValue = true)]
        public string LongName { get; set; }

        /// <summary>
        /// 取引先名
        /// </summary>
        /// <value>取引先名</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// カナ名称（255文字以内）
        /// </summary>
        /// <value>カナ名称（255文字以内）</value>
        [DataMember(Name = "name_kana", EmitDefaultValue = true)]
        public string NameKana { get; set; }

        /// <summary>
        /// 事業所種別（null: 未設定、1: 法人、2: 個人）
        /// </summary>
        /// <value>事業所種別（null: 未設定、1: 法人、2: 個人）</value>
        [DataMember(Name = "org_code", EmitDefaultValue = true)]
        public int? OrgCode { get; set; }

        /// <summary>
        /// 受取人名（カナ）
        /// </summary>
        /// <value>受取人名（カナ）</value>
        [DataMember(Name = "partner_bank_account_attributes[account_name]", EmitDefaultValue = true)]
        public string PartnerBankAccountAttributesAccountName { get; set; }

        /// <summary>
        /// 口座番号
        /// </summary>
        /// <value>口座番号</value>
        [DataMember(Name = "partner_bank_account_attributes[account_number]", EmitDefaultValue = true)]
        public string PartnerBankAccountAttributesAccountNumber { get; set; }

        /// <summary>
        /// 銀行番号
        /// </summary>
        /// <value>銀行番号</value>
        [DataMember(Name = "partner_bank_account_attributes[bank_code]", EmitDefaultValue = true)]
        public string PartnerBankAccountAttributesBankCode { get; set; }

        /// <summary>
        /// 銀行名
        /// </summary>
        /// <value>銀行名</value>
        [DataMember(Name = "partner_bank_account_attributes[bank_name]", EmitDefaultValue = true)]
        public string PartnerBankAccountAttributesBankName { get; set; }

        /// <summary>
        /// 銀行名（カナ）
        /// </summary>
        /// <value>銀行名（カナ）</value>
        [DataMember(Name = "partner_bank_account_attributes[bank_name_kana]", EmitDefaultValue = true)]
        public string PartnerBankAccountAttributesBankNameKana { get; set; }

        /// <summary>
        /// 支店番号
        /// </summary>
        /// <value>支店番号</value>
        [DataMember(Name = "partner_bank_account_attributes[branch_code]", EmitDefaultValue = true)]
        public string PartnerBankAccountAttributesBranchCode { get; set; }

        /// <summary>
        /// 支店名（カナ）
        /// </summary>
        /// <value>支店名（カナ）</value>
        [DataMember(Name = "partner_bank_account_attributes[branch_kana]", EmitDefaultValue = true)]
        public string PartnerBankAccountAttributesBranchKana { get; set; }

        /// <summary>
        /// 支店名
        /// </summary>
        /// <value>支店名</value>
        [DataMember(Name = "partner_bank_account_attributes[branch_name]", EmitDefaultValue = true)]
        public string PartnerBankAccountAttributesBranchName { get; set; }

        /// <summary>
        /// 受取人名
        /// </summary>
        /// <value>受取人名</value>
        [DataMember(Name = "partner_bank_account_attributes[long_account_name]", EmitDefaultValue = true)]
        public string PartnerBankAccountAttributesLongAccountName { get; set; }

        /// <summary>
        /// 振込元口座ID（一括振込ファイル用）:（未設定の場合は、nullです。）
        /// </summary>
        /// <value>振込元口座ID（一括振込ファイル用）:（未設定の場合は、nullです。）</value>
        [DataMember(Name = "payer_walletable_id", EmitDefaultValue = true)]
        public int? PayerWalletableId { get; set; }

        /// <summary>
        /// 電話番号
        /// </summary>
        /// <value>電話番号</value>
        [DataMember(Name = "phone", EmitDefaultValue = true)]
        public string Phone { get; set; }

        /// <summary>
        /// ショートカット1 (20文字以内)
        /// </summary>
        /// <value>ショートカット1 (20文字以内)</value>
        [DataMember(Name = "shortcut1", EmitDefaultValue = true)]
        public string Shortcut1 { get; set; }

        /// <summary>
        /// ショートカット2 (20文字以内)
        /// </summary>
        /// <value>ショートカット2 (20文字以内)</value>
        [DataMember(Name = "shortcut2", EmitDefaultValue = true)]
        public string Shortcut2 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PartnersResponsePartners {\n");
            sb.Append("  AddressAttributes: ").Append(AddressAttributes).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  CompanyId: ").Append(CompanyId).Append("\n");
            sb.Append("  ContactName: ").Append(ContactName).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  DefaultTitle: ").Append(DefaultTitle).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LongName: ").Append(LongName).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  NameKana: ").Append(NameKana).Append("\n");
            sb.Append("  OrgCode: ").Append(OrgCode).Append("\n");
            sb.Append("  PartnerBankAccountAttributesAccountName: ").Append(PartnerBankAccountAttributesAccountName).Append("\n");
            sb.Append("  PartnerBankAccountAttributesAccountNumber: ").Append(PartnerBankAccountAttributesAccountNumber).Append("\n");
            sb.Append("  PartnerBankAccountAttributesAccountType: ").Append(PartnerBankAccountAttributesAccountType).Append("\n");
            sb.Append("  PartnerBankAccountAttributesBankCode: ").Append(PartnerBankAccountAttributesBankCode).Append("\n");
            sb.Append("  PartnerBankAccountAttributesBankName: ").Append(PartnerBankAccountAttributesBankName).Append("\n");
            sb.Append("  PartnerBankAccountAttributesBankNameKana: ").Append(PartnerBankAccountAttributesBankNameKana).Append("\n");
            sb.Append("  PartnerBankAccountAttributesBranchCode: ").Append(PartnerBankAccountAttributesBranchCode).Append("\n");
            sb.Append("  PartnerBankAccountAttributesBranchKana: ").Append(PartnerBankAccountAttributesBranchKana).Append("\n");
            sb.Append("  PartnerBankAccountAttributesBranchName: ").Append(PartnerBankAccountAttributesBranchName).Append("\n");
            sb.Append("  PartnerBankAccountAttributesLongAccountName: ").Append(PartnerBankAccountAttributesLongAccountName).Append("\n");
            sb.Append("  PartnerDocSettingAttributesSendingMethod: ").Append(PartnerDocSettingAttributesSendingMethod).Append("\n");
            sb.Append("  PayerWalletableId: ").Append(PayerWalletableId).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  Shortcut1: ").Append(Shortcut1).Append("\n");
            sb.Append("  Shortcut2: ").Append(Shortcut2).Append("\n");
            sb.Append("  TransferFeeHandlingSide: ").Append(TransferFeeHandlingSide).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as PartnersResponsePartners);
        }

        /// <summary>
        /// Returns true if PartnersResponsePartners instances are equal
        /// </summary>
        /// <param name="input">Instance of PartnersResponsePartners to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PartnersResponsePartners input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AddressAttributes == input.AddressAttributes ||
                    (this.AddressAttributes != null &&
                    this.AddressAttributes.Equals(input.AddressAttributes))
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.CompanyId == input.CompanyId ||
                    this.CompanyId.Equals(input.CompanyId)
                ) && 
                (
                    this.ContactName == input.ContactName ||
                    (this.ContactName != null &&
                    this.ContactName.Equals(input.ContactName))
                ) && 
                (
                    this.CountryCode == input.CountryCode ||
                    (this.CountryCode != null &&
                    this.CountryCode.Equals(input.CountryCode))
                ) && 
                (
                    this.DefaultTitle == input.DefaultTitle ||
                    (this.DefaultTitle != null &&
                    this.DefaultTitle.Equals(input.DefaultTitle))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.LongName == input.LongName ||
                    (this.LongName != null &&
                    this.LongName.Equals(input.LongName))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.NameKana == input.NameKana ||
                    (this.NameKana != null &&
                    this.NameKana.Equals(input.NameKana))
                ) && 
                (
                    this.OrgCode == input.OrgCode ||
                    (this.OrgCode != null &&
                    this.OrgCode.Equals(input.OrgCode))
                ) && 
                (
                    this.PartnerBankAccountAttributesAccountName == input.PartnerBankAccountAttributesAccountName ||
                    (this.PartnerBankAccountAttributesAccountName != null &&
                    this.PartnerBankAccountAttributesAccountName.Equals(input.PartnerBankAccountAttributesAccountName))
                ) && 
                (
                    this.PartnerBankAccountAttributesAccountNumber == input.PartnerBankAccountAttributesAccountNumber ||
                    (this.PartnerBankAccountAttributesAccountNumber != null &&
                    this.PartnerBankAccountAttributesAccountNumber.Equals(input.PartnerBankAccountAttributesAccountNumber))
                ) && 
                (
                    this.PartnerBankAccountAttributesAccountType == input.PartnerBankAccountAttributesAccountType ||
                    this.PartnerBankAccountAttributesAccountType.Equals(input.PartnerBankAccountAttributesAccountType)
                ) && 
                (
                    this.PartnerBankAccountAttributesBankCode == input.PartnerBankAccountAttributesBankCode ||
                    (this.PartnerBankAccountAttributesBankCode != null &&
                    this.PartnerBankAccountAttributesBankCode.Equals(input.PartnerBankAccountAttributesBankCode))
                ) && 
                (
                    this.PartnerBankAccountAttributesBankName == input.PartnerBankAccountAttributesBankName ||
                    (this.PartnerBankAccountAttributesBankName != null &&
                    this.PartnerBankAccountAttributesBankName.Equals(input.PartnerBankAccountAttributesBankName))
                ) && 
                (
                    this.PartnerBankAccountAttributesBankNameKana == input.PartnerBankAccountAttributesBankNameKana ||
                    (this.PartnerBankAccountAttributesBankNameKana != null &&
                    this.PartnerBankAccountAttributesBankNameKana.Equals(input.PartnerBankAccountAttributesBankNameKana))
                ) && 
                (
                    this.PartnerBankAccountAttributesBranchCode == input.PartnerBankAccountAttributesBranchCode ||
                    (this.PartnerBankAccountAttributesBranchCode != null &&
                    this.PartnerBankAccountAttributesBranchCode.Equals(input.PartnerBankAccountAttributesBranchCode))
                ) && 
                (
                    this.PartnerBankAccountAttributesBranchKana == input.PartnerBankAccountAttributesBranchKana ||
                    (this.PartnerBankAccountAttributesBranchKana != null &&
                    this.PartnerBankAccountAttributesBranchKana.Equals(input.PartnerBankAccountAttributesBranchKana))
                ) && 
                (
                    this.PartnerBankAccountAttributesBranchName == input.PartnerBankAccountAttributesBranchName ||
                    (this.PartnerBankAccountAttributesBranchName != null &&
                    this.PartnerBankAccountAttributesBranchName.Equals(input.PartnerBankAccountAttributesBranchName))
                ) && 
                (
                    this.PartnerBankAccountAttributesLongAccountName == input.PartnerBankAccountAttributesLongAccountName ||
                    (this.PartnerBankAccountAttributesLongAccountName != null &&
                    this.PartnerBankAccountAttributesLongAccountName.Equals(input.PartnerBankAccountAttributesLongAccountName))
                ) && 
                (
                    this.PartnerDocSettingAttributesSendingMethod == input.PartnerDocSettingAttributesSendingMethod ||
                    this.PartnerDocSettingAttributesSendingMethod.Equals(input.PartnerDocSettingAttributesSendingMethod)
                ) && 
                (
                    this.PayerWalletableId == input.PayerWalletableId ||
                    (this.PayerWalletableId != null &&
                    this.PayerWalletableId.Equals(input.PayerWalletableId))
                ) && 
                (
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
                ) && 
                (
                    this.Shortcut1 == input.Shortcut1 ||
                    (this.Shortcut1 != null &&
                    this.Shortcut1.Equals(input.Shortcut1))
                ) && 
                (
                    this.Shortcut2 == input.Shortcut2 ||
                    (this.Shortcut2 != null &&
                    this.Shortcut2.Equals(input.Shortcut2))
                ) && 
                (
                    this.TransferFeeHandlingSide == input.TransferFeeHandlingSide ||
                    this.TransferFeeHandlingSide.Equals(input.TransferFeeHandlingSide)
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
                if (this.AddressAttributes != null)
                    hashCode = hashCode * 59 + this.AddressAttributes.GetHashCode();
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                hashCode = hashCode * 59 + this.CompanyId.GetHashCode();
                if (this.ContactName != null)
                    hashCode = hashCode * 59 + this.ContactName.GetHashCode();
                if (this.CountryCode != null)
                    hashCode = hashCode * 59 + this.CountryCode.GetHashCode();
                if (this.DefaultTitle != null)
                    hashCode = hashCode * 59 + this.DefaultTitle.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.LongName != null)
                    hashCode = hashCode * 59 + this.LongName.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.NameKana != null)
                    hashCode = hashCode * 59 + this.NameKana.GetHashCode();
                if (this.OrgCode != null)
                    hashCode = hashCode * 59 + this.OrgCode.GetHashCode();
                if (this.PartnerBankAccountAttributesAccountName != null)
                    hashCode = hashCode * 59 + this.PartnerBankAccountAttributesAccountName.GetHashCode();
                if (this.PartnerBankAccountAttributesAccountNumber != null)
                    hashCode = hashCode * 59 + this.PartnerBankAccountAttributesAccountNumber.GetHashCode();
                hashCode = hashCode * 59 + this.PartnerBankAccountAttributesAccountType.GetHashCode();
                if (this.PartnerBankAccountAttributesBankCode != null)
                    hashCode = hashCode * 59 + this.PartnerBankAccountAttributesBankCode.GetHashCode();
                if (this.PartnerBankAccountAttributesBankName != null)
                    hashCode = hashCode * 59 + this.PartnerBankAccountAttributesBankName.GetHashCode();
                if (this.PartnerBankAccountAttributesBankNameKana != null)
                    hashCode = hashCode * 59 + this.PartnerBankAccountAttributesBankNameKana.GetHashCode();
                if (this.PartnerBankAccountAttributesBranchCode != null)
                    hashCode = hashCode * 59 + this.PartnerBankAccountAttributesBranchCode.GetHashCode();
                if (this.PartnerBankAccountAttributesBranchKana != null)
                    hashCode = hashCode * 59 + this.PartnerBankAccountAttributesBranchKana.GetHashCode();
                if (this.PartnerBankAccountAttributesBranchName != null)
                    hashCode = hashCode * 59 + this.PartnerBankAccountAttributesBranchName.GetHashCode();
                if (this.PartnerBankAccountAttributesLongAccountName != null)
                    hashCode = hashCode * 59 + this.PartnerBankAccountAttributesLongAccountName.GetHashCode();
                hashCode = hashCode * 59 + this.PartnerDocSettingAttributesSendingMethod.GetHashCode();
                if (this.PayerWalletableId != null)
                    hashCode = hashCode * 59 + this.PayerWalletableId.GetHashCode();
                if (this.Phone != null)
                    hashCode = hashCode * 59 + this.Phone.GetHashCode();
                if (this.Shortcut1 != null)
                    hashCode = hashCode * 59 + this.Shortcut1.GetHashCode();
                if (this.Shortcut2 != null)
                    hashCode = hashCode * 59 + this.Shortcut2.GetHashCode();
                hashCode = hashCode * 59 + this.TransferFeeHandlingSide.GetHashCode();
                return hashCode;
            }
        }

    }

}
