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
			this.button_uninstallML = new System.Windows.Forms.Button();
			this.progressBar2 = new System.Windows.Forms.ProgressBar();
			this.button_installML = new System.Windows.Forms.Button();
			this.panel_repositories = new System.Windows.Forms.Panel();
			this.label_repo_url = new System.Windows.Forms.Label();
			this.label_repo_description = new System.Windows.Forms.Label();
			this.label_repo_title = new System.Windows.Forms.Label();
			this.listView_repos_installedrepos = new System.Windows.Forms.ListView();
			this.button_repos_remove = new System.Windows.Forms.Button();
			this.button_addrepo = new System.Windows.Forms.Button();
			this.textBox_addrepo = new System.Windows.Forms.TextBox();
			this.panel_installed = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.button_mods_localdownload = new System.Windows.Forms.Button();
			this.button_mods_modify = new System.Windows.Forms.Button();
			this.textBox_searchField = new System.Windows.Forms.TextBox();
			this.button_mods_refresh = new System.Windows.Forms.Button();
			this.label_mod_dependslist = new System.Windows.Forms.Label();
			this.label_mod_depends = new System.Windows.Forms.Label();
			this.label_mod_author = new System.Windows.Forms.Label();
			this.label_mod_version = new System.Windows.Forms.Label();
			this.button_toggleMod = new System.Windows.Forms.Button();
			this.listView_search = new System.Windows.Forms.ListView();
			this.label_mod_description = new System.Windows.Forms.Label();
			this.label_mod_title = new System.Windows.Forms.Label();
			this.listView_installed = new System.Windows.Forms.ListView();
			this.button_manuallInstall = new System.Windows.Forms.Button();
			this.button_installed_remove = new System.Windows.Forms.Button();
			this.panel_search = new System.Windows.Forms.Panel();
			this.button_debuglog = new System.Windows.Forms.Button();
			this.button_update = new System.Windows.Forms.Button();
			this.label_currentversion = new System.Windows.Forms.Label();
			this.button_packageBuilder = new System.Windows.Forms.Button();
			this.button_clean = new System.Windows.Forms.Button();
			this.button_searchDownload = new System.Windows.Forms.Button();
			this.button_search_refresh = new System.Windows.Forms.Button();
			this.button_settings = new System.Windows.Forms.Button();
			this.label_logger = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label_title = new System.Windows.Forms.Label();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel_home = new System.Windows.Forms.Panel();
			this.button_launch = new System.Windows.Forms.Button();
			this.button_launch_melonloader = new System.Windows.Forms.Button();
			this.button_launch_bepinex = new System.Windows.Forms.Button();
			this.button_launch_vanilla = new System.Windows.Forms.Button();
			this.panel_repositories.SuspendLayout();
			this.panel_installed.SuspendLayout();
			this.panel_search.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel_home.SuspendLayout();
			this.SuspendLayout();
			// 
			// button_home
			// 
			this.button_home.BackColor = System.Drawing.SystemColors.Menu;
			this.button_home.FlatAppearance.BorderSize = 0;
			this.button_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_home.Location = new System.Drawing.Point(34, 22);
			this.button_home.Name = "button_home";
			this.button_home.Size = new System.Drawing.Size(182, 39);
			this.button_home.TabIndex = 0;
			this.button_home.Text = "Home";
			this.button_home.UseVisualStyleBackColor = false;
			this.button_home.Click += new System.EventHandler(this.button_home_Click);
			// 
			// button_repositories
			// 
			this.button_repositories.BackColor = System.Drawing.SystemColors.Menu;
			this.button_repositories.FlatAppearance.BorderSize = 0;
			this.button_repositories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_repositories.Location = new System.Drawing.Point(34, 67);
			this.button_repositories.Name = "button_repositories";
			this.button_repositories.Size = new System.Drawing.Size(182, 39);
			this.button_repositories.TabIndex = 1;
			this.button_repositories.Text = "Repositories";
			this.button_repositories.UseVisualStyleBackColor = false;
			this.button_repositories.Click += new System.EventHandler(this.button_repositories_Click);
			// 
			// button_installed
			// 
			this.button_installed.BackColor = System.Drawing.SystemColors.Menu;
			this.button_installed.FlatAppearance.BorderSize = 0;
			this.button_installed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_installed.Location = new System.Drawing.Point(34, 112);
			this.button_installed.Name = "button_installed";
			this.button_installed.Size = new System.Drawing.Size(182, 39);
			this.button_installed.TabIndex = 2;
			this.button_installed.Text = "Mods";
			this.button_installed.UseVisualStyleBackColor = false;
			this.button_installed.Click += new System.EventHandler(this.button_installed_Click);
			// 
			// button_search
			// 
			this.button_search.BackColor = System.Drawing.SystemColors.Menu;
			this.button_search.FlatAppearance.BorderSize = 0;
			this.button_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_search.Location = new System.Drawing.Point(34, 724);
			this.button_search.Name = "button_search";
			this.button_search.Size = new System.Drawing.Size(182, 39);
			this.button_search.TabIndex = 3;
			this.button_search.Text = "Search";
			this.button_search.UseVisualStyleBackColor = false;
			this.button_search.Click += new System.EventHandler(this.button_search_Click);
			// 
			// button_uninstallML
			// 
			this.button_uninstallML.Location = new System.Drawing.Point(34, 976);
			this.button_uninstallML.Name = "button_uninstallML";
			this.button_uninstallML.Size = new System.Drawing.Size(118, 23);
			this.button_uninstallML.TabIndex = 7;
			this.button_uninstallML.Text = "Uninstall Melonloader";
			this.button_uninstallML.UseVisualStyleBackColor = true;
			this.button_uninstallML.Click += new System.EventHandler(this.button_uninstallML_Click);
			// 
			// progressBar2
			// 
			this.progressBar2.Location = new System.Drawing.Point(0, 1074);
			this.progressBar2.Name = "progressBar2";
			this.progressBar2.Size = new System.Drawing.Size(242, 11);
			this.progressBar2.TabIndex = 6;
			// 
			// button_installML
			// 
			this.button_installML.Location = new System.Drawing.Point(46, 922);
			this.button_installML.Name = "button_installML";
			this.button_installML.Size = new System.Drawing.Size(118, 23);
			this.button_installML.TabIndex = 5;
			this.button_installML.Text = "Install MelonLoader";
			this.button_installML.UseVisualStyleBackColor = true;
			this.button_installML.Click += new System.EventHandler(this.button_installML_Click);
			// 
			// panel_repositories
			// 
			this.panel_repositories.Controls.Add(this.label_repo_url);
			this.panel_repositories.Controls.Add(this.label_repo_description);
			this.panel_repositories.Controls.Add(this.label_repo_title);
			this.panel_repositories.Controls.Add(this.listView_repos_installedrepos);
			this.panel_repositories.Controls.Add(this.button_repos_remove);
			this.panel_repositories.Controls.Add(this.button_addrepo);
			this.panel_repositories.Controls.Add(this.textBox_addrepo);
			this.panel_repositories.Location = new System.Drawing.Point(1238, 76);
			this.panel_repositories.Name = "panel_repositories";
			this.panel_repositories.Size = new System.Drawing.Size(964, 642);
			this.panel_repositories.TabIndex = 5;
			// 
			// label_repo_url
			// 
			this.label_repo_url.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_repo_url.Location = new System.Drawing.Point(420, 261);
			this.label_repo_url.Name = "label_repo_url";
			this.label_repo_url.Size = new System.Drawing.Size(532, 22);
			this.label_repo_url.TabIndex = 13;
			this.label_repo_url.Text = "This mod doesn\'t exist and is just here as an example mod.";
			// 
			// label_repo_description
			// 
			this.label_repo_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_repo_description.Location = new System.Drawing.Point(420, 197);
			this.label_repo_description.Name = "label_repo_description";
			this.label_repo_description.Size = new System.Drawing.Size(532, 64);
			this.label_repo_description.TabIndex = 12;
			this.label_repo_description.Text = "This mod doesn\'t exist and is just here as an example mod.";
			// 
			// label_repo_title
			// 
			this.label_repo_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_repo_title.Location = new System.Drawing.Point(420, 150);
			this.label_repo_title.Name = "label_repo_title";
			this.label_repo_title.Size = new System.Drawing.Size(532, 35);
			this.label_repo_title.TabIndex = 11;
			this.label_repo_title.Text = "No Plates Only Cheeseboards";
			this.label_repo_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// listView_repos_installedrepos
			// 
			this.listView_repos_installedrepos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.listView_repos_installedrepos.FullRowSelect = true;
			this.listView_repos_installedrepos.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.listView_repos_installedrepos.HideSelection = false;
			this.listView_repos_installedrepos.Location = new System.Drawing.Point(6, 91);
			this.listView_repos_installedrepos.MultiSelect = false;
			this.listView_repos_installedrepos.Name = "listView_repos_installedrepos";
			this.listView_repos_installedrepos.Size = new System.Drawing.Size(402, 548);
			this.listView_repos_installedrepos.TabIndex = 8;
			this.listView_repos_installedrepos.UseCompatibleStateImageBehavior = false;
			this.listView_repos_installedrepos.View = System.Windows.Forms.View.Details;
			this.listView_repos_installedrepos.SelectedIndexChanged += new System.EventHandler(this.listView_repos_installedrepos_SelectedIndexChanged);
			// 
			// button_repos_remove
			// 
			this.button_repos_remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(209)))));
			this.button_repos_remove.Enabled = false;
			this.button_repos_remove.FlatAppearance.BorderSize = 0;
			this.button_repos_remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_repos_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_repos_remove.ForeColor = System.Drawing.SystemColors.Window;
			this.button_repos_remove.Location = new System.Drawing.Point(689, 91);
			this.button_repos_remove.Name = "button_repos_remove";
			this.button_repos_remove.Size = new System.Drawing.Size(263, 46);
			this.button_repos_remove.TabIndex = 5;
			this.button_repos_remove.Text = "Remove";
			this.button_repos_remove.UseVisualStyleBackColor = false;
			this.button_repos_remove.Click += new System.EventHandler(this.button_repos_remove_Click);
			// 
			// button_addrepo
			// 
			this.button_addrepo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(209)))));
			this.button_addrepo.FlatAppearance.BorderSize = 0;
			this.button_addrepo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_addrepo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_addrepo.ForeColor = System.Drawing.SystemColors.Window;
			this.button_addrepo.Location = new System.Drawing.Point(420, 91);
			this.button_addrepo.Name = "button_addrepo";
			this.button_addrepo.Size = new System.Drawing.Size(263, 46);
			this.button_addrepo.TabIndex = 4;
			this.button_addrepo.Text = "Add Repo";
			this.button_addrepo.UseVisualStyleBackColor = false;
			this.button_addrepo.Click += new System.EventHandler(this.button_addrepo_Click);
			// 
			// textBox_addrepo
			// 
			this.textBox_addrepo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.textBox_addrepo.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox_addrepo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
			this.textBox_addrepo.Location = new System.Drawing.Point(9, 10);
			this.textBox_addrepo.Multiline = true;
			this.textBox_addrepo.Name = "textBox_addrepo";
			this.textBox_addrepo.Size = new System.Drawing.Size(945, 41);
			this.textBox_addrepo.TabIndex = 3;
			this.textBox_addrepo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// panel_installed
			// 
			this.panel_installed.Controls.Add(this.label3);
			this.panel_installed.Controls.Add(this.label2);
			this.panel_installed.Controls.Add(this.progressBar1);
			this.panel_installed.Controls.Add(this.button_mods_localdownload);
			this.panel_installed.Controls.Add(this.button_mods_modify);
			this.panel_installed.Controls.Add(this.textBox_searchField);
			this.panel_installed.Controls.Add(this.button_mods_refresh);
			this.panel_installed.Controls.Add(this.label_mod_dependslist);
			this.panel_installed.Controls.Add(this.label_mod_depends);
			this.panel_installed.Controls.Add(this.label_mod_author);
			this.panel_installed.Controls.Add(this.label_mod_version);
			this.panel_installed.Controls.Add(this.button_toggleMod);
			this.panel_installed.Controls.Add(this.listView_search);
			this.panel_installed.Controls.Add(this.label_mod_description);
			this.panel_installed.Controls.Add(this.label_mod_title);
			this.panel_installed.Controls.Add(this.listView_installed);
			this.panel_installed.Location = new System.Drawing.Point(268, 779);
			this.panel_installed.Margin = new System.Windows.Forms.Padding(10);
			this.panel_installed.Name = "panel_installed";
			this.panel_installed.Size = new System.Drawing.Size(964, 642);
			this.panel_installed.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(759, 99);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 20);
			this.label3.TabIndex = 20;
			this.label3.Text = "Available";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(110, 99);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(98, 20);
			this.label2.TabIndex = 19;
			this.label2.Text = "Downloaded";
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(351, 454);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(262, 23);
			this.progressBar1.TabIndex = 12;
			// 
			// button_mods_localdownload
			// 
			this.button_mods_localdownload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(209)))));
			this.button_mods_localdownload.FlatAppearance.BorderSize = 0;
			this.button_mods_localdownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_mods_localdownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_mods_localdownload.ForeColor = System.Drawing.SystemColors.Window;
			this.button_mods_localdownload.Location = new System.Drawing.Point(402, 483);
			this.button_mods_localdownload.Name = "button_mods_localdownload";
			this.button_mods_localdownload.Size = new System.Drawing.Size(211, 45);
			this.button_mods_localdownload.TabIndex = 18;
			this.button_mods_localdownload.Text = "Local Download";
			this.button_mods_localdownload.UseVisualStyleBackColor = false;
			this.button_mods_localdownload.Click += new System.EventHandler(this.button_mods_localdownload_Click);
			// 
			// button_mods_modify
			// 
			this.button_mods_modify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(209)))));
			this.button_mods_modify.FlatAppearance.BorderSize = 0;
			this.button_mods_modify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_mods_modify.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_mods_modify.ForeColor = System.Drawing.SystemColors.Window;
			this.button_mods_modify.Location = new System.Drawing.Point(351, 534);
			this.button_mods_modify.Name = "button_mods_modify";
			this.button_mods_modify.Size = new System.Drawing.Size(262, 45);
			this.button_mods_modify.TabIndex = 17;
			this.button_mods_modify.Text = "Install";
			this.button_mods_modify.UseVisualStyleBackColor = false;
			this.button_mods_modify.Click += new System.EventHandler(this.button_mods_modify_Click);
			// 
			// textBox_searchField
			// 
			this.textBox_searchField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.textBox_searchField.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox_searchField.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_searchField.Location = new System.Drawing.Point(9, 10);
			this.textBox_searchField.Multiline = true;
			this.textBox_searchField.Name = "textBox_searchField";
			this.textBox_searchField.Size = new System.Drawing.Size(945, 41);
			this.textBox_searchField.TabIndex = 9;
			this.textBox_searchField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox_searchField.TextChanged += new System.EventHandler(this.textBox_searchField_TextChanged);
			// 
			// button_mods_refresh
			// 
			this.button_mods_refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(209)))));
			this.button_mods_refresh.FlatAppearance.BorderSize = 0;
			this.button_mods_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_mods_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_mods_refresh.ForeColor = System.Drawing.SystemColors.Window;
			this.button_mods_refresh.Location = new System.Drawing.Point(351, 585);
			this.button_mods_refresh.Name = "button_mods_refresh";
			this.button_mods_refresh.Size = new System.Drawing.Size(262, 45);
			this.button_mods_refresh.TabIndex = 16;
			this.button_mods_refresh.Text = "Refresh";
			this.button_mods_refresh.UseVisualStyleBackColor = false;
			this.button_mods_refresh.Click += new System.EventHandler(this.button_mods_refresh_Click);
			// 
			// label_mod_dependslist
			// 
			this.label_mod_dependslist.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_mod_dependslist.Location = new System.Drawing.Point(343, 368);
			this.label_mod_dependslist.Name = "label_mod_dependslist";
			this.label_mod_dependslist.Size = new System.Drawing.Size(278, 83);
			this.label_mod_dependslist.TabIndex = 15;
			this.label_mod_dependslist.Text = "- PumpkinSpiceLib 1.9.13";
			this.label_mod_dependslist.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label_mod_depends
			// 
			this.label_mod_depends.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_mod_depends.Location = new System.Drawing.Point(343, 346);
			this.label_mod_depends.Name = "label_mod_depends";
			this.label_mod_depends.Size = new System.Drawing.Size(278, 22);
			this.label_mod_depends.TabIndex = 14;
			this.label_mod_depends.Text = "Depends:";
			this.label_mod_depends.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label_mod_author
			// 
			this.label_mod_author.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_mod_author.Location = new System.Drawing.Point(343, 313);
			this.label_mod_author.Name = "label_mod_author";
			this.label_mod_author.Size = new System.Drawing.Size(278, 22);
			this.label_mod_author.TabIndex = 13;
			this.label_mod_author.Text = "Author: PumpkinSpice";
			this.label_mod_author.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label_mod_version
			// 
			this.label_mod_version.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_mod_version.Location = new System.Drawing.Point(341, 279);
			this.label_mod_version.Name = "label_mod_version";
			this.label_mod_version.Size = new System.Drawing.Size(278, 22);
			this.label_mod_version.TabIndex = 12;
			this.label_mod_version.Text = "Version: 1.1.3";
			this.label_mod_version.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// button_toggleMod
			// 
			this.button_toggleMod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(209)))));
			this.button_toggleMod.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_toggleMod.BackgroundImage")));
			this.button_toggleMod.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button_toggleMod.FlatAppearance.BorderSize = 0;
			this.button_toggleMod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_toggleMod.Location = new System.Drawing.Point(351, 483);
			this.button_toggleMod.Name = "button_toggleMod";
			this.button_toggleMod.Size = new System.Drawing.Size(45, 45);
			this.button_toggleMod.TabIndex = 8;
			this.button_toggleMod.UseVisualStyleBackColor = false;
			this.button_toggleMod.Click += new System.EventHandler(this.button_toggleMod_Click);
			// 
			// listView_search
			// 
			this.listView_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.listView_search.FullRowSelect = true;
			this.listView_search.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.listView_search.HideSelection = false;
			this.listView_search.Location = new System.Drawing.Point(637, 133);
			this.listView_search.MultiSelect = false;
			this.listView_search.Name = "listView_search";
			this.listView_search.Size = new System.Drawing.Size(316, 497);
			this.listView_search.TabIndex = 9;
			this.listView_search.UseCompatibleStateImageBehavior = false;
			this.listView_search.View = System.Windows.Forms.View.Details;
			this.listView_search.SelectedIndexChanged += new System.EventHandler(this.listView_search_SelectedIndexChanged);
			// 
			// label_mod_description
			// 
			this.label_mod_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_mod_description.Location = new System.Drawing.Point(341, 186);
			this.label_mod_description.Name = "label_mod_description";
			this.label_mod_description.Size = new System.Drawing.Size(278, 76);
			this.label_mod_description.TabIndex = 11;
			this.label_mod_description.Text = "This mod doesn\'t exist and is just here as an example mod.";
			this.label_mod_description.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label_mod_title
			// 
			this.label_mod_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_mod_title.Location = new System.Drawing.Point(339, 93);
			this.label_mod_title.Name = "label_mod_title";
			this.label_mod_title.Size = new System.Drawing.Size(278, 73);
			this.label_mod_title.TabIndex = 10;
			this.label_mod_title.Text = "No Plates Only Cheeseboards";
			this.label_mod_title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// listView_installed
			// 
			this.listView_installed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.listView_installed.FullRowSelect = true;
			this.listView_installed.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.listView_installed.HideSelection = false;
			this.listView_installed.Location = new System.Drawing.Point(8, 133);
			this.listView_installed.MultiSelect = false;
			this.listView_installed.Name = "listView_installed";
			this.listView_installed.Size = new System.Drawing.Size(316, 497);
			this.listView_installed.TabIndex = 7;
			this.listView_installed.UseCompatibleStateImageBehavior = false;
			this.listView_installed.View = System.Windows.Forms.View.Details;
			this.listView_installed.SelectedIndexChanged += new System.EventHandler(this.listView_installed_SelectedIndexChanged);
			// 
			// button_manuallInstall
			// 
			this.button_manuallInstall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(209)))));
			this.button_manuallInstall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_manuallInstall.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
			this.button_manuallInstall.ForeColor = System.Drawing.SystemColors.Window;
			this.button_manuallInstall.Location = new System.Drawing.Point(547, 74);
			this.button_manuallInstall.Name = "button_manuallInstall";
			this.button_manuallInstall.Size = new System.Drawing.Size(263, 46);
			this.button_manuallInstall.TabIndex = 5;
			this.button_manuallInstall.Text = "Manual";
			this.button_manuallInstall.UseVisualStyleBackColor = false;
			this.button_manuallInstall.Click += new System.EventHandler(this.button_manuallInstall_Click);
			// 
			// button_installed_remove
			// 
			this.button_installed_remove.Enabled = false;
			this.button_installed_remove.Location = new System.Drawing.Point(58, 872);
			this.button_installed_remove.Name = "button_installed_remove";
			this.button_installed_remove.Size = new System.Drawing.Size(75, 23);
			this.button_installed_remove.TabIndex = 4;
			this.button_installed_remove.Text = "Remove";
			this.button_installed_remove.UseVisualStyleBackColor = true;
			this.button_installed_remove.Click += new System.EventHandler(this.button_installed_remove_Click);
			// 
			// panel_search
			// 
			this.panel_search.Controls.Add(this.button_debuglog);
			this.panel_search.Controls.Add(this.button_update);
			this.panel_search.Controls.Add(this.label_currentversion);
			this.panel_search.Controls.Add(this.button_packageBuilder);
			this.panel_search.Controls.Add(this.button_manuallInstall);
			this.panel_search.Controls.Add(this.button_clean);
			this.panel_search.Location = new System.Drawing.Point(1241, 779);
			this.panel_search.Name = "panel_search";
			this.panel_search.Size = new System.Drawing.Size(964, 642);
			this.panel_search.TabIndex = 6;
			// 
			// button_debuglog
			// 
			this.button_debuglog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(209)))));
			this.button_debuglog.FlatAppearance.BorderSize = 0;
			this.button_debuglog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_debuglog.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
			this.button_debuglog.ForeColor = System.Drawing.SystemColors.Window;
			this.button_debuglog.Location = new System.Drawing.Point(279, 74);
			this.button_debuglog.Name = "button_debuglog";
			this.button_debuglog.Size = new System.Drawing.Size(262, 45);
			this.button_debuglog.TabIndex = 22;
			this.button_debuglog.Text = "Generate Debug Log";
			this.button_debuglog.UseVisualStyleBackColor = false;
			this.button_debuglog.Click += new System.EventHandler(this.button_debuglog_Click);
			// 
			// button_update
			// 
			this.button_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(209)))));
			this.button_update.FlatAppearance.BorderSize = 0;
			this.button_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
			this.button_update.ForeColor = System.Drawing.SystemColors.Window;
			this.button_update.Location = new System.Drawing.Point(11, 74);
			this.button_update.Name = "button_update";
			this.button_update.Size = new System.Drawing.Size(262, 45);
			this.button_update.TabIndex = 21;
			this.button_update.Text = "Update";
			this.button_update.UseVisualStyleBackColor = false;
			this.button_update.Click += new System.EventHandler(this.button_update_Click);
			// 
			// label_currentversion
			// 
			this.label_currentversion.AutoSize = true;
			this.label_currentversion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_currentversion.Location = new System.Drawing.Point(6, 8);
			this.label_currentversion.Name = "label_currentversion";
			this.label_currentversion.Size = new System.Drawing.Size(168, 25);
			this.label_currentversion.TabIndex = 13;
			this.label_currentversion.Text = "Current Version:";
			// 
			// button_packageBuilder
			// 
			this.button_packageBuilder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(209)))));
			this.button_packageBuilder.FlatAppearance.BorderSize = 0;
			this.button_packageBuilder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_packageBuilder.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_packageBuilder.ForeColor = System.Drawing.SystemColors.Window;
			this.button_packageBuilder.Location = new System.Drawing.Point(280, 133);
			this.button_packageBuilder.Name = "button_packageBuilder";
			this.button_packageBuilder.Size = new System.Drawing.Size(263, 46);
			this.button_packageBuilder.TabIndex = 5;
			this.button_packageBuilder.Text = "Builder";
			this.button_packageBuilder.UseVisualStyleBackColor = false;
			this.button_packageBuilder.Click += new System.EventHandler(this.button_packageBuilder_Click);
			// 
			// button_clean
			// 
			this.button_clean.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(209)))));
			this.button_clean.FlatAppearance.BorderSize = 0;
			this.button_clean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_clean.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_clean.ForeColor = System.Drawing.SystemColors.Window;
			this.button_clean.Location = new System.Drawing.Point(11, 133);
			this.button_clean.Name = "button_clean";
			this.button_clean.Size = new System.Drawing.Size(263, 46);
			this.button_clean.TabIndex = 6;
			this.button_clean.Text = "Clean";
			this.button_clean.UseVisualStyleBackColor = false;
			this.button_clean.Click += new System.EventHandler(this.button_clean_Click);
			// 
			// button_searchDownload
			// 
			this.button_searchDownload.Location = new System.Drawing.Point(89, 1166);
			this.button_searchDownload.Name = "button_searchDownload";
			this.button_searchDownload.Size = new System.Drawing.Size(75, 23);
			this.button_searchDownload.TabIndex = 14;
			this.button_searchDownload.Text = "Local Down";
			this.button_searchDownload.UseVisualStyleBackColor = true;
			this.button_searchDownload.Click += new System.EventHandler(this.button_searchDownload_Click);
			// 
			// button_search_refresh
			// 
			this.button_search_refresh.Location = new System.Drawing.Point(46, 1137);
			this.button_search_refresh.Name = "button_search_refresh";
			this.button_search_refresh.Size = new System.Drawing.Size(75, 23);
			this.button_search_refresh.TabIndex = 10;
			this.button_search_refresh.Text = "Refresh";
			this.button_search_refresh.UseVisualStyleBackColor = true;
			this.button_search_refresh.Click += new System.EventHandler(this.button_search_refresh_Click);
			// 
			// button_settings
			// 
			this.button_settings.BackColor = System.Drawing.SystemColors.Menu;
			this.button_settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button_settings.FlatAppearance.BorderSize = 0;
			this.button_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_settings.Location = new System.Drawing.Point(34, 158);
			this.button_settings.Name = "button_settings";
			this.button_settings.Size = new System.Drawing.Size(182, 39);
			this.button_settings.TabIndex = 7;
			this.button_settings.Text = "Settings";
			this.button_settings.UseVisualStyleBackColor = false;
			this.button_settings.Click += new System.EventHandler(this.button_settings_Click);
			// 
			// label_logger
			// 
			this.label_logger.Location = new System.Drawing.Point(3, 603);
			this.label_logger.Name = "label_logger";
			this.label_logger.Size = new System.Drawing.Size(259, 36);
			this.label_logger.TabIndex = 8;
			this.label_logger.Text = "label_logger";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.label_title);
			this.panel2.Controls.Add(this.pictureBox3);
			this.panel2.Cursor = System.Windows.Forms.Cursors.Default;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1232, 76);
			this.panel2.TabIndex = 9;
			// 
			// label_title
			// 
			this.label_title.AutoSize = true;
			this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_title.Location = new System.Drawing.Point(82, 19);
			this.label_title.Name = "label_title";
			this.label_title.Size = new System.Drawing.Size(371, 39);
			this.label_title.TabIndex = 11;
			this.label_title.Text = "PlateUp! Mod Manager";
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(0, 0);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(76, 76);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 11;
			this.pictureBox3.TabStop = false;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.button_home);
			this.panel3.Controls.Add(this.button_repositories);
			this.panel3.Controls.Add(this.button_installed);
			this.panel3.Controls.Add(this.button_settings);
			this.panel3.Controls.Add(this.label_logger);
			this.panel3.Location = new System.Drawing.Point(0, 76);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(268, 642);
			this.panel3.TabIndex = 10;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(144, 27);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(314, 24);
			this.label5.TabIndex = 1;
			this.label5.Text = "Welcome to PlateUp! Mod Manager!";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label7.Location = new System.Drawing.Point(145, 73);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(572, 48);
			this.label7.TabIndex = 3;
			this.label7.Text = "PLEASE NOTE: PlateUp! does NOT officially support mods.\r\n\r\nWe ( Or any other unof" +
    "ficial mods ) are not directly affiliated with the PlateUp! game, or Yogscast.\r\n" +
    "";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(18, 15);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(120, 120);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// panel_home
			// 
			this.panel_home.Controls.Add(this.button_launch);
			this.panel_home.Controls.Add(this.pictureBox1);
			this.panel_home.Controls.Add(this.label7);
			this.panel_home.Controls.Add(this.label5);
			this.panel_home.Location = new System.Drawing.Point(268, 76);
			this.panel_home.Name = "panel_home";
			this.panel_home.Size = new System.Drawing.Size(964, 642);
			this.panel_home.TabIndex = 4;
			// 
			// button_launch
			// 
			this.button_launch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(209)))));
			this.button_launch.FlatAppearance.BorderSize = 0;
			this.button_launch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_launch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_launch.ForeColor = System.Drawing.SystemColors.Window;
			this.button_launch.Location = new System.Drawing.Point(21, 150);
			this.button_launch.Name = "button_launch";
			this.button_launch.Size = new System.Drawing.Size(263, 46);
			this.button_launch.TabIndex = 10;
			this.button_launch.Text = "Launch PlateUp!";
			this.button_launch.UseVisualStyleBackColor = false;
			this.button_launch.Click += new System.EventHandler(this.button_launch_Click);
			// 
			// button_launch_melonloader
			// 
			this.button_launch_melonloader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(209)))));
			this.button_launch_melonloader.Enabled = false;
			this.button_launch_melonloader.FlatAppearance.BorderSize = 0;
			this.button_launch_melonloader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_launch_melonloader.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_launch_melonloader.ForeColor = System.Drawing.SystemColors.Window;
			this.button_launch_melonloader.Location = new System.Drawing.Point(938, 725);
			this.button_launch_melonloader.Name = "button_launch_melonloader";
			this.button_launch_melonloader.Size = new System.Drawing.Size(263, 46);
			this.button_launch_melonloader.TabIndex = 9;
			this.button_launch_melonloader.Text = "Launch MelonLoader";
			this.button_launch_melonloader.UseVisualStyleBackColor = false;
			// 
			// button_launch_bepinex
			// 
			this.button_launch_bepinex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(209)))));
			this.button_launch_bepinex.Enabled = false;
			this.button_launch_bepinex.FlatAppearance.BorderSize = 0;
			this.button_launch_bepinex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_launch_bepinex.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_launch_bepinex.ForeColor = System.Drawing.SystemColors.Window;
			this.button_launch_bepinex.Location = new System.Drawing.Point(615, 726);
			this.button_launch_bepinex.Name = "button_launch_bepinex";
			this.button_launch_bepinex.Size = new System.Drawing.Size(263, 46);
			this.button_launch_bepinex.TabIndex = 8;
			this.button_launch_bepinex.Text = "Launch BepInEx";
			this.button_launch_bepinex.UseVisualStyleBackColor = false;
			// 
			// button_launch_vanilla
			// 
			this.button_launch_vanilla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(159)))), ((int)(((byte)(209)))));
			this.button_launch_vanilla.Enabled = false;
			this.button_launch_vanilla.FlatAppearance.BorderSize = 0;
			this.button_launch_vanilla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_launch_vanilla.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_launch_vanilla.ForeColor = System.Drawing.SystemColors.Window;
			this.button_launch_vanilla.Location = new System.Drawing.Point(292, 725);
			this.button_launch_vanilla.Name = "button_launch_vanilla";
			this.button_launch_vanilla.Size = new System.Drawing.Size(263, 46);
			this.button_launch_vanilla.TabIndex = 7;
			this.button_launch_vanilla.Text = "Launch Vanilla";
			this.button_launch_vanilla.UseVisualStyleBackColor = false;
			this.button_launch_vanilla.Click += new System.EventHandler(this.button_launch_vanilla_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(2332, 1421);
			this.Controls.Add(this.button_searchDownload);
			this.Controls.Add(this.button_launch_melonloader);
			this.Controls.Add(this.button_launch_bepinex);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.button_launch_vanilla);
			this.Controls.Add(this.button_search_refresh);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.button_uninstallML);
			this.Controls.Add(this.button_search);
			this.Controls.Add(this.progressBar2);
			this.Controls.Add(this.panel_home);
			this.Controls.Add(this.panel_installed);
			this.Controls.Add(this.button_installML);
			this.Controls.Add(this.panel_search);
			this.Controls.Add(this.panel_repositories);
			this.Controls.Add(this.button_installed_remove);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "PlateUp Mod Manager";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.panel_repositories.ResumeLayout(false);
			this.panel_repositories.PerformLayout();
			this.panel_installed.ResumeLayout(false);
			this.panel_installed.PerformLayout();
			this.panel_search.ResumeLayout(false);
			this.panel_search.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel_home.ResumeLayout(false);
			this.panel_home.PerformLayout();
			this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.Button button_home;
        private System.Windows.Forms.Button button_repositories;
        private System.Windows.Forms.Button button_installed;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Panel panel_repositories;
        private System.Windows.Forms.Panel panel_installed;
        private System.Windows.Forms.Panel panel_search;
        private System.Windows.Forms.Button button_settings;
        private System.Windows.Forms.Button button_installed_remove;
        private System.Windows.Forms.Button button_addrepo;
        private System.Windows.Forms.TextBox textBox_addrepo;
        private System.Windows.Forms.Button button_repos_remove;
        private System.Windows.Forms.Button button_manuallInstall;
        private System.Windows.Forms.ListView listView_installed;
        private System.Windows.Forms.ListView listView_repos_installedrepos;
        private System.Windows.Forms.ListView listView_search;
        private System.Windows.Forms.Button button_search_refresh;
        private System.Windows.Forms.Label label_logger;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.TextBox textBox_searchField;
		private System.Windows.Forms.Label label_currentversion;
		private System.Windows.Forms.Button button_installML;
		private System.Windows.Forms.Button button_uninstallML;
		private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Button button_toggleMod;
        private System.Windows.Forms.Button button_searchDownload;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_packageBuilder;
        private System.Windows.Forms.Button button_clean;
        private System.Windows.Forms.Panel panel_home;
        private System.Windows.Forms.Label label_title;
		private System.Windows.Forms.Button button_launch_melonloader;
		private System.Windows.Forms.Button button_launch_bepinex;
		private System.Windows.Forms.Button button_launch_vanilla;
		private System.Windows.Forms.Label label_mod_description;
		private System.Windows.Forms.Label label_mod_title;
		private System.Windows.Forms.Label label_mod_dependslist;
		private System.Windows.Forms.Label label_mod_depends;
		private System.Windows.Forms.Label label_mod_author;
		private System.Windows.Forms.Label label_mod_version;
		private System.Windows.Forms.Button button_mods_localdownload;
		private System.Windows.Forms.Button button_mods_modify;
		private System.Windows.Forms.Button button_mods_refresh;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label_repo_description;
		private System.Windows.Forms.Label label_repo_title;
		private System.Windows.Forms.Label label_repo_url;
		private System.Windows.Forms.Button button_update;
		private System.Windows.Forms.Button button_debuglog;
		private System.Windows.Forms.Button button_launch;
    }
}