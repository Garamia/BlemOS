using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlemOS.Registry
{
    /// <summary>
    /// A layout object for the PersistenSettings file
    /// </summary>
    public class PersistentSettingsObject
    {
        public List<UserObject> Users { get; set; }
    }
}
