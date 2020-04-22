namespace MDI_FredyDeLeon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.interfaz1 = new capaDiseño.interfaz();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // interfaz1
            // 
            this.interfaz1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("interfaz1.BackgroundImage")));
            this.interfaz1.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.interfaz1.Location = new System.Drawing.Point(2, 0);
            this.interfaz1.Name = "interfaz1";
            this.interfaz1.Size = new System.Drawing.Size(797, 358);
            this.interfaz1.TabIndex = 0;
            this.interfaz1.Load += new System.EventHandler(this.interfaz1_Load);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.PanSouth;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(698, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 58);
            this.button3.TabIndex = 3;
            this.button3.Text = "CERRAR";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 349);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.interfaz1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private capaDiseño.interfaz interfaz1;
        private System.Windows.Forms.Button button3;
    }
}