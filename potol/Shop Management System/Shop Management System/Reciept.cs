/*
 * Created by SharpDevelop.
 * User: mohsi
 * Date: 08/02/2023
 * Time: 10:00 am
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace Shop_Management_System
{
	/// <summary>
	/// Description of Reciept.
	/// </summary>
	public class Reciept
	{
		 public string id { get; set; }
		 
		 public string rDate { get; set; }
		 
		 public string supId { get; set; }
		 
		 public string supName { get; set; }
		 
		 public string remarks { get; set; }
		 
		 public string qty { get; set; }
		 
		 public string amount { get; set; }
		 
		 public string type { get; set; }
		 
		 public string payamount { get; set; }
		 
		  public string discount { get; set; }
		  
		 public string status { get; set; }
		 
		 public List<Products> list = new List<Products>();
		 
		 
		public List<Products> products
   		{
        	get { return list; }
        	set {list = value;}
    	}
		 
	}
	
}
	
	
	
	
