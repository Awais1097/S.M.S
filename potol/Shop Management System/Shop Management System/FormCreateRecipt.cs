/*
 * Created by SharpDevelop.
 * User: Dell
 * Date: 2/4/2023
 * Time: 10:00 PM
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
	/// Description of FormCreateRecipt.
	/// </summary>
	public partial class FormCreateRecipt : Form
	{

		int new_id;
		Boolean isAllow = true;
		string type = "";
		double price = 0.0;
		int stockQty= 0;
		 
		public FormCreateRecipt(string mType)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			type = mType;
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			getId();
			cusList();
			proList();
		}
		
		void PictureBox1Click(object sender, EventArgs e)
		{
			
		}
		
		void FormCreateReciptLoad(object sender, EventArgs e)
		{
			
		}
		
		void TextBoxsupidTextChanged(object sender, EventArgs e)
		{
			if(isAllow){
				try{
				SQLDataBase.conOpen();
				SqlCommand get = new SqlCommand("SELECT  CustomersName  FROM Customers Where CustomersId ='"+textBoxsupid.Text+"' ",SQLDataBase.connection);
				SqlDataReader rdr = get.ExecuteReader();
				if(rdr.Read()){
					isAllow = false;
					comboBoxCus.Text = rdr[0].ToString();
				}else{
					//MessageBox.Show("Recoed not founded", "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				isAllow = true;
				SQLDataBase.conClose();
				textBoxsupid.Focus();
			}catch(Exception){
				SQLDataBase.conClose();
				//MessageBox.Show("Recoed not founded", "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
			}	
			}
			
		}
		
		void ComboBoxCusSelectedIndexChanged(object sender, EventArgs e)
		{
			if(isAllow){
			try{
				SQLDataBase.conOpen();
				SqlCommand get = new SqlCommand("SELECT  CustomersId  FROM Customers Where CustomersName ='"+comboBoxCus.Text+"' ",SQLDataBase.connection);
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
		
		void ComboBoxCusTextChanged(object sender, EventArgs e)
		{
			if(isAllow){
				try{
				SQLDataBase.conOpen();
				SqlCommand get = new SqlCommand("SELECT  CustomersId,CustomersName  FROM Customers Where CustomersName  Like '%"+comboBoxCus.Text+"%' ",SQLDataBase.connection);
				SqlDataAdapter da = new SqlDataAdapter(get);
				DataTable dt = new DataTable();
				da.Fill(dt);
				dataGridView2.Rows.Clear();
				foreach(DataRow dr in dt.Rows)
				{
					int n = dataGridView2.Rows.Add();
					dataGridView2.Rows[n].Cells[0].Value = dr[0].ToString();
					dataGridView2.Rows[n].Cells[1].Value = dr[1].ToString();
				}
				SQLDataBase.conClose();
				type = "SUP";
			}catch(Exception){
				SQLDataBase.conClose();
				//MessageBox.Show("Recoed not founded", "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
			}	
			}
			
		}
		
		void ComboBoxProTextChanged(object sender, EventArgs e)
		{
			if(isAllow){
				try{
				SQLDataBase.conOpen();
				SqlCommand get = new SqlCommand("SELECT  productid,productname,retailprice,Stock  FROM View_Product_Stock Where productname  Like '%"+comboBoxPro.Text+"%' ",SQLDataBase.connection);
				SqlDataAdapter da = new SqlDataAdapter(get);
				DataTable dt = new DataTable();
				da.Fill(dt);
				dataGridView2.Rows.Clear();
				foreach(DataRow dr in dt.Rows)
				{
					int n = dataGridView2.Rows.Add();
					dataGridView2.Rows[n].Cells[0].Value = dr[0].ToString();
					dataGridView2.Rows[n].Cells[1].Value = dr[1].ToString();
					dataGridView2.Rows[n].Cells[2].Value = dr[2].ToString();
					dataGridView2.Rows[n].Cells[3].Value = dr[3].ToString();
				}
				SQLDataBase.conClose();
				type = "PRO";
			}catch(Exception){
				SQLDataBase.conClose();
				//MessageBox.Show("Recoed not founded", "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
			}	
			}
			
		}
		
		void cusList(){		
			try{
				SQLDataBase.conOpen();
			SqlCommand get = new SqlCommand("SELECT  CustomersName  FROM Customers ORDER BY CustomersName ",SQLDataBase.connection);
			SqlDataReader rdr = get.ExecuteReader();
			while(rdr.Read())
			{
				comboBoxCus.Items.Add(rdr[0].ToString());
			}
			SQLDataBase.conClose();
			}catch(Exception){
			SQLDataBase.conClose();
			}
		}
		
		void proList(){		
			try{
				SQLDataBase.conOpen();
			SqlCommand get = new SqlCommand("SELECT  productname  FROM View_Product_Stock ORDER BY productname ",SQLDataBase.connection);
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
		
		void DataGridView2CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try{
				isAllow = false;
				DataGridViewRow row = dataGridView2.Rows[e.RowIndex];
				if(type == "SUP"){
					textBoxsupid.Text =  row.Cells[0].Value.ToString();
        			comboBoxCus.Text  = row.Cells[1].Value.ToString();
        			textBoxremarks.Focus();
				}else if(type == "PRO"){
					textBoxpro.Text =  row.Cells[0].Value.ToString();
        			comboBoxPro.Text  = row.Cells[1].Value.ToString();
        			labelStock.Text = "Stock Qty : "+ row.Cells[3].ToString();
        			price  = Double.Parse(row.Cells[2].Value.ToString());
        			stockQty  = int.Parse(row.Cells[3].Value.ToString());
        			textBoxqty.Focus();
        			getStock(textBoxpro.Text);
				}
				isAllow = true;
			}catch(Exception){
				isAllow = true;
			}			
		}
		
		void TextBoxproTextChanged(object sender, EventArgs e)
		{
			if(isAllow){
				try{
				SQLDataBase.conOpen();
				SqlCommand get = new SqlCommand("SELECT  productname,retailprice,Stock  FROM View_Product_Stock Where productid ='"+textBoxpro.Text+"' ",SQLDataBase.connection);
				SqlDataReader rdr = get.ExecuteReader();
				if(rdr.Read()){
					isAllow = false;
					comboBoxPro.Text = rdr[0].ToString();
					labelStock.Text = "Stock Qty : "+rdr[2].ToString();
					price = Double.Parse(rdr[1].ToString());
					stockQty = int.Parse(rdr[2].ToString());
				}else{
					//MessageBox.Show("Recoed not founded", "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				isAllow = true;
				SQLDataBase.conClose();
				textBoxpro.Focus();
			}catch(Exception){
				SQLDataBase.conClose();
				//MessageBox.Show("Recoed not founded", "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			getStock(textBoxpro.Text);				
			}				
		}
		
		void ComboBoxProSelectedIndexChanged(object sender, EventArgs e)
		{
			if(isAllow){
			try{
				SQLDataBase.conOpen();
				SqlCommand get = new SqlCommand("SELECT  productid,retailprice,Stock  FROM View_Product_Stock Where productname ='"+comboBoxCus.Text+"' ",SQLDataBase.connection);
				SqlDataReader rdr = get.ExecuteReader();
				if(rdr.Read()){
					textBoxpro.Text = rdr[0].ToString();
					labelStock.Text = "Stock Qty : "+rdr[2].ToString();
					price = Double.Parse(rdr[1].ToString());
					stockQty = int.Parse(rdr[2].ToString());
				}else{
					MessageBox.Show("Recoed not founded", "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				SQLDataBase.conClose();
			}catch(Exception){
				SQLDataBase.conClose();
				MessageBox.Show("Recoed not founded", "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
				getStock(textBoxpro.Text);
			}
		}
		
		void getId(){
			try{
				SQLDataBase.conOpen();
				SqlCommand get = new SqlCommand("SELECT _id FROM receipt_main ORDER BY _id DESC",SQLDataBase.connection);
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
				label5.Text = new_id.ToString();
				textBoxsupid.Focus();
			}catch(Exception){
				SQLDataBase.conClose();
			}
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			//getStock(textBoxpro.Text.ToString());mQty > stockQty &&
			try{
				int mQty = int.Parse(textBoxqty.Text.ToString());
				if( isNotAdded(textBoxpro.Text.ToString())){
					int n = dataGridView1.Rows.Add();
					dataGridView1.Rows[n].Cells[0].Value = textBoxpro.Text.ToString();
					dataGridView1.Rows[n].Cells[1].Value = comboBoxPro.Text.ToString();
					dataGridView1.Rows[n].Cells[2].Value = textBoxqty.Text.ToString();
					dataGridView1.Rows[n].Cells[3].Value = 
					(mQty * price).ToString();
					addOtherProduct();
					seTotal();
				}else{
					MessageBox.Show("Qty Out of stock OR Already Entered", "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}catch(Exception ){
				//MessageBox.Show("Qty Out of stock OR Already Entered", "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
				textBoxqty.Focus();
			}
		}
		
		Boolean isNotAdded(string id){
			Boolean result = true;
			foreach(DataGridViewRow row in dataGridView1.Rows){
				if(result && row.Cells[0].Value.ToString() == id){
					result = false;
				}
			}			
			return result;
		}
		
		void TextBoxqtyTextChanged(object sender, EventArgs e)
		{
			try{
				textBoxprice.Text = 
					Double.Parse((int.Parse(textBoxqty.Text.ToString()) * price).ToString()).ToString();
			}catch(Exception ){
			
			}		
		}
		
		void addOtherProduct(){
			isAllow = false;
			price = 0.0;
			stockQty = 0;
			textBoxpro.Text = "";
			comboBoxPro.Text = "";
			textBoxqty.Text  = "";
			textBoxprice.Text = "";
			labelStock.Text = "";
			isAllow = true;
			textBoxpro.Focus();
		}
		
		void seTotal(){
			int qty = 0;
			double tPtice = 0.0;
			foreach(DataGridViewRow row in dataGridView1.Rows){
				try{
					qty = qty + int.Parse(row.Cells[2].Value.ToString());
				}catch(Exception){
				
				}
				
				try{
					tPtice = tPtice + double.Parse(row.Cells[3].Value.ToString());
				}catch(Exception){
				
				}
			}
			
			textBox2.Text = qty.ToString();
			textBoxremain.Text = tPtice.ToString();
		}
		
		
		void Button1Click(object sender, EventArgs e)
		{
			Form cusf = new FormCustomer();
			cusf.ShowDialog();	
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			Form prof = new FormProducts();
			prof.ShowDialog();			
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			proList();
			cusList();
			seTotal();
		}
		
		void ButtonnEWClick(object sender, EventArgs e)
		{
			refresh();
		}
		
		void ButtonSaveClick(object sender, EventArgs e)
		{
			saveMain();
		}
		
		
		void saveMain(){
			try{
			string query = "INSERT INTO receipt_main (_id, date, supid, supname, remarks,qtys,price,type,mTime,payAmount,status) VALUES ( @_id, @date, @supid, @supname, @remarks,@qtys,@price,@type,@mTime ,@payAmount,@status)";  
          	SqlCommand cmd = new SqlCommand(query, SQLDataBase.connection);  
          	cmd.Parameters.AddWithValue("@_id", new_id);  
          	cmd.Parameters.AddWithValue("@date", dateTimePicker1.Text);    
          	cmd.Parameters.AddWithValue("@supid", textBoxsupid.Text); 
			cmd.Parameters.AddWithValue("@supname", comboBoxCus.Text);  
			cmd.Parameters.AddWithValue("@remarks", textBoxremarks.Text);
			cmd.Parameters.AddWithValue("@qtys", textBox2.Text);		
			cmd.Parameters.AddWithValue("@price", textBoxremain.Text);
			cmd.Parameters.AddWithValue("@status", comboBox1.Text);	
			cmd.Parameters.AddWithValue("@type", type);				
			cmd.Parameters.AddWithValue("@payAmount", textBox3.Text);					
			cmd.Parameters.AddWithValue("@mTime", DateTime.Now.ToString("hh:mm:ss"));
  			SQLDataBase.conOpen();
            cmd.ExecuteScalar();  
            SQLDataBase.conClose(); 
            saveProducts();
			}catch(Exception ){
			SQLDataBase.conClose();
			MessageBox.Show("Not Saved", "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		void saveProducts(){
			try{
				
				foreach(DataGridViewRow row in dataGridView1.Rows){
					string query = "INSERT INTO RecieptsDetail (recieptId, date, proId, proName,qty,price,id) VALUES (@recieptId, @date, @proId, @proName,@qty,@price,@id)";  
          			SqlCommand cmd = new SqlCommand(query, SQLDataBase.connection);  
          			cmd.Parameters.AddWithValue("@recieptId", new_id);  
          			cmd.Parameters.AddWithValue("@date", dateTimePicker1.Text);    
          			cmd.Parameters.AddWithValue("@proId", row.Cells[0].Value.ToString()); 
					cmd.Parameters.AddWithValue("@proName", row.Cells[1].Value.ToString());  
					cmd.Parameters.AddWithValue("@qty", row.Cells[2].Value.ToString());		
					cmd.Parameters.AddWithValue("@price", row.Cells[3].Value.ToString());	
					cmd.Parameters.AddWithValue("@id", DateTime.Now.ToString());
  					SQLDataBase.conOpen();
            		cmd.ExecuteScalar();  
            		SQLDataBase.conClose();
				}   
				updateStock();
				//refresh();
			MessageBox.Show("Saved" , "Success" , MessageBoxButtons.OK, MessageBoxIcon.Information);            				
			}catch(Exception ){
				SQLDataBase.conClose();
				MessageBox.Show("Not Saved", "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		void updateStock(){
			string query = "INSERT INTO StockOut (_id, inDate, inQty, productId,recieptid) VALUES ( @id,@inDate, @inQty, @productId,@recieptid)";  
          	SqlCommand cmd = new SqlCommand(query, SQLDataBase.connection); 
			cmd.Parameters.AddWithValue("@recieptid", new_id);            	
          	cmd.Parameters.AddWithValue("@inDate", dateTimePicker1.Text);    
          	cmd.Parameters.AddWithValue("@inQty", textBox2.Text); 
			cmd.Parameters.AddWithValue("@productId", textBoxremain.Text); 
			cmd.Parameters.AddWithValue("@id", DateTime.Now.ToString());			
  			SQLDataBase.conOpen();
            cmd.ExecuteScalar();  
            SQLDataBase.conClose(); 
            addReturns();
		}
		
		void addReturns(){
			double tAmount = double.Parse(textBoxremain.Text);
			double payAmount = double.Parse(textBox3.Text);
			if(payAmount < tAmount){
				double reAmount = tAmount - payAmount;
				string query = "INSERT INTO CustomerReturns (addedDate, cus_id, amount, recieptId) VALUES (@addedDate, @cus_id, @amount, @recieptId)";  
          	SqlCommand cmd = new SqlCommand(query, SQLDataBase.connection); 
			cmd.Parameters.AddWithValue("@addedDate", dateTimePicker1.Text);            	
          	cmd.Parameters.AddWithValue("@cus_id", textBoxsupid.Text);    
          	cmd.Parameters.AddWithValue("@amount", reAmount); 
			cmd.Parameters.AddWithValue("@recieptId", new_id); 
  			SQLDataBase.conOpen();
            cmd.ExecuteScalar();  
            SQLDataBase.conClose(); 
			}
		}
		
		void refresh(){
			addOtherProduct();
			textBoxsupid.Text = "";
			comboBoxCus.Text ="";
			textBoxremarks.Text ="";
			textBoxremain.Text = "";
			textBox2.Text= "";
			dataGridView1.Rows.Clear();
			dataGridView2.Rows.Clear();
			getId();
		}
		
		void getStock(string pid){
				SQLDataBase.conOpen();
				SqlCommand get = new SqlCommand("SELECT  retailprice,Stock  FROM View_Product_Stock Where productid ='"+pid+"' ",SQLDataBase.connection);
				SqlDataReader rdr = get.ExecuteReader();
				if(rdr.Read()){
					labelStock.Text = "Stock Qty : "+rdr[1].ToString();
					price = Double.Parse(rdr[0].ToString());
					stockQty = int.Parse(rdr[1].ToString());
				}else{
					//MessageBox.Show("Recoed not founded", "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				SQLDataBase.conClose();
				textBoxpro.Focus();
		}
		
		
		void Button5Click(object sender, EventArgs e)
		{
			printPreviewDialog1.Document =  printDocument1;
			printPreviewDialog1.ShowDialog();			
		}
		
		
		
		void PrintDocument1PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			//new_id.ToString()
			new PrintRepiept("2",e);
		}
		
	}
}
