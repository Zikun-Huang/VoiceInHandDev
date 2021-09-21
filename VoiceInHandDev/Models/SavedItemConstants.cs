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
            new SavedItemModel(){SavedName="How are you?",SavedTime="2021-06-01-13:59"},
            new SavedItemModel(){SavedName="I am good.",SavedTime="2021-05-29-13:59"},
            new SavedItemModel(){SavedName="Thank you!",SavedTime="2021-05-28-13:59"},
            new SavedItemModel(){SavedName="And you?",SavedTime="2021-05-05-13:59"},
            new SavedItemModel(){SavedName="Me too.",SavedTime="2021-03-03-13:59"},
            new SavedItemModel(){SavedName="Nice to meet you.",SavedTime="2021-02-08-13:59"}
        };
    }
}
