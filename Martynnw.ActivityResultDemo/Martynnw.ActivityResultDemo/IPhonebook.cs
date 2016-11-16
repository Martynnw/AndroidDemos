using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martynnw.ActivityResultDemo
{
    public interface IPhonebook
    {
        Task<string> GetContactName();
    }
}
