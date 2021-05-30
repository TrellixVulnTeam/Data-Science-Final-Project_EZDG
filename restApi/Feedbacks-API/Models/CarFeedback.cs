﻿using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Feedbacks_API.Models
{
    [BsonIgnoreExtraElements]


    public class CarFeedback:FeedbackBase
    {
        public string LicensePlate { get; set; }
    }
}
