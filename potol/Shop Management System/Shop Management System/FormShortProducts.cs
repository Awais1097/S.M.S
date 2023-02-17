/*
 * Created by SharpDevelop.
 * User: Dell
 * Date: 2/12/2023
 * Time: 10:30 AM
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
	/// Description of FormShortProducts.
	/// </summary>
	public partial class FormShortProducts : Form
	{
		public FormShortProducts()
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
		
		void Label6Click(object sender, EventArgs e)
		{
			
		}
		
		void getAll(){
			try{
			SQLDataBase.conOpen();
			SqlCommand get = new SqlCommand("select productid,productname,compname,rackname,Stock from ViewProductShort",SQLDataBase.connection);
			SqlDataAdapter da = new SqlDataAdapter(get);
			DataTable dt = new DataTable();
			da.Fill(dt);
			dataGridView1.Rows.Clear();
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
		
		
	}
}
