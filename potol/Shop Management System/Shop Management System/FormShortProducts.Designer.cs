/*
 * Created by SharpDevelop.
 * User: Dell
 * Date: 2/12/2023
 * Time: 10:30 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Shop_Management_System
{
	partial class FormShortProducts
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormShortProducts));
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.Column1Proid = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1SupId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column1SupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label6 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.Column1Proid,
									this.ColumnName,
									this.Column1SupId,
									this.Column1SupName,
									this.ColumnQty});
			this.dataGridView1.Location = new System.Drawing.Point(18, 118);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(647, 515);
			this.dataGridView1.TabIndex = 16;
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
			this.Column1SupId.HeaderText = "Comany";
			this.Column1SupId.Name = "Column1SupId";
			this.Column1SupId.ReadOnly = true;
			this.Column1SupId.Width = 200;
			// 
			// Column1SupName
			// 
			this.Column1SupName.HeaderText = "Rack";
			this.Column1SupName.Name = "Column1SupName";
			this.Column1SupName.ReadOnly = true;
			// 
			// ColumnQty
			// 
			this.ColumnQty.HeaderText = "STOCK QTY";
			this.ColumnQty.Name = "ColumnQty";
			this.ColumnQty.ReadOnly = true;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.SteelBlue;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(-2, -3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(109, 102);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 18;
			this.pictureBox1.TabStop = false;
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.label6.BackColor = System.Drawing.Color.SteelBlue;
			this.label6.Font = new System.Drawing.Font("Stencil", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(-2, -3);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(686, 103);
			this.label6.TabIndex = 17;
			this.label6.Text = "Stock";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label6.Click += new System.EventHandler(this.Label6Click);
			// 
			// FormShortProducts
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(683, 645);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.dataGridView1);
			this.MinimizeBox = false;
			this.Name = "FormShortProducts";
			this.Text = "S.M.S";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQty;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1SupName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1SupId;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1Proid;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}
