﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedLaunch.Classes.Scraper.DAT.NOINTRO.Models
{
    public class NoIntroObject
    {
        public int SystemId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Rom { get; set; }
        public string Size { get; set; }
        public string CRC { get; set; }
        public string MD5 { get; set; }
        public string SHA1 { get; set; }
    }
}