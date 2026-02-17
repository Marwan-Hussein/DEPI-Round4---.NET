using System;
namespace Day8.Classes
{
    internal class Book
    {
        string Title { get; set; }
        string Author { get; set; }
        #region ctors
        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }
        public Book(string title) : this(title, "Unknown") { }
        public Book() : this("Unknown", "Unknown") { }
        #endregion

        public override string ToString() { 
            return $"Title: {Title}\t Author: {Author}";
        }
    }
}