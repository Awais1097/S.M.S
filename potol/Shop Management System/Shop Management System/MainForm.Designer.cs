using System.Windows.Forms;
/*
 * Created by SharpDevelop.
 * User: NASIR
 * Date: 11/15/2022
 * Time: 7:13 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Shop_Management_System
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TreeView treeView1;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSale;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProducts;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTarget;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProgress;
		private System.Windows.Forms.Label labelDate;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.PictureBox pictureBox7;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button5;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Reciept");
			System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Orders");
			System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Stock");
			System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Suppliers");
			System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("Products");
			System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("Customers");
			System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("Companies");
			System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("Categories");
			System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("Brands");
			System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("Racks");
			System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("S.M.S", new System.Windows.Forms.TreeNode[] {
									treeNode27,
									treeNode28,
									treeNode29,
									treeNode30,
									treeNode31,
									treeNode32,
									treeNode33,
									treeNode34,
									treeNode35,
									treeNode36});
			System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("Reciept");
			System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("Sale");
			System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("Stock");
			System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("Short Products");
			System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("Target Vs Achivement");
			System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("Orders");
			System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("Reports", new System.Windows.Forms.TreeNode[] {
									treeNode38,
									treeNode39,
									treeNode40,
									treeNode41,
									treeNode42,
									treeNode43});
			System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("Back up");
			System.Windows.Forms.TreeNode treeNode46 = new System.Windows.Forms.TreeNode("Info");
			System.Windows.Forms.TreeNode treeNode47 = new System.Windows.Forms.TreeNode("Database", new System.Windows.Forms.TreeNode[] {
									treeNode45,
									treeNode46});
			System.Windows.Forms.TreeNode treeNode48 = new System.Windows.Forms.TreeNode("Settings");
			System.Windows.Forms.TreeNode treeNode49 = new System.Windows.Forms.TreeNode("Calculator");
			System.Windows.Forms.TreeNode treeNode50 = new System.Windows.Forms.TreeNode("Log Out");
			System.Windows.Forms.TreeNode treeNode51 = new System.Windows.Forms.TreeNode("Exit");
			System.Windows.Forms.TreeNode treeNode52 = new System.Windows.Forms.TreeNode("Tools", new System.Windows.Forms.TreeNode[] {
									treeNode48,
									treeNode49,
									treeNode50,
									treeNode51});
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.label5 = new System.Windows.Forms.Label();
			this.treeView1 = new System.Windows.Forms.TreeView();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.panel1 = new System.Windows.Forms.Panel();
			this.button5 = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.labelDate = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.ColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnProducts = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnTarget = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnProgress = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
			this.createNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
			this.inStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.stockDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
			this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.brandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.catoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripDropDownButton4 = new System.Windows.Forms.ToolStripDropDownButton();
			this.shortsProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.targetVSAchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripDropDownButton5 = new System.Windows.Forms.ToolStripDropDownButton();
			this.shopInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripDropDownButton6 = new System.Windows.Forms.ToolStripDropDownButton();
			this.backupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.restoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
			this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
			this.SuspendLayout();
			// 
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.SteelBlue;
			this.label5.Font = new System.Drawing.Font("Stencil", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(-1, -1);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(1346, 97);
			this.label5.TabIndex = 2;
			this.label5.Text = "Shop Management System (S.M.S)";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// treeView1
			// 
			this.treeView1.BackColor = System.Drawing.Color.White;
			this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.treeView1.ForeColor = System.Drawing.Color.Black;
			this.treeView1.ImageKey = "shop-icon.png";
			this.treeView1.ImageList = this.imageList1;
			this.treeView1.ItemHeight = 40;
			this.treeView1.Location = new System.Drawing.Point(21, 131);
			this.treeView1.Name = "treeView1";
			treeNode27.ImageKey = "reciept_img_icon.png";
			treeNode27.Name = "Reciept";
			treeNode27.Text = "Reciept";
			treeNode28.ImageKey = "purchase_order_img_icon.png";
			treeNode28.Name = "Orders";
			treeNode28.Text = "Orders";
			treeNode29.ImageKey = "stock_img_icon.png";
			treeNode29.Name = "Stock";
			treeNode29.Text = "Stock";
			treeNode30.ImageKey = "supplier_img_icon.png";
			treeNode30.Name = "Suppliers";
			treeNode30.Text = "Suppliers";
			treeNode31.ImageKey = "product_icon.png";
			treeNode31.Name = "Products";
			treeNode31.Text = "Products";
			treeNode32.ImageKey = "customers_img_icon.png";
			treeNode32.Name = "Customers";
			treeNode32.Text = "Customers";
			treeNode33.ImageKey = "company_img_icon.png";
			treeNode33.Name = "Companies";
			treeNode33.Text = "Companies";
			treeNode34.ImageKey = "caregory_img_icon.png";
			treeNode34.Name = "Categories";
			treeNode34.Text = "Categories";
			treeNode35.ImageKey = "brand_img_icon.png";
			treeNode35.Name = "Brands";
			treeNode35.Text = "Brands";
			treeNode36.ImageKey = "rack_img_icon.png";
			treeNode36.Name = "Racks";
			treeNode36.Text = "Racks";
			treeNode37.ImageKey = "shop-icon.png";
			treeNode37.Name = "S.M.S";
			treeNode37.Text = "S.M.S";
			treeNode38.ImageKey = "reciept_img_icon.png";
			treeNode38.Name = "RecieptReport";
			treeNode38.Text = "Reciept";
			treeNode39.ImageKey = "roday_sale_img_2_icon.png";
			treeNode39.Name = "Sale";
			treeNode39.Text = "Sale";
			treeNode40.ImageKey = "stock_img_icon.png";
			treeNode40.Name = "StockReport";
			treeNode40.Text = "Stock";
			treeNode41.ImageKey = "short_products_img_icon.png";
			treeNode41.Name = "Short Products";
			treeNode41.Text = "Short Products";
			treeNode42.ImageKey = "target_img_icon.png";
			treeNode42.Name = "Target Vs Achivement";
			treeNode42.Text = "Target Vs Achivement";
			treeNode43.ImageKey = "purchase_order_img_icon.png";
			treeNode43.Name = "ReportOrder";
			treeNode43.Text = "Orders";
			treeNode44.ImageKey = "report.png";
			treeNode44.Name = "Reports";
			treeNode44.Text = "Reports";
			treeNode45.ImageKey = "databse_backup_icon_img.png";
			treeNode45.Name = "Back up";
			treeNode45.Text = "Back up";
			treeNode46.ImageKey = "data_gear.png";
			treeNode46.Name = "Info";
			treeNode46.Text = "Info";
			treeNode47.ImageKey = "download (4).jpg";
			treeNode47.Name = "Database";
			treeNode47.Text = "Database";
			treeNode48.ImageKey = "setting_img_icon.png";
			treeNode48.Name = "Settings";
			treeNode48.Text = "Settings";
			treeNode49.ImageKey = "images__9_-removebg-preview.png";
			treeNode49.Name = "Calculator";
			treeNode49.Text = "Calculator";
			treeNode50.ImageKey = "Logout.png";
			treeNode50.Name = "Log Out";
			treeNode50.Text = "Log Out";
			treeNode51.ImageKey = "exit_icon.png";
			treeNode51.Name = "Exit";
			treeNode51.Text = "Exit";
			treeNode52.ImageKey = "download__5_-removebg-preview.png";
			treeNode52.Name = "Tools";
			treeNode52.Text = "Tools";
			this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
									treeNode37,
									treeNode44,
									treeNode47,
									treeNode52});
			this.treeView1.SelectedImageKey = "shop-icon.png";
			this.treeView1.ShowNodeToolTips = true;
			this.treeView1.Size = new System.Drawing.Size(261, 513);
			this.treeView1.TabIndex = 1;
			this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView1AfterSelect);
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "server.png");
			this.imageList1.Images.SetKeyName(1, "report.png");
			this.imageList1.Images.SetKeyName(2, "dashboard_img_icon.png");
			this.imageList1.Images.SetKeyName(3, "stock_img_icon.png");
			this.imageList1.Images.SetKeyName(4, "product_icon.png");
			this.imageList1.Images.SetKeyName(5, "customers_img_icon.png");
			this.imageList1.Images.SetKeyName(6, "company_img_icon.png");
			this.imageList1.Images.SetKeyName(7, "caregory_img_icon.png");
			this.imageList1.Images.SetKeyName(8, "brand_img_icon.png");
			this.imageList1.Images.SetKeyName(9, "rack_img_icon.png");
			this.imageList1.Images.SetKeyName(10, "download (4).jpg");
			this.imageList1.Images.SetKeyName(11, "databse_backup_icon_img.png");
			this.imageList1.Images.SetKeyName(12, "data_gear.png");
			this.imageList1.Images.SetKeyName(13, "setting_img_icon.png");
			this.imageList1.Images.SetKeyName(14, "Logout.png");
			this.imageList1.Images.SetKeyName(15, "exit_icon.png");
			this.imageList1.Images.SetKeyName(16, "sync_img_icon.png");
			this.imageList1.Images.SetKeyName(17, "short_products_img_icon.png");
			this.imageList1.Images.SetKeyName(18, "roday_sale_img_2_icon.png");
			this.imageList1.Images.SetKeyName(19, "today_sale_img_icon.png");
			this.imageList1.Images.SetKeyName(20, "target_img_icon.png");
			this.imageList1.Images.SetKeyName(21, "shop-icon.png");
			this.imageList1.Images.SetKeyName(22, "purchase_order_img_icon.png");
			this.imageList1.Images.SetKeyName(23, "reciept_img_icon.png");
			this.imageList1.Images.SetKeyName(24, "shop_icon_img.png");
			this.imageList1.Images.SetKeyName(25, "images__9_-removebg-preview.png");
			this.imageList1.Images.SetKeyName(26, "download__5_-removebg-preview.png");
			this.imageList1.Images.SetKeyName(27, "supplier_img_icon.png");
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.button5);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.pictureBox6);
			this.panel1.Controls.Add(this.label12);
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.label11);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Location = new System.Drawing.Point(1068, 131);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(261, 513);
			this.panel1.TabIndex = 10;
			// 
			// button5
			// 
			this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
			this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button5.Location = new System.Drawing.Point(25, 399);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(218, 29);
			this.button5.TabIndex = 3;
			this.button5.Text = "Print Today Reciepts (P)";
			this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button5.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button1.Location = new System.Drawing.Point(25, 362);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(217, 29);
			this.button1.TabIndex = 2;
			this.button1.Text = "Create Reciept (C)";
			this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// pictureBox6
			// 
			this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
			this.pictureBox6.Location = new System.Drawing.Point(12, 437);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(66, 64);
			this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox6.TabIndex = 11;
			this.pictureBox6.TabStop = false;
			// 
			// label12
			// 
			this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.label12.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.label12.Location = new System.Drawing.Point(82, 439);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(175, 64);
			this.label12.TabIndex = 10;
			this.label12.Text = "BigSol Software House\r\nAwais ul Hassan (Developer)\r\n+92306-6395565\r\nawaisbagga109" +
			"7@gmail.com ";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label12.UseWaitCursor = true;
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.RoyalBlue;
			this.label10.Location = new System.Drawing.Point(21, 266);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(218, 38);
			this.label10.TabIndex = 4;
			this.label10.Text = "Awais ul Hassan";
			this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label11
			// 
			this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(20, 234);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(218, 30);
			this.label11.TabIndex = 3;
			this.label11.Text = "Aslam-O-Alikum .. !";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(25, 18);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(214, 206);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.SteelBlue;
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel2.Controls.Add(this.pictureBox8);
			this.panel2.Controls.Add(this.label8);
			this.panel2.Controls.Add(this.label9);
			this.panel2.Controls.Add(this.pictureBox5);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(this.pictureBox4);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.pictureBox3);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.pictureBox2);
			this.panel2.Controls.Add(this.labelDate);
			this.panel2.Location = new System.Drawing.Point(304, 131);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(751, 135);
			this.panel2.TabIndex = 11;
			this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel2Paint);
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.White;
			this.label8.Location = new System.Drawing.Point(415, 85);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(132, 19);
			this.label8.TabIndex = 16;
			this.label8.Text = "0%";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.White;
			this.label9.Location = new System.Drawing.Point(450, 60);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(132, 19);
			this.label9.TabIndex = 15;
			this.label9.Text = "Progress";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox5
			// 
			this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
			this.pictureBox5.Location = new System.Drawing.Point(415, 54);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(29, 28);
			this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox5.TabIndex = 14;
			this.pictureBox5.TabStop = false;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(590, 85);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(132, 19);
			this.label6.TabIndex = 13;
			this.label6.Text = "1.0K To 1.5K";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(625, 60);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(132, 19);
			this.label7.TabIndex = 12;
			this.label7.Text = "Target";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(590, 54);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(29, 28);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox4.TabIndex = 11;
			this.pictureBox4.TabStop = false;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(240, 85);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(132, 19);
			this.label3.TabIndex = 10;
			this.label3.Text = "0";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(275, 60);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(132, 19);
			this.label4.TabIndex = 9;
			this.label4.Text = "Produts";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(240, 54);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(29, 28);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 8;
			this.pictureBox3.TabStop = false;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(59, 85);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(132, 19);
			this.label2.TabIndex = 7;
			this.label2.Text = "0";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label2.Click += new System.EventHandler(this.Label2Click);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(94, 60);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(132, 19);
			this.label1.TabIndex = 6;
			this.label1.Text = "Sale";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(59, 54);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(29, 28);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 5;
			this.pictureBox2.TabStop = false;
			// 
			// labelDate
			// 
			this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelDate.ForeColor = System.Drawing.Color.White;
			this.labelDate.Location = new System.Drawing.Point(52, 15);
			this.labelDate.Name = "labelDate";
			this.labelDate.Size = new System.Drawing.Size(546, 23);
			this.labelDate.TabIndex = 4;
			this.labelDate.Text = "Seturday, 19 Nov, 2022";
			this.labelDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.White;
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel3.Controls.Add(this.dataGridView1);
			this.panel3.Location = new System.Drawing.Point(304, 292);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(751, 352);
			this.panel3.TabIndex = 12;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
			this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ColumnDate,
									this.ColumnProducts,
									this.ColumnSale,
									this.ColumnTarget,
									this.ColumnProgress});
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(0, 0);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(749, 350);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
			// 
			// ColumnDate
			// 
			this.ColumnDate.HeaderText = "Date";
			this.ColumnDate.Name = "ColumnDate";
			this.ColumnDate.ReadOnly = true;
			this.ColumnDate.Width = 160;
			// 
			// ColumnProducts
			// 
			this.ColumnProducts.HeaderText = "Products";
			this.ColumnProducts.Name = "ColumnProducts";
			this.ColumnProducts.ReadOnly = true;
			this.ColumnProducts.Width = 190;
			// 
			// ColumnSale
			// 
			this.ColumnSale.HeaderText = "Sale";
			this.ColumnSale.Name = "ColumnSale";
			this.ColumnSale.ReadOnly = true;
			this.ColumnSale.Width = 110;
			// 
			// ColumnTarget
			// 
			this.ColumnTarget.HeaderText = "Target";
			this.ColumnTarget.Name = "ColumnTarget";
			this.ColumnTarget.ReadOnly = true;
			this.ColumnTarget.Width = 110;
			// 
			// ColumnProgress
			// 
			this.ColumnProgress.HeaderText = "Progress";
			this.ColumnProgress.Name = "ColumnProgress";
			this.ColumnProgress.ReadOnly = true;
			this.ColumnProgress.Width = 110;
			// 
			// pictureBox7
			// 
			this.pictureBox7.BackColor = System.Drawing.Color.SteelBlue;
			this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
			this.pictureBox7.Location = new System.Drawing.Point(3, 0);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(101, 95);
			this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox7.TabIndex = 13;
			this.pictureBox7.TabStop = false;
			// 
			// toolStripDropDownButton1
			// 
			this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.createNewToolStripMenuItem,
									this.reportToolStripMenuItem});
			this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
			this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
			this.toolStripDropDownButton1.Size = new System.Drawing.Size(75, 22);
			this.toolStripDropDownButton1.Text = "&Reciept";
			// 
			// createNewToolStripMenuItem
			// 
			this.createNewToolStripMenuItem.Name = "createNewToolStripMenuItem";
			this.createNewToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
			this.createNewToolStripMenuItem.Text = "&Create New";
			this.createNewToolStripMenuItem.Click += new System.EventHandler(this.CreateNewToolStripMenuItemClick);
			// 
			// reportToolStripMenuItem
			// 
			this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
			this.reportToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
			this.reportToolStripMenuItem.Text = "&Report";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripDropDownButton2
			// 
			this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.inStockToolStripMenuItem,
									this.stockDetailToolStripMenuItem});
			this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
			this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
			this.toolStripDropDownButton2.Size = new System.Drawing.Size(65, 22);
			this.toolStripDropDownButton2.Text = "&Stock";
			// 
			// inStockToolStripMenuItem
			// 
			this.inStockToolStripMenuItem.Name = "inStockToolStripMenuItem";
			this.inStockToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
			this.inStockToolStripMenuItem.Text = "&In Stock";
			this.inStockToolStripMenuItem.Click += new System.EventHandler(this.InStockToolStripMenuItemClick);
			// 
			// stockDetailToolStripMenuItem
			// 
			this.stockDetailToolStripMenuItem.Name = "stockDetailToolStripMenuItem";
			this.stockDetailToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
			this.stockDetailToolStripMenuItem.Text = "&Stock Detail";
			this.stockDetailToolStripMenuItem.Click += new System.EventHandler(this.StockDetailToolStripMenuItemClick);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripDropDownButton3
			// 
			this.toolStripDropDownButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.productsToolStripMenuItem,
									this.brandsToolStripMenuItem,
									this.customersToolStripMenuItem,
									this.catoriesToolStripMenuItem});
			this.toolStripDropDownButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton3.Image")));
			this.toolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
			this.toolStripDropDownButton3.Size = new System.Drawing.Size(69, 22);
			this.toolStripDropDownButton3.Text = "&Forms";
			// 
			// productsToolStripMenuItem
			// 
			this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
			this.productsToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
			this.productsToolStripMenuItem.Text = "&Products";
			// 
			// brandsToolStripMenuItem
			// 
			this.brandsToolStripMenuItem.Name = "brandsToolStripMenuItem";
			this.brandsToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
			this.brandsToolStripMenuItem.Text = "&Brands";
			// 
			// customersToolStripMenuItem
			// 
			this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
			this.customersToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
			this.customersToolStripMenuItem.Text = "&Customers";
			// 
			// catoriesToolStripMenuItem
			// 
			this.catoriesToolStripMenuItem.Name = "catoriesToolStripMenuItem";
			this.catoriesToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
			this.catoriesToolStripMenuItem.Text = "C&atories";
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripDropDownButton4
			// 
			this.toolStripDropDownButton4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.shortsProductsToolStripMenuItem,
									this.targetVSAchToolStripMenuItem});
			this.toolStripDropDownButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton4.Image")));
			this.toolStripDropDownButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton4.Name = "toolStripDropDownButton4";
			this.toolStripDropDownButton4.Size = new System.Drawing.Size(76, 22);
			this.toolStripDropDownButton4.Text = "R&eports";
			// 
			// shortsProductsToolStripMenuItem
			// 
			this.shortsProductsToolStripMenuItem.Name = "shortsProductsToolStripMenuItem";
			this.shortsProductsToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
			this.shortsProductsToolStripMenuItem.Text = "&Shorts Products";
			// 
			// targetVSAchToolStripMenuItem
			// 
			this.targetVSAchToolStripMenuItem.Name = "targetVSAchToolStripMenuItem";
			this.targetVSAchToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
			this.targetVSAchToolStripMenuItem.Text = "&Target VS Ach.";
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripDropDownButton5
			// 
			this.toolStripDropDownButton5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.shopInfoToolStripMenuItem});
			this.toolStripDropDownButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton5.Image")));
			this.toolStripDropDownButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton5.Name = "toolStripDropDownButton5";
			this.toolStripDropDownButton5.Size = new System.Drawing.Size(78, 22);
			this.toolStripDropDownButton5.Text = "S&ettings";
			// 
			// shopInfoToolStripMenuItem
			// 
			this.shopInfoToolStripMenuItem.Name = "shopInfoToolStripMenuItem";
			this.shopInfoToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
			this.shopInfoToolStripMenuItem.Text = "&Shop Info.";
			this.shopInfoToolStripMenuItem.Click += new System.EventHandler(this.ShopInfoToolStripMenuItemClick);
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripDropDownButton6
			// 
			this.toolStripDropDownButton6.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.backupToolStripMenuItem,
									this.restoreToolStripMenuItem});
			this.toolStripDropDownButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton6.Image")));
			this.toolStripDropDownButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton6.Name = "toolStripDropDownButton6";
			this.toolStripDropDownButton6.Size = new System.Drawing.Size(84, 22);
			this.toolStripDropDownButton6.Text = "&Database";
			// 
			// backupToolStripMenuItem
			// 
			this.backupToolStripMenuItem.Name = "backupToolStripMenuItem";
			this.backupToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
			this.backupToolStripMenuItem.Text = "&Backup";
			// 
			// restoreToolStripMenuItem
			// 
			this.restoreToolStripMenuItem.Name = "restoreToolStripMenuItem";
			this.restoreToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
			this.restoreToolStripMenuItem.Text = "&Restore";
			// 
			// toolStripSeparator6
			// 
			this.toolStripSeparator6.Name = "toolStripSeparator6";
			this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripButton1
			// 
			this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
			this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripButton1.Name = "toolStripButton1";
			this.toolStripButton1.Size = new System.Drawing.Size(46, 22);
			this.toolStripButton1.Text = "E&xit";
			this.toolStripButton1.Click += new System.EventHandler(this.ToolStripButton1Click);
			// 
			// toolStripSeparator7
			// 
			this.toolStripSeparator7.Name = "toolStripSeparator7";
			this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
			// 
			// toolStripLabel1
			// 
			this.toolStripLabel1.Name = "toolStripLabel1";
			this.toolStripLabel1.Size = new System.Drawing.Size(0, 22);
			// 
			// toolStrip1
			// 
			this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.toolStripDropDownButton1,
									this.toolStripSeparator1,
									this.toolStripDropDownButton2,
									this.toolStripSeparator2,
									this.toolStripDropDownButton3,
									this.toolStripSeparator3,
									this.toolStripDropDownButton4,
									this.toolStripSeparator4,
									this.toolStripDropDownButton5,
									this.toolStripSeparator5,
									this.toolStripDropDownButton6,
									this.toolStripSeparator6,
									this.toolStripButton1,
									this.toolStripSeparator7,
									this.toolStripLabel1});
			this.toolStrip1.Location = new System.Drawing.Point(2, 99);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(547, 25);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// printDocument1
			// 
			this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1PrintPage);
			// 
			// printPreviewDialog1
			// 
			this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
			this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
			this.printPreviewDialog1.Enabled = true;
			this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
			this.printPreviewDialog1.Name = "printPreviewDialog1";
			this.printPreviewDialog1.Visible = false;
			// 
			// pictureBox8
			// 
			this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
			this.pictureBox8.Location = new System.Drawing.Point(708, 10);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(29, 28);
			this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox8.TabIndex = 17;
			this.pictureBox8.TabStop = false;
			this.pictureBox8.Click += new System.EventHandler(this.PictureBox8Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(1343, 679);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.pictureBox7);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.treeView1);
			this.Controls.Add(this.label5);
			this.Name = "MainForm";
			this.Text = "Shop Management System";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.PictureBox pictureBox8;
		private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
		private System.Drawing.Printing.PrintDocument printDocument1;
		private System.Windows.Forms.ToolStripLabel toolStripLabel1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
		private System.Windows.Forms.ToolStripButton toolStripButton1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
		private System.Windows.Forms.ToolStripMenuItem restoreToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem backupToolStripMenuItem;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton6;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
		private System.Windows.Forms.ToolStripMenuItem shopInfoToolStripMenuItem;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton5;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripMenuItem targetVSAchToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem shortsProductsToolStripMenuItem;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton4;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem catoriesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem brandsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton3;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem stockDetailToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem inStockToolStripMenuItem;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem createNewToolStripMenuItem;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
		private System.Windows.Forms.ToolStrip toolStrip1;
		
		void CreateNewToolStripMenuItemClick(object sender, System.EventArgs e)
		{
				Form form = new FormCreateRecipt(Utilites.RECIEPT);
			form.ShowDialog();				
		}
		
		void InStockToolStripMenuItemClick(object sender, System.EventArgs e)
		{
			Form stockIn = new FormStockIn();
			stockIn.ShowDialog();			
		}
		
		void StockDetailToolStripMenuItemClick(object sender, System.EventArgs e)
		{
			Form stockReportForm = new FormStockReport();
					stockReportForm.ShowDialog();			
		}
	}
}
