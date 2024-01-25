namespace NewsOnThisDate.Services
{
    public class WikiDataService
    {
        public (string, string) GetData(int? month, int? day)
        {
            if (month == null && day == null)
            {
                month = DateTime.Now.Month;
                day = DateTime.Now.Day;
            }

            return (month.Value.ToString("D2"), day.Value.ToString("D2"));
        }
    }
}