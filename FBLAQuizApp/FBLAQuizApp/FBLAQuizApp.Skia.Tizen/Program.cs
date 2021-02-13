﻿using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace FBLAQuizApp.Skia.Tizen
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new TizenHost(() => new FBLAQuizApp.App(), args);
            host.Run();
        }
    }
}
