using System;
using System.Collections.Generic;
using System.Text;

namespace Thandizo.DataModels.Notifications.Requests
{
    public class BulkNotificationRequest : BulkNotificationDTO
    {
        public bool SendNow { get; set; }
    }
}
