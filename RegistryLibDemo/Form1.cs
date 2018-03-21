using System;
using System.Windows.Forms;

namespace RegistryLibDemo
{
    public partial class Form1 : Form
    {
        string keyName = "TestDate";
        RegistryLib.Common regedit = new RegistryLib.Common("RegistryLibDemo");
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Read_Click(object sender, EventArgs e)
        {
            var testDate = regedit.Read(keyName);
            if (testDate != null)
            {
                MessageBox.Show(testDate.ToString());
            }
        }

        private void btn_Write_Click(object sender, EventArgs e)
        {
            var isWritten = regedit.Write(keyName, DateTime.Now);
        }

        private void btn_DeleteKey_Click(object sender, EventArgs e)
        {
            var isDeleted = regedit.DeleteKey(keyName);
        }

        private void btn_DeleteSubKey_Click(object sender, EventArgs e)
        {
            var isDeleted = regedit.DeleteSubKeyTree();
        }

    }
}
