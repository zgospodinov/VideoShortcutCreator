using IWshRuntimeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Logic
{
    public static class Shortcuts
    {
        public static void Create(string shortcutName, string shortcutPath, string targetFileLocation)
        {
            string shortcutLocation = System.IO.Path.Combine(shortcutPath, shortcutName + ".lnk");
            WshShell shell = new WshShell();
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutLocation);

            //shortcut.Description = "My shortcut description";
            //shortcut.IconLocation = @"c:\myicon.ico";
            shortcut.TargetPath = targetFileLocation;
            shortcut.Save();
        }
    }
}
