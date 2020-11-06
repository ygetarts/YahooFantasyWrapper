using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;

namespace YahooFantasyWrapper.Models
{
    [Serializable]
    public class UserInfo
    {
        [JsonProperty("sub")]
        public string Sub { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("given_name")]
        public string GivenName { get; set; }
        [JsonProperty("family_name")]
        public string FamilyName { get; set; }
        [JsonProperty("locale")]
        public string Locale { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("birthdate")]
        public string BirthDate { get; set; }
        [JsonProperty("nickname")]
        public string NickName { get; set; }
        [JsonProperty("profile_images")]
        public Image Images { get; set; }
    }
      
    [Serializable]
    public class Image
    {
        [JsonProperty("image32")]
        public string Image32 { get; set; }

        [JsonProperty("image64")]
        public string Image64 { get; set; }

        [JsonProperty("image128")]
        public string Image128 { get; set; }

        [JsonProperty("image192")]
        public string Image192 { get; set; }
    }

}
