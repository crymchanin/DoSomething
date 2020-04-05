using System.Runtime.Serialization;


namespace DoSomething.Configuration {
    [DataContract]
    public class Global {

        [DataMember]
        public PlaceInfoParms PlaceInfoParms { get; set; }

        [DataMember]
        public PostItemParParms PostItemParParms { get; set; }
    }
}
