using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace Library
{
    public class Book : Form1
    {
        public string name ;
        public int ammountSheet;
        public string publishingHouse;
        public int year;
        public bool disk;
        public string commingDate;
        public Author author = new Author();
     
        public Book()
        {

        }

        public string getNameBook()
        {
            return name;
        }
        public int getAmmountSheets()
        {
            return ammountSheet;
        }
        public string getPublishingHouse()
        {
            return publishingHouse;
        }
        public int getYearBook()
        {
            return year;
        }
        public string getCdOrDvd()
        {
            if (disk == true)
                return "Электронная версия присутствует";
            else
                return "Электронной версии не существует";
        }
        public string getDateComming()
        {
            return commingDate;
        }
   
        public void SetInfo(string a, int b, string c, int d,bool e, string f, string h, string g, int i)
        {
            this.name = a;
            this.ammountSheet = b;
            this.publishingHouse = c;
            this.year = d;
            this.disk = e;
            this.commingDate = f;
            this.author.setData(h,g,i);                  
        }

        public string getNameAuthor()
        {
            return this.author.getName();
        }
        public string getSurnameAuthor()
        {
            return this.author.getSurname();
        }
        public int getYearsOldAuthor()
        {
            return this.author.getYears();
        }


    }
}
