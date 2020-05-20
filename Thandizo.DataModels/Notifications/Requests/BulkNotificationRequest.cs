using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;
using System.Web;

namespace Thandizo.DataModels.Notifications.Requests
{
    public class BulkNotificationRequest : BulkNotificationDTO
    {
        public bool SendNow { get; set; }
        public bool ToPatients { get; set; }
        public bool ToHealthCareWorkers { get; set; }
        public bool ToTeamMembers { get; set; }
        public bool ToChannels { get; set; }
        public bool ToCustomNumbers { get; set; }
        public List<string> UploadedPhoneNumbers { get; set; }
        public string CustomNumbers { get; set; }
        public string MessageType { get; set; }
    }
}
