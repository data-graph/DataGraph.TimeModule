namespace DataGraph.TimeModule
{
    public class Date
    {

        // Properties

        public int? Day { get; set; }
        public int? Month { get; set; }
        public long? Year { get; set; }

        // Constructors

        public Date() { }

        public Date(int? day, int? month, long? year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

    }
}