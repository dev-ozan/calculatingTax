namespace WinFormsApp4
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
            label1 = new Label();
            fiyatText = new TextBox();
            btnDiger = new Button();
            btnGida = new Button();
            btnEkmek = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(39, 39);
            label1.Name = "label1";
            label1.Size = new Size(153, 38);
            label1.TabIndex = 0;
            label1.Text = "Fiyat Giriniz";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // fiyatText
            // 
            fiyatText.Location = new Point(39, 80);
            fiyatText.Name = "fiyatText";
            fiyatText.Size = new Size(153, 29);
            fiyatText.TabIndex = 1;
            // 
            // btnDiger
            // 
            btnDiger.Location = new Point(39, 127);
            btnDiger.Name = "btnDiger";
            btnDiger.Size = new Size(153, 34);
            btnDiger.TabIndex = 2;
            btnDiger.Text = "Diğer ( %18)";
            btnDiger.UseVisualStyleBackColor = true;
            btnDiger.Click += btnDiger_Click;
            // 
            // btnGida
            // 
            btnGida.Location = new Point(39, 179);
            btnGida.Name = "btnGida";
            btnGida.Size = new Size(153, 34);
            btnGida.TabIndex = 3;
            btnGida.Text = "Gıda Satışı ( %8 )";
            btnGida.UseVisualStyleBackColor = true;
            btnGida.Click += btnGida_Click;
            // 
            // btnEkmek
            // 
            btnEkmek.Location = new Point(39, 231);
            btnEkmek.Name = "btnEkmek";
            btnEkmek.Size = new Size(153, 34);
            btnEkmek.TabIndex = 4;
            btnEkmek.Text = "Ekmek  ( %1)";
            btnEkmek.UseVisualStyleBackColor = true;
            btnEkmek.Click += btnEkmek_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(258, 356);
            Controls.Add(btnEkmek);
            Controls.Add(btnGida);
            Controls.Add(btnDiger);
            Controls.Add(fiyatText);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox fiyatText;
        private Button btnDiger;
        private Button btnGida;
        private Button btnEkmek;
    }
}