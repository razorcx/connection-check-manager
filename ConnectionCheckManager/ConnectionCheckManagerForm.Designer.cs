namespace ConnectionCheckManager
{
	partial class ConnectionCheckManagerForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectionCheckManagerForm));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.dataGridViewConnectionCheckingSummary = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.btnRefresh = new System.Windows.Forms.Button();
			this.textBoxWithPluginCount = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxWithoutPluginCount = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewConnectionCheckingSummary)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::ConnectionCheckManager.Properties.Resources.Logo;
			this.pictureBox1.Location = new System.Drawing.Point(12, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(171, 42);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 15;
			this.pictureBox1.TabStop = false;
			// 
			// dataGridViewConnectionCheckingSummary
			// 
			this.dataGridViewConnectionCheckingSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewConnectionCheckingSummary.Location = new System.Drawing.Point(12, 91);
			this.dataGridViewConnectionCheckingSummary.Name = "dataGridViewConnectionCheckingSummary";
			this.dataGridViewConnectionCheckingSummary.RowTemplate.Height = 24;
			this.dataGridViewConnectionCheckingSummary.Size = new System.Drawing.Size(1189, 250);
			this.dataGridViewConnectionCheckingSummary.TabIndex = 16;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(11, 67);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(204, 17);
			this.label1.TabIndex = 17;
			this.label1.Text = "Connection Checking Summary";
			// 
			// btnRefresh
			// 
			this.btnRefresh.Location = new System.Drawing.Point(1063, 48);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(137, 36);
			this.btnRefresh.TabIndex = 18;
			this.btnRefresh.Text = "Refresh";
			this.btnRefresh.UseVisualStyleBackColor = true;
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// textBoxWithPluginCount
			// 
			this.textBoxWithPluginCount.BackColor = System.Drawing.Color.PaleGreen;
			this.textBoxWithPluginCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxWithPluginCount.Location = new System.Drawing.Point(552, 63);
			this.textBoxWithPluginCount.Name = "textBoxWithPluginCount";
			this.textBoxWithPluginCount.Size = new System.Drawing.Size(49, 22);
			this.textBoxWithPluginCount.TabIndex = 19;
			this.textBoxWithPluginCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(326, 67);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(211, 17);
			this.label2.TabIndex = 20;
			this.label2.Text = "Connections WITH Check Plugin";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(626, 67);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(241, 17);
			this.label3.TabIndex = 22;
			this.label3.Text = "Connections WITHOUT Check Plugin";
			// 
			// textBoxWithoutPluginCount
			// 
			this.textBoxWithoutPluginCount.BackColor = System.Drawing.Color.SeaShell;
			this.textBoxWithoutPluginCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxWithoutPluginCount.Location = new System.Drawing.Point(882, 63);
			this.textBoxWithoutPluginCount.Name = "textBoxWithoutPluginCount";
			this.textBoxWithoutPluginCount.Size = new System.Drawing.Size(49, 22);
			this.textBoxWithoutPluginCount.TabIndex = 21;
			this.textBoxWithoutPluginCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ConnectionCheckManagerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.ClientSize = new System.Drawing.Size(1213, 353);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBoxWithoutPluginCount);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBoxWithPluginCount);
			this.Controls.Add(this.btnRefresh);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridViewConnectionCheckingSummary);
			this.Controls.Add(this.pictureBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ConnectionCheckManagerForm";
			this.Text = "Connection Check Manager";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewConnectionCheckingSummary)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.DataGridView dataGridViewConnectionCheckingSummary;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnRefresh;
		private System.Windows.Forms.TextBox textBoxWithPluginCount;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxWithoutPluginCount;
	}
}

