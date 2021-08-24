using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AllNewsCms.Web.Inferistruct.CustomeAttrebiute
{
    [AttributeUsage(AttributeTargets.Class,Inherited =false)]
    public class SecurePage:Attribute
    {

        private string _permissionDescription;
        public SecurePage(string permissionDescription)
        {
            _permissionDescription = permissionDescription;
        }


        public string permissionDescription { get => _permissionDescription; }
    }
}
