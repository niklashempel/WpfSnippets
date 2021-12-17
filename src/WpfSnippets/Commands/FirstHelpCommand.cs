using System.Threading.Tasks;
using Community.VisualStudio.Toolkit;
using Microsoft.VisualStudio.Shell;

namespace WpfSnippets.Commands
{
    [Command(PackageIds.FirstHelp)]
    internal sealed class FirstHelpCommand : BaseCommand<FirstHelpCommand>
    {
        protected override async System.Threading.Tasks.Task ExecuteAsync(OleMenuCmdEventArgs e)
        {
            await VS.MessageBox.ShowWarningAsync("FirstHelpCommand", "Help is on the way.");
        }
    }
}