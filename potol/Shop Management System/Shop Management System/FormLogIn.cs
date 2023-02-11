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
			// System.IO.File.WriteAllText(@"D:\myfile.txt","Hello this is my File");		
			//Utilites.save("info.csv","Shop Management System\nFor infromation and in case of any problem\nName: Awais ul Hassan\n(Call-WhatsApp-SMS) On: 03066395565\nEmail on: awaisbagga@gmail.com, ");
			Utilites.readEcxalFile();
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
