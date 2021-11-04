using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace classwork
{
	class Program
	{
		static void Main(string[] args)
		{
			#region create author
			try
			{
				Author a = new Author();
				a.F_name = "jack";
				a.L_name = "jackson";
				a.Dob = new DateTime(1988, 2, 1);

				List<Book> Books = new List<Book>();
				Books.Add(new Book()
				{
					Name = "book1",
					Publisher = 3,
					ISBN = "11",
				}); 
				Books.Add(new Book()
				{
					Name = "book2",
					Publisher = 3,
					ISBN = "12",
				});
				Books.Add(new Book()
				{
					Name = "book3",
					Publisher = 3,
					ISBN = "13",
				});
				a.Books = Books;
				string queryAuthor = "INSERT INTO author OUTPUT INSERTED.id VALUES(@F_name, @L_name, @Dob)";
				string queryBook = "INSERT INTO book OUTPUT INSERTED.id VALUES(@Name, @Publisher, @ISBN)";
				string queryBookAuthor = "INSERT INTO book_author VALUES(@Author_id, @Book_id)";

				using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString))
				{
					conn.Open();
					using (SqlTransaction tran = conn.BeginTransaction())
					{
						try
						{
							SqlCommand comAuthor = new SqlCommand(queryAuthor, conn, tran);
							comAuthor.Parameters.AddWithValue("@F_name", a.F_name);
							comAuthor.Parameters.AddWithValue("@L_name", a.L_name);
							comAuthor.Parameters.AddWithValue("@Dob", a.Dob.ToString("yyyy-MM-dd"));

							int authorId = (int)comAuthor.ExecuteScalar();
							foreach (Book book in a.Books)
							{
								SqlCommand comBook = new SqlCommand(queryBook, conn, tran);
								comBook.Parameters.AddWithValue("@Name", book.Name);
								comBook.Parameters.AddWithValue("@Publisher", book.Publisher);
								comBook.Parameters.AddWithValue("@ISBN", book.ISBN);

								int bookId = (int)comBook.ExecuteScalar();
								SqlCommand comBookAuthor = new SqlCommand(queryBookAuthor, conn, tran);
								comBookAuthor.Parameters.AddWithValue("@Author_id", authorId);
								comBookAuthor.Parameters.AddWithValue("@Book_id", bookId);
								comBookAuthor.ExecuteNonQuery();
							}
							tran.Commit();
						}
						catch (SqlException se)
						{
							tran.Rollback();
							throw new Exception(se.Message);
						}
						catch (Exception ex)
						{
							throw new Exception(ex.Message);
						}
					}
				}
			}
			catch (Exception)
			{
				throw;
			}
			#endregion
		}
	}
}
