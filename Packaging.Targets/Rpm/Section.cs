using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Packaging.Targets.Rpm
{
    internal class Section<TK>
    {
        public RpmHeader Header
        {
            get;
            set;
        }

        public Dictionary<TK, IndexRecord> Records
        { get; set; } = new Dictionary<TK, IndexRecord>();
    }
}
