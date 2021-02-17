using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    abstract class Book
    {
        // Fields
        protected string _title;
        protected string[] _authors;
        protected int _numberOfPages;
        protected double _price;

        // Constructor 1 
        public Book(string title, double price)
        {
            _title = title;
            _price = price;
        }

        // Constructor 2 
        public Book(string title, string[] authors, int numberOfPages, double price)
        {
            _title = title;
            _authors = authors;
            _numberOfPages = numberOfPages;
            _price = price;
        }

        // Title property
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        // Authors property
        public string[] Authors
        {
            get { return _authors; }
            set { _authors = value; }
        }

        // Number of pages property
        public int NumberOfPages
        {
            get { return _numberOfPages; }
            set { _numberOfPages = value; }
        }

        // Price property
        public double Price
        {
            get { return _price; }
            set {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("price", "The price must be a positive number");
                }
                else
                {
                    _price = value;
                }
            }
        }

        // Method displays book title, authors, number of pages, and price
        public virtual string BookPrint()
        {
            string display =
                "Title: " + _title + "\n" +
                "Author(s): " + String.Join(", ", _authors) + "\n" +
                "Number of Pages: " + _numberOfPages.ToString() + "\n" +
                "Price: " + _price.ToString("c");

            return display;
        }
    }
}
