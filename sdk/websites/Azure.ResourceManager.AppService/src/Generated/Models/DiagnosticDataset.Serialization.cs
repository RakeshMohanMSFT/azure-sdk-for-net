// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class DiagnosticDataset : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Table))
            {
                writer.WritePropertyName("table");
                writer.WriteObjectValue(Table);
            }
            if (Optional.IsDefined(RenderingProperties))
            {
                writer.WritePropertyName("renderingProperties");
                writer.WriteObjectValue(RenderingProperties);
            }
            writer.WriteEndObject();
        }

        internal static DiagnosticDataset DeserializeDiagnosticDataset(JsonElement element)
        {
            Optional<DataTableResponseObject> table = default;
            Optional<DiagnosticDataRendering> renderingProperties = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("table"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    table = DataTableResponseObject.DeserializeDataTableResponseObject(property.Value);
                    continue;
                }
                if (property.NameEquals("renderingProperties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    renderingProperties = DiagnosticDataRendering.DeserializeDiagnosticDataRendering(property.Value);
                    continue;
                }
            }
            return new DiagnosticDataset(table.Value, renderingProperties.Value);
        }
    }
}
