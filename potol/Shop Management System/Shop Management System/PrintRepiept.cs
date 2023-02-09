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
				SqlCommand get = new SqlCommand("SELECT _id, date, supid, supname, remarks,qtys,price,type,mTime,payAmount,status FROM receipt_main ORDER BY _id DESC",SQLDataBase.connection);
				SqlDataReader rdr = get.ExecuteReader();
				if (rdr == null){
					SQLDataBase.conClose();
					MessageBox.Show("No Record Found.","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				if(rdr.Read()){
					reciept.id = rdr[0].ToString();
					reciept.rDate = rdr[1].ToString() +" "+ rdr[8].ToString();
					reciept.supId = rdr[2].ToString();
					reciept.supName = rdr[3].ToString();
					reciept.remarks = rdr[4].ToString();
					reciept.qty = rdr[5].ToString();
					reciept.amount = rdr[6].ToString();
					reciept.type = rdr[7].ToString();
					reciept.payamount = rdr[9].ToString();
					reciept.status = rdr[10].ToString();
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
				SqlCommand get = new SqlCommand("SELECT proId, proName,qty,price FROM RecieptsDetail WHERE recieptId = '"+reciept.id+"'",SQLDataBase.connection);
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
			e.Graphics.DrawImage(Utilites.LoadImage(shopInfo.shoplogo),80,15,100,100);
			e.Graphics.DrawString(shopInfo.shopname, new Font("Book Antiqua",22,FontStyle.Bold),Brushes.Black,new Point(200,15));
			e.Graphics.DrawString(shopInfo.address, new Font("Book Antiqua",14,FontStyle.Bold),Brushes.Black,new Point(200,55));
			e.Graphics.DrawString(shopInfo.mobile1 +" | "+shopInfo.mobile2, new Font("Book Antiqua",14,FontStyle.Bold),Brushes.Black,new Point(200,90));
			//e.Graphics.DrawString("_______________________________________________________________ ", new Font("Arial",24,FontStyle.Bold),Brushes.Black,new Point(0,250));
			e.Graphics.DrawLine(new Pen(Color.Gray, 1), new Point(80, 130), new Point(700, 130));
			e.Graphics.DrawString(reciept.type, new Font("Book Antiqua",24,FontStyle.Bold),Brushes.Black,new Point(300,135));
			drawRecieptInfo();
		}
		
		void drawRecieptInfo(){
			
			e.Graphics.DrawLine(new Pen(Color.Gray, 1), new Point(80, 180), new Point(700, 180));
			
			e.Graphics.DrawString("Reciept # : ", new Font("Book Antiqua",11,FontStyle.Bold),Brushes.Black,new Point(80,200));
			e.Graphics.DrawString(reciept.id, new Font("Book Antiqua",11,FontStyle.Regular),Brushes.Black,new Point(175,200));
				
			e.Graphics.DrawString("Date : ", new Font("Book Antiqua",11,FontStyle.Bold),Brushes.Black,new Point(350,200));
			e.Graphics.DrawString(reciept.rDate, new Font("Book Antiqua",11,FontStyle.Regular),Brushes.Black,new Point(420,200));
				
			e.Graphics.DrawString("Customer : ", new Font("Book Antiqua",11,FontStyle.Bold),Brushes.Black,new Point(80,230));
			e.Graphics.DrawString(reciept.supId + " \t "+ reciept.supName, new Font("Arial",11,FontStyle.Regular),Brushes.Black,new Point(175,230));
			
			e.Graphics.DrawString("Remarks : ", new Font("Book Antiqua",11,FontStyle.Bold),Brushes.Black,new Point(80,260));
			e.Graphics.DrawString(reciept.remarks, new Font("Book Antiqua",11,FontStyle.Regular),Brushes.Black,new Point(175,260));
		
			drawProducts();
		}
		
		void drawProducts(){
			int height = 260;  
			height += 40;  
			e.Graphics.DrawLine(new Pen(Color.Gray, 1), new Point(80, height), new Point(700, height));
			height += 5; 
            e.Graphics.DrawString("Product", new Font("Book Antiqua", 10,FontStyle.Bold), Brushes.Black, new RectangleF(80, height, 420, 50));  
            e.Graphics.DrawString( "QTY", new Font("Book Antiqua", 10,FontStyle.Bold), Brushes.Black, new RectangleF(500, height, 100, 50)); 
			e.Graphics.DrawString( "Price", new Font("Book Antiqua", 10,FontStyle.Bold), Brushes.Black, new RectangleF(600, height, 100, 50));

			for (int l = numberOfItemsPrintedSoFar; l < reciept.products.Count; l++)  
			{  
   				numberOfItemsPerPage = numberOfItemsPerPage + 1;  
   		 		if (numberOfItemsPerPage <= 30)  
    			{  
        			numberOfItemsPrintedSoFar++;  
       				if (numberOfItemsPrintedSoFar <= reciept.products.Count)  
        			{  
       					Products product = reciept.products[l];
            			height += 25;  
            			e.Graphics.DrawLine(new Pen(Color.Gray, 1), new Point(80, height), new Point(700, height));
            			height += 5; 
            			e.Graphics.DrawString(product.proId+ "\t"+ product.proName, new Font("Book Antiqua", 10), Brushes.Black, new RectangleF(80, height, 420, 50));  
            			e.Graphics.DrawString(product.qty, new Font("Book Antiqua", 10), Brushes.Black, new RectangleF(500, height, 100, 50)); 
						e.Graphics.DrawString(product.price, new Font("Book Antiqua", 10), Brushes.Black, new RectangleF(600, height, 150, 50));
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
			drawFooter(height += 25);
		}
		
		void drawFooter(int height){
			
			e.Graphics.DrawLine(new Pen(Color.Gray, 1), new Point(80, height), new Point(700, height));
            height += 5; 
            e.Graphics.DrawString("Total", new Font("Book Antiqua", 10,FontStyle.Bold), Brushes.Black, new RectangleF(80, height, 420, 50));  
            e.Graphics.DrawString(reciept.qty, new Font("Book Antiqua", 10,FontStyle.Bold), Brushes.Black, new RectangleF(500, height, 100, 50)); 
			e.Graphics.DrawString(reciept.amount, new Font("Book Antiqua", 10,FontStyle.Bold), Brushes.Black, new RectangleF(600, height, 150, 50));
			height += 25;
			e.Graphics.DrawLine(new Pen(Color.Gray, 1), new Point(80, height), new Point(700, height));
			height += 5; 
			e.Graphics.DrawString("Pay Amount", new Font("Book Antiqua", 10,FontStyle.Bold), Brushes.Black, new RectangleF(500, height, 100, 50)); 
			e.Graphics.DrawString(reciept.payamount, new Font("Book Antiqua", 10,FontStyle.Bold), Brushes.Black, new RectangleF(600, height, 150, 50));
			height += 25;
			e.Graphics.DrawLine(new Pen(Color.Gray, 1), new Point(500, height), new Point(700, height));
			double tAmount = double.Parse(reciept.amount);
			double payAmount = double.Parse(reciept.payamount);
			e.Graphics.DrawString("Remianing", new Font("Book Antiqua", 10,FontStyle.Bold), Brushes.Black, new RectangleF(500, height, 100, 50)); 
			e.Graphics.DrawString((tAmount - payAmount).ToString(), new Font("Book Antiqua", 10,FontStyle.Bold), Brushes.Black, new RectangleF(600, height, 150, 50));
			height += 25;
			e.Graphics.DrawLine(new Pen(Color.Gray, 1), new Point(500, height), new Point(700, height));
			height += 50;
			e.Graphics.DrawLine(new Pen(Color.Gray, 1), new Point(80, height), new Point(180, height));
			e.Graphics.DrawString("Signature", new Font("Book Antiqua", 10,FontStyle.Bold), Brushes.Black, new RectangleF(100, height, 420, 50));  
           
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
