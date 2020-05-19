using System;
using System.Collections.Generic;
using System.Text;
using Thandizo.DataModels.Notifications;
using Thandizo.DataModels.Notifications.Requests;

namespace Thandizo.DataModels.ViewModels.Notifications
{
    public class BulkNotificationRequestViewModel
    {
        public BulkNotificationRequest BulkNotificationRequest { get; set; }

        public IEnumerable<NotificationChannelDTO> Channels { get; set; }
        
    }
}
