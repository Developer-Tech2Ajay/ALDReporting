using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALDReporting
{
    public partial class ucProductImages : UserControl
    {
        public string imgBefore { get; set; }
        public string imgAfter { get; set; }

        public ucProductImages()
        {
            InitializeComponent();
            setValues();
        }

        private void setValues()
        {
            picBeforePStart.ImageLocation = imgBefore;
            picAfterPStart.ImageLocation = imgAfter;


        }
    }
}
