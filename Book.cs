namespace Biblioteket
{
    abstract class Book
    {
        public string Title
        {
            get;
            set;
        }
        public string Writer
        {
            get;
            set;
        }
        public int YearofPublication
        {
            get;
            set;
        }

        public Book(string Title, string Writer, int YearofPublication)
        {
            this.Title = Title;
            this.Writer = Writer;
            this.YearofPublication = YearofPublication;
        }
    }
}