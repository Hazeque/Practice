using System;
using System.Collections.Generic;
using System.IO;

namespace Practice_13
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				string path = @"Catalog.txt";
				List<Edition> collection = new List<Edition>();
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
				foreach (Edition var in collection)
					var.Info();
				Console.Write("Введите ФИО автора: ");
				string authorname = Console.ReadLine();
				List<Edition> search = new List<Edition>();
				foreach (Edition var in collection)
				{
					if (var._snp.Contains(authorname)) 
						search.Add(var);
				}
				Console.WriteLine("Результат поиска по автору: ");
				foreach (Edition var in search)
					var.Info();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
			Console.ReadLine();

		}
	}
} 


