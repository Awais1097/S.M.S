/*
 * Created by SharpDevelop.
 * User: Dell
 * Date: 2/12/2023
 * Time: 5:01 AM
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
	/// Description of FormAddPayment.
	/// </summary>
	public partial class FormAddPayment : Form
	{
		string rid;
		string csnm;
		double outstanding = 0.0;
		
		public FormAddPayment(string i,string sc, double r)
		{
			rid = i;
			csnm = sc;
			outstanding = r;
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			textBox1.Text = rid.ToString();
			textBox2.Text = csnm;
			textBox3.Text = outstanding.ToString();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void TextBox4TextChanged(object sender, EventArgs e)
		{
			try{
					double pay = double.Parse(textBox4.Text.ToString());
					if(pay > outstanding){
						MessageBox.Show("Wrong Payment","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);				
					}
			}catch(Exception){
			}
		}
		
		
		
		void ButtonSaveClick(object sender, EventArgs e)
		{
			if(textBox4.Text.Trim() ==String.Empty){
				MessageBox.Show("Wrong Payment","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			
			try{
				double pay = double.Parse(textBox4.Text.ToString());
				string query = "INSERT INTO CustomerPays (_id, payDate, payAmount, outId,remarks) VALUES (@_id, @payDate, @payAmount, @outId, @remarks)";  
          		SqlCommand cmd = new SqlCommand(query, SQLDataBase.connection); 
          		cmd.Parameters.AddWithValue("@_id", DateTime.Now.ToString());
				cmd.Parameters.AddWithValue("@payDate", dateTimePicker1.Text);
          		cmd.Parameters.AddWithValue("@payAmount", pay); 
				cmd.Parameters.AddWithValue("@outId", rid); 
				cmd.Parameters.AddWithValue("@remarks", textBoxremarks.Text);			
  				SQLDataBase.conOpen();
            	cmd.ExecuteScalar();  
            	SQLDataBase.conClose(); 
				buttonSave.Enabled = false; 
				MessageBox.Show("Saved Successfully","Save", MessageBoxButtons.OK, MessageBoxIcon.Information);				
			}catch(Exception){
				MessageBox.Show("Wrong Payment","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		
		
		void PrintDocument1PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			PrintPayment p = new PrintPayment(textBox1.Text.ToString(),e);
		}
		
		void Button5Click(object sender, EventArgs e)
		{
				printPreviewDialog1.Document =  printDocument1;
			printPreviewDialog1.ShowDialog();						
		}
	}
}
