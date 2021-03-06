// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Search.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Truncates the terms to a specific length. This token filter is
    /// implemented using Apache Lucene.
    /// <see
    /// href="http://lucene.apache.org/core/4_10_3/analyzers-common/org/apache/lucene/analysis/miscellaneous/TruncateTokenFilter.html"
    /// />
    /// </summary>
    [Newtonsoft.Json.JsonObject("#Microsoft.Azure.Search.TruncateTokenFilter")]
    public partial class TruncateTokenFilter : TokenFilter
    {
        /// <summary>
        /// Initializes a new instance of the TruncateTokenFilter class.
        /// </summary>
        public TruncateTokenFilter()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TruncateTokenFilter class.
        /// </summary>
        /// <param name="name">The name of the token filter. It must only
        /// contain letters, digits, spaces, dashes or underscores, can only
        /// start and end with alphanumeric characters, and is limited to 128
        /// characters.</param>
        /// <param name="length">The length at which terms will be truncated.
        /// Default and maximum is 300.</param>
        public TruncateTokenFilter(string name, int? length = default(int?))
            : base(name)
        {
            Length = length;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the length at which terms will be truncated. Default
        /// and maximum is 300.
        /// </summary>
        [JsonProperty(PropertyName = "length")]
        public int? Length { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Length > 300)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "Length", 300);
            }
        }
    }
}
