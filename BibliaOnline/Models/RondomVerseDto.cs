namespace BibliaOnline.Models;
public class RondomVerseDto
    {
        public Book? Book { get; set; }
        public long Chapter { get; set; }
        public long Number { get; set; }
        public string? Text { get; set; }
        
        public Abbrev? Abbrev { get; set; }
    }


 

