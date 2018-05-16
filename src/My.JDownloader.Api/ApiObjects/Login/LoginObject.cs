﻿namespace My.JDownloader.Api.ApiObjects.Login
{
    public class LoginObject
    {

        [Newtonsoft.Json.JsonProperty(PropertyName = "sessiontoken")]
        public string SessionToken { get; set; }
        [Newtonsoft.Json.JsonProperty(PropertyName = "regaintoken")]
        public string RegainToken { get; set; }
        [Newtonsoft.Json.JsonProperty(PropertyName = "rid")]
        public int RequestId { get; set; }

        [Newtonsoft.Json.JsonIgnore]
        public byte[] ServerEncryptionToken;
        [Newtonsoft.Json.JsonIgnore]
        public byte[] DeviceEncryptionToken;
    }
}