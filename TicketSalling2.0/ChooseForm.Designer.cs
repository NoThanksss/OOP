using System;

namespace TicketSalling2._0
{
    partial class ChooseForm
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
            this.TrueF = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            // 
            // TrueF
            // 
            this.TrueF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TrueF.FormattingEnabled = true;
            this.TrueF.Location = new System.Drawing.Point(12, 90);
            this.TrueF.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TrueF.Name = "TrueF";
            this.TrueF.Size = new System.Drawing.Size(1161, 28);
            this.TrueF.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(544, 231);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "choose";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // ChooseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 290);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TrueF);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ChooseForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.ChooseForm_Load);

        }

        //private void TrueF_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        #endregion

        private System.Windows.Forms.ComboBox TrueF;
        private System.Windows.Forms.Button button1;
    }
}