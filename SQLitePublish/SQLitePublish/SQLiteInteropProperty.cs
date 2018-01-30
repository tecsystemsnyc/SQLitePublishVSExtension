using Microsoft.VisualStudio.Editors.PropertyPages;
using Microsoft.VisualStudio.Shell;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLitePublish
{
    [ComVisible(true)]
    [Guid("b952f5c2-2fc5-4202-bdad-48433d87036e")]
    [ProvideObject(typeof(SQLiteInteropProperty))]
    public class SQLiteInteropProperty : PropPageBase
    {
        protected override Type ControlType
        {
            get { return typeof(SQLiteInteropPropertyControl); }
        }
        protected override string Title
        {
            get { return "SQLite Interop Publish"; }
        }
        protected override Control CreateControl()
        {
            return new SQLiteInteropPropertyControl();
        }
    }
}
