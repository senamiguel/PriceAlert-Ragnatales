namespace PriceAlert_Ragnatales
{
    partial class Vender
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vender));
            label1 = new Label();
            cmbItens = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            txtPreco = new TextBox();
            pctrItem = new PictureBox();
            lblItem = new Label();
            printPreviewDialog1 = new PrintPreviewDialog();
            txtZap = new TextBox();
            label5 = new Label();
            groupBox1 = new GroupBox();
            btnIniciar = new Button();
            ((System.ComponentModel.ISupportInitialize)pctrItem).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(318, 87);
            label1.Name = "label1";
            label1.Size = new Size(164, 30);
            label1.TabIndex = 4;
            label1.Text = "Alerta de Preço";
            // 
            // cmbItens
            // 
            cmbItens.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbItens.FormattingEnabled = true;
            cmbItens.Location = new Point(188, 216);
            cmbItens.Name = "cmbItens";
            cmbItens.Size = new Size(170, 23);
            cmbItens.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(248, 192);
            label2.Name = "label2";
            label2.Size = new Size(44, 21);
            label2.TabIndex = 6;
            label2.Text = "Item";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(225, 242);
            label3.Name = "label3";
            label3.Size = new Size(89, 21);
            label3.TabIndex = 7;
            label3.Text = "Preço Alvo";
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(185, 266);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(170, 23);
            txtPreco.TabIndex = 8;
            // 
            // pctrItem
            // 
            pctrItem.Location = new Point(450, 216);
            pctrItem.Name = "pctrItem";
            pctrItem.Size = new Size(140, 123);
            pctrItem.SizeMode = PictureBoxSizeMode.CenterImage;
            pctrItem.TabIndex = 9;
            pctrItem.TabStop = false;
            // 
            // lblItem
            // 
            lblItem.AutoSize = true;
            lblItem.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblItem.Location = new Point(479, 192);
            lblItem.Name = "lblItem";
            lblItem.Size = new Size(0, 21);
            lblItem.TabIndex = 10;
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
            // txtZap
            // 
            txtZap.Location = new Point(185, 316);
            txtZap.Name = "txtZap";
            txtZap.Size = new Size(170, 23);
            txtZap.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(199, 292);
            label5.Name = "label5";
            label5.Size = new Size(146, 21);
            label5.TabIndex = 11;
            label5.Text = "Contato Whatsapp";
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(165, 151);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(449, 235);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            // 
            // btnIniciar
            // 
            btnIniciar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIniciar.Location = new Point(351, 404);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(99, 35);
            btnIniciar.TabIndex = 14;
            btnIniciar.Text = "Iniciar";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // Vender
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 549);
            Controls.Add(btnIniciar);
            Controls.Add(txtZap);
            Controls.Add(label5);
            Controls.Add(lblItem);
            Controls.Add(pctrItem);
            Controls.Add(txtPreco);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cmbItens);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Vender";
            Text = "Vendendo";
            ((System.ComponentModel.ISupportInitialize)pctrItem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cmbItens;
        private Label label2;
        private Label label3;
        private TextBox txtPreco;
        private PictureBox pctrItem;
        private Label lblItem;
        private PrintPreviewDialog printPreviewDialog1;
        private TextBox txtZap;
        private Label label5;
        private GroupBox groupBox1;
        private Button btnIniciar;
    }
}