namespace Database_Vehicle
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
            this.listView = new System.Windows.Forms.ListView();
            this.refreshButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.details = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.plateNumber = new System.Windows.Forms.TextBox();
            this.ownerName = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.Location = new System.Drawing.Point(12, 264);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(750, 258);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.List;
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(12, 47);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(133, 23);
            this.refreshButton.TabIndex = 1;
            this.refreshButton.Text = "Actualizare";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Inmatriculare";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(350, 141);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(213, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Sterge interogare dar nu de tot";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 141);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(170, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Modificare Caracteristici";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // details
            // 
            this.details.Location = new System.Drawing.Point(12, 113);
            this.details.Name = "details";
            this.details.Size = new System.Drawing.Size(255, 22);
            this.details.TabIndex = 5;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(886, 141);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(170, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Cautare dupa numar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // plateNumber
            // 
            this.plateNumber.Location = new System.Drawing.Point(728, 113);
            this.plateNumber.Name = "plateNumber";
            this.plateNumber.Size = new System.Drawing.Size(255, 22);
            this.plateNumber.TabIndex = 7;
            this.plateNumber.TextChanged += new System.EventHandler(this.plateNumber_TextChanged);
            // 
            // ownerName
            // 
            this.ownerName.Location = new System.Drawing.Point(13, 200);
            this.ownerName.Name = "ownerName";
            this.ownerName.Size = new System.Drawing.Size(254, 22);
            this.ownerName.TabIndex = 8;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(12, 229);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(178, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "Cautare dupa nume prop";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(350, 27);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(150, 23);
            this.button6.TabIndex = 10;
            this.button6.Text = "Revizie";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(350, 84);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(150, 23);
            this.button7.TabIndex = 11;
            this.button7.Text = "Radiere";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(350, 199);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(206, 23);
            this.button8.TabIndex = 12;
            this.button8.Text = "Sortare dupa tipul masinii";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(658, 142);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(222, 24);
            this.button9.TabIndex = 13;
            this.button9.Text = "Alocare nr de inmatriculare";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 534);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.ownerName);
            this.Controls.Add(this.plateNumber);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.details);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.listView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox details;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox plateNumber;
        private System.Windows.Forms.TextBox ownerName;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
    }
}

