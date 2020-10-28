namespace Biblioteket
{
    class Fantasy : Book
    {
        public override string ToString()
        {
            return "Fantasi" + Title + " " + Writer + " " + YearofPublication;
        }

        public Fantasy(string Title, string Writer, int YearofPublication) : base(Title, Writer, YearofPublication)
        {

        }
    }
}