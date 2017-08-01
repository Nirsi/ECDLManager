using System;
using System.Reflection;
using System.Windows.Forms;
using System.Diagnostics;

namespace ECDLManager
{
    partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            lb_appName.Text = string.Format("{0}", AssemblyProduct);
            lb_version.Text = string.Format("Verze:  {0}", AssemblyVersion);
            lb_author.Text = string.Format("Autor:  {0}", AssemblyCopyright);
            tb_description.Text = AssemblyDescription;
            lb_license.Text = "Licence: MIT";
            lb_projectLink.Text = "Stránka projektu";
            lb_feedback.Text = "Zpětnou vazbu";
            
        }

        #region Assembly info access

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion

        private void lb_projectLink_Click(object sender, EventArgs e)
        {
            Process.Start("https://goo.gl/eYuyNW");
        }

        private void lb_license_Click(object sender, EventArgs e)
        {
            Process.Start("https://goo.gl/objUyr");
        }

        private void lb_feedback_Click(object sender, EventArgs e)
        {
            Process.Start("https://goo.gl/forms/Nn3Z2ulnMJA4RR6V2");
        }
    }
}
