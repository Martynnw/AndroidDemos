using System;
using System.Collections.Generic;
using System.Text;
using FileAccessDemo.iOS;

[assembly: Xamarin.Forms.Dependency(typeof(FileAccess))]

namespace FileAccessDemo.iOS
{
    class FileAccess : IFileAccess
    {
        public List<KeyValuePair<string, string>> GetSpecialFolders()
        {
            var result = new List<KeyValuePair<string, string>>();
            var folderIds = Enum.GetValues(typeof(System.Environment.SpecialFolder));

            foreach (var folderId in folderIds)
            {
                string name = folderId.ToString();
                string path = System.Environment.GetFolderPath((System.Environment.SpecialFolder)folderId);
                result.Add(new KeyValuePair<string, string>(name, path));
            }

            return result;
        }
    }
}
