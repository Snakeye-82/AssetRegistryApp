using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AssetRegistry.Data;
using AssetRegistry.Droid;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Xamarin.Forms;

[assembly: Dependency(typeof(FileHelper))]
namespace AssetRegistry.Droid
{
    public class FileHelper : IFileHelper
    {
        public string GetLocalFilePath(string filename)
        {
            string docFolder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData);
            string libFolder = Path.Combine(docFolder, "..", "ItemsDatabase");

            // "..", "Library", "Databases"
            if (!Directory.Exists(libFolder))
            {
                Directory.CreateDirectory(libFolder);
            }
            return Path.Combine(libFolder, filename);
        }
    }

}