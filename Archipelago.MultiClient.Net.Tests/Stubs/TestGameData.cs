﻿using Archipelago.MultiClient.Net.Models;
using System.Collections.Generic;

namespace Archipelago.MultiClient.Net.Tests.Stubs
{
    class TestGameData : GameData
    {
        public TestGameData(int version)
        {
            Version = version;
            LocationLookup = new Dictionary<string, long>(0);
            ItemLookup = new Dictionary<string, long>(0);
        }
    }
}
