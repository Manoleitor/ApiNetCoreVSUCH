using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiNetCoreVS.Helpers
{
    public interface IFileHelper
    {
        public string Base64Encode(string plainText);

        public string Base64Decode(string base64EncodedData);
       
    }
}
