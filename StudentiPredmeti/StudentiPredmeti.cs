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
    public partial class StudentiPredmeti : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        StudentPredmet studentPredmet = new StudentPredmet();
        public StudentiPredmeti()
        {
            InitializeComponent();
            dgvStudentiPredmeti.AutoGenerateColumns = false;
            UcitajStudente();
            UcitajPredmete();
        }

        private void UcitajPredmete()
        {
            cbPredmet.DataSource = db.Predmeti.ToList();
            cbPredmet.SelectedIndex = -1;
        }

        private void UcitajStudente()
        {
            cbStudent.DataSource = db.Studenti.ToList();
            cbStudent.SelectedIndex = -1;
        }

        private void StudentiPredmeti_Load(object sender, EventArgs e)
        {
            OsvjeziDGV();

        }

        private void OsvjeziDGV()
        {
            dgvStudentiPredmeti.DataSource = db.StudentiPredmeti.ToList();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            KreirajStudentPredmet();
            if (!PredmetVecPolozen())
            {
                db.Add(studentPredmet);
                db.SaveChanges();
                MessageBox.Show("Položeni predmet uspješno dodan!");
                OsvjeziDGV();
            }
            
        }

        private bool PredmetVecPolozen()
        {
            var odabraniPredmet = cbPredmet.SelectedItem as Predmet;
            var odabraniStudent = cbStudent.SelectedItem as Student;

            if (db.StudentiPredmeti.Where(polozeni => polozeni.PredmetId == odabraniPredmet.Id && polozeni.StudentId == odabraniStudent.Id).Count() > 0)
            {
                MessageBox.Show("Predmet je već položen!");
                return true;
            }
            else
                return false;
            
        }

        private void KreirajStudentPredmet()
        {
            studentPredmet.StudentId = (cbStudent.SelectedItem as Student).Id;
            studentPredmet.PredmetId = (cbPredmet.SelectedItem as Predmet).Id;
            studentPredmet.DatumPolaganja = dtpVrijemePolaganja.Value; ;
        }
    }
}
