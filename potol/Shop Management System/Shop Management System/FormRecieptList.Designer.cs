/*
 * Created by SharpDevelop.
 * User: mohsi
 * Date: 08/02/2023
 * Time: 3:13 pm
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Shop_Management_System
{
	partial class FormRecieptList
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRecieptList));
			this.label6 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
			this.pictureBox8 = new System.Windows.Forms.PictureBox();
			this.label7 = new System.Windows.Forms.Label();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.label5 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Columndate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnSupid = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnSupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnMobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnRemarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label13 = new System.Windows.Forms.Label();
			this.textBoxID = new System.Windows.Forms.TextBox();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
			this.printDocument1 = new System.Drawing.Printing.PrintDocument();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// label6
			// 
			this.label6.BackColor = System.Drawing.Color.SteelBlue;
			this.label6.Font = new System.Drawing.Font("Stencil", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(43, -6);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(1109, 127);
			this.label6.TabIndex = 15;
			this.label6.Text = "Reciepts";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.SteelBlue;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(1, -5);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(145, 126);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 35;
			this.pictureBox1.TabStop = false;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.Location = new System.Drawing.Point(491, 193);
			this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.button1.Name = "button1";
			this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.button1.Size = new System.Drawing.Size(192, 47);
			this.button1.TabIndex = 68;
			this.button1.Text = "Export";
			this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
			this.button2.Location = new System.Drawing.Point(325, 133);
			this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.button2.Name = "button2";
			this.button2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.button2.Size = new System.Drawing.Size(145, 107);
			this.button2.TabIndex = 67;
			this.button2.Text = "VIEW";
			this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// dateTimePicker3
			// 
			this.dateTimePicker3.Location = new System.Drawing.Point(16, 215);
			this.dateTimePicker3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dateTimePicker3.Name = "dateTimePicker3";
			this.dateTimePicker3.Size = new System.Drawing.Size(300, 22);
			this.dateTimePicker3.TabIndex = 66;
			// 
			// pictureBox8
			// 
			this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
			this.pictureBox8.Location = new System.Drawing.Point(15, 182);
			this.pictureBox8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.pictureBox8.Name = "pictureBox8";
			this.pictureBox8.Size = new System.Drawing.Size(33, 31);
			this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox8.TabIndex = 72;
			this.pictureBox8.TabStop = false;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(56, 183);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(121, 28);
			this.label7.TabIndex = 71;
			this.label7.Text = "To Date";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Location = new System.Drawing.Point(16, 155);
			this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(300, 22);
			this.dateTimePicker2.TabIndex = 65;
			// 
			// pictureBox6
			// 
			this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
			this.pictureBox6.Location = new System.Drawing.Point(13, 123);
			this.pictureBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(33, 31);
			this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox6.TabIndex = 70;
			this.pictureBox6.TabStop = false;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(55, 124);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(121, 28);
			this.label5.TabIndex = 69;
			this.label5.Text = "From Date";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// button3
			// 
			this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
			this.button3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.button3.Location = new System.Drawing.Point(905, 133);
			this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(229, 106);
			this.button3.TabIndex = 73;
			this.button3.Text = "Create New";
			this.button3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ColumnID,
									this.Column1Time,
									this.Columndate,
									this.ColumnSupid,
									this.ColumnSupName,
									this.ColumnCity,
									this.ColumnMobile,
									this.ColumnRemarks});
			this.dataGridView1.Location = new System.Drawing.Point(19, 256);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(1119, 479);
			this.dataGridView1.TabIndex = 74;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
			// 
			// ColumnID
			// 
			this.ColumnID.HeaderText = "ID";
			this.ColumnID.Name = "ColumnID";
			this.ColumnID.ReadOnly = true;
			this.ColumnID.Width = 40;
			// 
			// Column1Time
			// 
			this.Column1Time.HeaderText = "Time";
			this.Column1Time.Name = "Column1Time";
			this.Column1Time.ReadOnly = true;
			// 
			// Columndate
			// 
			this.Columndate.HeaderText = "Date";
			this.Columndate.Name = "Columndate";
			this.Columndate.ReadOnly = true;
			// 
			// ColumnSupid
			// 
			this.ColumnSupid.HeaderText = "Cusid";
			this.ColumnSupid.Name = "ColumnSupid";
			this.ColumnSupid.ReadOnly = true;
			// 
			// ColumnSupName
			// 
			this.ColumnSupName.HeaderText = "Customer Name";
			this.ColumnSupName.Name = "ColumnSupName";
			this.ColumnSupName.ReadOnly = true;
			this.ColumnSupName.Width = 200;
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
			// ColumnRemarks
			// 
			this.ColumnRemarks.HeaderText = "Remarks";
			this.ColumnRemarks.Name = "ColumnRemarks";
			this.ColumnRemarks.ReadOnly = true;
			// 
			// label13
			// 
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(532, 129);
			this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(241, 28);
			this.label13.TabIndex = 75;
			this.label13.Text = "Enter ID For Print";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBoxID
			// 
			this.textBoxID.Location = new System.Drawing.Point(491, 162);
			this.textBoxID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.textBoxID.Name = "textBoxID";
			this.textBoxID.Size = new System.Drawing.Size(393, 22);
			this.textBoxID.TabIndex = 76;
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
			this.button4.Location = new System.Drawing.Point(691, 192);
			this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.button4.Name = "button4";
			this.button4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.button4.Size = new System.Drawing.Size(195, 47);
			this.button4.TabIndex = 77;
			this.button4.Text = "PRINT";
			this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.SystemColors.Control;
			this.button5.FlatAppearance.BorderSize = 0;
			this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
			this.button5.Location = new System.Drawing.Point(491, 127);
			this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(41, 28);
			this.button5.TabIndex = 78;
			this.button5.UseVisualStyleBackColor = false;
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
			// printDocument1
			// 
			this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocument1PrintPage);
			// 
			// FormRecieptList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1151, 750);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.textBoxID);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.dateTimePicker3);
			this.Controls.Add(this.pictureBox8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.dateTimePicker2);
			this.Controls.Add(this.pictureBox6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label6);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormRecieptList";
			this.Text = "S.M.S";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Drawing.Printing.PrintDocument printDocument1;
		private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1Time;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.TextBox textBoxID;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRemarks;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSupName;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSupid;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMobile;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCity;
		private System.Windows.Forms.DataGridViewTextBoxColumn Columndate;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.PictureBox pictureBox8;
		private System.Windows.Forms.DateTimePicker dateTimePicker3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
