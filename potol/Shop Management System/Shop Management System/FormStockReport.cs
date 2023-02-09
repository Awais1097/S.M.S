/*
 * Created by SharpDevelop.
 * User: Dell
 * Date: 12/18/2022
 * Time: 1:28 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Shop_Management_System
{
	/// <summary>
	/// Description of FormStockReport.
	/// </summary>
	public partial class FormStockReport : Form
	{
		string data;
		public FormStockReport()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			getAll();
		}
	
		
		void ButtonSaveClick(object sender, EventArgs e)
		{
			Form stockIn = new FormStockIn();
			stockIn.ShowDialog();	
		}
		
		void getAll(){
			try{
			SQLDataBase.conOpen();
			SqlCommand get = new SqlCommand("SELECT * from View_Stock_Qty ORDER BY supplierId",SQLDataBase.connection);
			SqlDataAdapter da = new SqlDataAdapter(get);
			DataTable dt = new DataTable();
			da.Fill(dt);
			dataGridView1.Rows.Clear();
			dataGridView2.Rows.Clear();
			dataGridView3.Rows.Clear();
			data = "Stock Detail\nProfuct id,Product Name, Supplier Id, Supplier Name, QTY\n";
			foreach(DataRow dr in dt.Rows)
			{
				int n = dataGridView1.Rows.Add();
				dataGridView1.Rows[n].Cells[0].Value = dr[0].ToString();
				dataGridView1.Rows[n].Cells[1].Value = dr[1].ToString();
				dataGridView1.Rows[n].Cells[2].Value = dr[2].ToString();
				dataGridView1.Rows[n].Cells[3].Value = dr[3].ToString();
				dataGridView1.Rows[n].Cells[4].Value = dr[4].ToString();
				data = data + 
					dr[0].ToString()+","+
					dr[1].ToString()+","+
					dr[2].ToString()+","+
					dr[3].ToString()+","+
					dr[4].ToString()+","+"\n";
			}
		
			SQLDataBase.conClose();
			}catch(Exception){
			SQLDataBase.conClose();}
		}
		
		
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try{
				DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
				dataGridView3.Rows.Clear();
				dataGridView2.Rows.Clear();
				getIntStock(row.Cells[0].Value.ToString());
			}catch(Exception){
			}							
		}
		
		
		void getIntStock(string pid){
			try{
			SQLDataBase.conOpen();
			SqlCommand get = new SqlCommand("SELECT * FROM StockIn WHERE productId = '"+pid+"' ORDER BY _id DESC",SQLDataBase.connection);
			SqlDataAdapter da = new SqlDataAdapter(get);
			DataTable dt = new DataTable();
			da.Fill(dt);
			dataGridView3.Rows.Clear();
			foreach(DataRow dr in dt.Rows)
			{
				int n = dataGridView3.Rows.Add();
				dataGridView3.Rows[n].Cells[0].Value = dr[1].ToString();
				dataGridView3.Rows[n].Cells[1].Value = dr[4].ToString();
				dataGridView3.Rows[n].Cells[2].Value = dr[7].ToString();
			}
		
			SQLDataBase.conClose();
			getOutStock(pid);
			}catch(Exception){
			SQLDataBase.conClose();
			}
		}
		
		void getOutStock(string pid){
			try{
			SQLDataBase.conOpen();
			SqlCommand get = new SqlCommand("SELECT * FROM StockOut WHERE productId = '"+pid+"' ORDER BY _id DESC",SQLDataBase.connection);
			SqlDataAdapter da = new SqlDataAdapter(get);
			DataTable dt = new DataTable();
			da.Fill(dt);
			dataGridView2.Rows.Clear();
			foreach(DataRow dr in dt.Rows)
			{
				int n = dataGridView2.Rows.Add();
				dataGridView2.Rows[n].Cells[0].Value = dr[1].ToString();
				dataGridView2.Rows[n].Cells[1].Value = dr[2].ToString();
				dataGridView2.Rows[n].Cells[2].Value = dr[5].ToString();
			}
		
			SQLDataBase.conClose();
			}catch(Exception){
			SQLDataBase.conClose();
			}
		}
		
		
		
		void Button3Click(object sender, EventArgs e)
		{
			getAll();
		}
		
		void TextBoxproTextChanged(object sender, EventArgs e)
		{
			try{
			SQLDataBase.conOpen();
			SqlCommand get = new SqlCommand("SELECT * from View_Stock_Qty WHERE productId LIKE '%"+textBoxpro.Text.ToString()+"%' OR  productName LIKE '%"+textBoxpro.Text.ToString()+"%' ORDER BY supplierId",SQLDataBase.connection);
			SqlDataAdapter da = new SqlDataAdapter(get);
			DataTable dt = new DataTable();
			da.Fill(dt);
			dataGridView1.Rows.Clear();
			dataGridView3.Rows.Clear();
			dataGridView2.Rows.Clear();
			foreach(DataRow dr in dt.Rows)
			{
				int n = dataGridView1.Rows.Add();
				dataGridView1.Rows[n].Cells[0].Value = dr[0].ToString();
				dataGridView1.Rows[n].Cells[1].Value = dr[1].ToString();
				dataGridView1.Rows[n].Cells[2].Value = dr[2].ToString();
				dataGridView1.Rows[n].Cells[3].Value = dr[3].ToString();
				dataGridView1.Rows[n].Cells[4].Value = dr[4].ToString();
			}
		
			SQLDataBase.conClose();
			}catch(Exception){
			SQLDataBase.conClose();}			
		}

		
		void Button1Click(object sender, EventArgs e)
		{
			string filePath = @"StockDetail.csv";
            File.WriteAllText(filePath, data);
            string dataFromRead = File.ReadAllText(filePath);
            Console.WriteLine(dataFromRead);			
		}
		
	}
}
