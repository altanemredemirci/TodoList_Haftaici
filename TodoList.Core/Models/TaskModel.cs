using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using TodoList.Core.Enums;

namespace TodoList.Core.Models
{
    public class TaskModel
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("content")]
        public string Content { get; set; }

        [JsonPropertyName("taskDate")]
        public DateTime TaskDate { get; set; }

        [JsonPropertyName("isFavourite")]
        public bool IsFavourite { get; set; }

        [JsonPropertyName("status")]
        public MyTaskStatus Status { get; set; }

        [JsonPropertyName("color")]
        public string Color { get; set; }
    }
}
