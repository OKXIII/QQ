using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Xml;
using System.Xml.Linq;

using System.Runtime.Serialization;
using System.ServiceModel;



namespace ScreenPaste
{
	/// <summary>
	/// Class with routines that upload images to hostings.
	/// </summary>
	static class PostingServices
	{
        
        const string IMGUR_API_KEY = "3d5907509d22a3130787a91bbb3c9189"; //идентификатор взят из общего доступа
//        const string IMGUR_API_KEY = "3514d0d4bd066edf37ec9ea1a845cecaacf0167f";

		public static string PostToImgur(Bitmap bitmap)
		{
			MemoryStream memoryStream = new MemoryStream();
			bitmap.Save(memoryStream, ImageFormat.Jpeg);
            String result = "";
            using (var w = new WebClient())
			{
				var values = new NameValueCollection
				{
					{ "key", IMGUR_API_KEY },
					{ "image", Convert.ToBase64String(memoryStream.ToArray()) }
				};
				string debug = values.ToString();
                //try
                //{
                    byte[] response = w.UploadValues("http://imgur.com/api/upload.xml", values);
                    XDocument xDocument = XDocument.Load(new MemoryStream(response));
                    result=(string)xDocument.Root.Element("original_image");
                //}
                //catch
                //{ 

                //}
				return result;
			}
		}

        public static string PostToQQ (Bitmap bitmap)
        {
            String result = "";
            MemoryStream memoryStream = new MemoryStream();
            bitmap.Save(memoryStream, ImageFormat.Png);
   //         qq.Azure.Service1Client client = new qq.Azure.Service1Client();
            qq.Master.Service1Client client = new qq.Master.Service1Client();
        //    qq.LocalService.Service1Client client = new qq.LocalService.Service1Client();
            try
            {
                result = client.GetBitmap(memoryStream.ToArray());
            }
            catch
            { 
            }
            return result;
        }

	}
}
