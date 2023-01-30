namespace FrogcomposbandManager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRefreshSaves = new System.Windows.Forms.Button();
            this.lbSaves = new System.Windows.Forms.ListBox();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRefreshSaves
            // 
            this.btnRefreshSaves.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRefreshSaves.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRefreshSaves.Location = new System.Drawing.Point(27, 20);
            this.btnRefreshSaves.Name = "btnRefreshSaves";
            this.btnRefreshSaves.Size = new System.Drawing.Size(137, 59);
            this.btnRefreshSaves.TabIndex = 0;
            this.btnRefreshSaves.Text = "Reload";
            this.btnRefreshSaves.UseVisualStyleBackColor = true;
            this.btnRefreshSaves.Click += new System.EventHandler(this.btnRefreshSaves_Click);
            // 
            // lbSaves
            // 
            this.lbSaves.BackColor = System.Drawing.SystemColors.InfoText;
            this.lbSaves.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSaves.ForeColor = System.Drawing.SystemColors.Window;
            this.lbSaves.FormattingEnabled = true;
            this.lbSaves.ItemHeight = 37;
            this.lbSaves.Location = new System.Drawing.Point(27, 108);
            this.lbSaves.Name = "lbSaves";
            this.lbSaves.Size = new System.Drawing.Size(473, 670);
            this.lbSaves.TabIndex = 1;
            // 
            // btnBackup
            // 
            this.btnBackup.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBackup.Location = new System.Drawing.Point(624, 108);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(128, 100);
            this.btnBackup.TabIndex = 2;
            this.btnBackup.Text = "BACKUP";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnRestore
            // 
            this.btnRestore.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRestore.Location = new System.Drawing.Point(624, 400);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(128, 100);
            this.btnRestore.TabIndex = 3;
            this.btnRestore.Text = "RESTORE";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnLaunch
            // 
            this.btnLaunch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLaunch.Location = new System.Drawing.Point(624, 692);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(128, 100);
            this.btnLaunch.TabIndex = 4;
            this.btnLaunch.Text = "LAUNCH";
            this.btnLaunch.UseVisualStyleBackColor = true;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.Location = new System.Drawing.Point(363, 20);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(137, 59);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(837, 838);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnLaunch);
            this.Controls.Add(this.btnRestore);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.lbSaves);
            this.Controls.Add(this.btnRefreshSaves);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Frogcomposband Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnRefreshSaves;
        private ListBox lbSaves;
        private Button btnBackup;
        private Button btnRestore;
        private Button btnLaunch;
        private Button btnDelete;
    }
}