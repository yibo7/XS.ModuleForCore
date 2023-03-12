using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using XS.ModuleForCore.MCore;

namespace XS.ModuleForCore.Modules
{
    public partial class TestModule : XsEbDockContent, IModules
    {
        public string Title => "内部模块";//要实现模块名称
        public Image Ico => Resource.word1; //要实现模块图标

        public TestModule()
        {
            InitializeComponent();
        }
    }
}
