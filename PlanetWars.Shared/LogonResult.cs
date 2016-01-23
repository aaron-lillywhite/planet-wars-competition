﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetWars.Shared
{
    public class LogonResult : BaseResult
    {
        public string AuthToken { get; set; }
        public int GameId { get; set; }
        public DateTime GameStart { get; set; }
    }
}
