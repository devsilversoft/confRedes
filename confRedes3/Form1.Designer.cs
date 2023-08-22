namespace confRedes3
{
    partial class Form1
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
            ConfigureButton = new Button();
            statusRichTextBox = new RichTextBox();
            connectionListBox = new ComboBox();
            IPAddressTextBox = new TextBox();
            SubnetMaskTextBox = new TextBox();
            GatewayTextBox = new TextBox();
            DnsTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            DHCPButton = new Button();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            chbMostrarDesabilitados = new CheckBox();
            DisableButton = new Button();
            EnableButton = new Button();
            richTextBoxInformacoes = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // ConfigureButton
            // 
            ConfigureButton.Location = new Point(631, 12);
            ConfigureButton.Name = "ConfigureButton";
            ConfigureButton.Size = new Size(115, 40);
            ConfigureButton.TabIndex = 0;
            ConfigureButton.Text = "Configurar";
            ConfigureButton.UseVisualStyleBackColor = true;
            ConfigureButton.Click += button1_Click;
            // 
            // statusRichTextBox
            // 
            statusRichTextBox.BorderStyle = BorderStyle.None;
            statusRichTextBox.Location = new Point(16, 243);
            statusRichTextBox.Name = "statusRichTextBox";
            statusRichTextBox.Size = new Size(443, 25);
            statusRichTextBox.TabIndex = 1;
            statusRichTextBox.Text = "";
            // 
            // connectionListBox
            // 
            connectionListBox.FormattingEnabled = true;
            connectionListBox.Location = new Point(24, 55);
            connectionListBox.Name = "connectionListBox";
            connectionListBox.Size = new Size(238, 23);
            connectionListBox.TabIndex = 3;
            connectionListBox.SelectedIndexChanged += connectionListBox_SelectedIndexChanged_1;
            connectionListBox.Click += connectionListBox_SelectedIndexChanged_1;
            // 
            // IPAddressTextBox
            // 
            IPAddressTextBox.Location = new Point(81, 112);
            IPAddressTextBox.Name = "IPAddressTextBox";
            IPAddressTextBox.Size = new Size(244, 23);
            IPAddressTextBox.TabIndex = 4;
            // 
            // SubnetMaskTextBox
            // 
            SubnetMaskTextBox.Location = new Point(81, 141);
            SubnetMaskTextBox.Name = "SubnetMaskTextBox";
            SubnetMaskTextBox.Size = new Size(244, 23);
            SubnetMaskTextBox.TabIndex = 5;
            // 
            // GatewayTextBox
            // 
            GatewayTextBox.Location = new Point(81, 170);
            GatewayTextBox.Name = "GatewayTextBox";
            GatewayTextBox.Size = new Size(244, 23);
            GatewayTextBox.TabIndex = 6;
            // 
            // DnsTextBox
            // 
            DnsTextBox.Location = new Point(81, 199);
            DnsTextBox.Name = "DnsTextBox";
            DnsTextBox.Size = new Size(244, 23);
            DnsTextBox.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 115);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 8;
            label1.Text = "IP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 144);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 9;
            label2.Text = "Mascara";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 202);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 10;
            label3.Text = "DNS";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 173);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 11;
            label4.Text = "Gateway";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 34);
            label5.Name = "label5";
            label5.Size = new Size(142, 15);
            label5.TabIndex = 12;
            label5.Text = "Lista de conexões de rede";
            // 
            // DHCPButton
            // 
            DHCPButton.Location = new Point(631, 58);
            DHCPButton.Name = "DHCPButton";
            DHCPButton.Size = new Size(115, 42);
            DHCPButton.TabIndex = 13;
            DHCPButton.Text = "DHCP";
            DHCPButton.UseVisualStyleBackColor = true;
            DHCPButton.Click += DHCPButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.IMG_20220524_WA0054;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(465, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(153, 133);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chbMostrarDesabilitados);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(DnsTextBox);
            groupBox1.Controls.Add(GatewayTextBox);
            groupBox1.Controls.Add(SubnetMaskTextBox);
            groupBox1.Controls.Add(IPAddressTextBox);
            groupBox1.Controls.Add(connectionListBox);
            groupBox1.Location = new Point(16, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(443, 234);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Configurações de rede";
            // 
            // chbMostrarDesabilitados
            // 
            chbMostrarDesabilitados.AutoSize = true;
            chbMostrarDesabilitados.Location = new Point(268, 57);
            chbMostrarDesabilitados.Name = "chbMostrarDesabilitados";
            chbMostrarDesabilitados.Size = new Size(139, 19);
            chbMostrarDesabilitados.TabIndex = 13;
            chbMostrarDesabilitados.Text = "Mostrar desabilitados";
            chbMostrarDesabilitados.UseVisualStyleBackColor = true;
            chbMostrarDesabilitados.CheckedChanged += chbMostrarDesabilitados_CheckedChanged;
            // 
            // DisableButton
            // 
            DisableButton.Location = new Point(631, 106);
            DisableButton.Name = "DisableButton";
            DisableButton.Size = new Size(115, 40);
            DisableButton.TabIndex = 16;
            DisableButton.Text = "Desativar";
            DisableButton.UseVisualStyleBackColor = true;
            DisableButton.Click += DisableButton_Click;
            // 
            // EnableButton
            // 
            EnableButton.Location = new Point(631, 152);
            EnableButton.Name = "EnableButton";
            EnableButton.Size = new Size(115, 40);
            EnableButton.TabIndex = 17;
            EnableButton.Text = "Ativar";
            EnableButton.UseVisualStyleBackColor = true;
            EnableButton.Click += EnableButton_Click;
            // 
            // richTextBoxInformacoes
            // 
            richTextBoxInformacoes.BorderStyle = BorderStyle.None;
            richTextBoxInformacoes.Location = new Point(18, 284);
            richTextBoxInformacoes.Name = "richTextBoxInformacoes";
            richTextBoxInformacoes.Size = new Size(444, 152);
            richTextBoxInformacoes.TabIndex = 18;
            richTextBoxInformacoes.Text = "Informações do PC";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(753, 450);
            Controls.Add(richTextBoxInformacoes);
            Controls.Add(EnableButton);
            Controls.Add(DisableButton);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(DHCPButton);
            Controls.Add(statusRichTextBox);
            Controls.Add(ConfigureButton);
            Name = "Form1";
            Text = "Telemática 34º BPM/I";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button ConfigureButton;
        private RichTextBox statusRichTextBox;
        private ComboBox connectionListBox;
        private TextBox IPAddressTextBox;
        private TextBox SubnetMaskTextBox;
        private TextBox GatewayTextBox;
        private TextBox DnsTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button DHCPButton;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Button DisableButton;
        private Button EnableButton;
        private CheckBox chbMostrarDesabilitados;
        private RichTextBox richTextBoxInformacoes;
    }
}