namespace AutoTechMed.Models
{
    public class Holiday
    {
        public DateTime Date { get; set; }
        public string LocalName { get; set; }
        public string Name { get; set; }
        public bool Fixed { get; set; }
        public bool Global { get; set; }

        public List<string> Types { get; set; }
    }
}
