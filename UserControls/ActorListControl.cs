using Sinema_Otomasyonu.Classes;
using Sinema_Otomasyonu.Forms.Actor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Otomasyonu.UserControls
{
    public partial class ActorListControl : UserControl
    {
        public ActorListControl()
        {
            InitializeComponent();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            ActorUpdate AU = new ActorUpdate();

            using (AchiDBContext ac = new AchiDBContext(Secrets.DB_Path))
            {
                int Actor_ID = int.Parse(ID.Text);

                var Actor_Edit = ac.Actors
                    .FirstOrDefault(a => a.ID == Actor_ID);

                AU.r_id.Text = Actor_Edit.ID.ToString();
                AU.r_name.Text = Actor_Edit.AD.ToString();
                AU.r_surname.Text = Actor_Edit.SOYAD.ToString();
                AU.r_gender = Actor_Edit.CINSIYET;
                AU.r_date.Value = Actor_Edit.DOGUM;
                AU.r_bio.Text = Actor_Edit.BIO.ToString();
                AU.r_img.ImageLocation = Actor_Edit.RESIM.ToString();

            }

            MainPage mp = new MainPage();
            Functions.ShowFormCentered(AU, mp.panel1, mp.panel2, mp.panel3);
        }
    }
}
