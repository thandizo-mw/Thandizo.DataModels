using System;
using System.Collections.Generic;
using System.Text;
using Thandizo.DataModels.Notifications;

namespace Thandizo.DataModels.ViewModels.Notifications
{
    public class ScheduledNotificationViewModel
    {
        public ScheduledNotificationDTO ScheduledNotification { get; set; }
        public IEnumerable<NotificationChannelDTO> NotificationChannels { get; set; }
        public IEnumerable<ScheduledNotificationEscalationRuleDTO> EscalationRules { get; set; }
        public IEnumerable<NotificationTemplateDTO> NotificationTemplates { get; set; }
    }
}
