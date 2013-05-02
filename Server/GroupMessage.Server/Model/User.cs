﻿using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace GroupMessage.Server.Model
{
    public enum DeviceOs
    {
        NotSet = 0,
        Android = 1,
        iOS = 2,
        WindowsPhone = 3,
        Windows8 = 4
    }

    public class User : EntityBase
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        [BsonRepresentation(BsonType.String)]
        public DeviceOs DeviceOs { get; set; }
        public string DeviceToken { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}