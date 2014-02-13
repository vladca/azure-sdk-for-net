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
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Management.Compute.Models;

namespace Microsoft.WindowsAzure.Management.Compute.Models
{
    /// <summary>
    /// A virtual machine disk associated with your subscription.
    /// </summary>
    public partial class VirtualMachineDiskGetDiskResponse : OperationResponse
    {
        private string _affinityGroup;
        
        /// <summary>
        /// The affinity group in which the disk is located. The AffinityGroup
        /// value is derived from storage account that contains the blob in
        /// which the media is located. If the storage account does not belong
        /// to an affinity group the value is NULL.
        /// </summary>
        public string AffinityGroup
        {
            get { return this._affinityGroup; }
            set { this._affinityGroup = value; }
        }
        
        private bool? _isCorrupted;
        
        /// <summary>
        /// Specifies thether the disk is known to be corrupt.
        /// </summary>
        public bool? IsCorrupted
        {
            get { return this._isCorrupted; }
            set { this._isCorrupted = value; }
        }
        
        private bool? _isPremium;
        
        /// <summary>
        /// Specifies whether or not the disk contains a premium virtual
        /// machine image.
        /// </summary>
        public bool? IsPremium
        {
            get { return this._isPremium; }
            set { this._isPremium = value; }
        }
        
        private string _label;
        
        /// <summary>
        /// The friendly name of the disk.
        /// </summary>
        public string Label
        {
            get { return this._label; }
            set { this._label = value; }
        }
        
        private string _location;
        
        /// <summary>
        /// The geo-location in which the disk is located. The Location value
        /// is derived from storage account that contains the blob in which
        /// the disk is located. If the storage account belongs to an affinity
        /// group the value is NULL.
        /// </summary>
        public string Location
        {
            get { return this._location; }
            set { this._location = value; }
        }
        
        private int _logicalSizeInGB;
        
        /// <summary>
        /// The size, in GB, of the disk.
        /// </summary>
        public int LogicalSizeInGB
        {
            get { return this._logicalSizeInGB; }
            set { this._logicalSizeInGB = value; }
        }
        
        private Uri _mediaLinkUri;
        
        /// <summary>
        /// The location of the blob in the blob store in which the media for
        /// the disk is located. The blob location belongs to a storage
        /// account in the subscription specified by the SubscriptionId value
        /// in the operation call. Example:
        /// http://example.blob.core.windows.net/disks/mydisk.vhd
        /// </summary>
        public Uri MediaLinkUri
        {
            get { return this._mediaLinkUri; }
            set { this._mediaLinkUri = value; }
        }
        
        private string _name;
        
        /// <summary>
        /// The name of the disk. This is the name that is used when creating
        /// one or more virtual machines using the disk.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private string _operatingSystemType;
        
        /// <summary>
        /// The operating system type of the OS image.  Possible Values are:
        /// Linux, Windows, NULL.
        /// </summary>
        public string OperatingSystemType
        {
            get { return this._operatingSystemType; }
            set { this._operatingSystemType = value; }
        }
        
        private string _sourceImageName;
        
        /// <summary>
        /// The name of the OS Image from which the disk was created. This
        /// property is populated automatically when a disk is created from an
        /// OS image by calling the Add Role, Create Deployment, or Provision
        /// Disk operations.
        /// </summary>
        public string SourceImageName
        {
            get { return this._sourceImageName; }
            set { this._sourceImageName = value; }
        }
        
        private VirtualMachineDiskGetDiskResponse.VirtualMachineDiskUsageDetails _usageDetails;
        
        /// <summary>
        /// Contains properties that specify a virtual machine that currently
        /// using the disk. A disk cannot be deleted as long as it is attached
        /// to a virtual machine.
        /// </summary>
        public VirtualMachineDiskGetDiskResponse.VirtualMachineDiskUsageDetails UsageDetails
        {
            get { return this._usageDetails; }
            set { this._usageDetails = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the VirtualMachineDiskGetDiskResponse
        /// class.
        /// </summary>
        public VirtualMachineDiskGetDiskResponse()
        {
        }
        
        /// <summary>
        /// Contains properties that specify a virtual machine that currently
        /// using the disk. A disk cannot be deleted as long as it is attached
        /// to a virtual machine.
        /// </summary>
        public partial class VirtualMachineDiskUsageDetails
        {
            private string _deploymentName;
            
            /// <summary>
            /// The deployment in which the disk is being used.
            /// </summary>
            public string DeploymentName
            {
                get { return this._deploymentName; }
                set { this._deploymentName = value; }
            }
            
            private string _hostedServiceName;
            
            /// <summary>
            /// The hosted service in which the disk is being used.
            /// </summary>
            public string HostedServiceName
            {
                get { return this._hostedServiceName; }
                set { this._hostedServiceName = value; }
            }
            
            private string _roleName;
            
            /// <summary>
            /// The virtual machine that the disk is attached to.
            /// </summary>
            public string RoleName
            {
                get { return this._roleName; }
                set { this._roleName = value; }
            }
            
            /// <summary>
            /// Initializes a new instance of the
            /// VirtualMachineDiskUsageDetails class.
            /// </summary>
            public VirtualMachineDiskUsageDetails()
            {
            }
        }
    }
}
