using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_13_WF
{

    public partial class Form1 : Form
    {
		List<Edition> collection = new List<Edition>();
		private void fill_tabel(DataGridView tabel, List<Edition> list)
		{
			tabel.RowCount = list.Count;
			for (int i = 0; i < tabel.RowCount; i++)
			{
				list[i].Info(tabel.Rows[i]);
			}
		}

		public Form1()
		{
			InitializeComponent();
			try
			{
				string path = @"Catalog.txt";
				string[] all_lines = File.ReadAllLines(path);
				for (int i = 0; i < all_lines.Length; i++)
				{
					string[] current_position = all_lines[i].Split(',');
					if (Convert.ToInt32(current_position[0]) == 1)
					{
						Book book = new Book(current_position[1], current_position[2], current_position[3], Convert.ToInt32(current_position[4]));
						collection.Add(book);
					}
					if (Convert.ToInt32(current_position[0]) == 2)
					{
						Article article = new Article(current_position[1], current_position[2], current_position[3], Convert.ToInt32(current_position[4]), Convert.ToInt32(current_position[5]));
						collection.Add(article);
					}
					if (Convert.ToInt32(current_position[0]) == 3)
					{
						InternetResource source = new InternetResource(current_position[1], current_position[2], current_position[3], current_position[4]);
						collection.Add(source);
					}

				}
				fill_tabel(dataGridView2, collection);
			}

			catch
			{

			}
		}

        private void button2_Click(object sender, EventArgs e)
        {
			string authorname = textBox2.Text;
			try
			{
				List<Edition> search = new List<Edition>();
				foreach (Edition var in collection)
				{
					if (var._snp.Contains(authorname)) search.Add(var);
				}
				fill_tabel(dataGridView2, search);

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}
	}
}
