/*
 * Created by SharpDevelop.
 * User: Dell
 * Date: 2/12/2023
 * Time: 10:46 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Shop_Management_System
{
	partial class FormTargetAch
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTargetAch));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label6 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.ColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnProducts = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnTarget = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnProgress = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.SteelBlue;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(-5, -2);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(109, 102);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 20;
			this.pictureBox1.TabStop = false;
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.label6.BackColor = System.Drawing.Color.SteelBlue;
			this.label6.Font = new System.Drawing.Font("Stencil", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(-5, -2);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(761, 103);
			this.label6.TabIndex = 19;
			this.label6.Text = "Target Vs Achivement";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
									| System.Windows.Forms.AnchorStyles.Left) 
									| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
			this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.ColumnDate,
									this.ColumnProducts,
									this.ColumnSale,
									this.ColumnTarget,
									this.ColumnProgress});
			this.dataGridView1.Location = new System.Drawing.Point(12, 118);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(723, 485);
			this.dataGridView1.TabIndex = 21;
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
			// FormTargetAch
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(753, 615);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label6);
			this.MinimizeBox = false;
			this.Name = "FormTargetAch";
			this.Text = "FormTargetAch";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProgress;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTarget;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSale;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProducts;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDate;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}
