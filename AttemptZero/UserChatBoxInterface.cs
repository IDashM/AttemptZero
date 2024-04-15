using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttemptZero
{
    public partial class UserChatBoxInterface : UserControl
    {
        private string _title;
        private Image  _icon;
          public UserChatBoxInterface()
        {
            InitializeComponent();
        }

        private void UserChatBoxInterface_Load(object sender, EventArgs e)
        {

        }

        public string Title {
            get { return _title; }
            set { _title = value; label1.Text = value; }
         }
        public Image Icon{
            get { return _icon; }
            set { _icon = value; pictureBox1.Image = value; }
          }
    }
}
