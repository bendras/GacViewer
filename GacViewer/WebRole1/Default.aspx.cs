using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace WebRole1
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void OnViewAllButtonClick(object sender, EventArgs e)
        {
            string path = MapPath("gacutil.exe");
            string command = "/l";

            ressultsBox.Text = RunCommandLineTool(path, command);
        }

        protected void OnViewAssemblyButtonClick(object sender, EventArgs e)
        {
            string path = MapPath("gacutil.exe");
            string command = "/l " + assemblyName.Text;

            ressultsBox.Text = RunCommandLineTool(path, command);
        }

        private string RunCommandLineTool(string path, string parameters)
        {
            ProcessStartInfo info = new System.Diagnostics.ProcessStartInfo(path, parameters);
            info.UseShellExecute = false;
            info.ErrorDialog = false;
            info.CreateNoWindow = true;
            info.RedirectStandardOutput = true;

            Process p = Process.Start(info);

            StreamReader sr = p.StandardOutput;
            string output = sr.ReadToEnd();
            sr.Close();

            return output;
        }
    }
}
