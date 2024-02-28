using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DXApp_Listbox_Veri_Ekleme
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        int i = 0;
        string[] dizi = new string[10];
        public Form1()
        {
            InitializeComponent();
        }


        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (i < 10)
            {
                // Kullanıcı tarafından girilen metin
                string newItem = textEdit1.Text;
                // İlk harfi büyük yap
                newItem = char.ToUpper(newItem[0]) + newItem.Substring(1);

                // Diziye ve ListBox'a öğe ekle
                dizi[i] = newItem;
                listBox1.Items.Add(newItem);
                i++;
                textEdit1.Clear();
                textEdit1.Focus();
            }
            

        }
    }
}
