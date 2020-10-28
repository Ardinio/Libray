using System.Collections;

namespace Biblioteket
{
    class Romance : Book
    {
        public override string ToString()
        {
            return "Roman" + Title + " " + Writer + " " + YearofPublication;
        }

        public Romance(string Title, string Writer, int YearofPublication) : base(Title, Writer, YearofPublication)
        {

        }
    }
}