using System.Collections.Generic;
using Expandable.Internal;

namespace Expandable
{

    public class ExpandableObject : ExpandableBaseObject
    {
        public ExpandableObject() : base()
        {

        }

        public ExpandableObject(object @object) : base(@object)
        {

        }

        public ExpandableObject(IDictionary<string, object> dictionary)
        {

            foreach (var keyValuePair in dictionary)
            {
                this[keyValuePair.Key] = keyValuePair.Value;
            }

        }

        
    }

}
