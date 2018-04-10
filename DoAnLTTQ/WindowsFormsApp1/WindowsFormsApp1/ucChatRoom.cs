using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class ucChatRoom : UserControl
    {
        // static value to access and create control
        private static ucChatRoom _instance;
        public static ucChatRoom Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ucChatRoom();
                }
                return _instance;
            }
        }
        public ucChatRoom()
        {
            InitializeComponent();          
            
            //addbtn();
        }

        private void btnRoomAdmin_MouseHover(object sender, EventArgs e)
        {
            pnlRoomAdmin.BackColor = Color.FromArgb(40, 43, 48);
        }
        void addbtn()
        {
            //lstOnlineUser.View = View.Details;
            //lstOnlineUser.Columns.Add("",lstOnlineUser.Width/2 - 25);
            //lstOnlineUser.Columns.Add("", lstOnlineUser.Width / 2);
            
            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(60, 60);

            Image img_user = Image.FromFile(@"C:\WORK\Winform\DoAn\WindowsFormsApp1\WindowsFormsApp1\img\user_img\s_user.png");
            imageList.Images.Add(img_user);

            listView1.SmallImageList = imageList;
            listView1.LargeImageList = imageList;

            for (int i =0; i < 10; i++){
                ListViewItem item = new ListViewItem() { ImageIndex = 0,Text ="User 1"};              
                listView1.Items.Add(item);
            }
            
            


        }
       
    }
}
