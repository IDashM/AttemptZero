using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
namespace AttemptZero
{
    public partial class ChatboxCustomer : MaterialForm

    {
        public Font Roboto_Medium15;

        public ChatboxCustomer()
        {
            InitializeComponent();
            MaterialSkinManager manage = MaterialSkinManager.Instance;
            manage.AddFormToManage(this);
            manage.Theme = MaterialSkinManager.Themes.LIGHT;
            manage.ColorScheme = new ColorScheme(Primary.Blue400,Primary.Blue500,Primary.Blue500,Accent.LightBlue200,TextShade.WHITE);

        }

        private void ChatboxCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}
