using System.Collections.Generic; 
namespace Library.Classes{ 

    public class Root
    {
        public Coord coord { get; set; }
        public List<Weather> weather { get; set; }
        public string @base { get; set; }
        public Main main { get; set; }
        public float visibility { get; set; }
        public Wind wind { get; set; }
        public Clouds clouds { get; set; }
        public float dt { get; set; }
        public Sys sys { get; set; }
        public float timezone { get; set; }
        public float id { get; set; }
        public string name { get; set; }
        public float cod { get; set; }
    }

}