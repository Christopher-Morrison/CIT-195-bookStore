using System;

namespace bookStore
{
    class book
    {
        private int _Id;
        private string _Title;
        private string _Author;

        public book() {
            _Id = 0;
            _Title = "";
            _Author = "";
        }
        public book(int id, string title, string author)
        {
            _Id = id;
            _Title = title;
            _Author = author;
        }
        public int getId()
        { return _Id; }
        public void setId(int value)
        { _Id = value; }
        public string getTitle() 
        { return _Title; }
        public void setTitle(string value)
        { _Title = value; }
        public string getAuthor()
        { return _Author; }
        public void setAuthor(string value)
        { _Author = value; }

    }
    class myStore
    {
        static void Main(string[] args)
        {
            book book1 = new book();
            book1.setId(1);
            book1.setTitle("Calculus 9th Edition");
            book1.setAuthor("James Stewart");

            book book2 = new book();
            Console.WriteLine("Please enter the book Id");
            book2.setId(int.Parse(Console.ReadLine()));
            Console.WriteLine("Please enter the book Title");
            book2.setTitle(Console.ReadLine());
            Console.WriteLine("Please enter the book Author");
            book2.setAuthor(Console.ReadLine());

            book book3 = new book(3,"How to train your Dragon", "Hiccup Horrendous");

            
            Console.WriteLine("Please enter the Id of the book");
            int tempID = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the name of the book");
            string tempTitle = Console.ReadLine();
            Console.WriteLine("Please enter the name of the book");
            string tempAuthor = Console.ReadLine();
            book book4 = new book(tempID, tempTitle, tempAuthor);

            displayBooks(book1);
            displayBooks(book2);
            displayBooks(book3);
            displayBooks(book4);

        }
        static void displayBooks(book bookObject)
        {
            Console.WriteLine("Here is your Book information.");
            Console.WriteLine($"Book Id: {bookObject.getId()}");
            Console.WriteLine($"Book Title: {bookObject.getTitle()}");
            Console.WriteLine($"Book Author: {bookObject.getAuthor()}");

        }
    }
}




/*        public int Id
        {
            get
            {
                return _Id;
            }
            set
            { _Id = value; }
        }
        public string Title
        {
            get
            {
                return _Title;
            }
            set
            { _Title = value; }
        }
        public string Author
        {
            get
            {
                return _Author;
            }
            set
            { _Author = value; }
        }*/