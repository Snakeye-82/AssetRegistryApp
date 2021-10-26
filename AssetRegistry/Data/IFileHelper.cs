using System;
using System.Collections.Generic;
using System.Text;

namespace AssetRegistry.Data
{
    public interface IFileHelper
    {
        string GetLocalFilePath(string filename);
    }
}
