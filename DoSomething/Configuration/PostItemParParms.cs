using System.Collections.Generic;
using System.Runtime.Serialization;


namespace DoSomething.Configuration {
    [DataContract]
    public class PostItemParParms {
        [DataMember]
        public string Database { get; set; }

        [DataMember]
        public string Datasource { get; set; }

        [DataMember]
        public string Username { get; set; }

        [DataMember]
        public string Password { get; set; }

        [DataMember]
        public string Encoding { get; set; }

        [DataMember]
        public List<string> EncodingList { get; set; }

        [DataMember]
        public Dictionary<string, string> HostList { get; set; }

        [DataMember]
        public List<int> ParamList { get; set; }
    }
}
