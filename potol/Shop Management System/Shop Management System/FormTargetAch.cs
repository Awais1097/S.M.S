/*
 * Created by SharpDevelop.
 * User: Dell
 * Date: 2/12/2023
 * Time: 10:46 AM
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
	/// Description of FormTargetAch.
	/// </summary>
	public partial class FormTargetAch : Form
	{
		string target;
		public FormTargetAch(string t)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			target = t;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			getAllProgresss();
		}
		
		void getAllProgresss(){
		try{
			SQLDataBase.conOpen();
			SqlCommand get = new SqlCommand("select * from ViewProgress order by date DESC",SQLDataBase.connection);
			SqlDataAdapter da = new SqlDataAdapter(get);
			DataTable dt = new DataTable();
			da.Fill(dt);
			dataGridView1.Rows.Clear();
			foreach(DataRow dr in dt.Rows)
			{
				int n = dataGridView1.Rows.Add();
				dataGridView1.Rows[n].Cells[0].Value =  DateTime.Parse(dr[4].ToString()).ToString("yyyy-MM-dd") ;
				dataGridView1.Rows[n].Cells[1].Value = dr[1].ToString();
				dataGridView1.Rows[n].Cells[2].Value = dr[0].ToString();
				dataGridView1.Rows[n].Cells[3].Value = target.ToString();
				dataGridView1.Rows[n].Cells[4].Value =Math.Round(double.Parse(dr[3].ToString()),1).ToString();
			}
		
			SQLDataBase.conClose();
			}catch(Exception){
			SQLDataBase.conClose();
			}
		}
	}
}
