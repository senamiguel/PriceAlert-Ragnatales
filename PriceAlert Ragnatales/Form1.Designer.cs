namespace PriceAlert_Ragnatales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            Buttons = new GroupBox();
            label1 = new Label();
            btnGithub = new Button();
            btnComprar = new Button();
            btnVender = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            Buttons.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(-135, -317);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1036, 1239);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Buttons
            // 
            Buttons.Controls.Add(btnGithub);
            Buttons.Controls.Add(btnComprar);
            Buttons.Controls.Add(btnVender);
            Buttons.Location = new Point(177, 133);
            Buttons.Name = "Buttons";
            Buttons.Size = new Size(446, 331);
            Buttons.TabIndex = 1;
            Buttons.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(318, 198);
            label1.Name = "label1";
            label1.Size = new Size(164, 30);
            label1.TabIndex = 3;
            label1.Text = "Alerta de Preço";
            // 
            // btnGithub
            // 
            btnGithub.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGithub.Image = (Image)resources.GetObject("btnGithub.Image");
            btnGithub.ImageAlign = ContentAlignment.MiddleLeft;
            btnGithub.Location = new Point(164, 254);
            btnGithub.Name = "btnGithub";
            btnGithub.Size = new Size(118, 30);
            btnGithub.TabIndex = 2;
            btnGithub.Text = "GitHub";
            btnGithub.UseVisualStyleBackColor = true;
            btnGithub.Click += btnGithub_Click;
            // 
            // btnComprar
            // 
            btnComprar.Location = new Point(226, 148);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(131, 61);
            btnComprar.TabIndex = 1;
            btnComprar.Text = "Comprando";
            btnComprar.UseVisualStyleBackColor = true;
            btnComprar.Click += btnComprar_Click;
            // 
            // btnVender
            // 
            btnVender.Location = new Point(89, 148);
            btnVender.Name = "btnVender";
            btnVender.Size = new Size(131, 61);
            btnVender.TabIndex = 0;
            btnVender.Text = "Vendendo";
            btnVender.UseVisualStyleBackColor = true;
            btnVender.Click += btnVender_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 549);
            Controls.Add(label1);
            Controls.Add(Buttons);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "PriceAlert";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            Buttons.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private GroupBox Buttons;
        private Button btnVender;
        private Button btnComprar;
        private Label label1;
        private Button btnGithub;
    }
}
