using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using FileAccessDemo;
using FileAccessDemo.Droid;
using Xamarin.Forms;

[assembly: Xamarin.Forms.Dependency(typeof(FileAccess))]

namespace FileAccessDemo.Droid
{
    class FileAccess : IFileAccess
    {
        public List<KeyValuePair<string, string>> GetSpecialFolders()
        {
            var result = new List<KeyValuePair<string, string>>();

            GetAndroidFolders(result);
            GetDotNetFolders(result);
            
            return result;
        }

        private void GetAndroidFolders(List<KeyValuePair<string, string>> result)
        {
            result.Add(new KeyValuePair<string, string>("Android.OS.Environment.ExternalStorageDirectory", Android.OS.Environment.ExternalStorageDirectory.AbsolutePath));
            result.Add(new KeyValuePair<string, string>("Context.GetExternalFilesDir(null)", Forms.Context.GetExternalFilesDir(null).AbsolutePath));
            result.Add(new KeyValuePair<string, string>("Context.GetExternalFiles(DirectoryPictures)", Android.OS.Environment.GetExternalStoragePublicDirectory(Android.OS.Environment.DirectoryPictures).AbsolutePath));
        }

        private void GetDotNetFolders(List<KeyValuePair<string, string>> result)
        {
            var folderIds = Enum.GetValues(typeof(System.Environment.SpecialFolder));

            foreach (var folderId in folderIds)
            {
                string name = $"System.Environment.SpecialFolder.{folderId}";
                string path = System.Environment.GetFolderPath((System.Environment.SpecialFolder) folderId);
                result.Add(new KeyValuePair<string, string>(name, path));
            }
        }
    }
}