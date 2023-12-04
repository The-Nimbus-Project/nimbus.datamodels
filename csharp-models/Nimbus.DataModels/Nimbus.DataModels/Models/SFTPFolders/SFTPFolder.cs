namespace Nimbus.DataModels.Models.SFTPFolders
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using MongoDB.Bson;
    using MongoDB.Bson.Serialization.Attributes;

    public partial class SftpFolder
    {
        /// <summary>
        /// MongoDB ObjectId
        /// </summary>
        [BsonElement("_id")]
        public ObjectId Id { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("path")]
        public string Path { get; set; }

        [BsonElement("patterns")]
        public List<SftpFolderPattern> Patterns { get; set; }

        /// <summary>
        /// MongoDB ObjectId
        /// </summary>
        [BsonElement("sftp_id")]
        public ObjectId SftpId { get; set; }
    }

    public partial class SftpFolderPattern
    {
        /// <summary>
        /// MongoDB ObjectId
        /// </summary>
        [BsonElement("_id")]
        public ObjectId Id { get; set; }

        [BsonElement("descriptor")]
        public string Descriptor { get; set; }

        [BsonElement("fileType")]
        public string FileType { get; set; }

        [BsonElement("regexPatterns")]
        public List<string> RegexPatterns { get; set; }
    }
}
