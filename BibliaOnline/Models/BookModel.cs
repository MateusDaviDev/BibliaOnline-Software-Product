namespace BibliaOnline.Models;

public  class BookModel
{
    public Abbrev Abbrev { get; set; }
    public string Author { get; set; }
    public long Chapters { get; set; }
    public string Group { get; set; }
    public string Name { get; set; }
    public string Testament { get; set; }
}

public partial class Abbrev
{
    public string Pt { get; set; }
    public string En { get; set; }
}

