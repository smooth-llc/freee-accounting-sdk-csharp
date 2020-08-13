/*
 * freee API
 *
 *  <h1 id=\"freee_api\">freee API</h1> <hr /> <h2 id=\"start_guide\">スタートガイド</h2>  <p>freee API開発がはじめての方は<a href=\"https://developer.freee.co.jp/getting-started\">freee API スタートガイド</a>を参照してください。</p>  <hr /> <h2 id=\"specification\">仕様</h2>  <pre><code>【重要】会計freee APIの新バージョンについて 2020年12月まで、2つのバージョンが利用できる状態です。古いものは2020年12月に利用不可となります。<br> 新しいAPIを利用するにはリクエストヘッダーに以下を指定します。 X-Api-Version: 2020-06-15<br> 指定がない場合は2020年12月に廃止予定のAPIを利用することとなります。<br> 【重要】APIのバージョン指定をせずに利用し続ける場合 2020年12月に新しいバージョンのAPIに自動的に切り替わります。 詳細は、<a href=\"https://developer.freee.co.jp/release-note/2948\" target=\"_blank\">リリースノート</a>をご覧ください。<br> 旧バージョンのAPIリファレンスを確認したい場合は、<a href=\"https://freee.github.io/freee-api-schema/\" target=\"_blank\">旧バージョンのAPIリファレンスページ</a>をご覧ください。 </code></pre>  <h3 id=\"api_endpoint\">APIエンドポイント</h3>  <p>https://api.freee.co.jp/ (httpsのみ)</p>  <h3 id=\"about_authorize\">認証について</h3> <p>OAuth2.0を利用します。詳細は<a href=\"https://developer.freee.co.jp/docs\" target=\"_blank\">ドキュメントの認証</a>パートを参照してください。</p>  <h3 id=\"data_format\">データフォーマット</h3>  <p>リクエスト、レスポンスともにJSON形式をサポートしていますが、詳細は、API毎の説明欄（application/jsonなど）を確認してください。</p>  <h3 id=\"compatibility\">後方互換性ありの変更</h3>  <p>freeeでは、APIを改善していくために以下のような変更は後方互換性ありとして通知なく変更を入れることがあります。アプリケーション実装者は以下を踏まえて開発を行ってください。</p>  <ul> <li>新しいAPIリソース・エンドポイントの追加</li> <li>既存のAPIに対して必須ではない新しいリクエストパラメータの追加</li> <li>既存のAPIレスポンスに対する新しいプロパティの追加</li> <li>既存のAPIレスポンスに対するプロパティの順番の入れ変え</li> <li>keyとなっているidやcodeの長さの変更（長くする）</li> </ul>  <h3 id=\"common_response_header\">共通レスポンスヘッダー</h3>  <p>すべてのAPIのレスポンスには以下のHTTPヘッダーが含まれます。</p>  <ul> <li> <p>X-Freee-Request-ID</p> <ul> <li>各リクエスト毎に発行されるID</li> </ul> </li> </ul>  <h3 id=\"common_error_response\">共通エラーレスポンス</h3>  <ul> <li> <p>ステータスコードはレスポンス内のJSONに含まれる他、HTTPヘッダにも含まれる</p> </li> <li> <p>一部のエラーレスポンスにはエラーコードが含まれます。<br>詳細は、<a href=\"https://developer.freee.co.jp/tips/faq/40x-checkpoint\">HTTPステータスコード400台エラー時のチェックポイント</a>を参照してください</p> </li> <p>type</p>  <ul> <li>status : HTTPステータスコードの説明</li>  <li>validation : エラーの詳細の説明（開発者向け）</li> </ul> </li> </ul>  <p>レスポンスの例</p>  <pre><code>  {     &quot;status_code&quot; : 400,     &quot;errors&quot; : [       {         &quot;type&quot; : &quot;status&quot;,         &quot;messages&quot; : [&quot;不正なリクエストです。&quot;]       },       {         &quot;type&quot; : &quot;validation&quot;,         &quot;messages&quot; : [&quot;Date は不正な日付フォーマットです。入力例：2013-01-01&quot;]       }     ]   }</code></pre>  </br>  <h3 id=\"api_rate_limit\">API使用制限</h3>    <p>freeeは一定期間に過度のアクセスを検知した場合、APIアクセスをコントロールする場合があります。</p>   <p>その際のhttp status codeは403となります。制限がかかってから10分程度が過ぎると再度使用することができるようになります。</p>  <h4 id=\"reports_api_endpoint\">/reportsエンドポイント</h4>  <p>freeeは/reportsエンドポイントに対して1秒間に10以上のアクセスを検知した場合、APIアクセスをコントロールする場合があります。その際のhttp status codeは429（too many requests）となります。</p>  <p>レスポンスボディのmetaプロパティに以下を含めます。</p>  <ul>   <li>設定されている上限値</li>   <li>上限に達するまでの使用可能回数</li>   <li>（上限値に達した場合）使用回数がリセットされる時刻</li> </ul>  <h3 id=\"plan_api_rate_limit\">プラン別のAPI Rate Limit</h3>   <table border=\"1\">     <tbody>       <tr>         <th style=\"padding: 10px\"><strong>会計freeeプラン名</strong></th>         <th style=\"padding: 10px\"><strong>事業所とアプリケーション毎に1日でのAPIコール数</strong></th>       </tr>       <tr>         <td style=\"padding: 10px\">エンタープライズ</td>         <td style=\"padding: 10px\">10,000</td>       </tr>       <tr>         <td style=\"padding: 10px\">プロフェッショナル</td>         <td style=\"padding: 10px\">5,000</td>       </tr>       <tr>         <td style=\"padding: 10px\">ベーシック</td>         <td style=\"padding: 10px\">3,000</td>       </tr>       <tr>         <td style=\"padding: 10px\">ミニマム</td>         <td style=\"padding: 10px\">3,000</td>       </tr>       <tr>         <td style=\"padding: 10px\">上記以外</td>         <td style=\"padding: 10px\">3,000</td>       </tr>     </tbody>   </table>  <h3 id=\"webhook\">Webhookについて</h3>  <p>詳細は<a href=\"https://developer.freee.co.jp/docs/accounting/webhook\" target=\"_blank\">会計Webhook概要</a>を参照してください。</p>  <hr /> <h2 id=\"contact\">連絡先</h2>  <p>ご不明点、ご要望等は <a href=\"https://support.freee.co.jp/hc/ja/requests/new\">freee サポートデスクへのお問い合わせフォーム</a> からご連絡ください。</p> <hr />&copy; Since 2013 freee K.K.
 *
 * The version of the OpenAPI document: v1.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OpenAPIDateConverter = Freee.Accounting.Client.OpenAPIDateConverter;

namespace Freee.Accounting.Models
{
    /// <summary>
    /// TrialBsResponseTrialBs
    /// </summary>
    [DataContract]
    public partial class TrialBsResponseTrialBs :  IEquatable<TrialBsResponseTrialBs>
    {
        /// <summary>
        /// 勘定科目の表示（勘定科目: account_item, 決算書表示:group）(条件に指定した時のみ含まれる）
        /// </summary>
        /// <value>勘定科目の表示（勘定科目: account_item, 決算書表示:group）(条件に指定した時のみ含まれる）</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AccountItemDisplayTypeEnum
        {
            /// <summary>
            /// Enum Accountitem for value: account_item
            /// </summary>
            [EnumMember(Value = "account_item")]
            Accountitem = 1,

            /// <summary>
            /// Enum Group for value: group
            /// </summary>
            [EnumMember(Value = "group")]
            Group = 2

        }

        /// <summary>
        /// 勘定科目の表示（勘定科目: account_item, 決算書表示:group）(条件に指定した時のみ含まれる）
        /// </summary>
        /// <value>勘定科目の表示（勘定科目: account_item, 決算書表示:group）(条件に指定した時のみ含まれる）</value>
        [DataMember(Name="account_item_display_type", EmitDefaultValue=false)]
        public AccountItemDisplayTypeEnum? AccountItemDisplayType { get; set; }
        /// <summary>
        /// 決算整理仕訳のみ: only, 決算整理仕訳以外: without(条件に指定した時のみ含まれる）
        /// </summary>
        /// <value>決算整理仕訳のみ: only, 決算整理仕訳以外: without(条件に指定した時のみ含まれる）</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AdjustmentEnum
        {
            /// <summary>
            /// Enum Only for value: only
            /// </summary>
            [EnumMember(Value = "only")]
            Only = 1,

            /// <summary>
            /// Enum Without for value: without
            /// </summary>
            [EnumMember(Value = "without")]
            Without = 2

        }

        /// <summary>
        /// 決算整理仕訳のみ: only, 決算整理仕訳以外: without(条件に指定した時のみ含まれる）
        /// </summary>
        /// <value>決算整理仕訳のみ: only, 決算整理仕訳以外: without(条件に指定した時のみ含まれる）</value>
        [DataMember(Name="adjustment", EmitDefaultValue=false)]
        public AdjustmentEnum? Adjustment { get; set; }
        /// <summary>
        /// 内訳の表示（取引先: partner, 品目: item, 勘定科目: account_item）(条件に指定した時のみ含まれる）
        /// </summary>
        /// <value>内訳の表示（取引先: partner, 品目: item, 勘定科目: account_item）(条件に指定した時のみ含まれる）</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BreakdownDisplayTypeEnum
        {
            /// <summary>
            /// Enum Partner for value: partner
            /// </summary>
            [EnumMember(Value = "partner")]
            Partner = 1,

            /// <summary>
            /// Enum Item for value: item
            /// </summary>
            [EnumMember(Value = "item")]
            Item = 2,

            /// <summary>
            /// Enum Accountitem for value: account_item
            /// </summary>
            [EnumMember(Value = "account_item")]
            Accountitem = 3

        }

        /// <summary>
        /// 内訳の表示（取引先: partner, 品目: item, 勘定科目: account_item）(条件に指定した時のみ含まれる）
        /// </summary>
        /// <value>内訳の表示（取引先: partner, 品目: item, 勘定科目: account_item）(条件に指定した時のみ含まれる）</value>
        [DataMember(Name="breakdown_display_type", EmitDefaultValue=false)]
        public BreakdownDisplayTypeEnum? BreakdownDisplayType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TrialBsResponseTrialBs" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TrialBsResponseTrialBs() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TrialBsResponseTrialBs" /> class.
        /// </summary>
        /// <param name="accountItemDisplayType">勘定科目の表示（勘定科目: account_item, 決算書表示:group）(条件に指定した時のみ含まれる）.</param>
        /// <param name="adjustment">決算整理仕訳のみ: only, 決算整理仕訳以外: without(条件に指定した時のみ含まれる）.</param>
        /// <param name="balances">balances (required).</param>
        /// <param name="breakdownDisplayType">内訳の表示（取引先: partner, 品目: item, 勘定科目: account_item）(条件に指定した時のみ含まれる）.</param>
        /// <param name="companyId">事業所ID (required).</param>
        /// <param name="createdAt">作成日時.</param>
        /// <param name="endDate">発生日で絞込：終了日(yyyy-mm-dd)(条件に指定した時のみ含まれる）.</param>
        /// <param name="endMonth">発生月で絞込：終了会計月(1-12)(条件に指定した時のみ含まれる）.</param>
        /// <param name="fiscalYear">会計年度(条件に指定した時、または条件に月、日条件がない時のみ含まれる）.</param>
        /// <param name="itemId">品目ID(条件に指定した時のみ含まれる）.</param>
        /// <param name="partnerCode">取引先コード(条件に指定した時のみ含まれる）.</param>
        /// <param name="partnerId">取引先ID(条件に指定した時のみ含まれる）.</param>
        /// <param name="startDate">発生日で絞込：開始日(yyyy-mm-dd)(条件に指定した時のみ含まれる）.</param>
        /// <param name="startMonth">発生月で絞込：開始会計月(1-12)(条件に指定した時のみ含まれる）.</param>
        public TrialBsResponseTrialBs(AccountItemDisplayTypeEnum? accountItemDisplayType = default(AccountItemDisplayTypeEnum?), AdjustmentEnum? adjustment = default(AdjustmentEnum?), List<TrialBsResponseTrialBsBalances> balances = default(List<TrialBsResponseTrialBsBalances>), BreakdownDisplayTypeEnum? breakdownDisplayType = default(BreakdownDisplayTypeEnum?), int companyId = default(int), string createdAt = default(string), string endDate = default(string), int endMonth = default(int), int fiscalYear = default(int), int itemId = default(int), string partnerCode = default(string), int partnerId = default(int), string startDate = default(string), int startMonth = default(int))
        {
            // to ensure "balances" is required (not null)
            this.Balances = balances ?? throw new ArgumentNullException("balances is a required property for TrialBsResponseTrialBs and cannot be null");
            this.CompanyId = companyId;
            this.AccountItemDisplayType = accountItemDisplayType;
            this.Adjustment = adjustment;
            this.BreakdownDisplayType = breakdownDisplayType;
            this.CreatedAt = createdAt;
            this.EndDate = endDate;
            this.EndMonth = endMonth;
            this.FiscalYear = fiscalYear;
            this.ItemId = itemId;
            this.PartnerCode = partnerCode;
            this.PartnerId = partnerId;
            this.StartDate = startDate;
            this.StartMonth = startMonth;
        }

        /// <summary>
        /// Gets or Sets Balances
        /// </summary>
        [DataMember(Name="balances", EmitDefaultValue=false)]
        public List<TrialBsResponseTrialBsBalances> Balances { get; set; }

        /// <summary>
        /// 事業所ID
        /// </summary>
        /// <value>事業所ID</value>
        [DataMember(Name="company_id", EmitDefaultValue=false)]
        public int CompanyId { get; set; }

        /// <summary>
        /// 作成日時
        /// </summary>
        /// <value>作成日時</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// 発生日で絞込：終了日(yyyy-mm-dd)(条件に指定した時のみ含まれる）
        /// </summary>
        /// <value>発生日で絞込：終了日(yyyy-mm-dd)(条件に指定した時のみ含まれる）</value>
        [DataMember(Name="end_date", EmitDefaultValue=false)]
        public string EndDate { get; set; }

        /// <summary>
        /// 発生月で絞込：終了会計月(1-12)(条件に指定した時のみ含まれる）
        /// </summary>
        /// <value>発生月で絞込：終了会計月(1-12)(条件に指定した時のみ含まれる）</value>
        [DataMember(Name="end_month", EmitDefaultValue=false)]
        public int EndMonth { get; set; }

        /// <summary>
        /// 会計年度(条件に指定した時、または条件に月、日条件がない時のみ含まれる）
        /// </summary>
        /// <value>会計年度(条件に指定した時、または条件に月、日条件がない時のみ含まれる）</value>
        [DataMember(Name="fiscal_year", EmitDefaultValue=false)]
        public int FiscalYear { get; set; }

        /// <summary>
        /// 品目ID(条件に指定した時のみ含まれる）
        /// </summary>
        /// <value>品目ID(条件に指定した時のみ含まれる）</value>
        [DataMember(Name="item_id", EmitDefaultValue=false)]
        public int ItemId { get; set; }

        /// <summary>
        /// 取引先コード(条件に指定した時のみ含まれる）
        /// </summary>
        /// <value>取引先コード(条件に指定した時のみ含まれる）</value>
        [DataMember(Name="partner_code", EmitDefaultValue=false)]
        public string PartnerCode { get; set; }

        /// <summary>
        /// 取引先ID(条件に指定した時のみ含まれる）
        /// </summary>
        /// <value>取引先ID(条件に指定した時のみ含まれる）</value>
        [DataMember(Name="partner_id", EmitDefaultValue=false)]
        public int PartnerId { get; set; }

        /// <summary>
        /// 発生日で絞込：開始日(yyyy-mm-dd)(条件に指定した時のみ含まれる）
        /// </summary>
        /// <value>発生日で絞込：開始日(yyyy-mm-dd)(条件に指定した時のみ含まれる）</value>
        [DataMember(Name="start_date", EmitDefaultValue=false)]
        public string StartDate { get; set; }

        /// <summary>
        /// 発生月で絞込：開始会計月(1-12)(条件に指定した時のみ含まれる）
        /// </summary>
        /// <value>発生月で絞込：開始会計月(1-12)(条件に指定した時のみ含まれる）</value>
        [DataMember(Name="start_month", EmitDefaultValue=false)]
        public int StartMonth { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrialBsResponseTrialBs {\n");
            sb.Append("  AccountItemDisplayType: ").Append(AccountItemDisplayType).Append("\n");
            sb.Append("  Adjustment: ").Append(Adjustment).Append("\n");
            sb.Append("  Balances: ").Append(Balances).Append("\n");
            sb.Append("  BreakdownDisplayType: ").Append(BreakdownDisplayType).Append("\n");
            sb.Append("  CompanyId: ").Append(CompanyId).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  EndMonth: ").Append(EndMonth).Append("\n");
            sb.Append("  FiscalYear: ").Append(FiscalYear).Append("\n");
            sb.Append("  ItemId: ").Append(ItemId).Append("\n");
            sb.Append("  PartnerCode: ").Append(PartnerCode).Append("\n");
            sb.Append("  PartnerId: ").Append(PartnerId).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  StartMonth: ").Append(StartMonth).Append("\n");
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
            return this.Equals(input as TrialBsResponseTrialBs);
        }

        /// <summary>
        /// Returns true if TrialBsResponseTrialBs instances are equal
        /// </summary>
        /// <param name="input">Instance of TrialBsResponseTrialBs to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrialBsResponseTrialBs input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccountItemDisplayType == input.AccountItemDisplayType ||
                    this.AccountItemDisplayType.Equals(input.AccountItemDisplayType)
                ) && 
                (
                    this.Adjustment == input.Adjustment ||
                    this.Adjustment.Equals(input.Adjustment)
                ) && 
                (
                    this.Balances == input.Balances ||
                    this.Balances != null &&
                    input.Balances != null &&
                    this.Balances.SequenceEqual(input.Balances)
                ) && 
                (
                    this.BreakdownDisplayType == input.BreakdownDisplayType ||
                    this.BreakdownDisplayType.Equals(input.BreakdownDisplayType)
                ) && 
                (
                    this.CompanyId == input.CompanyId ||
                    this.CompanyId.Equals(input.CompanyId)
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.EndMonth == input.EndMonth ||
                    this.EndMonth.Equals(input.EndMonth)
                ) && 
                (
                    this.FiscalYear == input.FiscalYear ||
                    this.FiscalYear.Equals(input.FiscalYear)
                ) && 
                (
                    this.ItemId == input.ItemId ||
                    this.ItemId.Equals(input.ItemId)
                ) && 
                (
                    this.PartnerCode == input.PartnerCode ||
                    (this.PartnerCode != null &&
                    this.PartnerCode.Equals(input.PartnerCode))
                ) && 
                (
                    this.PartnerId == input.PartnerId ||
                    this.PartnerId.Equals(input.PartnerId)
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.StartMonth == input.StartMonth ||
                    this.StartMonth.Equals(input.StartMonth)
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
                hashCode = hashCode * 59 + this.AccountItemDisplayType.GetHashCode();
                hashCode = hashCode * 59 + this.Adjustment.GetHashCode();
                if (this.Balances != null)
                    hashCode = hashCode * 59 + this.Balances.GetHashCode();
                hashCode = hashCode * 59 + this.BreakdownDisplayType.GetHashCode();
                hashCode = hashCode * 59 + this.CompanyId.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                hashCode = hashCode * 59 + this.EndMonth.GetHashCode();
                hashCode = hashCode * 59 + this.FiscalYear.GetHashCode();
                hashCode = hashCode * 59 + this.ItemId.GetHashCode();
                if (this.PartnerCode != null)
                    hashCode = hashCode * 59 + this.PartnerCode.GetHashCode();
                hashCode = hashCode * 59 + this.PartnerId.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                hashCode = hashCode * 59 + this.StartMonth.GetHashCode();
                return hashCode;
            }
        }

    }

}
