namespace Nimbus.DataModels.Models.DataSegments
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using MongoDB.Bson;
    using MongoDB.Bson.Serialization.Attributes;

    public partial class DataSegment
    {
        /// <summary>
        /// MongoDB ObjectId
        /// </summary>
        [BsonElement("_id")]
        public ObjectId Id { get; set; }

        [BsonElement("code")]
        public string Code { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }
    }
}
