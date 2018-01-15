namespace DockerTest.Models
{
    public class CardsModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int ManaCost { get; set; }
        public int? Attack { get; set; }
        public int? Health { get; set; }
        public string Rarity { get; set; }
        public string SetName { get; set; }
    }
}

