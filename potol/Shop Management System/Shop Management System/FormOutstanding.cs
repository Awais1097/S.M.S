/*
 * Created by SharpDevelop.
 * User: mohsi
 * Date: 11/02/2023
 * Time: 3:59 pm
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Shop_Management_System
{
	/// <summary>
	/// Description of FormOutstanding.
	/// </summary>
	public partial class FormOutstanding : Form
	{
		Boolean isAllow = true;
		
		public FormOutstanding()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			cusList();
		}
		
		void FormOutstandingLoad(object sender, EventArgs e)
		{
			
		}
		
		void TextBoxsupidTextChanged(object sender, EventArgs e)
		{
			if(isAllow){
				try{
					isAllow  = false;
				SQLDataBase.conOpen();
				SqlCommand get = new SqlCommand("SELECT  CustomersName  FROM Customers Where CustomersId ='"+textBoxsupid.Text+"' ",SQLDataBase.connection);
				SqlDataReader rdr = get.ExecuteReader();
				if(rdr.Read()){
					isAllow = false;
					comboBoxCus.Text = rdr[0].ToString();
				}else{
					//MessageBox.Show("Recoed not founded", "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				SQLDataBase.conClose();
				textBoxsupid.Focus();
				isAllow  = true;
			}catch(Exception){
				SQLDataBase.conClose();
				isAllow  = true;
				//MessageBox.Show("Recoed not founded", "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
			}	
			}			
		}
		
		
		
		void ComboBoxCusSelectedIndexChanged(object sender, EventArgs e)
		{
			if(isAllow){
			try{
					isAllow  = false;
				SQLDataBase.conOpen();
				SqlCommand get = new SqlCommand("SELECT  CustomersId  FROM Customers Where CustomersName ='"+comboBoxCus.Text+"' ",SQLDataBase.connection);
				SqlDataReader rdr = get.ExecuteReader();
				if(rdr.Read()){
					textBoxsupid.Text = rdr[0].ToString();
				}else{
					//MessageBox.Show("Recoed not founded", "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				SQLDataBase.conClose();
				isAllow  = true;
			}catch(Exception){
				SQLDataBase.conClose();
				isAllow  = true;
				//MessageBox.Show("Recoed not founded", "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			}			
		}
		
		void cusList(){		
			try{
				SQLDataBase.conOpen();
			SqlCommand get = new SqlCommand("SELECT  CustomersName  FROM Customers ORDER BY CustomersName ",SQLDataBase.connection);
			SqlDataReader rdr = get.ExecuteReader();
			while(rdr.Read())
			{
				comboBoxCus.Items.Add(rdr[0].ToString());
			}
			SQLDataBase.conClose();
			}catch(Exception){
			SQLDataBase.conClose();
			}
		}
		
		
		
	}
}
