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

namespace Shop_Management_System
{
	/// <summary>
	/// Description of Utilites.
	/// </summary>
	public static class Utilites
	{
		
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
	}
}
