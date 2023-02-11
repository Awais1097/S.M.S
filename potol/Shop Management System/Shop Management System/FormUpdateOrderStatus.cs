/*
 * Created by SharpDevelop.
 * User: Dell
 * Date: 2/10/2023
 * Time: 10:19 AM
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
	/// Description of FormUpdateOrderStatus.
	/// </summary>
	public partial class FormUpdateOrderStatus : Form
	{
		string id;
		public FormUpdateOrderStatus(string d)
		{
			id = d;
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			getAll();
		}
		
		
		void getAll(){
			try{
			SQLDataBase.conOpen();
			SqlCommand get = new SqlCommand("select * from receipt_main Where _id = '"+id+"' ORDER BY _id DESC",SQLDataBase.connection);
			SqlDataReader rdr = get.ExecuteReader();
				if(rdr.Read()){
					textBox1.Text = rdr[0].ToString();	
					dateTimePicker1.Text = rdr[1].ToString();
					textBoxsupid.Text = rdr[2].ToString();
					comboBoxCus.Text = rdr[3].ToString();
					textBoxremarks.Text = rdr[4].ToString();
					comboBox1.Text = rdr[9].ToString();
				}
				SQLDataBase.conClose();;
			}catch(Exception){
			SQLDataBase.conClose();
			}
		}
		
		void FormUpdateOrderStatusLoad(object sender, EventArgs e)
		{
			
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			try{
			string query = "UPDATE receipt_main SET status=@status where _id= @_id";  
          	SqlCommand cmd = new SqlCommand(query, SQLDataBase.connection);  
          	cmd.Parameters.AddWithValue("@_id", id);   
			cmd.Parameters.AddWithValue("@status", comboBox1.Text);	
  			SQLDataBase.conOpen();
            cmd.ExecuteScalar();  
            SQLDataBase.conClose(); 
          	 MessageBox.Show("Updated", "Status" , MessageBoxButtons.OK, MessageBoxIcon.Information);
			}catch(Exception ){
			SQLDataBase.conClose();
			MessageBox.Show("Not Saved", "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
			}			
		}
	}
}
