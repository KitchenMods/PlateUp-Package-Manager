namespace PlateUp_Package_Manager
{
	partial class FirstLaunchForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstLaunchForm));
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.button_next = new System.Windows.Forms.Button();
			this.label_messages = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(3, 48);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(695, 20);
			this.textBox1.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(698, 74);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Continue";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 32);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(112, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "PlateUp.exe Location:";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(698, 45);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 4;
			this.button2.Text = "Browse";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(55, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(697, 33);
			this.label1.TabIndex = 5;
			this.label1.Text = "Welcome to the Unofficial PlateUp Mod Manager!";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.button_next);
			this.panel1.Controls.Add(this.label_messages);
			this.panel1.Location = new System.Drawing.Point(12, 156);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(776, 100);
			this.panel1.TabIndex = 6;
			// 
			// button_next
			// 
			this.button_next.BackColor = System.Drawing.Color.Transparent;
			this.button_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_next.Location = new System.Drawing.Point(351, 62);
			this.button_next.Name = "button_next";
			this.button_next.Size = new System.Drawing.Size(75, 23);
			this.button_next.TabIndex = 1;
			this.button_next.Text = ">";
			this.button_next.UseVisualStyleBackColor = false;
			this.button_next.Click += new System.EventHandler(this.button_next_Click);
			// 
			// label_messages
			// 
			this.label_messages.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_messages.Location = new System.Drawing.Point(3, 13);
			this.label_messages.Name = "label_messages";
			this.label_messages.Size = new System.Drawing.Size(770, 37);
			this.label_messages.TabIndex = 0;
			this.label_messages.Text = "Hey there! It looks like you\'re new around here.";
			this.label_messages.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.button1);
			this.panel2.Controls.Add(this.button2);
			this.panel2.Controls.Add(this.textBox1);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Location = new System.Drawing.Point(12, 338);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(776, 100);
			this.panel2.TabIndex = 7;
			this.panel2.Visible = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 74);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(0, 13);
			this.label3.TabIndex = 5;
			// 
			// FirstLaunchForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "FirstLaunchForm";
			this.Text = "PlateUp Mod Manager";
			this.Load += new System.EventHandler(this.FirstLaunchForm_Load);
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.Label label_messages;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
    }
}