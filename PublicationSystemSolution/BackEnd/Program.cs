﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Collections;

namespace BackEnd
{
	class Program
	{
		static void Main(string[] args)
		{
			string x = "jack jackson, mack mackson, ";
			var x2 = x.Split(new string[] { ", " }, StringSplitOptions.None);
			foreach (var item in x2)
			{
				Console.WriteLine(item);
			}
		}
	}
}
