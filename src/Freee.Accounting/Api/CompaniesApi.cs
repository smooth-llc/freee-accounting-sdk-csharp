/*
 * freee API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: v1.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Freee.Accounting.Client;
using Freee.Accounting.Models;

namespace Freee.Accounting.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICompaniesApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 事業所一覧の取得
        /// </summary>
        /// <exception cref="Freee.Accounting.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>CompanyIndexResponse</returns>
        CompanyIndexResponse GetCompanies();

        /// <summary>
        /// 事業所一覧の取得
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Freee.Accounting.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of CompanyIndexResponse</returns>
        ApiResponse<CompanyIndexResponse> GetCompaniesWithHttpInfo();
        /// <summary>
        /// 事業所の詳細情報の取得
        /// </summary>
        /// <exception cref="Freee.Accounting.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">事業所ID</param>
        /// <param name="details">取得情報に勘定科目・税区分コード・税区分・品目・取引先・部門・メモタグ・口座の一覧を含める (optional)</param>
        /// <param name="accountItems">取得情報に勘定科目一覧を含める (optional)</param>
        /// <param name="taxes">取得情報に税区分コード・税区分一覧を含める (optional)</param>
        /// <param name="items">取得情報に品目一覧を含める (optional)</param>
        /// <param name="partners">取得情報に取引先一覧を含める (optional)</param>
        /// <param name="sections">取得情報に部門一覧を含める (optional)</param>
        /// <param name="tags">取得情報にメモタグ一覧を含める (optional)</param>
        /// <param name="walletables">取得情報に口座一覧を含める (optional)</param>
        /// <returns>CompanyResponse</returns>
        CompanyResponse GetCompany(int id, bool? details = default(bool?), bool? accountItems = default(bool?), bool? taxes = default(bool?), bool? items = default(bool?), bool? partners = default(bool?), bool? sections = default(bool?), bool? tags = default(bool?), bool? walletables = default(bool?));

        /// <summary>
        /// 事業所の詳細情報の取得
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Freee.Accounting.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">事業所ID</param>
        /// <param name="details">取得情報に勘定科目・税区分コード・税区分・品目・取引先・部門・メモタグ・口座の一覧を含める (optional)</param>
        /// <param name="accountItems">取得情報に勘定科目一覧を含める (optional)</param>
        /// <param name="taxes">取得情報に税区分コード・税区分一覧を含める (optional)</param>
        /// <param name="items">取得情報に品目一覧を含める (optional)</param>
        /// <param name="partners">取得情報に取引先一覧を含める (optional)</param>
        /// <param name="sections">取得情報に部門一覧を含める (optional)</param>
        /// <param name="tags">取得情報にメモタグ一覧を含める (optional)</param>
        /// <param name="walletables">取得情報に口座一覧を含める (optional)</param>
        /// <returns>ApiResponse of CompanyResponse</returns>
        ApiResponse<CompanyResponse> GetCompanyWithHttpInfo(int id, bool? details = default(bool?), bool? accountItems = default(bool?), bool? taxes = default(bool?), bool? items = default(bool?), bool? partners = default(bool?), bool? sections = default(bool?), bool? tags = default(bool?), bool? walletables = default(bool?));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICompaniesApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 事業所一覧の取得
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Freee.Accounting.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CompanyIndexResponse</returns>
        System.Threading.Tasks.Task<CompanyIndexResponse> GetCompaniesAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 事業所一覧の取得
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Freee.Accounting.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CompanyIndexResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CompanyIndexResponse>> GetCompaniesWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// 事業所の詳細情報の取得
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Freee.Accounting.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">事業所ID</param>
        /// <param name="details">取得情報に勘定科目・税区分コード・税区分・品目・取引先・部門・メモタグ・口座の一覧を含める (optional)</param>
        /// <param name="accountItems">取得情報に勘定科目一覧を含める (optional)</param>
        /// <param name="taxes">取得情報に税区分コード・税区分一覧を含める (optional)</param>
        /// <param name="items">取得情報に品目一覧を含める (optional)</param>
        /// <param name="partners">取得情報に取引先一覧を含める (optional)</param>
        /// <param name="sections">取得情報に部門一覧を含める (optional)</param>
        /// <param name="tags">取得情報にメモタグ一覧を含める (optional)</param>
        /// <param name="walletables">取得情報に口座一覧を含める (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CompanyResponse</returns>
        System.Threading.Tasks.Task<CompanyResponse> GetCompanyAsync(int id, bool? details = default(bool?), bool? accountItems = default(bool?), bool? taxes = default(bool?), bool? items = default(bool?), bool? partners = default(bool?), bool? sections = default(bool?), bool? tags = default(bool?), bool? walletables = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 事業所の詳細情報の取得
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Freee.Accounting.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">事業所ID</param>
        /// <param name="details">取得情報に勘定科目・税区分コード・税区分・品目・取引先・部門・メモタグ・口座の一覧を含める (optional)</param>
        /// <param name="accountItems">取得情報に勘定科目一覧を含める (optional)</param>
        /// <param name="taxes">取得情報に税区分コード・税区分一覧を含める (optional)</param>
        /// <param name="items">取得情報に品目一覧を含める (optional)</param>
        /// <param name="partners">取得情報に取引先一覧を含める (optional)</param>
        /// <param name="sections">取得情報に部門一覧を含める (optional)</param>
        /// <param name="tags">取得情報にメモタグ一覧を含める (optional)</param>
        /// <param name="walletables">取得情報に口座一覧を含める (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CompanyResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<CompanyResponse>> GetCompanyWithHttpInfoAsync(int id, bool? details = default(bool?), bool? accountItems = default(bool?), bool? taxes = default(bool?), bool? items = default(bool?), bool? partners = default(bool?), bool? sections = default(bool?), bool? tags = default(bool?), bool? walletables = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ICompaniesApi : ICompaniesApiSync, ICompaniesApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class CompaniesApi : ICompaniesApi
    {
        private Freee.Accounting.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="CompaniesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CompaniesApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompaniesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CompaniesApi(string basePath)
        {
            this.Configuration = Freee.Accounting.Client.Configuration.MergeConfigurations(
                Freee.Accounting.Client.GlobalConfiguration.Instance,
                new Freee.Accounting.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Freee.Accounting.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Freee.Accounting.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Freee.Accounting.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompaniesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CompaniesApi(Freee.Accounting.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Freee.Accounting.Client.Configuration.MergeConfigurations(
                Freee.Accounting.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Freee.Accounting.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Freee.Accounting.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Freee.Accounting.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompaniesApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public CompaniesApi(Freee.Accounting.Client.ISynchronousClient client, Freee.Accounting.Client.IAsynchronousClient asyncClient, Freee.Accounting.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Freee.Accounting.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Freee.Accounting.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Freee.Accounting.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Freee.Accounting.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Freee.Accounting.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// 事業所一覧の取得 
        /// </summary>
        /// <exception cref="Freee.Accounting.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>CompanyIndexResponse</returns>
        public CompanyIndexResponse GetCompanies()
        {
            Freee.Accounting.Client.ApiResponse<CompanyIndexResponse> localVarResponse = GetCompaniesWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// 事業所一覧の取得 
        /// </summary>
        /// <exception cref="Freee.Accounting.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of CompanyIndexResponse</returns>
        public Freee.Accounting.Client.ApiResponse<CompanyIndexResponse> GetCompaniesWithHttpInfo()
        {
            Freee.Accounting.Client.RequestOptions localVarRequestOptions = new Freee.Accounting.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Freee.Accounting.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Freee.Accounting.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }


            // authentication (oauth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<CompanyIndexResponse>("/api/1/companies", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetCompanies", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 事業所一覧の取得 
        /// </summary>
        /// <exception cref="Freee.Accounting.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CompanyIndexResponse</returns>
        public async System.Threading.Tasks.Task<CompanyIndexResponse> GetCompaniesAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Freee.Accounting.Client.ApiResponse<CompanyIndexResponse> localVarResponse = await GetCompaniesWithHttpInfoAsync(cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 事業所一覧の取得 
        /// </summary>
        /// <exception cref="Freee.Accounting.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CompanyIndexResponse)</returns>
        public async System.Threading.Tasks.Task<Freee.Accounting.Client.ApiResponse<CompanyIndexResponse>> GetCompaniesWithHttpInfoAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Freee.Accounting.Client.RequestOptions localVarRequestOptions = new Freee.Accounting.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Freee.Accounting.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Freee.Accounting.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }


            // authentication (oauth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<CompanyIndexResponse>("/api/1/companies", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetCompanies", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 事業所の詳細情報の取得 
        /// </summary>
        /// <exception cref="Freee.Accounting.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">事業所ID</param>
        /// <param name="details">取得情報に勘定科目・税区分コード・税区分・品目・取引先・部門・メモタグ・口座の一覧を含める (optional)</param>
        /// <param name="accountItems">取得情報に勘定科目一覧を含める (optional)</param>
        /// <param name="taxes">取得情報に税区分コード・税区分一覧を含める (optional)</param>
        /// <param name="items">取得情報に品目一覧を含める (optional)</param>
        /// <param name="partners">取得情報に取引先一覧を含める (optional)</param>
        /// <param name="sections">取得情報に部門一覧を含める (optional)</param>
        /// <param name="tags">取得情報にメモタグ一覧を含める (optional)</param>
        /// <param name="walletables">取得情報に口座一覧を含める (optional)</param>
        /// <returns>CompanyResponse</returns>
        public CompanyResponse GetCompany(int id, bool? details = default(bool?), bool? accountItems = default(bool?), bool? taxes = default(bool?), bool? items = default(bool?), bool? partners = default(bool?), bool? sections = default(bool?), bool? tags = default(bool?), bool? walletables = default(bool?))
        {
            Freee.Accounting.Client.ApiResponse<CompanyResponse> localVarResponse = GetCompanyWithHttpInfo(id, details, accountItems, taxes, items, partners, sections, tags, walletables);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 事業所の詳細情報の取得 
        /// </summary>
        /// <exception cref="Freee.Accounting.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">事業所ID</param>
        /// <param name="details">取得情報に勘定科目・税区分コード・税区分・品目・取引先・部門・メモタグ・口座の一覧を含める (optional)</param>
        /// <param name="accountItems">取得情報に勘定科目一覧を含める (optional)</param>
        /// <param name="taxes">取得情報に税区分コード・税区分一覧を含める (optional)</param>
        /// <param name="items">取得情報に品目一覧を含める (optional)</param>
        /// <param name="partners">取得情報に取引先一覧を含める (optional)</param>
        /// <param name="sections">取得情報に部門一覧を含める (optional)</param>
        /// <param name="tags">取得情報にメモタグ一覧を含める (optional)</param>
        /// <param name="walletables">取得情報に口座一覧を含める (optional)</param>
        /// <returns>ApiResponse of CompanyResponse</returns>
        public Freee.Accounting.Client.ApiResponse<CompanyResponse> GetCompanyWithHttpInfo(int id, bool? details = default(bool?), bool? accountItems = default(bool?), bool? taxes = default(bool?), bool? items = default(bool?), bool? partners = default(bool?), bool? sections = default(bool?), bool? tags = default(bool?), bool? walletables = default(bool?))
        {
            Freee.Accounting.Client.RequestOptions localVarRequestOptions = new Freee.Accounting.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Freee.Accounting.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Freee.Accounting.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("id", Freee.Accounting.Client.ClientUtils.ParameterToString(id)); // path parameter
            if (details != null)
            {
                localVarRequestOptions.QueryParameters.Add(Freee.Accounting.Client.ClientUtils.ParameterToMultiMap("", "details", details));
            }
            if (accountItems != null)
            {
                localVarRequestOptions.QueryParameters.Add(Freee.Accounting.Client.ClientUtils.ParameterToMultiMap("", "account_items", accountItems));
            }
            if (taxes != null)
            {
                localVarRequestOptions.QueryParameters.Add(Freee.Accounting.Client.ClientUtils.ParameterToMultiMap("", "taxes", taxes));
            }
            if (items != null)
            {
                localVarRequestOptions.QueryParameters.Add(Freee.Accounting.Client.ClientUtils.ParameterToMultiMap("", "items", items));
            }
            if (partners != null)
            {
                localVarRequestOptions.QueryParameters.Add(Freee.Accounting.Client.ClientUtils.ParameterToMultiMap("", "partners", partners));
            }
            if (sections != null)
            {
                localVarRequestOptions.QueryParameters.Add(Freee.Accounting.Client.ClientUtils.ParameterToMultiMap("", "sections", sections));
            }
            if (tags != null)
            {
                localVarRequestOptions.QueryParameters.Add(Freee.Accounting.Client.ClientUtils.ParameterToMultiMap("", "tags", tags));
            }
            if (walletables != null)
            {
                localVarRequestOptions.QueryParameters.Add(Freee.Accounting.Client.ClientUtils.ParameterToMultiMap("", "walletables", walletables));
            }

            // authentication (oauth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<CompanyResponse>("/api/1/companies/{id}", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetCompany", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// 事業所の詳細情報の取得 
        /// </summary>
        /// <exception cref="Freee.Accounting.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">事業所ID</param>
        /// <param name="details">取得情報に勘定科目・税区分コード・税区分・品目・取引先・部門・メモタグ・口座の一覧を含める (optional)</param>
        /// <param name="accountItems">取得情報に勘定科目一覧を含める (optional)</param>
        /// <param name="taxes">取得情報に税区分コード・税区分一覧を含める (optional)</param>
        /// <param name="items">取得情報に品目一覧を含める (optional)</param>
        /// <param name="partners">取得情報に取引先一覧を含める (optional)</param>
        /// <param name="sections">取得情報に部門一覧を含める (optional)</param>
        /// <param name="tags">取得情報にメモタグ一覧を含める (optional)</param>
        /// <param name="walletables">取得情報に口座一覧を含める (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of CompanyResponse</returns>
        public async System.Threading.Tasks.Task<CompanyResponse> GetCompanyAsync(int id, bool? details = default(bool?), bool? accountItems = default(bool?), bool? taxes = default(bool?), bool? items = default(bool?), bool? partners = default(bool?), bool? sections = default(bool?), bool? tags = default(bool?), bool? walletables = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Freee.Accounting.Client.ApiResponse<CompanyResponse> localVarResponse = await GetCompanyWithHttpInfoAsync(id, details, accountItems, taxes, items, partners, sections, tags, walletables, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// 事業所の詳細情報の取得 
        /// </summary>
        /// <exception cref="Freee.Accounting.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">事業所ID</param>
        /// <param name="details">取得情報に勘定科目・税区分コード・税区分・品目・取引先・部門・メモタグ・口座の一覧を含める (optional)</param>
        /// <param name="accountItems">取得情報に勘定科目一覧を含める (optional)</param>
        /// <param name="taxes">取得情報に税区分コード・税区分一覧を含める (optional)</param>
        /// <param name="items">取得情報に品目一覧を含める (optional)</param>
        /// <param name="partners">取得情報に取引先一覧を含める (optional)</param>
        /// <param name="sections">取得情報に部門一覧を含める (optional)</param>
        /// <param name="tags">取得情報にメモタグ一覧を含める (optional)</param>
        /// <param name="walletables">取得情報に口座一覧を含める (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (CompanyResponse)</returns>
        public async System.Threading.Tasks.Task<Freee.Accounting.Client.ApiResponse<CompanyResponse>> GetCompanyWithHttpInfoAsync(int id, bool? details = default(bool?), bool? accountItems = default(bool?), bool? taxes = default(bool?), bool? items = default(bool?), bool? partners = default(bool?), bool? sections = default(bool?), bool? tags = default(bool?), bool? walletables = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

            Freee.Accounting.Client.RequestOptions localVarRequestOptions = new Freee.Accounting.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = Freee.Accounting.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Freee.Accounting.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.PathParameters.Add("id", Freee.Accounting.Client.ClientUtils.ParameterToString(id)); // path parameter
            if (details != null)
            {
                localVarRequestOptions.QueryParameters.Add(Freee.Accounting.Client.ClientUtils.ParameterToMultiMap("", "details", details));
            }
            if (accountItems != null)
            {
                localVarRequestOptions.QueryParameters.Add(Freee.Accounting.Client.ClientUtils.ParameterToMultiMap("", "account_items", accountItems));
            }
            if (taxes != null)
            {
                localVarRequestOptions.QueryParameters.Add(Freee.Accounting.Client.ClientUtils.ParameterToMultiMap("", "taxes", taxes));
            }
            if (items != null)
            {
                localVarRequestOptions.QueryParameters.Add(Freee.Accounting.Client.ClientUtils.ParameterToMultiMap("", "items", items));
            }
            if (partners != null)
            {
                localVarRequestOptions.QueryParameters.Add(Freee.Accounting.Client.ClientUtils.ParameterToMultiMap("", "partners", partners));
            }
            if (sections != null)
            {
                localVarRequestOptions.QueryParameters.Add(Freee.Accounting.Client.ClientUtils.ParameterToMultiMap("", "sections", sections));
            }
            if (tags != null)
            {
                localVarRequestOptions.QueryParameters.Add(Freee.Accounting.Client.ClientUtils.ParameterToMultiMap("", "tags", tags));
            }
            if (walletables != null)
            {
                localVarRequestOptions.QueryParameters.Add(Freee.Accounting.Client.ClientUtils.ParameterToMultiMap("", "walletables", walletables));
            }

            // authentication (oauth2) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<CompanyResponse>("/api/1/companies/{id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetCompany", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
