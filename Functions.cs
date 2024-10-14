using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace Sinema_Otomasyonu
{
    public static class Functions
    {
        public static void ShowFormCentered(Form formName , Panel panel1 , Panel panel2 ,  Panel panel3)
        {
            var workingAreaWidth = Screen.PrimaryScreen.Bounds.Width - panel2.Width;

            var workingAreaHeight = Screen.PrimaryScreen.Bounds.Height - (panel3.Height + panel1.Height);

            formName.Size = new System.Drawing.Size(workingAreaWidth, workingAreaHeight);

            int MainPageX = panel2.Width + (workingAreaWidth - formName.Width) / 2;
            int MainPageY = panel1.Height + (workingAreaHeight - formName.Height) / 2;

            formName.StartPosition = FormStartPosition.Manual;
            formName.Location = new System.Drawing.Point(MainPageX, MainPageY);

            formName.ShowDialog();
        }

        public static void Register(SqlCommand register ,TextBox name , TextBox surname , DateTimePicker bdate , char gender , string img , TextBox bio)
        {
            register.Parameters.AddWithValue("@name", name.Text);
            register.Parameters.AddWithValue("@surname", surname.Text);
            register.Parameters.AddWithValue("@bdate", bdate.Value.ToString("yyyy-MM-dd"));
            register.Parameters.AddWithValue("@gender", gender);
            register.Parameters.AddWithValue("@img", img);
            register.Parameters.AddWithValue("@bio", bio.Text);
            register.ExecuteNonQuery();

            name.Text = "";
            surname.Text = "";
            bio.Text = "";
            img = "";
            bdate.Value = DateTime.Now;

            name.Focus();
        }

        
    }
}
