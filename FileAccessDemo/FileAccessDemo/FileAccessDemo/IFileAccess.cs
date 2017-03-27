using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAccessDemo
{
    public interface IFileAccess
    {
        List<KeyValuePair<string, string>> GetSpecialFolders();
    }
}
