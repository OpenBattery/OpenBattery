using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Reflection.Emit;
using Azure.Storage.Blobs;
using AzureSQLWebApplication.Controllers;
using System.Web.Mvc;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using Microsoft.WindowsAzure.Storage.Auth;
using System.IO;

namespace AzureSQLWebApplication
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == true)
            {
                //Label3.Text = ("Great! All information was recorded!");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            /*SqlConnection azureconn = new SqlConnection("Server=tcp:uwcei.database.windows.net,1433;Initial Catalog=macrobattery;Persist Security Info=False;User ID=macrobatteryadmin;Password=MScapstone2020;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            {
                SqlCommand insertInfo = new SqlCommand("EXEC dbo.InsertInfo @id @name @table_name", azureconn);
                insertInfo.Parameters.AddWithValue("@id", TextBox1.Text);
                insertInfo.Parameters.AddWithValue("@name", TextBox2.Text);
                insertInfo.Parameters.AddWithValue("@table_name", TextBox3.Text);
                SqlCommand insertName = new SqlCommand("EXEC dbo.InsertInfo @name", azureconn);
                insertName.Parameters.AddWithValue("@name", TextBox2.Text);

                SqlCommand insertTableName = new SqlCommand("EXEC dbo.InsertInfo @table_name", azureconn);
                insertTableName.Parameters.AddWithValue("@table_name", TextBox3.Text);

                azureconn.Open();
                insertID.ExecuteNonQuery();
                insertName.ExecuteNonQuery();
                insertTableName.ExecuteNonQuery();
                azureconn.Close();

                azureconn.Open();
                insertInfo.ExecuteNonQuery();
                azureconn.Close();

                if (IsPostBack)
                {
                    TextBox1.Text = "";
                    TextBox2.Text = "";
                    TextBox3.Text = "";
                }
            }*/
            SqlConnection azureconn = new SqlConnection("Server=tcp:uwcei.database.windows.net,1433;Initial Catalog=macrobattery;Persist Security Info=False;User ID=macrobatteryadmin;Password=MScapstone2020;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            {
                SqlCommand insertID = new SqlCommand("EXEC dbo.InsertID @id", azureconn);
                insertID.Parameters.AddWithValue("@id", TextBox1.Text);
                azureconn.Open();
                insertID.ExecuteNonQuery();
                azureconn.Close();
                TextBox1.Text = "";
                Label3.Text = ("Great! ID was recorded!");
            }


        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged1(object sender, EventArgs e)
        {

        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string accountName = "macrobattery";
            string accessKey = "vDkl2k9Qc5gu6Q9ArUBAX20ZaDVhn9Xbg5RGaEIogmAeTuPFkUKtSmPORViieVJ8kgFRLM5Jc4y6a213EPvwLA==";

            try
            {
                StorageCredentials credentials = new StorageCredentials(accountName, accessKey);
                CloudStorageAccount account = new CloudStorageAccount(credentials, true);
                CloudBlobClient client = account.CreateCloudBlobClient();
                CloudBlobContainer container = client.GetContainerReference("examplebattery");
                container.CreateIfNotExists();

                container.SetPermissions(new BlobContainerPermissions
                {
                    PublicAccess = BlobContainerPublicAccessType.Blob
                });

                string fileName = Path.GetFileName(FileUpload1.FileName);

                CloudBlockBlob blockBlob = container.GetBlockBlobReference(TextBox4.Text);

                using(FileUpload1.PostedFile.InputStream)
                {
                    blockBlob.UploadFromStream(FileUpload1.PostedFile.InputStream);
                }

                TextBox4.Text = "";

                Label6.Text = fileName + " has been uploaded successfully! ";
            }
            catch (Exception ex)
            {
                Label6.Text = "Upload status: The file could not be uploaded. The following error occured: " + ex.Message;
            }
        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}