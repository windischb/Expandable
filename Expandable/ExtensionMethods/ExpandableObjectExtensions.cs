using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Expandable.ExtensionMethods
{
    public static class ExpandableObjectExtensions
    {

        public static Dictionary<string, object> AsDictionary(this ExpandableObject expandableObject)
        {
            return expandableObject.GetProperties().ToDictionary(kv => kv.Key, kv => kv.Value);
        }
        
    }
}
