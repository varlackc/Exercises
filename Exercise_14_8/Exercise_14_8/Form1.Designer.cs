namespace Exercise_14_8
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EnterGuessBT = new System.Windows.Forms.Button();
            this.StartNewBT = new System.Windows.Forms.Button();
            this.Message = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(44, 89);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Guess Number Game";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Insert the Guessed Number";
            // 
            // EnterGuessBT
            // 
            this.EnterGuessBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterGuessBT.Location = new System.Drawing.Point(118, 161);
            this.EnterGuessBT.Name = "EnterGuessBT";
            this.EnterGuessBT.Size = new System.Drawing.Size(108, 39);
            this.EnterGuessBT.TabIndex = 3;
            this.EnterGuessBT.Text = "Enter Guess";
            this.EnterGuessBT.UseVisualStyleBackColor = true;
            this.EnterGuessBT.Click += new System.EventHandler(this.EnterGuessBT_Click);
            // 
            // StartNewBT
            // 
            this.StartNewBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartNewBT.Location = new System.Drawing.Point(118, 220);
            this.StartNewBT.Name = "StartNewBT";
            this.StartNewBT.Size = new System.Drawing.Size(108, 42);
            this.StartNewBT.TabIndex = 4;
            this.StartNewBT.Text = "Start New Game";
            this.StartNewBT.UseVisualStyleBackColor = true;
            this.StartNewBT.Click += new System.EventHandler(this.StartNewBT_Click);
            // 
            // Message
            // 
            this.Message.AutoSize = true;
            this.Message.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Message.Location = new System.Drawing.Point(115, 127);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(12, 16);
            this.Message.TabIndex = 5;
            this.Message.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 289);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.StartNewBT);
            this.Controls.Add(this.EnterGuessBT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Guess Number Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button EnterGuessBT;
        private System.Windows.Forms.Button StartNewBT;
        private System.Windows.Forms.Label Message;
    }
}

