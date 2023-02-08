/*
 * Created by SharpDevelop.
 * User: mohsi
 * Date: 08/02/2023
 * Time: 9:50 am
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Shop_Management_System
{
	/// <summary>
	/// Description of PrintRepiept.
	/// </summary>
	public class PrintRepiept
	{
		string rid;
		Reciept reciept;
		System.Drawing.Printing.PrintPageEventArgs e;
		ShopInfo shopInfo;
		int numberOfItemsPerPage = 0;  
		int numberOfItemsPrintedSoFar = 0; 
		const string TOP_LEFT_JOINT = "┌";
    	const string TOP_RIGHT_JOINT = "┐";
    	const string BOTTOM_LEFT_JOINT = "└";
    	const string BOTTOM_RIGHT_JOINT = "┘";
    	const string TOP_JOINT = "┬";
    	const string BOTTOM_JOINT = "┴";
    	const string LEFT_JOINT = "├";
    	const string JOINT = "┼";
    	const string RIGHT_JOINT = "┤";
    	const char HORIZONTAL_LINE = '─';
    	const char PADDING = ' ';
    	const string VERTICAL_LINE = "│";
    	List<string[]> table = new List<string[]>();
		 
		public PrintRepiept(string newId, System.Drawing.Printing.PrintPageEventArgs ee)
		{
			rid = newId;
			e = ee;
			reciept = new Reciept();
			shopInfo = new ShopInfo();
			numberOfItemsPerPage = 0;  
			numberOfItemsPrintedSoFar = 0; 
			getShopData();
		}
		
		void getShopData(){		
			SQLDataBase.conOpen();
			SqlCommand get = new SqlCommand("SELECT TOP (1) name,email,shopname,shoplogo,address,mobile1,mobile2  FROM UserShopTable",SQLDataBase.connection);
			SqlDataReader rdr = get.ExecuteReader();
			if (rdr == null){
					SQLDataBase.conClose();
					MessageBox.Show("No Record Found.","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			if(rdr.Read())
			{
					shopInfo.name = rdr[0].ToString();
					shopInfo.email = rdr[1].ToString();
					shopInfo.shopname = rdr[2].ToString();
					shopInfo.shoplogo = rdr[3].ToString();
					shopInfo.address = rdr[4].ToString();
					shopInfo.mobile1 = rdr[5].ToString();
					shopInfo.mobile2 = rdr[6].ToString();
			}
			SQLDataBase.conClose();
			getData();
		}
		
		void getData(){
			try{
				SQLDataBase.conOpen();
				SqlCommand get = new SqlCommand("SELECT _id, date, supid, supname, remarks,qtys,price FROM repeipt_main ORDER BY _id DESC",SQLDataBase.connection);
				SqlDataReader rdr = get.ExecuteReader();
				if (rdr == null){
					SQLDataBase.conClose();
					MessageBox.Show("No Record Found.","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				if(rdr.Read()){
					reciept.id = rdr[0].ToString();
					reciept.rDate = rdr[1].ToString();
					reciept.supId = rdr[2].ToString();
					reciept.supName = rdr[3].ToString();
					reciept.remarks = rdr[4].ToString();
					reciept.qty = rdr[5].ToString();
					reciept.amount = rdr[6].ToString();
				}
				SQLDataBase.conClose();
				bindData();
			}catch(Exception){
				SQLDataBase.conClose();
			}
		}
		
		void bindData(){
			try{
				SQLDataBase.conOpen();
				SqlCommand get = new SqlCommand("SELECT proId, proName,qty,price FROM RecieptDetail WHERE recieptId = '"+reciept.id+"'",SQLDataBase.connection);
				SqlDataAdapter da = new SqlDataAdapter(get);
				DataTable dt = new DataTable();
				da.Fill(dt);
				List<Products> list = new List<Products>();
				
				foreach(DataRow dr in dt.Rows)
				{
					Products product = new Products();
					product.proId = dr[0].ToString();
					product.proName = dr[1].ToString();
					product.qty = dr[2].ToString();
					product.price = dr[3].ToString();
					list.Add(product);
					string[] items = {dr[0].ToString(),dr[1].ToString(),dr[2].ToString(),dr[3].ToString()};
					table.Add(items);
				}
				SQLDataBase.conClose();
				reciept.products = list;
				if (list.Count == 0){
					MessageBox.Show("No Record Found.","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				drawHeader();
			}catch(Exception){
				SQLDataBase.conClose();
			}
		}
		
		
		void drawHeader(){
			e.Graphics.DrawImage(Utilites.LoadImage(shopInfo.shoplogo),50,100,100,100);
			e.Graphics.DrawString(shopInfo.shopname, new Font("Arial",14,FontStyle.Bold),Brushes.Black,new Point(110,100));
			e.Graphics.DrawString(shopInfo.address, new Font("Arial",10,FontStyle.Regular),Brushes.Black,new Point(150,100));
			e.Graphics.DrawString(shopInfo.mobile1 +" | "+shopInfo.mobile2, new Font("Arial",10,FontStyle.Regular),Brushes.Black,new Point(200,100));
			//e.Graphics.DrawString("_______________________________________________________________ ", new Font("Arial",24,FontStyle.Bold),Brushes.Black,new Point(0,250));
			e.Graphics.DrawLine(new Pen(Color.Gray, 1), new Point(10, 250), new Point(700, 250));
			e.Graphics.DrawString(reciept.type, new Font("Arial",24,FontStyle.Bold),Brushes.Black,new Point(50,240));
			drawRecieptInfo();
		}
		
		void drawRecieptInfo(){
			e.Graphics.DrawString("Reciept # : ", new Font("Arial",11,FontStyle.Bold),Brushes.Black,new Point(98,300));
			e.Graphics.DrawString(reciept.id, new Font("Arial",11,FontStyle.Underline),Brushes.Black,new Point(300,300));
				
			e.Graphics.DrawString("Date : ", new Font("Arial",11,FontStyle.Bold),Brushes.Black,new Point(98,340));
			e.Graphics.DrawString(reciept.rDate, new Font("Arial",11,FontStyle.Underline),Brushes.Black,new Point(300,340));
				
			e.Graphics.DrawString("Customer : ", new Font("Arial",11,FontStyle.Bold),Brushes.Black,new Point(98,380));
			e.Graphics.DrawString(reciept.supId + " - "+ reciept.supName, new Font("Arial",11,FontStyle.Underline),Brushes.Black,new Point(300,380));
			
			e.Graphics.DrawString("Remarks : ", new Font("Arial",11,FontStyle.Bold),Brushes.Black,new Point(98,380));
			e.Graphics.DrawString(reciept.remarks, new Font("Arial",11,FontStyle.Underline),Brushes.Black,new Point(300,420));
		
			drawProducts();
		}
		
		void drawProducts(){
			int height = 460;  
			height += 50;  
			e.Graphics.DrawLine(new Pen(Color.Gray, 1), new Point(30, height), new Point(700, height));
            e.Graphics.DrawString(VERTICAL_LINE+ " Product", new Font("Book Antiqua", 8), Brushes.Black, new RectangleF(30, height, 420, 50));  
            e.Graphics.DrawString(VERTICAL_LINE+ " QTY", new Font("Book Antiqua", 8), Brushes.Black, new RectangleF(450, height, 100, 50)); 
			e.Graphics.DrawString(VERTICAL_LINE+ " Price", new Font("Book Antiqua", 8), Brushes.Black, new RectangleF(550, height, 150, 50));
			for (int l = numberOfItemsPrintedSoFar; l < reciept.products.Count; l++)  
			{  
   				numberOfItemsPerPage = numberOfItemsPerPage + 1;  
   		 		if (numberOfItemsPerPage <= 30)  
    			{  
        			numberOfItemsPrintedSoFar++;  
       				if (numberOfItemsPrintedSoFar <= reciept.products.Count)  
        			{  
       					Products product = reciept.products[l];
            			height += 50;  
            			e.Graphics.DrawLine(new Pen(Color.Gray, 1), new Point(30, height), new Point(700, height));
            			e.Graphics.DrawString(VERTICAL_LINE+ " "+product.proId+ " - "+ product.proName, new Font("Book Antiqua", 8), Brushes.Black, new RectangleF(30, height, 420, 50));  
            			e.Graphics.DrawString(VERTICAL_LINE+ " "+product.qty, new Font("Book Antiqua", 8), Brushes.Black, new RectangleF(450, height, 100, 50)); 
						e.Graphics.DrawString(VERTICAL_LINE+ " "+product.price, new Font("Book Antiqua", 8), Brushes.Black, new RectangleF(550, height, 150, 50));
					}  
        			else  
        			{  
            			e.HasMorePages = false;  
            			height =150;
        			}  
    			} 
   		 		else
    			{  
        			numberOfItemsPerPage = 0;  
        			e.HasMorePages = true;
        			height =150;
   		 		}
			}
			drawFooter(height += 50);
		}
		
		void drawFooter(int height){
			//e.Graphics.DrawString("____________________________________ ", new Font("Arial",24,FontStyle.Bold),Brushes.Black,new Point(250,height));
			e.Graphics.DrawLine(new Pen(Color.Gray, 1), new Point(250, height), new Point(700, height));
			height += 50;
			e.Graphics.DrawString("Total QTY : ", new Font("Arial",12,FontStyle.Bold),Brushes.Black,new Point(250,height));
			e.Graphics.DrawString(reciept.id, new Font("Arial",12,FontStyle.Underline),Brushes.Black,new Point(350,height));
			height += 50;
			e.Graphics.DrawString("Total Price : ", new Font("Arial",12,FontStyle.Bold),Brushes.Black,new Point(250,height));
			e.Graphics.DrawString(reciept.rDate, new Font("Arial",12,FontStyle.Underline),Brushes.Black,new Point(350,height));	
		}
		
		
		public static string GetDataInTableFormat(List<string[]> table)
    	{
        	StringBuilder formattedTable = new StringBuilder();
        	Array nextRow = table.FirstOrDefault();
        	Array previousRow = table.FirstOrDefault();

        	if (table == null || nextRow == null)
           	 return String.Empty;

        	// FIRST LINE:
        	int[] maximumCellWidths = GetMaxCellWidths(table);
        	for (int i = 0; i < nextRow.Length; i++)
        	{
            	if (i == 0 && i == nextRow.Length - 1)
                	formattedTable.Append(String.Format("{0}{1}{2}", TOP_LEFT_JOINT, String.Empty.PadLeft(maximumCellWidths[i], HORIZONTAL_LINE), TOP_RIGHT_JOINT));
            	else if (i == 0)
                	formattedTable.Append(String.Format("{0}{1}", TOP_LEFT_JOINT, String.Empty.PadLeft(maximumCellWidths[i], HORIZONTAL_LINE)));
            	else if (i == nextRow.Length - 1)
                	formattedTable.AppendLine(String.Format("{0}{1}{2}", TOP_JOINT, String.Empty.PadLeft(maximumCellWidths[i], HORIZONTAL_LINE), TOP_RIGHT_JOINT));
            	else
               	 	formattedTable.Append(String.Format("{0}{1}", TOP_JOINT, String.Empty.PadLeft(maximumCellWidths[i], HORIZONTAL_LINE)));
        	}

        	int rowIndex = 0;
        	int lastRowIndex = table.Count - 1;
        	foreach (Array thisRow in table)
        	{
            	// LINE WITH VALUES:
            	int cellIndex = 0;
            	int lastCellIndex = thisRow.Length - 1;
            	foreach (object thisCell in thisRow)
            	{
                string thisValue = thisCell.ToString().PadLeft(maximumCellWidths[cellIndex], PADDING);

                if (cellIndex == 0 && cellIndex == lastCellIndex)
                    formattedTable.AppendLine(String.Format("{0}{1}{2}", VERTICAL_LINE, thisValue, VERTICAL_LINE));
                else if (cellIndex == 0)
                    formattedTable.Append(String.Format("{0}{1}", VERTICAL_LINE, thisValue));
                else if (cellIndex == lastCellIndex)
                    formattedTable.AppendLine(String.Format("{0}{1}{2}", VERTICAL_LINE, thisValue, VERTICAL_LINE));
                else
                    formattedTable.Append(String.Format("{0}{1}", VERTICAL_LINE, thisValue));

                cellIndex++;
            }

            previousRow = thisRow;

            // SEPARATING LINE:
            if (rowIndex != lastRowIndex)
            {
                nextRow = table[rowIndex + 1];

                int maximumCells = Math.Max(previousRow.Length, nextRow.Length);
                for (int i = 0; i < maximumCells; i++)
                {
                    if (i == 0 && i == maximumCells - 1)
                    {
                        formattedTable.Append(String.Format("{0}{1}{2}", LEFT_JOINT, String.Empty.PadLeft(maximumCellWidths[i], HORIZONTAL_LINE), RIGHT_JOINT));
                    }
                    else if (i == 0)
                    {
                        formattedTable.Append(String.Format("{0}{1}", LEFT_JOINT, String.Empty.PadLeft(maximumCellWidths[i], HORIZONTAL_LINE)));
                    }
                    else if (i == maximumCells - 1)
                    {
                        if (i > previousRow.Length)
                            formattedTable.AppendLine(String.Format("{0}{1}{2}", TOP_JOINT, String.Empty.PadLeft(maximumCellWidths[i], HORIZONTAL_LINE), TOP_RIGHT_JOINT));
                        else if (i > nextRow.Length)
                            formattedTable.AppendLine(String.Format("{0}{1}{2}", BOTTOM_JOINT, String.Empty.PadLeft(maximumCellWidths[i], HORIZONTAL_LINE), BOTTOM_RIGHT_JOINT));
                        else if (i > previousRow.Length - 1)
                            formattedTable.AppendLine(String.Format("{0}{1}{2}", JOINT, String.Empty.PadLeft(maximumCellWidths[i], HORIZONTAL_LINE), TOP_RIGHT_JOINT));
                        else if (i > nextRow.Length - 1)
                            formattedTable.AppendLine(String.Format("{0}{1}{2}", JOINT, String.Empty.PadLeft(maximumCellWidths[i], HORIZONTAL_LINE), BOTTOM_RIGHT_JOINT));
                        else
                            formattedTable.AppendLine(String.Format("{0}{1}{2}", JOINT, String.Empty.PadLeft(maximumCellWidths[i], HORIZONTAL_LINE), RIGHT_JOINT));
                    }
                    else
                    {
                        if (i > previousRow.Length)
                            formattedTable.Append(String.Format("{0}{1}", TOP_JOINT, String.Empty.PadLeft(maximumCellWidths[i], HORIZONTAL_LINE)));
                        else if (i > nextRow.Length)
                            formattedTable.Append(String.Format("{0}{1}", BOTTOM_JOINT, String.Empty.PadLeft(maximumCellWidths[i], HORIZONTAL_LINE)));
                        else
                            formattedTable.Append(String.Format("{0}{1}", JOINT, String.Empty.PadLeft(maximumCellWidths[i], HORIZONTAL_LINE)));
                    }
                }
            }

            rowIndex++;
        }

        // LAST LINE:
        for (int i = 0; i < previousRow.Length; i++)
        {
            if (i == 0)
                formattedTable.Append(String.Format("{0}{1}", BOTTOM_LEFT_JOINT, String.Empty.PadLeft(maximumCellWidths[i], HORIZONTAL_LINE)));
            else if (i == previousRow.Length - 1)
                formattedTable.AppendLine(String.Format("{0}{1}{2}", BOTTOM_JOINT, String.Empty.PadLeft(maximumCellWidths[i], HORIZONTAL_LINE), BOTTOM_RIGHT_JOINT));
            else
                formattedTable.Append(String.Format("{0}{1}", BOTTOM_JOINT, String.Empty.PadLeft(maximumCellWidths[i], HORIZONTAL_LINE)));
        }

        return formattedTable.ToString();
    }
		
		 private static int[] GetMaxCellWidths(List<string[]> table)
    	{
        	int maximumCells = 0;
        	foreach (Array row in table)
        	{
           	 if (row.Length > maximumCells)
                	maximumCells = row.Length;
        	}

        	int[] maximumCellWidths = new int[maximumCells];
        	for (int i = 0; i < maximumCellWidths.Length; i++)
           	 maximumCellWidths[i] = 0;

       	 	foreach (Array row in table)
        	{
            	for (int i = 0; i < row.Length; i++)
            	{
                	if (row.GetValue(i).ToString().Length > maximumCellWidths[i])
                	    maximumCellWidths[i] = row.GetValue(i).ToString().Length;
            	}
        	}

        	return maximumCellWidths;
    	}
		
		
	}
	
	
	
}
