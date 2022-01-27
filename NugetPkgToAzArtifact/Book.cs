using System;

namespace NugetPkgToAzArtifact
{
    public class Book
    {
        public string BookName;
        public string Isbn;
        public string Author;

        public Book(string name, string isbn, string author)
        {
            BookName = name;
            Isbn = isbn;
            Author = author;
        }
    }
}
