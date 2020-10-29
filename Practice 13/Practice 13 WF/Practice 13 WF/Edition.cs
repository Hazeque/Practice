using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_13_WF
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
        public virtual void Info(DataGridViewRow row)
        {
            row.Cells["Name"].Value = _name;
            row.Cells["Author"].Value = _snp;
        }

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
        public override void Info(DataGridViewRow row)
        {
            row.Cells["Name"].Value = _name;
            row.Cells["Author"].Value = _snp;
            row.Cells["Publisher"].Value = publisher;
            row.Cells["Publication date"].Value = pubdate;
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
        public override void Info(DataGridViewRow row)
        {
            row.Cells["Name"].Value = _name;
            row.Cells["Author"].Value = _snp;
            row.Cells["Magazine"].Value = magazinename;
            row.Cells["Number"].Value = num;
            row.Cells["Publication date"].Value = pubdate;
        }
    }
    class InternetResource : Edition
    {
        public string link;
        public string annotation;
        public InternetResource(string name, string snp, string _link, string _annotation) : base(name, snp)
        {
            this.link = _link;
            this.annotation = _annotation;
        }
        public override void Info(DataGridViewRow row)
        {
            row.Cells["Name"].Value = _name;
            row.Cells["Author"].Value = _snp;
            row.Cells["Link"].Value = link;
            row.Cells["Annotation"].Value = annotation;
        }
    }
    class Catalog
    {
        public List<Edition> list = new List<Edition>();

        public void Add(Edition edit)
        {
            list.Add(edit);
        }
    }
}
