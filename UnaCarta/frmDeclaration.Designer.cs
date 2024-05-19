namespace UnaCarta
{
    partial class frmDeclaration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDeclaration));
            label1 = new Label();
            btnUno = new Button();
            btnNo = new Button();
            panel1 = new Panel();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(51, 61);
            label1.Name = "label1";
            label1.Size = new Size(342, 40);
            label1.TabIndex = 0;
            label1.Text = "¿Quieres salir conmigo?";
            // 
            // btnUno
            // 
            btnUno.BackColor = Color.ForestGreen;
            btnUno.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUno.ForeColor = Color.Black;
            btnUno.Location = new Point(111, 124);
            btnUno.Name = "btnUno";
            btnUno.Size = new Size(78, 30);
            btnUno.TabIndex = 1;
            btnUno.Text = "Si";
            btnUno.UseVisualStyleBackColor = false;
            btnUno.Click += btn1_Click;
            // 
            // btnNo
            // 
            btnNo.BackColor = Color.Firebrick;
            btnNo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNo.ForeColor = Color.Black;
            btnNo.Location = new Point(240, 124);
            btnNo.Name = "btnNo";
            btnNo.Size = new Size(75, 30);
            btnNo.TabIndex = 2;
            btnNo.Text = "No";
            btnNo.UseVisualStyleBackColor = false;
            btnNo.MouseMove += btnNo_MouseMove;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(451, 187);
            panel1.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.Firebrick;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(176, 143);
            button1.Name = "button1";
            button1.Size = new Size(79, 29);
            button1.TabIndex = 3;
            button1.Text = "Cerrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(194, 110);
            label3.Name = "label3";
            label3.Size = new Size(40, 30);
            label3.TabIndex = 2;
            label3.Text = "<3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 21F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(61, 72);
            label2.Name = "label2";
            label2.Size = new Size(318, 38);
            label2.TabIndex = 1;
            label2.Text = "Sabía que dirias que si!";
            // 
            // frmDeclaration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(451, 186);
            Controls.Add(panel1);
            Controls.Add(btnNo);
            Controls.Add(btnUno);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmDeclaration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += frmDeclaration_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnUno;
        private Button btnNo;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private Button button1;
    }
}
