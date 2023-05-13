/****************************************************************************
** SAKARYA �N�VERS�TES�
** B�LG�SAYAR VE B�L���M B�L�MLER� FAK�LTES�
** B�LG�SAYAR M�HEND�SL��� B�L�M�
** NESNEYE DAYALI PROGRAMLAMA DERS�
**
** �DEV NUMARASI�...: 1
** ��RENC� ADI...............: EM�RHAN AKSU
** ��RENC� NUMARASI.: G221210058    
** DERS GRUBU����: 2.��RET�M B GRUBU
YOUTUBE L�NK݅ �: https://youtu.be/pWlgv49QukA
****************************************************************************/


using System.Drawing.Drawing2D;

namespace ProjeDeneme6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Emirhan Aksu\nG-221210058\nBir denetimden sonra tekrar denetim yapmak i�in " +
                "ilk SIFIRLA butonuna t�klay�n�z sonras�nda yapaca��n�z denetimi se�iniz",
                "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information); // Form load oldu�unda bir tan�t�m ve bilgilendirme kutusunun ekrana ��kmas�n� sa�lad�m.

            #region Combobox �geleri eklendi
            comboBox1.Items.Add("1- Nokta-D�rtgen �arp��ma Denetimi"); // Combobox ��elerini form load oldu�unda eklenmesini sa�lad�m.
            comboBox1.Items.Add("2- Nokta-�ember �arp��ma Denetimi");
            comboBox1.Items.Add("3- Dikd�rtgen-Dikd�rtgen �arp��ma Denetimi");
            comboBox1.Items.Add("4- Dikd�rtgen-�ember �arp��ma Denetimi");
            comboBox1.Items.Add("5- �ember-�ember �arp��ma Denetimi");
            comboBox1.Items.Add("6- Nokta-K�re �arp��ma Denetimi");
            comboBox1.Items.Add("7- Nokta-Dikd�rtgen Prizma �arp��ma Denetimi");
            comboBox1.Items.Add("8- Nokta-Silindir �arp��ma Denetimi");
            comboBox1.Items.Add("9- Silindir-Silindir �arp��ma Denetimi");
            comboBox1.Items.Add("10- K�re-K�re �arp��ma Denetimi");
            comboBox1.Items.Add("11- K�re-Silindir �arp��ma Denetimi");
            comboBox1.Items.Add("12- K�re-Y�zey �arp��ma Denetimi");
            comboBox1.Items.Add("13- Dikd�rtgen Prizma-Y�zey �arp��ma Denetimi");
            comboBox1.Items.Add("14- Silindir-Y�zey �arp��ma Denetimi");
            comboBox1.Items.Add("15- K�re-Dikd�rtgen Prizma �arp��ma Denetimi");
            comboBox1.Items.Add("16- Dikd�rtgen Prizma-Dikd�rtgen Prizma �arp��ma Denetimi");
            #endregion



        }
        #region 1.Cisim TextBoxlar� i�in handled durumu
        private void txt1W_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // TextBox'un string de�er almas�n� engelledim 
            }
        }
        private void txt1H_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;// TextBox'un string de�er almas�n� engelledim
            }
        }
        private void txt1D_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;// TextBox'un string de�er almas�n� engelledim
            }
        }
        private void txt1R_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;// TextBox'un string de�er almas�n� engelledim
            }
        }
        private void txt1X_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;// TextBox'un string de�er almas�n� engelledim
            }
        }
        private void txt1Y_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;// TextBox'un string de�er almas�n� engelledim
            }
        }
        private void txt1Z_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;// TextBox'un string de�er almas�n� engelledim
            }
        }
        private void txt1NX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;// TextBox'un string de�er almas�n� engelledim
            }
        }
        private void txt1NY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;// TextBox'un string de�er almas�n� engelledim
            }
        }
        private void txt1NZ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;// TextBox'un string de�er almas�n� engelledim
            }
        }
        #endregion

        #region 2.Cisim TextBoxlar� i�in handled
        private void txt2W_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;// TextBox'un string de�er almas�n� engelledim
            }
        }
        private void txt2H_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;// TextBox'un string de�er almas�n� engelledim
            }
        }
        private void txt2D_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;// TextBox'un string de�er almas�n� engelledim
            }
        }
        private void txt2R_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;// TextBox'un string de�er almas�n� engelledim
            }
        }
        private void txt2X_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;// TextBox'un string de�er almas�n� engelledim
            }
        }
        private void txt2Y_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;// TextBox'un string de�er almas�n� engelledim
            }
        }
        private void txt2Z_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;// TextBox'un string de�er almas�n� engelledim
            }
        }
        private void txt2NX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;// TextBox'un string de�er almas�n� engelledim
            }
        }
        private void txt2NY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;// TextBox'un string de�er almas�n� engelledim
            }
        }
        private void txt2NZ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;// TextBox'un string de�er almas�n� engelledim
            }
        }
        #endregion

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0) // Se�ilen denetime g�re gereksiz kutular� devre d��� b�rakt�m
            {
                txt1W.Enabled = false;
                txt1H.Enabled = false;
                txt1D.Enabled = false;
                txt1R.Enabled = false;

                txt1Z.Enabled = false;

                txt1NX.Enabled = false;
                txt1NY.Enabled = false;
                txt1NZ.Enabled = false;


                txt2Z.Enabled = false;
                txt2D.Enabled = false;
                txt2R.Enabled = false;
                txt2NX.Enabled = false;
                txt2NY.Enabled = false;
                txt2NZ.Enabled = false;


            }
            else if (comboBox1.SelectedIndex == 1)
            {
                txt1W.Enabled = false;
                txt1H.Enabled = false;
                txt1D.Enabled = false;
                txt1R.Enabled = false;
                txt1Z.Enabled = false;

                txt1NX.Enabled = false;
                txt1NY.Enabled = false;
                txt1NZ.Enabled = false;

                txt2Z.Enabled = false;
                txt2D.Enabled = false;
                txt2W.Enabled = false;
                txt2H.Enabled = false;

                txt2NX.Enabled = false;
                txt2NY.Enabled = false;
                txt2NZ.Enabled = false;
            }// Se�ilen denetime g�re gereksiz kutular� devre d��� b�rakt�m
            else if (comboBox1.SelectedIndex == 2)// Se�ilen denetime g�re gereksiz kutular� devre d��� b�rakt�m
            {
                txt1D.Enabled = false;
                txt1R.Enabled = false;
                txt1Z.Enabled = false;
                txt1NX.Enabled = false;
                txt1NY.Enabled = false;
                txt1NZ.Enabled = false;

                txt2Z.Enabled = false;
                txt2NX.Enabled = false;
                txt2NY.Enabled = false;
                txt2NZ.Enabled = false;
                txt2D.Enabled = false;
                txt2R.Enabled = false;
            }
            else if (comboBox1.SelectedIndex == 3)// Se�ilen denetime g�re gereksiz kutular� devre d��� b�rakt�m
            {
                txt1D.Enabled = false;
                txt1R.Enabled = false;
                txt1Z.Enabled = false;
                txt1NX.Enabled = false;
                txt1NY.Enabled = false;
                txt1NZ.Enabled = false;

                txt2Z.Enabled = false;
                txt2NX.Enabled = false;
                txt2NY.Enabled = false;
                txt2NZ.Enabled = false;
                txt2D.Enabled = false;

            }
            else if (comboBox1.SelectedIndex == 4)
            {
                txt1W.Enabled = false;
                txt1H.Enabled = false;
                txt1D.Enabled = false;
                txt1Z.Enabled = false;
                txt1NX.Enabled = false;
                txt1NY.Enabled = false;
                txt1NZ.Enabled = false;

                txt2W.Enabled = false;
                txt2H.Enabled = false;
                txt2D.Enabled = false;
                txt2Z.Enabled = false;
                txt2NX.Enabled = false;
                txt2NY.Enabled = false;
                txt2NZ.Enabled = false;
            }// Se�ilen denetime g�re gereksiz kutular� devre d��� b�rakt�m
            else if (comboBox1.SelectedIndex == 5)
            {
                txt1W.Enabled = false;
                txt1H.Enabled = false;
                txt1D.Enabled = false;
                txt1R.Enabled = false;
                txt1NX.Enabled = false;
                txt1NY.Enabled = false;
                txt1NZ.Enabled = false;

                txt2W.Enabled = false;
                txt2H.Enabled = false;
                txt2D.Enabled = false;
                txt2NX.Enabled = false;
                txt2NY.Enabled = false;
                txt2NZ.Enabled = false;
            }// Se�ilen denetime g�re gereksiz kutular� devre d��� b�rakt�m
            else if (comboBox1.SelectedIndex == 6)
            {
                txt1W.Enabled = false;
                txt1H.Enabled = false;
                txt1D.Enabled = false;
                txt1R.Enabled = false;
                txt1NX.Enabled = false;
                txt1NY.Enabled = false;
                txt1NZ.Enabled = false;

                txt2R.Enabled = false;
                txt2NX.Enabled = false;
                txt2NY.Enabled = false;
                txt2NZ.Enabled = false;
            }// Se�ilen denetime g�re gereksiz kutular� devre d��� b�rakt�m
            else if (comboBox1.SelectedIndex == 7)
            {
                txt1W.Enabled = false;
                txt1H.Enabled = false;
                txt1D.Enabled = false;
                txt1R.Enabled = false;
                txt1NX.Enabled = false;
                txt1NY.Enabled = false;
                txt1NZ.Enabled = false;

                txt2W.Enabled = false;
                txt2D.Enabled = false;
                txt2NX.Enabled = false;
                txt2NY.Enabled = false;
                txt2NZ.Enabled = false;
            }// Se�ilen denetime g�re gereksiz kutular� devre d��� b�rakt�m
            else if (comboBox1.SelectedIndex == 8)
            {
                txt1W.Enabled = false;
                txt1D.Enabled = false;
                txt1NX.Enabled = false;
                txt1NY.Enabled = false;
                txt1NZ.Enabled = false;

                txt2W.Enabled = false;
                txt2D.Enabled = false;
                txt2NX.Enabled = false;
                txt2NY.Enabled = false;
                txt2NZ.Enabled = false;

            }// Se�ilen denetime g�re gereksiz kutular� devre d��� b�rakt�m
            else if (comboBox1.SelectedIndex == 9)
            {
                txt1W.Enabled = false;
                txt1H.Enabled = false;
                txt1D.Enabled = false;
                txt1NX.Enabled = false;
                txt1NY.Enabled = false;
                txt1NZ.Enabled = false;

                txt2W.Enabled = false;
                txt2H.Enabled = false;
                txt2D.Enabled = false;
                txt2NX.Enabled = false;
                txt2NY.Enabled = false;
                txt2NZ.Enabled = false;
            }// Se�ilen denetime g�re gereksiz kutular� devre d��� b�rakt�m
            else if (comboBox1.SelectedIndex == 10)
            {
                txt1W.Enabled = false;
                txt1D.Enabled = false;
                txt1H.Enabled = false;
                txt1NX.Enabled = false;
                txt1NY.Enabled = false;
                txt1NZ.Enabled = false;

                txt2W.Enabled = false;
                txt2D.Enabled = false;
                txt2NX.Enabled = false;
                txt2NY.Enabled = false;
                txt2NZ.Enabled = false;
            }// Se�ilen denetime g�re gereksiz kutular� devre d��� b�rakt�m
            else if (comboBox1.SelectedIndex == 11)
            {
                txt1W.Enabled = false;
                txt1D.Enabled = false;
                txt1H.Enabled = false;
                txt1NX.Enabled = false;
                txt1NY.Enabled = false;
                txt1NZ.Enabled = false;

                txt2W.Enabled = false;
                txt2D.Enabled = false;
                txt2H.Enabled = false;
                txt2R.Enabled = false;
            }// Se�ilen denetime g�re gereksiz kutular� devre d��� b�rakt�m
            else if (comboBox1.SelectedIndex == 12)
            {
                txt1R.Enabled = false;
                txt1NX.Enabled = false;
                txt1NY.Enabled = false;
                txt1NZ.Enabled = false;

                txt2D.Enabled = false;
                txt2R.Enabled = false;
                txt2NX.Enabled = false;
                txt2NY.Enabled = false;
                txt2NZ.Enabled = false;
            }// Se�ilen denetime g�re gereksiz kutular� devre d��� b�rakt�m
            else if (comboBox1.SelectedIndex == 13)
            {
                txt1W.Enabled = false;
                txt1D.Enabled = false;
                txt1NX.Enabled = false;
                txt1NY.Enabled = false;
                txt1NZ.Enabled = false;

                txt2R.Enabled = false;
                txt2NX.Enabled = false;
                txt2NY.Enabled = false;
                txt2NZ.Enabled = false;
            }// Se�ilen denetime g�re gereksiz kutular� devre d��� b�rakt�m
            else if (comboBox1.SelectedIndex == 14)
            {
                txt1W.Enabled = false;
                txt1D.Enabled = false;
                txt1H.Enabled = false;
                txt1NX.Enabled = false;
                txt1NY.Enabled = false;
                txt1NZ.Enabled = false;

                txt2R.Enabled = false;
                txt2NX.Enabled = false;
                txt2NY.Enabled = false;
                txt2NZ.Enabled = false;
            }// Se�ilen denetime g�re gereksiz kutular� devre d��� b�rakt�m
            else// Se�ilen denetime g�re gereksiz kutular� devre d��� b�rakt�m
            {
                txt1R.Enabled = false;
                txt1NX.Enabled = false;
                txt1NY.Enabled = false;
                txt1NZ.Enabled = false;

                txt2R.Enabled = false;
                txt2NX.Enabled = false;
                txt2NY.Enabled = false;
                txt2NZ.Enabled = false;
            }
        }

        private void btnS�f�rla_Click(object sender, EventArgs e) // S�f�rla butonuna i�lev eklendi
        {
            comboBox1.SelectedItem = null; // Combobox se�imi s�f�rland�

            txt1W.Enabled = true;//textboxlar enabled true hale getirildi
            txt1D.Enabled = true; //textboxlar enabled true hale getirildi
            txt1H.Enabled = true;//textboxlar enabled true hale getirildi
            txt1R.Enabled = true;//textboxlar enabled true hale getirildi
            txt1X.Enabled = true;//textboxlar enabled true hale getirildi
            txt1Y.Enabled = true;//textboxlar enabled true hale getirildi
            txt1Z.Enabled = true;//textboxlar enabled true hale getirildi
            txt1NX.Enabled = true;//textboxlar enabled true hale getirildi
            txt1NY.Enabled = true;//textboxlar enabled true hale getirildi
            txt1NZ.Enabled = true;//textboxlar enabled true hale getirildi

            txt2W.Enabled = true;//textboxlar enabled true hale getirildi
            txt2D.Enabled = true;//textboxlar enabled true hale getirildi
            txt2H.Enabled = true;//textboxlar enabled true hale getirildi
            txt2R.Enabled = true;//textboxlar enabled true hale getirildi
            txt2X.Enabled = true;//textboxlar enabled true hale getirildi
            txt2Y.Enabled = true;//textboxlar enabled true hale getirildi
            txt2Z.Enabled = true;//textboxlar enabled true hale getirildi
            txt2NX.Enabled = true;//textboxlar enabled true hale getirildi
            txt2NY.Enabled = true;//textboxlar enabled true hale getirildi
            txt2NZ.Enabled = true;//textboxlar enabled true hale getirildi


            txt1W.Text = string.Empty; // Textboxlar�n i�erisi bo� konuma getirildi
            txt1D.Text = string.Empty;// Textboxlar�n i�erisi bo� konuma getirildi
            txt1H.Text = string.Empty;// Textboxlar�n i�erisi bo� konuma getirildi
            txt1R.Text = string.Empty;// Textboxlar�n i�erisi bo� konuma getirildi
            txt1X.Text = string.Empty;// Textboxlar�n i�erisi bo� konuma getirildi
            txt1Y.Text = string.Empty;// Textboxlar�n i�erisi bo� konuma getirildi
            txt1Z.Text = string.Empty;// Textboxlar�n i�erisi bo� konuma getirildi
            txt1NX.Text = string.Empty;// Textboxlar�n i�erisi bo� konuma getirildi
            txt1NY.Text = string.Empty;// Textboxlar�n i�erisi bo� konuma getirildi
            txt1NZ.Text = string.Empty;// Textboxlar�n i�erisi bo� konuma getirildi


            txt2W.Text = string.Empty;// Textboxlar�n i�erisi bo� konuma getirildi
            txt2D.Text = string.Empty;// Textboxlar�n i�erisi bo� konuma getirildi
            txt2H.Text = string.Empty;// Textboxlar�n i�erisi bo� konuma getirildi
            txt2R.Text = string.Empty;// Textboxlar�n i�erisi bo� konuma getirildi
            txt2X.Text = string.Empty;// Textboxlar�n i�erisi bo� konuma getirildi
            txt2Y.Text = string.Empty;// Textboxlar�n i�erisi bo� konuma getirildi
            txt2Z.Text = string.Empty;// Textboxlar�n i�erisi bo� konuma getirildi
            txt2NX.Text = string.Empty;// Textboxlar�n i�erisi bo� konuma getirildi
            txt2NY.Text = string.Empty;// Textboxlar�n i�erisi bo� konuma getirildi
            txt2NZ.Text = string.Empty;// Textboxlar�n i�erisi bo� konuma getirildi

            lblDurum.Text = string.Empty; // Durum bildirgesi bo� hale getirildi
            this.Refresh(); // Form yeniden ba�lat�ld�

        }

        private void btnHesapla_Click(object sender, EventArgs e) // Hesapla butonuna i�lev eklendi
        {
            switch (comboBox1.SelectedIndex) // Combobox '�n se�ilen indeksine g�re metotlar �a��r�ld�.
            {
                case 0:
                    ND_Carpisma();
                    break;
                case 1:
                    NC_Carpisma();
                    break;
                case 2:
                    DD_Carpisma();
                    break;
                case 3:
                    DC_Carpisma();
                    break;
                case 4:
                    CC_Carpisma();
                    break;
                case 5:
                    NK_Carpisma();
                    break;
                case 6:
                    NDP_Carpisma();
                    break;
                case 7:
                    NS_Carpisma();
                    break;
                case 8:
                    SS_Carpisma();
                    break;
                case 9:
                    KK_Carpisma();
                    break;
                case 10:
                    KS_Carpisma();
                    break;
                case 11:
                    KY_Carpisma();
                    break;
                case 12:
                    DPY_Carpisma();
                    break;
                case 13:
                    SY_Carpisma();
                    break;
                case 14:
                    KDP_Carpisma();
                    break;
                case 15:
                    DP_Carpisma();
                    break;

            }
        }

        #region CARPISMALAR

        private void ND_Carpisma()
        {
            // Noktan�n x,y koordinatlar� ile D�rtgenin x,y koordinatlar� ve geni�lik y�kseklik de�erlerini textboxtan ald�m.

            if (txt2W.Text == "" || txt2H.Text == "" || txt2X.Text == "" || txt1X.Text == "" || txt1Y.Text == "" || txt2Y.Text == "")
            {
                MessageBox.Show("L�tfen bo� kutular� doldurunuz", "D�KKAT!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // E�er kullan�c� bunlardan birini bo� girdiyse uyar� mesaj� ��karmas�n� sa�lad�m.
            }
            else
            {  // E�er herhangi bir sorun yoksa �arp��ma denetimi ba�lar
                // Convert.ToInt32 kullanarak textboxtan verilerin al�nmas�n� sa�lad�m.


                float genislik2 = Convert.ToInt32(txt2W.Text) / 2;
                float yukseklik2 = Convert.ToInt32(txt2H.Text) / 2;

                float dortgenMinX = Convert.ToInt32(txt2X.Text) - genislik2;
                float dortgenMaxX = Convert.ToInt32(txt2X.Text) + genislik2;

                float dortgenMinY = Convert.ToInt32(txt2Y.Text) - yukseklik2;
                float dortgenMaxY = Convert.ToInt32(txt2Y.Text) + yukseklik2;

                if ((Convert.ToInt32(txt1X.Text) >= dortgenMinX) &&
                    (Convert.ToInt32(txt1X.Text) <= dortgenMaxX) &&
                    (Convert.ToInt32(txt1Y.Text) <= dortgenMaxY) &&
                    (Convert.ToInt32(txt1Y.Text) >= dortgenMinY))

                { // E�er ko�ul sa�lan�yorsa cisimler �st �ste �izilir ve label'a durum bilgisi verilir.
                    List<GeometrikCisimler> cisimler = new List<GeometrikCisimler>();
                    // Genelleyici s�n�f nesnesi olu�turdum ve cisimleri buna ekledim
                    Nokta nokta = new Nokta();
                    Dortgen dortgen = new Dortgen();

                    cisimler.Add(nokta);
                    cisimler.Add(dortgen);
                    foreach (var item in cisimler)
                    {   // Cisimleri �izdirdim
                        item.Ciz(panel1);
                    }
                    lblDurum.ForeColor = Color.Green;
                    lblDurum.Text = "�ARPI�MA GER�EKLE��R";
                }
                else
                {// E�er ko�ul sa�lan�yorsa cisimler uzak mesafe arayla �izilir ve label'a durum bilgisi verilir.
                    List<GeometrikCisimler> cisimler = new List<GeometrikCisimler>();

                    Nokta nokta = new Nokta();
                    Dortgen2 dortgen2 = new Dortgen2();

                    cisimler.Add(nokta);
                    cisimler.Add(dortgen2);
                    foreach (var item in cisimler)
                    {
                        item.Ciz(panel1);
                    }


                    lblDurum.ForeColor = Color.Red;
                    lblDurum.Text = "�ARPI�MA GER�EKLE�MEZ";
                }
            }

        }
        private void NC_Carpisma()
        {// Noktan�n x,y koordinatlar� ile �emberin x,y koordinatlar� ve yar��ap de�erlerini textboxlardan ald�m.
            if (txt2X.Text == "" || txt1X.Text == "" || txt2Y.Text == "" || txt2Y.Text == "" || txt2R.Text == "")
            {
                MessageBox.Show("L�tfen bo� kutular� doldurunuz", "D�KKAT!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // E�er kullan�c� bunlardan birini bo� girdiyse uyar� mesaj� ��karmas�n� sa�lad�m.

            }

            else
            {   // E�er herhangi bir sorun yoksa �arp��ma denetimi ba�lar
                // Convert.ToInt32 kullanarak textboxtan verilerin al�nmas�n� sa�lad�m.
                float mesafe = (float)Math.Sqrt(Math.Pow(Convert.ToInt32(txt2X.Text) - Convert.ToInt32(txt1X.Text), 2) +
                Math.Pow(Convert.ToInt32(txt2Y.Text) - Convert.ToInt32(txt1Y.Text), 2));

                if (Convert.ToInt32(txt2R.Text) >= mesafe)
                {   // E�er ko�ul sa�lan�yorsa cisimler �st �ste �izilir ve label'a durum bilgisi verilir.
                    List<GeometrikCisimler> cisimler = new List<GeometrikCisimler>();
                    // Genelleyici s�n�f nesnesi olu�turdum ve cisimleri buna ekledim
                    Nokta nokta = new Nokta();
                    Cember cember = new Cember();

                    cisimler.Add(nokta);
                    cisimler.Add(cember);

                    foreach (var item in cisimler)
                    {
                        item.Ciz(panel1);
                    }
                    lblDurum.ForeColor = Color.Green;
                    lblDurum.Text = "�ARPI�MA GER�EKLE��R";
                }
                else
                {// E�er ko�ul sa�lan�yorsa cisimler uzak mesafe arayla �izilir ve label'a durum bilgisi verilir.
                    List<GeometrikCisimler> cisimler = new List<GeometrikCisimler>();

                    Nokta nokta = new Nokta();
                    Cember2 cember2 = new Cember2();

                    cisimler.Add(nokta);
                    cisimler.Add(cember2);

                    foreach (var item in cisimler)
                    {
                        item.Ciz(panel1);
                    }
                    lblDurum.ForeColor = Color.Red;
                    lblDurum.Text = "�ARPI�MA GER�EKLE�MEZ";
                }
            }


        }
        private void DD_Carpisma()
        {   // Dikd�rtgenlerin x,y koordinatlar� ile y�kseklik ve geni�lik de�erlerini textboxtan ald�m.
            if (txt2X.Text == "" || txt1X.Text == "" || txt2Y.Text == "" || txt2Y.Text == "" || txt2W.Text == ""
                || txt2H.Text == "" || txt1W.Text == "" || txt1H.Text == ""
                )
            {
                MessageBox.Show("L�tfen bo� kutular� doldurunuz", "D�KKAT!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // E�er kullan�c� bunlardan birini bo� girdiyse uyar� mesaj� ��karmas�n� sa�lad�m.

            }

            else
            {   // E�er herhangi bir sorun yoksa �arp��ma denetimi ba�lar
                // Convert.ToInt32 kullanarak textboxtan verilerin al�nmas�n� sa�lad�m.
                float kosul1 = (float)Math.Abs(Convert.ToInt32(txt1X.Text) - Convert.ToInt32(txt2X.Text));
                float kosul2 = (float)Math.Abs(Convert.ToInt32(txt1Y.Text) - Convert.ToInt32(txt2Y.Text));

                if ((kosul1 < (Convert.ToInt32(txt1W.Text) / 2) + (Convert.ToInt32(txt2W.Text) / 2)) &&
                    (kosul2 < (Convert.ToInt32(txt1H.Text) / 2) + (Convert.ToInt32(txt2H.Text) / 2)))
                {   // E�er ko�ul sa�lan�yorsa cisimler �st �ste �izilir ve label'a durum bilgisi verilir.
                    List<GeometrikCisimler> cisimler = new List<GeometrikCisimler>();
                    // Genelleyici s�n�f nesnesi olu�turdum ve cisimleri buna ekledim
                    Dikdortgen dikdortgen = new Dikdortgen();
                    Dikdortgen dikdortgen2 = new Dikdortgen();

                    cisimler.Add(dikdortgen);
                    cisimler.Add(dikdortgen2);

                    foreach (var item in cisimler)
                    {
                        item.Ciz(panel1);
                    }
                    lblDurum.ForeColor = Color.Green;
                    lblDurum.Text = "�ARPI�MA GER�EKLE��R";
                }
                else
                {   // E�er ko�ul sa�lan�yorsa cisimler uzak mesafe arayla �izilir ve label'a durum bilgisi verilir.
                    List<GeometrikCisimler> cisimler = new List<GeometrikCisimler>();
                    // Genelleyici s�n�f nesnesi olu�turdum ve cisimleri buna ekledim
                    Dikdortgen dikdortgen = new Dikdortgen();
                    Dikdortgen2 dikdortgen2 = new Dikdortgen2();

                    cisimler.Add(dikdortgen);
                    cisimler.Add(dikdortgen2);

                    foreach (var item in cisimler)
                    {
                        item.Ciz(panel1);
                    }
                    lblDurum.ForeColor = Color.Red;
                    lblDurum.Text = "�ARPI�MA GER�EKLE�MEZ";
                }
            }



        }
        private void DC_Carpisma()
        {   // Dikd�rtgenin x,y koordinatlar� geni�lik ve y�kseklik de�i�kenleri ile �emberin x,y koordinarlar� ile yar��ap de�erlerini textboxtan ald�m.
            if (txt1X.Text == "" || txt1W.Text == "" || txt1H.Text == "" || txt1Y.Text == "" || txt2X.Text == "" || txt2Y.Text == "" || txt2R.Text == "")
            {
                MessageBox.Show("L�tfen bo� kutular� doldurunuz", "D�KKAT!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // E�er kullan�c� bunlardan birini bo� girdiyse uyar� mesaj� ��karmas�n� sa�lad�m.

            }

            else
            {
                float xSol = Convert.ToInt32(txt1X.Text) - (Convert.ToInt32(txt1W.Text) / 2);
                float xSag = Convert.ToInt32(txt1X.Text) + (Convert.ToInt32(txt1W.Text) / 2);

                float yAlt = Convert.ToInt32(txt1Y.Text) - (Convert.ToInt32(txt1H.Text) / 2);
                float yUst = Convert.ToInt32(txt1Y.Text) + (Convert.ToInt32(txt1H.Text) / 2);

                float dx = Convert.ToInt32(txt2X.Text) - Math.Max(xSol, Math.Min(Convert.ToInt32(txt2X.Text), xSag));
                float dy = Convert.ToInt32(txt2Y.Text) - Math.Max(yAlt, Math.Min(Convert.ToInt32(txt2Y.Text), yUst));

                float uzaklik = (float)Math.Sqrt((dx * dx) + (dy * dy));

                if (uzaklik < Convert.ToInt32(txt2R.Text))
                {   // E�er ko�ul sa�lan�yorsa cisimler �st �ste �izilir ve label'a durum bilgisi verilir.
                    List<GeometrikCisimler> cisimler = new List<GeometrikCisimler>();
                    Dikdortgen dikdortgen = new Dikdortgen();
                    Cember cember = new Cember();
                    // Genelleyici s�n�f nesnesi olu�turdum ve cisimleri buna ekledim
                    cisimler.Add(dikdortgen);
                    cisimler.Add(cember);

                    foreach (var item in cisimler)
                    {
                        item.Ciz(panel1);
                    }
                    lblDurum.ForeColor = Color.Green;
                    lblDurum.Text = "�ARPI�MA GER�EKLE��R";
                }
                else
                {   // E�er ko�ul sa�lan�yorsa cisimler uzak mesafe arayla �izilir ve label'a durum bilgisi verilir.
                    List<GeometrikCisimler> cisimler = new List<GeometrikCisimler>();
                    Dikdortgen dikdortgen = new Dikdortgen();
                    Cember2 cember2 = new Cember2();

                    cisimler.Add(dikdortgen);
                    cisimler.Add(cember2);

                    foreach (var item in cisimler)
                    {
                        item.Ciz(panel1);
                    }
                    lblDurum.ForeColor = Color.Red;
                    lblDurum.Text = "�ARPI�MA GER�EKLE�MEZ";
                }
            }

        }
        private void CC_Carpisma()
        { // �emberlerin x,y ve yar��ap de�erlerini textboxtan ald�m.
            if (txt1X.Text == "" || txt1Y.Text == "" || txt1R.Text == "" || txt2X.Text == "" || txt2Y.Text == "" || txt2R.Text == "")
            {
                MessageBox.Show("L�tfen bo� kutular� doldurunuz", "D�KKAT!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                float mesafe =
                (float)Math.Sqrt((Math.Pow(Convert.ToInt32(txt2X.Text) - Convert.ToInt32(txt1X.Text), 2)) +
                Math.Pow(Convert.ToInt32(txt2Y.Text) - Convert.ToInt32(txt1Y.Text), 2));

                if (mesafe < Convert.ToInt32(txt1R.Text) + Convert.ToInt32(txt2R.Text))
                {
                    List<GeometrikCisimler> cisimler = new List<GeometrikCisimler>();

                    Cember cember = new Cember();
                    Cember cember2 = new Cember();

                    cisimler.Add(cember);
                    cisimler.Add(cember2);

                    foreach (var item in cisimler)
                    {
                        item.Ciz(panel1);
                    }
                    lblDurum.ForeColor = Color.Green;
                    lblDurum.Text = "�ARPI�MA GER�EKLE��R";
                }
                else
                {
                    List<GeometrikCisimler> cisimler = new List<GeometrikCisimler>();

                    Cember cember = new Cember();
                    Cember2 cember2 = new Cember2();

                    cisimler.Add(cember);
                    cisimler.Add(cember2);

                    foreach (var item in cisimler)
                    {
                        item.Ciz(panel1);
                    }
                    lblDurum.ForeColor = Color.Red;
                    lblDurum.Text = "�ARPI�MA GER�EKLE�MEZ";
                }
            }

        }
        private void NK_Carpisma()
        {// Noktan�n x,y,z koordinatlar� ile �emberin x,y,z ve yar��ap de�erlerini textboxtan ald�m.
            if (txt1X.Text == "" || txt1Y.Text == "" || txt1Z.Text == "" || txt2X.Text == "" || txt2Y.Text == "" || txt2Z.Text == "" || txt2R.Text == "")
            {
                MessageBox.Show("L�tfen bo� kutular� doldurunuz", "D�KKAT!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else
            {
                float mesafe =
               (float)Math.Sqrt(Math.Pow(Convert.ToInt32(txt1X.Text) - Convert.ToInt32(txt2X.Text), 2) +
               Math.Pow(Convert.ToInt32(txt1Y.Text) - Convert.ToInt32(txt2Y.Text), 2) +
               Math.Pow(Convert.ToInt32(txt1Z.Text) - Convert.ToInt32(txt2Z.Text), 2)
               );

                if (mesafe <= Convert.ToInt32(txt2R.Text))
                {
                    List<GeometrikCisimler> cisimler = new List<GeometrikCisimler>();

                    Nokta nokta = new Nokta();
                    Kure kure = new Kure();

                    cisimler.Add(nokta);
                    cisimler.Add(kure);

                    foreach (var item in cisimler)
                    {
                        item.Ciz(panel1);
                    }
                    lblDurum.ForeColor = Color.Green;
                    lblDurum.Text = "�ARPI�MA GER�EKLE��R";
                }
                else
                {
                    List<GeometrikCisimler> cisimler = new List<GeometrikCisimler>();

                    Nokta nokta = new Nokta();
                    Kure2 kure2 = new Kure2();

                    cisimler.Add(nokta);
                    cisimler.Add(kure2);

                    foreach (var item in cisimler)
                    {
                        item.Ciz(panel1);
                    }
                    lblDurum.ForeColor = Color.Red;
                    lblDurum.Text = "�ARPI�MA GER�EKLE�MEZ";
                }
            }

        }
        private void NDP_Carpisma()
        {// Noktan�n x,y,z koordinatlar� ile Dikd�rtgen P. nin x,y,z geni�lik,y�kseklik ve derinlik de�erlerini textboxtan ald�m.
            if (txt1X.Text == "" || txt1Y.Text == "" || txt1Z.Text == "" || txt2X.Text == "" || txt2Y.Text == "" || txt2Z.Text == "" ||
                txt2W.Text == "" || txt2H.Text == "" || txt2D.Text == "")
            {
                MessageBox.Show("L�tfen bo� kutular� doldurunuz", "D�KKAT!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else
            {
                float vx = Convert.ToInt32(txt2W.Text) / 2;
                float vy = Convert.ToInt32(txt2H.Text) / 2;
                float vz = Convert.ToInt32(txt2D.Text) / 2;

                float mx = Convert.ToInt32(txt2X.Text) + vx;
                float my = Convert.ToInt32(txt2Y.Text) + vy;
                float mz = Convert.ToInt32(txt2Z.Text) + vz;

                float mesafex = Math.Abs(Convert.ToInt32(txt1X.Text) - mx);
                float mesafey = Math.Abs(Convert.ToInt32(txt1Y.Text) - my);
                float mesafez = Math.Abs(Convert.ToInt32(txt1Z.Text) - mz);

                if ((mesafex <= vx) || (mesafey <= vy) || (mesafez <= vz))
                {
                    List<GeometrikCisimler> cisimler = new List<GeometrikCisimler>();

                    Nokta nokta = new Nokta();
                    DikdortgenPrizm dikdortgenPrizm = new DikdortgenPrizm();

                    cisimler.Add(nokta);
                    cisimler.Add(dikdortgenPrizm);

                    foreach (var item in cisimler)
                    {
                        item.Ciz(panel1);
                    }
                    lblDurum.ForeColor = Color.Green;
                    lblDurum.Text = "�ARPI�MA GER�EKLE��R";
                }
                else
                {
                    List<GeometrikCisimler> cisimler = new List<GeometrikCisimler>();

                    Nokta nokta = new Nokta();
                    DikdortgenPrizm2 dikdortgenPrizm2 = new DikdortgenPrizm2();

                    cisimler.Add(nokta);
                    cisimler.Add(dikdortgenPrizm2);

                    foreach (var item in cisimler)
                    {
                        item.Ciz(panel1);
                    }
                    lblDurum.ForeColor = Color.Red;
                    lblDurum.Text = "�ARPI�MA GER�EKLE�MEZ";
                }
            }

        }
        private void NS_Carpisma()
        {// Noktan�n x,y,z koordinatlar� ile Silindirin x,y,z y�kseklik ve yar��ap de�erlerini textboxtan ald�m.
            if (txt1X.Text == "" || txt1Y.Text == "" || txt1Z.Text == "" || txt2X.Text == "" || txt2Y.Text == "" || txt2Z.Text == "" ||
                txt2H.Text == "" || txt2R.Text == "")
            {
                MessageBox.Show("L�tfen bo� kutular� doldurunuz", "D�KKAT!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                if ((Convert.ToInt32(txt2Z.Text) < Convert.ToInt32(txt1Z.Text) - Convert.ToInt32(txt2H.Text) / 2) ||
                Convert.ToInt32(txt2Z.Text) > Convert.ToInt32(txt1Z.Text) + Convert.ToInt32(txt2H.Text) / 2)
                {
                    List<GeometrikCisimler> cisimler = new List<GeometrikCisimler>();

                    Nokta nokta = new Nokta();
                    Silindir silindir = new Silindir();

                    cisimler.Add(nokta);
                    cisimler.Add(silindir);

                    foreach (var item in cisimler)
                    {
                        item.Ciz(panel1);
                    }

                    lblDurum.ForeColor = Color.Green;
                    lblDurum.Text = "�ARPI�MA GER�EKLE��R";
                }
                else
                {
                    float mesafe1 = Convert.ToInt32(txt1X.Text) - Convert.ToInt32(txt2X.Text);
                    float mesafe2 = Convert.ToInt32(txt1Y.Text) - Convert.ToInt32(txt2Y.Text);

                    float mesafe3 = (mesafe1 * mesafe1) + (mesafe2 * mesafe2);

                    if (mesafe3 <= (Convert.ToInt32(txt2R.Text) * Convert.ToInt32(txt2R.Text)))
                    {
                        List<GeometrikCisimler> cisimler = new List<GeometrikCisimler>();

                        Nokta nokta = new Nokta();
                        Silindir silindir = new Silindir();

                        cisimler.Add(nokta);
                        cisimler.Add(silindir);

                        foreach (var item in cisimler)
                        {
                            item.Ciz(panel1);
                        }
                        lblDurum.ForeColor = Color.Green;
                        lblDurum.Text = "�ARPI�MA GER�EKLE��R";
                    }
                    else
                    {
                        List<GeometrikCisimler> cisimler = new List<GeometrikCisimler>();

                        Nokta nokta = new Nokta();
                        Silindir2 silindir2 = new Silindir2();

                        cisimler.Add(nokta);
                        cisimler.Add(silindir2);

                        foreach (var item in cisimler)
                        {
                            item.Ciz(panel1);
                        }
                        lblDurum.ForeColor = Color.Red;
                        lblDurum.Text = "�ARPI�MA GER�EKLE�MEZ";
                    }
                }
            }


        }
        private void SS_Carpisma()
        {// Silindirlerin x,y,z yar��ap ve y�kseklik de�erlerini textboxtan ald�m.
            if (txt1X.Text == "" || txt1Y.Text == "" || txt1Z.Text == "" || txt2X.Text == "" || txt2Y.Text == "" || txt2Z.Text == "" ||
                txt2H.Text == "" || txt2R.Text == "" || txt1H.Text == "" || txt1R.Text == "")
            {
                MessageBox.Show("L�tfen bo� kutular� doldurunuz", "D�KKAT!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {


                float mesafe1 = (float)Math.Sqrt(Math.Pow(Convert.ToInt32(txt2X.Text) - Convert.ToInt32(txt1X.Text), 2) +
                Math.Pow(Convert.ToInt32(txt2Y.Text) - Convert.ToInt32(txt1Y.Text), 2) +
                Math.Pow(Convert.ToInt32(txt2Z.Text) - Convert.ToInt32(txt1Z.Text), 2));

                float mesafe2 = (float)Math.Sqrt(Math.Pow(Convert.ToInt32(txt1R.Text) + Convert.ToInt32(txt2R.Text), 2));

                if ((mesafe1 <= mesafe2) && (Math.Abs(Convert.ToInt32(txt2Z.Text) - Convert.ToInt32(txt1Z.Text))
                    <= (Convert.ToInt32(txt1H.Text) + Convert.ToInt32(txt2H.Text)) / 2
                    ))
                {
                    List<GeometrikCisimler> cisimler = new List<GeometrikCisimler>();

                    Silindir silindir = new Silindir();
                    Silindir silindir2 = new Silindir();

                    cisimler.Add(silindir);
                    cisimler.Add(silindir2);

                    foreach (var item in cisimler)
                    {
                        item.Ciz(panel1);
                    }
                    lblDurum.ForeColor = Color.Green;
                    lblDurum.Text = "�ARPI�MA GER�EKLE��R";
                }
                else
                {
                    List<GeometrikCisimler> cisimler = new List<GeometrikCisimler>();

                    Silindir silindir = new Silindir();
                    Silindir2 silindir2 = new Silindir2();

                    cisimler.Add(silindir);
                    cisimler.Add(silindir2);

                    foreach (var item in cisimler)
                    {
                        item.Ciz(panel1);
                    }
                    lblDurum.ForeColor = Color.Red;
                    lblDurum.Text = "�ARPI�MA GER�EKLE�MEZ";
                }
            }


        }
        private void KK_Carpisma()
        {// K�relerin x,y,z ve yar��ap de�erlerini textboxtan ald�m.
            if (txt1X.Text == "" || txt1Y.Text == "" || txt1Z.Text == "" || txt2X.Text == "" || txt2Y.Text == "" || txt2Z.Text == "" ||
                txt1R.Text == "" || txt2R.Text == "")
            {
                MessageBox.Show("L�tfen bo� kutular� doldurunuz", "D�KKAT!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else
            {
                float mesafe = (float)Math.Sqrt(Math.Pow(Convert.ToInt32(txt2X.Text) - Convert.ToInt32(txt1X.Text), 2) +
                Math.Pow(Convert.ToInt32(txt2Y.Text) - Convert.ToInt32(txt1Y.Text), 2) +
                Math.Pow(Convert.ToInt32(txt2Z.Text) - Convert.ToInt32(txt1Z.Text), 2));

                if (mesafe <= (Convert.ToInt32(txt1R.Text) + Convert.ToInt32(txt2R.Text)))
                {
                    List<GeometrikCisimler> cisimler = new List<GeometrikCisimler>();

                    Kure kure = new Kure();
                    Kure kure2 = new Kure();

                    cisimler.Add(kure);
                    cisimler.Add(kure2);

                    foreach (var item in cisimler)
                    {
                        item.Ciz(panel1);
                    }
                    lblDurum.ForeColor = Color.Green;
                    lblDurum.Text = "�ARPI�MA GER�EKLE��R";
                }
                else
                {
                    List<GeometrikCisimler> cisimler = new List<GeometrikCisimler>();

                    Kure kure = new Kure();
                    Kure2 kure2 = new Kure2();

                    cisimler.Add(kure);
                    cisimler.Add(kure2);

                    foreach (var item in cisimler)
                    {
                        item.Ciz(panel1);
                    }
                    lblDurum.ForeColor = Color.Red;
                    lblDurum.Text = "�ARPI�MA GER�EKLE�MEZ";
                }
            }


        }
        private void KS_Carpisma()
        { // K�renin x,y,z ve yar��ap de�erleri ile Silindirin x,y,z ,yar��ap ve y�kseklik de�erlerini textboxtan ald�m.
            if (txt1X.Text == "" || txt1Y.Text == "" || txt1Z.Text == "" || txt2X.Text == "" || txt2Y.Text == "" || txt2Z.Text == "" ||
                txt1R.Text == "" || txt2R.Text == "" || txt2H.Text == "")
            {
                MessageBox.Show("L�tfen bo� kutular� doldurunuz", "D�KKAT!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else
            {



                float mesafe1 = (float)Math.Sqrt(Math.Pow(Convert.ToInt32(txt2X.Text) - Convert.ToInt32(txt1X.Text), 2) +
                Math.Pow(Convert.ToInt32(txt2Y.Text) - Convert.ToInt32(txt1Y.Text), 2) +
                Math.Pow(Convert.ToInt32(txt2Z.Text) - Convert.ToInt32(txt1Z.Text), 2));

                float mesafe2 = Convert.ToInt32(txt1R.Text) + Convert.ToInt32(txt2R.Text);

                if (mesafe2 > mesafe1)
                {
                    List<GeometrikCisimler> cisimler = new List<GeometrikCisimler>();

                    Kure kure = new Kure();
                    Silindir silindir = new Silindir();

                    cisimler.Add(kure);
                    cisimler.Add(silindir);

                    foreach (var item in cisimler)
                    {
                        item.Ciz(panel1);
                    }
                    lblDurum.ForeColor = Color.Green;
                    lblDurum.Text = "�ARPI�MA GER�EKLE��R";
                }
                else
                {
                    if ((Convert.ToInt32(txt1Z.Text) > ((Convert.ToInt32(txt2Z.Text) - (Convert.ToInt32(txt2H.Text) / 2))) &&
                        (Convert.ToInt32(txt1Z.Text) < (Convert.ToInt32(txt2Z.Text) + (Convert.ToInt32(txt2H.Text) / 2)))))
                    {
                        float mesafe3 = (float)Math.Sqrt(Math.Pow(Convert.ToInt32(txt1X.Text) - Convert.ToInt32(txt2X.Text), 2) +
                            Math.Pow(Convert.ToInt32(txt1Y.Text) - Convert.ToInt32(txt2Y.Text), 2));

                        if (mesafe3 > mesafe2)
                        {
                            List<GeometrikCisimler> cisimler = new List<GeometrikCisimler>();

                            Kure kure = new Kure();
                            Silindir silindir = new Silindir();

                            cisimler.Add(kure);
                            cisimler.Add(silindir);

                            foreach (var item in cisimler)
                            {
                                item.Ciz(panel1);
                            }
                            lblDurum.ForeColor = Color.Green;
                            lblDurum.Text = "�ARPI�MA GER�EKLE��R";
                        }
                        else
                        {
                            List<GeometrikCisimler> cisimler = new List<GeometrikCisimler>();

                            Kure kure = new Kure();
                            Silindir2 silindir2 = new Silindir2();

                            cisimler.Add(kure);
                            cisimler.Add(silindir2);

                            foreach (var item in cisimler)
                            {
                                item.Ciz(panel1);
                            }
                            lblDurum.ForeColor = Color.Red;
                            lblDurum.Text = "�ARPI�MA GER�EKLE�MEZ";
                        }
                    }
                }
            }

        }
        private void KY_Carpisma()
        {// K�renin x,y,z ve yar��ap de�erleri ile y�zeyin x,y,z ve normal x ,normal y,normal z de�erlerini textboxtan ald�m.
            if (txt1X.Text == "" || txt1Y.Text == "" || txt1Z.Text == "" || txt2X.Text == "" || txt2Y.Text == "" || txt2Z.Text == "" ||
                txt1R.Text == "" || txt2NX.Text == "" || txt2NY.Text == "" || txt2NZ.Text == "")
            {
                MessageBox.Show("L�tfen bo� kutular� doldurunuz", "D�KKAT!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {


                float mesafe =
                (Convert.ToInt32(txt1X.Text) - Convert.ToInt32(txt2X.Text)) * Convert.ToInt32(txt2NX.Text) +
                (Convert.ToInt32(txt1Y.Text) - Convert.ToInt32(txt2Y.Text)) * Convert.ToInt32(txt2NY.Text) +
                (Convert.ToInt32(txt1Z.Text) - Convert.ToInt32(txt2Z.Text)) * Convert.ToInt32(txt2NZ.Text);


                if (mesafe < Convert.ToInt32(txt1R.Text))
                {
                    List<GeometrikCisimler> cisimler = new List<GeometrikCisimler>();

                    Kure kure = new Kure();
                    Yuzey yuzey = new Yuzey();

                    cisimler.Add(kure);
                    cisimler.Add(yuzey);

                    foreach (var item in cisimler)
                    {
                        item.Ciz(panel1);
                    }
                    lblDurum.ForeColor = Color.Green;
                    lblDurum.Text = "�ARPI�MA GER�EKLE��R";
                }
                else
                {
                    List<GeometrikCisimler> cisimler = new List<GeometrikCisimler>();

                    Kure kure = new Kure();
                    Yuzey2 yuzey2 = new Yuzey2();

                    cisimler.Add(kure);
                    cisimler.Add(yuzey2);

                    foreach (var item in cisimler)
                    {
                        item.Ciz(panel1);
                    }
                    lblDurum.ForeColor = Color.Red;
                    lblDurum.Text = "�ARPI�MA GER�EKLE�MEZ";
                }
            }

        }
        private void DPY_Carpisma()
        {// Dikd�rtgen P'nin x,y,z ve geni�lik, y�kseklik,derinlik de�erleri ile Y�zeyin x,y,z ve geni�lik, y�kseklik de�erlerini textboxtan ald�m.
            if (txt1X.Text == "" || txt1Y.Text == "" || txt1Z.Text == "" || txt2X.Text == "" || txt2Y.Text == "" || txt2Z.Text == "" ||
                 txt1W.Text == "" || txt1H.Text == "" || txt1D.Text == "")
            {
                MessageBox.Show("L�tfen bo� kutular� doldurunuz", "D�KKAT!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {



                if (
                Convert.ToInt32(txt1X.Text) < (Convert.ToInt32(txt2X.Text) + Convert.ToInt32(txt2W.Text)) &&
                (Convert.ToInt32(txt1X.Text) + Convert.ToInt32(txt1W.Text)) > Convert.ToInt32(txt2X.Text) &&
                Convert.ToInt32(txt1Y.Text) < (Convert.ToInt32(txt2Y.Text) + Convert.ToInt32(txt2H.Text)) &&
                (Convert.ToInt32(txt1Y.Text) + Convert.ToInt32(txt1H.Text)) > Convert.ToInt32(txt2Y.Text) &&
                Convert.ToInt32(txt1Z.Text) < Convert.ToInt32(txt2Z.Text) &&
                (Convert.ToInt32(txt1Z.Text) + Convert.ToInt32(txt1D.Text)) > Convert.ToInt32(txt2Z.Text))


                {
                    List<GeometrikCisimler> cisimler = new List<GeometrikCisimler>();

                    DikdortgenPrizm dikdortgenPrizm = new DikdortgenPrizm();
                    Yuzey yuzey = new Yuzey();

                    cisimler.Add(dikdortgenPrizm);
                    cisimler.Add(yuzey);

                    foreach (var item in cisimler)
                    {
                        item.Ciz(panel1);
                    }
                    lblDurum.ForeColor = Color.Green;
                    lblDurum.Text = "�ARPI�MA GER�EKLE��R";
                }
                else
                {
                    List<GeometrikCisimler> cisimler = new List<GeometrikCisimler>();

                    DikdortgenPrizm dikdortgenPrizm = new DikdortgenPrizm();
                    Yuzey2 yuzey2 = new Yuzey2();

                    cisimler.Add(dikdortgenPrizm);
                    cisimler.Add(yuzey2);

                    foreach (var item in cisimler)
                    {
                        item.Ciz(panel1);
                    }
                    lblDurum.ForeColor = Color.Red;
                    lblDurum.Text = "�ARPI�MA GER�EKLE�MEZ";
                }
            }


        }
        private void SY_Carpisma()
        {// Silindirin x,y,z, yar��ap ve y�kseklik de�erleri ile Y�zeyin x,y,z geni�lik y�kseklik derinlik de�erlerini textboxtan ald�m.
            if (txt1X.Text == "" || txt1Y.Text == "" || txt1Z.Text == "" || txt2X.Text == "" || txt2Y.Text == "" || txt2Z.Text == "" ||
                txt1H.Text == "" || txt1R.Text == "" || txt2W.Text == "" || txt2H.Text == "" || txt2D.Text == "")
            {
                MessageBox.Show("L�tfen bo� kutular� doldurunuz", "D�KKAT!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {



                float nokta =
                (Convert.ToInt32(txt1X.Text) - Convert.ToInt32(txt2X.Text)) * Convert.ToInt32(txt2W.Text) +
                (Convert.ToInt32(txt1Y.Text) - Convert.ToInt32(txt2Y.Text)) * Convert.ToInt32(txt2H.Text) +
                (Convert.ToInt32(txt1Z.Text) - Convert.ToInt32(txt2Z.Text)) * Convert.ToInt32(txt2D.Text);

                float yakinx = (Convert.ToInt32(txt2X.Text) + Convert.ToInt32(txt2W.Text)) * nokta;
                float yakiny = (Convert.ToInt32(txt2Y.Text) + Convert.ToInt32(txt2H.Text)) * nokta;
                float yakinz = (Convert.ToInt32(txt2Z.Text) + Convert.ToInt32(txt2D.Text)) * nokta;

                float mesafe =
                    (float)Math.Sqrt(Math.Pow(Convert.ToInt32(txt1X.Text) - yakinx, 2) +
                    Math.Pow(Convert.ToInt32(txt1Y.Text) - yakiny, 2) +
                    Math.Pow(Convert.ToInt32(txt1Z.Text) - yakinz, 2)
                    );

                if (mesafe <= Convert.ToInt32(txt1R.Text))
                {
                    if (nokta >= 0 && nokta <= Convert.ToInt32(txt1H.Text))
                    {
                        List<GeometrikCisimler> cisimler = new List<GeometrikCisimler>();

                        Silindir silindir = new Silindir();
                        Yuzey yuzey = new Yuzey();

                        cisimler.Add(silindir);
                        cisimler.Add(yuzey);

                        foreach (var item in cisimler)
                        {
                            item.Ciz(panel1);
                        }
                        lblDurum.ForeColor = Color.Green;
                        lblDurum.Text = "�ARPI�MA GER�EKLE��R";
                    }
                    else
                    {
                        List<GeometrikCisimler> cisimler = new List<GeometrikCisimler>();

                        Silindir silindir = new Silindir();
                        Yuzey2 yuzey2 = new Yuzey2();

                        cisimler.Add(silindir);
                        cisimler.Add(yuzey2);

                        foreach (var item in cisimler)
                        {
                            item.Ciz(panel1);
                        }
                        lblDurum.ForeColor = Color.Red;
                        lblDurum.Text = "�ARPI�MA GER�EKLE�MEZ";
                    }
                }
                else
                {
                    List<GeometrikCisimler> cisimler = new List<GeometrikCisimler>();

                    Silindir silindir = new Silindir();
                    Yuzey2 yuzey2 = new Yuzey2();

                    cisimler.Add(silindir);
                    cisimler.Add(yuzey2);

                    foreach (var item in cisimler)
                    {
                        item.Ciz(panel1);
                    }
                    lblDurum.ForeColor = Color.Red;
                    lblDurum.Text = "�ARPI�MA GER�EKLE�MEZ";
                }
            }


        }
        private void KDP_Carpisma()
        {// K�renin x,y,z ve yar��ap de�erleri ile Dikd�rtgen P.'nin x,y,z,geni�lik,yukseklik,derinlik de�erlerini textboxtan ald�m.
            if (txt1X.Text == "" || txt1Y.Text == "" || txt1Z.Text == "" || txt2X.Text == "" || txt2Y.Text == "" || txt2Z.Text == "" ||
                txt1R.Text == "" || txt2W.Text == "" || txt2H.Text == "" || txt2D.Text == "")
            {
                MessageBox.Show("L�tfen bo� kutular� doldurunuz", "D�KKAT!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {


                float yakinx = (float)Math.Max(Convert.ToInt32(txt2X.Text) - Convert.ToInt32(txt2W.Text) / 2,
                Math.Min(Convert.ToInt32(txt1X.Text), Convert.ToInt32(txt2X.Text) + Convert.ToInt32(txt2W.Text) / 2));

                float yakiny = (float)Math.Max(Convert.ToInt32(txt2Y.Text) - Convert.ToInt32(txt2H.Text) / 2,
                    Math.Min(Convert.ToInt32(txt1Y.Text), Convert.ToInt32(txt2Y.Text) + Convert.ToInt32(txt2H.Text) / 2));

                float yakinz = (float)Math.Max(Convert.ToInt32(txt2Z.Text) - Convert.ToInt32(txt2D.Text) / 2,
                    Math.Min(Convert.ToInt32(txt1Z.Text), Convert.ToInt32(txt2Z.Text) + Convert.ToInt32(txt2D.Text) / 2));

                float mesafeX = yakinx - Convert.ToInt32(txt1X.Text);
                float mesafeY = yakiny - Convert.ToInt32(txt1Y.Text);
                float mesafeZ = yakinz - Convert.ToInt32(txt1Z.Text);

                float mesafe4 = (mesafeX * mesafeX) + (mesafeY * mesafeY) + (mesafeZ * mesafeZ);

                if (mesafe4 <= (Convert.ToInt32(txt1R.Text) * Convert.ToInt32(txt1R.Text)))
                {
                    List<GeometrikCisimler> cisimler = new List<GeometrikCisimler>();

                    Kure kure = new Kure();
                    DikdortgenPrizm dikdortgenPrizm = new DikdortgenPrizm();

                    cisimler.Add(kure);
                    cisimler.Add(dikdortgenPrizm);

                    foreach (var item in cisimler)
                    {
                        item.Ciz(panel1);
                    }
                    lblDurum.ForeColor = Color.Green;
                    lblDurum.Text = "�ARPI�MA GER�EKLE��R";
                }
                else
                {
                    List<GeometrikCisimler> cisimler = new List<GeometrikCisimler>();

                    Kure kure = new Kure();
                    DikdortgenPrizm2 dikdortgenPrizm2 = new DikdortgenPrizm2();

                    cisimler.Add(kure);
                    cisimler.Add(dikdortgenPrizm2);

                    foreach (var item in cisimler)
                    {
                        item.Ciz(panel1);
                    }
                    lblDurum.ForeColor = Color.Red;
                    lblDurum.Text = "�ARPI�MA GER�EKLE�MEZ";
                }
            }


        }
        private void DP_Carpisma()
        { // Dikd�rtgen Prizmalar�n x,y,z,geni�lik,y�kseklik,derinlik de�erlerini textboxtan ald�m.
            if (txt1X.Text == "" || txt1Y.Text == "" || txt1Z.Text == "" || txt2X.Text == "" || txt2Y.Text == "" || txt2Z.Text == "" ||
                txt1W.Text == "" || txt1H.Text == "" || txt1D.Text == "" || txt2W.Text == "" || txt2H.Text == "" || txt2D.Text == "")
            {
                MessageBox.Show("L�tfen bo� kutular� doldurunuz", "D�KKAT!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {


                float xMin1 = Convert.ToInt32(txt1X.Text) - (Convert.ToInt32(txt1W.Text) / 2);
                float xMax1 = Convert.ToInt32(txt1X.Text) + (Convert.ToInt32(txt1W.Text) / 2);
                float yMin1 = Convert.ToInt32(txt1Y.Text) - (Convert.ToInt32(txt1H.Text) / 2);
                float yMax1 = Convert.ToInt32(txt1Y.Text) + (Convert.ToInt32(txt1H.Text) / 2);
                float zMin1 = Convert.ToInt32(txt1Z.Text) - (Convert.ToInt32(txt1D.Text) / 2);
                float zMax1 = Convert.ToInt32(txt1Z.Text) + (Convert.ToInt32(txt1D.Text) / 2);

                float xMin2 = Convert.ToInt32(txt2X.Text) - (Convert.ToInt32(txt2W.Text) / 2);
                float xMax2 = Convert.ToInt32(txt2X.Text) + (Convert.ToInt32(txt2W.Text) / 2);
                float yMin2 = Convert.ToInt32(txt2Y.Text) - (Convert.ToInt32(txt2H.Text) / 2);
                float yMax2 = Convert.ToInt32(txt2Y.Text) + (Convert.ToInt32(txt2H.Text) / 2);
                float zMin2 = Convert.ToInt32(txt2Z.Text) - (Convert.ToInt32(txt2D.Text) / 2);
                float zMax2 = Convert.ToInt32(txt2Z.Text) + (Convert.ToInt32(txt2D.Text) / 2);

                if ((xMin1 <= xMax2) && (xMax1 >= xMin2) &&
                    (yMin1 <= yMax2) && (yMax1 >= yMin2) &&
                    (zMin1 <= zMax2) && (zMax1 >= zMin2)
                    )
                {
                    List<GeometrikCisimler> cisimler = new List<GeometrikCisimler>();

                    DikdortgenPrizm dikdortgenPrizm = new DikdortgenPrizm();
                    DikdortgenPrizm dikdortgenPrizm2 = new DikdortgenPrizm();

                    cisimler.Add(dikdortgenPrizm);
                    cisimler.Add(dikdortgenPrizm2);

                    foreach (var item in cisimler)
                    {
                        item.Ciz(panel1);
                    }
                    lblDurum.ForeColor = Color.Green;
                    lblDurum.Text = "�ARPI�MA GER�EKLE��R";
                }
                else
                {
                    List<GeometrikCisimler> cisimler = new List<GeometrikCisimler>();

                    DikdortgenPrizm dikdortgenPrizm = new DikdortgenPrizm();
                    DikdortgenPrizm2 dikdortgenPrizm2 = new DikdortgenPrizm2();

                    cisimler.Add(dikdortgenPrizm);
                    cisimler.Add(dikdortgenPrizm2);

                    foreach (var item in cisimler)
                    {
                        item.Ciz(panel1);
                    }
                    lblDurum.ForeColor = Color.Red;
                    lblDurum.Text = "�ARPI�MA GER�EKLE�MEZ";
                }
            }

        }

        #endregion
    }
}
