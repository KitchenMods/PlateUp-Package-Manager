namespace PlateUp_Package_Manager
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.button_home = new System.Windows.Forms.Button();
			this.button_repositories = new System.Windows.Forms.Button();
			this.button_installed = new System.Windows.Forms.Button();
			this.button_search = new System.Windows.Forms.Button();
			this.panel_home = new System.Windows.Forms.Panel();
			this.label7 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel_repositories = new System.Windows.Forms.Panel();
			this.listBox_installedrepos = new System.Windows.Forms.ListBox();
			this.label2 = new System.Windows.Forms.Label();
			this.panel_installed = new System.Windows.Forms.Panel();
			this.button_installed_remove = new System.Windows.Forms.Button();
			this.listBox_installed = new System.Windows.Forms.ListBox();
			this.label3 = new System.Windows.Forms.Label();
			this.panel_search = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox_addrepo = new System.Windows.Forms.TextBox();
			this.button_addrepo = new System.Windows.Forms.Button();
			this.panel_home.SuspendLayout();
			this.panel_repositories.SuspendLayout();
			this.panel_installed.SuspendLayout();
			this.panel_search.SuspendLayout();
			this.SuspendLayout();
			// 
			// button_home
			// 
			this.button_home.Location = new System.Drawing.Point(12, 415);
			this.button_home.Name = "button_home";
			this.button_home.Size = new System.Drawing.Size(184, 23);
			this.button_home.TabIndex = 0;
			this.button_home.Text = "Home";
			this.button_home.UseVisualStyleBackColor = true;
			this.button_home.Click += new System.EventHandler(this.button_home_Click);
			// 
			// button_repositories
			// 
			this.button_repositories.Location = new System.Drawing.Point(196, 415);
			this.button_repositories.Name = "button_repositories";
			this.button_repositories.Size = new System.Drawing.Size(184, 23);
			this.button_repositories.TabIndex = 1;
			this.button_repositories.Text = "Repositories";
			this.button_repositories.UseVisualStyleBackColor = true;
			this.button_repositories.Click += new System.EventHandler(this.button_repositories_Click);
			// 
			// button_installed
			// 
			this.button_installed.Location = new System.Drawing.Point(381, 415);
			this.button_installed.Name = "button_installed";
			this.button_installed.Size = new System.Drawing.Size(184, 23);
			this.button_installed.TabIndex = 2;
			this.button_installed.Text = "Installed";
			this.button_installed.UseVisualStyleBackColor = true;
			this.button_installed.Click += new System.EventHandler(this.button_installed_Click);
			// 
			// button_search
			// 
			this.button_search.Location = new System.Drawing.Point(565, 415);
			this.button_search.Name = "button_search";
			this.button_search.Size = new System.Drawing.Size(184, 23);
			this.button_search.TabIndex = 3;
			this.button_search.Text = "Search";
			this.button_search.UseVisualStyleBackColor = true;
			this.button_search.Click += new System.EventHandler(this.button_search_Click);
			// 
			// panel_home
			// 
			this.panel_home.Controls.Add(this.label7);
			this.panel_home.Controls.Add(this.label5);
			this.panel_home.Controls.Add(this.label1);
			this.panel_home.Location = new System.Drawing.Point(12, 12);
			this.panel_home.Name = "panel_home";
			this.panel_home.Size = new System.Drawing.Size(776, 397);
			this.panel_home.TabIndex = 4;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(5, 73);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(668, 48);
			this.label7.TabIndex = 3;
			this.label7.Text = "PLEASE NOTE: PlateUp does NOT officially support mods.\r\n\r\nWe ( Or any other unoff" +
    "icial mods ) are not directly affiliated with the PlateUp game, or Yogscast.\r\n";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(3, 41);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(309, 24);
			this.label5.TabIndex = 1;
			this.label5.Text = "Welcome to PlateUp Mod Manager!";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(404, 31);
			this.label1.TabIndex = 0;
			this.label1.Text = "PlateUp Mod Manager - Home";
			// 
			// panel_repositories
			// 
			this.panel_repositories.Controls.Add(this.button_addrepo);
			this.panel_repositories.Controls.Add(this.textBox_addrepo);
			this.panel_repositories.Controls.Add(this.listBox_installedrepos);
			this.panel_repositories.Controls.Add(this.label2);
			this.panel_repositories.Location = new System.Drawing.Point(852, 12);
			this.panel_repositories.Name = "panel_repositories";
			this.panel_repositories.Size = new System.Drawing.Size(776, 397);
			this.panel_repositories.TabIndex = 5;
			// 
			// listBox_installedrepos
			// 
			this.listBox_installedrepos.FormattingEnabled = true;
			this.listBox_installedrepos.Location = new System.Drawing.Point(6, 91);
			this.listBox_installedrepos.Name = "listBox_installedrepos";
			this.listBox_installedrepos.Size = new System.Drawing.Size(336, 303);
			this.listBox_installedrepos.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(0, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(492, 31);
			this.label2.TabIndex = 1;
			this.label2.Text = "PlateUp Mod Manager - Repositories";
			// 
			// panel_installed
			// 
			this.panel_installed.Controls.Add(this.button_installed_remove);
			this.panel_installed.Controls.Add(this.listBox_installed);
			this.panel_installed.Controls.Add(this.label3);
			this.panel_installed.Location = new System.Drawing.Point(12, 465);
			this.panel_installed.Name = "panel_installed";
			this.panel_installed.Size = new System.Drawing.Size(776, 397);
			this.panel_installed.TabIndex = 6;
			// 
			// button_installed_remove
			// 
			this.button_installed_remove.Location = new System.Drawing.Point(416, 367);
			this.button_installed_remove.Name = "button_installed_remove";
			this.button_installed_remove.Size = new System.Drawing.Size(75, 23);
			this.button_installed_remove.TabIndex = 4;
			this.button_installed_remove.Text = "Remove";
			this.button_installed_remove.UseVisualStyleBackColor = true;
			this.button_installed_remove.Click += new System.EventHandler(this.button_installed_remove_Click);
			// 
			// listBox_installed
			// 
			this.listBox_installed.FormattingEnabled = true;
			this.listBox_installed.Location = new System.Drawing.Point(8, 48);
			this.listBox_installed.Name = "listBox_installed";
			this.listBox_installed.Size = new System.Drawing.Size(402, 342);
			this.listBox_installed.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(0, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(439, 31);
			this.label3.TabIndex = 2;
			this.label3.Text = "PlateUp Mod Manager - Installed";
			// 
			// panel_search
			// 
			this.panel_search.Controls.Add(this.label4);
			this.panel_search.Location = new System.Drawing.Point(852, 465);
			this.panel_search.Name = "panel_search";
			this.panel_search.Size = new System.Drawing.Size(776, 397);
			this.panel_search.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(0, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(420, 31);
			this.label4.TabIndex = 3;
			this.label4.Text = "PlateUp Mod Manager - Search";
			// 
			// button1
			// 
			this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button1.Location = new System.Drawing.Point(755, 415);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(23, 23);
			this.button1.TabIndex = 7;
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox_addrepo
			// 
			this.textBox_addrepo.Location = new System.Drawing.Point(3, 65);
			this.textBox_addrepo.Name = "textBox_addrepo";
			this.textBox_addrepo.Size = new System.Drawing.Size(689, 20);
			this.textBox_addrepo.TabIndex = 3;
			// 
			// button_addrepo
			// 
			this.button_addrepo.Location = new System.Drawing.Point(698, 62);
			this.button_addrepo.Name = "button_addrepo";
			this.button_addrepo.Size = new System.Drawing.Size(75, 23);
			this.button_addrepo.TabIndex = 4;
			this.button_addrepo.Text = "button2";
			this.button_addrepo.UseVisualStyleBackColor = true;
			this.button_addrepo.Click += new System.EventHandler(this.button_addrepo_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1890, 911);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.panel_installed);
			this.Controls.Add(this.panel_search);
			this.Controls.Add(this.panel_repositories);
			this.Controls.Add(this.panel_home);
			this.Controls.Add(this.button_search);
			this.Controls.Add(this.button_installed);
			this.Controls.Add(this.button_repositories);
			this.Controls.Add(this.button_home);
			this.Name = "MainForm";
			this.Text = "PlateUp Mod Manager";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.panel_home.ResumeLayout(false);
			this.panel_home.PerformLayout();
			this.panel_repositories.ResumeLayout(false);
			this.panel_repositories.PerformLayout();
			this.panel_installed.ResumeLayout(false);
			this.panel_installed.PerformLayout();
			this.panel_search.ResumeLayout(false);
			this.panel_search.PerformLayout();
			this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.Button button_home;
        private System.Windows.Forms.Button button_repositories;
        private System.Windows.Forms.Button button_installed;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Panel panel_home;
        private System.Windows.Forms.Panel panel_repositories;
        private System.Windows.Forms.Panel panel_installed;
        private System.Windows.Forms.Panel panel_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox_installed;
        private System.Windows.Forms.Button button_installed_remove;
        private System.Windows.Forms.ListBox listBox_installedrepos;
        private System.Windows.Forms.Button button_addrepo;
        private System.Windows.Forms.TextBox textBox_addrepo;
    }
}