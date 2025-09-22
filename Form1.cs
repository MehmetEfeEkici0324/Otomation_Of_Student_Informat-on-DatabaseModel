using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentNotes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        StudentDal _studentdal = new StudentDal();
        
        private void LoadStudents()
        {
            //grid kısmından dataların kaynagı olarak belirliyor ve _studentdal nesnesinin getall komutunu çağırıyor 
            //getall komutu bizim veritabanındaki bütün verileri döndürüyordu
            dgwStudents.DataSource = _studentdal.GetAll();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            //_studentdal nesnesinin studentdal dosyasında oluşturduğumuz add fonksiyonunu çağırıyoruz ve içine yeni bir student değeri ekliyoruz
            //new Student diyerek Student classından bir nesneymiş gibi oluşan değerlerimizin adresini add fonksiyonumuza yolluyoruz
            _studentdal.Add(new Student
            {
                //add fonksiyonunda istediğimiz Name değerinin bizim textboxumuza yazdığımız o an ki text olduğunu söylüyoruz
                //Aynsını surname ve class için de yapıyoruz
                Name = tbxname.Text,
                Surname = tbxsurname.Text,
                Number = tbxnumber.Text,
                Class = tbxclass.Text
            });

            tbxname.Text = "";
            tbxsurname.Text = "";
            tbxclass.Text = "";
            tbxnumber.Text = "";
            //Ve gridimizi güncelleyerek güncel verilerimizi çekiyoruz
            LoadStudents();
            MessageBox.Show(" < STUDENT ADDED > ");
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            //Bu hiçbir işlem yapmadığımızda da gridde güncel verilerin olmasını sağlar.
            LoadStudents();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Burada student nesnesi olarak bir ayrı nesne oluşturuyoruz
            Student student = new Student
            {
                //Bu sefer Id değerini de istiyoruz çünkü bu Id değerini kullanarak değişen değerleri aynı Id değerinni olduğu rowa yerleştireceğiz
                Id = Convert.ToInt32(dgwStudents.CurrentRow.Cells[0].Value),
                Name = tbxnameUpdate.Text,
                Surname= tbxsurnameUpdate.Text,
                Number = tbxnumberUpdate.Text,
                Class = tbxclassUpdate.Text
            };

            //Burada _studentdal nesnesinin update fonksiyonunu çağırarak içine oluşturduğumuz student nesnesini atıyouz ve fonksiyon bu nesneden değerlerini çekiyor
            //ve çektiği değerleri add gibi ekliyor sadece aynı Id kısmına ekliyor.
            _studentdal.Update(student);
            tbxnameUpdate.Text = "";
            tbxsurnameUpdate.Text = "";
            tbxclassUpdate.Text = "";
            tbxnumberUpdate.Text = "";
            LoadStudents();
            MessageBox.Show(" < STUDENT UPDATED > ");
        }

        private void dgwStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Grid üzerinde bir row kısmına tıklayınca onu seçip update kısımları üzerine getirmesini sağlıyor ki biz update işlemini yapabilelim
            //CellClick ifadesine dikkat edelim çünkü diğer cellclick sadece Id kısmına basınca çalışıyor
            tbxnameUpdate.Text = dgwStudents.CurrentRow.Cells[1].Value.ToString();
            tbxsurnameUpdate.Text = dgwStudents.CurrentRow.Cells[2].Value.ToString();
            tbxnumberUpdate.Text = dgwStudents.CurrentRow.Cells[3].Value.ToString();
            tbxclassUpdate.Text = dgwStudents.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnremove_Click(object sender, EventArgs e)
        {
            //Burada remove etmek istediğinde bir mesaj döndürecek ve diyecek ki emin misin
            rtbxmesaj.Text = "ARE YOU SURE DELETE IT? "; 

            /* string select;
             * select = Convert.ToString(Console.ReadLine());
             * 
             * Şeklinde kullanıcıdan input alındığını daha bu projeyi geliştirirken öğrendim teşekkür ederim hocam :)
             * 
             * Başka bir örnek;
             * 
             * int benim_Yasim;
             * benim_Yasim = Convert.ToInt32(Console.ReadLine());
             */

            btnyes.Visible = true;
            btnno.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Evet butonuna yani buna basarsa remove edilecek
            //id değişkenine bastığımız rowun int değeri aktarılıyor
            int id = Convert.ToInt32(dgwStudents.CurrentRow.Cells[0].Value);
            //_studentdal ile remove fonksiyonunu çağırıyoruz ve içerisine id int değerini yolluyoruz
            _studentdal.Remove(id);
            //Burada mesaj kısmını siliyoruz ki aynı emin misin sorusu orada kalmasın
            rtbxmesaj.Text = "";
            btnyes.Visible = false;
            btnno.Visible = false;
            tbxnameUpdate.Text = "";
            tbxsurnameUpdate.Text = "";
            tbxclassUpdate.Text = "";
            tbxnumberUpdate.Text = "";
            LoadStudents();
            MessageBox.Show(" < STUDENT DELETED > ");
        }

        private void btnno_Click(object sender, EventArgs e)
        {
            //Eğer cevabı hayırsa sadece mesaj kutusu temzileniyo ve bir işlem yapılmıyor.
            rtbxmesaj.Text = "";
            btnyes.Visible = false;
            btnno.Visible = false;
            tbxnameUpdate.Text = "";
            tbxsurnameUpdate.Text = "";
            tbxclassUpdate.Text = "";
            tbxnumberUpdate.Text = "";
        }
    }
}
