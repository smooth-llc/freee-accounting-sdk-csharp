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
    /// ExpenseApplicationCreateParams
    /// </summary>
    [DataContract(Name = "expenseApplicationCreateParams")]
    public partial class ExpenseApplicationCreateParams : IEquatable<ExpenseApplicationCreateParams>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExpenseApplicationCreateParams" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ExpenseApplicationCreateParams() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExpenseApplicationCreateParams" /> class.
        /// </summary>
        /// <param name="approvalFlowRouteId">申請経路ID&lt;br&gt; &lt;ul&gt;     &lt;li&gt;経費申請のステータスを申請中として作成する場合は、必ず指定してください。&lt;/li&gt;     &lt;li&gt;指定する申請経路IDは、申請経路APIを利用して取得してください。&lt;/li&gt;     &lt;li&gt;         未指定の場合は、基本経路を設定している事業所では基本経路が、基本経路を設定していない事業所では利用可能な申請経路の中から最初の申請経路が自動的に使用されます。         &lt;ul&gt;            &lt;li&gt;意図しない申請経路を持った経費申請の作成を防ぐために、使用する申請経路IDを指定することを推奨します。&lt;/li&gt;         &lt;/ul&gt;     &lt;/li&gt;     &lt;li&gt;         ベーシックプランの事業所では以下のデフォルトで用意された申請経路のみ指定できます         &lt;ul&gt;         &lt;li&gt;指定なし&lt;/li&gt;         &lt;li&gt;承認者を指定&lt;/li&gt;         &lt;/ul&gt;     &lt;/li&gt; &lt;/ul&gt; .</param>
        /// <param name="approverId">承認者のユーザーID&lt;br&gt; 「承認者を指定」の経路を申請経路として使用する場合に指定してください。&lt;br&gt; 指定する承認者のユーザーIDは、申請経路APIを利用して取得してください。 .</param>
        /// <param name="companyId">事業所ID (required).</param>
        /// <param name="description">備考 (10000文字以内).</param>
        /// <param name="draft">経費申請のステータス&lt;br&gt; falseを指定した時は申請中（in_progress）で経費申請を作成します。&lt;br&gt; trueを指定した時は下書き（draft）で経費申請を作成します。&lt;br&gt; 未指定の時は下書きとみなして経費申請を作成します。 .</param>
        /// <param name="expenseApplicationLines">expenseApplicationLines (required).</param>
        /// <param name="issueDate">申請日 (yyyy-mm-dd)&lt;br&gt; 指定しない場合は当日の日付が登録されます。 .</param>
        /// <param name="parentId">親申請ID(法人向けプロフェッショナル, 法人向け エンタープライズプラン)&lt;br&gt; &lt;ul&gt;   &lt;li&gt;承認済みの既存各種申請IDのみ指定可能です。&lt;/li&gt;   &lt;li&gt;各種申請一覧APIを利用して取得してください。&lt;/li&gt; &lt;/ul&gt; .</param>
        /// <param name="sectionId">部門ID.</param>
        /// <param name="segment1TagId">セグメント１ID(法人向けプロフェッショナル, 法人向けエンタープライズプラン)&lt;br&gt; セグメントタグ一覧APIを利用して取得してください。&lt;br&gt; &lt;a href&#x3D;\&quot;https://support.freee.co.jp/hc/ja/articles/360020679611\&quot; target&#x3D;\&quot;_blank\&quot;&gt;セグメント（分析用タグ）の設定&lt;/a&gt;&lt;br&gt; .</param>
        /// <param name="segment2TagId">セグメント２ID(法人向け エンタープライズプラン)&lt;br&gt; セグメントタグ一覧APIを利用して取得してください。&lt;br&gt; &lt;a href&#x3D;\&quot;https://support.freee.co.jp/hc/ja/articles/360020679611\&quot; target&#x3D;\&quot;_blank\&quot;&gt;セグメント（分析用タグ）の設定&lt;/a&gt;&lt;br&gt; .</param>
        /// <param name="segment3TagId">セグメント３ID(法人向け エンタープライズプラン)&lt;br&gt; セグメントタグ一覧APIを利用して取得してください。&lt;br&gt; &lt;a href&#x3D;\&quot;https://support.freee.co.jp/hc/ja/articles/360020679611\&quot; target&#x3D;\&quot;_blank\&quot;&gt;セグメント（分析用タグ）の設定&lt;/a&gt;&lt;br&gt; .</param>
        /// <param name="tagIds">メモタグID.</param>
        /// <param name="title">申請タイトル (250文字以内) (required).</param>
        public ExpenseApplicationCreateParams(int approvalFlowRouteId = default(int), int approverId = default(int), int companyId = default(int), string description = default(string), bool draft = default(bool), List<ExpenseApplicationCreateParamsExpenseApplicationLines> expenseApplicationLines = default(List<ExpenseApplicationCreateParamsExpenseApplicationLines>), string issueDate = default(string), int parentId = default(int), int sectionId = default(int), long segment1TagId = default(long), long segment2TagId = default(long), long segment3TagId = default(long), List<int> tagIds = default(List<int>), string title = default(string))
        {
            this.CompanyId = companyId;
            // to ensure "expenseApplicationLines" is required (not null)
            if (expenseApplicationLines == null) {
                throw new ArgumentNullException("expenseApplicationLines is a required property for ExpenseApplicationCreateParams and cannot be null");
            }
            this.ExpenseApplicationLines = expenseApplicationLines;
            // to ensure "title" is required (not null)
            if (title == null) {
                throw new ArgumentNullException("title is a required property for ExpenseApplicationCreateParams and cannot be null");
            }
            this.Title = title;
            this.ApprovalFlowRouteId = approvalFlowRouteId;
            this.ApproverId = approverId;
            this.Description = description;
            this.Draft = draft;
            this.IssueDate = issueDate;
            this.ParentId = parentId;
            this.SectionId = sectionId;
            this.Segment1TagId = segment1TagId;
            this.Segment2TagId = segment2TagId;
            this.Segment3TagId = segment3TagId;
            this.TagIds = tagIds;
        }

        /// <summary>
        /// 申請経路ID&lt;br&gt; &lt;ul&gt;     &lt;li&gt;経費申請のステータスを申請中として作成する場合は、必ず指定してください。&lt;/li&gt;     &lt;li&gt;指定する申請経路IDは、申請経路APIを利用して取得してください。&lt;/li&gt;     &lt;li&gt;         未指定の場合は、基本経路を設定している事業所では基本経路が、基本経路を設定していない事業所では利用可能な申請経路の中から最初の申請経路が自動的に使用されます。         &lt;ul&gt;            &lt;li&gt;意図しない申請経路を持った経費申請の作成を防ぐために、使用する申請経路IDを指定することを推奨します。&lt;/li&gt;         &lt;/ul&gt;     &lt;/li&gt;     &lt;li&gt;         ベーシックプランの事業所では以下のデフォルトで用意された申請経路のみ指定できます         &lt;ul&gt;         &lt;li&gt;指定なし&lt;/li&gt;         &lt;li&gt;承認者を指定&lt;/li&gt;         &lt;/ul&gt;     &lt;/li&gt; &lt;/ul&gt; 
        /// </summary>
        /// <value>申請経路ID&lt;br&gt; &lt;ul&gt;     &lt;li&gt;経費申請のステータスを申請中として作成する場合は、必ず指定してください。&lt;/li&gt;     &lt;li&gt;指定する申請経路IDは、申請経路APIを利用して取得してください。&lt;/li&gt;     &lt;li&gt;         未指定の場合は、基本経路を設定している事業所では基本経路が、基本経路を設定していない事業所では利用可能な申請経路の中から最初の申請経路が自動的に使用されます。         &lt;ul&gt;            &lt;li&gt;意図しない申請経路を持った経費申請の作成を防ぐために、使用する申請経路IDを指定することを推奨します。&lt;/li&gt;         &lt;/ul&gt;     &lt;/li&gt;     &lt;li&gt;         ベーシックプランの事業所では以下のデフォルトで用意された申請経路のみ指定できます         &lt;ul&gt;         &lt;li&gt;指定なし&lt;/li&gt;         &lt;li&gt;承認者を指定&lt;/li&gt;         &lt;/ul&gt;     &lt;/li&gt; &lt;/ul&gt; </value>
        [DataMember(Name = "approval_flow_route_id", EmitDefaultValue = false)]
        public int ApprovalFlowRouteId { get; set; }

        /// <summary>
        /// 承認者のユーザーID&lt;br&gt; 「承認者を指定」の経路を申請経路として使用する場合に指定してください。&lt;br&gt; 指定する承認者のユーザーIDは、申請経路APIを利用して取得してください。 
        /// </summary>
        /// <value>承認者のユーザーID&lt;br&gt; 「承認者を指定」の経路を申請経路として使用する場合に指定してください。&lt;br&gt; 指定する承認者のユーザーIDは、申請経路APIを利用して取得してください。 </value>
        [DataMember(Name = "approver_id", EmitDefaultValue = false)]
        public int ApproverId { get; set; }

        /// <summary>
        /// 事業所ID
        /// </summary>
        /// <value>事業所ID</value>
        [DataMember(Name = "company_id", IsRequired = true, EmitDefaultValue = false)]
        public int CompanyId { get; set; }

        /// <summary>
        /// 備考 (10000文字以内)
        /// </summary>
        /// <value>備考 (10000文字以内)</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// 経費申請のステータス&lt;br&gt; falseを指定した時は申請中（in_progress）で経費申請を作成します。&lt;br&gt; trueを指定した時は下書き（draft）で経費申請を作成します。&lt;br&gt; 未指定の時は下書きとみなして経費申請を作成します。 
        /// </summary>
        /// <value>経費申請のステータス&lt;br&gt; falseを指定した時は申請中（in_progress）で経費申請を作成します。&lt;br&gt; trueを指定した時は下書き（draft）で経費申請を作成します。&lt;br&gt; 未指定の時は下書きとみなして経費申請を作成します。 </value>
        [DataMember(Name = "draft", EmitDefaultValue = true)]
        public bool Draft { get; set; }

        /// <summary>
        /// Gets or Sets ExpenseApplicationLines
        /// </summary>
        [DataMember(Name = "expense_application_lines", IsRequired = true, EmitDefaultValue = false)]
        public List<ExpenseApplicationCreateParamsExpenseApplicationLines> ExpenseApplicationLines { get; set; }

        /// <summary>
        /// 申請日 (yyyy-mm-dd)&lt;br&gt; 指定しない場合は当日の日付が登録されます。 
        /// </summary>
        /// <value>申請日 (yyyy-mm-dd)&lt;br&gt; 指定しない場合は当日の日付が登録されます。 </value>
        [DataMember(Name = "issue_date", EmitDefaultValue = false)]
        public string IssueDate { get; set; }

        /// <summary>
        /// 親申請ID(法人向けプロフェッショナル, 法人向け エンタープライズプラン)&lt;br&gt; &lt;ul&gt;   &lt;li&gt;承認済みの既存各種申請IDのみ指定可能です。&lt;/li&gt;   &lt;li&gt;各種申請一覧APIを利用して取得してください。&lt;/li&gt; &lt;/ul&gt; 
        /// </summary>
        /// <value>親申請ID(法人向けプロフェッショナル, 法人向け エンタープライズプラン)&lt;br&gt; &lt;ul&gt;   &lt;li&gt;承認済みの既存各種申請IDのみ指定可能です。&lt;/li&gt;   &lt;li&gt;各種申請一覧APIを利用して取得してください。&lt;/li&gt; &lt;/ul&gt; </value>
        [DataMember(Name = "parent_id", EmitDefaultValue = false)]
        public int ParentId { get; set; }

        /// <summary>
        /// 部門ID
        /// </summary>
        /// <value>部門ID</value>
        [DataMember(Name = "section_id", EmitDefaultValue = false)]
        public int SectionId { get; set; }

        /// <summary>
        /// セグメント１ID(法人向けプロフェッショナル, 法人向けエンタープライズプラン)&lt;br&gt; セグメントタグ一覧APIを利用して取得してください。&lt;br&gt; &lt;a href&#x3D;\&quot;https://support.freee.co.jp/hc/ja/articles/360020679611\&quot; target&#x3D;\&quot;_blank\&quot;&gt;セグメント（分析用タグ）の設定&lt;/a&gt;&lt;br&gt; 
        /// </summary>
        /// <value>セグメント１ID(法人向けプロフェッショナル, 法人向けエンタープライズプラン)&lt;br&gt; セグメントタグ一覧APIを利用して取得してください。&lt;br&gt; &lt;a href&#x3D;\&quot;https://support.freee.co.jp/hc/ja/articles/360020679611\&quot; target&#x3D;\&quot;_blank\&quot;&gt;セグメント（分析用タグ）の設定&lt;/a&gt;&lt;br&gt; </value>
        [DataMember(Name = "segment_1_tag_id", EmitDefaultValue = false)]
        public long Segment1TagId { get; set; }

        /// <summary>
        /// セグメント２ID(法人向け エンタープライズプラン)&lt;br&gt; セグメントタグ一覧APIを利用して取得してください。&lt;br&gt; &lt;a href&#x3D;\&quot;https://support.freee.co.jp/hc/ja/articles/360020679611\&quot; target&#x3D;\&quot;_blank\&quot;&gt;セグメント（分析用タグ）の設定&lt;/a&gt;&lt;br&gt; 
        /// </summary>
        /// <value>セグメント２ID(法人向け エンタープライズプラン)&lt;br&gt; セグメントタグ一覧APIを利用して取得してください。&lt;br&gt; &lt;a href&#x3D;\&quot;https://support.freee.co.jp/hc/ja/articles/360020679611\&quot; target&#x3D;\&quot;_blank\&quot;&gt;セグメント（分析用タグ）の設定&lt;/a&gt;&lt;br&gt; </value>
        [DataMember(Name = "segment_2_tag_id", EmitDefaultValue = false)]
        public long Segment2TagId { get; set; }

        /// <summary>
        /// セグメント３ID(法人向け エンタープライズプラン)&lt;br&gt; セグメントタグ一覧APIを利用して取得してください。&lt;br&gt; &lt;a href&#x3D;\&quot;https://support.freee.co.jp/hc/ja/articles/360020679611\&quot; target&#x3D;\&quot;_blank\&quot;&gt;セグメント（分析用タグ）の設定&lt;/a&gt;&lt;br&gt; 
        /// </summary>
        /// <value>セグメント３ID(法人向け エンタープライズプラン)&lt;br&gt; セグメントタグ一覧APIを利用して取得してください。&lt;br&gt; &lt;a href&#x3D;\&quot;https://support.freee.co.jp/hc/ja/articles/360020679611\&quot; target&#x3D;\&quot;_blank\&quot;&gt;セグメント（分析用タグ）の設定&lt;/a&gt;&lt;br&gt; </value>
        [DataMember(Name = "segment_3_tag_id", EmitDefaultValue = false)]
        public long Segment3TagId { get; set; }

        /// <summary>
        /// メモタグID
        /// </summary>
        /// <value>メモタグID</value>
        [DataMember(Name = "tag_ids", EmitDefaultValue = false)]
        public List<int> TagIds { get; set; }

        /// <summary>
        /// 申請タイトル (250文字以内)
        /// </summary>
        /// <value>申請タイトル (250文字以内)</value>
        [DataMember(Name = "title", IsRequired = true, EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ExpenseApplicationCreateParams {\n");
            sb.Append("  ApprovalFlowRouteId: ").Append(ApprovalFlowRouteId).Append("\n");
            sb.Append("  ApproverId: ").Append(ApproverId).Append("\n");
            sb.Append("  CompanyId: ").Append(CompanyId).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Draft: ").Append(Draft).Append("\n");
            sb.Append("  ExpenseApplicationLines: ").Append(ExpenseApplicationLines).Append("\n");
            sb.Append("  IssueDate: ").Append(IssueDate).Append("\n");
            sb.Append("  ParentId: ").Append(ParentId).Append("\n");
            sb.Append("  SectionId: ").Append(SectionId).Append("\n");
            sb.Append("  Segment1TagId: ").Append(Segment1TagId).Append("\n");
            sb.Append("  Segment2TagId: ").Append(Segment2TagId).Append("\n");
            sb.Append("  Segment3TagId: ").Append(Segment3TagId).Append("\n");
            sb.Append("  TagIds: ").Append(TagIds).Append("\n");
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
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ExpenseApplicationCreateParams);
        }

        /// <summary>
        /// Returns true if ExpenseApplicationCreateParams instances are equal
        /// </summary>
        /// <param name="input">Instance of ExpenseApplicationCreateParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExpenseApplicationCreateParams input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ApprovalFlowRouteId == input.ApprovalFlowRouteId ||
                    this.ApprovalFlowRouteId.Equals(input.ApprovalFlowRouteId)
                ) && 
                (
                    this.ApproverId == input.ApproverId ||
                    this.ApproverId.Equals(input.ApproverId)
                ) && 
                (
                    this.CompanyId == input.CompanyId ||
                    this.CompanyId.Equals(input.CompanyId)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Draft == input.Draft ||
                    this.Draft.Equals(input.Draft)
                ) && 
                (
                    this.ExpenseApplicationLines == input.ExpenseApplicationLines ||
                    this.ExpenseApplicationLines != null &&
                    input.ExpenseApplicationLines != null &&
                    this.ExpenseApplicationLines.SequenceEqual(input.ExpenseApplicationLines)
                ) && 
                (
                    this.IssueDate == input.IssueDate ||
                    (this.IssueDate != null &&
                    this.IssueDate.Equals(input.IssueDate))
                ) && 
                (
                    this.ParentId == input.ParentId ||
                    this.ParentId.Equals(input.ParentId)
                ) && 
                (
                    this.SectionId == input.SectionId ||
                    this.SectionId.Equals(input.SectionId)
                ) && 
                (
                    this.Segment1TagId == input.Segment1TagId ||
                    this.Segment1TagId.Equals(input.Segment1TagId)
                ) && 
                (
                    this.Segment2TagId == input.Segment2TagId ||
                    this.Segment2TagId.Equals(input.Segment2TagId)
                ) && 
                (
                    this.Segment3TagId == input.Segment3TagId ||
                    this.Segment3TagId.Equals(input.Segment3TagId)
                ) && 
                (
                    this.TagIds == input.TagIds ||
                    this.TagIds != null &&
                    input.TagIds != null &&
                    this.TagIds.SequenceEqual(input.TagIds)
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
                hashCode = (hashCode * 59) + this.ApprovalFlowRouteId.GetHashCode();
                hashCode = (hashCode * 59) + this.ApproverId.GetHashCode();
                hashCode = (hashCode * 59) + this.CompanyId.GetHashCode();
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Draft.GetHashCode();
                if (this.ExpenseApplicationLines != null)
                {
                    hashCode = (hashCode * 59) + this.ExpenseApplicationLines.GetHashCode();
                }
                if (this.IssueDate != null)
                {
                    hashCode = (hashCode * 59) + this.IssueDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ParentId.GetHashCode();
                hashCode = (hashCode * 59) + this.SectionId.GetHashCode();
                hashCode = (hashCode * 59) + this.Segment1TagId.GetHashCode();
                hashCode = (hashCode * 59) + this.Segment2TagId.GetHashCode();
                hashCode = (hashCode * 59) + this.Segment3TagId.GetHashCode();
                if (this.TagIds != null)
                {
                    hashCode = (hashCode * 59) + this.TagIds.GetHashCode();
                }
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
                return hashCode;
            }
        }

    }

}
