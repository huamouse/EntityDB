using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Reflection;
using System.ComponentModel.DataAnnotations.Schema;

namespace Way.EntityDB
{
    public class DataItemTextJsonConverter : JsonConverter<DataItem>
    {
        static Type baseType = typeof(DataItem);
        public override bool CanConvert(Type typeToConvert)
        {
            return typeToConvert.IsSubclassOf(baseType);
        }
        public override DataItem Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if(reader.TokenType == JsonTokenType.StartObject)
            {
                DataItem dataitem = (DataItem)Activator.CreateInstance(typeToConvert);
                dataitem.m_notSendPropertyChanged = true;

                //这种是自己去读reader
                string proName = null;
                while (reader.TokenType != JsonTokenType.EndObject)
                {
                    if (reader.TokenType == JsonTokenType.PropertyName)
                    {
                        proName = reader.GetString();
                        reader.Read();
                        var proInfo = typeToConvert.GetProperty(proName);
                        var value = JsonSerializer.Deserialize(ref reader, proInfo.PropertyType, options);
                        if( value != null)
                            proInfo.SetValue(dataitem, value);
                    }
                    reader.Read();
                }
                dataitem.m_notSendPropertyChanged = false;
                return dataitem;
            }
            return null;
        }

        public override void Write(Utf8JsonWriter writer, DataItem dataitem, JsonSerializerOptions options)
        {
            var properties = dataitem.GetType().GetTypeInfo().GetProperties();
            writer.WriteStartObject();
            foreach (var p in properties)
            {
                if (p.GetCustomAttribute(typeof(NotMappedAttribute)) != null)
                    continue;
                object pvalue = p.GetValue(dataitem);
                if (pvalue == null && options.DefaultIgnoreCondition.HasFlag(JsonIgnoreCondition.WhenWritingNull))
                    continue;
                writer.WritePropertyName(p.Name);

                JsonSerializer.Serialize(writer, pvalue, options);

            }
            if (dataitem.ChangedProperties.Count > 0)
            {
                writer.WritePropertyName("ChangedProperties");
                JsonSerializer.Serialize(writer, dataitem.ChangedProperties, options);
            }
            if (dataitem.BackupChangedProperties.Count > 0)
            {
                writer.WritePropertyName("BackupChangedProperties");
                JsonSerializer.Serialize(writer, dataitem.BackupChangedProperties, options);
            }
            writer.WriteEndObject();
        }
    }
}
