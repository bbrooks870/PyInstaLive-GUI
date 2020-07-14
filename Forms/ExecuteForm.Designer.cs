namespace PyInstaLive_GUI
{
    partial class ExecuteForm
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
            this.ExecutionOutputTextBox = new System.Windows.Forms.TextBox();
            this.KillProcessButton = new System.Windows.Forms.Button();
            this.SendCtrlCButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExecutionOutputTextBox
            // 
            this.ExecutionOutputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ExecutionOutputTextBox.Enabled = false;
            this.ExecutionOutputTextBox.Location = new System.Drawing.Point(12, 12);
            this.ExecutionOutputTextBox.Multiline = true;
            this.ExecutionOutputTextBox.Name = "ExecutionOutputTextBox";
            this.ExecutionOutputTextBox.ReadOnly = true;
            this.ExecutionOutputTextBox.Size = new System.Drawing.Size(660, 408);
            this.ExecutionOutputTextBox.TabIndex = 0;
            // 
            // KillProcessButton
            // 
            this.KillProcessButton.Location = new System.Drawing.Point(352, 426);
            this.KillProcessButton.Name = "KillProcessButton";
            this.KillProcessButton.Size = new System.Drawing.Size(320, 23);
            this.KillProcessButton.TabIndex = 2;
            this.KillProcessButton.Text = "Kill Process";
            this.KillProcessButton.UseVisualStyleBackColor = true;
            this.KillProcessButton.Click += new System.EventHandler(this.KillProcessButtonClicked);
            // 
            // SendCtrlCButton
            // 
            this.SendCtrlCButton.Location = new System.Drawing.Point(12, 426);
            this.SendCtrlCButton.Name = "SendCtrlCButton";
            this.SendCtrlCButton.Size = new System.Drawing.Size(320, 23);
            this.SendCtrlCButton.TabIndex = 1;
            this.SendCtrlCButton.Text = "Send [CTRL+C]";
            this.SendCtrlCButton.UseVisualStyleBackColor = true;
            this.SendCtrlCButton.Click += new System.EventHandler(this.SendCtrlCButtonClicked);
            // 
            // ExecuteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.SendCtrlCButton);
            this.Controls.Add(this.KillProcessButton);
            this.Controls.Add(this.ExecutionOutputTextBox);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExecuteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Execution Window";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ExecutionOutputTextBox;
        private System.Windows.Forms.Button KillProcessButton;
        private System.Windows.Forms.Button SendCtrlCButton;
    }
}