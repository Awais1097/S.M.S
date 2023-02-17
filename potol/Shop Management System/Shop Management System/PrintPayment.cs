/*
 * Created by SharpDevelop.
 * User: Dell
 * Date: 2/12/2023
 * Time: 6:09 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Shop_Management_System
{
	/// <summary>
	/// Description of PrintPayment.
	/// </summary>
	public class PrintPayment
	{
		string rid;
		System.Drawing.Printing.PrintPageEventArgs e;
		Reciept reciept;
		ShopInfo shopInfo;
		int numberOfItemsPerPage = 0;  
		int numberOfItemsPrintedSoFar = 0; 
		
		public PrintPayment(string newId, System.Drawing.Printing.PrintPageEventArgs ee)
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
				SqlCommand get = new SqlCommand("SELECT m._id, m.date, m.supid, m.supname, m.remarks,m.qtys,m.price,m.type,m.mTime,m.payAmount,status,c.CustomersAddress,m.discount FROM receipt_main m , Customers c  Where m.supid = c.CustomersId AND m._id ='"+rid+"' ORDER BY m._id DESC",SQLDataBase.connection);
				SqlDataReader rdr = get.ExecuteReader();
				if (rdr == null){
					SQLDataBase.conClose();
					MessageBox.Show("No Record Found.","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				if(rdr.Read()){
					reciept.id = rdr[0].ToString();
					reciept.rDate = DateTime.Parse(rdr[1].ToString()).ToString("yyyy-MM-dd")  +" "+ rdr[8].ToString();
					reciept.supId = rdr[2].ToString();
					reciept.supName = rdr[3].ToString() +" ( "+rdr[11].ToString()+" )";
					reciept.remarks = rdr[4].ToString();
					reciept.qty = rdr[5].ToString();
					reciept.amount = rdr[6].ToString();
					reciept.type = rdr[7].ToString();
					reciept.payamount = rdr[9].ToString();
					reciept.status = rdr[10].ToString();
					reciept.discount = rdr[12].ToString();
				}
				SQLDataBase.conClose();
				getData2();
			}catch(Exception){
				SQLDataBase.conClose();
				MessageBox.Show("No Record Found.","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		
		void getData2(){
			try{
				SQLDataBase.conOpen();
				SqlCommand get = new SqlCommand(" select TotalAmount,PayAmount,Outstanding from ViewOutStanding where ID = '"+rid+"' ORDER BY ID DESC",SQLDataBase.connection);
				SqlDataReader rdr = get.ExecuteReader();
				if (rdr == null){
					SQLDataBase.conClose();
					MessageBox.Show("No Record Found.","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				if(rdr.Read()){
					reciept.amount = rdr[0].ToString();
					reciept.payamount = rdr[1].ToString();
					reciept.outstanding = rdr[2].ToString();
				}
				SQLDataBase.conClose();
				bindData();
			}catch(Exception){
				SQLDataBase.conClose();
				MessageBox.Show("No Record Found.","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		void bindData(){
			try{
				SQLDataBase.conOpen();
				SqlCommand get = new SqlCommand(" select remarks,payDate,payAmount from  CustomerPays where outId = '"+rid+"' ",SQLDataBase.connection);
				SqlDataAdapter da = new SqlDataAdapter(get);
				DataTable dt = new DataTable();
				da.Fill(dt);
				List<Payment> list = new List<Payment>();
				
				foreach(DataRow dr in dt.Rows)
				{
					Payment product = new Payment();
					product.remarks = dr[0].ToString();
					product.date = dr[1].ToString();
					product.amount = dr[2].ToString();
					list.Add(product);
				}
				SQLDataBase.conClose();
				reciept.paymets = list;
				drawHeader();
			}catch(Exception){
				SQLDataBase.conClose();
				MessageBox.Show("No Record Found.","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		void drawHeader(){
			e.Graphics.DrawImage(Utilites.LoadImage(shopInfo.shoplogo),80,15,100,100);
			e.Graphics.DrawString(shopInfo.shopname, new Font("Book Antiqua",22,FontStyle.Bold),Brushes.Black,new Point(200,15));
			e.Graphics.DrawString(shopInfo.address, new Font("Book Antiqua",14,FontStyle.Bold),Brushes.Black,new Point(200,55));
			e.Graphics.DrawString(shopInfo.mobile1 +" | "+shopInfo.mobile2, new Font("Book Antiqua",14,FontStyle.Bold),Brushes.Black,new Point(200,90));
			e.Graphics.DrawLine(new Pen(Color.Gray, 1), new Point(80, 130), new Point(700, 130));
			e.Graphics.DrawString(reciept.type, new Font("Book Antiqua",24,FontStyle.Bold),Brushes.Black,new Point(300,135));
			drawRecieptInfo();
		}
		
		void drawRecieptInfo(){
			
			e.Graphics.DrawLine(new Pen(Color.Gray, 1), new Point(80, 180), new Point(700, 180));
			
			e.Graphics.DrawString("Reciept # : ", new Font("Book Antiqua",11,FontStyle.Bold),Brushes.Black,new Point(80,200));
			e.Graphics.DrawString(reciept.id, new Font("Book Antiqua",11,FontStyle.Regular),Brushes.Black,new Point(175,200));
				
			e.Graphics.DrawString("Date : ", new Font("Book Antiqua",11,FontStyle.Bold),Brushes.Black,new Point(350,200));
			e.Graphics.DrawString(reciept.rDate , new Font("Book Antiqua",11,FontStyle.Regular),Brushes.Black,new Point(400,200));
				
			e.Graphics.DrawString("Customer : ", new Font("Book Antiqua",11,FontStyle.Bold),Brushes.Black,new Point(80,230));
			e.Graphics.DrawString(reciept.supName, new Font("Arial",11,FontStyle.Regular),Brushes.Black,new Point(175,230));
			
			e.Graphics.DrawString("Remarks : ", new Font("Book Antiqua",11,FontStyle.Bold),Brushes.Black,new Point(80,260));
			e.Graphics.DrawString(reciept.remarks, new Font("Book Antiqua",11,FontStyle.Regular),Brushes.Black,new Point(175,260));
		
			drawProducts();
		}
		
		void drawProducts(){
			int height = 260;  
			height += 40;  
			e.Graphics.DrawLine(new Pen(Color.Gray, 1), new Point(80, height), new Point(700, height));
			height += 5; 
            e.Graphics.DrawString("Remarks", new Font("Book Antiqua", 10,FontStyle.Bold), Brushes.Black, new RectangleF(80, height, 320, 50));  
            e.Graphics.DrawString( "Date", new Font("Book Antiqua", 10,FontStyle.Bold), Brushes.Black, new RectangleF(350, height, 250, 50)); 
			e.Graphics.DrawString( "Amount", new Font("Book Antiqua", 10,FontStyle.Bold), Brushes.Black, new RectangleF(600, height, 100, 50));

			for (int l = numberOfItemsPrintedSoFar; l < reciept.paymets.Count; l++)  
			{  
   				numberOfItemsPerPage = numberOfItemsPerPage + 1;  
   		 		if (numberOfItemsPerPage <= 30)  
    			{  
        			numberOfItemsPrintedSoFar++;  
       				if (numberOfItemsPrintedSoFar <= reciept.paymets.Count)  
        			{  
       					Payment product = reciept.paymets[l];
            			height += 25;  
            			e.Graphics.DrawLine(new Pen(Color.Gray, 1), new Point(80, height), new Point(700, height));
            			height += 5; 
            			e.Graphics.DrawString(product.remarks, new Font("Book Antiqua", 10), Brushes.Black, new RectangleF(80, height, 320, 50));  
            			e.Graphics.DrawString(product.date, new Font("Book Antiqua", 10), Brushes.Black, new RectangleF(350, height, 250, 50)); 
						e.Graphics.DrawString(product.amount, new Font("Book Antiqua", 10), Brushes.Black, new RectangleF(600, height, 150, 50));
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
            e.Graphics.DrawString("Paid Amount", new Font("Book Antiqua", 10,FontStyle.Bold), Brushes.Black, new RectangleF(350, height, 250, 50));  
			e.Graphics.DrawString(reciept.payamount, new Font("Book Antiqua", 10,FontStyle.Bold), Brushes.Black, new RectangleF(600, height, 150, 50));
			height += 25;
			e.Graphics.DrawLine(new Pen(Color.Gray, 1), new Point(350, height), new Point(700, height));
			height += 5; 
			e.Graphics.DrawString("OutStanding", new Font("Book Antiqua", 10,FontStyle.Bold), Brushes.Black, new RectangleF(350, height, 250, 50)); 
			e.Graphics.DrawString(reciept.outstanding, new Font("Book Antiqua", 10,FontStyle.Bold), Brushes.Black, new RectangleF(600, height, 150, 50));
			height += 25;
			e.Graphics.DrawLine(new Pen(Color.Gray, 1), new Point(350, height), new Point(700, height));
			height += 5; 
			e.Graphics.DrawString("Total Amount", new Font("Book Antiqua", 10,FontStyle.Bold), Brushes.Black, new RectangleF(350, height, 250, 50)); 
			e.Graphics.DrawString(reciept.amount, new Font("Book Antiqua", 10,FontStyle.Bold), Brushes.Black, new RectangleF(600, height, 150, 50));
			height += 25;
			e.Graphics.DrawLine(new Pen(Color.Gray, 1), new Point(350, height), new Point(700, height));
			height += 50;
			e.Graphics.DrawLine(new Pen(Color.Gray, 1), new Point(80, height), new Point(180, height));
			e.Graphics.DrawString("Signature", new Font("Book Antiqua", 10,FontStyle.Bold), Brushes.Black, new RectangleF(100, height, 420, 50));  
           
			e.Graphics.DrawImage(Image.FromFile(@"pain_icon.png"),250,300,200,200);
		}
		
	}
}
