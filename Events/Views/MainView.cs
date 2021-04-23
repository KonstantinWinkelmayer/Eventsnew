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
    public partial class MainView : Form
    {
        public event EventHandler<string> TextChanged;
        public MainView()
        {
            InitializeComponent();
        }

        private void TbText_TextChanged(object sender, EventArgs e)
        {
            //get text 
            string text = TbText.Text;
            if(TextChanged != null)
            {
                TextChanged.Invoke(this, text);
            }

            //short
            //TextChanged.Invoke(this, text);
        }

        

        
    }
}
