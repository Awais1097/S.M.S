/*
 * Created by SharpDevelop.
 * User: Dell
 * Date: 2/4/2023
 * Time: 7:52 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Shop_Management_System
{
	/// <summary>
	/// Description of Category.
	/// </summary>
	public class Category
	{
		string id;
		string name;
		public Category(string i, string n)
		{
			id= i;
			name = n;
		}
		
		string getId(){
			return id;
		}
		
		string getName(){
			return name;
		}
	}
}
