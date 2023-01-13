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
    public partial class frmNoviStudent : Form
    {
        DLWMSDbContext db = new DLWMSDbContext();
        private Student student = new Student();
        public frmNoviStudent()
        {
            InitializeComponent();
            
            UcitajNaredniIndeks();
            

        }

        private void UcitajNaredniIndeks()
        {
            var brojStudenata = db.Studenti.Count();
            txtIndeks.Text = (DateTime.Now.Year * 1000 + brojStudenata).ToString();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(txtIme.Text) || !String.IsNullOrEmpty(txtPrezime.Text))
            {
                KreirajStudenta();

                db.Add(student);
                db.SaveChanges();
                MessageBox.Show($"{student} uspješno dodan!");
                OsvjeziForum();
            }
           
         
        }

        private void OsvjeziForum()
        {
            UcitajNaredniIndeks();
            txtIme.Text = null;
            txtPrezime.Text = null;
            
        }

        private void KreirajStudenta()
        {
            student.Ime = txtIme.Text;
            student.Prezime = txtPrezime.Text;
            student.Indeks = txtIndeks.Text;
        }
    }
}
