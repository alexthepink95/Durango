﻿using System;
using System.Collections.Generic;

namespace Framework.Models
{
    public class TitleInfo
    {
        public string Name { get; set; }
        public object Id { get; set; }
    }

    public class Friend
    {
        public string GamerTag { get; set; }
        public string GamerTileUrl { get; set; }
        public string LargeGamerTileUrl { get; set; }
        public int GamerScore { get; set; }
        public bool IsOnline { get; set; }
        public DateTime LastSeen { get; set; }
        public string Presence { get; set; }
        public TitleInfo TitleInfo { get; set; }
        public string RichPresence { get; set; }
    }

    public class Data
    {
        public List<Friend> Friends { get; set; }
        public List<object> Outgoing { get; set; }
        public List<object> Incoming { get; set; }
    }

    public class RootObject
    {
        public Data Data { get; set; }
        public bool Success { get; set; }
        public object Diagnostics { get; set; }
    }
}