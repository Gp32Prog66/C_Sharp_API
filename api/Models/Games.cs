using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Games
    {
        public int video_game_id { get; set; }

        public string title { get; set; } = string.Empty;

        public string system_name { get; set; } = string.Empty;

        public string publisher { get; set; } = string.Empty;
    }
}