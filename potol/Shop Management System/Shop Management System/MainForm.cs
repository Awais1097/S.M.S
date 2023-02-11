/*
 * Created by SharpDevelop.
 * User: NASIR
 * Date: 11/15/2022
 * Time: 7:13 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Shop_Management_System
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			getData();
			treeView1.ExpandAll();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			labelDate.Text = DateTime.Now.ToString("dd MMMM , yyyy");
			toolStripLabel1.Text = "Login Time: "+ DateTime.Now.ToString("hh:mm:ss , dd MMMM , yyyy");
		}
		
		void getData(){		
			SQLDataBase.conOpen();
			SqlCommand get = new SqlCommand("SELECT TOP (1) name,password,email,image,shopname,shoplogo,address,mobile1,mobile2,username,min_target,max_target  FROM UserShopTable",SQLDataBase.connection);
			SqlDataReader rdr = get.ExecuteReader();
			if(rdr.Read())
			{
				 label10.Text = rdr[0].ToString();
				 label5.Text = rdr[4].ToString() + " (SMS)";//5logo
				 label6.Text = rdr[10].ToString() +" To "+ rdr[11].ToString();
				 try{
				 	pictureBox1.Image = Utilites.LoadImage(rdr[3].ToString());
				 }catch(Exception){}
				 
				 try{
				 	pictureBox7.Image = Utilites.LoadImage(rdr[5].ToString());
				 }catch(Exception){}
			}
			SQLDataBase.conClose();
			getProgress();
		}
		
		void getProgress(){		
			SQLDataBase.conOpen();
			SqlCommand get = new SqlCommand("select * from ViewProgress where date = '"+DateTime.Now.ToString("yyyy-MM-dd")+"'",SQLDataBase.connection);
			SqlDataReader rdr = get.ExecuteReader();
			if(rdr.Read())
			{
				 label2.Text = rdr[0].ToString()+ "+";
				 label3.Text = rdr[1].ToString() + "+";
				 label8.Text = rdr[3].ToString() +"%";
			}
			SQLDataBase.conClose();
			getAllProgresss();
		}
		
		void getAllProgresss(){
		try{
			SQLDataBase.conOpen();
			SqlCommand get = new SqlCommand("select TOP (100) * from ViewProgress order by date DESC",SQLDataBase.connection);
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
				dataGridView1.Rows[n].Cells[3].Value = dr[3].ToString();
			}
		
			SQLDataBase.conClose();
			}catch(Exception){
			SQLDataBase.conClose();
			}
		
		}
		void Label2Click(object sender, EventArgs e)
		{
	
		}
		void Panel2Paint(object sender, PaintEventArgs e)
		{
	
		}
		protected override bool ProcessCmdKey(ref Message msg, Keys keyData){
			switch (keyData) {
				case Keys.C:
					Form form = new FormCreateRecipt(Utilites.RECIEPT);
					form.ShowDialog();
					break;
				case Keys.P:
					MessageBox.Show("Press Key P","Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
					break;
			}
			return true;
		}
		void TreeView1AfterSelect(object sender, TreeViewEventArgs e)
		{
			string item = treeView1.SelectedNode.Name;
			switch (item) {
				case "Exit":
					Application.Exit();
					break;
				case "Racks":
					Form rackForm = new FormRacks();
					rackForm.ShowDialog();
					break;
				case "Brands":
					Form brandForm = new FormBrands();
					brandForm.ShowDialog();
					break;
				case "Categories":
					Form categoryForm = new FormCategory();
					categoryForm.ShowDialog();
					break;
				case "Log Out":
					Form df = new FormLogIn();
					this.Hide();
					df.Show();
					break;
				case "Companies":
					Form compf = new CompanyForm();
					compf.ShowDialog();
					break;
				case "Customers":
					Form cusf = new FormCustomer();
					cusf.ShowDialog();
					break;
				case "Suppliers":
					Form supf = new FormSupplier();
					supf.ShowDialog();
					break;
				case "Products":
					Form prof = new FormProducts();
					prof.ShowDialog();
					break;
				case "Stock":
					Form stockReportForm = new FormStockReport();
					stockReportForm.ShowDialog();
					break;
				case "Settings":
					Form settingReportForm = new FormShopInfo();
					settingReportForm.ShowDialog();
					break;
				case "RecieptReport":
					Form recListForm = new FormRecieptList(Utilites.RECIEPT);
					recListForm .ShowDialog();
					break;
				case "Reciept":
					Form racForm = new FormCreateRecipt(Utilites.RECIEPT);
					racForm.ShowDialog();
					break;
				case "Orders":
					Form orderForm = new FormCreateRecipt(Utilites.ORDER);
					orderForm.ShowDialog();
					break;
				case "ReportOrder":
					Form ordListForm = new FormRecieptList(Utilites.ORDER);
					ordListForm .ShowDialog();
					break;
				case "Calculator":
					try {
						System.Diagnostics.Process p = null;
						if (p == null) {
							p = new System.Diagnostics.Process();
							p.StartInfo.FileName = "Calc.exe";
							p.Start();
						} else {
							p.Close();
							p.Dispose();
						}
					} catch (Exception) {
						MessageBox.Show("Excepton" + e);
					}
					break;
				case "Back up":
					try{
						string query = "BACKUP DATABASE ShopDataBase TO DISK = 'C:\\Backup\\ShopDataBase-"+DateTime.Now.ToString("ddMMMMyyyy") + ".bak'";  
						SqlCommand cmd = new SqlCommand(query,SQLDataBase.getConnection());
						SQLDataBase.conOpen();
						cmd.ExecuteScalar();
						SQLDataBase.conClose();  
            			MessageBox.Show("Update Dateabse BackUp Successsfully..! ","Infromation", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}catch(Exception){
						SQLDataBase.conClose();
						MessageBox.Show("Update Dateabse BackUp Not Successsfully..!  ","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					break;
			}
			//treeView1.SelectedNode = this.treeView1.Nodes[0];
		}
		void Button1Click(object sender, EventArgs e)
		{
			Form form = new FormCreateRecipt(Utilites.RECIEPT);
			form.ShowDialog();	
		}
		
		void ToolStripButton1Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}
		
		void ShopInfoToolStripMenuItemClick(object sender, EventArgs e)
		{
				Form form = new FormShopInfo();
				form.ShowDialog();	
		}
		
		void PrintDocument1PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{

		}
		
		void Button2Click(object sender, EventArgs e)
		{
						
		}
		
		void Label13Click(object sender, EventArgs e)
		{
			
		}
		
		void PictureBox8Click(object sender, EventArgs e)
		{
			
			getData();
		}
	}
	
}
