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
using System.Linq;
using Hyak.Common;
using Microsoft.Azure.Insights.Models;

namespace Microsoft.Azure.Insights.Models
{
    /// <summary>
    /// The event count summary item for a single resource.
    /// </summary>
    public partial class EventStatusCountSummaryItem
    {
        private DateTime _eventTime;
        
        /// <summary>
        /// Optional. The event summary time.
        /// </summary>
        public DateTime EventTime
        {
            get { return this._eventTime; }
            set { this._eventTime = value; }
        }
        
        private string _id;
        
        /// <summary>
        /// Optional. The resource id.
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }
        
        private IList<StatusCount> _statusCounts;
        
        /// <summary>
        /// Optional. The status counts.
        /// </summary>
        public IList<StatusCount> StatusCounts
        {
            get { return this._statusCounts; }
            set { this._statusCounts = value; }
        }
        
        private TimeSpan _timeGrain;
        
        /// <summary>
        /// Optional. The time grain of the summary item.
        /// </summary>
        public TimeSpan TimeGrain
        {
            get { return this._timeGrain; }
            set { this._timeGrain = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the EventStatusCountSummaryItem class.
        /// </summary>
        public EventStatusCountSummaryItem()
        {
            this.StatusCounts = new LazyList<StatusCount>();
        }
    }
}
