using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;

namespace Sichris.Models
{
    public static class AnalyticsModel
    {
        static AnalyticsModel ()
        {
            StartDate = DateTime.Now;
            AnalyticsData = new Dictionary<string, int> ();
            AnalyticsData["Home"] = 0;
            AnalyticsData["Games"] = 0;
            AnalyticsData["Fiction"] = 0;
            AnalyticsData["Poetry"] = 0;
            AnalyticsData["Support"] = 0;
            AnalyticsData["Contact"] = 0;
        }
        public static DateTime StartDate { get; set; }
        public static Dictionary<string, int> AnalyticsData { get; set; }
        public static void IncrementCount(string key)
        {
            if(!AnalyticsData.ContainsKey(key)) {
                AnalyticsData[key] = 0;
            }
            AnalyticsData[key]++;
        }
    }
}