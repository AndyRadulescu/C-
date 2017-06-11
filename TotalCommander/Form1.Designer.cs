namespace WindowsFormsApp1
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
            this.driverList = new System.Windows.Forms.ListView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.driverList2 = new System.Windows.Forms.ListView();
            this.listView3 = new System.Windows.Forms.ListView();
            this.path1 = new System.Windows.Forms.TextBox();
            this.path2 = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.backButton2 = new System.Windows.Forms.Button();
            this.create1 = new System.Windows.Forms.Button();
            this.create2 = new System.Windows.Forms.Button();
            this.file1 = new System.Windows.Forms.Button();
            this.file2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // driverList
            // 
            this.driverList.Location = new System.Drawing.Point(12, 32);
            this.driverList.Name = "driverList";
            this.driverList.Size = new System.Drawing.Size(168, 135);
            this.driverList.TabIndex = 0;
            this.driverList.UseCompatibleStateImageBehavior = false;
            this.driverList.View = System.Windows.Forms.View.List;
            this.driverList.SelectedIndexChanged += new System.EventHandler(this.DriverList_SelectedIndexChanged);
            this.driverList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DriveOnClick);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(186, 32);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(286, 272);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // driverList2
            // 
            this.driverList2.Location = new System.Drawing.Point(524, 32);
            this.driverList2.Name = "driverList2";
            this.driverList2.Size = new System.Drawing.Size(178, 135);
            this.driverList2.TabIndex = 2;
            this.driverList2.UseCompatibleStateImageBehavior = false;
            this.driverList2.View = System.Windows.Forms.View.List;
            this.driverList2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DriveOnClick2);
            // 
            // listView3
            // 
            this.listView3.Location = new System.Drawing.Point(708, 32);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(296, 272);
            this.listView3.TabIndex = 3;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.List;
            this.listView3.SelectedIndexChanged += new System.EventHandler(this.listView3_SelectedIndexChanged);
            // 
            // path1
            // 
            this.path1.Location = new System.Drawing.Point(13, 360);
            this.path1.Name = "path1";
            this.path1.Size = new System.Drawing.Size(459, 22);
            this.path1.TabIndex = 4;
            // 
            // path2
            // 
            this.path2.Location = new System.Drawing.Point(524, 360);
            this.path2.Name = "path2";
            this.path2.Size = new System.Drawing.Size(480, 22);
            this.path2.TabIndex = 5;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 410);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // backButton2
            // 
            this.backButton2.Location = new System.Drawing.Point(524, 410);
            this.backButton2.Name = "backButton2";
            this.backButton2.Size = new System.Drawing.Size(75, 23);
            this.backButton2.TabIndex = 7;
            this.backButton2.Text = "Back";
            this.backButton2.UseVisualStyleBackColor = true;
            this.backButton2.Click += new System.EventHandler(this.backButton2_Click);
            // 
            // create1
            // 
            this.create1.Location = new System.Drawing.Point(13, 191);
            this.create1.Name = "create1";
            this.create1.Size = new System.Drawing.Size(167, 23);
            this.create1.TabIndex = 8;
            this.create1.Text = "Create Folder";
            this.create1.UseVisualStyleBackColor = true;
            this.create1.Click += new System.EventHandler(this.create1_Click);
            // 
            // create2
            // 
            this.create2.Location = new System.Drawing.Point(524, 190);
            this.create2.Name = "create2";
            this.create2.Size = new System.Drawing.Size(178, 23);
            this.create2.TabIndex = 10;
            this.create2.Text = "Create Folder";
            this.create2.UseVisualStyleBackColor = true;
            this.create2.Click += new System.EventHandler(this.create2_Click);
            // 
            // file1
            // 
            this.file1.Location = new System.Drawing.Point(12, 221);
            this.file1.Name = "file1";
            this.file1.Size = new System.Drawing.Size(168, 23);
            this.file1.TabIndex = 11;
            this.file1.Text = "Create File";
            this.file1.UseVisualStyleBackColor = true;
            this.file1.Click += new System.EventHandler(this.file1_Click);
            // 
            // file2
            // 
            this.file2.Location = new System.Drawing.Point(524, 220);
            this.file2.Name = "file2";
            this.file2.Size = new System.Drawing.Size(178, 23);
            this.file2.TabIndex = 12;
            this.file2.Text = "Create File ";
            this.file2.UseVisualStyleBackColor = true;
            this.file2.Click += new System.EventHandler(this.file2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 616);
            this.Controls.Add(this.file2);
            this.Controls.Add(this.file1);
            this.Controls.Add(this.create2);
            this.Controls.Add(this.create1);
            this.Controls.Add(this.backButton2);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.path2);
            this.Controls.Add(this.path1);
            this.Controls.Add(this.listView3);
            this.Controls.Add(this.driverList2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.driverList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView driverList;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView driverList2;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.TextBox path1;
        private System.Windows.Forms.TextBox path2;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button backButton2;
        private System.Windows.Forms.Button create1;
        private System.Windows.Forms.Button create2;
        private System.Windows.Forms.Button file1;
        private System.Windows.Forms.Button file2;
    }
}

