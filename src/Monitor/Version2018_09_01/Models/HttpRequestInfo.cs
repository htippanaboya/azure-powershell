// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Monitor.Version2018_09_01.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The Http request info.
    /// </summary>
    public partial class HttpRequestInfo
    {
        /// <summary>
        /// Initializes a new instance of the HttpRequestInfo class.
        /// </summary>
        public HttpRequestInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the HttpRequestInfo class.
        /// </summary>
        /// <param name="clientRequestId">the client request id.</param>
        /// <param name="clientIpAddress">the client Ip Address</param>
        /// <param name="method">the Http request method.</param>
        /// <param name="uri">the Uri.</param>
        public HttpRequestInfo(string clientRequestId = default(string), string clientIpAddress = default(string), string method = default(string), string uri = default(string))
        {
            ClientRequestId = clientRequestId;
            ClientIpAddress = clientIpAddress;
            Method = method;
            Uri = uri;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the client request id.
        /// </summary>
        [JsonProperty(PropertyName = "clientRequestId")]
        public string ClientRequestId { get; set; }

        /// <summary>
        /// Gets or sets the client Ip Address
        /// </summary>
        [JsonProperty(PropertyName = "clientIpAddress")]
        public string ClientIpAddress { get; set; }

        /// <summary>
        /// Gets or sets the Http request method.
        /// </summary>
        [JsonProperty(PropertyName = "method")]
        public string Method { get; set; }

        /// <summary>
        /// Gets or sets the Uri.
        /// </summary>
        [JsonProperty(PropertyName = "uri")]
        public string Uri { get; set; }

    }
}
