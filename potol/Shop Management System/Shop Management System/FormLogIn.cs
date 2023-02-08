/*
 * Created by SharpDevelop.
 * User: NASIR
 * Date: 11/15/2022
 * Time: 7:18 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Shop_Management_System
{
	/// <summary>
	/// Description of FormLogIn.
	/// </summary>
	public partial class FormLogIn : Form
	{
		int uId;

		public FormLogIn()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			
		}
		void Label6Click(object sender, EventArgs e)
		{
			
		}
		void ButtonExitClick(object sender, EventArgs e)
		{
			login();			
		}
		void Button2Click(object sender, EventArgs e)
		{
			Application.Exit();	
		}
		
		private void login(){
			if(textBoxName.Text.Trim() == string.Empty){
				MessageBox.Show("User Name required" , "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			   }
			if(textBoxPassword.Text.Trim() == string.Empty){
				MessageBox.Show("User Password required" , "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			   }
			SQLDataBase.conOpen();
			SqlCommand cmd =new SqlCommand( "select * from UserShopTable where username ='" + textBoxName.Text + "'and password = '" + textBoxPassword.Text + "'",SQLDataBase.connection);
			
			int cont = 0;
			SqlDataReader rdr = cmd.ExecuteReader();
			while(rdr.Read())
			{
				uId =  int.Parse(rdr[0].ToString());
				cont = cont + 1;
			}
			if(cont == 1)
			{
				SQLDataBase.conClose();
				//MessageBox.Show("User Name & Password is correct ","Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
					
				Form df = new MainForm();
				this.Hide();
				df.Show();

			}
			else
			{
				SQLDataBase.conClose();
				MessageBox.Show("User Name & Password is not correct ","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				textBoxName.Clear();
				textBoxPassword.Clear();
				textBoxName.Focus();
				
				return ;
				
			}
		
		}
	
	}
}
