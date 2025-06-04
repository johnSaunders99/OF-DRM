﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Auth
    {
        public string? USER_ID { get; set; } = string.Empty;
        public string? USER_AGENT { get; set; } = string.Empty;
        public string? X_BC { get; set; } = string.Empty;
        public string? COOKIE { get; set; } = string.Empty;
        public string? YTDLP_PATH { get; set; } = string.Empty;
        public string? FFMPEG_PATH { get; set; } = string.Empty;
        public string? MP4DECRYPT_PATH { get; set; } = string.Empty;
        public bool DownloadPaidPosts { get; set; }
        public bool DownloadPosts { get; set; }
        public bool DownloadArchived { get; set; }
        public bool DownloadMessages { get; set; }
        public bool DownloadPaidMessages { get; set; }
        public bool IncludeExpiredSubscriptions { get; set; }
        public string? DownloadPath { get; set; } = string.Empty;
    }
}