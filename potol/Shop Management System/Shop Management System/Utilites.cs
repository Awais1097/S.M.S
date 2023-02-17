/*
 * Created by SharpDevelop.
 * User: Dell
 * Date: 1/22/2023
 * Time: 5:26 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

using Microsoft.Office.Interop.Excel;

namespace Shop_Management_System
{
	/// <summary>
	/// Description of Utilites.
	/// </summary>
	public static class Utilites
	{
		public static string RECIEPT = "RECIEPT";
		public static string ORDER = "ORDER";
		
		public static string ImageToBase64(Image image)
		{
    	var imageStream = new MemoryStream();
    	try
    	{           
        	image.Save(imageStream, System.Drawing.Imaging.ImageFormat.Bmp);
        	imageStream.Position = 0;
        	var imageBytes = imageStream.ToArray();
        	var ImageBase64 = Convert.ToBase64String(imageBytes);
        	return ImageBase64;
    	}
    	catch (Exception ex)
    	{
        	return "Error converting image to base64! "+ex;
    	}
    	finally
    	{
    		imageStream.Dispose();
    	}
	}	



	public static Image LoadImage(String base64)
	{
    //data:image/gif;base64,
    //this image is a single pixel (black)
    	byte[] bytes = Convert.FromBase64String(base64);

    	Image image;
    	using (MemoryStream ms = new MemoryStream(bytes))
    		{
        		image = Image.FromStream(ms);
    		}

    		return image;
		}
	
	
	public static Boolean save(string newFileName,string data){
		try{
		 	// Specify a "currently active folder"
        	string activeDir = @"c:\S.M.S";

        	//Create a new subfolder under the current active folder
        	string newPath = System.IO.Path.Combine(activeDir, "Export");

        	// Create the subfolder
        	System.IO.Directory.CreateDirectory(newPath);

       		 // Combine the new file name with the path
        	newPath = System.IO.Path.Combine(newPath, newFileName);

        	// Create the file and write to it.
        	// DANGER: System.IO.File.Create will overwrite the file
        	// if it already exists. This can occur even with random file names.
        	if (!System.IO.File.Exists(newPath))
        	{
            	using (System.IO.FileStream fs = System.IO.File.Create(newPath))
            	{
                	for (byte i = 0; i < 100; i++)
                	{
                   	 fs.WriteByte(i);
                	}
            	}
        	}
        	File.WriteAllText(@newPath, data); 

        	// Read data back from the file to prove that the previous code worked.
        	try
        	{
            	byte[] readBuffer = System.IO.File.ReadAllBytes(newPath);
            	foreach (byte b in readBuffer)
            	{
                	Console.WriteLine(b);
            	}
        	}
        	catch (System.IO.IOException e)
        	{
            	Console.WriteLine(e.Message);
        	}
        	var ExcelApp = new Microsoft.Office.Interop.Excel.Application();
        	ExcelApp.Workbooks.OpenText( newPath, Comma:true);

       		ExcelApp.Visible = true;
 //       	File.Open(newPath, FileMode.Open, FileAccess.Read, FileShare.None);
//        	Microsoft.Office.Interop.Excel.Application xl = new Microsoft.Office.Interop.Excel.Application();
//        	Microsoft.Office.Interop.Excel.Workbook wb = xl.Workbooks.Open(newPath);
//        	wb.Close();
//        	xl.Quit();
        	return true;
		}catch(Exception){
			return false;
		}
		}
	
	public static void readEcxalFile(){
		String filename = "";
		string fileData = "";
               OpenFileDialog dialog = new OpenFileDialog();
               dialog.Title = "Open CSV File";
               dialog.Filter = "CSV Files (*.csv)|*.csv";
               if (dialog.ShowDialog() == DialogResult.OK)
               {
                   filename = dialog.FileName;
               }
               else
               {
                   return;
               }
       		
       		string[] lines = System.IO.File.ReadAllLines(filename);
			foreach(string line in lines)
			{
    			string[] columns = line.Split(',');
    			foreach (string column in columns) {
        				fileData = fileData + column+"," ;
    			}
    			fileData = fileData+ "\n" ;
			}
			save("Readed.csv",fileData);
	}
		
}
	

}
