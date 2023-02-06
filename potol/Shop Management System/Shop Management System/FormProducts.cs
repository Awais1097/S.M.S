/*
 * Created by SharpDevelop.
 * User: Dell
 * Date: 12/17/2022
 * Time: 8:49 AM
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
	/// Description of FormProducts.
	/// </summary>
	public partial class FormProducts : Form
	{
		string fileName;
		int new_id;
		Boolean isAllow = true;
				
		public FormProducts()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			companylist();
			ranklist();
			catelist();
			brandlist();
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
		
		void companylist(){		
			try{
				SQLDataBase.conOpen();
			SqlCommand get = new SqlCommand("SELECT  CompanyName  FROM Company ORDER BY CompanyName ",SQLDataBase.connection);
			SqlDataReader rdr = get.ExecuteReader();
			while(rdr.Read())
			{
				comboBoxComp.Items.Add(rdr[0].ToString());
			}
			SQLDataBase.conClose();
			}catch(Exception){
			SQLDataBase.conClose();
			}
		}
		
		void ranklist(){		
			try{
				SQLDataBase.conOpen();
			SqlCommand get = new SqlCommand("SELECT  RackName  FROM Racks ORDER BY RackName ",SQLDataBase.connection);
			SqlDataReader rdr = get.ExecuteReader();
			while(rdr.Read())
			{
				comboBoxRack.Items.Add(rdr[0].ToString());
			}
			SQLDataBase.conClose();
			}catch(Exception){
			SQLDataBase.conClose();
			}
		}
		
		void catelist(){		
			try{
				SQLDataBase.conOpen();
			SqlCommand get = new SqlCommand("SELECT  CategoryName  FROM Category ORDER BY CategoryName ",SQLDataBase.connection);
			SqlDataReader rdr = get.ExecuteReader();
			while(rdr.Read())
			{
				comboBoxCate.Items.Add(rdr[0].ToString());
			}
			SQLDataBase.conClose();
			}catch(Exception){
			SQLDataBase.conClose();
			}
		}
		
		void brandlist(){		
			try{
				SQLDataBase.conOpen();
			SqlCommand get = new SqlCommand("SELECT  BrandName  FROM Brands ORDER BY BrandName ",SQLDataBase.connection);
			SqlDataReader rdr = get.ExecuteReader();
			while(rdr.Read())
			{
				comboBoxBrnd.Items.Add(rdr[0].ToString());
			}
			SQLDataBase.conClose();
			}catch(Exception){
			SQLDataBase.conClose();
			}
		}
		
		void getId(){
			try{
				SQLDataBase.conOpen();
				SqlCommand get = new SqlCommand("SELECT * FROM product ORDER BY _id DESC",SQLDataBase.connection);
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
				textBoxid.Text = "PRO-"+new_id.ToString();
			}catch(Exception){
				SQLDataBase.conClose();
			}
		}
		
		void refresh(){
				textBoxName.Text  = "";
        		textBoxid.Text  = "";
        		textBoxuprice.Text  = "";
        		textBoxrprice.Text  = "";
        		textBoxusize.Text  = "";
        		textBoxcsize.Text  = "";
        		textBoxcatid.Text  = "";
        		textBoxcmpid.Text  = "";
        		textBoxBrndid.Text = "";
        		textBoxrackid.Text = "";
        		comboBoxCate.Text = "";
        		comboBoxComp.Text = "";
        		comboBoxRack.Text = "";
        		comboBoxBrnd.Text = "";        		
				textBoxid.Enabled = true;
			getId();
		}
		
		void getAll(){
			try{
			SQLDataBase.conOpen();
			SqlCommand get = new SqlCommand("SELECT _id,productid,productname,unitsize,unitprice,compname from product ORDER BY _id DESC",SQLDataBase.connection);
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
			}
		
			SQLDataBase.conClose();
			}catch(Exception){
			SQLDataBase.conClose();
			}
		}
		
		
		void ButtonSaveClick(object sender, EventArgs e)
		{
			try{
			string query = "INSERT INTO product (_id, productid, productname, unitsize, cartonsize, unitprice, retailprice, categoryid, categoryname, brandid,brandname,compid,compname,rackid,rackname,proimg) VALUES (@_id, @productid, @productname, @unitsize, @cartonsize, @unitprice, @retailprice, @categoryid, @categoryname, @brandid,@brandname,@compid,@compname,@rackid,@rackname,@proimg)";  
          	SqlCommand cmd = new SqlCommand(query, SQLDataBase.connection);  
          	cmd.Parameters.AddWithValue("@_id", new_id);  
          	cmd.Parameters.AddWithValue("@productid", textBoxid.Text);    
          	cmd.Parameters.AddWithValue("@productname", textBoxName.Text);  
          	cmd.Parameters.AddWithValue("@unitsize", textBoxusize.Text); 
          	cmd.Parameters.AddWithValue("@cartonsize", textBoxcsize.Text); 
          	cmd.Parameters.AddWithValue("@unitprice", textBoxuprice.Text); 
          	cmd.Parameters.AddWithValue("@retailprice", textBoxrprice.Text); 
          	cmd.Parameters.AddWithValue("@categoryid", textBoxcatid.Text); 
          	cmd.Parameters.AddWithValue("@categoryname", comboBoxCate.Text); 
          	
          	cmd.Parameters.AddWithValue("@brandid", textBoxBrndid.Text); 
          	cmd.Parameters.AddWithValue("@brandname", comboBoxBrnd.Text); 
          	cmd.Parameters.AddWithValue("@compid", textBoxcmpid.Text);
          	cmd.Parameters.AddWithValue("@compname", comboBoxComp.Text);
			cmd.Parameters.AddWithValue("@rackid", textBoxrackid.Text); 
			cmd.Parameters.AddWithValue("@rackname", comboBoxRack.Text);			
			string img1= Utilites.ImageToBase64(pictureBox2.Image);
			if(img1 != "Error converting image to base64!"){
				cmd.Parameters.AddWithValue("@proimg",img1 );
			}else{
				cmd.Parameters.AddWithValue("@proimg", "NULL");
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
				string query = "DELETE from product where _id=@_id";  
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
		
		void ButtonnEWClick(object sender, EventArgs e)
		{
			refresh();
			getId();
			getAll();			
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			try{
			string query = "UPDATE product  SET productname=@productname, unitsize=@unitsize, cartonsize=@cartonsize, unitprice=@unitprice, retailprice=@retailprice, categoryid=@categoryid, categoryname=@categoryname, brandid=@brandid,brandname=@brandname,compid=@compid,compname=@compname,rackid=@rackid,rackname=@rackname,proimg=@proimg where productid=@productid";  
          	SqlCommand cmd = new SqlCommand(query, SQLDataBase.connection);  
          	//cmd.Parameters.AddWithValue("@_id", new_id);  
          	cmd.Parameters.AddWithValue("@productid", textBoxid.Text);    
          	cmd.Parameters.AddWithValue("@productname", textBoxName.Text);  
          	cmd.Parameters.AddWithValue("@unitsize", textBoxusize.Text); 
          	cmd.Parameters.AddWithValue("@cartonsize", textBoxcsize.Text); 
          	cmd.Parameters.AddWithValue("@unitprice", textBoxuprice.Text); 
          	cmd.Parameters.AddWithValue("@retailprice", textBoxrprice.Text); 
          	cmd.Parameters.AddWithValue("@categoryid", textBoxcatid.Text); 
          	cmd.Parameters.AddWithValue("@categoryname", comboBoxCate.Text); 
          	
          	cmd.Parameters.AddWithValue("@brandid", textBoxBrndid.Text); 
          	cmd.Parameters.AddWithValue("@brandname", comboBoxBrnd.Text); 
          	cmd.Parameters.AddWithValue("@compid", textBoxcmpid.Text);
          	cmd.Parameters.AddWithValue("@compname", comboBoxComp.Text);
			cmd.Parameters.AddWithValue("@rackid", textBoxrackid.Text); 
			cmd.Parameters.AddWithValue("@rackname", comboBoxRack.Text);			
			string img1= Utilites.ImageToBase64(pictureBox2.Image);
			if(img1 != "Error converting image to base64!"){
				cmd.Parameters.AddWithValue("@proimg",img1 );
			}else{
				cmd.Parameters.AddWithValue("@proimg", "NULL");
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
		
		void Button1Click(object sender, EventArgs e)
		{
			searchById(textBoxid.Text.ToString());
		}
		
		
		void searchById(string id){
			try{
				isAllow = false;
				SQLDataBase.conOpen();
				SqlCommand get = new SqlCommand("SELECT _id, productid, productname, unitsize, cartonsize, unitprice, retailprice, categoryid, categoryname, brandid,brandname,compid,compname,rackid,rackname,proimg FROM product where  productid = '"+id+"' ORDER BY _id DESC",SQLDataBase.connection);
				SqlDataReader rdr = get.ExecuteReader();
				if(rdr.Read()){
					new_id = int.Parse(rdr[0].ToString());
        			textBoxid.Text  = rdr[1].ToString();
        			textBoxName.Text  = rdr[2].ToString();
        			textBoxusize.Text  = rdr[3].ToString();
        			textBoxcsize.Text  = rdr[4].ToString();
        			textBoxuprice.Text  = rdr[5].ToString();
        			textBoxrprice.Text  = rdr[6].ToString();
        			textBoxcatid.Text  = rdr[7].ToString();
        			comboBoxCate.Text  = rdr[8].ToString();
        			textBoxBrndid.Text  = rdr[9].ToString();
        			comboBoxBrnd.Text  = rdr[10].ToString();
        			textBoxcmpid.Text  = rdr[11].ToString();
        			comboBoxComp.Text  = rdr[12].ToString();
        			textBoxrackid.Text  = rdr[13].ToString();
        			comboBoxRack.Text  = rdr[14].ToString();
					pictureBox2.Image = Utilites.LoadImage(rdr[15].ToString()); 
					textBoxid.Enabled = false;
				}
				SQLDataBase.conClose();
				textBoxName.Focus();
				isAllow = true;
			}catch(Exception){
				SQLDataBase.conClose();
				MessageBox.Show("Recoed not founded", "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
			}	
		}
		
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try{
				DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
				searchById(row.Cells[1].Value.ToString());
				textBoxid.Enabled = false;
			}catch(Exception){
			}				
		}
		
		void ComboBoxCateSelectedIndexChanged(object sender, EventArgs e)
		{
			if(isAllow){
			try{
				SQLDataBase.conOpen();
				SqlCommand get = new SqlCommand("SELECT  CategoryId  FROM Category Where CategoryName ='"+comboBoxCate.Text+"' ",SQLDataBase.connection);
				SqlDataReader rdr = get.ExecuteReader();
				if(rdr.Read()){
					textBoxcatid.Text = rdr[0].ToString();
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
		
		void TextBoxcatidTextChanged(object sender, EventArgs e)
		{
			if(isAllow){
				try{
				SQLDataBase.conOpen();
				SqlCommand get = new SqlCommand("SELECT  CategoryName  FROM Category Where CategoryId ='"+textBoxcatid.Text+"' ",SQLDataBase.connection);
				SqlDataReader rdr = get.ExecuteReader();
				if(rdr.Read()){
					comboBoxCate.Text = rdr[0].ToString();
				}else{
					//MessageBox.Show("Recoed not founded", "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				SQLDataBase.conClose();
				textBoxcatid.Focus();
			}catch(Exception){
				SQLDataBase.conClose();
				//MessageBox.Show("Recoed not founded", "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
			}	
			}
						
		}
		
		void TextBoxcmpidTextChanged(object sender, EventArgs e)
		{
			if(isAllow){
			try{
				SQLDataBase.conOpen();
				SqlCommand get = new SqlCommand("SELECT  CompanyName  FROM Company Where CompanyId ='"+textBoxcmpid.Text+"' ",SQLDataBase.connection);
				SqlDataReader rdr = get.ExecuteReader();
				if(rdr.Read()){
					comboBoxComp.Text = rdr[0].ToString();
				}else{
					//MessageBox.Show("Recoed not founded", "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				SQLDataBase.conClose();
				textBoxcmpid.Focus();
			}catch(Exception){
				SQLDataBase.conClose();
				//MessageBox.Show("Recoed not founded", "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			}
		}
		
		void ComboBoxCompSelectedIndexChanged(object sender, EventArgs e)
		{
			if(isAllow){
			try{
				SQLDataBase.conOpen();
				SqlCommand get = new SqlCommand("SELECT  CompanyId  FROM Company Where CompanyName ='"+comboBoxComp.Text+"' ",SQLDataBase.connection);
				SqlDataReader rdr = get.ExecuteReader();
				if(rdr.Read()){
					textBoxcmpid.Text = rdr[0].ToString();
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
		
		void TextBoxBrndidTextChanged(object sender, EventArgs e)
		{
			if(isAllow){
			try{
				SQLDataBase.conOpen();
				SqlCommand get = new SqlCommand("SELECT  BrandName  FROM Brands Where BrandId ='"+textBoxBrndid.Text+"' ",SQLDataBase.connection);
				SqlDataReader rdr = get.ExecuteReader();
				if(rdr.Read()){
					comboBoxBrnd.Text = rdr[0].ToString();
				}else{
					//MessageBox.Show("Recoed not founded", "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				SQLDataBase.conClose();
				textBoxBrndid.Focus();
			}catch(Exception){
				SQLDataBase.conClose();
				//MessageBox.Show("Recoed not founded", "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			}
		}
		
		void TextBoxrackidTextChanged(object sender, EventArgs e)
		{
			if(isAllow){
			try{
				SQLDataBase.conOpen();
				SqlCommand get = new SqlCommand("SELECT  RackName  FROM Racks Where RackId ='"+textBoxrackid.Text+"' ",SQLDataBase.connection);
				SqlDataReader rdr = get.ExecuteReader();
				if(rdr.Read()){
					comboBoxRack.Text = rdr[0].ToString();
				}else{
					//MessageBox.Show("Recoed not founded", "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				SQLDataBase.conClose();
				textBoxrackid.Focus();
			}catch(Exception){
				SQLDataBase.conClose();
				//MessageBox.Show("Recoed not founded", "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			}
		}
		
		void ComboBoxBrndSelectedIndexChanged(object sender, EventArgs e)
		{
			if(isAllow){
			try{
				SQLDataBase.conOpen();
				SqlCommand get = new SqlCommand("SELECT  BrandId  FROM Brands Where BrandName ='"+comboBoxBrnd.Text+"' ",SQLDataBase.connection);
				SqlDataReader rdr = get.ExecuteReader();
				if(rdr.Read()){
					textBoxBrndid.Text = rdr[0].ToString();
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
		
		void ComboBoxRackSelectedIndexChanged(object sender, EventArgs e)
		{
			if(isAllow){
			try{
				SQLDataBase.conOpen();
				SqlCommand get = new SqlCommand("SELECT  RackId  FROM Racks Where RackName ='"+comboBoxRack.Text+"' ",SQLDataBase.connection);
				SqlDataReader rdr = get.ExecuteReader();
				if(rdr.Read()){
					textBoxrackid.Text = rdr[0].ToString();
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
	}
	
}
