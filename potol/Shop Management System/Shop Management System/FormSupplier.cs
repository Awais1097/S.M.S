/*
 * Created by SharpDevelop.
 * User: Dell
 * Date: 12/17/2022
 * Time: 8:43 AM
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
	/// Description of FormSupplier.
	/// </summary>
	public partial class FormSupplier : Form
	{
		string fileName;
		int new_id;
				
		public FormSupplier()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			getId();
			companylist();
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
		
		void TextBox6TextChanged(object sender, EventArgs e)
		{
			
		}
		
		
		void getId(){
			try{
				SQLDataBase.conOpen();
				SqlCommand get = new SqlCommand("SELECT * FROM Suppliers ORDER BY _id DESC",SQLDataBase.connection);
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
				textBox2.Focus();
				textBoxName.Text = "SUP-"+new_id.ToString();
			}catch(Exception){
				SQLDataBase.conClose();
			}
		}
		
		void refresh(){
				textBox2.Text  = "";
        		textBoxName.Text  = "";
        		textBox1.Text  = "";
        		textBox3.Text  = "";
        		textBox5.Text  = "Pakistan";
        		textBox4.Text  = "";
        		textBox6.Text  = "";
        		comboBox1.Text  = "";
			textBoxName.Enabled = true;
			getId();
		}
		
		void getAll(){
			try{
			SQLDataBase.conOpen();
			SqlCommand get = new SqlCommand("SELECT * from Suppliers ORDER BY _id DESC",SQLDataBase.connection);
			SqlDataAdapter da = new SqlDataAdapter(get);
			DataTable dt = new DataTable();
			da.Fill(dt);
			dataGridView1.Rows.Clear();
			foreach(DataRow dr in dt.Rows)
			{
				int n = dataGridView1.Rows.Add();
				dataGridView1.Rows[n].Cells[0].Value = dr[0].ToString();
				dataGridView1.Rows[n].Cells[1].Value = dr[2].ToString();
				dataGridView1.Rows[n].Cells[2].Value = dr[1].ToString();
				dataGridView1.Rows[n].Cells[3].Value = dr[3].ToString();
				dataGridView1.Rows[n].Cells[4].Value = dr[4].ToString();
				dataGridView1.Rows[n].Cells[5].Value = dr[5].ToString();
				dataGridView1.Rows[n].Cells[6].Value = dr[6].ToString();
				dataGridView1.Rows[n].Cells[7].Value = dr[7].ToString();
				dataGridView1.Rows[n].Cells[8].Value = dr[8].ToString();
				dataGridView1.Rows[n].Cells[9].Value = dr[9].ToString();
				dataGridView1.Rows[n].Cells[10].Value = dr[10].ToString();
				dataGridView1.Rows[n].Cells[11].Value = dr[11].ToString();
			}
		
			SQLDataBase.conClose();
			}catch(Exception){
			SQLDataBase.conClose();
			}
		}
		
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try{
				DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
				new_id = int.Parse(row.Cells[0].Value.ToString());
        		textBox2.Text  = row.Cells[1].Value.ToString();
        		textBoxName.Text  = row.Cells[2].Value.ToString();
        		textBox1.Text  = row.Cells[3].Value.ToString();
        		textBox3.Text  = row.Cells[4].Value.ToString();
        		textBox5.Text  = row.Cells[5].Value.ToString();
        		textBox4.Text  = row.Cells[6].Value.ToString();
        		textBox6.Text  = row.Cells[7].Value.ToString();
        		comboBox1.Text  = row.Cells[8].Value.ToString();
				pictureBox2.Image = Utilites.LoadImage(row.Cells[9].Value.ToString()); 
				textBoxName.Enabled = false;
			}catch(Exception){
			}			
		}
	
		
		void companylist(){		
			try{
				SQLDataBase.conOpen();
			SqlCommand get = new SqlCommand("SELECT  CompanyName  FROM Company ORDER BY CompanyName ",SQLDataBase.connection);
			SqlDataReader rdr = get.ExecuteReader();
			while(rdr.Read())
			{
				comboBox1.Items.Add(rdr[0].ToString());
			}
			SQLDataBase.conClose();
			}catch(Exception){
			SQLDataBase.conClose();
			}
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			try{
				SQLDataBase.conOpen();
				SqlCommand get = new SqlCommand("SELECT * FROM Suppliers where  SupplierId = '"+textBoxName.Text+"' ORDER BY _id DESC",SQLDataBase.connection);
				SqlDataReader rdr = get.ExecuteReader();
				if(rdr.Read()){
					new_id = int.Parse(rdr[0].ToString());
        			textBoxName.Text  = rdr[1].ToString();
        			textBox2.Text  = rdr[2].ToString();
        			textBox1.Text  = rdr[3].ToString();
        			textBox3.Text  = rdr[4].ToString();
        			textBox5.Text  = rdr[5].ToString();
        			textBox4.Text  = rdr[6].ToString();
        			textBox6.Text  = rdr[7].ToString();
        			comboBox1.Text  = rdr[8].ToString();
					pictureBox2.Image = Utilites.LoadImage(rdr[9].ToString()); 
					textBoxName.Enabled = false;
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
		
		void ButtonnEWClick(object sender, EventArgs e)
		{
			refresh();
			getId();
			getAll();			
		}
		
		void ButtonDeleteClick(object sender, EventArgs e)
		{
			try{
				string query = "DELETE from Suppliers where _id=@_id";  
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
		
		void ButtonSaveClick(object sender, EventArgs e)
		{
			try{
			string query = "INSERT INTO Suppliers (_id, SupplierId, SupplierName, SupplierPhoneNumber, SupplierMobileNumber, SupplierCity, SupplierCountry, SupplierAddress, SupplierCompName, SupplierImage) VALUES (@_id, @CustomersId, @CustomersName, @CustomersPhoneNumber,@CustomersMobileNumber,@CustomersCity,@CustomersCountry,@CustomersAddress,@Remarks,@CustomersImage)";  
          	SqlCommand cmd = new SqlCommand(query, SQLDataBase.connection);  
          	cmd.Parameters.AddWithValue("@_id", new_id);  
          	cmd.Parameters.AddWithValue("@CustomersId", textBoxName.Text);    
          	cmd.Parameters.AddWithValue("@CustomersName", textBox2.Text);  
          	cmd.Parameters.AddWithValue("@CustomersPhoneNumber", textBox1.Text); 
          	cmd.Parameters.AddWithValue("@CustomersMobileNumber", textBox3.Text); 
          	cmd.Parameters.AddWithValue("@CustomersCity", textBox5.Text); 
          	cmd.Parameters.AddWithValue("@CustomersCountry", textBox4.Text); 
          	cmd.Parameters.AddWithValue("@CustomersAddress", textBox6.Text); 
          	cmd.Parameters.AddWithValue("@Remarks", comboBox1.Text); 
			string img1= Utilites.ImageToBase64(pictureBox2.Image);
			if(img1 != "Error converting image to base64!"){
				cmd.Parameters.AddWithValue("@CustomersImage",img1 );
			}else{
				cmd.Parameters.AddWithValue("@CustomersImage", "NULL");
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
		
		void Button3Click(object sender, EventArgs e)
		{
			try{
			string query = "UPDATE Suppliers SET SupplierName=@CustomersName, SupplierPhoneNumber=@CustomersPhoneNumber,SupplierMobileNumber=@CustomersMobileNumber,SupplierCity=@CustomersCity,SupplierCountry=@CustomersCountry,SupplierAddress=@CustomersAddress,SupplierCompName=@Remarks,SupplierImage=@CustomersImage where SupplierId=@CustomersId";  
          	SqlCommand cmd = new SqlCommand(query, SQLDataBase.connection);  
          	//cmd.Parameters.AddWithValue("@_id", new_id);  
          	cmd.Parameters.AddWithValue("@CustomersId", textBoxName.Text);    
          	cmd.Parameters.AddWithValue("@CustomersName", textBox2.Text);  
          	cmd.Parameters.AddWithValue("@CustomersPhoneNumber", textBox1.Text); 
          	cmd.Parameters.AddWithValue("@CustomersMobileNumber", textBox3.Text); 
          	cmd.Parameters.AddWithValue("@CustomersCity", textBox5.Text); 
          	cmd.Parameters.AddWithValue("@CustomersCountry", textBox4.Text); 
          	cmd.Parameters.AddWithValue("@CustomersAddress", textBox6.Text); 
          	cmd.Parameters.AddWithValue("@Remarks", comboBox1.Text); 
			string img1= Utilites.ImageToBase64(pictureBox2.Image);
			if(img1 != "Error converting image to base64!"){
				cmd.Parameters.AddWithValue("@CustomersImage",img1 );
			}else{
				cmd.Parameters.AddWithValue("@CustomersImage", "NULL");
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
	}
}
