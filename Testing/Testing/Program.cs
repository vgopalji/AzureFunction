using Microsoft.Azure.Storage;
using Microsoft.Azure.Storage.Blob;
using System;

namespace Testing
{
   public  class Program
    {
        private readonly string _blobContainerName = "blobcontainer";
        public static void Main(string[] args)
        {
            try
            {
                //string test111 = "AV CENTER test";

                //if (test111.Contains("test"))
                //{
                //    string sma = "succss";
                //}

                //string sdate = DateTime.UtcNow.ToString("s") + "Z";

                CloudStorageAccount storageAccount = CloudStorageAccount.Parse("DefaultEndpointsProtocol=https;AccountName=cldopsdiag;AccountKey=NFVBKppnMNu9opHOSVdtAkXL50XqNC12cJqRRZFFJPuSJpbDp5G/S2lkH/sFpiKxcBF5Ig3VAmI4YkT5jjlc0A==;EndpointSuffix=core.windows.net");
                CloudBlobClient blobclient = storageAccount.CreateCloudBlobClient();
                CloudBlobContainer blobcontainer = blobclient.GetContainerReference("container");
                if (blobcontainer.CreateIfNotExists())
                {
                    blobcontainer.SetPermissions(new BlobContainerPermissions { PublicAccess = BlobContainerPublicAccessType.Blob });
                }
                /*
                string Email = "EmailList.csv";
                CloudBlockBlob blob = blobcontainer.GetBlockBlobReference($"{Email}");
                blob.Properties.ContentType = "text/csv";
                blob.UploadFromFile(@"C:\Users\venugopalm\Desktop\EmailList.csv"); 


                string Email1 = "AccountEmailList.csv";
                CloudBlockBlob blob1 = blobcontainer.GetBlockBlobReference($"{Email1}");
                blob1.Properties.ContentType = "text/csv";
                //blob.UploadFromFile(@"C:\Apurv\POCs\AzurefunctionCrestronDeviceDetails\AzurefunctionCrestronDeviceDetails\File\EmailList.csv");

                blob1.UploadFromFile(@"C:\Users\venugopalm\Desktop\AccountEmailList.csv"); */

                //string Email1 = "device-3rdParty_email_list.csv";
                //string Email1 = "EmailList-UCEngineReports.csv";
                //string Email1 = "EmailList-Athanahealth.csv";
                //string Email1 = "EmailList-AccountBiWeeklyReports.csv"; /*---------------this is last changed--*/
                //string Email1 = "EmailList-one-id.csv";
                //string Email1 = "EmailList-three-id.csv"; 
                //string Email1 = "EmailList-ThirdPartyDeviceReports-six-ids.csv";
                //string Email1 = "EmailList-venu.csv";
                string Email1 = "EmailList-ThirdPartyDeviceReports.csv";
                //string Email1 = "Device-Details.csv"; AccountEmailList
                //string Email1 = "AccountEmailList.csv";
                CloudBlockBlob blob1 = blobcontainer.GetBlockBlobReference($"{Email1}");
                blob1.Properties.ContentType = "text/csv";
                //blob.UploadFromFile(@"C:\Apurv\POCs\AzurefunctionCrestronDeviceDetails\AzurefunctionCrestronDeviceDetails\File\EmailList.csv");

                //blob1.UploadFromFile(@"C:\Users\venugopalm\Desktop\Device-Details.csv");
                // blob1.UploadFromFile(@"C:\Users\venugopalm\Desktop\EmailList-AccountWeeklyReports.csv");
                //blob1.UploadFromFile(@"C:\Users\venugopalm\Desktop\EmailList-AccountBiWeeklyReports.csv");
                //blob1.UploadFromFile(@"C:\Users\venugopalm\Downloads\EmailList-AccountBiWeeklyReports.csv");
                //blob1.UploadFromFile(@"C:\Users\venugopalm\Desktop\EmailList-UCEngineReports.csv");
                blob1.UploadFromFile(@"C:\Users\venugopalm\Desktop\EmailList-ThirdPartyDeviceReports.csv");
                //blob1.UploadFromFile(@"C:\Users\venugopalm\Desktop\EmailList-three-id.csv");
                //blob1.UploadFromFile(@"C:\Users\venugopalm\Desktop\EmailList-ThirdPartyDeviceReports-six-ids.csv");
                //blob1.UploadFromFile(@"C:\Users\venugopalm\Desktop\EmailList-Athanahealth.csv");
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
