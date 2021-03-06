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
using Microsoft.WindowsAzure.Management.Network.Models;

namespace Microsoft.WindowsAzure.Management.Network.Models
{
    public partial class AGHttpListener
    {
        private string _frontendIP;
        
        /// <summary>
        /// Optional. Name of the Frontend IP.
        /// </summary>
        public string FrontendIP
        {
            get { return this._frontendIP; }
            set { this._frontendIP = value; }
        }
        
        private string _frontendPort;
        
        /// <summary>
        /// Optional.
        /// </summary>
        public string FrontendPort
        {
            get { return this._frontendPort; }
            set { this._frontendPort = value; }
        }
        
        private string _name;
        
        /// <summary>
        /// Optional. Name of the Front End Port.
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        
        private Protocol _protocol;
        
        /// <summary>
        /// Optional. Protocol
        /// </summary>
        public Protocol Protocol
        {
            get { return this._protocol; }
            set { this._protocol = value; }
        }
        
        private string _sslCert;
        
        /// <summary>
        /// Optional. Whether to do load balancing using cookie based affinity
        /// </summary>
        public string SslCert
        {
            get { return this._sslCert; }
            set { this._sslCert = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the AGHttpListener class.
        /// </summary>
        public AGHttpListener()
        {
        }
    }
}
