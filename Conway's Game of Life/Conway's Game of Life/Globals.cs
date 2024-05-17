using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Conway_s_Game_of_Life
{
    static class Globals
    {
        // These are all global variables that the settings form and grid form use.
        static public SettingsForm settingsForm;
        static public BlueprintConfigForm blueprintConfigForm;
        static public bool change = false;
        static public int width = 39;
        static public int height = 28;
        static public int currentColour = 1;
        static public int clockSpeed = 100;

        /* Plane Types:
         * 0 = Torus
         * 1 = Klein Bottle
        */
        static public int planeType = 0;
    }
}
