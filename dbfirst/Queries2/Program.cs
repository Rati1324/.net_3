using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queries2 {
	class Program {
		static NWDBEntities db = new NWDBEntities();
		static void selectData() {
			var data = from x in db.Products
					   select x;
			foreach (var item in data) {
				Console.WriteLine(item);
			}
		}
		public static void updateData(string oldName, string newName) {
			var data = from x in db.Categories.ToList()
					   where x.CategoryName == oldName
					   select x;
			data.First().CategoryName = newName;
			db.SaveChanges();
		}

		static void Main(string[] args) {
			updateData("Beverages", "Beverages2");
		
		}
	}
}
