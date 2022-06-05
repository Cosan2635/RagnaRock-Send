using System;
using System.ComponentModel.DataAnnotations;

namespace Rockmuseet.models
{
    public class History
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [StringLength(250, ErrorMessage = "Description cannot be longer than 133 characters.")]
        public string Description { get; set; }

        public string Image { get; set; }

        public int HistoryAudioId { get; set; }

        public string HistoryAudio { get; set; }

        public int MusicAudioId { get; set; }

        public string MusicAudio { get; set; }
    }
}
