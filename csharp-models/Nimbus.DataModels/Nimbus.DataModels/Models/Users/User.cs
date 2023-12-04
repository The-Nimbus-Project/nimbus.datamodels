namespace Nimbus.DataModels.Models.Users
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using MongoDB.Bson;
    using MongoDB.Bson.Serialization.Attributes;

    public partial class User
    {
        /// <summary>
        /// MongoDB ObjectId
        /// </summary>
        [BsonElement("_id")]
        public ObjectId Id { get; set; }

        /// <summary>
        /// List of MongoDB ObjectId
        /// </summary>
        [BsonElement("approvedDataSegment_ids")]
        public List<ObjectId> ApprovedDataSegmentIds { get; set; }

        [BsonElement("email")]
        public string Email { get; set; }

        [BsonElement("firstName")]
        public string FirstName { get; set; }

        [BsonElement("isActive")]
        public bool? IsActive { get; set; }

        [BsonElement("isDeleted")]
        public bool? IsDeleted { get; set; }

        [BsonElement("lastName")]
        public string LastName { get; set; }

        [BsonElement("middleInitial")]
        public string MiddleInitial { get; set; }

        /// <summary>
        /// MongoDB ObjectId
        /// </summary>
        [BsonElement("organization_id")]
        public ObjectId OrganizationId { get; set; }

        [BsonElement("passwordHash")]
        public string PasswordHash { get; set; }

        [BsonElement("phone")]
        public string Phone { get; set; }

        [BsonElement("userName")]
        public string UserName { get; set; }
    }
}
