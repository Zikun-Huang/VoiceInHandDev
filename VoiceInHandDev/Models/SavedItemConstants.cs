using System;
using System.Collections.Generic;
using System.Text;
using VoiceInHandDev.ViewModels;

namespace VoiceInHandDev.Models
{
    public static class SavedItemConstants
    {
        public static List<SavedItemModel> SavedItems = new List<SavedItemModel>
        {
            new SavedItemModel(){SavedName="你就放心吧",SavedTime="2021-06-01-13:59"},
            new SavedItemModel(){SavedName="没关系",SavedTime="2021-05-29-13:59"},
            new SavedItemModel(){SavedName="没什么问题",SavedTime="2021-05-28-13:59"},
            new SavedItemModel(){SavedName="我看过检查报告了",SavedTime="2021-05-05-13:59"},
            new SavedItemModel(){SavedName="回去好好休息",SavedTime="2021-05-05-13:59"},
            new SavedItemModel(){SavedName="下个月回来复查",SavedTime="2021-05-05-13:59"}
        };
    }
}
