using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelFirst {
	class Program {
		static Model1Container x = new Model1Container();
		public static void select() {
			var data = (from e in x.Employees
						where e.city1.name.Equals("Boston")
						select e.name).ToList();

			foreach (var item in data) {
				Console.WriteLine(item);
			}
		}

		public static void insert() {

		}
		static void Main(string[] args) {
			select();
		}
	}
}
