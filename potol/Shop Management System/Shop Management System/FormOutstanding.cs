/*
 * Created by SharpDevelop.
 * User: mohsi
 * Date: 11/02/2023
 * Time: 3:59 pm
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
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
		string oId= "0";
		string cname = "";
		double r =0.0;
		DataTable dt;
		
		public FormOutstanding(string type)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			comboBox1.Text = type;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			cusList();
			searchData();
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
		
		void searchData(){
		try{
				string q = "select * from ViewOutStanding";
				bool w=false; 
				if(textBoxsupid.Text.Trim() != String.Empty){
					if(w == false){
						q = q + " Where ";
					}
					q = q + " AND CusId = '"+textBoxsupid.Text+"'";
				}
				if(comboBox1.Text.ToString().ToUpper() != "ALL"){
					if(w == false){
						q = q + " Where ";
					}
					q = q + " AND OutStanding > 0";
				}
				q = q + " Order By OutStanding DESC";
				SQLDataBase.conOpen();
				SqlCommand get = new SqlCommand(q,SQLDataBase.connection);
				SqlDataAdapter da = new SqlDataAdapter(get);
				dt = new DataTable();
				da.Fill(dt);
				dataGridView3.DataSource = null;
				var bindingSource = new BindingSource();
				bindingSource.DataSource = dt;
				dataGridView3.Rows.Clear();
				dataGridView3.ReadOnly = true;
            	dataGridView3.DataSource = bindingSource;
				SQLDataBase.conClose();
			}catch(Exception){
				SQLDataBase.conClose();
			}
		
		}
		
		
		void DataGridView3CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try{
				DataGridViewRow row = dataGridView3.Rows[e.RowIndex];
				oId = row.Cells[0].Value.ToString();
				textBox1.Text = row.Cells[0].Value.ToString();
				textBox2.Text = row.Cells[6].Value.ToString();
				textBox3.Text = row.Cells[3].Value.ToString();
				cname = row.Cells[3].Value.ToString();
				r =  double.Parse(row.Cells[6].Value.ToString());
				string q = "select * from CustomerPays where outid = '"+oId+"'";
				SQLDataBase.conOpen();
				SqlCommand get = new SqlCommand(q,SQLDataBase.connection);
				SqlDataAdapter da = new SqlDataAdapter(get);
				DataTable dt = new DataTable();
				da.Fill(dt);
				dataGridView1.DataSource = null;
				var bindingSource = new BindingSource();
				bindingSource.DataSource = dt;
				dataGridView1.Rows.Clear();
				dataGridView1.ReadOnly = true;
            	dataGridView1.DataSource = bindingSource;
            	SQLDataBase.conClose();
			}catch(Exception){
				SQLDataBase.conClose();
			}			
		}
	
	
		
		void Button3Click(object sender, EventArgs e)
		{
			Form racForm = new FormAddPayment(textBox1.Text,textBox3.Text,r);
			racForm.ShowDialog();			
		}
		
		
		
		void PrintDocument1PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			new PrintPayment(textBox1.Text,e);
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			printPreviewDialog1.Document =  printDocument1;
			printPreviewDialog1.ShowDialog();			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			string data = "";	
				for (int i = 0; i < dt.Columns.Count; i++)
				{
				data  = data + dt.Columns[i].Caption+ ",";
				}
				data  = data +  "\n";	
			foreach(System.Data.DataRow row in dt.Rows){
				for (int i = 0; i < dt.Columns.Count; i++)
				{
					data  = data + row.ItemArray[i].ToString()+ ",";
				}
				data  = data +  "\n";	
			}			
			Boolean msg = Utilites.save("Outstanding"+"-"+DateTime.Now.ToString("yyyy-MM-dd")+".csv",data);
			if(msg == false){
				MessageBox.Show("File not saved. Try again","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}			
		}
		
		
	}
}
