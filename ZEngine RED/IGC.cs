using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZEngine_RED
{
    class IGC
    {
        internal static Library.IOD.Dispatcher ControlDispatcher = new Library.IOD.Dispatcher();
        internal static Library.ION.Handler Network = new Library.ION.Handler();

        internal static Repositories.Client Client = new Repositories.Client();

        internal static UI.Messages.License MessageLicenseE = new UI.Messages.License();
        internal static UI.Messages.ConnectionMessageBox MessageConnectionS = new UI.Messages.ConnectionMessageBox();

        internal static UI.Forms.Form1 GeneralForm;
    }
}
