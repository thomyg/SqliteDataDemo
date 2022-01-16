using System.ComponentModel.DataAnnotations;

namespace SqliteDataDemo.Data
{
    public class Ship
    {
        [Editable(false)]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
