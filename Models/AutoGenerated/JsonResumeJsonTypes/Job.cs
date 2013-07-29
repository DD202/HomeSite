﻿// Generated by Xamasoft JSON Class Generator
// http://www.xamasoft.com/json-class-generator

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using DomDeMaioHomePage.Models.AutoGenerated.JsonResumeJsonTypes;

namespace DomDeMaioHomePage.Models.AutoGenerated.JsonResumeJsonTypes
{

    public class Job
    {

        [JsonProperty("jobTitle")]
        public string JobTitle { get; set; }

        [JsonProperty("address")]
        public Address2 Address { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        [JsonProperty("keyContributions")]
        public KeyContribution[] KeyContributions { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

}