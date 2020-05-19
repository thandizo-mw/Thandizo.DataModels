using System;
using System.Collections.Generic;
using System.Text;
using Thandizo.DataModels.Notifications;

namespace Thandizo.DataModels.ViewModels.Notifications
{
    public class BulkNotificationViewModel
    {
        public BulkNotificationDTO BulkNotification { get; set; }
        public IEnumerable<NotificationChannelDTO> Channels { get; set; }

    }
}
