using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace ShellTabBar
{
    [Preserve(AllMembers = true)]
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("tab1/modal", typeof(ModalPage));
            Routing.RegisterRoute("tab2/modal", typeof(ModalPage));
        }
    }
}
