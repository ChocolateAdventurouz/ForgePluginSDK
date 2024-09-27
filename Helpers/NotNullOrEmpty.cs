using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForgePlugin.Helpers
{
    [AttributeUsage(AttributeTargets.Property)]
    public class NotNullOrEmptyAttribute : Attribute
    {
        public NotNullOrEmptyAttribute()
        {
            throw new InvalidOperationException("Mandatory values cannot be empty");
        }
    }
}
