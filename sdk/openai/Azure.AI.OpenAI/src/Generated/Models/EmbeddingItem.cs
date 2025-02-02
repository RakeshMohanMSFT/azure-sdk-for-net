// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.AI.OpenAI.Models
{
    /// <summary> The EmbeddingItem. </summary>
    public partial class EmbeddingItem
    {
        /// <summary> Initializes a new instance of EmbeddingItem. </summary>
        /// <param name="object"></param>
        /// <param name="embedding"></param>
        /// <param name="index"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="object"/> or <paramref name="embedding"/> is null. </exception>
        internal EmbeddingItem(string @object, IEnumerable<float> embedding, int index)
        {
            Argument.AssertNotNull(@object, nameof(@object));
            Argument.AssertNotNull(embedding, nameof(embedding));

            Object = @object;
            Embedding = embedding.ToList();
            Index = index;
        }

        /// <summary> Initializes a new instance of EmbeddingItem. </summary>
        /// <param name="object"></param>
        /// <param name="embedding"></param>
        /// <param name="index"></param>
        internal EmbeddingItem(string @object, IReadOnlyList<float> embedding, int index)
        {
            Object = @object;
            Embedding = embedding.ToList();
            Index = index;
        }

        /// <summary> Gets the object. </summary>
        public string Object { get; }
        /// <summary> Gets the embedding. </summary>
        public IReadOnlyList<float> Embedding { get; }
        /// <summary> Gets the index. </summary>
        public int Index { get; }
    }
}
