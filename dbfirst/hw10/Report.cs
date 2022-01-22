using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw10 {
	public class Report<T> {
		public string Name { get; set; }
		public List<T> Data { get; set; }
	}
}
