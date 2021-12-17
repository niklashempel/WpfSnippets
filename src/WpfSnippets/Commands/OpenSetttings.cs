using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Community.VisualStudio.Toolkit;
using Microsoft.VisualStudio.Shell;

namespace WpfSnippets.Commands
{
    [Command(PackageIds.WpfSnippetsOptions)]
    internal class OpenSetttingsCommand : BaseCommand<OpenSetttingsCommand>
    {
        protected override async System.Threading.Tasks.Task ExecuteAsync(OleMenuCmdEventArgs e)
        {
            System.Windows.MessageBox.Show("HELP");
        }
    }
}