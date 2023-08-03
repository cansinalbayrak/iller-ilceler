using System.ComponentModel;

namespace iller_ilceler
{
    public partial class Form1 : Form
    {
        string[] iller = new string[4] { "Ankara", "�stanbul", "D�zce", "Kocaeli" };
        string[,] ilceler = new string[4, 3];
        public Form1()
        {
            InitializeComponent();
            // daha ne kadar i�i karma��kla�t�r�p fazla kod yazabilirim diye d���nmedim :(. Yine harika optimizasyonlu kodum ve ben ... Sayg�lar.

            string[] ankarailceler = new string[3] { "�ankaya", "Bat�kent", "Ke�i�ren" };
            string[] istanbulilceler = new string[3] { "Kad�k�y", "Be�ikta�", "�i�li" };
            string[] d�zceilceler = new string[3] { "Merkez", "�ilimli", "Y���lca" };
            string[] kocaeliilceler = new string[3] { "�zmit", "G�lc�k", "Karam�rsel" };
            for (int i = 0; i < ankarailceler.Length; i++)
            {
                ilceler[0, i] = ankarailceler[i];
                ilceler[1, i] = istanbulilceler[i];
                ilceler[2, i] = d�zceilceler[i];
                ilceler[3, i] = kocaeliilceler[i];
            }
            for (int i = 0; i < iller.Length; i++)
            {
                cbIller.Items.Add(iller[i]);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cbIlceler.Enabled = false; //Ba�lang��ta il�eler aktif de�il
        }

        private void cbIller_SelectedIndexChanged(object sender, EventArgs e)
        {
            //se�ilen ile g�re il�eler listelenecek. (il�eler 2 boyutlu arrayin ikinci elemanlar�)
            cbIlceler.Enabled = true; //iller se�ilince il�eler aktifle�ti
            int secilenindex = cbIller.SelectedIndex;
            cbIlceler.Items.Clear();
            for (int i = 0; i < ilceler.GetUpperBound(1); i++)
            {
                cbIlceler.Items.Add(ilceler[secilenindex, i]);
            }


        }

        private void cbIller_TextChanged(object sender, EventArgs e)
        {
            //combobox a yaz�lan ili getirme (Umar�m olmu�tur G�ksel hocam ;( )
            bool bulunduMu = false;

            for (int i = 0; i < iller.Length; i++)
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
            // bu da il�eyi getirme
            bool bulunduMu = false;

            for (int i = 0; i < ilceler.GetUpperBound(1); i++)
            {
                if (cbIller.Text == ilceler[i,i])
                {
                    bulunduMu = true;
                    break;
                }

            }
        }
    }
}