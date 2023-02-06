/*
 * Created by SharpDevelop.
 * User: NASIR
 * Date: 11/15/2022
 * Time: 9:57 AM
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
	/// Description of FormRacks.
	/// </summary>
	public partial class FormRacks : Form
	{
		string fileName;
		int new_id;
		
		public FormRacks()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			getId();
			getAll();
		}
		
		void PictureBox2Click(object sender, EventArgs e)
		{
			OpenFileDialog open = new OpenFileDialog(); 
			open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";  
			if (open.ShowDialog() == DialogResult.OK) {  
    			// display image in picture box  
    		pictureBox2.Image = new Bitmap(open.FileName);  
    		// image file path  
    		fileName = open.FileName;  
			}			
		}
		
		void getId(){
			try{
				SQLDataBase.conOpen();
				SqlCommand get = new SqlCommand("SELECT * FROM Racks ORDER BY _id DESC",SQLDataBase.connection);
				int i;
				SqlDataReader rdr = get.ExecuteReader();
				if(rdr.Read()){
					i = int.Parse(rdr[0].ToString()) + 1;
					new_id = i;
				}
				else{
					new_id = 1;
				}
				SQLDataBase.conClose();
				textBoxName.Focus();
				textBox1.Text = "RAC-"+new_id.ToString();
			}catch(Exception){
				SQLDataBase.conClose();
			}
		}
		
		
		void ButtonSaveClick(object sender, EventArgs e)
		{
			try{
			string query = "INSERT INTO Racks (_id, RackName, RackId, BrandImage) VALUES ( @_id, @RackName, @RackId, @BrandImage)";  
          	SqlCommand cmd = new SqlCommand(query, SQLDataBase.connection);  
          	cmd.Parameters.AddWithValue("@_id", new_id);  
          	cmd.Parameters.AddWithValue("@RackName", textBoxName.Text);    
          	cmd.Parameters.AddWithValue("@RackId", textBox1.Text);  
			string img1= Utilites.ImageToBase64(pictureBox2.Image);
			if(img1 != "Error converting image to base64!"){
				cmd.Parameters.AddWithValue("@BrandImage",img1 );
			}else{
				cmd.Parameters.AddWithValue("@BrandImage", "NULL");
			}
  			SQLDataBase.conOpen();
            cmd.ExecuteScalar();  
            SQLDataBase.conClose();
			getAll();
            	getId();
            	refresh();            
			MessageBox.Show("Saved" , "Success" , MessageBoxButtons.OK, MessageBoxIcon.Information);            
			}catch(Exception ){
			SQLDataBase.conClose();
			MessageBox.Show("Not Saved", "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
			}			
		}
		
		void ButtonDeleteClick(object sender, EventArgs e)
		{
			
			try{
				string query = "DELETE from Racks where _id=@_id";  
          		SqlCommand cmd = new SqlCommand(query, SQLDataBase.connection);  
          		cmd.Parameters.AddWithValue("@_id", new_id);   
            	SQLDataBase.conOpen();
            	cmd.ExecuteScalar();  
            	SQLDataBase.conClose();  
            	getAll();
            	getId();
            	refresh();
			}catch(Exception){
				SQLDataBase.conClose();
			}			
		}
		
		void refresh(){
			textBoxName.Text ="";
			textBox1.Enabled = true;
			getId();
		}
		
		void getAll(){
			try{
			SQLDataBase.conOpen();
			SqlCommand get = new SqlCommand("SELECT * from Racks ORDER BY _id DESC",SQLDataBase.connection);
			SqlDataAdapter da = new SqlDataAdapter(get);
			DataTable dt = new DataTable();
			da.Fill(dt);
			dataGridView1.Rows.Clear();
			foreach(DataRow dr in dt.Rows)
			{
				int n = dataGridView1.Rows.Add();
				dataGridView1.Rows[n].Cells[0].Value = dr[0].ToString();
				//DateTime dateTime= Convert.ToDateTime(dr[1].ToString()); 
				//dataGridView1.Rows[n].Cells[1].Value = dateTime.ToString("dd-MM-yyyy");
				dataGridView1.Rows[n].Cells[1].Value = dr[2].ToString();
				dataGridView1.Rows[n].Cells[2].Value = dr[1].ToString();
				dataGridView1.Rows[n].Cells[3].Value = dr[3].ToString();
			}
		
			SQLDataBase.conClose();
			}catch(Exception){
			SQLDataBase.conClose();}
		}
		
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try{
				DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
				new_id = int.Parse(row.Cells[0].Value.ToString());
        		textBox1.Text  = row.Cells[1].Value.ToString();
        		textBoxName.Text  = row.Cells[2].Value.ToString();
				pictureBox2.Image = Utilites.LoadImage(row.Cells[3].Value.ToString()); 
				textBox1.Enabled = false;
			}catch(Exception){
			}
		}
		
		void ButtonnEWClick(object sender, EventArgs e)
		{
			refresh();
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			try{
			string query = "UPDATE Racks SET RackName=@RackName, BrandImage=@BrandImage WHERE _id=_id";  
          	SqlCommand cmd = new SqlCommand(query, SQLDataBase.connection);  
          	cmd.Parameters.AddWithValue("@RackName", textBoxName.Text);    
          	cmd.Parameters.AddWithValue("@_id", new_id);  
			string img1= Utilites.ImageToBase64(pictureBox2.Image);
			if(img1 != "Error converting image to base64!"){
				cmd.Parameters.AddWithValue("@BrandImage",img1 );
			}else{
				cmd.Parameters.AddWithValue("@BrandImage", "NULL");
			}
  			SQLDataBase.conOpen();
            cmd.ExecuteScalar();  
            SQLDataBase.conClose();
			getAll();
            	getId();
            	refresh();            
			MessageBox.Show("Updated" , "Success" , MessageBoxButtons.OK, MessageBoxIcon.Information);            
			}catch(Exception ){
			SQLDataBase.conClose();
			MessageBox.Show("Not Updated", "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
			}			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			try{
				SQLDataBase.conOpen();
				SqlCommand get = new SqlCommand("SELECT * FROM Racks where  RackId = '"+textBox1.Text+"' ORDER BY _id DESC",SQLDataBase.connection);
				SqlDataReader rdr = get.ExecuteReader();
				if(rdr.Read()){
					new_id = int.Parse(rdr[0].ToString());
					textBoxName.Text = rdr[1].ToString();
					pictureBox2.Image = Utilites.LoadImage(rdr[3].ToString());
				}else{
					MessageBox.Show("Recoed not founded", "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				SQLDataBase.conClose();
				textBoxName.Focus();
			}catch(Exception){
				SQLDataBase.conClose();
				MessageBox.Show("Recoed not founded", "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
			}				
		}
		
	}
	
}
