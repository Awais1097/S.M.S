/*
 * Created by SharpDevelop.
 * User: NASIR
 * Date: 11/15/2022
 * Time: 10:39 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data.SqlClient;

namespace Shop_Management_System
{
	/// <summary>
	/// Description of SQLDataBase.
	/// </summary>
	public class SQLDataBase
	{
		public static SqlConnection connection= new SqlConnection();
		
		public SQLDataBase()
		{
			//connection.ConnectionString = "data source  = AWAISPC\MSSQLSERVER01;database = AccountManagement;integrated security = true";
		}
		
		public static SqlConnection conOpen()
		{
			//SqlConnection cs = new SqlConnection(@"Data Source=(IP Address)\SQLEXPRESS,1433;Network Library=DBMSSOCN;Initial Catalog=dbase;User ID=sa;Password=password");
			connection.ConnectionString = "data source  = DESKTOP-DAVEUPR\\SQLEXPRESS; database = ShopDataBase; integrated security = true";
			connection.Open();
			return connection;
		}
		
		public static void conClose(){
			connection.Close();
		}
		
		public static SqlConnection getConnection(){
			return connection;
		}
		
	}
	
}


/*
 
 var localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;

// Create a simple setting

localSettings.Values["exampleSetting"] = "Hello Windows";

// Read data from a simple setting

Object value = localSettings.Values["exampleSetting"];


 */