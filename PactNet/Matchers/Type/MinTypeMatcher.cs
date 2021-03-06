﻿using Newtonsoft.Json;

namespace PactNet.Matchers.Type
{
    public class MinTypeMatcher : IMatcher
    {
        //Generate JSON using the Ruby spec for now

        [JsonProperty(PropertyName = "json_class")]
        public string Match { get; set; }

        [JsonProperty(PropertyName = "contents")]
        public dynamic Example { get; set; }

        [JsonProperty(PropertyName = "min")]
        public int Min { get; set; }

        internal MinTypeMatcher(dynamic example, int min)
        {
            Match = "Pact::ArrayLike";
            Example = example;
            Min = min;
        }
    }
}