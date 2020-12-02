namespace Exercise_15_3
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
            this.comboStates = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboStates
            // 
            this.comboStates.FormattingEnabled = true;
            this.comboStates.Items.AddRange(new object[] {
            "Alaska",
            "Alabama",
            "California",
            "Florida",
            "Georgia",
            "Michigan",
            "New Jersey",
            "New York",
            "North Carolina",
            "South Carolina",
            "New Mexico",
            "Nevada",
            "Oregon",
            "Pennsylvania",
            "Rhode Island",
            "South Dakota",
            "Texas",
            "Wisconsin"});
            this.comboStates.Location = new System.Drawing.Point(75, 47);
            this.comboStates.Name = "comboStates";
            this.comboStates.Size = new System.Drawing.Size(204, 21);
            this.comboStates.TabIndex = 0;
            this.comboStates.SelectedIndexChanged += new System.EventHandler(this.ComboStates_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 450);
            this.Controls.Add(this.comboStates);
            this.Name = "Form1";
            this.Text = "Using Combo Boxes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboStates;
    }
}

