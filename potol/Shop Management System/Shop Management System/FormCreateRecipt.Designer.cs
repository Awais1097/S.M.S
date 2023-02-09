/*
 * Created by SharpDevelop.
 * User: Dell
 * Date: 2/4/2023
 * Time: 10:00 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Shop_Management_System
{
	partial class FormCreateRecipt
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreateRecipt));
			this.label6 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.label12 = new System.Windows.Forms.Label();
			this.textBoxsupid = new System.Windows.Forms.TextBox();
			this.comboBoxCus = new System.Windows.Forms.ComboBox();
			this.label8 = new System.Windows.Forms.Label();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.textBoxpro = new System.Windows.Forms.TextBox();
			this.comboBoxPro = new System.Windows.Forms.ComboBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxprice = new System.Windows.Forms.TextBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxqty = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.pictureBox9 = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxremarks = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Columnid = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Columnname = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.textBox1 = new System.Windows.Forms.Label();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.textBox2 = new System.Windows.Forms.Label();
			this.buttonSave = new System.Windows.Forms.Button();
			this.buttonnEW = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.label10 = new System.Windows.Forms.Label();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.Column1id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.labelStock = new System.Windows.Forms.Label();
			this.button4 = new System.Windows.Forms.Button();
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
			this.label5 = new System.Windows.Forms.Label();
			this.pictureBox10 = new System.Windows.Forms.PictureBox();
			this.textBoxremain = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
			this.SuspendLayout();
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.label6.BackColor = System.Drawing.Color.SteelBlue;
			this.label6.Font = new System.Drawing.Font("Stencil", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(102, -4);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(904, 103);
			this.label6.TabIndex = 33;
			this.label6.Text = "Create New Receipt";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.SteelBlue;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(0, -3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(109, 102);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 34;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.PictureBox1Click);
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(16, 138);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(227, 20);
			this.dateTimePicker1.TabIndex = 0;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(16, 110);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(25, 25);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 60;
			this.pictureBox2.TabStop = false;
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(44, 112);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(45, 23);
			this.label12.TabIndex = 59;
			this.label12.Text = "Date";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBoxsupid
			// 
			this.textBoxsupid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.textBoxsupid.Location = new System.Drawing.Point(249, 139);
			this.textBoxsupid.Name = "textBoxsupid";
			this.textBoxsupid.Size = new System.Drawing.Size(109, 20);
			this.textBoxsupid.TabIndex = 1;
			this.textBoxsupid.TextChanged += new System.EventHandler(this.TextBoxsupidTextChanged);
			// 
			// comboBoxCus
			// 
			this.comboBoxCus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.comboBoxCus.FormattingEnabled = true;
			this.comboBoxCus.Location = new System.Drawing.Point(364, 138);
			this.comboBoxCus.Name = "comboBoxCus";
			this.comboBoxCus.Size = new System.Drawing.Size(317, 21);
			this.comboBoxCus.TabIndex = 2;
			this.comboBoxCus.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCusSelectedIndexChanged);
			this.comboBoxCus.TextChanged += new System.EventHandler(this.ComboBoxCusTextChanged);
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(282, 112);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(127, 23);
			this.label8.TabIndex = 63;
			this.label8.Text = "Customer";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(249, 112);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(25, 25);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 64;
			this.pictureBox3.TabStop = false;
			// 
			// textBoxpro
			// 
			this.textBoxpro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.textBoxpro.Location = new System.Drawing.Point(12, 239);
			this.textBoxpro.Name = "textBoxpro";
			this.textBoxpro.Size = new System.Drawing.Size(102, 20);
			this.textBoxpro.TabIndex = 4;
			this.textBoxpro.TextChanged += new System.EventHandler(this.TextBoxproTextChanged);
			// 
			// comboBoxPro
			// 
			this.comboBoxPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.comboBoxPro.FormattingEnabled = true;
			this.comboBoxPro.Location = new System.Drawing.Point(122, 238);
			this.comboBoxPro.Name = "comboBoxPro";
			this.comboBoxPro.Size = new System.Drawing.Size(236, 21);
			this.comboBoxPro.TabIndex = 5;
			this.comboBoxPro.SelectedIndexChanged += new System.EventHandler(this.ComboBoxProSelectedIndexChanged);
			this.comboBoxPro.TextChanged += new System.EventHandler(this.ComboBoxProTextChanged);
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(16, 211);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(25, 25);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox4.TabIndex = 68;
			this.pictureBox4.TabStop = false;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(47, 211);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(91, 23);
			this.label2.TabIndex = 67;
			this.label2.Text = "Product";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox5
			// 
			this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
			this.pictureBox5.Location = new System.Drawing.Point(495, 214);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(25, 23);
			this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox5.TabIndex = 74;
			this.pictureBox5.TabStop = false;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(530, 214);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(99, 23);
			this.label4.TabIndex = 73;
			this.label4.Text = "Price";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBoxprice
			// 
			this.textBoxprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.textBoxprice.Location = new System.Drawing.Point(495, 238);
			this.textBoxprice.Name = "textBoxprice";
			this.textBoxprice.Size = new System.Drawing.Size(162, 20);
			this.textBoxprice.TabIndex = 7;
			// 
			// pictureBox6
			// 
			this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
			this.pictureBox6.Location = new System.Drawing.Point(365, 214);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(25, 23);
			this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox6.TabIndex = 72;
			this.pictureBox6.TabStop = false;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(396, 214);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(127, 23);
			this.label1.TabIndex = 71;
			this.label1.Text = "QTY";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBoxqty
			// 
			this.textBoxqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.textBoxqty.Location = new System.Drawing.Point(365, 238);
			this.textBoxqty.Name = "textBoxqty";
			this.textBoxqty.Size = new System.Drawing.Size(124, 20);
			this.textBoxqty.TabIndex = 6;
			this.textBoxqty.TextChanged += new System.EventHandler(this.TextBoxqtyTextChanged);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.Location = new System.Drawing.Point(650, 109);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(31, 23);
			this.button1.TabIndex = 75;
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
			this.button3.Location = new System.Drawing.Point(327, 212);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(31, 23);
			this.button3.TabIndex = 77;
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
			this.button2.Location = new System.Drawing.Point(663, 233);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(18, 23);
			this.button2.TabIndex = 8;
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// pictureBox9
			// 
			this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
			this.pictureBox9.Location = new System.Drawing.Point(13, 161);
			this.pictureBox9.Name = "pictureBox9";
			this.pictureBox9.Size = new System.Drawing.Size(25, 25);
			this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox9.TabIndex = 81;
			this.pictureBox9.TabStop = false;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(44, 161);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(127, 23);
			this.label3.TabIndex = 80;
			this.label3.Text = "Remarks";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBoxremarks
			// 
			this.textBoxremarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.textBoxremarks.Location = new System.Drawing.Point(11, 187);
			this.textBoxremarks.Name = "textBoxremarks";
			this.textBoxremarks.Size = new System.Drawing.Size(670, 20);
			this.textBoxremarks.TabIndex = 3;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Columnid,
									this.Columnname,
									this.ColumnQty,
									this.ColumnPrice});
			this.dataGridView1.Location = new System.Drawing.Point(11, 271);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(670, 303);
			this.dataGridView1.TabIndex = 83;
			// 
			// Columnid
			// 
			this.Columnid.HeaderText = "id";
			this.Columnid.Name = "Columnid";
			this.Columnid.ReadOnly = true;
			// 
			// Columnname
			// 
			this.Columnname.HeaderText = "Products Name";
			this.Columnname.Name = "Columnname";
			this.Columnname.ReadOnly = true;
			this.Columnname.Width = 300;
			// 
			// ColumnQty
			// 
			this.ColumnQty.HeaderText = "Qty";
			this.ColumnQty.Name = "ColumnQty";
			this.ColumnQty.ReadOnly = true;
			// 
			// ColumnPrice
			// 
			this.ColumnPrice.HeaderText = "Price";
			this.ColumnPrice.Name = "ColumnPrice";
			this.ColumnPrice.ReadOnly = true;
			// 
			// pictureBox7
			// 
			this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
			this.pictureBox7.Location = new System.Drawing.Point(197, 579);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(25, 23);
			this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox7.TabIndex = 89;
			this.pictureBox7.TabStop = false;
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(232, 579);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(99, 23);
			this.textBox1.TabIndex = 88;
			this.textBox1.Text = "Pay Amount";
			this.textBox1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox8
			// 
			this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
			this.pictureBox8.Location = new System.Drawing.Point(12, 579);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(25, 23);
			this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox8.TabIndex = 87;
			this.pictureBox8.TabStop = false;
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox2.Location = new System.Drawing.Point(45, 579);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(145, 23);
			this.textBox2.TabIndex = 86;
			this.textBox2.Text = "Total QTY";
			this.textBox2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// buttonSave
			// 
			this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonSave.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave.Image")));
			this.buttonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonSave.Location = new System.Drawing.Point(381, 580);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(92, 47);
			this.buttonSave.TabIndex = 9;
			this.buttonSave.Text = "Save";
			this.buttonSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.ButtonSaveClick);
			// 
			// buttonnEW
			// 
			this.buttonnEW.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonnEW.Image = ((System.Drawing.Image)(resources.GetObject("buttonnEW.Image")));
			this.buttonnEW.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonnEW.Location = new System.Drawing.Point(585, 580);
			this.buttonnEW.Name = "buttonnEW";
			this.buttonnEW.Size = new System.Drawing.Size(97, 47);
			this.buttonnEW.TabIndex = 10;
			this.buttonnEW.Text = "Add New";
			this.buttonnEW.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonnEW.UseVisualStyleBackColor = true;
			this.buttonnEW.Click += new System.EventHandler(this.ButtonnEWClick);
			// 
			// button5
			// 
			this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
			this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button5.Location = new System.Drawing.Point(476, 580);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(105, 47);
			this.button5.TabIndex = 11;
			this.button5.Text = "Print";
			this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.Button5Click);
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label10.Location = new System.Drawing.Point(700, 121);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(127, 23);
			this.label10.TabIndex = 93;
			this.label10.Text = "Result";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dataGridView2
			// 
			this.dataGridView2.AllowUserToAddRows = false;
			this.dataGridView2.AllowUserToDeleteRows = false;
			this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Column1id,
									this.Column1Name,
									this.Column1Price,
									this.Column1Qty});
			this.dataGridView2.Location = new System.Drawing.Point(699, 147);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.ReadOnly = true;
			this.dataGridView2.Size = new System.Drawing.Size(288, 476);
			this.dataGridView2.TabIndex = 94;
			this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView2CellContentClick);
			// 
			// Column1id
			// 
			this.Column1id.HeaderText = "Id";
			this.Column1id.Name = "Column1id";
			this.Column1id.ReadOnly = true;
			this.Column1id.Width = 60;
			// 
			// Column1Name
			// 
			this.Column1Name.HeaderText = "Name";
			this.Column1Name.Name = "Column1Name";
			this.Column1Name.ReadOnly = true;
			this.Column1Name.Width = 170;
			// 
			// Column1Price
			// 
			this.Column1Price.HeaderText = "Price";
			this.Column1Price.Name = "Column1Price";
			this.Column1Price.ReadOnly = true;
			// 
			// Column1Qty
			// 
			this.Column1Qty.HeaderText = "Stock";
			this.Column1Qty.Name = "Column1Qty";
			this.Column1Qty.ReadOnly = true;
			// 
			// labelStock
			// 
			this.labelStock.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelStock.ForeColor = System.Drawing.Color.Maroon;
			this.labelStock.Location = new System.Drawing.Point(123, 215);
			this.labelStock.Name = "labelStock";
			this.labelStock.Size = new System.Drawing.Size(199, 23);
			this.labelStock.TabIndex = 95;
			this.labelStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.button4.FlatAppearance.BorderSize = 0;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
			this.button4.Location = new System.Drawing.Point(663, 211);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(18, 23);
			this.button4.TabIndex = 96;
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.Button4Click);
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
			// label5
			// 
			this.label5.BackColor = System.Drawing.Color.SteelBlue;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label5.Location = new System.Drawing.Point(95, 75);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(127, 23);
			this.label5.TabIndex = 97;
			this.label5.Text = "id";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox10
			// 
			this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
			this.pictureBox10.Location = new System.Drawing.Point(13, 604);
			this.pictureBox10.Name = "pictureBox10";
			this.pictureBox10.Size = new System.Drawing.Size(25, 23);
			this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox10.TabIndex = 99;
			this.pictureBox10.TabStop = false;
			// 
			// textBoxremain
			// 
			this.textBoxremain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxremain.Location = new System.Drawing.Point(46, 604);
			this.textBoxremain.Name = "textBoxremain";
			this.textBoxremain.Size = new System.Drawing.Size(144, 23);
			this.textBoxremain.TabIndex = 98;
			this.textBoxremain.Text = "Total Price";
			this.textBoxremain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBox3
			// 
			this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.textBox3.Location = new System.Drawing.Point(196, 607);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(162, 20);
			this.textBox3.TabIndex = 100;
			// 
			// FormCreateRecipt
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(999, 636);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.pictureBox10);
			this.Controls.Add(this.textBoxremain);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.labelStock);
			this.Controls.Add(this.dataGridView2);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.buttonnEW);
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.pictureBox7);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.pictureBox8);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.pictureBox9);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBoxremarks);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.pictureBox5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBoxprice);
			this.Controls.Add(this.pictureBox6);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxqty);
			this.Controls.Add(this.textBoxpro);
			this.Controls.Add(this.comboBoxPro);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.textBoxsupid);
			this.Controls.Add(this.comboBoxCus);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.pictureBox1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormCreateRecipt";
			this.Text = "FormCreateRecipt";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.FormCreateReciptLoad);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label textBoxremain;
		private System.Windows.Forms.PictureBox pictureBox10;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
		private System.Drawing.Printing.PrintDocument printDocument1;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label labelStock;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1Qty;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1Price;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1Name;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1id;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrice;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQty;
		private System.Windows.Forms.DataGridViewTextBoxColumn Columnname;
		private System.Windows.Forms.DataGridViewTextBoxColumn Columnid;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button buttonnEW;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.Label textBox2;
		private System.Windows.Forms.PictureBox pictureBox8;
		private System.Windows.Forms.Label textBox1;
		private System.Windows.Forms.PictureBox pictureBox7;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox textBoxremarks;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.PictureBox pictureBox9;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBoxqty;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.TextBox textBoxprice;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.ComboBox comboBoxPro;
		private System.Windows.Forms.TextBox textBoxpro;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox comboBoxCus;
		private System.Windows.Forms.TextBox textBoxsupid;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label6;
	}
}
