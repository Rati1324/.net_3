﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw12
{
	public class User
	{
		private string id;
		public string FirstName;
		public string LastName;
		private string personalNumber;
		private DateTime? birthDate;
		private int genderID;
		private string phoneNumber;
		private string eMail;
		private int roleID;
		
		public User(string id, string FirstName, string LastName, string personalNumber, DateTime? birthDate, 
			int genderID, string phoneNumber, string eMail, int roleID)
		{
			this.id = id; this.FirstName = FirstName; this.LastName = LastName;
			this.personalNumber = personalNumber; this.birthDate = birthDate;
			this.genderID = genderID; this.phoneNumber = phoneNumber;
			this.eMail = eMail; this.roleID = roleID;
		}
		
		public void Update()
		{
			try
			{
				string query = $"UPDATE Users SET FirstName = '{this.FirstName}' WHERE ID = {this.id}";
			}
			catch (Exception)
			{

				throw;
			}
		}

		public void insert()
		{
			string query = $"INSERT INTO Users VALUES({this.id}, '{this.LastName}', '{this.FirstName}', " +
				$"'{this.birthDate.Value.ToString("dd.MM.yyyy")}', {this.genderID}, '{this.phoneNumber}', '{this.eMail}', {this.roleID})";
			using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["edu"].ConnectionString))
			{
				using (SqlCommand com = new SqlCommand(query, conn))
				{
					conn.Open();
					try
					{
						com.ExecuteNonQuery();
					}
					catch (Exception ex)
					{
						throw new Exception($"error {ex}");
					}
				}
			}

		}
	}
}
