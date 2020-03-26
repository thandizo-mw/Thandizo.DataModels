using System;

namespace Thandizo.DataModels.General
{
    public abstract class BaseRowDTO
    {
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedBy { get; set; }
        public string RowAction { get; set; }
    }
}
