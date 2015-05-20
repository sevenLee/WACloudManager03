using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.Text;
using System.IO;
using System.Net;


// Description: some tiny tools make by Raxel 
// Ver: 0.1.20150211
namespace RRTool
{
    public static class StrTool : Object
    {
        public static string myMD5(string source){
            MD5 md5Hash = MD5.Create();
            
            string hash = GetMd5Hash(md5Hash, source);
            
            return hash;
        }

        static string GetMd5Hash(MD5 md5Hash, string input)
        {

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        // Verify a hash against a string.
        static bool VerifyMd5Hash(MD5 md5Hash, string input, string hash)
        {
            // Hash the input.
            string hashOfInput = GetMd5Hash(md5Hash, input);

            // Create a StringComparer an compare the hashes.
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            if (0 == comparer.Compare(hashOfInput, hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string microtime()
        {
            //得到1970年的时间戳
            DateTime timeStamp = new DateTime(1970, 1, 1);
            //注意这里有时区问题，用now就要减掉8个小时
            long sec = (DateTime.UtcNow.Ticks - timeStamp.Ticks) / 10000000;
            int msec = DateTime.UtcNow.Millisecond;
            string strMsec = "0." + msec.ToString().PadRight(8, '0');
            string strRet = strMsec + " " + sec.ToString();
            return strRet;
        }

    } // end of Class StrTool

    public static class WebTool {
        

        public static String GET(String url, String UserAgent)
        {
            String Result = "";
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";
                request.UserAgent = UserAgent; 
                WebResponse response = request.GetResponse();
                Stream dataStream = response.GetResponseStream();
                // Open the stream using a StreamReader for easy access.
                StreamReader reader = new StreamReader(dataStream);
                // Read the content.
                Result = reader.ReadToEnd();
                reader.Close();
                dataStream.Close();
                response.Close();

            }
            catch(Exception e)
            {
                return e.Message;
            }


            return Result;
        } // end of function GET

        public static String POST(String url, String UserAgent, String Content)
        {
            String Result = "";

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "POST";
                byte[] byteArray = Encoding.UTF8.GetBytes(Content);
                request.ContentType = "application/x-www-form-urlencoded";
                request.UserAgent = UserAgent; 
                request.ContentLength = byteArray.Length;
                Stream dataStream = request.GetRequestStream();
                dataStream.Write(byteArray, 0, byteArray.Length);
                dataStream.Close();

                WebResponse response = request.GetResponse();
                dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                Result = reader.ReadToEnd();

                reader.Close();
                dataStream.Close();
                response.Close();

            }
            catch (Exception e)
            {
                return e.Message;
            }

            return Result;
        }
    } // end of class WebTool
    
}