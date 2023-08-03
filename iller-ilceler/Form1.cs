using System.ComponentModel;

namespace iller_ilceler
{
    public partial class Form1 : Form
    {
        List<string> iller = new List<string> { "Ankara", "Ýstanbul", "Düzce", "Kocaeli" };
        string[,] ilceler = new string[4, 3];
        public Form1()
        {
            InitializeComponent();
            //Yine harika optimizasyonlu kodum ve ben ... Saygýlar.

            string[] ankarailceler = new string[3] { "Çankaya", "Batýkent", "Keçiören" };
            string[] istanbulilceler = new string[3] { "Kadýköy", "Beþiktaþ", "Þiþli" };
            string[] düzceilceler = new string[3] { "Merkez", "Çilimli", "Yýðýlca" };
            string[] kocaeliilceler = new string[3] { "Ýzmit", "Gölcük", "Karamürsel" };
            for (int i = 0; i < ankarailceler.Length; i++)
            {
                ilceler[0, i] = ankarailceler[i];
                ilceler[1, i] = istanbulilceler[i];
                ilceler[2, i] = düzceilceler[i];
                ilceler[3, i] = kocaeliilceler[i];
            }
            for (int i = 0; i < iller.Count; i++)
            {
                cbIller.Items.Add(iller[i]);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cbIlceler.Enabled = false; 
        }

        private void cbIller_SelectedIndexChanged(object sender, EventArgs e)
        {
            //seçilen ile göre ilçeler listelenecek. (ilçeler 2 boyutlu arrayin ikinci elemanlarý)
            cbIlceler.Enabled = true; //iller seçilince ilçeler aktifleþti
            int secilenindex = cbIller.SelectedIndex;
            cbIlceler.Items.Clear();
            for (int i = 0; i < ilceler.GetUpperBound(1); i++)
            {
                cbIlceler.Items.Add(ilceler[secilenindex, i]);
            }


        }

        private void cbIller_TextChanged(object sender, EventArgs e)
        {
            //combobox a yazýlan ili getirme 
            bool bulunduMu = false;

            for (int i = 0; i < iller.Count; i++)
            {
                if (cbIller.Text == iller[i])
                {
                    bulunduMu = true;
                    break;
                }

            }
        }

        private void cbIlceler_TextChanged(object sender, EventArgs e)
        {
            // bu da ilçeyi getirme
            bool bulunduMu = false;

            for (int i = 0; i < ilceler.GetUpperBound(1); i++)
            {
                if (cbIller.Text == ilceler[i, i])
                {
                    bulunduMu = true;
                    break;
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        { 
        //dışarıdan il ekleme
            string yazi = cbIller.Text;
            if(cbIller.Items.Contains(yazi))
            {
                MessageBox.Show("yazýlan il listede vardýr.");
            }
            else
            {
                iller.Add(yazi);
                cbIller.Items.Add(yazi);
            }

            

        }
    }
}
