using System.ComponentModel.DataAnnotations;

namespace SqliteDataDemo.Data
{
    public class Airplane
    {

        [Editable(false)]
        public int Id { get; set; }

        public string Type { get; set; }

        public int EngineCount { get; set; }

        public int Reach { get; set; }

        public string HomeAirPort { get; set; }
    }
}
