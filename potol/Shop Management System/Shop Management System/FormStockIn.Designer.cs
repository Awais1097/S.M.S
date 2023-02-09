/*
 * Created by SharpDevelop.
 * User: Dell
 * Date: 12/18/2022
 * Time: 1:06 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Shop_Management_System
{
	partial class FormStockIn
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStockIn));
			this.comboBox4 = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxprice = new System.Windows.Forms.TextBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxqty = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.pictureBox9 = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxremarks = new System.Windows.Forms.TextBox();
			this.textBoxsupid = new System.Windows.Forms.TextBox();
			this.textBoxpro = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonSave = new System.Windows.Forms.Button();
			this.buttonnEW = new System.Windows.Forms.Button();
			this.comboBoxPro = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.label7 = new System.Windows.Forms.Label();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.label5 = new System.Windows.Forms.Label();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.label12 = new System.Windows.Forms.Label();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Columndate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Columnproid = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnMobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnSupid = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnSupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnRemarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// comboBox4
			// 
			this.comboBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.comboBox4.FormattingEnabled = true;
			this.comboBox4.Location = new System.Drawing.Point(115, 261);
			this.comboBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.comboBox4.Name = "comboBox4";
			this.comboBox4.Size = new System.Drawing.Size(372, 25);
			this.comboBox4.TabIndex = 6;
			this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.ComboBox4SelectedIndexChanged);
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.SteelBlue;
			this.label6.Font = new System.Drawing.Font("Stencil", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(143, 0);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(1099, 127);
			this.label6.TabIndex = 35;
			this.label6.Text = "Stock In";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureBox7
			// 
			this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
			this.pictureBox7.Location = new System.Drawing.Point(15, 228);
			this.pictureBox7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(33, 31);
			this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox7.TabIndex = 41;
			this.pictureBox7.TabStop = false;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(56, 230);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(169, 28);
			this.label8.TabIndex = 40;
			this.label8.Text = "Supplier";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(304, 169);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(164, 28);
			this.label4.TabIndex = 33;
			this.label4.Text = "Price";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBoxprice
			// 
			this.textBoxprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.textBoxprice.Location = new System.Drawing.Point(257, 198);
			this.textBoxprice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBoxprice.Name = "textBoxprice";
			this.textBoxprice.Size = new System.Drawing.Size(229, 23);
			this.textBoxprice.TabIndex = 4;
			this.textBoxprice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// pictureBox5
			// 
			this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
			this.pictureBox5.Location = new System.Drawing.Point(13, 169);
			this.pictureBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(33, 28);
			this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox5.TabIndex = 31;
			this.pictureBox5.TabStop = false;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(55, 169);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(169, 28);
			this.label1.TabIndex = 30;
			this.label1.Text = "QTY";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBoxqty
			// 
			this.textBoxqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.textBoxqty.Location = new System.Drawing.Point(13, 198);
			this.textBoxqty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBoxqty.Name = "textBoxqty";
			this.textBoxqty.Size = new System.Drawing.Size(229, 23);
			this.textBoxqty.TabIndex = 3;
			this.textBoxqty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.pictureBox9);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.textBoxremarks);
			this.groupBox1.Controls.Add(this.textBoxsupid);
			this.groupBox1.Controls.Add(this.textBoxpro);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.buttonDelete);
			this.groupBox1.Controls.Add(this.buttonSave);
			this.groupBox1.Controls.Add(this.buttonnEW);
			this.groupBox1.Controls.Add(this.comboBoxPro);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.dateTimePicker3);
			this.groupBox1.Controls.Add(this.pictureBox8);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.dateTimePicker2);
			this.groupBox1.Controls.Add(this.pictureBox6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.pictureBox4);
			this.groupBox1.Controls.Add(this.dateTimePicker1);
			this.groupBox1.Controls.Add(this.pictureBox2);
			this.groupBox1.Controls.Add(this.label12);
			this.groupBox1.Controls.Add(this.comboBox4);
			this.groupBox1.Controls.Add(this.pictureBox7);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.textBoxprice);
			this.groupBox1.Controls.Add(this.pictureBox5);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.textBoxqty);
			this.groupBox1.Controls.Add(this.pictureBox3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(19, 144);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox1.Size = new System.Drawing.Size(507, 647);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Add/Delete Product";
			// 
			// pictureBox9
			// 
			this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
			this.pictureBox9.Location = new System.Drawing.Point(17, 290);
			this.pictureBox9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.pictureBox9.Name = "pictureBox9";
			this.pictureBox9.Size = new System.Drawing.Size(33, 31);
			this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox9.TabIndex = 70;
			this.pictureBox9.TabStop = false;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(59, 290);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(169, 28);
			this.label3.TabIndex = 69;
			this.label3.Text = "Remarks";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBoxremarks
			// 
			this.textBoxremarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.textBoxremarks.Location = new System.Drawing.Point(15, 322);
			this.textBoxremarks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBoxremarks.Name = "textBoxremarks";
			this.textBoxremarks.Size = new System.Drawing.Size(472, 23);
			this.textBoxremarks.TabIndex = 7;
			// 
			// textBoxsupid
			// 
			this.textBoxsupid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.textBoxsupid.Location = new System.Drawing.Point(12, 262);
			this.textBoxsupid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBoxsupid.Name = "textBoxsupid";
			this.textBoxsupid.Size = new System.Drawing.Size(95, 23);
			this.textBoxsupid.TabIndex = 5;
			this.textBoxsupid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBoxsupid.TextChanged += new System.EventHandler(this.TextBoxsupidTextChanged);
			// 
			// textBoxpro
			// 
			this.textBoxpro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.textBoxpro.Location = new System.Drawing.Point(12, 139);
			this.textBoxpro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBoxpro.Name = "textBoxpro";
			this.textBoxpro.Size = new System.Drawing.Size(95, 23);
			this.textBoxpro.TabIndex = 1;
			this.textBoxpro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBoxpro.TextChanged += new System.EventHandler(this.TextBox2TextChanged);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.Location = new System.Drawing.Point(184, 583);
			this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.button1.Name = "button1";
			this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.button1.Size = new System.Drawing.Size(145, 47);
			this.button1.TabIndex = 14;
			this.button1.Text = "Export";
			this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// buttonDelete
			// 
			this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonDelete.Image = ((System.Drawing.Image)(resources.GetObject("buttonDelete.Image")));
			this.buttonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.buttonDelete.Location = new System.Drawing.Point(347, 358);
			this.buttonDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(137, 36);
			this.buttonDelete.TabIndex = 10;
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
			this.buttonSave.Location = new System.Drawing.Point(12, 358);
			this.buttonSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(147, 36);
			this.buttonSave.TabIndex = 8;
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
			this.buttonnEW.Location = new System.Drawing.Point(175, 358);
			this.buttonnEW.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.buttonnEW.Name = "buttonnEW";
			this.buttonnEW.Size = new System.Drawing.Size(159, 36);
			this.buttonnEW.TabIndex = 9;
			this.buttonnEW.Text = "Add New";
			this.buttonnEW.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonnEW.UseVisualStyleBackColor = true;
			this.buttonnEW.Click += new System.EventHandler(this.ButtonnEWClick);
			// 
			// comboBoxPro
			// 
			this.comboBoxPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.comboBoxPro.FormattingEnabled = true;
			this.comboBoxPro.Location = new System.Drawing.Point(115, 139);
			this.comboBoxPro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.comboBoxPro.Name = "comboBoxPro";
			this.comboBoxPro.Size = new System.Drawing.Size(372, 25);
			this.comboBoxPro.TabIndex = 2;
			this.comboBoxPro.SelectedIndexChanged += new System.EventHandler(this.ComboBoxProSelectedIndexChanged);
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(15, 404);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(121, 28);
			this.label9.TabIndex = 67;
			this.label9.Text = "Report";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
			this.button2.Location = new System.Drawing.Point(337, 583);
			this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.button2.Name = "button2";
			this.button2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.button2.Size = new System.Drawing.Size(145, 47);
			this.button2.TabIndex = 13;
			this.button2.Text = "VIEW";
			this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// dateTimePicker3
			// 
			this.dateTimePicker3.Location = new System.Drawing.Point(15, 548);
			this.dateTimePicker3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dateTimePicker3.Name = "dateTimePicker3";
			this.dateTimePicker3.Size = new System.Drawing.Size(463, 22);
			this.dateTimePicker3.TabIndex = 12;
			// 
			// pictureBox8
			// 
			this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
			this.pictureBox8.Location = new System.Drawing.Point(16, 511);
			this.pictureBox8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(33, 31);
			this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox8.TabIndex = 64;
			this.pictureBox8.TabStop = false;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(57, 512);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(121, 28);
			this.label7.TabIndex = 63;
			this.label7.Text = "To Date";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Location = new System.Drawing.Point(15, 478);
			this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(463, 22);
			this.dateTimePicker2.TabIndex = 11;
			this.dateTimePicker2.ValueChanged += new System.EventHandler(this.DateTimePicker2ValueChanged);
			// 
			// pictureBox6
			// 
			this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
			this.pictureBox6.Location = new System.Drawing.Point(16, 441);
			this.pictureBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(33, 31);
			this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox6.TabIndex = 61;
			this.pictureBox6.TabStop = false;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(57, 442);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(121, 28);
			this.label5.TabIndex = 60;
			this.label5.Text = "From Date";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(257, 169);
			this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(33, 28);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox4.TabIndex = 59;
			this.pictureBox4.TabStop = false;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(12, 75);
			this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(475, 22);
			this.dateTimePicker1.TabIndex = 0;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(13, 38);
			this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(33, 31);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 57;
			this.pictureBox2.TabStop = false;
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(55, 39);
			this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(121, 28);
			this.label12.TabIndex = 56;
			this.label12.Text = "Date";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(13, 105);
			this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(33, 31);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 10;
			this.pictureBox3.TabStop = false;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(55, 105);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(121, 28);
			this.label2.TabIndex = 9;
			this.label2.Text = "Product";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ColumnID,
									this.Columndate,
									this.Columnproid,
									this.ColumnName,
									this.ColumnCity,
									this.ColumnMobile,
									this.ColumnSupid,
									this.ColumnSupName,
									this.ColumnRemarks});
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(0, 0);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(673, 608);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
			// 
			// ColumnID
			// 
			this.ColumnID.HeaderText = "ID";
			this.ColumnID.Name = "ColumnID";
			this.ColumnID.ReadOnly = true;
			this.ColumnID.Width = 40;
			// 
			// Columndate
			// 
			this.Columndate.HeaderText = "In Date";
			this.Columndate.Name = "Columndate";
			this.Columndate.ReadOnly = true;
			// 
			// Columnproid
			// 
			this.Columnproid.HeaderText = "Proid";
			this.Columnproid.Name = "Columnproid";
			this.Columnproid.ReadOnly = true;
			// 
			// ColumnName
			// 
			this.ColumnName.HeaderText = "Name";
			this.ColumnName.Name = "ColumnName";
			this.ColumnName.ReadOnly = true;
			// 
			// ColumnCity
			// 
			this.ColumnCity.HeaderText = "QTY";
			this.ColumnCity.Name = "ColumnCity";
			this.ColumnCity.ReadOnly = true;
			// 
			// ColumnMobile
			// 
			this.ColumnMobile.HeaderText = "Price";
			this.ColumnMobile.Name = "ColumnMobile";
			this.ColumnMobile.ReadOnly = true;
			// 
			// ColumnSupid
			// 
			this.ColumnSupid.HeaderText = "Supid";
			this.ColumnSupid.Name = "ColumnSupid";
			this.ColumnSupid.ReadOnly = true;
			// 
			// ColumnSupName
			// 
			this.ColumnSupName.HeaderText = "Sup Name";
			this.ColumnSupName.Name = "ColumnSupName";
			this.ColumnSupName.ReadOnly = true;
			// 
			// ColumnRemarks
			// 
			this.ColumnRemarks.HeaderText = "Remarks";
			this.ColumnRemarks.Name = "ColumnRemarks";
			this.ColumnRemarks.ReadOnly = true;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.dataGridView1);
			this.panel1.Location = new System.Drawing.Point(549, 154);
			this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(673, 608);
			this.panel1.TabIndex = 38;
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
			this.pictureBox1.TabIndex = 36;
			this.pictureBox1.TabStop = false;
			// 
			// FormStockIn
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1240, 806);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pictureBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormStockIn";
			this.Text = "S.M.S";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRemarks;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSupName;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSupid;
		private System.Windows.Forms.DataGridViewTextBoxColumn Columnproid;
		private System.Windows.Forms.DataGridViewTextBoxColumn Columndate;
		private System.Windows.Forms.TextBox textBoxremarks;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.PictureBox pictureBox9;
		private System.Windows.Forms.TextBox textBoxpro;
		private System.Windows.Forms.TextBox textBoxsupid;
		private System.Windows.Forms.Button buttonnEW;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.ComboBox comboBoxPro;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.PictureBox pictureBox8;
		private System.Windows.Forms.DateTimePicker dateTimePicker3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCity;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMobile;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox textBoxqty;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.TextBox textBoxprice;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.PictureBox pictureBox7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox comboBox4;
	}
}
