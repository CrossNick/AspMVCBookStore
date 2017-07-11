using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BookStore.Models
{
	public class BookContext : DbContext
	{
		public DbSet<Book> Books { set; get; }
		public DbSet<Purchase> Purchases { get; set; }

	}
}