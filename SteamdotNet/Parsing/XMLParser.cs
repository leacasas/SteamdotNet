using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Xml.Serialization;

namespace SteamdotNet.Parsing
{
    /// <summary>
    /// XML Parser
    /// </summary>
    public sealed class XMLParser : BaseParser
    {
        /// <summary>
        /// Parses a JSON from a service call to a given object type.
        /// It deserializes directly to a stream to reduce memory usage.
        /// </summary>
        /// <param name="url">URL of the service to call</param>
        /// <typeparam name="T">Type of object to return</typeparam>
        /// <returns>Parsed object of T type</returns>
        public override T ParseFromURL<T>(string url)
        {
            using (var client = new HttpClient())
            using (Stream stream = client.GetStreamAsync(url).Result)
            using (var reader = new StreamReader(stream))
            {
                string serializableFieldName;
                Type serializableType = GetXMLRootFieldType(typeof(T), out serializableFieldName);
                var serializer = new XmlSerializer(serializableType);
                return WrapWithinObjectOfType<T>(serializer.Deserialize(reader), serializableType, serializableFieldName);
            }
        }

        /// <summary>
        /// Serializes a given object into XML.
        /// </summary>
        /// <param name="source">Object to serialize</param>
        /// <typeparam name="T">Object type</typeparam>
        /// <returns>Serialized object into a XML String</returns>
        public override string SerializeFromObject<T>(T source)
        {
            using (var writer = new StringWriter())
            {
                var serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(writer, source);
                return writer.ToString();
            }
        }

        /// <summary>
        /// Deserializes a given XML into an object
        /// </summary>
        /// <param name="source">string containing the XML Document</param>
        /// <typeparam name="T">Object type</typeparam>
        /// <returns>Deserialized object</returns>
        public override T DeserializeToObject<T>(string source)
        {
            using (var reader = new StringReader(source))
            {
                var serializer = new XmlSerializer(typeof(T));
                return (T)serializer.Deserialize(reader);
            }
        }

        private Type GetXMLRootFieldType(Type rootType, out string fieldName)
        {
            fieldName = string.Empty;
            if (rootType.GetCustomAttributes(typeof(SerializableAttribute), false).Length > 0)
                return rootType;
            foreach (var fieldInfo in rootType.GetProperties().Where(f => f.GetType().GetCustomAttributes(typeof(SerializableAttribute), false).Length > 0))
            {
                fieldName = fieldInfo.Name;
                return fieldInfo.PropertyType;
            }
            throw new Exception(String.Format("Couldn't find XmlRoot attribute within object of type {0}", rootType));//CHANGE FOR MORE SUITABLE EXCEPTION
        }

        private T WrapWithinObjectOfType<T>(object deserializedObject, Type targetType, string fieldName) where T : new()
        {
            if (typeof(T) == targetType)
                return (T)deserializedObject;
            if (typeof(T).GetProperties().Any(t => t.PropertyType == targetType && t.GetType().GetCustomAttributes(typeof(SerializableAttribute), false).Length > 0))
            {
                var result = new T();
                result.GetType().GetProperty(fieldName).SetValue(result, deserializedObject);
                return result;
            }
            throw new Exception("Failed to find the XmlRoot property of object type of type" + targetType);//CHANGE FOR MORE SUITABLE EXCEPTION
        }
    }
}