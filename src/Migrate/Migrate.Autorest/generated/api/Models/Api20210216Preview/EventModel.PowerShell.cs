// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview
{
    using Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.PowerShell;

    /// <summary>Event model.</summary>
    [System.ComponentModel.TypeConverter(typeof(EventModelTypeConverter))]
    public partial class EventModel
    {

        /// <summary>
        /// <c>AfterDeserializeDictionary</c> will be called after the deserialization has finished, allowing customization of the
        /// object before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>

        partial void AfterDeserializeDictionary(global::System.Collections.IDictionary content);

        /// <summary>
        /// <c>AfterDeserializePSObject</c> will be called after the deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>

        partial void AfterDeserializePSObject(global::System.Management.Automation.PSObject content);

        /// <summary>
        /// <c>BeforeDeserializeDictionary</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializeDictionary(global::System.Collections.IDictionary content, ref bool returnNow);

        /// <summary>
        /// <c>BeforeDeserializePSObject</c> will be called before the deserialization has commenced, allowing complete customization
        /// of the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeDeserializePSObject(global::System.Management.Automation.PSObject content, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.EventModel"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModel" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModel DeserializeFromDictionary(global::System.Collections.IDictionary content)
        {
            return new EventModel(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.EventModel"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        /// <returns>
        /// an instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModel" />.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModel DeserializeFromPSObject(global::System.Management.Automation.PSObject content)
        {
            return new EventModel(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Collections.IDictionary" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.EventModel"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Collections.IDictionary content that should be used.</param>
        internal EventModel(global::System.Collections.IDictionary content)
        {
            bool returnNow = false;
            BeforeDeserializeDictionary(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.EventModelPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.ISystemDataModel) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.SystemDataModelTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("CustomProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelInternal)this).CustomProperty = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelCustomProperties) content.GetValueForProperty("CustomProperty",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelInternal)this).CustomProperty, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.EventModelCustomPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ResourceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelInternal)this).ResourceType = (string) content.GetValueForProperty("ResourceType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelInternal)this).ResourceType, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelInternal)this).ResourceName = (string) content.GetValueForProperty("ResourceName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelInternal)this).ResourceName, global::System.Convert.ToString);
            }
            if (content.Contains("EventType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelInternal)this).EventType = (string) content.GetValueForProperty("EventType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelInternal)this).EventType, global::System.Convert.ToString);
            }
            if (content.Contains("EventName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelInternal)this).EventName = (string) content.GetValueForProperty("EventName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelInternal)this).EventName, global::System.Convert.ToString);
            }
            if (content.Contains("TimeOfOccurrence"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelInternal)this).TimeOfOccurrence = (global::System.DateTime?) content.GetValueForProperty("TimeOfOccurrence",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelInternal)this).TimeOfOccurrence, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("Severity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelInternal)this).Severity = (string) content.GetValueForProperty("Severity",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelInternal)this).Severity, global::System.Convert.ToString);
            }
            if (content.Contains("Description"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelInternal)this).Description = (string) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelInternal)this).Description, global::System.Convert.ToString);
            }
            if (content.Contains("CorrelationId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelInternal)this).CorrelationId = (string) content.GetValueForProperty("CorrelationId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelInternal)this).CorrelationId, global::System.Convert.ToString);
            }
            if (content.Contains("HealthError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelInternal)this).HealthError = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IHealthErrorModel[]) content.GetValueForProperty("HealthError",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelInternal)this).HealthError, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IHealthErrorModel>(__y, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.HealthErrorModelTypeConverter.ConvertFrom));
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelInternal)this).SystemDataCreatedByType = (string) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelInternal)this).SystemDataCreatedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelInternal)this).SystemDataLastModifiedByType = (string) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelInternal)this).SystemDataLastModifiedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("CustomPropertyInstanceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelInternal)this).CustomPropertyInstanceType = (string) content.GetValueForProperty("CustomPropertyInstanceType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelInternal)this).CustomPropertyInstanceType, global::System.Convert.ToString);
            }
            AfterDeserializeDictionary(content);
        }

        /// <summary>
        /// Deserializes a <see cref="global::System.Management.Automation.PSObject" /> into a new instance of <see cref="Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.EventModel"
        /// />.
        /// </summary>
        /// <param name="content">The global::System.Management.Automation.PSObject content that should be used.</param>
        internal EventModel(global::System.Management.Automation.PSObject content)
        {
            bool returnNow = false;
            BeforeDeserializePSObject(content, ref returnNow);
            if (returnNow)
            {
                return;
            }
            // actually deserialize
            if (content.Contains("Property"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelInternal)this).Property = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelProperties) content.GetValueForProperty("Property",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelInternal)this).Property, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.EventModelPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("SystemData"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelInternal)this).SystemData = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.ISystemDataModel) content.GetValueForProperty("SystemData",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelInternal)this).SystemData, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.SystemDataModelTypeConverter.ConvertFrom);
            }
            if (content.Contains("Id"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelInternal)this).Id = (string) content.GetValueForProperty("Id",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelInternal)this).Id, global::System.Convert.ToString);
            }
            if (content.Contains("Name"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelInternal)this).Name = (string) content.GetValueForProperty("Name",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelInternal)this).Name, global::System.Convert.ToString);
            }
            if (content.Contains("Type"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelInternal)this).Type = (string) content.GetValueForProperty("Type",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelInternal)this).Type, global::System.Convert.ToString);
            }
            if (content.Contains("CustomProperty"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelInternal)this).CustomProperty = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelCustomProperties) content.GetValueForProperty("CustomProperty",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelInternal)this).CustomProperty, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.EventModelCustomPropertiesTypeConverter.ConvertFrom);
            }
            if (content.Contains("ResourceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelInternal)this).ResourceType = (string) content.GetValueForProperty("ResourceType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelInternal)this).ResourceType, global::System.Convert.ToString);
            }
            if (content.Contains("ResourceName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelInternal)this).ResourceName = (string) content.GetValueForProperty("ResourceName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelInternal)this).ResourceName, global::System.Convert.ToString);
            }
            if (content.Contains("EventType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelInternal)this).EventType = (string) content.GetValueForProperty("EventType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelInternal)this).EventType, global::System.Convert.ToString);
            }
            if (content.Contains("EventName"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelInternal)this).EventName = (string) content.GetValueForProperty("EventName",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelInternal)this).EventName, global::System.Convert.ToString);
            }
            if (content.Contains("TimeOfOccurrence"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelInternal)this).TimeOfOccurrence = (global::System.DateTime?) content.GetValueForProperty("TimeOfOccurrence",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelInternal)this).TimeOfOccurrence, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("Severity"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelInternal)this).Severity = (string) content.GetValueForProperty("Severity",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelInternal)this).Severity, global::System.Convert.ToString);
            }
            if (content.Contains("Description"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelInternal)this).Description = (string) content.GetValueForProperty("Description",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelInternal)this).Description, global::System.Convert.ToString);
            }
            if (content.Contains("CorrelationId"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelInternal)this).CorrelationId = (string) content.GetValueForProperty("CorrelationId",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelInternal)this).CorrelationId, global::System.Convert.ToString);
            }
            if (content.Contains("HealthError"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelInternal)this).HealthError = (Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IHealthErrorModel[]) content.GetValueForProperty("HealthError",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelInternal)this).HealthError, __y => TypeConverterExtensions.SelectToArray<Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IHealthErrorModel>(__y, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.HealthErrorModelTypeConverter.ConvertFrom));
            }
            if (content.Contains("SystemDataCreatedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelInternal)this).SystemDataCreatedBy = (string) content.GetValueForProperty("SystemDataCreatedBy",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelInternal)this).SystemDataCreatedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelInternal)this).SystemDataCreatedByType = (string) content.GetValueForProperty("SystemDataCreatedByType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelInternal)this).SystemDataCreatedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataCreatedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelInternal)this).SystemDataCreatedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataCreatedAt",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelInternal)this).SystemDataCreatedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("SystemDataLastModifiedBy"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelInternal)this).SystemDataLastModifiedBy = (string) content.GetValueForProperty("SystemDataLastModifiedBy",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelInternal)this).SystemDataLastModifiedBy, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedByType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelInternal)this).SystemDataLastModifiedByType = (string) content.GetValueForProperty("SystemDataLastModifiedByType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelInternal)this).SystemDataLastModifiedByType, global::System.Convert.ToString);
            }
            if (content.Contains("SystemDataLastModifiedAt"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelInternal)this).SystemDataLastModifiedAt = (global::System.DateTime?) content.GetValueForProperty("SystemDataLastModifiedAt",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelInternal)this).SystemDataLastModifiedAt, (v) => v is global::System.DateTime _v ? _v : global::System.Xml.XmlConvert.ToDateTime( v.ToString() , global::System.Xml.XmlDateTimeSerializationMode.Unspecified));
            }
            if (content.Contains("CustomPropertyInstanceType"))
            {
                ((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelInternal)this).CustomPropertyInstanceType = (string) content.GetValueForProperty("CustomPropertyInstanceType",((Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModelInternal)this).CustomPropertyInstanceType, global::System.Convert.ToString);
            }
            AfterDeserializePSObject(content);
        }

        /// <summary>
        /// Creates a new instance of <see cref="EventModel" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="EventModel" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210216Preview.IEventModel FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Json.JsonNode.Parse(jsonText));

        /// <summary>Serializes this instance to a json string.</summary>

        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Event model.
    [System.ComponentModel.TypeConverter(typeof(EventModelTypeConverter))]
    public partial interface IEventModel

    {

    }
}