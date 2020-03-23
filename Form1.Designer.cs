namespace WalkingMan1._0
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
            this.components = new System.ComponentModel.Container();
            this.Man = new System.Windows.Forms.PictureBox();
            this.action = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Man)).BeginInit();
            this.SuspendLayout();
            // 
            // Man
            // 
            this.Man.Image = global::WalkingMan1._0.Properties.Resources._1;
            this.Man.Location = new System.Drawing.Point(12, 291);
            this.Man.Name = "Man";
            this.Man.Size = new System.Drawing.Size(100, 100);
            this.Man.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Man.TabIndex = 0;
            this.Man.TabStop = false;
            // 
            // action
            // 
            this.action.Tick += new System.EventHandler(this.action_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Man);
            this.Name = "Form1";
            this.Text = "WalkingMan1.0";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Man)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Man;
        private System.Windows.Forms.Timer action;
    }
}

