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
    /// DeprecatedApprovalRequestResponseApprovalRequest
    /// </summary>
    [DataContract]
    public partial class DeprecatedApprovalRequestResponseApprovalRequest :  IEquatable<DeprecatedApprovalRequestResponseApprovalRequest>
    {
        /// <summary>
        /// 申請ステータス
        /// </summary>
        /// <value>申請ステータス</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Draft for value: draft
            /// </summary>
            [EnumMember(Value = "draft")]
            Draft = 1

        }

        /// <summary>
        /// 申請ステータス
        /// </summary>
        /// <value>申請ステータス</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeprecatedApprovalRequestResponseApprovalRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DeprecatedApprovalRequestResponseApprovalRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeprecatedApprovalRequestResponseApprovalRequest" /> class.
        /// </summary>
        /// <param name="applicantId">申請者のユーザーID (required).</param>
        /// <param name="applicationDate">申請日 (yyyy-mm-dd) (required).</param>
        /// <param name="applicationNumber">申請No. (required).</param>
        /// <param name="approverId">承認者のユーザーID (required).</param>
        /// <param name="companyId">事業所ID (required).</param>
        /// <param name="id">各種申請ID (required).</param>
        /// <param name="requestItems">各種申請の項目一覧（配列） (required).</param>
        /// <param name="status">申請ステータス (required).</param>
        /// <param name="title">申請タイトル (required).</param>
        public DeprecatedApprovalRequestResponseApprovalRequest(int applicantId = default(int), string applicationDate = default(string), string applicationNumber = default(string), int? approverId = default(int?), int companyId = default(int), int id = default(int), List<DeprecatedApprovalRequestResponseApprovalRequestRequestItems> requestItems = default(List<DeprecatedApprovalRequestResponseApprovalRequestRequestItems>), StatusEnum status = default(StatusEnum), string title = default(string))
        {
            this.ApplicantId = applicantId;
            // to ensure "applicationDate" is required (not null)
            this.ApplicationDate = applicationDate ?? throw new ArgumentNullException("applicationDate is a required property for DeprecatedApprovalRequestResponseApprovalRequest and cannot be null");
            // to ensure "applicationNumber" is required (not null)
            this.ApplicationNumber = applicationNumber ?? throw new ArgumentNullException("applicationNumber is a required property for DeprecatedApprovalRequestResponseApprovalRequest and cannot be null");
            // to ensure "approverId" is required (not null)
            this.ApproverId = approverId ?? throw new ArgumentNullException("approverId is a required property for DeprecatedApprovalRequestResponseApprovalRequest and cannot be null");
            this.CompanyId = companyId;
            this.Id = id;
            // to ensure "requestItems" is required (not null)
            this.RequestItems = requestItems ?? throw new ArgumentNullException("requestItems is a required property for DeprecatedApprovalRequestResponseApprovalRequest and cannot be null");
            this.Status = status;
            // to ensure "title" is required (not null)
            this.Title = title ?? throw new ArgumentNullException("title is a required property for DeprecatedApprovalRequestResponseApprovalRequest and cannot be null");
        }

        /// <summary>
        /// 申請者のユーザーID
        /// </summary>
        /// <value>申請者のユーザーID</value>
        [DataMember(Name="applicant_id", EmitDefaultValue=false)]
        public int ApplicantId { get; set; }

        /// <summary>
        /// 申請日 (yyyy-mm-dd)
        /// </summary>
        /// <value>申請日 (yyyy-mm-dd)</value>
        [DataMember(Name="application_date", EmitDefaultValue=false)]
        public string ApplicationDate { get; set; }

        /// <summary>
        /// 申請No.
        /// </summary>
        /// <value>申請No.</value>
        [DataMember(Name="application_number", EmitDefaultValue=false)]
        public string ApplicationNumber { get; set; }

        /// <summary>
        /// 承認者のユーザーID
        /// </summary>
        /// <value>承認者のユーザーID</value>
        [DataMember(Name="approver_id", EmitDefaultValue=true)]
        public int? ApproverId { get; set; }

        /// <summary>
        /// 事業所ID
        /// </summary>
        /// <value>事業所ID</value>
        [DataMember(Name="company_id", EmitDefaultValue=false)]
        public int CompanyId { get; set; }

        /// <summary>
        /// 各種申請ID
        /// </summary>
        /// <value>各種申請ID</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int Id { get; set; }

        /// <summary>
        /// 各種申請の項目一覧（配列）
        /// </summary>
        /// <value>各種申請の項目一覧（配列）</value>
        [DataMember(Name="request_items", EmitDefaultValue=false)]
        public List<DeprecatedApprovalRequestResponseApprovalRequestRequestItems> RequestItems { get; set; }

        /// <summary>
        /// 申請タイトル
        /// </summary>
        /// <value>申請タイトル</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeprecatedApprovalRequestResponseApprovalRequest {\n");
            sb.Append("  ApplicantId: ").Append(ApplicantId).Append("\n");
            sb.Append("  ApplicationDate: ").Append(ApplicationDate).Append("\n");
            sb.Append("  ApplicationNumber: ").Append(ApplicationNumber).Append("\n");
            sb.Append("  ApproverId: ").Append(ApproverId).Append("\n");
            sb.Append("  CompanyId: ").Append(CompanyId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  RequestItems: ").Append(RequestItems).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
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
            return this.Equals(input as DeprecatedApprovalRequestResponseApprovalRequest);
        }

        /// <summary>
        /// Returns true if DeprecatedApprovalRequestResponseApprovalRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of DeprecatedApprovalRequestResponseApprovalRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeprecatedApprovalRequestResponseApprovalRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ApplicantId == input.ApplicantId ||
                    this.ApplicantId.Equals(input.ApplicantId)
                ) && 
                (
                    this.ApplicationDate == input.ApplicationDate ||
                    (this.ApplicationDate != null &&
                    this.ApplicationDate.Equals(input.ApplicationDate))
                ) && 
                (
                    this.ApplicationNumber == input.ApplicationNumber ||
                    (this.ApplicationNumber != null &&
                    this.ApplicationNumber.Equals(input.ApplicationNumber))
                ) && 
                (
                    this.ApproverId == input.ApproverId ||
                    (this.ApproverId != null &&
                    this.ApproverId.Equals(input.ApproverId))
                ) && 
                (
                    this.CompanyId == input.CompanyId ||
                    this.CompanyId.Equals(input.CompanyId)
                ) && 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.RequestItems == input.RequestItems ||
                    this.RequestItems != null &&
                    input.RequestItems != null &&
                    this.RequestItems.SequenceEqual(input.RequestItems)
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
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
                hashCode = hashCode * 59 + this.ApplicantId.GetHashCode();
                if (this.ApplicationDate != null)
                    hashCode = hashCode * 59 + this.ApplicationDate.GetHashCode();
                if (this.ApplicationNumber != null)
                    hashCode = hashCode * 59 + this.ApplicationNumber.GetHashCode();
                if (this.ApproverId != null)
                    hashCode = hashCode * 59 + this.ApproverId.GetHashCode();
                hashCode = hashCode * 59 + this.CompanyId.GetHashCode();
                hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.RequestItems != null)
                    hashCode = hashCode * 59 + this.RequestItems.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                return hashCode;
            }
        }

    }

}
