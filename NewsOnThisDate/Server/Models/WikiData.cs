namespace NewsOnThisDate.Models
{
    public class Rootobject
    {
        public Selected[] selected { get; set; }
        public Birth[] births { get; set; }
        public Death[] deaths { get; set; }
        public Event[] events { get; set; }
        public Holiday[] holidays { get; set; }
    }

    public class Selected
    {
        public string text { get; set; }
        public Page[] pages { get; set; }
        public int year { get; set; }
    }


    public class Birth
    {
        public string text { get; set; }
        public Page[] pages { get; set; }
        public int year { get; set; }
    }

    public class Death
    {
        public string text { get; set; }
        public Page[] pages { get; set; }
        public int year { get; set; }
    }

    public class Event
    {
        public string text { get; set; }
        public Page[] pages { get; set; }
        public int year { get; set; }
    }


    public class Holiday
    {
        public string text { get; set; }
        public Page[] pages { get; set; }
    }

    public class Page
    {
        public int pageid { get; set; }
        public string lang { get; set; }
        public string description { get; set; }
        public Content_Urls content_urls { get; set; }
        public string extract { get; set; }
        public string normalizedtitle { get; set; }
        public Thumbnail thumbnail { get; set; }
        public Originalimage originalimage { get; set; }
    }

    public class Content_Urls
    {
        public Desktop desktop { get; set; }
    }

    public class Desktop
    {
        public string page { get; set; }
    }

    public class Thumbnail
    {
        public string source { get; set; }
    }

    public class Originalimage
    {
        public string source { get; set; }
    }

   
  
}
