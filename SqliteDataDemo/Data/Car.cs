using System.ComponentModel.DataAnnotations;

namespace SqliteDataDemo.Data
{
    public class Car
    {
        [Editable(false)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string PlateNumber { get; set; }
        public DateTime Built { get; set; }
        public string Colour { get; set; }
    }
}
