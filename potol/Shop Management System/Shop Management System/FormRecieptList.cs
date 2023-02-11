/*
 * Created by SharpDevelop.
 * User: mohsi
 * Date: 08/02/2023
 * Time: 3:13 pm
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
	/// Description of FormRecieptList.
	/// </summary>
	public partial class FormRecieptList : Form
	{
		string type;
		public FormRecieptList(string t)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			type = t;
			InitializeComponent();
			label6.Text = type == Utilites.ORDER ? "ORDER" : "RECIEPT";
			button1.Text = type == Utilites.ORDER ? "Update" : "Export";
			getAll();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			Form form = new FormCreateRecipt(type);
			form.ShowDialog();			
		}
		
		void getAll(){
			try{
			SQLDataBase.conOpen();
			SqlCommand get = new SqlCommand("select * from receipt_main Where type = '"+type+"' ORDER BY _id DESC",SQLDataBase.connection);
			SqlDataAdapter da = new SqlDataAdapter(get);
			DataTable dt = new DataTable();
			da.Fill(dt);
			dataGridView1.Rows.Clear();
			foreach(DataRow dr in dt.Rows)
			{
				int n = dataGridView1.Rows.Add();
				dataGridView1.Rows[n].Cells[0].Value = dr[0].ToString();
				dataGridView1.Rows[n].Cells[1].Value = dr[8].ToString();
				dataGridView1.Rows[n].Cells[2].Value = dr[1].ToString();
				dataGridView1.Rows[n].Cells[3].Value = dr[2].ToString();
				dataGridView1.Rows[n].Cells[4].Value = dr[3].ToString();
				dataGridView1.Rows[n].Cells[5].Value = dr[5].ToString();
				dataGridView1.Rows[n].Cells[6].Value = dr[6].ToString();
				dataGridView1.Rows[n].Cells[7].Value = dr[4].ToString();
			}
		
			SQLDataBase.conClose();
			}catch(Exception){
			SQLDataBase.conClose();
			}
		}
		
		void PrintDocument1PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			PrintRepiept p = new PrintRepiept(textBoxID.Text.ToString(),e);
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			printPreviewDialog1.Document =  printDocument1;
			printPreviewDialog1.ShowDialog();			
		}
		
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try{
				DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
				textBoxID.Text = row.Cells[0].Value.ToString();
			}catch(Exception){
			}			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			if(type == Utilites.ORDER){
				Form form = new FormUpdateOrderStatus(textBoxID.Text);
				form.ShowDialog();
			}else{
			string data = "ID,Time,Date,Customer ID,Customer Name,QTY,Price,Remarks\n";
			foreach(DataGridViewRow row in dataGridView1.Rows){
				data = data + 
					row.Cells[0].Value.ToString()+ ","+
					row.Cells[1].Value.ToString()+ ","+
					row.Cells[2].Value.ToString()+ ","+
					row.Cells[3].Value.ToString()+ ","+
					row.Cells[4].Value.ToString()+ ","+
					row.Cells[5].Value.ToString()+ ","+
					row.Cells[6].Value.ToString()+ ","+
					row.Cells[7].Value.ToString()+ "\n";
			}
			Boolean msg = Utilites.save("Reciepts"+DateTime.Now.ToString("yyyy-MM-dd")+".csv",data);
			if(msg == false){
				MessageBox.Show("File not saved. Try again","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			}
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			try{
				String sDate =DateTime.Parse(dateTimePicker2.Text).ToString("yyyy-MM-dd");
				String edate = DateTime.Parse(dateTimePicker3.Text).ToString("yyyy-MM-dd");
			SQLDataBase.conOpen();
			SqlCommand get = new SqlCommand("select * from receipt_main Where type = '"+type+"' AND date BETWEEN '"+sDate+"' AND '"+edate+"' ORDER BY _id DESC",SQLDataBase.connection);
			SqlDataAdapter da = new SqlDataAdapter(get);
			DataTable dt = new DataTable();
			da.Fill(dt);
			dataGridView1.Rows.Clear();
			foreach(DataRow dr in dt.Rows)
			{
				int n = dataGridView1.Rows.Add();
				dataGridView1.Rows[n].Cells[0].Value = dr[0].ToString();
				dataGridView1.Rows[n].Cells[1].Value = dr[8].ToString();
				dataGridView1.Rows[n].Cells[2].Value = dr[1].ToString();
				dataGridView1.Rows[n].Cells[3].Value = dr[2].ToString();
				dataGridView1.Rows[n].Cells[4].Value = dr[3].ToString();
				dataGridView1.Rows[n].Cells[5].Value = dr[5].ToString();
				dataGridView1.Rows[n].Cells[6].Value = dr[6].ToString();
				dataGridView1.Rows[n].Cells[7].Value = dr[4].ToString();
			}
		
			SQLDataBase.conClose();
			}catch(Exception){
			SQLDataBase.conClose();
			}			
		}
	}
}
