using System;

namespace Thandizo.DataModels.General
{
    public abstract class DataCreatorDTO
    {
        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
    }
}
