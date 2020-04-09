using System.ComponentModel.DataAnnotations;
using Thandizo.DataModels.General;

namespace Thandizo.DataModels.Core
{
    public class ResponseTeamMappingDTO : BaseRowDTO
    {
        public int MappingId { get; set; }

        [Required(ErrorMessage = "Team Member Id cannot be blank")]
        public int TeamMemberId { get; set; }

        [Required(ErrorMessage = "District Code cannot be blank")]
        public string DistrictCode { get; set; }
    }
}
