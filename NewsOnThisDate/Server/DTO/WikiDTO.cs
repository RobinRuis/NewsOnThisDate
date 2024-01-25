using NewsOnThisDate.Models;

namespace NewsOnThisDate.DTO
{
    public class WikiDTO
    {
        public List<Selected> Selected { get; set; }
        public List<Birth> Births { get; set; }
        public List<Death> Deaths { get; set; }
        public List<Event> Events { get; set; }
        public List<Holiday> Holidays { get; set; }
    }
    
    public class Selected
    {
        public string Text { get; set; }
        public List<Page> Pages { get; set; }
        public int Year { get; set; }
    }


    public class Birth
    {
        public string Text { get; set; }
        public List<Page> Pages { get; set; }
        public int Year { get; set; }
    }

    public class Death
    {
        public string Text { get; set; }
        public List<Page> Pages { get; set; }
        public int Year { get; set; }
    }

    public class Event
    {
        public string Text { get; set; }
        public List<Page> Pages { get; set; }
        public int Year { get; set; }
    }


    public class Holiday
    {
        public string Text { get; set; }
        public List<Page> Pages { get; set; }
    }

    public class Page
    {
        public int Pageid { get; set; }
        public string Lang { get; set; }
        public string Description { get; set; }
        public Content_Urls Content_urls { get; set; }
        public string Extract { get; set; }
        public string Normalizedtitle { get; set; }
        public Thumbnail Thumbnail { get; set; }
        public Originalimage Originalimage { get; set; }
    }

    public class Content_Urls
    {
        public Desktop Desktop { get; set; }
    }

    public class Desktop
    {
        public string Page { get; set; }
    }

    public class Thumbnail
    {
        public string Source { get; set; }
    }

    public class Originalimage
    {
        public string Source { get; set; }
    }
}
