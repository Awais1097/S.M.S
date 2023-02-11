/*
 * Created by SharpDevelop.
 * User: mohsi
 * Date: 11/02/2023
 * Time: 11:00 am
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
	/// Description of FormSearch.
	/// </summary>
	public partial class FormSearch : Form
	{
		string selectedId  = "0";
		public FormSearch()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			switch(comboBox1.Text){
				case "Products":
					searchProdcuts(textBox1.Text);
					break;
				case "Customers":
					searchCustomers(textBox1.Text);
					break;
				case "Suppliers":
					searchSupplier(textBox1.Text);
					break;
				case "Brands":
					searchBrands(textBox1.Text);
					break;
				case "Companies":
					searchCompany(textBox1.Text);
					break;
				case "Categories":
					searchCategory(textBox1.Text);
					break;
				case "Racks":
					searchRacks(textBox1.Text);
					break;
				case "Orders":
					searchOrdersReciept(textBox1.Text,Utilites.ORDER);
					break;
				case "Reciepts":
					searchOrdersReciept(textBox1.Text,Utilites.RECIEPT);
					break;
			}
		}
		
		
		void searchProdcuts(string s){
			try{
				SQLDataBase.conOpen();
				SqlCommand get = new SqlCommand("select _id,productid,productname,unitsize,unitprice,compname from product where productid Like '%"+s+"%' OR productname Like '%"+s+"%' OR unitsize Like '%"+s+"%' OR unitprice Like '%"+s+"%' OR compname Like '%"+s+"%' ORDER BY _id DESC",SQLDataBase.connection);
				SqlDataAdapter da = new SqlDataAdapter(get);
				DataTable dt = new DataTable();
				da.Fill(dt);
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
		
		void searchCustomers(string s){
			try{
				SQLDataBase.conOpen();
				SqlCommand get = new SqlCommand("SELECT * from Customers where CustomersId Like '%"+s+"%' OR CustomersName Like '%"+s+"%' OR CustomersPhoneNumber Like '%"+s+"%' OR CustomersMobileNumber Like '%"+s+"%' OR CustomersAddress Like '%"+s+"%' ORDER BY _id DESC",SQLDataBase.connection);
				SqlDataAdapter da = new SqlDataAdapter(get);
				DataTable dt = new DataTable();
				da.Fill(dt);
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
		
		void searchSupplier(string s){
			try{
				SQLDataBase.conOpen();
				SqlCommand get = new SqlCommand("SELECT * from Suppliers where SupplierId Like '%"+s+"%' OR SupplierName Like '%"+s+"%' OR SupplierPhoneNumber Like '%"+s+"%' OR SupplierMobileNumber Like '%"+s+"%' OR SupplierAddress Like '%"+s+"%' ORDER BY _id DESC",SQLDataBase.connection);
				SqlDataAdapter da = new SqlDataAdapter(get);
				DataTable dt = new DataTable();
				da.Fill(dt);
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
		
		
		
		void searchCompany(string s){
			try{
				SQLDataBase.conOpen();
				SqlCommand get = new SqlCommand("SELECT * from Company where CompanyId Like '%"+s+"%' OR CompanyName Like '%"+s+"%' OR CompanyPhoneNumber Like '%"+s+"%' OR CompanyMobileNumber Like '%"+s+"%' OR CompanyAddress Like '%"+s+"%' ORDER BY _id DESC",SQLDataBase.connection);
				SqlDataAdapter da = new SqlDataAdapter(get);
				DataTable dt = new DataTable();
				da.Fill(dt);
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
		
		
		void searchBrands(string s){
			try{
				SQLDataBase.conOpen();
				SqlCommand get = new SqlCommand("SELECT * from Brands where BrandId Like '%"+s+"%' OR BrandName Like '%"+s+"%' ORDER BY _id DESC",SQLDataBase.connection);
				SqlDataAdapter da = new SqlDataAdapter(get);
				DataTable dt = new DataTable();
				da.Fill(dt);
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
		
		
		void searchCategory(string s){
			try{
				SQLDataBase.conOpen();
				SqlCommand get = new SqlCommand("SELECT * from Category where CategoryName Like '%"+s+"%' OR CategoryId Like '%"+s+"%' ORDER BY _id DESC",SQLDataBase.connection);
				SqlDataAdapter da = new SqlDataAdapter(get);
				DataTable dt = new DataTable();
				da.Fill(dt);
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
		
		
		void searchRacks(string s){
			try{
				SQLDataBase.conOpen();
				SqlCommand get = new SqlCommand("SELECT * from Racks where RackName Like '%"+s+"%' OR RackId Like '%"+s+"%' ORDER BY _id DESC",SQLDataBase.connection);
				SqlDataAdapter da = new SqlDataAdapter(get);
				DataTable dt = new DataTable();
				da.Fill(dt);
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
		
		void searchOrdersReciept(string s,String type){
			try{
				SQLDataBase.conOpen();
				SqlCommand get = new SqlCommand("select * from receipt_main where date Like '%"+s+"%' OR supid Like '%"+s+"%' OR supname Like '%"+s+"%' OR remarks Like '%"+s+"%' OR qtys Like '%"+s+"%' OR price Like '%"+s+"%' OR mTime Like '%"+s+"%' OR payAmount Like '%"+s+"%' OR discount Like '%"+s+"%' OR status Like '%"+s+"%'  AND type = '"+type+"' ORDER BY _id DESC",SQLDataBase.connection);
				SqlDataAdapter da = new SqlDataAdapter(get);
				DataTable dt = new DataTable();
				da.Fill(dt);
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
		
		
		
		void ComboBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			switch(comboBox1.Text){
				case "Products":
					searchProdcuts(textBox1.Text);
					break;
				case "Customers":
					searchCustomers(textBox1.Text);
					break;
				case "Suppliers":
					searchSupplier(textBox1.Text);
					break;
				case "Brands":
					searchBrands(textBox1.Text);
					break;
				case "Companies":
					searchCompany(textBox1.Text);
					break;
				case "Categories":
					searchCategory(textBox1.Text);
					break;
				case "Racks":
					searchRacks(textBox1.Text);
					break;
				case "Orders":
					searchOrdersReciept(textBox1.Text,Utilites.ORDER);
					break;
				case "Reciepts":
					searchOrdersReciept(textBox1.Text,Utilites.RECIEPT);
					break;
			}			
		}
		
		void PictureBox3Click(object sender, EventArgs e)
		{
			dataGridView1.Rows.Clear();
		}
		
		void PictureBox2Click(object sender, EventArgs e)
		{
			string data = "";
			for (var i = 0; i < dataGridView1.ColumnCount; i++)
			{
				data  = data + dataGridView1.Columns[i].HeaderText + ",";
			}
			data  = data +  "\n";	
			foreach(DataGridViewRow row in dataGridView1.Rows){
				for (var i = 0; i < dataGridView1.ColumnCount; i++)
				{
					data  = data + row.Cells[i].Value.ToString()+ ",";
				}
				data  = data +  "\n";	
			}			
			Boolean msg = Utilites.save(comboBox1.Text+"-"+DateTime.Now.ToString("yyyy-MM-dd")+".csv",data);
			if(msg == false){
				MessageBox.Show("File not saved. Try again","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if(comboBox1.Text == "Orders" || comboBox1.Text == "Reciepts"){
				try{
					DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
					selectedId = row.Cells[0].Value.ToString();
					printPreviewDialog1.Document =  printDocument1;
					printPreviewDialog1.ShowDialog();	
				}catch(Exception){
				}	
			}
		}
		
		
		void PrintDocument1PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			new PrintRepiept(selectedId,e);
		}
		
	}
	
}
