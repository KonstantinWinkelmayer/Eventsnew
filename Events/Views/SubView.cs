using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Events.Views
{
    public partial class SubView : Form
    {
        public SubView()
        {
            InitializeComponent();
        }

        internal void UpdateText(string text)
        {
            TbText.Text = text;
        }
    }
}
