﻿// Generated by Xamasoft JSON Class Generator
// http://www.xamasoft.com/json-class-generator

using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using DomDeMaioHomePage.Models.AutoGenerated.JsonResumeJsonTypes;

namespace DomDeMaioHomePage.Models.AutoGenerated.JsonResumeJsonTypes
{

    public class College
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("graduationDate")]
        public string GraduationDate { get; set; }

        [JsonProperty("degree")]
        public string Degree { get; set; }

        [JsonProperty("major")]
        public string Major { get; set; }

        [JsonProperty("minor")]
        public string Minor { get; set; }

        [JsonProperty("gpa")]
        public Gpa Gpa { get; set; }
    }

}
