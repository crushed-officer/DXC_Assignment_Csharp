using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2AssignmentCsharp
{
    class BookStore
    {
        private int isbn;
        private string bookName;
        private string bookTitle;
        private string bookAuthor;
        private int quantityOfBooks;
        private double bookPrice;
        private double totalPrice;

        public int Isbn { get => isbn; set => isbn = value; }
        public string BookName { get => bookName; set => bookName = value; }
        public string BookTitle { get => bookTitle; set => bookTitle = value; }
        public string BookAuthor { get => bookAuthor; set => bookAuthor = value; }
        public int QuantityOfBooks { get => quantityOfBooks; set => quantityOfBooks = value; }
        public double BookPrice { get => bookPrice; set => bookPrice = value; }
        public double TotalPrice { get => totalPrice; set => totalPrice = value; }

        public double CalculatePrice()
        {
            TotalPrice = BookPrice * QuantityOfBooks;
            return TotalPrice;
        }
        public void DisplayDetails()
        {
            Console.WriteLine("\nBook Name : " + bookName + "Book ISBN : " + isbn + "\nBook Title : " + bookTitle + "\nAuthor : " + bookAuthor + "\nBook Price : " + bookPrice);
        }
        public void BillingDetails()
        {
            Console.WriteLine("\nBilling Details\n");
            Console.WriteLine("Book ISBN : " + isbn + "\nBook Name : " + bookName + "\nBook Title : " + bookTitle + "\nAuthor : " + bookAuthor + "\nBook Price : " + bookPrice + "\nQuantity : " + quantityOfBooks + "\nTotal Price : " + totalPrice);

        }
    }
}
