namespace Summarize_Document
{
    partial class TLDR
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
            this.SidePanel = new System.Windows.Forms.Panel();
            this.Exit = new System.Windows.Forms.Button();
            this.Open = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.resultText = new System.Windows.Forms.RichTextBox();
            this.wikipedia = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.OLength = new System.Windows.Forms.Label();
            this.ALength = new System.Windows.Forms.Label();
            this.SidePanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.DarkGray;
            this.SidePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SidePanel.Controls.Add(this.ALength);
            this.SidePanel.Controls.Add(this.OLength);
            this.SidePanel.Controls.Add(this.label3);
            this.SidePanel.Controls.Add(this.label2);
            this.SidePanel.Controls.Add(this.wikipedia);
            this.SidePanel.Controls.Add(this.Exit);
            this.SidePanel.Controls.Add(this.Open);
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanel.Location = new System.Drawing.Point(0, 0);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(213, 458);
            this.SidePanel.TabIndex = 0;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(2, 303);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(210, 69);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Open
            // 
            this.Open.BackColor = System.Drawing.Color.DodgerBlue;
            this.Open.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Open.Location = new System.Drawing.Point(3, 111);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(210, 65);
            this.Open.TabIndex = 2;
            this.Open.Text = "Open";
            this.Open.UseVisualStyleBackColor = false;
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.DarkGray;
            this.topPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(213, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(781, 76);
            this.topPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(261, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Text Summarizer";
            // 
            // resultText
            // 
            this.resultText.Location = new System.Drawing.Point(234, 80);
            this.resultText.Name = "resultText";
            this.resultText.Size = new System.Drawing.Size(738, 366);
            this.resultText.TabIndex = 2;
            this.resultText.Text = "Summary will go here";
            // 
            // wikipedia
            // 
            this.wikipedia.BackColor = System.Drawing.Color.DodgerBlue;
            this.wikipedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wikipedia.Location = new System.Drawing.Point(0, 196);
            this.wikipedia.Name = "wikipedia";
            this.wikipedia.Size = new System.Drawing.Size(210, 65);
            this.wikipedia.TabIndex = 4;
            this.wikipedia.Text = "Wikipedia Article";
            this.wikipedia.UseVisualStyleBackColor = false;
            this.wikipedia.Click += new System.EventHandler(this.wikipedia_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Original Length :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Length After :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // OLength
            // 
            this.OLength.AutoSize = true;
            this.OLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OLength.Location = new System.Drawing.Point(150, 8);
            this.OLength.Name = "OLength";
            this.OLength.Size = new System.Drawing.Size(0, 20);
            this.OLength.TabIndex = 7;
            // 
            // ALength
            // 
            this.ALength.AutoSize = true;
            this.ALength.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ALength.Location = new System.Drawing.Point(141, 42);
            this.ALength.Name = "ALength";
            this.ALength.Size = new System.Drawing.Size(0, 20);
            this.ALength.TabIndex = 8;
            // 
            // TLDR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(994, 458);
            this.Controls.Add(this.resultText);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.SidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TLDR";
            this.RightToLeftLayout = true;
            this.Text = "Form1";
            this.SidePanel.ResumeLayout(false);
            this.SidePanel.PerformLayout();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.RichTextBox resultText;
        private System.Windows.Forms.Button wikipedia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ALength;
        private System.Windows.Forms.Label OLength;
    }
}

