/*
 * Created by SharpDevelop.
 * User: Dell
 * Date: 12/18/2022
 * Time: 1:28 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Shop_Management_System
{
	/// <summary>
	/// Description of FormStockReport.
	/// </summary>
	public partial class FormStockReport : Form
	{
		public FormStockReport()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
	
		
		void ButtonSaveClick(object sender, EventArgs e)
		{
			Form stockIn = new FormStockIn();
			stockIn.ShowDialog();	
		}
	}
}
