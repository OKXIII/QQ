using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Net;
using System.Drawing;
using System.Drawing.Imaging;


using System.Xml;
using System.Xml.Linq;
using System.IO;

namespace QQ_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class QQService : IQQService
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

       public string SendImage(byte[] base64image)
    //  public string SendImage(Bitmap base64image)
        {
//             byte[] image = Convert.FromBase64String(base64image);
            byte [] image = base64image;
           string filename = String.Format(@"d:\\{0}", System.Guid.NewGuid());
    //        base64image.Save(filename);
             File.WriteAllBytes(filename, image);
            return filename;
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.key!=null)
            {
                composite.image += "Suffix";
            }
            return composite;
        }
    }
}
