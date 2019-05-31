namespace Labirint2D
{
    partial class Form_livel1
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
            this.label_start = new System.Windows.Forms.Label();
            this.label_finish = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_start
            // 
            this.label_start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label_start.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_start.Location = new System.Drawing.Point(12, 19);
            this.label_start.Name = "label_start";
            this.label_start.Size = new System.Drawing.Size(80, 55);
            this.label_start.TabIndex = 2;
            this.label_start.Text = "Старт";
            this.label_start.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_finish
            // 
            this.label_finish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label_finish.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_finish.Location = new System.Drawing.Point(708, 376);
            this.label_finish.Name = "label_finish";
            this.label_finish.Size = new System.Drawing.Size(80, 55);
            this.label_finish.TabIndex = 1;
            this.label_finish.Text = "Финиш";
            this.label_finish.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_finish.Click += new System.EventHandler(this.label_finish_Click);
            this.label_finish.MouseEnter += new System.EventHandler(this.label_finish_MouseEnter);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Green;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-9, 431);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(797, 48);
            this.label1.TabIndex = 3;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Green;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(760, -3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 418);
            this.label2.TabIndex = 4;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_livel1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(780, 441);
            this.Controls.Add(this.label_finish);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_livel1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form_livel1";
            this.Load += new System.EventHandler(this.Form_livel1_Load);
            this.Shown += new System.EventHandler(this.Form_livel1_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_start;
        private System.Windows.Forms.Label label_finish;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}