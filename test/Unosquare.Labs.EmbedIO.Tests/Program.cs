﻿using System;
using Unosquare.Labs.EmbedIO.Log;
using Unosquare.Labs.EmbedIO.Tests.TestObjects;

namespace Unosquare.Labs.EmbedIO.Tests
{
    public static class Program
    {
        public static void Main()
        {
            var ws = new WebSocketsModuleTest();
            ws.Init();
            ws.TestConnectWebSocket();
            Console.ReadLine();
        }
    }
}
