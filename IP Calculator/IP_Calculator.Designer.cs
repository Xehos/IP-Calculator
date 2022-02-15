
namespace IP_Calculator
{
    partial class IP_Calculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.inputGb = new System.Windows.Forms.GroupBox();
            this.prfxBox = new System.Windows.Forms.ComboBox();
            this.prefixLenLbl = new System.Windows.Forms.Label();
            this.IPAddrLbl = new System.Windows.Forms.Label();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.sbntLbl = new System.Windows.Forms.Label();
            this.outputGb = new System.Windows.Forms.GroupBox();
            this.sbntStr = new System.Windows.Forms.RichTextBox();
            this.lastAssignedBinary = new System.Windows.Forms.RichTextBox();
            this.lastAssignedStr = new System.Windows.Forms.RichTextBox();
            this.firstAssignedBinary = new System.Windows.Forms.RichTextBox();
            this.firstAssignedStr = new System.Windows.Forms.RichTextBox();
            this.lastAssignedLbl = new System.Windows.Forms.Label();
            this.firstassignedLbl = new System.Windows.Forms.Label();
            this.broadcastAddrLbl = new System.Windows.Forms.Label();
            this.broadcastBinary = new System.Windows.Forms.RichTextBox();
            this.broadcastStr = new System.Windows.Forms.RichTextBox();
            this.sbntMaskBinary = new System.Windows.Forms.RichTextBox();
            this.sbntMask = new System.Windows.Forms.RichTextBox();
            this.sbntMaskLbl = new System.Windows.Forms.Label();
            this.sbntBinary = new System.Windows.Forms.RichTextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.WebPageLink = new System.Windows.Forms.LinkLabel();
            this.copyLabel = new System.Windows.Forms.Label();
            this.langLbl = new System.Windows.Forms.Label();
            this.CbLang = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.inputGb.SuspendLayout();
            this.outputGb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputGb
            // 
            this.inputGb.Controls.Add(this.prfxBox);
            this.inputGb.Controls.Add(this.prefixLenLbl);
            this.inputGb.Controls.Add(this.IPAddrLbl);
            this.inputGb.Controls.Add(this.addressBox);
            this.inputGb.Location = new System.Drawing.Point(12, 25);
            this.inputGb.Name = "inputGb";
            this.inputGb.Size = new System.Drawing.Size(606, 124);
            this.inputGb.TabIndex = 0;
            this.inputGb.TabStop = false;
            this.inputGb.Text = "Vstup";
            // 
            // prfxBox
            // 
            this.prfxBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.prfxBox.FormattingEnabled = true;
            this.prfxBox.Items.AddRange(new object[] {
            "/30",
            "/29",
            "/28",
            "/27",
            "/26",
            "/25",
            "/24",
            "/23",
            "/22",
            "/21",
            "/20",
            "/19",
            "/18",
            "/17",
            "/16",
            "/15",
            "/14",
            "/13",
            "/12",
            "/11",
            "/10",
            "/9",
            "/8",
            "/7",
            "/6",
            "/5",
            "/4",
            "/3",
            "/2",
            "/1",
            "/0"});
            this.prfxBox.Location = new System.Drawing.Point(356, 59);
            this.prfxBox.Name = "prfxBox";
            this.prfxBox.Size = new System.Drawing.Size(105, 23);
            this.prfxBox.TabIndex = 3;
            // 
            // prefixLenLbl
            // 
            this.prefixLenLbl.AutoSize = true;
            this.prefixLenLbl.Location = new System.Drawing.Point(356, 24);
            this.prefixLenLbl.Name = "prefixLenLbl";
            this.prefixLenLbl.Size = new System.Drawing.Size(76, 15);
            this.prefixLenLbl.TabIndex = 2;
            this.prefixLenLbl.Text = "Délka prefixu";
            // 
            // IPAddrLbl
            // 
            this.IPAddrLbl.AutoSize = true;
            this.IPAddrLbl.Location = new System.Drawing.Point(93, 24);
            this.IPAddrLbl.Name = "IPAddrLbl";
            this.IPAddrLbl.Size = new System.Drawing.Size(56, 15);
            this.IPAddrLbl.TabIndex = 1;
            this.IPAddrLbl.Text = "IP Adresa";
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(93, 59);
            this.addressBox.Name = "addressBox";
            this.addressBox.PlaceholderText = "192.168.0.1";
            this.addressBox.Size = new System.Drawing.Size(223, 23);
            this.addressBox.TabIndex = 0;
            this.addressBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.addressBox_KeyDown);
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.Location = new System.Drawing.Point(269, 164);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(78, 32);
            this.BtnCalculate.TabIndex = 4;
            this.BtnCalculate.Text = "Vypočítat";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // sbntLbl
            // 
            this.sbntLbl.AutoSize = true;
            this.sbntLbl.Location = new System.Drawing.Point(118, 32);
            this.sbntLbl.Name = "sbntLbl";
            this.sbntLbl.Size = new System.Drawing.Size(41, 15);
            this.sbntLbl.TabIndex = 5;
            this.sbntLbl.Text = "Podsíť";
            // 
            // outputGb
            // 
            this.outputGb.Controls.Add(this.sbntStr);
            this.outputGb.Controls.Add(this.lastAssignedBinary);
            this.outputGb.Controls.Add(this.lastAssignedStr);
            this.outputGb.Controls.Add(this.firstAssignedBinary);
            this.outputGb.Controls.Add(this.firstAssignedStr);
            this.outputGb.Controls.Add(this.lastAssignedLbl);
            this.outputGb.Controls.Add(this.firstassignedLbl);
            this.outputGb.Controls.Add(this.broadcastAddrLbl);
            this.outputGb.Controls.Add(this.broadcastBinary);
            this.outputGb.Controls.Add(this.broadcastStr);
            this.outputGb.Controls.Add(this.sbntMaskBinary);
            this.outputGb.Controls.Add(this.sbntMask);
            this.outputGb.Controls.Add(this.sbntMaskLbl);
            this.outputGb.Controls.Add(this.sbntBinary);
            this.outputGb.Controls.Add(this.sbntLbl);
            this.outputGb.Location = new System.Drawing.Point(12, 202);
            this.outputGb.Name = "outputGb";
            this.outputGb.Size = new System.Drawing.Size(606, 330);
            this.outputGb.TabIndex = 6;
            this.outputGb.TabStop = false;
            this.outputGb.Text = "Výstup";
            // 
            // sbntStr
            // 
            this.sbntStr.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sbntStr.Location = new System.Drawing.Point(234, 20);
            this.sbntStr.Name = "sbntStr";
            this.sbntStr.ReadOnly = true;
            this.sbntStr.Size = new System.Drawing.Size(167, 23);
            this.sbntStr.TabIndex = 19;
            this.sbntStr.Text = "";
            // 
            // lastAssignedBinary
            // 
            this.lastAssignedBinary.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastAssignedBinary.Location = new System.Drawing.Point(315, 298);
            this.lastAssignedBinary.Name = "lastAssignedBinary";
            this.lastAssignedBinary.ReadOnly = true;
            this.lastAssignedBinary.Size = new System.Drawing.Size(285, 23);
            this.lastAssignedBinary.TabIndex = 18;
            this.lastAssignedBinary.Text = "";
            // 
            // lastAssignedStr
            // 
            this.lastAssignedStr.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastAssignedStr.Location = new System.Drawing.Point(6, 257);
            this.lastAssignedStr.Name = "lastAssignedStr";
            this.lastAssignedStr.ReadOnly = true;
            this.lastAssignedStr.Size = new System.Drawing.Size(285, 23);
            this.lastAssignedStr.TabIndex = 17;
            this.lastAssignedStr.Text = "";
            // 
            // firstAssignedBinary
            // 
            this.firstAssignedBinary.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstAssignedBinary.Location = new System.Drawing.Point(6, 298);
            this.firstAssignedBinary.Name = "firstAssignedBinary";
            this.firstAssignedBinary.ReadOnly = true;
            this.firstAssignedBinary.Size = new System.Drawing.Size(285, 23);
            this.firstAssignedBinary.TabIndex = 16;
            this.firstAssignedBinary.Text = "";
            // 
            // firstAssignedStr
            // 
            this.firstAssignedStr.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstAssignedStr.Location = new System.Drawing.Point(315, 255);
            this.firstAssignedStr.Name = "firstAssignedStr";
            this.firstAssignedStr.ReadOnly = true;
            this.firstAssignedStr.Size = new System.Drawing.Size(285, 23);
            this.firstAssignedStr.TabIndex = 15;
            this.firstAssignedStr.Text = "";
            // 
            // lastAssignedLbl
            // 
            this.lastAssignedLbl.AutoSize = true;
            this.lastAssignedLbl.Location = new System.Drawing.Point(386, 237);
            this.lastAssignedLbl.Name = "lastAssignedLbl";
            this.lastAssignedLbl.Size = new System.Drawing.Size(140, 15);
            this.lastAssignedLbl.TabIndex = 14;
            this.lastAssignedLbl.Text = "Poslední přiřazená adresa";
            // 
            // firstassignedLbl
            // 
            this.firstassignedLbl.AutoSize = true;
            this.firstassignedLbl.Location = new System.Drawing.Point(76, 239);
            this.firstassignedLbl.Name = "firstassignedLbl";
            this.firstassignedLbl.Size = new System.Drawing.Size(122, 15);
            this.firstassignedLbl.TabIndex = 13;
            this.firstassignedLbl.Text = "První přiřazená adresa";
            // 
            // broadcastAddrLbl
            // 
            this.broadcastAddrLbl.AutoSize = true;
            this.broadcastAddrLbl.Location = new System.Drawing.Point(118, 170);
            this.broadcastAddrLbl.Name = "broadcastAddrLbl";
            this.broadcastAddrLbl.Size = new System.Drawing.Size(105, 15);
            this.broadcastAddrLbl.TabIndex = 12;
            this.broadcastAddrLbl.Text = "Adresa broadcastu";
            // 
            // broadcastBinary
            // 
            this.broadcastBinary.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.broadcastBinary.Location = new System.Drawing.Point(118, 196);
            this.broadcastBinary.Name = "broadcastBinary";
            this.broadcastBinary.ReadOnly = true;
            this.broadcastBinary.Size = new System.Drawing.Size(350, 23);
            this.broadcastBinary.TabIndex = 11;
            this.broadcastBinary.Text = "";
            // 
            // broadcastStr
            // 
            this.broadcastStr.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.broadcastStr.Location = new System.Drawing.Point(234, 167);
            this.broadcastStr.Name = "broadcastStr";
            this.broadcastStr.ReadOnly = true;
            this.broadcastStr.Size = new System.Drawing.Size(167, 23);
            this.broadcastStr.TabIndex = 10;
            this.broadcastStr.Text = "";
            // 
            // sbntMaskBinary
            // 
            this.sbntMaskBinary.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sbntMaskBinary.Location = new System.Drawing.Point(118, 117);
            this.sbntMaskBinary.Name = "sbntMaskBinary";
            this.sbntMaskBinary.ReadOnly = true;
            this.sbntMaskBinary.Size = new System.Drawing.Size(350, 23);
            this.sbntMaskBinary.TabIndex = 9;
            this.sbntMaskBinary.Text = "";
            // 
            // sbntMask
            // 
            this.sbntMask.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sbntMask.Location = new System.Drawing.Point(234, 88);
            this.sbntMask.Name = "sbntMask";
            this.sbntMask.ReadOnly = true;
            this.sbntMask.Size = new System.Drawing.Size(167, 23);
            this.sbntMask.TabIndex = 8;
            this.sbntMask.Text = "";
            // 
            // sbntMaskLbl
            // 
            this.sbntMaskLbl.AutoSize = true;
            this.sbntMaskLbl.Location = new System.Drawing.Point(118, 91);
            this.sbntMaskLbl.Name = "sbntMaskLbl";
            this.sbntMaskLbl.Size = new System.Drawing.Size(83, 15);
            this.sbntMaskLbl.TabIndex = 7;
            this.sbntMaskLbl.Text = "Maska podsítě";
            // 
            // sbntBinary
            // 
            this.sbntBinary.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sbntBinary.Location = new System.Drawing.Point(118, 50);
            this.sbntBinary.Name = "sbntBinary";
            this.sbntBinary.ReadOnly = true;
            this.sbntBinary.Size = new System.Drawing.Size(350, 23);
            this.sbntBinary.TabIndex = 6;
            this.sbntBinary.Text = "";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.WebPageLink);
            this.panel1.Controls.Add(this.copyLabel);
            this.panel1.Location = new System.Drawing.Point(-3, 556);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(636, 35);
            this.panel1.TabIndex = 20;
            // 
            // WebPageLink
            // 
            this.WebPageLink.AutoSize = true;
            this.WebPageLink.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WebPageLink.ForeColor = System.Drawing.Color.Navy;
            this.WebPageLink.LinkColor = System.Drawing.Color.Black;
            this.WebPageLink.Location = new System.Drawing.Point(366, 7);
            this.WebPageLink.Name = "WebPageLink";
            this.WebPageLink.Size = new System.Drawing.Size(110, 14);
            this.WebPageLink.TabIndex = 8;
            this.WebPageLink.TabStop = true;
            this.WebPageLink.Text = "https://xehos.cz";
            this.WebPageLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.WebPageLink_LinkClicked);
            // 
            // copyLabel
            // 
            this.copyLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.copyLabel.AutoSize = true;
            this.copyLabel.BackColor = System.Drawing.Color.Silver;
            this.copyLabel.CausesValidation = false;
            this.copyLabel.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.copyLabel.Location = new System.Drawing.Point(493, 7);
            this.copyLabel.Name = "copyLabel";
            this.copyLabel.Size = new System.Drawing.Size(129, 14);
            this.copyLabel.TabIndex = 7;
            this.copyLabel.Text = "Adam Huml © 2022";
            // 
            // langLbl
            // 
            this.langLbl.AutoSize = true;
            this.langLbl.Location = new System.Drawing.Point(511, 8);
            this.langLbl.Name = "langLbl";
            this.langLbl.Size = new System.Drawing.Size(34, 15);
            this.langLbl.TabIndex = 21;
            this.langLbl.Text = "Jazyk";
            // 
            // CbLang
            // 
            this.CbLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbLang.FormattingEnabled = true;
            this.CbLang.Items.AddRange(new object[] {
            "CZ",
            "EN"});
            this.CbLang.Location = new System.Drawing.Point(551, 5);
            this.CbLang.Name = "CbLang";
            this.CbLang.Size = new System.Drawing.Size(64, 23);
            this.CbLang.TabIndex = 22;
            this.CbLang.SelectedIndexChanged += new System.EventHandler(this.CbLang_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Location = new System.Drawing.Point(479, 556);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 28);
            this.panel2.TabIndex = 20;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.Location = new System.Drawing.Point(354, 556);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(3, 28);
            this.panel3.TabIndex = 21;
            // 
            // IP_Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 583);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.CbLang);
            this.Controls.Add(this.langLbl);
            this.Controls.Add(this.outputGb);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnCalculate);
            this.Controls.Add(this.inputGb);
            this.Name = "IP_Calculator";
            this.Text = "IP Kalkulačka";
            this.inputGb.ResumeLayout(false);
            this.inputGb.PerformLayout();
            this.outputGb.ResumeLayout(false);
            this.outputGb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox inputGb;
        private System.Windows.Forms.ComboBox prfxBox;
        private System.Windows.Forms.Label prefixLenLbl;
        private System.Windows.Forms.Label IPAddrLbl;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.Label sbntLbl;
        private System.Windows.Forms.GroupBox outputGb;
        private System.Windows.Forms.RichTextBox lastAssignedBinary;
        private System.Windows.Forms.RichTextBox lastAssignedStr;
        private System.Windows.Forms.RichTextBox firstAssignedBinary;
        private System.Windows.Forms.RichTextBox firstAssignedStr;
        private System.Windows.Forms.Label lastAssignedLbl;
        private System.Windows.Forms.Label firstassignedLbl;
        private System.Windows.Forms.Label broadcastAddrLbl;
        private System.Windows.Forms.RichTextBox broadcastBinary;
        private System.Windows.Forms.RichTextBox broadcastStr;
        private System.Windows.Forms.RichTextBox sbntMaskBinary;
        private System.Windows.Forms.RichTextBox sbntMask;
        private System.Windows.Forms.Label sbntMaskLbl;
        private System.Windows.Forms.RichTextBox sbntBinary;
        private System.Windows.Forms.RichTextBox sbntStr;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label copyLabel;
        private System.Windows.Forms.ComboBox CbLang;
        private System.Windows.Forms.Label langLbl;
        private System.Windows.Forms.LinkLabel WebPageLink;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}

