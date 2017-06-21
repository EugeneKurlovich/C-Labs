using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Windows;
using System.Windows.Forms;

namespace LR8
{
    [Serializable]
    public class Library 
    {
        [AtributeValidation]
       [StringLength(10, MinimumLength = 2)]
        public string bookName { get; set; }

        [Required(ErrorMessage = "Неверное количество страниц")]
        [Range(1, 90)]
        public int pages { get; set; }

        [Required]
        [StringLength(15, MinimumLength = 3)]
        public string publishingHouse{ get; set; }

        [Required(ErrorMessage = "Недопустимый год выпуска")]
        [Range(1, 2017)]
        public int year { get; set; }

        [Required]
        public string electronicVersion { get; set; }

        [Required]
        public   string date { get; set; }

        Author author = new Author();

        public static List<Library> allBook = new List<Library>();

        public Library ()
        {

        }


        public string BN
        {
            get
            {
                return bookName;
            }
        }
        public int P
        {
            get
            {
                return pages;
            }
        }
        public string PH
        {
            get { return publishingHouse; }
        }
        public int Y
        {
            get { return year; }
        }
        public string EV
        {
            get
            {
                return electronicVersion;
            }
        }
        public string D
        {
            get { return date; }
        }
        public string AN
        {
            get
            {
                return author.Name;
            }
        }
        public string AS
        {
            get
            {
                return author.Surname;
            }
        }
        public int AYO
        {
            get
            {
                return author.YO;
            }
        }



        public void Set(string bN, int p, string pH, int y, string CD, string DVD, string d, string N, string S, int yO)
        {
            bookName = bN;
            pages = p;
            publishingHouse = pH;
            year = y;
            electronicVersion = CD + " " + DVD;
            date = d;
            author.Name = N;
            author.Surname = S;
            author.YO = yO;
        }

        public void addBook(Library obj)
        {
            allBook.Add(obj);
        }

        public List<Library> GiveBook()
        {
            return allBook;
        }
    }
}
