using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using TodoList.Core.Enums;

namespace TodoList.Core.Models
{
    public class SettingsModel
    {
        [JsonPropertyName("userName")]
        public string UserName { get; set; }

        [JsonPropertyName("theme")]
        public MyTaskTheme Theme { get; set; }
    }
}
