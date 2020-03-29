using System;

namespace Thandizo.DataModels.General
{
    public abstract class BaseRowDTO : DataCreatorDTO
    {        
        public DateTime? DateModified { get; set; }
        public string ModifiedBy { get; set; }
        public string RowAction { get; set; }
    }
}
