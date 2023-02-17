/*
 * Created by SharpDevelop.
 * User: Dell
 * Date: 12/18/2022
 * Time: 1:06 AM
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
	/// Description of FormStockIn.
	/// </summary>
	public partial class FormStockIn : Form
	{
		int new_id;
		Boolean isAllow = true;
		
		public FormStockIn()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			catelist();
			getAll();
			getId();
			suplist();
			
		}
		
		void DateTimePicker2ValueChanged(object sender, EventArgs e)
		{
			
		}
		
		void TextBox2TextChanged(object sender, EventArgs e)
		{
			if(isAllow){
				try{
				SQLDataBase.conOpen();
				SqlCommand get = new SqlCommand("SELECT  productname  FROM product Where productid ='"+textBoxpro.Text+"' ",SQLDataBase.connection);
				SqlDataReader rdr = get.ExecuteReader();
				if(rdr.Read()){
					comboBoxPro.Text = rdr[0].ToString();
				}else{
					//MessageBox.Show("Recoed not founded", "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				SQLDataBase.conClose();
				textBoxpro.Focus();
			}catch(Exception){
				SQLDataBase.conClose();
				//MessageBox.Show("Recoed not founded", "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
			}	
			}			
		}
		
		void catelist(){		
			try{
				SQLDataBase.conOpen();
			SqlCommand get = new SqlCommand("SELECT  productname  FROM product ORDER BY productname ",SQLDataBase.connection);
			SqlDataReader rdr = get.ExecuteReader();
			while(rdr.Read())
			{
				comboBoxPro.Items.Add(rdr[0].ToString());
			}
			SQLDataBase.conClose();
			}catch(Exception){
			SQLDataBase.conClose();
			}
		}
		
		void ComboBoxProSelectedIndexChanged(object sender, EventArgs e)
		{
		  if(isAllow){
			try{
				SQLDataBase.conOpen();
				SqlCommand get = new SqlCommand("SELECT  productid  FROM product Where productname ='"+comboBoxPro.Text+"' ",SQLDataBase.connection);
				SqlDataReader rdr = get.ExecuteReader();
				if(rdr.Read()){
					textBoxpro.Text = rdr[0].ToString();
				}else{
					MessageBox.Show("Recoed not founded", "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				SQLDataBase.conClose();
			}catch(Exception){
				SQLDataBase.conClose();
				MessageBox.Show("Recoed not founded", "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			}			
		}
		
		
		
		void getId(){
			try{
				SQLDataBase.conOpen();
				SqlCommand get = new SqlCommand("SELECT * FROM StockIn ORDER BY _id DESC",SQLDataBase.connection);
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
			}catch(Exception){
				SQLDataBase.conClose();
			}
		}
		
		void refresh(){
				textBoxpro.Text  = "";
        		textBoxprice.Text  = "";
        		textBoxprice.Text  = "";
        		textBoxqty.Text  = "";
        		textBoxremarks.Text  = "";
        		comboBoxPro.Text  = "";
        		comboBox4.Text  = "";       		
			getId();
		}
		
		void getAll(){
			try{
			SQLDataBase.conOpen();
			DateTime sDate = DateTime.Parse(dateTimePicker2.Text);
			DateTime eDate = DateTime.Parse(dateTimePicker3.Text);
			SqlCommand get = new SqlCommand("SELECT * FROM StockIn  WHERE inDate BETWEEN '"+sDate+"' AND '"+eDate+"' ORDER BY _id DESC",SQLDataBase.connection);
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
				dataGridView1.Rows[n].Cells[5].Value = dr[5].ToString();
				dataGridView1.Rows[n].Cells[6].Value = dr[6].ToString();
				dataGridView1.Rows[n].Cells[7].Value = dr[7].ToString();
				dataGridView1.Rows[n].Cells[8].Value = dr[8].ToString();
			}
		
			SQLDataBase.conClose();
			}catch(Exception){
			SQLDataBase.conClose();
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
				string query = "DELETE from StockIn where _id=@_id";  
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
		
		
		
		
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try{
				DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
				new_id = int.Parse(row.Cells[0].Value.ToString());
        		dateTimePicker1.Text  = row.Cells[1].Value.ToString();
        		textBoxpro.Text  = row.Cells[2].Value.ToString();
        		comboBoxPro.Text  = row.Cells[3].Value.ToString();
        		textBoxqty.Text  = row.Cells[4].Value.ToString();
        		textBoxprice.Text  = row.Cells[5].Value.ToString();
        		textBoxsupid.Text  = row.Cells[6].Value.ToString();
        		comboBox4.Text  = row.Cells[7].Value.ToString();
        		textBoxremarks.Text  = row.Cells[8].Value.ToString();
			}catch(Exception){
			}						
		}
		
		void ButtonSaveClick(object sender, EventArgs e)
		{
						try{
			string query = "INSERT INTO StockIn (_id, inDate, productId, productName, inQty, unitCost, supplierId, supplierName, remarks) VALUES (@_id, @inDate, @productId, @productName, @inQty, @unitCost, @supplierId, @supplierName, @remarks)";  
          	SqlCommand cmd = new SqlCommand(query, SQLDataBase.connection);  
          	cmd.Parameters.AddWithValue("@_id", new_id);  
          	DateTime sDate = DateTime.Parse(dateTimePicker1.Text);
          	cmd.Parameters.AddWithValue("@inDate", sDate);    
          	cmd.Parameters.AddWithValue("@productId", textBoxpro.Text);  
          	cmd.Parameters.AddWithValue("@productName", comboBoxPro.Text); 
          	cmd.Parameters.AddWithValue("@inQty", textBoxqty.Text); 
          	cmd.Parameters.AddWithValue("@unitCost", textBoxprice.Text); 
          	cmd.Parameters.AddWithValue("@supplierId", textBoxsupid.Text); 
          	cmd.Parameters.AddWithValue("@supplierName", comboBox4.Text); 
          	cmd.Parameters.AddWithValue("@remarks", textBoxremarks.Text); 
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
		
		void TextBoxsupidTextChanged(object sender, EventArgs e)
		{
			if(isAllow){
				try{
				SQLDataBase.conOpen();
				SqlCommand get = new SqlCommand("SELECT  SupplierName  FROM Suppliers Where SupplierId ='"+textBoxsupid.Text+"' ",SQLDataBase.connection);
				SqlDataReader rdr = get.ExecuteReader();
				if(rdr.Read()){
					comboBox4.Text = rdr[0].ToString();
				}else{
					//MessageBox.Show("Recoed not founded", "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				SQLDataBase.conClose();
				textBoxsupid.Focus();
			}catch(Exception){
				SQLDataBase.conClose();
				//MessageBox.Show("Recoed not founded", "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
			}	
			}				
		}
		
		void ComboBox4SelectedIndexChanged(object sender, EventArgs e)
		{
			if(isAllow){
			try{
				SQLDataBase.conOpen();
				SqlCommand get = new SqlCommand("SELECT  SupplierId  FROM Suppliers Where SupplierName ='"+comboBox4.Text+"' ",SQLDataBase.connection);
				SqlDataReader rdr = get.ExecuteReader();
				if(rdr.Read()){
					textBoxsupid.Text = rdr[0].ToString();
				}else{
					MessageBox.Show("Recoed not founded", "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				SQLDataBase.conClose();
			}catch(Exception){
				SQLDataBase.conClose();
				MessageBox.Show("Recoed not founded", "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			}	
		}
		
		
		void suplist(){		
			try{
				SQLDataBase.conOpen();
			SqlCommand get = new SqlCommand("SELECT  SupplierName  FROM Suppliers ORDER BY SupplierName ",SQLDataBase.connection);
			SqlDataReader rdr = get.ExecuteReader();
			while(rdr.Read())
			{
				comboBox4.Items.Add(rdr[0].ToString());
			}
			SQLDataBase.conClose();
			}catch(Exception){
			SQLDataBase.conClose();
			}
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			try{
			SQLDataBase.conOpen();
			SqlCommand get = new SqlCommand("SELECT * FROM StockIn ORDER BY _id DESC WHERE inDate BETWEEN '"+dateTimePicker2.Text+"' AND '"+dateTimePicker3.Text+"'",SQLDataBase.connection);
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
				dataGridView1.Rows[n].Cells[5].Value = dr[5].ToString();
				dataGridView1.Rows[n].Cells[6].Value = dr[6].ToString();
				dataGridView1.Rows[n].Cells[7].Value = dr[7].ToString();
				dataGridView1.Rows[n].Cells[8].Value = dr[8].ToString();
			}
		
			SQLDataBase.conClose();
			}catch(Exception){
			SQLDataBase.conClose();
			}									
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			SQLDataBase.conOpen();
			DateTime sDate = DateTime.Parse(dateTimePicker2.Text);
			DateTime eDate = DateTime.Parse(dateTimePicker3.Text);
			SqlCommand get = new SqlCommand("SELECT * FROM StockIn  WHERE inDate BETWEEN '"+sDate+"' AND '"+eDate+"' ORDER BY _id DESC",SQLDataBase.connection);
			SqlDataAdapter da = new SqlDataAdapter(get);
			DataTable dt = new DataTable();
			da.Fill(dt);
			string data = "id,Date,Product id,Product Name, QTY, Price, Supplier Id, Supplier Name, Remarks\n";
			foreach(DataRow dr in dt.Rows)
			{
				data = data + 
					dr[0].ToString()+","+
					dr[1].ToString()+","+
					dr[2].ToString()+","+
					dr[3].ToString()+","+
					dr[4].ToString()+","+
					dr[5].ToString()+","+
					dr[6].ToString()+","+
					dr[7].ToString()+","+
					dr[8].ToString()+"\n";
			}
			SQLDataBase.conClose();
            Boolean msg = Utilites.save("StockIn-"+DateTime.Now.ToString("yyyy-MM-dd")+".csv",data);
			if(msg == false){
				MessageBox.Show("File not saved. Try again","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		
	}
}
