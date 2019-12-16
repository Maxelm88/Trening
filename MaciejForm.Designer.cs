namespace Trening
{
    partial class MaciejForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaciejForm));
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerData = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIloscOkrazen = new System.Windows.Forms.TextBox();
            this.txtGodzina = new System.Windows.Forms.TextBox();
            this.txtDystans = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboMiesiac = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboRok = new System.Windows.Forms.ComboBox();
            this.dataGridViewMaciej = new System.Windows.Forms.DataGridView();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnEdytuj = new System.Windows.Forms.Button();
            this.btnUsun = new System.Windows.Forms.Button();
            this.btnPrzelicz = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMinuta = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtSekunda = new System.Windows.Forms.TextBox();
            this.txtCzas = new System.Windows.Forms.Label();
            this.txtSrednieTempo = new System.Windows.Forms.Label();
            this.txtSredniaPredkosc = new System.Windows.Forms.Label();
            this.txtSredniCzasOkrazenia = new System.Windows.Forms.Label();
            this.bindingSourceMaciej = new System.Windows.Forms.BindingSource(this.components);
            this.btnSzukaj = new System.Windows.Forms.Button();
            this.txtSumaCzas = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtSumaDystans = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtSumaSrednieTempo = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtSumaSredniaPredkosc = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtSumaSredniCzasOkrazen = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txtOkres = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtSumaIloscOkrazen = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaciej)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMaciej)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // dateTimePickerData
            // 
            resources.ApplyResources(this.dateTimePickerData, "dateTimePickerData");
            this.dateTimePickerData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerData.Name = "dateTimePickerData";
            this.dateTimePickerData.Value = new System.DateTime(2019, 12, 5, 0, 0, 0, 0);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // txtIloscOkrazen
            // 
            resources.ApplyResources(this.txtIloscOkrazen, "txtIloscOkrazen");
            this.txtIloscOkrazen.Name = "txtIloscOkrazen";
            this.txtIloscOkrazen.Leave += new System.EventHandler(this.txtIloscOkrazen_Leave);
            // 
            // txtGodzina
            // 
            resources.ApplyResources(this.txtGodzina, "txtGodzina");
            this.txtGodzina.Name = "txtGodzina";
            this.txtGodzina.Leave += new System.EventHandler(this.txtGodzina_Leave);
            // 
            // txtDystans
            // 
            resources.ApplyResources(this.txtDystans, "txtDystans");
            this.txtDystans.Name = "txtDystans";
            this.txtDystans.Leave += new System.EventHandler(this.txtDystans_Leave);
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // cboMiesiac
            // 
            resources.ApplyResources(this.cboMiesiac, "cboMiesiac");
            this.cboMiesiac.FormattingEnabled = true;
            this.cboMiesiac.Items.AddRange(new object[] {
            resources.GetString("cboMiesiac.Items"),
            resources.GetString("cboMiesiac.Items1"),
            resources.GetString("cboMiesiac.Items2"),
            resources.GetString("cboMiesiac.Items3"),
            resources.GetString("cboMiesiac.Items4"),
            resources.GetString("cboMiesiac.Items5"),
            resources.GetString("cboMiesiac.Items6"),
            resources.GetString("cboMiesiac.Items7"),
            resources.GetString("cboMiesiac.Items8"),
            resources.GetString("cboMiesiac.Items9"),
            resources.GetString("cboMiesiac.Items10"),
            resources.GetString("cboMiesiac.Items11")});
            this.cboMiesiac.Name = "cboMiesiac";
            this.cboMiesiac.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboMiesiac_KeyPress);
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // cboRok
            // 
            resources.ApplyResources(this.cboRok, "cboRok");
            this.cboRok.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cboRok.FormattingEnabled = true;
            this.cboRok.Items.AddRange(new object[] {
            resources.GetString("cboRok.Items"),
            resources.GetString("cboRok.Items1"),
            resources.GetString("cboRok.Items2")});
            this.cboRok.Name = "cboRok";
            this.cboRok.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboRok_KeyPress);
            // 
            // dataGridViewMaciej
            // 
            resources.ApplyResources(this.dataGridViewMaciej, "dataGridViewMaciej");
            this.dataGridViewMaciej.AllowUserToAddRows = false;
            this.dataGridViewMaciej.AllowUserToDeleteRows = false;
            this.dataGridViewMaciej.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewMaciej.Name = "dataGridViewMaciej";
            this.dataGridViewMaciej.ReadOnly = true;
            this.dataGridViewMaciej.TabStop = false;
            this.dataGridViewMaciej.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMaciej_CellClick);
            this.dataGridViewMaciej.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMaciej_CellValueChanged);
            // 
            // btnDodaj
            // 
            resources.ApplyResources(this.btnDodaj, "btnDodaj");
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnEdytuj
            // 
            resources.ApplyResources(this.btnEdytuj, "btnEdytuj");
            this.btnEdytuj.Name = "btnEdytuj";
            this.btnEdytuj.UseVisualStyleBackColor = true;
            this.btnEdytuj.Click += new System.EventHandler(this.btnEdytuj_Click);
            // 
            // btnUsun
            // 
            resources.ApplyResources(this.btnUsun, "btnUsun");
            this.btnUsun.Name = "btnUsun";
            this.btnUsun.UseVisualStyleBackColor = true;
            this.btnUsun.Click += new System.EventHandler(this.btnUsun_Click);
            // 
            // btnPrzelicz
            // 
            resources.ApplyResources(this.btnPrzelicz, "btnPrzelicz");
            this.btnPrzelicz.Name = "btnPrzelicz";
            this.btnPrzelicz.UseVisualStyleBackColor = true;
            this.btnPrzelicz.Click += new System.EventHandler(this.btnPrzelicz_Click);
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // txtMinuta
            // 
            resources.ApplyResources(this.txtMinuta, "txtMinuta");
            this.txtMinuta.Name = "txtMinuta";
            this.txtMinuta.Leave += new System.EventHandler(this.txtMinuta_Leave);
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // txtSekunda
            // 
            resources.ApplyResources(this.txtSekunda, "txtSekunda");
            this.txtSekunda.Name = "txtSekunda";
            this.txtSekunda.Leave += new System.EventHandler(this.txtSekunda_Leave);
            // 
            // txtCzas
            // 
            resources.ApplyResources(this.txtCzas, "txtCzas");
            this.txtCzas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCzas.Name = "txtCzas";
            // 
            // txtSrednieTempo
            // 
            resources.ApplyResources(this.txtSrednieTempo, "txtSrednieTempo");
            this.txtSrednieTempo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSrednieTempo.Name = "txtSrednieTempo";
            // 
            // txtSredniaPredkosc
            // 
            resources.ApplyResources(this.txtSredniaPredkosc, "txtSredniaPredkosc");
            this.txtSredniaPredkosc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSredniaPredkosc.Name = "txtSredniaPredkosc";
            // 
            // txtSredniCzasOkrazenia
            // 
            resources.ApplyResources(this.txtSredniCzasOkrazenia, "txtSredniCzasOkrazenia");
            this.txtSredniCzasOkrazenia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSredniCzasOkrazenia.Name = "txtSredniCzasOkrazenia";
            // 
            // btnSzukaj
            // 
            resources.ApplyResources(this.btnSzukaj, "btnSzukaj");
            this.btnSzukaj.Name = "btnSzukaj";
            this.btnSzukaj.UseVisualStyleBackColor = true;
            this.btnSzukaj.Click += new System.EventHandler(this.btnSzukaj_Click);
            // 
            // txtSumaCzas
            // 
            resources.ApplyResources(this.txtSumaCzas, "txtSumaCzas");
            this.txtSumaCzas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSumaCzas.Name = "txtSumaCzas";
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.Name = "label16";
            // 
            // txtSumaDystans
            // 
            resources.ApplyResources(this.txtSumaDystans, "txtSumaDystans");
            this.txtSumaDystans.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSumaDystans.Name = "txtSumaDystans";
            // 
            // label18
            // 
            resources.ApplyResources(this.label18, "label18");
            this.label18.Name = "label18";
            // 
            // txtSumaSrednieTempo
            // 
            resources.ApplyResources(this.txtSumaSrednieTempo, "txtSumaSrednieTempo");
            this.txtSumaSrednieTempo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSumaSrednieTempo.Name = "txtSumaSrednieTempo";
            // 
            // label20
            // 
            resources.ApplyResources(this.label20, "label20");
            this.label20.Name = "label20";
            // 
            // txtSumaSredniaPredkosc
            // 
            resources.ApplyResources(this.txtSumaSredniaPredkosc, "txtSumaSredniaPredkosc");
            this.txtSumaSredniaPredkosc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSumaSredniaPredkosc.Name = "txtSumaSredniaPredkosc";
            // 
            // label22
            // 
            resources.ApplyResources(this.label22, "label22");
            this.label22.Name = "label22";
            // 
            // txtSumaSredniCzasOkrazen
            // 
            resources.ApplyResources(this.txtSumaSredniCzasOkrazen, "txtSumaSredniCzasOkrazen");
            this.txtSumaSredniCzasOkrazen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSumaSredniCzasOkrazen.Name = "txtSumaSredniCzasOkrazen";
            // 
            // label24
            // 
            resources.ApplyResources(this.label24, "label24");
            this.label24.Name = "label24";
            // 
            // txtOkres
            // 
            resources.ApplyResources(this.txtOkres, "txtOkres");
            this.txtOkres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOkres.Name = "txtOkres";
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // txtSumaIloscOkrazen
            // 
            resources.ApplyResources(this.txtSumaIloscOkrazen, "txtSumaIloscOkrazen");
            this.txtSumaIloscOkrazen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSumaIloscOkrazen.Name = "txtSumaIloscOkrazen";
            // 
            // label19
            // 
            resources.ApplyResources(this.label19, "label19");
            this.label19.Name = "label19";
            // 
            // MaciejForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSumaIloscOkrazen);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtOkres);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtSumaSredniCzasOkrazen);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.txtSumaSredniaPredkosc);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.txtSumaSrednieTempo);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.txtSumaDystans);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.txtSumaCzas);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btnSzukaj);
            this.Controls.Add(this.txtSredniCzasOkrazenia);
            this.Controls.Add(this.txtSredniaPredkosc);
            this.Controls.Add(this.txtSrednieTempo);
            this.Controls.Add(this.txtCzas);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtSekunda);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtMinuta);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnPrzelicz);
            this.Controls.Add(this.btnUsun);
            this.Controls.Add(this.btnEdytuj);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dataGridViewMaciej);
            this.Controls.Add(this.cboRok);
            this.Controls.Add(this.cboMiesiac);
            this.Controls.Add(this.txtDystans);
            this.Controls.Add(this.txtGodzina);
            this.Controls.Add(this.txtIloscOkrazen);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePickerData);
            this.Controls.Add(this.label1);
            this.Name = "MaciejForm";
            this.Load += new System.EventHandler(this.MaciejForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMaciej)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMaciej)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIloscOkrazen;
        private System.Windows.Forms.TextBox txtGodzina;
        private System.Windows.Forms.TextBox txtDystans;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboMiesiac;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridViewMaciej;
        private System.Windows.Forms.BindingSource bindingSourceMaciej;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnEdytuj;
        private System.Windows.Forms.Button btnUsun;
        private System.Windows.Forms.Button btnPrzelicz;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMinuta;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSekunda;
        private System.Windows.Forms.Label txtCzas;
        private System.Windows.Forms.Label txtSrednieTempo;
        private System.Windows.Forms.Label txtSredniaPredkosc;
        private System.Windows.Forms.Label txtSredniCzasOkrazenia;
        private System.Windows.Forms.Button btnSzukaj;
        private System.Windows.Forms.ComboBox cboRok;
        private System.Windows.Forms.Label txtSumaCzas;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label txtSumaDystans;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label txtSumaSrednieTempo;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label txtSumaSredniaPredkosc;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label txtSumaSredniCzasOkrazen;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label txtOkres;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label txtSumaIloscOkrazen;
        private System.Windows.Forms.Label label19;
    }
}