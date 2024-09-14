
namespace BibliaOnline.Models;

    public class DetailsCapModel
    {
        public Book Book { get; set; }
        public Chapter Chapter { get; set; }
        public List<Verse> Verses { get; set; }
        public Abbrev Abbrev { get; set; }  
    }

    public partial class Book
    {
        public Abbrev Abbrev { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Group { get; set; }
        public string Version { get; set; }
    }

    public partial class Chapter
    {
        public long Number { get; set; }
        public long Verses { get; set; }
    }

    public partial class Verse
    {
        public long Number { get; set; }
        public string Text { get; set; }

    }

 