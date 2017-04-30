namespace WHReplayNamer
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.playerFaction = new System.Windows.Forms.ComboBox();
            this.opposingFaction = new System.Windows.Forms.ComboBox();
            this.submit = new System.Windows.Forms.Button();
            this.notes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // playerFaction
            // 
            this.playerFaction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.playerFaction.FormattingEnabled = true;
            this.playerFaction.Items.AddRange(new object[] {
            "Space Marines",
            "Eldar",
            "Orkz"});
            this.playerFaction.Location = new System.Drawing.Point(12, 12);
            this.playerFaction.Name = "playerFaction";
            this.playerFaction.Size = new System.Drawing.Size(121, 21);
            this.playerFaction.TabIndex = 0;
            // 
            // opposingFaction
            // 
            this.opposingFaction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.opposingFaction.FormattingEnabled = true;
            this.opposingFaction.Items.AddRange(new object[] {
            "Space Marines",
            "Eldar",
            "Orkz"});
            this.opposingFaction.Location = new System.Drawing.Point(151, 12);
            this.opposingFaction.Name = "opposingFaction";
            this.opposingFaction.Size = new System.Drawing.Size(121, 21);
            this.opposingFaction.TabIndex = 1;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(83, 65);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(121, 23);
            this.submit.TabIndex = 2;
            this.submit.Text = "Generate";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // notes
            // 
            this.notes.Location = new System.Drawing.Point(12, 39);
            this.notes.Name = "notes";
            this.notes.Size = new System.Drawing.Size(260, 20);
            this.notes.TabIndex = 3;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 99);
            this.Controls.Add(this.notes);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.opposingFaction);
            this.Controls.Add(this.playerFaction);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form";
            this.Text = "WH Replay Namer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox playerFaction;
        private System.Windows.Forms.ComboBox opposingFaction;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox notes;
    }
}

