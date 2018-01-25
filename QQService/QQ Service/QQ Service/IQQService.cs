using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;

namespace QQ_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IQQService
    {
        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        [OperationContract]
      //  string SendImage(Bitmap image);
              string SendImage(byte[] image);


        // TODO: Add your service operations here
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "QQ_Service.ContractType".
    [DataContract]
    public class CompositeType
    {
        string keyValue = "kkk";
        string imageValue = "Hello ";

        [DataMember]
        public string key
        {
            get { return keyValue; }
            set { keyValue = value; }
        }

        [DataMember]
        public string image
        {
            get { return imageValue; }
            set { imageValue=value; }
        }
    }
}
