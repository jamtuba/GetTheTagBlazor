using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace GetTheTagBlazor.Client.Helpers
{
    public class ValidateImageUrl
    {
        public static bool Validate(string uri)
        {
            List<string> extensionNames = new List<string> { ".jpg", ".png", ".bmp", ".gif" };

            var uriExtension = Path.GetExtension(uri);
            bool isVal = false;

            if (Regex.IsMatch(uri, @"^(?:(?<scheme>[^:\/?#]+):)?(?:\/\/(?<authority>[^\/?#]*))?(?<path>[^?#]*\/)?(?<file>[^?#]*\.(?<extension>[Jj][Pp][Ee]?[Gg]|[Pp][Nn][Gg]|[Gg][Ii][Ff]))(?:\?(?<query>[^#]*))?(?:#(?<fragment>.*))?$"))
            {
                Console.WriteLine("Please enter a valid Url");
                isVal = true;
            }

            if (extensionNames.Contains(uriExtension.ToLower()))
            {
                isVal = true;
            }

            Console.WriteLine("Validation: " + isVal);

            return isVal;


            //string ImageFolder;
            //ImageFolder = Server.MapPath(txtImageUrl.Text);
            //if (File.Exists(ImageFolder))
            //{
            //    lblStatus.Text = "File exists in given URL";

            //}
            //else
            //{
            //    lblStatus.Text = "File does not exist in given Url";
            //    txtImageUrl.Text = "";
            //}



            //var fileSize = blob.Length;

            //if (extensionNames.Contains(blobExtension.ToLower()) && fileSize <= 4000000)
            //    return true;

            //return false;


        }
    }
}
