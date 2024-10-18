namespace Topic_9___GUI_Introduction
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.imgCharacter = new System.Windows.Forms.PictureBox();
            this.lblIsntructor = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgCharacter)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Red;
            this.btnSubmit.Font = new System.Drawing.Font("Ravie", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnSubmit.Location = new System.Drawing.Point(493, 201);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(92, 23);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Click Me";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // imgCharacter
            // 
            this.imgCharacter.Image = ((System.Drawing.Image)(resources.GetObject("imgCharacter.Image")));
            this.imgCharacter.Location = new System.Drawing.Point(109, 166);
            this.imgCharacter.Name = "imgCharacter";
            this.imgCharacter.Size = new System.Drawing.Size(346, 147);
            this.imgCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCharacter.TabIndex = 1;
            this.imgCharacter.TabStop = false;
            this.imgCharacter.Click += new System.EventHandler(this.imgCharacter_Click);
            // 
            // lblIsntructor
            // 
            this.lblIsntructor.AutoSize = true;
            this.lblIsntructor.BackColor = System.Drawing.Color.Green;
            this.lblIsntructor.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsntructor.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblIsntructor.Location = new System.Drawing.Point(313, 64);
            this.lblIsntructor.Name = "lblIsntructor";
            this.lblIsntructor.Size = new System.Drawing.Size(199, 14);
            this.lblIsntructor.TabIndex = 2;
            this.lblIsntructor.Text = "Click the Button, or the PictureBox";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Turquoise;
            this.lblStatus.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(618, 75);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(48, 16);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Status";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 635);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblIsntructor);
            this.Controls.Add(this.imgCharacter);
            this.Controls.Add(this.btnSubmit);
            this.Name = "MainForm";
            this.Text = "Controls, Events, and Properties";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgCharacter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.PictureBox imgCharacter;
        private System.Windows.Forms.Label lblIsntructor;
        private System.Windows.Forms.Label lblStatus;
    }
}

