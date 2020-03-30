namespace KEAOpgave4._2
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
            this.listBoxWhile = new System.Windows.Forms.ListBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.textBoxTableNum = new System.Windows.Forms.TextBox();
            this.buttonWhile = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.buttonFor = new System.Windows.Forms.Button();
            this.listBoxFor = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxWhile
            // 
            this.listBoxWhile.FormattingEnabled = true;
            this.listBoxWhile.ItemHeight = 25;
            this.listBoxWhile.Location = new System.Drawing.Point(72, 218);
            this.listBoxWhile.Name = "listBoxWhile";
            this.listBoxWhile.Size = new System.Drawing.Size(269, 554);
            this.listBoxWhile.TabIndex = 0;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(67, 36);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(398, 50);
            this.labelInfo.TabIndex = 1;
            this.labelInfo.Text = "Write a number for the factor of the table\r\n you want to see and click a button:";
            // 
            // textBoxTableNum
            // 
            this.textBoxTableNum.Location = new System.Drawing.Point(511, 46);
            this.textBoxTableNum.Name = "textBoxTableNum";
            this.textBoxTableNum.Size = new System.Drawing.Size(91, 31);
            this.textBoxTableNum.TabIndex = 2;
            // 
            // buttonWhile
            // 
            this.buttonWhile.Location = new System.Drawing.Point(114, 148);
            this.buttonWhile.Name = "buttonWhile";
            this.buttonWhile.Size = new System.Drawing.Size(162, 40);
            this.buttonWhile.TabIndex = 3;
            this.buttonWhile.Text = "While Loop";
            this.buttonWhile.UseVisualStyleBackColor = true;
            this.buttonWhile.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(379, 84);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 25);
            this.labelError.TabIndex = 4;
            // 
            // buttonFor
            // 
            this.buttonFor.Location = new System.Drawing.Point(465, 148);
            this.buttonFor.Name = "buttonFor";
            this.buttonFor.Size = new System.Drawing.Size(162, 40);
            this.buttonFor.TabIndex = 5;
            this.buttonFor.Text = "For Loop";
            this.buttonFor.UseVisualStyleBackColor = true;
            this.buttonFor.Click += new System.EventHandler(this.buttonFor_Click);
            // 
            // listBoxFor
            // 
            this.listBoxFor.FormattingEnabled = true;
            this.listBoxFor.ItemHeight = 25;
            this.listBoxFor.Location = new System.Drawing.Point(414, 218);
            this.listBoxFor.Name = "listBoxFor";
            this.listBoxFor.Size = new System.Drawing.Size(269, 554);
            this.listBoxFor.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 813);
            this.Controls.Add(this.listBoxFor);
            this.Controls.Add(this.buttonFor);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.buttonWhile);
            this.Controls.Add(this.textBoxTableNum);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.listBoxWhile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxWhile;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.TextBox textBoxTableNum;
        private System.Windows.Forms.Button buttonWhile;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Button buttonFor;
        private System.Windows.Forms.ListBox listBoxFor;
    }
}

