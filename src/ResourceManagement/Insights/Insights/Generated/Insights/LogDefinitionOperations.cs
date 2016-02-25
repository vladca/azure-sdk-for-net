// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Hyak.Common;
using Microsoft.Azure.Insights;
using Microsoft.Azure.Insights.Models;
using Newtonsoft.Json.Linq;

namespace Microsoft.Azure.Insights
{
    /// <summary>
    /// Operations for log definitions.
    /// </summary>
    internal partial class LogDefinitionOperations : IServiceOperations<InsightsClient>, ILogDefinitionOperations
    {
        /// <summary>
        /// Initializes a new instance of the LogDefinitionOperations class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        internal LogDefinitionOperations(InsightsClient client)
        {
            this._client = client;
        }
        
        private InsightsClient _client;
        
        /// <summary>
        /// Gets a reference to the Microsoft.Azure.Insights.InsightsClient.
        /// </summary>
        public InsightsClient Client
        {
            get { return this._client; }
        }
        
        /// <summary>
        /// The List Log Definitions operation lists the log definitions for
        /// the resource.
        /// </summary>
        /// <param name='resourceUri'>
        /// Required. The resource identifier of the target resource to get
        /// logs for.
        /// </param>
        /// <param name='filterString'>
        /// Optional. An OData $filter expression that supports querying by the
        /// name of the log definition. For example, "name.value eq
        /// 'Percentage CPU'". Name is optional, meaning the expression may be
        /// "".
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// The List Log Definitions operation response.
        /// </returns>
        public async Task<LogDefinitionListResponse> GetLogDefinitionsAsync(string resourceUri, string filterString, CancellationToken cancellationToken)
        {
            // Validate
            if (resourceUri == null)
            {
                throw new ArgumentNullException("resourceUri");
            }
            
            // Tracing
            bool shouldTrace = TracingAdapter.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = TracingAdapter.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("resourceUri", resourceUri);
                tracingParameters.Add("filterString", filterString);
                TracingAdapter.Enter(invocationId, this, "GetLogDefinitionsAsync", tracingParameters);
            }
            
