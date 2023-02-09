/*
 * Created by SharpDevelop.
 * User: Dell
 * Date: 12/18/2022
 * Time: 1:28 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Shop_Management_System
{
	partial class FormStockReport
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStockReport));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label6 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
<<<<<<< HEAD
			this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
=======
>>>>>>> b8c9d1ab660ef9166321cbdd8511d0731c98f8c4
			this.Column1Proid = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1SupId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1SupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridView3 = new System.Windows.Forms.DataGridView();
			this.ColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnSullpier = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.buttonSave = new System.Windows.Forms.Button();
<<<<<<< HEAD
=======
			this.button1 = new System.Windows.Forms.Button();
			this.textBoxpro = new System.Windows.Forms.TextBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.button3 = new System.Windows.Forms.Button();
>>>>>>> b8c9d1ab660ef9166321cbdd8511d0731c98f8c4
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.SteelBlue;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(-1, 1);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(145, 126);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 14;
			this.pictureBox1.TabStop = false;
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.label6.BackColor = System.Drawing.Color.SteelBlue;
			this.label6.Font = new System.Drawing.Font("Stencil", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(143, 1);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(1415, 127);
			this.label6.TabIndex = 13;
			this.label6.Text = "Stock";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Column1Proid,
									this.ColumnName,
									this.Column1SupId,
									this.Column1SupName,
									this.ColumnQty});
<<<<<<< HEAD
			this.dataGridView1.Location = new System.Drawing.Point(16, 171);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(928, 591);
			this.dataGridView1.TabIndex = 15;
			// 
			// ColumnID
			// 
			this.ColumnID.HeaderText = "ID";
			this.ColumnID.Name = "ColumnID";
			this.ColumnID.ReadOnly = true;
			this.ColumnID.Width = 60;
=======
			this.dataGridView1.Location = new System.Drawing.Point(12, 175);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(647, 444);
			this.dataGridView1.TabIndex = 15;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
>>>>>>> b8c9d1ab660ef9166321cbdd8511d0731c98f8c4
			// 
			// Column1Proid
			// 
			this.Column1Proid.HeaderText = "ProId";
			this.Column1Proid.Name = "Column1Proid";
			this.Column1Proid.ReadOnly = true;
			// 
			// ColumnName
			// 
			this.ColumnName.HeaderText = "Product Name";
			this.ColumnName.Name = "ColumnName";
			this.ColumnName.ReadOnly = true;
			this.ColumnName.Width = 200;
			// 
			// Column1SupId
			// 
			this.Column1SupId.HeaderText = "SupId";
			this.Column1SupId.Name = "Column1SupId";
			this.Column1SupId.ReadOnly = true;
			// 
			// Column1SupName
			// 
			this.Column1SupName.HeaderText = "Sup Name";
			this.Column1SupName.Name = "Column1SupName";
			this.Column1SupName.ReadOnly = true;
			// 
			// ColumnQty
			// 
			this.ColumnQty.HeaderText = "STOCK QTY";
			this.ColumnQty.Name = "ColumnQty";
			this.ColumnQty.ReadOnly = true;
			// 
			// dataGridView3
			// 
			this.dataGridView3.AllowUserToAddRows = false;
			this.dataGridView3.AllowUserToDeleteRows = false;
<<<<<<< HEAD
=======
			this.dataGridView3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
>>>>>>> b8c9d1ab660ef9166321cbdd8511d0731c98f8c4
			this.dataGridView3.BackgroundColor = System.Drawing.Color.Gainsboro;
			this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ColumnDate,
									this.Qty,
									this.ColumnSullpier});
<<<<<<< HEAD
			this.dataGridView3.Location = new System.Drawing.Point(956, 247);
			this.dataGridView3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dataGridView3.Name = "dataGridView3";
			this.dataGridView3.ReadOnly = true;
			this.dataGridView3.Size = new System.Drawing.Size(577, 240);
=======
			this.dataGridView3.Location = new System.Drawing.Point(665, 201);
			this.dataGridView3.Name = "dataGridView3";
			this.dataGridView3.ReadOnly = true;
			this.dataGridView3.Size = new System.Drawing.Size(485, 195);
>>>>>>> b8c9d1ab660ef9166321cbdd8511d0731c98f8c4
			this.dataGridView3.TabIndex = 17;
			// 
			// ColumnDate
			// 
			this.ColumnDate.HeaderText = "Date";
			this.ColumnDate.Name = "ColumnDate";
			this.ColumnDate.ReadOnly = true;
			this.ColumnDate.Width = 150;
			// 
			// Qty
			// 
			this.Qty.HeaderText = "Qty";
			this.Qty.Name = "Qty";
			this.Qty.ReadOnly = true;
			// 
			// ColumnSullpier
			// 
			this.ColumnSullpier.HeaderText = "Supplier";
			this.ColumnSullpier.Name = "ColumnSullpier";
			this.ColumnSullpier.ReadOnly = true;
			this.ColumnSullpier.Width = 200;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
			this.label1.Location = new System.Drawing.Point(956, 215);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(320, 28);
=======
			this.label1.Location = new System.Drawing.Point(665, 175);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(240, 23);
>>>>>>> b8c9d1ab660ef9166321cbdd8511d0731c98f8c4
			this.label1.TabIndex = 26;
			this.label1.Text = "In Record";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
			this.label2.Location = new System.Drawing.Point(956, 494);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(320, 28);
=======
			this.label2.Location = new System.Drawing.Point(665, 401);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(240, 23);
>>>>>>> b8c9d1ab660ef9166321cbdd8511d0731c98f8c4
			this.label2.TabIndex = 27;
			this.label2.Text = "Out Record";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.DarkRed;
<<<<<<< HEAD
			this.label3.Location = new System.Drawing.Point(956, 171);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(320, 28);
=======
			this.label3.Location = new System.Drawing.Point(665, 139);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(240, 23);
>>>>>>> b8c9d1ab660ef9166321cbdd8511d0731c98f8c4
			this.label3.TabIndex = 28;
			this.label3.Text = "Selected Product History";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// dataGridView2
			// 
			this.dataGridView2.AllowUserToAddRows = false;
			this.dataGridView2.AllowUserToDeleteRows = false;
<<<<<<< HEAD
=======
			this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left)));
>>>>>>> b8c9d1ab660ef9166321cbdd8511d0731c98f8c4
			this.dataGridView2.BackgroundColor = System.Drawing.Color.Gainsboro;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.dataGridViewTextBoxColumn1,
									this.dataGridViewTextBoxColumn2,
									this.dataGridViewTextBoxColumn3});
<<<<<<< HEAD
			this.dataGridView2.Location = new System.Drawing.Point(956, 522);
			this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.ReadOnly = true;
			this.dataGridView2.Size = new System.Drawing.Size(577, 240);
=======
			this.dataGridView2.Location = new System.Drawing.Point(665, 424);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.ReadOnly = true;
			this.dataGridView2.Size = new System.Drawing.Size(485, 195);
>>>>>>> b8c9d1ab660ef9166321cbdd8511d0731c98f8c4
			this.dataGridView2.TabIndex = 29;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.HeaderText = "Date";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn1.Width = 150;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.HeaderText = "Qty";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn3
			// 
<<<<<<< HEAD
			this.dataGridViewTextBoxColumn3.HeaderText = "Supplier";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			this.dataGridViewTextBoxColumn3.Width = 200;
=======
			this.dataGridViewTextBoxColumn3.HeaderText = "Reciept";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
>>>>>>> b8c9d1ab660ef9166321cbdd8511d0731c98f8c4
			// 
			// buttonSave
			// 
			this.buttonSave.BackColor = System.Drawing.Color.LightSteelBlue;
<<<<<<< HEAD
			this.buttonSave.Location = new System.Drawing.Point(1388, 162);
			this.buttonSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.buttonSave.Size = new System.Drawing.Size(145, 47);
=======
			this.buttonSave.Image = ((System.Drawing.Image)(resources.GetObject("buttonSave.Image")));
			this.buttonSave.Location = new System.Drawing.Point(986, 139);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.buttonSave.Size = new System.Drawing.Size(164, 38);
>>>>>>> b8c9d1ab660ef9166321cbdd8511d0731c98f8c4
			this.buttonSave.TabIndex = 30;
			this.buttonSave.Text = "ADD STOCK";
			this.buttonSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.buttonSave.UseVisualStyleBackColor = true;
			this.buttonSave.Click += new System.EventHandler(this.ButtonSaveClick);
			// 
<<<<<<< HEAD
=======
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
			this.button1.Location = new System.Drawing.Point(871, 139);
			this.button1.Name = "button1";
			this.button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.button1.Size = new System.Drawing.Size(109, 38);
			this.button1.TabIndex = 31;
			this.button1.Text = "Export";
			this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// textBoxpro
			// 
			this.textBoxpro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxpro.Location = new System.Drawing.Point(43, 141);
			this.textBoxpro.Name = "textBoxpro";
			this.textBoxpro.Size = new System.Drawing.Size(479, 22);
			this.textBoxpro.TabIndex = 32;
			this.textBoxpro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBoxpro.TextChanged += new System.EventHandler(this.TextBoxproTextChanged);
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(12, 138);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(25, 25);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 34;
			this.pictureBox3.TabStop = false;
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.LightSteelBlue;
			this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
			this.button3.Location = new System.Drawing.Point(528, 138);
			this.button3.Name = "button3";
			this.button3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.button3.Size = new System.Drawing.Size(131, 26);
			this.button3.TabIndex = 37;
			this.button3.Text = "VIEW ALL";
			this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
>>>>>>> b8c9d1ab660ef9166321cbdd8511d0731c98f8c4
			// FormStockReport
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
			this.ClientSize = new System.Drawing.Size(1549, 777);
=======
			this.ClientSize = new System.Drawing.Size(1162, 631);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.textBoxpro);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.button1);
>>>>>>> b8c9d1ab660ef9166321cbdd8511d0731c98f8c4
			this.Controls.Add(this.buttonSave);
			this.Controls.Add(this.dataGridView2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridView3);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label6);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormStockReport";
			this.Text = "S.M.S";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.TextBox textBoxpro;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1SupName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1SupId;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1Proid;
		private System.Windows.Forms.Button buttonSave;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSullpier;
		private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDate;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridView3;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQty;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
