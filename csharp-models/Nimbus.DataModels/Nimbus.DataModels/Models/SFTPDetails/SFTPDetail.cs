namespace Nimbus.DataModels.Models.SFTPDetails
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using MongoDB.Bson;
    using MongoDB.Bson.Serialization.Attributes;

    public partial class SftpDetail
    {
        /// <summary>
        /// MongoDB ObjectId
        /// </summary>
        [BsonElement("_id")]
        public ObjectId Id { get; set; }

        [BsonElement("address")]
        public string Address { get; set; }

        [BsonElement("isReachable")]
        public bool? IsReachable { get; set; }

        [BsonElement("key")]
        public string Key { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// MongoDB ObjectId
        /// </summary>
        [BsonElement("organization_id")]
        public ObjectId OrganizationId { get; set; }

        [BsonElement("passwordHash")]
        public string PasswordHash { get; set; }

        [BsonElement("userName")]
        public string UserName { get; set; }
    }
}
