using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebBackup {
    class Logger {

        private static System.Windows.Forms.RichTextBox appOut = null;

        public static void toConsole( string txt ) {
            if (appOut != null) {//throw new Exception("Niepoprawnie skonfigurowany logger - nie może logować na konsoli");
                appOut.Text += txt + "\n"; 
            }
        }

        public static void connectConsole( System.Windows.Forms.RichTextBox o ) {
            appOut = o;
        }

        public static void log(string txt) {
            toConsole(txt);
        }

        public static void logInfo(string txt) {
            toConsole( "Info: " + txt );
        }

        public static void logErr(string err) {
            toConsole("!!! " + err);
        }



    }
}
