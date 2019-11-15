namespace TicketSalling2._0
{
    partial class TicketForm
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
            this.ticket = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            // 
            // ticket
            // 
            this.ticket.Location = new System.Drawing.Point(12, 15);
            this.ticket.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ticket.Multiline = true;
            this.ticket.Name = "ticket";
            this.ticket.ReadOnly = true;
            this.ticket.Size = new System.Drawing.Size(781, 102);
            this.ticket.TabIndex = 0;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(644, 148);
            this.okButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(96, 39);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "ok(";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // TicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 212);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.ticket);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TicketForm";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Ticket_Load);

        }

        #endregion

        private System.Windows.Forms.TextBox ticket;
        private System.Windows.Forms.Button okButton;
    }
}