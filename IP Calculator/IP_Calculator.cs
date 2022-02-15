using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace IP_Calculator
{
    public partial class IP_Calculator : Form
    {
        string invalidIPError;
        private static void RichboxAppend(RichTextBox textbox, string text, Color color)
        {
            textbox.SelectionStart = textbox.TextLength;
            textbox.SelectionLength = 0;

            textbox.SelectionColor = color;
            textbox.AppendText(text);
            textbox.SelectionColor = textbox.ForeColor;
        }
        private void Console_Load(object sender) //Console definition
        {
            AllocConsole();
        }
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
        public IP_Calculator()
        {
            /* For Debug */
            //Console_Load(this); 
            InitializeComponent();
            prfxBox.SelectedIndex = 6;
            
            CbLang.SelectedIndex = 1; // English default
            copyLabel.Text = "Adam Huml © " + Convert.ToString(DateTime.Now.Year);
            

        }

        private string List_to_str(List<string> list, string delimiter)
        {
            string str = "";
            int i = 0;

            foreach (string chunk in list)
            {
                i += 1;
                str += chunk;
                if (i < 4)
                {
                    str += delimiter;
                }
            }

            return str;
        }

        private void TbClear()
        {
            sbntMaskBinary.Text = sbntMask.Text = sbntBinary.Text = sbntStr.Text
                    = broadcastBinary.Text = broadcastStr.Text = firstAssignedBinary.Text
                    = firstAssignedStr.Text = lastAssignedBinary.Text
                    = lastAssignedStr.Text = "";
        }

        private void Colorized_RichTextbox(RichTextBox box, string ip_sbnt, string ip_diff)
        {
            for (int x = 0; x < ip_sbnt.Count(); x++)
            {
                if (ip_sbnt[x] == ip_diff[x])
                {
                    RichboxAppend(box, Convert.ToString(ip_diff[x]), Color.Black);
                }
                else
                {
                    RichboxAppend(box, Convert.ToString(ip_diff[x]), Color.Red);
                }
            }
        }

            private void BtnCalculate_Click(object sender, EventArgs e)
        {
            try
            {

                foreach (string chunk in addressBox.Text.Split("."))
                {
                    if (Convert.ToInt32(chunk) > 255 || Convert.ToInt32(chunk) < 0 || chunk.Count() > 3 || addressBox.Text.Count(f => f == '.') != 3)
                    {
                        throw new System.FormatException();
                    }
                }
                TbClear();
                errorProvider.Clear();
                IP ip = new IP(addressBox.Text, prfxBox.Text);
                List<string> ip_address_bin = ip.Ip_to_bin();
                List<string> subnet_mask_bin = ip.Prefix_to_sbntMask();

                Console.WriteLine("Adresa = " + List_to_str(ip_address_bin, "."));
                // Maska podsite
                sbntMaskBinary.Text = List_to_str(subnet_mask_bin, ".");
                string sbntMaskStr  = List_to_str(ip.Bin_to_ip(sbntMaskBinary.Text), ".");
                sbntMask.Text = sbntMaskStr;
                
                // Podsit
                string sbntBin = List_to_str(ip.Get_network_address(ip_address_bin, subnet_mask_bin), ".");
                string sbntString = List_to_str(ip.Bin_to_ip(sbntBin), ".") + prfxBox.Text;
                sbntBinary.Text = sbntBin;
                sbntStr.Text = sbntString;

                // Broadcast
                string broadcastBin = List_to_str(ip.Get_broadcast_address(List_to_str(ip_address_bin, "")), ".");
                string broadcastString = List_to_str(ip.Bin_to_ip(broadcastBin), ".");
                broadcastStr.Text = broadcastString;
                Colorized_RichTextbox(broadcastBinary, sbntBin, broadcastBin);

                // Prvni prirazena
                string firstAssignedBin = List_to_str(ip.Get_first_assigned(List_to_str(ip_address_bin, "")), ".");
                string firstAssignedString = List_to_str(ip.Bin_to_ip(firstAssignedBin), ".");
                firstAssignedStr.Text = firstAssignedString;
                Colorized_RichTextbox(firstAssignedBinary, sbntBin, firstAssignedBin);
                
                // Posledni prirazena
                string lastAssignedBin = List_to_str(ip.Get_last_assigned(List_to_str(ip_address_bin, "")), ".");
                Colorized_RichTextbox(lastAssignedBinary, sbntBin, lastAssignedBin);
                lastAssignedStr.Text = List_to_str(ip.Bin_to_ip(lastAssignedBinary.Text), ".");
            }
            catch (System.FormatException)
            {
                errorProvider.SetError(addressBox, invalidIPError);
                System.Media.SystemSounds.Beep.Play();
                TbClear();
            }
        }

        private void addressBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnCalculate.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void CbLang_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> cz = new List<string> { "IP Kalkulačka", "Jazyk", "Vstup", "IP Adresa", "Délka prefixu", "Výstup", 
                "Podsíť", "Maska podsítě", "Adresa broadcastu", "První přiřazená adresa", "Poslední přiřazená adresa" , "Vypočítat",
            "Zadaná IP adresa není platná!"};
            
            
            List<string> en = new List<string> { "IP Calculator", "Lang.", "Input" , "IP Address", "Prefix length", "Output",
            "Subnet", "Subnet mask", "Broadcast address", "First assigned address", "Last assigned address", "Calculate", 
                "Entered IP is not valid!"};
            List<string> lang_list;
            switch (CbLang.SelectedIndex)
            {
                case 0:
                     lang_list = cz;
                    break;
                case 1:
                     lang_list = en;
                    break;
                default:
                    lang_list = en;
                    break;
            }
            
            this.Text = lang_list[0];
            langLbl.Text = lang_list[1];
            inputGb.Text = lang_list[2];
            IPAddrLbl.Text = lang_list[3];
            prefixLenLbl.Text = lang_list[4];
            outputGb.Text = lang_list[5];
            sbntLbl.Text = lang_list[6];
            sbntMaskLbl.Text = lang_list[7];
            broadcastAddrLbl.Text =  lang_list[8];
            firstassignedLbl.Text = lang_list[9];
            lastAssignedLbl.Text = lang_list[10];
            BtnCalculate.Text = lang_list[11];
            invalidIPError = lang_list[12];


        }

        private void WebPageLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/c start " + WebPageLink.Text;
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            process.StartInfo = startInfo;
            process.Start();
        }
    }
}
