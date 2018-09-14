using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace ShortStraw.iOS
{
    public class Application
    {
        // This is the main entry point of the application.
        static void Main(string[] args)
        {
            // if you want to use a different Application Delegate class from "AppDelegate"
            // you can specify it here.

            UIApplication.Main(args, typeof(ShortStrawApp), typeof(AppDelegate));
        }
    }

    public class ShortStrawApp : UIApplication
    {
        public override void MotionEnded(UIEventSubtype motion, UIEvent evt)
        {
            base.MotionEnded(motion, evt);
            if (motion == UIEventSubtype.MotionShake)
            {
                Console.WriteLine($"{this.GetType().Name}.{nameof(MotionEnded)}:  You shook me!");
            }
        }
    }
}
