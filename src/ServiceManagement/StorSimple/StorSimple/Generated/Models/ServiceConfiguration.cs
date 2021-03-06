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
using Microsoft.WindowsAzure.Management.StorSimple.Models;

namespace Microsoft.WindowsAzure.Management.StorSimple.Models
{
    /// <summary>
    /// Info about the service configuration regarding the resource
    /// </summary>
    public partial class ServiceConfiguration
    {
        private AcrChangeList _acrChangeList;
        
        /// <summary>
        /// Optional. List of access control record
        /// </summary>
        public AcrChangeList AcrChangeList
        {
            get { return this._acrChangeList; }
            set { this._acrChangeList = value; }
        }
        
        private SacChangeList _credentialChangeList;
        
        /// <summary>
        /// Optional. List of credential change list
        /// </summary>
        public SacChangeList CredentialChangeList
        {
            get { return this._credentialChangeList; }
            set { this._credentialChangeList = value; }
        }
        
        private bool _operationInProgress;
        
        /// <summary>
        /// Optional. Is operation in progress
        /// </summary>
        public bool OperationInProgress
        {
            get { return this._operationInProgress; }
            set { this._operationInProgress = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ServiceConfiguration class.
        /// </summary>
        public ServiceConfiguration()
        {
        }
    }
}
