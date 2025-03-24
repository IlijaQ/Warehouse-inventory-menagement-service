using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseUI
{
    public static class Target
    {
        public static string Url { get; set; }

        public static void CheckSettingOf(string url)
        {
            if (string.IsNullOrEmpty(url.Trim()))
            {
                AddTargetUrl dialog = new AddTargetUrl();
            }
        }
    }
}