            // Construct URL
            string url = "";
            url = url + "/";
            url = url + Uri.EscapeDataString(resourceUri);
            url = url + "/providers/microsoft.insights/logDefinitions";
            List<string> queryParameters = new List<string>();
            queryParameters.Add("api-version=2015-07-01");
            List<string> odataFilter = new List<string>();
            if (filterString != null)
            {
                odataFilter.Add(Uri.EscapeDataString(filterString));
            }
            if (odataFilter.Count > 0)
            {
                queryParameters.Add("$filter=" + string.Join(null, odataFilter));
            }
            if (queryParameters.Count > 0)
            {
                url = url + "?" + string.Join("&", queryParameters);
            }
            string baseUrl = this.Client.BaseUri.AbsoluteUri;
            // Trim '/' character from the end of baseUrl and beginning of url.
            if (baseUrl[baseUrl.Length - 1] == '/')
            {
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);
            }
            if (url[0] == '/')
            {
                url = url.Substring(1);
            }
            url = baseUrl + "/" + url;
            url = url.Replace(" ", "%20");
            
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = null;
            try
            {
                httpRequest = new HttpRequestMessage();
                httpRequest.Method = HttpMethod.Get;
                httpRequest.RequestUri = new Uri(url);
                
                // Set Headers
                httpRequest.Headers.Add("Accept", "application/json");
                httpRequest.Headers.Add("x-ms-version", "2014-04-01");
                
                // Set Credentials
                cancellationToken.ThrowIfCancellationRequested();
                await this.Client.Credentials.ProcessHttpRequestAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                
                // Send Request
                HttpResponseMessage httpResponse = null;
                try
                {
                    if (shouldTrace)
                    {
                        TracingAdapter.SendRequest(invocationId, httpRequest);
                    }
                    cancellationToken.ThrowIfCancellationRequested();
                    httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
                    if (shouldTrace)
                    {
                        TracingAdapter.ReceiveResponse(invocationId, httpResponse);
                    }
                    HttpStatusCode statusCode = httpResponse.StatusCode;
                    if (statusCode != HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        CloudException ex = CloudException.Create(httpRequest, null, httpResponse, await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false));
                        if (shouldTrace)
                        {
                            TracingAdapter.Error(invocationId, ex);
                        }
                        throw ex;
                    }
                    
                    // Create Result
                    LogDefinitionListResponse result = null;
                    // Deserialize Response
                    if (statusCode == HttpStatusCode.OK)
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                        result = new LogDefinitionListResponse();
                        JToken responseDoc = null;
                        if (string.IsNullOrEmpty(responseContent) == false)
                        {
                            responseDoc = JToken.Parse(responseContent);
                        }
                        
                        if (responseDoc != null && responseDoc.Type != JTokenType.Null)
                        {
                            LogDefinitionCollection logDefinitionCollectionInstance = new LogDefinitionCollection();
                            result.LogDefinitionCollection = logDefinitionCollectionInstance;
                            
                            JToken valueArray = responseDoc["value"];
                            if (valueArray != null && valueArray.Type != JTokenType.Null)
                            {
                                foreach (JToken valueValue in ((JArray)valueArray))
                                {
                                    LogDefinition logDefinitionInstance = new LogDefinition();
                                    logDefinitionCollectionInstance.Value.Add(logDefinitionInstance);
                                    
                                    JToken categoryValue = valueValue["category"];
                                    if (categoryValue != null && categoryValue.Type != JTokenType.Null)
                                    {
                                        LocalizableString categoryInstance = new LocalizableString();
                                        logDefinitionInstance.Category = categoryInstance;
                                        
                                        JToken valueValue2 = categoryValue["value"];
                                        if (valueValue2 != null && valueValue2.Type != JTokenType.Null)
                                        {
                                            string valueInstance = ((string)valueValue2);
                                            categoryInstance.Value = valueInstance;
                                        }
                                        
                                        JToken localizedValueValue = categoryValue["localizedValue"];
                                        if (localizedValueValue != null && localizedValueValue.Type != JTokenType.Null)
                                        {
                                            string localizedValueInstance = ((string)localizedValueValue);
                                            categoryInstance.LocalizedValue = localizedValueInstance;
                                        }
                                    }
                                    
                                    JToken resourceIdValue = valueValue["resourceId"];
                                    if (resourceIdValue != null && resourceIdValue.Type != JTokenType.Null)
                                    {
                                        string resourceIdInstance = ((string)resourceIdValue);
                                        logDefinitionInstance.ResourceId = resourceIdInstance;
                                    }
                                    
                                    JToken retentionValue = valueValue["retention"];
                                    if (retentionValue != null && retentionValue.Type != JTokenType.Null)
                                    {
                                        TimeSpan retentionInstance = TimeSpan.Parse(((string)retentionValue), CultureInfo.InvariantCulture);
                                        logDefinitionInstance.Retention = retentionInstance;
                                    }
                                    
                                    JToken blobLocationValue = valueValue["blobLocation"];
                                    if (blobLocationValue != null && blobLocationValue.Type != JTokenType.Null)
                                    {
                                        BlobLocation blobLocationInstance = new BlobLocation();
                                        logDefinitionInstance.BlobLocation = blobLocationInstance;
                                        
                                        JToken blobEndpointValue = blobLocationValue["blobEndpoint"];
                                        if (blobEndpointValue != null && blobEndpointValue.Type != JTokenType.Null)
                                        {
                                            string blobEndpointInstance = ((string)blobEndpointValue);
                                            blobLocationInstance.BlobEndpoint = blobEndpointInstance;
                                        }
                                        
                                        JToken blobInfoArray = blobLocationValue["blobInfo"];
                                        if (blobInfoArray != null && blobInfoArray.Type != JTokenType.Null)
                                        {
                                            foreach (JToken blobInfoValue in ((JArray)blobInfoArray))
                                            {
                                                BlobInfo blobInfoInstance = new BlobInfo();
                                                blobLocationInstance.BlobInfo.Add(blobInfoInstance);
                                                
                                                JToken blobUriValue = blobInfoValue["blobUri"];
                                                if (blobUriValue != null && blobUriValue.Type != JTokenType.Null)
                                                {
                                                    string blobUriInstance = ((string)blobUriValue);
                                                    blobInfoInstance.BlobUri = blobUriInstance;
                                                }
                                                
                                                JToken startTimeValue = blobInfoValue["startTime"];
                                                if (startTimeValue != null && startTimeValue.Type != JTokenType.Null)
                                                {
                                                    DateTime startTimeInstance = ((DateTime)startTimeValue);
                                                    blobInfoInstance.StartTime = startTimeInstance;
                                                }
                                                
                                                JToken endTimeValue = blobInfoValue["endTime"];
                                                if (endTimeValue != null && endTimeValue.Type != JTokenType.Null)
                                                {
                                                    DateTime endTimeInstance = ((DateTime)endTimeValue);
                                                    blobInfoInstance.EndTime = endTimeInstance;
                                                }
                                                
                                                JToken sasTokenValue = blobInfoValue["sasToken"];
                                                if (sasTokenValue != null && sasTokenValue.Type != JTokenType.Null)
                                                {
                                                    string sasTokenInstance = ((string)sasTokenValue);
                                                    blobInfoInstance.SasToken = sasTokenInstance;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        
                    }
                    result.StatusCode = statusCode;
                    if (httpResponse.Headers.Contains("x-ms-request-id"))
                    {
                        result.RequestId = httpResponse.Headers.GetValues("x-ms-request-id").FirstOrDefault();
                    }
                    
                    if (shouldTrace)
                    {
                        TracingAdapter.Exit(invocationId, result);
                    }
                    return result;
                }
                finally
                {
                    if (httpResponse != null)
                    {
                        httpResponse.Dispose();
                    }
                }
            }
            finally
            {
                if (httpRequest != null)
                {
                    httpRequest.Dispose();
                }
            }
        }
    }
}