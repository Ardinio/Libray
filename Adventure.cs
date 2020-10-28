namespace Biblioteket
{
    class Adventure : Book
    {
        public override string ToString()
        {
            return "Äventur" + Title + " " + Writer + " " + YearofPublication;
        }

        public Adventure(string Title, string Writer, int YearofPublication) : base(Title, Writer, YearofPublication)
        {

        }
    }
}