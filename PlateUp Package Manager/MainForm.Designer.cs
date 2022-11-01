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
			this.button_clean = new System.Windows.Forms.Button();
			this.button_packageBuilder = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.button_uninstallML = new System.Windows.Forms.Button();
			this.progressBar2 = new System.Windows.Forms.ProgressBar();
			this.button_installML = new System.Windows.Forms.Button();
			this.panel_repositories = new System.Windows.Forms.Panel();
			this.label_selectedInstalledRepoInformation = new System.Windows.Forms.Label();
			this.listView_repos_installedrepos = new System.Windows.Forms.ListView();
			this.button_repos_remove = new System.Windows.Forms.Button();
			this.button_addrepo = new System.Windows.Forms.Button();
			this.textBox_addrepo = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.panel_installed = new System.Windows.Forms.Panel();
			this.button_toggleMod = new System.Windows.Forms.Button();
			this.listView_installed = new System.Windows.Forms.ListView();
			this.label_selectedInstalledPackageInformation = new System.Windows.Forms.Label();
			this.button_manuallInstall = new System.Windows.Forms.Button();
			this.button_installed_remove = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.panel_search = new System.Windows.Forms.Panel();
			this.button_searchDownload = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox_searchField = new System.Windows.Forms.TextBox();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.button_searchInstall = new System.Windows.Forms.Button();
			this.label_selectedSearchPackageInformation = new System.Windows.Forms.Label();
			this.button_search_refresh = new System.Windows.Forms.Button();
			this.listView_search = new System.Windows.Forms.ListView();
			this.label4 = new System.Windows.Forms.Label();
			this.button_settings = new System.Windows.Forms.Button();
			this.label_logger = new System.Windows.Forms.Label();
			this.panel_home.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
			this.panel_home.Controls.Add(this.button_clean);
			this.panel_home.Controls.Add(this.button_packageBuilder);
			this.panel_home.Controls.Add(this.pictureBox1);
			this.panel_home.Controls.Add(this.label7);
			this.panel_home.Controls.Add(this.label5);
			this.panel_home.Controls.Add(this.label1);
			this.panel_home.Location = new System.Drawing.Point(12, 12);
			this.panel_home.Name = "panel_home";
			this.panel_home.Size = new System.Drawing.Size(776, 397);
			this.panel_home.TabIndex = 4;
			// 
			// button_clean
			// 
			this.button_clean.Location = new System.Drawing.Point(610, 360);
			this.button_clean.Name = "button_clean";
			this.button_clean.Size = new System.Drawing.Size(75, 23);
			this.button_clean.TabIndex = 6;
			this.button_clean.Text = "Clean";
			this.button_clean.UseVisualStyleBackColor = true;
			this.button_clean.Click += new System.EventHandler(this.button_clean_Click);
			// 
			// button_packageBuilder
			// 
			this.button_packageBuilder.Location = new System.Drawing.Point(691, 360);
			this.button_packageBuilder.Name = "button_packageBuilder";
			this.button_packageBuilder.Size = new System.Drawing.Size(75, 23);
			this.button_packageBuilder.TabIndex = 5;
			this.button_packageBuilder.Text = "Builder";
			this.button_packageBuilder.UseVisualStyleBackColor = true;
			this.button_packageBuilder.Click += new System.EventHandler(this.button_packageBuilder_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(8, 143);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(200, 200);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
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
			// button_uninstallML
			// 
			this.button_uninstallML.Location = new System.Drawing.Point(1510, 415);
			this.button_uninstallML.Name = "button_uninstallML";
			this.button_uninstallML.Size = new System.Drawing.Size(118, 23);
			this.button_uninstallML.TabIndex = 7;
			this.button_uninstallML.Text = "Uninstall Melonloader";
			this.button_uninstallML.UseVisualStyleBackColor = true;
			this.button_uninstallML.Click += new System.EventHandler(this.button_uninstallML_Click);
			// 
			// progressBar2
			// 
			this.progressBar2.Location = new System.Drawing.Point(1386, 444);
			this.progressBar2.Name = "progressBar2";
			this.progressBar2.Size = new System.Drawing.Size(242, 11);
			this.progressBar2.TabIndex = 6;
			// 
			// button_installML
			// 
			this.button_installML.Location = new System.Drawing.Point(1386, 415);
			this.button_installML.Name = "button_installML";
			this.button_installML.Size = new System.Drawing.Size(118, 23);
			this.button_installML.TabIndex = 5;
			this.button_installML.Text = "Install MelonLoader";
			this.button_installML.UseVisualStyleBackColor = true;
			this.button_installML.Click += new System.EventHandler(this.button_installML_Click);
			// 
			// panel_repositories
			// 
			this.panel_repositories.Controls.Add(this.label_selectedInstalledRepoInformation);
			this.panel_repositories.Controls.Add(this.listView_repos_installedrepos);
			this.panel_repositories.Controls.Add(this.button_repos_remove);
			this.panel_repositories.Controls.Add(this.button_addrepo);
			this.panel_repositories.Controls.Add(this.textBox_addrepo);
			this.panel_repositories.Controls.Add(this.label2);
			this.panel_repositories.Location = new System.Drawing.Point(852, 12);
			this.panel_repositories.Name = "panel_repositories";
			this.panel_repositories.Size = new System.Drawing.Size(776, 397);
			this.panel_repositories.TabIndex = 5;
			// 
			// label_selectedInstalledRepoInformation
			// 
			this.label_selectedInstalledRepoInformation.Location = new System.Drawing.Point(414, 91);
			this.label_selectedInstalledRepoInformation.Name = "label_selectedInstalledRepoInformation";
			this.label_selectedInstalledRepoInformation.Size = new System.Drawing.Size(278, 292);
			this.label_selectedInstalledRepoInformation.TabIndex = 8;
			this.label_selectedInstalledRepoInformation.Text = "label_selectedInstalledRepoInformation";
			// 
			// listView_repos_installedrepos
			// 
			this.listView_repos_installedrepos.FullRowSelect = true;
			this.listView_repos_installedrepos.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.listView_repos_installedrepos.HideSelection = false;
			this.listView_repos_installedrepos.Location = new System.Drawing.Point(6, 91);
			this.listView_repos_installedrepos.MultiSelect = false;
			this.listView_repos_installedrepos.Name = "listView_repos_installedrepos";
			this.listView_repos_installedrepos.Size = new System.Drawing.Size(402, 292);
			this.listView_repos_installedrepos.TabIndex = 8;
			this.listView_repos_installedrepos.UseCompatibleStateImageBehavior = false;
			this.listView_repos_installedrepos.View = System.Windows.Forms.View.Details;
			this.listView_repos_installedrepos.SelectedIndexChanged += new System.EventHandler(this.listView_repos_installedrepos_SelectedIndexChanged);
			// 
			// button_repos_remove
			// 
			this.button_repos_remove.Enabled = false;
			this.button_repos_remove.Location = new System.Drawing.Point(698, 91);
			this.button_repos_remove.Name = "button_repos_remove";
			this.button_repos_remove.Size = new System.Drawing.Size(75, 23);
			this.button_repos_remove.TabIndex = 5;
			this.button_repos_remove.Text = "Remove";
			this.button_repos_remove.UseVisualStyleBackColor = true;
			this.button_repos_remove.Click += new System.EventHandler(this.button_repos_remove_Click);
			// 
			// button_addrepo
			// 
			this.button_addrepo.Location = new System.Drawing.Point(698, 62);
			this.button_addrepo.Name = "button_addrepo";
			this.button_addrepo.Size = new System.Drawing.Size(75, 23);
			this.button_addrepo.TabIndex = 4;
			this.button_addrepo.Text = "Add Repo";
			this.button_addrepo.UseVisualStyleBackColor = true;
			this.button_addrepo.Click += new System.EventHandler(this.button_addrepo_Click);
			// 
			// textBox_addrepo
			// 
			this.textBox_addrepo.Location = new System.Drawing.Point(3, 65);
			this.textBox_addrepo.Name = "textBox_addrepo";
			this.textBox_addrepo.Size = new System.Drawing.Size(689, 20);
			this.textBox_addrepo.TabIndex = 3;
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
			this.panel_installed.Controls.Add(this.button_toggleMod);
			this.panel_installed.Controls.Add(this.listView_installed);
			this.panel_installed.Controls.Add(this.label_selectedInstalledPackageInformation);
			this.panel_installed.Controls.Add(this.button_manuallInstall);
			this.panel_installed.Controls.Add(this.button_installed_remove);
			this.panel_installed.Controls.Add(this.label3);
			this.panel_installed.Location = new System.Drawing.Point(12, 465);
			this.panel_installed.Name = "panel_installed";
			this.panel_installed.Size = new System.Drawing.Size(776, 397);
			this.panel_installed.TabIndex = 6;
			// 
			// button_toggleMod
			// 
			this.button_toggleMod.Location = new System.Drawing.Point(419, 309);
			this.button_toggleMod.Name = "button_toggleMod";
			this.button_toggleMod.Size = new System.Drawing.Size(75, 23);
			this.button_toggleMod.TabIndex = 8;
			this.button_toggleMod.Text = "Toggle";
			this.button_toggleMod.UseVisualStyleBackColor = true;
			this.button_toggleMod.Click += new System.EventHandler(this.button_toggleMod_Click);
			// 
			// listView_installed
			// 
			this.listView_installed.FullRowSelect = true;
			this.listView_installed.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.listView_installed.HideSelection = false;
			this.listView_installed.Location = new System.Drawing.Point(8, 48);
			this.listView_installed.MultiSelect = false;
			this.listView_installed.Name = "listView_installed";
			this.listView_installed.Size = new System.Drawing.Size(402, 342);
			this.listView_installed.TabIndex = 7;
			this.listView_installed.UseCompatibleStateImageBehavior = false;
			this.listView_installed.View = System.Windows.Forms.View.Details;
			this.listView_installed.SelectedIndexChanged += new System.EventHandler(this.listView_installed_SelectedIndexChanged);
			// 
			// label_selectedInstalledPackageInformation
			// 
			this.label_selectedInstalledPackageInformation.Location = new System.Drawing.Point(416, 48);
			this.label_selectedInstalledPackageInformation.Name = "label_selectedInstalledPackageInformation";
			this.label_selectedInstalledPackageInformation.Size = new System.Drawing.Size(350, 258);
			this.label_selectedInstalledPackageInformation.TabIndex = 6;
			this.label_selectedInstalledPackageInformation.Text = "label_selectedInstalledPackageInformation";
			// 
			// button_manuallInstall
			// 
			this.button_manuallInstall.Location = new System.Drawing.Point(416, 338);
			this.button_manuallInstall.Name = "button_manuallInstall";
			this.button_manuallInstall.Size = new System.Drawing.Size(75, 23);
			this.button_manuallInstall.TabIndex = 5;
			this.button_manuallInstall.Text = "Manual";
			this.button_manuallInstall.UseVisualStyleBackColor = true;
			this.button_manuallInstall.Click += new System.EventHandler(this.button_manuallInstall_Click);
			// 
			// button_installed_remove
			// 
			this.button_installed_remove.Enabled = false;
			this.button_installed_remove.Location = new System.Drawing.Point(416, 367);
			this.button_installed_remove.Name = "button_installed_remove";
			this.button_installed_remove.Size = new System.Drawing.Size(75, 23);
			this.button_installed_remove.TabIndex = 4;
			this.button_installed_remove.Text = "Remove";
			this.button_installed_remove.UseVisualStyleBackColor = true;
			this.button_installed_remove.Click += new System.EventHandler(this.button_installed_remove_Click);
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
			this.panel_search.Controls.Add(this.button_searchDownload);
			this.panel_search.Controls.Add(this.label6);
			this.panel_search.Controls.Add(this.textBox_searchField);
			this.panel_search.Controls.Add(this.progressBar1);
			this.panel_search.Controls.Add(this.button_searchInstall);
			this.panel_search.Controls.Add(this.label_selectedSearchPackageInformation);
			this.panel_search.Controls.Add(this.button_search_refresh);
			this.panel_search.Controls.Add(this.listView_search);
			this.panel_search.Controls.Add(this.label4);
			this.panel_search.Location = new System.Drawing.Point(852, 465);
			this.panel_search.Name = "panel_search";
			this.panel_search.Size = new System.Drawing.Size(776, 397);
			this.panel_search.TabIndex = 6;
			// 
			// button_searchDownload
			// 
			this.button_searchDownload.Location = new System.Drawing.Point(698, 338);
			this.button_searchDownload.Name = "button_searchDownload";
			this.button_searchDownload.Size = new System.Drawing.Size(75, 23);
			this.button_searchDownload.TabIndex = 14;
			this.button_searchDownload.Text = "Local Down";
			this.button_searchDownload.UseVisualStyleBackColor = true;
			this.button_searchDownload.Click += new System.EventHandler(this.button_searchDownload_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(3, 59);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(41, 13);
			this.label6.TabIndex = 13;
			this.label6.Text = "Search";
			// 
			// textBox_searchField
			// 
			this.textBox_searchField.Location = new System.Drawing.Point(3, 75);
			this.textBox_searchField.Name = "textBox_searchField";
			this.textBox_searchField.Size = new System.Drawing.Size(770, 20);
			this.textBox_searchField.TabIndex = 9;
			this.textBox_searchField.TextChanged += new System.EventHandler(this.textBox_searchField_TextChanged);
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(417, 309);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(356, 23);
			this.progressBar1.TabIndex = 12;
			// 
			// button_searchInstall
			// 
			this.button_searchInstall.Enabled = false;
			this.button_searchInstall.Location = new System.Drawing.Point(417, 338);
			this.button_searchInstall.Name = "button_searchInstall";
			this.button_searchInstall.Size = new System.Drawing.Size(75, 23);
			this.button_searchInstall.TabIndex = 11;
			this.button_searchInstall.Text = "Install";
			this.button_searchInstall.UseVisualStyleBackColor = true;
			this.button_searchInstall.Click += new System.EventHandler(this.button_searchInstall_Click);
			// 
			// label_selectedSearchPackageInformation
			// 
			this.label_selectedSearchPackageInformation.Location = new System.Drawing.Point(414, 98);
			this.label_selectedSearchPackageInformation.Name = "label_selectedSearchPackageInformation";
			this.label_selectedSearchPackageInformation.Size = new System.Drawing.Size(359, 208);
			this.label_selectedSearchPackageInformation.TabIndex = 8;
			this.label_selectedSearchPackageInformation.Text = "label_selectedSearchPackageInformation";
			// 
			// button_search_refresh
			// 
			this.button_search_refresh.Location = new System.Drawing.Point(417, 367);
			this.button_search_refresh.Name = "button_search_refresh";
			this.button_search_refresh.Size = new System.Drawing.Size(75, 23);
			this.button_search_refresh.TabIndex = 10;
			this.button_search_refresh.Text = "Refresh";
			this.button_search_refresh.UseVisualStyleBackColor = true;
			this.button_search_refresh.Click += new System.EventHandler(this.button_search_refresh_Click);
			// 
			// listView_search
			// 
			this.listView_search.FullRowSelect = true;
			this.listView_search.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.listView_search.HideSelection = false;
			this.listView_search.Location = new System.Drawing.Point(6, 98);
			this.listView_search.MultiSelect = false;
			this.listView_search.Name = "listView_search";
			this.listView_search.Size = new System.Drawing.Size(402, 292);
			this.listView_search.TabIndex = 9;
			this.listView_search.UseCompatibleStateImageBehavior = false;
			this.listView_search.View = System.Windows.Forms.View.Details;
			this.listView_search.SelectedIndexChanged += new System.EventHandler(this.listView_search_SelectedIndexChanged);
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
			// button_settings
			// 
			this.button_settings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_settings.BackgroundImage")));
			this.button_settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button_settings.Location = new System.Drawing.Point(755, 415);
			this.button_settings.Name = "button_settings";
			this.button_settings.Size = new System.Drawing.Size(23, 23);
			this.button_settings.TabIndex = 7;
			this.button_settings.UseVisualStyleBackColor = true;
			this.button_settings.Click += new System.EventHandler(this.button_settings_Click);
			// 
			// label_logger
			// 
			this.label_logger.AutoSize = true;
			this.label_logger.Location = new System.Drawing.Point(12, 446);
			this.label_logger.Name = "label_logger";
			this.label_logger.Size = new System.Drawing.Size(64, 13);
			this.label_logger.TabIndex = 8;
			this.label_logger.Text = "label_logger";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1703, 906);
			this.Controls.Add(this.button_uninstallML);
			this.Controls.Add(this.progressBar2);
			this.Controls.Add(this.label_logger);
			this.Controls.Add(this.button_installML);
			this.Controls.Add(this.button_settings);
			this.Controls.Add(this.panel_installed);
			this.Controls.Add(this.panel_search);
			this.Controls.Add(this.panel_repositories);
			this.Controls.Add(this.panel_home);
			this.Controls.Add(this.button_search);
			this.Controls.Add(this.button_installed);
			this.Controls.Add(this.button_repositories);
			this.Controls.Add(this.button_home);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "PlateUp Mod Manager";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.panel_home.ResumeLayout(false);
			this.panel_home.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel_repositories.ResumeLayout(false);
			this.panel_repositories.PerformLayout();
			this.panel_installed.ResumeLayout(false);
			this.panel_installed.PerformLayout();
			this.panel_search.ResumeLayout(false);
			this.panel_search.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

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
        private System.Windows.Forms.Button button_settings;
        private System.Windows.Forms.Button button_installed_remove;
        private System.Windows.Forms.Button button_addrepo;
        private System.Windows.Forms.TextBox textBox_addrepo;
        private System.Windows.Forms.Button button_repos_remove;
        private System.Windows.Forms.Button button_manuallInstall;
        private System.Windows.Forms.Label label_selectedInstalledPackageInformation;
        private System.Windows.Forms.ListView listView_installed;
        private System.Windows.Forms.ListView listView_repos_installedrepos;
        private System.Windows.Forms.Label label_selectedInstalledRepoInformation;
        private System.Windows.Forms.ListView listView_search;
        private System.Windows.Forms.Button button_search_refresh;
        private System.Windows.Forms.Label label_selectedSearchPackageInformation;
        private System.Windows.Forms.Label label_logger;
        private System.Windows.Forms.Button button_searchInstall;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.TextBox textBox_searchField;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button button_installML;
		private System.Windows.Forms.Button button_uninstallML;
		private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Button button_toggleMod;
        private System.Windows.Forms.Button button_packageBuilder;
        private System.Windows.Forms.Button button_clean;
        private System.Windows.Forms.Button button_searchDownload;
    }
}