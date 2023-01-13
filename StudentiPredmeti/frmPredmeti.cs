using StudentiPredmeti.Klase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentiPredmeti
{
    public partial class frmPredmeti : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        Predmet predmet = new Predmet();
        public frmPredmeti()
        {
            InitializeComponent();
        }

        private void frmPredmeti_Load(object sender, EventArgs e)
        {
            UcitajPredmete();
        }

        private void UcitajPredmete()
        {
            dgvPredmeti.AutoGenerateColumns = false;
            dgvPredmeti.DataSource = db.Predmeti.ToList();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            
            if (PredmetPostoji())
            {
                MessageBox.Show($"Predmet {txtPredmet.Text} je već u bazi!");
            }
            else
            
            if(!string.IsNullOrEmpty(txtPredmet.Text)) 
            {
                predmet.Naziv = txtPredmet.Text;
                db.Add(predmet);
                db.SaveChanges();
                UcitajPredmete();
            }
        }

        private bool PredmetPostoji()
        {
            foreach (var pr in db.Predmeti.ToList())
            {
                if(pr.Naziv.ToString() == txtPredmet.Text)
                { return true; }
            }
            return false;
        }
    }
}
