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
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure;
using Microsoft.AzureStack.Management.Models;

namespace Microsoft.AzureStack.Management
{
    /// <summary>
    /// Resource provider manifest registration operations  (see
    /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXX.aspx for
    /// more information)
    /// </summary>
    public partial interface IProviderRegistrationOperations
    {
        /// <summary>
        /// Registers a resource provider manifest
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Resource group name
        /// </param>
        /// <param name='parameters'>
        /// Resource provider manifest definition
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Result of the create or update of resource provider manifest
        /// </returns>
        Task<ProviderRegistrationCreateOrUpdateResult> CreateOrUpdateAsync(string resourceGroupName, ProviderRegistrationCreateOrUpdateParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Deletes the resource provider registration
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Resource group name
        /// </param>
        /// <param name='providerregistrationId'>
        /// Resource provider manifest Id
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> DeleteAsync(string resourceGroupName, string providerregistrationId, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets the manifest registration for the specified manifest
        /// registration id
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Resource group name
        /// </param>
        /// <param name='providerregistrationId'>
        /// Resource provider manifest registration Id
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Get result of the resource provider manifest registration
        /// </returns>
        Task<ProviderRegistrationGetResult> GetAsync(string resourceGroupName, string providerregistrationId, CancellationToken cancellationToken);
        
        /// <summary>
        /// Lists the registered provider manifest given a resource group
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Resource group name
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Result of the resource provider manifest list operation
        /// </returns>
        Task<ProviderRegistrationListResult> ListAsync(string resourceGroupName, CancellationToken cancellationToken);
    }
}
