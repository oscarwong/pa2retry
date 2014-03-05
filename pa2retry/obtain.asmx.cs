using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace pa2retry
{
    /// <summary>
    /// Summary description for obtain
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class obtain : System.Web.Services.WebService
    {
        public Trie trie = new Trie();


        [WebMethod]
        public static Trie GetStorage()
        {
            CloudStorageAccount storageAccount = CloudStorageAccount.Parse(
                ConfigurationManager.AppSettings["StorageConnectionString"]);

            CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();

            CloudBlobContainer container = blobClient.GetContainerReference("pa2");

            CloudBlockBlob blob2 = container.GetBlockBlobReference("newtitles.txt");

            string line = null;
            using (StreamReader sr = new StreamReader(blob2.OpenRead()))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    
                }
            }
        }
    }
}
