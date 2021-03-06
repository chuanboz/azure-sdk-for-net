﻿// Copyright (c) Microsoft Corporation
// All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License"); you may not
// use this file except in compliance with the License.  You may obtain a copy
// of the License at http://www.apache.org/licenses/LICENSE-2.0
// 
// THIS CODE IS PROVIDED *AS IS* BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
// KIND, EITHER EXPRESS OR IMPLIED, INCLUDING WITHOUT LIMITATION ANY IMPLIED
// WARRANTIES OR CONDITIONS OF TITLE, FITNESS FOR A PARTICULAR PURPOSE,
// MERCHANTABLITY OR NON-INFRINGEMENT.
// 
// See the Apache Version 2.0 License for specific language governing
// permissions and limitations under the License.
namespace Microsoft.WindowsAzure.Management.HDInsight.Framework.Core.Library.Json
{
    /// <summary>
    /// Represents a string in Json.
    /// </summary>
#if Non_Public_SDK
    public class JsonString : JsonItem
#else
    internal class JsonString : JsonItem
#endif
    {
        private string data;

        /// <inheritdoc />
        public override bool TryGetValue(out string asString)
        {
            asString = this.data;
            return true;
        }

        /// <inheritdoc />
        public override bool IsString
        {
            get { return true; }
        }

        /// <inheritdoc />
        public override bool IsNull
        {
            get { return this.data.IsNull(); }
        }

        /// <inheritdoc />
        public override bool IsEmpty
        {
            get { return this.data.Length == 0; }
        }

        /// <summary>
        /// Initializes a new instance of the JsonString class.
        /// </summary>
        /// <param name="input">
        /// The string representing the item.
        /// </param>
        public JsonString(string input)
        {
            this.data = input;
        }

        /// <inheritdoc />
        public override string ToString()
        {
            return JsonEncodeString(this.data);
        }
    }
}
