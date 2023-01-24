/*
 * Created by SharpDevelop.
 * User: Dell
 * Date: 1/15/2023
 * Time: 3:01 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Shop_Management_System
{
	/// <summary>
	/// Description of FormShopInfo.
	/// </summary>
	public partial class FormShopInfo : Form
	{
		string img;
		string logo;
		
		public FormShopInfo()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			getData();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void PictureBox2Click(object sender, EventArgs e)
		{
			OpenFileDialog open = new OpenFileDialog(); 
			open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";  
			if (open.ShowDialog() == DialogResult.OK) {  
    			// display image in picture box  
    		pictureBox2.Image = new Bitmap(open.FileName);  
    		
			}			
		}
		
		void PictureBox3Click(object sender, EventArgs e)
		{
			OpenFileDialog open = new OpenFileDialog(); 
			open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";  
			if (open.ShowDialog() == DialogResult.OK) {  
    			// display image in picture box  
    		pictureBox3.Image = new Bitmap(open.FileName);  
			}			
		}
		
		void ButtonSaveClick(object sender, EventArgs e)
		{
			try{
			string query = "UPDATE UserShopTable SET name =@name , email =@email , shopname =@shopname , address =@address , mobile1 =@mobile1 , mobile2 =@mobile2 , username =@username, password =@password  , image=@image, shoplogo=@shoplogo ,min_target=@min_target,max_target=@max_target  where _id = 1";  
          	SqlCommand cmd = new SqlCommand(query, SQLDataBase.connection);  
          	cmd.Parameters.AddWithValue("@name", textBoxOwnerName.Text);  
          	cmd.Parameters.AddWithValue("@email", textBoxEmail.Text);    
          	cmd.Parameters.AddWithValue("@shopname", textBoxShopName.Text);  
  			cmd.Parameters.AddWithValue("@address",textBoxAddress.Text);  
  			cmd.Parameters.AddWithValue("@mobile1",textBoxMobile.Text); 
			cmd.Parameters.AddWithValue("@mobile2",textBoxMobile2.Text); 
			cmd.Parameters.AddWithValue("@username",textBoxUserName.Text); 
			cmd.Parameters.AddWithValue("@password",textBoxPassword.Text);  
			cmd.Parameters.AddWithValue("@min_target",textBoxMin.Text); 
			cmd.Parameters.AddWithValue("@max_target",textBoxMax.Text);
			string img1= Utilites.ImageToBase64(pictureBox2.Image);
			if(img1 != "Error converting image to base64!"){
				cmd.Parameters.AddWithValue("@image",img1 );
			}else{
				cmd.Parameters.AddWithValue("@image", img);
			}
			
			string img2= Utilites.ImageToBase64(pictureBox3.Image);
			if(img2 != "Error converting image to base64!"){
				cmd.Parameters.AddWithValue("@shoplogo",img2 );
			}else{
				cmd.Parameters.AddWithValue("@shoplogo", logo);
			}
			
  			SQLDataBase.conOpen();
            cmd.ExecuteScalar();  
            SQLDataBase.conClose(); 
			MessageBox.Show("Saved" , "Success" , MessageBoxButtons.OK, MessageBoxIcon.Information);            
			}catch(Exception ){
			SQLDataBase.conClose();
			MessageBox.Show("Not Saved", "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
			}			
		}
		
		void getData(){		
			SQLDataBase.conOpen();
			SqlCommand get = new SqlCommand("SELECT TOP (1) name,password,email,image,shopname,shoplogo,address,mobile1,mobile2,username,min_target,max_target  FROM UserShopTable",SQLDataBase.connection);
			SqlDataReader rdr = get.ExecuteReader();
			if(rdr.Read())
			{
				 textBoxOwnerName.Text = rdr[0].ToString();
				 textBoxPassword.Text = rdr[1].ToString();
				 textBoxEmail.Text = rdr[2].ToString();//3img
				 textBoxShopName.Text = rdr[4].ToString();//5logo
				 textBoxAddress.Text = rdr[6].ToString();
				 textBoxMobile.Text = rdr[7].ToString();
				 textBoxMobile2.Text = rdr[8].ToString();
				 textBoxUserName.Text = rdr[9].ToString();
				 textBoxMin.Text = rdr[10].ToString();
				 textBoxMax.Text = rdr[11].ToString();
				 try{
				 	img = rdr[3].ToString();
				 	logo = rdr[5].ToString();
				 	pictureBox2.Image = Utilites.LoadImage(rdr[3].ToString());
				 	pictureBox3.Image = Utilites.LoadImage(rdr[5].ToString());
				 }catch(Exception){}
			}
			SQLDataBase.conClose();
		}
		
		void TextBoxShopNameTextChanged(object sender, EventArgs e)
		{
			
		}
	}
}
