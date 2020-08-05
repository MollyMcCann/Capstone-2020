namespace HomeTrackerTest
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
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.HomeSearchlbl = new System.Windows.Forms.Label();
            this.AddHomeButton = new System.Windows.Forms.Label();
            this.AddressListBox = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateHomeAsSoldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.CityListBox = new System.Windows.Forms.ListBox();
            this.StateListbox = new System.Windows.Forms.ListBox();
            this.ZipListbox = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(492, 55);
            this.searchBox.Multiline = true;
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(111, 20);
            this.searchBox.TabIndex = 0;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(634, 52);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // HomeSearchlbl
            // 
            this.HomeSearchlbl.AutoSize = true;
            this.HomeSearchlbl.Location = new System.Drawing.Point(386, 28);
            this.HomeSearchlbl.Name = "HomeSearchlbl";
            this.HomeSearchlbl.Size = new System.Drawing.Size(77, 13);
            this.HomeSearchlbl.TabIndex = 2;
            this.HomeSearchlbl.Text = "Select a Home";
            // 
            // AddHomeButton
            // 
            this.AddHomeButton.AutoSize = true;
            this.AddHomeButton.Location = new System.Drawing.Point(25, 52);
            this.AddHomeButton.Name = "AddHomeButton";
            this.AddHomeButton.Size = new System.Drawing.Size(89, 13);
            this.AddHomeButton.TabIndex = 3;
            this.AddHomeButton.Text = "Add a new Home";
            // 
            // AddressListBox
            // 
            this.AddressListBox.FormattingEnabled = true;
            this.AddressListBox.Location = new System.Drawing.Point(28, 81);
            this.AddressListBox.Name = "AddressListBox";
            this.AddressListBox.Size = new System.Drawing.Size(133, 17);
            this.AddressListBox.TabIndex = 4;
            this.AddressListBox.SelectedIndexChanged += new System.EventHandler(this.AddressListBox_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem,
            this.addToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.updateHomeAsSoldToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.searchToolStripMenuItem.Text = "Search";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.updateToolStripMenuItem.Text = "Update";
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.removeToolStripMenuItem.Text = "Remove";
            // 
            // updateHomeAsSoldToolStripMenuItem
            // 
            this.updateHomeAsSoldToolStripMenuItem.Name = "updateHomeAsSoldToolStripMenuItem";
            this.updateHomeAsSoldToolStripMenuItem.Size = new System.Drawing.Size(133, 20);
            this.updateHomeAsSoldToolStripMenuItem.Text = "Update Home as Sold";
            // 
            // CityListBox
            // 
            this.CityListBox.FormattingEnabled = true;
            this.CityListBox.Location = new System.Drawing.Point(28, 104);
            this.CityListBox.Name = "CityListBox";
            this.CityListBox.Size = new System.Drawing.Size(133, 17);
            this.CityListBox.TabIndex = 6;
            this.CityListBox.SelectedIndexChanged += new System.EventHandler(this.CityListBox_SelectedIndexChanged);
            // 
            // StateListbox
            // 
            this.StateListbox.FormattingEnabled = true;
            this.StateListbox.Location = new System.Drawing.Point(28, 127);
            this.StateListbox.Name = "StateListbox";
            this.StateListbox.Size = new System.Drawing.Size(133, 17);
            this.StateListbox.TabIndex = 7;
            // 
            // ZipListbox
            // 
            this.ZipListbox.FormattingEnabled = true;
            this.ZipListbox.Location = new System.Drawing.Point(28, 150);
            this.ZipListbox.Name = "ZipListbox";
            this.ZipListbox.Size = new System.Drawing.Size(133, 17);
            this.ZipListbox.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ZipListbox);
            this.Controls.Add(this.StateListbox);
            this.Controls.Add(this.CityListBox);
            this.Controls.Add(this.AddressListBox);
            this.Controls.Add(this.AddHomeButton);
            this.Controls.Add(this.HomeSearchlbl);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Home Tracker";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label HomeSearchlbl;
        private System.Windows.Forms.Label AddHomeButton;
        private System.Windows.Forms.ListBox AddressListBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateHomeAsSoldToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ListBox CityListBox;
        private System.Windows.Forms.ListBox StateListbox;
        private System.Windows.Forms.ListBox ZipListbox;
    }
}

