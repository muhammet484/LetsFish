
namespace LetsFish
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CongratText = new System.Windows.Forms.Label();
            this.HireFisher1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.FisherManagerMan = new System.Windows.Forms.CheckBox();
            this.FishNoTextBox = new System.Windows.Forms.RichTextBox();
            this.FisherNoTextBox = new System.Windows.Forms.RichTextBox();
            this.ChatButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(12, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(293, 132);
            this.button1.TabIndex = 0;
            this.button1.Text = "Try Catching a fish";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(15, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fishes:";
            // 
            // CongratText
            // 
            this.CongratText.AutoSize = true;
            this.CongratText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CongratText.Location = new System.Drawing.Point(12, 9);
            this.CongratText.Name = "CongratText";
            this.CongratText.Size = new System.Drawing.Size(188, 46);
            this.CongratText.TabIndex = 1;
            this.CongratText.Text = "Let\'s fish!";
            // 
            // HireFisher1
            // 
            this.HireFisher1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HireFisher1.Location = new System.Drawing.Point(12, 329);
            this.HireFisher1.Name = "HireFisher1";
            this.HireFisher1.Size = new System.Drawing.Size(113, 84);
            this.HireFisher1.TabIndex = 0;
            this.HireFisher1.Text = "Hire a fisher\r\n(15 fish)";
            this.HireFisher1.UseVisualStyleBackColor = true;
            this.HireFisher1.Click += new System.EventHandler(this.HireFisher1_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(9, 415);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 45);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fishers use your lake and give you a part of their fishes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(131, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 36);
            this.label3.TabIndex = 1;
            this.label3.Text = "Fishers:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(12, 463);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(293, 64);
            this.button2.TabIndex = 0;
            this.button2.Text = "Hire a fisher manager\r\n(1500 fish)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(9, 533);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(296, 54);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fisher manager hires fishers when you have 1000 fishes. You can hire only one fis" +
    "her manager.";
            // 
            // FisherManagerMan
            // 
            this.FisherManagerMan.AutoSize = true;
            this.FisherManagerMan.Checked = true;
            this.FisherManagerMan.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FisherManagerMan.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.HighlightText;
            this.FisherManagerMan.Location = new System.Drawing.Point(9, 463);
            this.FisherManagerMan.Name = "FisherManagerMan";
            this.FisherManagerMan.Size = new System.Drawing.Size(154, 21);
            this.FisherManagerMan.TabIndex = 4;
            this.FisherManagerMan.Text = "Use fisher manager";
            this.FisherManagerMan.UseVisualStyleBackColor = true;
            this.FisherManagerMan.Visible = false;
            // 
            // FishNoTextBox
            // 
            this.FishNoTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.FishNoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FishNoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FishNoTextBox.Location = new System.Drawing.Point(12, 146);
            this.FishNoTextBox.Multiline = false;
            this.FishNoTextBox.Name = "FishNoTextBox";
            this.FishNoTextBox.ReadOnly = true;
            this.FishNoTextBox.Size = new System.Drawing.Size(1906, 39);
            this.FishNoTextBox.TabIndex = 5;
            this.FishNoTextBox.Text = "0";
            // 
            // FisherNoTextBox
            // 
            this.FisherNoTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.FisherNoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FisherNoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FisherNoTextBox.Location = new System.Drawing.Point(131, 368);
            this.FisherNoTextBox.Multiline = false;
            this.FisherNoTextBox.Name = "FisherNoTextBox";
            this.FisherNoTextBox.ReadOnly = true;
            this.FisherNoTextBox.Size = new System.Drawing.Size(1787, 39);
            this.FisherNoTextBox.TabIndex = 5;
            this.FisherNoTextBox.Text = "0";
            // 
            // ChatButton
            // 
            this.ChatButton.BackColor = System.Drawing.SystemColors.Control;
            this.ChatButton.FlatAppearance.BorderSize = 0;
            this.ChatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChatButton.Location = new System.Drawing.Point(-1, -3);
            this.ChatButton.Margin = new System.Windows.Forms.Padding(1);
            this.ChatButton.Name = "ChatButton";
            this.ChatButton.Size = new System.Drawing.Size(18, 17);
            this.ChatButton.TabIndex = 7;
            this.ChatButton.UseVisualStyleBackColor = false;
            this.ChatButton.Click += new System.EventHandler(this.ChatButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 593);
            this.Controls.Add(this.FisherNoTextBox);
            this.Controls.Add(this.FishNoTextBox);
            this.Controls.Add(this.FisherManagerMan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CongratText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.HireFisher1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ChatButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Let\'s Fish!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CongratText;
        private System.Windows.Forms.Button HireFisher1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox FisherManagerMan;
        private System.Windows.Forms.RichTextBox FishNoTextBox;
        private System.Windows.Forms.RichTextBox FisherNoTextBox;
        private System.Windows.Forms.Button ChatButton;
    }
}

