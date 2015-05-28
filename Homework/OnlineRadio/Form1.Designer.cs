namespace OnlineRadio
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
            this.radioListBox = new System.Windows.Forms.ListBox();
            this.radioName = new System.Windows.Forms.Label();
            this.next = new System.Windows.Forms.Button();
            this.previous = new System.Windows.Forms.Button();
            this.play = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioListBox
            // 
            this.radioListBox.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioListBox.FormattingEnabled = true;
            this.radioListBox.ItemHeight = 20;
            this.radioListBox.Location = new System.Drawing.Point(26, 12);
            this.radioListBox.Name = "radioListBox";
            this.radioListBox.Size = new System.Drawing.Size(323, 124);
            this.radioListBox.TabIndex = 0;
            // 
            // radioName
            // 
            this.radioName.AutoSize = true;
            this.radioName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioName.Location = new System.Drawing.Point(2, 149);
            this.radioName.Name = "radioName";
            this.radioName.Size = new System.Drawing.Size(0, 31);
            this.radioName.TabIndex = 2;
            // 
            // next
            // 
            this.next.BackgroundImage = global::OnlineRadio.Properties.Resources.next;
            this.next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.next.FlatAppearance.BorderSize = 0;
            this.next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.next.Location = new System.Drawing.Point(289, 194);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(60, 60);
            this.next.TabIndex = 4;
            this.next.Tag = "1";
            this.next.UseVisualStyleBackColor = true;
            // 
            // previous
            // 
            this.previous.BackgroundImage = global::OnlineRadio.Properties.Resources.previous;
            this.previous.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.previous.FlatAppearance.BorderSize = 0;
            this.previous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previous.Location = new System.Drawing.Point(26, 194);
            this.previous.Name = "previous";
            this.previous.Size = new System.Drawing.Size(60, 60);
            this.previous.TabIndex = 3;
            this.previous.Tag = "-1";
            this.previous.UseVisualStyleBackColor = true;
            // 
            // play
            // 
            this.play.AutoEllipsis = true;
            this.play.BackgroundImage = global::OnlineRadio.Properties.Resources.stop;
            this.play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.play.FlatAppearance.BorderSize = 0;
            this.play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.play.Location = new System.Drawing.Point(158, 194);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(60, 60);
            this.play.TabIndex = 1;
            this.play.Tag = "Stop";
            this.play.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(374, 265);
            this.Controls.Add(this.next);
            this.Controls.Add(this.previous);
            this.Controls.Add(this.radioName);
            this.Controls.Add(this.play);
            this.Controls.Add(this.radioListBox);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.Text = "Online Radio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox radioListBox;
        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Label radioName;
        private System.Windows.Forms.Button previous;
        private System.Windows.Forms.Button next;

    }
}

