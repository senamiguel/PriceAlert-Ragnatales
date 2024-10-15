namespace PriceAlert_Ragnatales
{
    partial class Comprar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Comprar));
            lblItem = new Label();
            pctrItem = new PictureBox();
            txtPreco = new TextBox();
            label3 = new Label();
            label2 = new Label();
            cmbItens = new ComboBox();
            label4 = new Label();
            printPreviewDialog1 = new PrintPreviewDialog();
            btnIniciar = new Button();
            txtZap = new TextBox();
            label5 = new Label();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pctrItem).BeginInit();
            SuspendLayout();
            // 
            // lblItem
            // 
            lblItem.AutoSize = true;
            lblItem.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblItem.Location = new Point(490, 203);
            lblItem.Name = "lblItem";
            lblItem.Size = new Size(0, 21);
            lblItem.TabIndex = 21;
            // 
            // pctrItem
            // 
            pctrItem.Location = new Point(461, 227);
            pctrItem.Name = "pctrItem";
            pctrItem.Size = new Size(140, 123);
            pctrItem.SizeMode = PictureBoxSizeMode.CenterImage;
            pctrItem.TabIndex = 20;
            pctrItem.TabStop = false;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(196, 277);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(170, 23);
            txtPreco.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(236, 253);
            label3.Name = "label3";
            label3.Size = new Size(89, 21);
            label3.TabIndex = 18;
            label3.Text = "Preço Alvo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(259, 203);
            label2.Name = "label2";
            label2.Size = new Size(44, 21);
            label2.TabIndex = 17;
            label2.Text = "Item";
            // 
            // cmbItens
            // 
            cmbItens.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbItens.FormattingEnabled = true;
            cmbItens.Location = new Point(199, 227);
            cmbItens.Name = "cmbItens";
            cmbItens.Size = new Size(170, 23);
            cmbItens.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(329, 98);
            label4.Name = "label4";
            label4.Size = new Size(164, 30);
            label4.TabIndex = 15;
            label4.Text = "Alerta de Preço";
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // btnIniciar
            // 
            btnIniciar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIniciar.Location = new Point(362, 415);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(99, 35);
            btnIniciar.TabIndex = 25;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // txtZap
            // 
            txtZap.Location = new Point(196, 327);
            txtZap.Name = "txtZap";
            txtZap.Size = new Size(170, 23);
            txtZap.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(210, 303);
            label5.Name = "label5";
            label5.Size = new Size(146, 21);
            label5.TabIndex = 22;
            label5.Text = "Contato Whatsapp";
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(176, 162);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(449, 235);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            // 
            // Comprar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 549);
            Controls.Add(lblItem);
            Controls.Add(pctrItem);
            Controls.Add(txtPreco);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cmbItens);
            Controls.Add(label4);
            Controls.Add(btnIniciar);
            Controls.Add(txtZap);
            Controls.Add(label5);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Comprar";
            Text = "Comprar";
            ((System.ComponentModel.ISupportInitialize)pctrItem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblItem;
        private PictureBox pctrItem;
        private TextBox txtPreco;
        private Label label3;
        private Label label2;
        private ComboBox cmbItens;
        private Label label4;
        private PrintPreviewDialog printPreviewDialog1;
        private Button btnIniciar;
        private TextBox txtZap;
        private Label label5;
        private GroupBox groupBox1;
    }
}