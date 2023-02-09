/*
 * Created by SharpDevelop.
 * User: Dell
 * Date: 12/17/2022
 * Time: 7:46 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Shop_Management_System
{
	partial class CompanyForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanyForm));
			this.panel1 = new System.Windows.Forms.Panel();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumncCusId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnMobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnRemarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnImg = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnLat = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnLng = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label6 = new System.Windows.Forms.Label();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button3 = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonSave = new System.Windows.Forms.Button();
			this.buttonnEW = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.dataGridView1);
			this.panel1.Location = new System.Drawing.Point(549, 154);
			this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(721, 583);
			this.panel1.TabIndex = 22;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1Paint);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ColumnID,
									this.ColumnName,
									this.ColumncCusId,
									this.ColumnPhone,
									this.ColumnMobile,
									this.ColumnCountry,
									this.ColumnCity,
									this.ColumnAddress,
									this.ColumnRemarks,
									this.ColumnImg,
									this.ColumnLat,
									this.ColumnLng});
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(0, 0);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(721, 583);
			this.dataGridView1.TabIndex = 1;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
			// 
			// ColumnID
			// 
			this.ColumnID.HeaderText = "ID";
			this.ColumnID.Name = "ColumnID";
			this.ColumnID.ReadOnly = true;
			// 
			// ColumnName
			// 
			this.ColumnName.HeaderText = "Name";
			this.ColumnName.Name = "ColumnName";
			this.ColumnName.ReadOnly = true;
			// 
			// ColumncCusId
			// 
			this.ColumncCusId.HeaderText = "CmpId";
			this.ColumncCusId.Name = "ColumncCusId";
			this.ColumncCusId.ReadOnly = true;
			// 
			// ColumnPhone
			// 
			this.ColumnPhone.HeaderText = "Phone";
			this.ColumnPhone.Name = "ColumnPhone";
			this.ColumnPhone.ReadOnly = true;
			// 
			// ColumnMobile
			// 
			this.ColumnMobile.HeaderText = "Mobile";
			this.ColumnMobile.Name = "ColumnMobile";
			this.ColumnMobile.ReadOnly = true;
			// 
			// ColumnCountry
			// 
			this.ColumnCountry.HeaderText = "Country";
			this.ColumnCountry.Name = "ColumnCountry";
			this.ColumnCountry.ReadOnly = true;
			// 
			// ColumnCity
			// 
			this.ColumnCity.HeaderText = "City";
			this.ColumnCity.Name = "ColumnCity";
			this.ColumnCity.ReadOnly = true;
			// 
			// ColumnAddress
			// 
			this.ColumnAddress.HeaderText = "Address";
			this.ColumnAddress.Name = "ColumnAddress";
			this.ColumnAddress.ReadOnly = true;
			// 
			// ColumnRemarks
			// 
			this.ColumnRemarks.HeaderText = "Owner";
			this.ColumnRemarks.Name = "ColumnRemarks";
			this.ColumnRemarks.ReadOnly = true;
			// 
			// ColumnImg
			// 
			this.ColumnImg.HeaderText = "ColumnImg";
			this.ColumnImg.Name = "ColumnImg";
			this.ColumnImg.ReadOnly = true;
			// 
			// ColumnLat
			// 
			this.ColumnLat.HeaderText = "Lat";
			this.ColumnLat.Name = "ColumnLat";
			this.ColumnLat.ReadOnly = true;
			// 
			// ColumnLng
			// 
			this.ColumnLng.HeaderText = "Lng";
			this.ColumnLng.Name = "ColumnLng";
			this.ColumnLng.ReadOnly = true;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.SteelBlue;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(145, 126);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 20;
			this.pictureBox1.TabStop = false;
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.SteelBlue;
			this.label6.Font = new System.Drawing.Font("Stencil", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(143, 0);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(1165, 127);
			this.label6.TabIndex = 19;
			this.label6.Text = "Company";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(12, 27);
			this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(157, 150);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 0;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += new System.EventHandler(this.PictureBox2Click);
			// 
			// textBoxName
			// 
			this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxName.Location = new System.Drawing.Point(187, 69);
			this.textBoxName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(301, 30);
			this.textBoxName.TabIndex = 8;
			this.textBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(228, 31);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(201, 28);
			this.label2.TabIndex = 9;
			this.label2.Text = "Company ID";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(187, 31);
			this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(33, 31);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 10;
			this.pictureBox3.TabStop = false;
			this.pictureBox3.Click += new System.EventHandler(this.PictureBox3Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.Location = new System.Drawing.Point(448, 31);
			this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(41, 28);
			this.button1.TabIndex = 23;
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox2.Location = new System.Drawing.Point(187, 144);
			this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(301, 30);
			this.textBox2.TabIndex = 26;
			this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(228, 106);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(241, 28);
			this.label3.TabIndex = 27;
			this.label3.Text = "Company Name";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(187, 106);
			this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(33, 31);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox4.TabIndex = 28;
			this.pictureBox4.TabStop = false;
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(13, 219);
			this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(229, 30);
			this.textBox1.TabIndex = 29;
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(55, 186);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(169, 28);
			this.label1.TabIndex = 30;
			this.label1.Text = "Phone Number";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox5
			// 
			this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
			this.pictureBox5.Location = new System.Drawing.Point(13, 186);
			this.pictureBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(33, 31);
			this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox5.TabIndex = 31;
			this.pictureBox5.TabStop = false;
			// 
			// textBox3
			// 
			this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox3.Location = new System.Drawing.Point(257, 219);
			this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(229, 30);
			this.textBox3.TabIndex = 32;
			this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(257, 186);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(211, 28);
			this.label4.TabIndex = 33;
			this.label4.Text = "Mobile Number";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBox5
			// 
			this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox5.Location = new System.Drawing.Point(16, 289);
			this.textBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(229, 30);
			this.textBox5.TabIndex = 34;
			this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(57, 256);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(169, 28);
			this.label7.TabIndex = 35;
			this.label7.Text = "Country";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox6
			// 
			this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
			this.pictureBox6.Location = new System.Drawing.Point(16, 256);
			this.pictureBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(33, 31);
			this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox6.TabIndex = 36;
			this.pictureBox6.TabStop = false;
			// 
			// textBox4
			// 
			this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox4.Location = new System.Drawing.Point(260, 289);
			this.textBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(229, 30);
			this.textBox4.TabIndex = 37;
			this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(261, 258);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(211, 28);
			this.label5.TabIndex = 38;
			this.label5.Text = "City";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBox6
			// 
			this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox6.Location = new System.Drawing.Point(16, 367);
			this.textBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(471, 30);
			this.textBox6.TabIndex = 39;
			this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(57, 332);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(169, 28);
			this.label8.TabIndex = 40;
			this.label8.Text = "Address";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox7
			// 
			this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
			this.pictureBox7.Location = new System.Drawing.Point(16, 332);
			this.pictureBox7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(33, 31);
			this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox7.TabIndex = 41;
			this.pictureBox7.TabStop = false;
			// 
			// textBox7
			// 
			this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox7.Location = new System.Drawing.Point(16, 439);
			this.textBox7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(471, 30);
			this.textBox7.TabIndex = 42;
			this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(57, 406);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(169, 28);
			this.label9.TabIndex = 43;
			this.label9.Text = "Owner Name";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox8
			// 
			this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
			this.pictureBox8.Location = new System.Drawing.Point(16, 406);
			this.pictureBox8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(33, 31);
			this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox8.TabIndex = 44;
			this.pictureBox8.TabStop = false;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button3);
			this.groupBox1.Controls.Add(this.buttonDelete);
			this.groupBox1.Controls.Add(this.buttonSave);
			this.groupBox1.Controls.Add(this.buttonnEW);
			this.groupBox1.Controls.Add(this.pictureBox8);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.textBox7);
			this.groupBox1.Controls.Add(this.pictureBox7);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.textBox6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.textBox4);
			this.groupBox1.Controls.Add(this.pictureBox6);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.textBox5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.textBox3);
			this.groupBox1.Controls.Add(this.pictureBox5);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.pictureBox4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.textBox2);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.pictureBox3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.textBoxName);
			this.groupBox1.Controls.Add(this.pictureBox2);
			this.groupBox1.Location = new System.Drawing.Point(19, 144);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox1.Size = new System.Drawing.Size(507, 593);
			this.groupBox1.TabIndex = 21;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Add/Delete Company";
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
			this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button3.Location = new System.Drawing.Point(257, 537);
			this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(231, 36);
			this.button3.TabIndex = 52;
			this.button3.Text = "Update";
			this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// buttonDelete
			// 
			this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonDelete.Image = ((System.Drawing.Image)(resources.GetObject("buttonDelete.Image")));
			this.buttonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonDelete.Location = new System.Drawing.Point(257, 490);
			this.buttonDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(231, 36);
			this.buttonDelete.TabIndex = 51;
			this.buttonDelete.Text = "Delete";
			this.buttonDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonDelete.UseVisualStyleBackColor = true;
			this.buttonDelete.Click += new System.EventHandler(this.ButtonDeleteClick);
			// 
			// buttonSave
			// 
			this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonSave.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave.Image")));
			this.buttonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonSave.Location = new System.Drawing.Point(16, 490);
			this.buttonSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(228, 36);
			this.buttonSave.TabIndex = 49;
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
			this.buttonnEW.Location = new System.Drawing.Point(16, 537);
			this.buttonnEW.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.buttonnEW.Name = "buttonnEW";
			this.buttonnEW.Size = new System.Drawing.Size(228, 36);
			this.buttonnEW.TabIndex = 50;
			this.buttonnEW.Text = "Add New";
			this.buttonnEW.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonnEW.UseVisualStyleBackColor = true;
			this.buttonnEW.Click += new System.EventHandler(this.ButtonnEWClick);
			// 
			// CompanyForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1303, 752);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label6);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "CompanyForm";
			this.Text = "S.M.S";
			this.Load += new System.EventHandler(this.CompanyFormLoad);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLng;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLat;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnImg;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRemarks;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAddress;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCountry;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPhone;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumncCusId;
		private System.Windows.Forms.Button buttonnEW;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCity;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMobile;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.PictureBox pictureBox8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.PictureBox pictureBox7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
	}
}
