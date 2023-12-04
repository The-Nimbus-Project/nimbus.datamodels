namespace Nimbus.DataModels.Models.ConfigurationLists
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using MongoDB.Bson;
    using MongoDB.Bson.Serialization.Attributes;

    public partial class ConfigurationList
    {
        /// <summary>
        /// MongoDB ObjectId
        /// </summary>
        [BsonElement("_id")]
        public ObjectId Id { get; set; }

        [BsonElement("applicableDataSegmentIds")]
        public List<string> ApplicableDataSegmentIds { get; set; }

        [BsonElement("configurations")]
        public List<Configuration> Configurations { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("readOnly")]
        public bool? ReadOnly { get; set; }
    }

    public partial class Configuration
    {
        /// <summary>
        /// MongoDB ObjectId
        /// </summary>
        [BsonElement("_id")]
        public ObjectId Id { get; set; }

        [BsonElement("descriptor")]
        public string Descriptor { get; set; }

        [BsonElement("details")]
        public List<Detail> Details { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }
    }

    public partial class Detail
    {
        /// <summary>
        /// MongoDB ObjectId
        /// </summary>
        [BsonElement("_id")]
        public ObjectId Id { get; set; }

        [BsonElement("descriptor")]
        public string Descriptor { get; set; }

        [BsonElement("identifier")]
        public string Identifier { get; set; }
    }
}
