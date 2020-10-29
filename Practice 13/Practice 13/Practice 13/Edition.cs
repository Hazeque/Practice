using System;
using System.Collections.Generic;
using System.Text;

namespace Practice_13
{
    public abstract class Edition
    {
        public string _name;
        public string _snp;


        public Edition(string name, string snp)
        {
            _name = name;
            _snp = snp;
        }
        public abstract void Info();
    }
    class Book : Edition
    {
        public string publisher;
        public int pubdate;
        public Book(string name, string snp, string _publisher, int _pubdate) : base(name, snp)
        {
            this.publisher = _publisher;
            this.pubdate = _pubdate;
        }
        public override void Info()
        {
            Console.WriteLine("Информация : {0},{1},{2},{3}", _name, _snp, publisher, pubdate);
        }
    }
    class Article : Edition
    {
        public string magazinename;
        public int num;
        public int pubdate;
        public Article(string name, string snp, string _magazinename, int _num, int _pubdate) : base(name, snp)
        {
            this.magazinename = _magazinename;
            this.num = _num;
            this.pubdate = _pubdate;
        }
        public override void Info()
        {
            Console.WriteLine("Информация : {0},{1},{2},{3}, {4}", _name, _snp, magazinename, num, pubdate);
        }
    }
    class InternetResource : Edition
    {
        public string link;
        public string annotation;
        public InternetResource (string name, string snp, string _link, string _annotation) : base(name, snp)
        {   
            this.link = _link;
            this.annotation = _annotation;
        }
        public override void Info()
        {
            Console.WriteLine("Информация : {0},{1},{2},{3}", _name, _snp, link, annotation);
        }
    }
    class Catalog
    {
        public List<Edition> list = new List<Edition>();
        public void Add(Edition edit)
        {
            list.Add(edit);

        }
        public void FindEdition(string author)
        {
            foreach (var p in list.FindAll(p => p._snp == author))
                p.Info();
        }
    }
}
