namespace TicketSalling2._0
{
    partial class FlightForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FromLab = new System.Windows.Forms.Label();
            this.ThereLab = new System.Windows.Forms.Label();
            this.ToLab = new System.Windows.Forms.Label();
            this.There = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.From = new System.Windows.Forms.ComboBox();
            this.To = new System.Windows.Forms.ComboBox();
            this.Class = new System.Windows.Forms.ComboBox();
            this.ClassLab = new System.Windows.Forms.Label();
            // 
            // FromLab
            // 
            this.FromLab.AutoSize = true;
            this.FromLab.Location = new System.Drawing.Point(12, 39);
            this.FromLab.Name = "FromLab";
            this.FromLab.Size = new System.Drawing.Size(130, 20);
            this.FromLab.TabIndex = 0;
            this.FromLab.Text = "Departure Airport:";
            // 
            // ThereLab
            // 
            this.ThereLab.AutoSize = true;
            this.ThereLab.Location = new System.Drawing.Point(221, 39);
            this.ThereLab.Name = "ThereLab";
            this.ThereLab.Size = new System.Drawing.Size(116, 20);
            this.ThereLab.TabIndex = 1;
            this.ThereLab.Text = "Departure Time:";
            // 
            // ToLab
            // 
            this.ToLab.AutoSize = true;
            this.ToLab.Location = new System.Drawing.Point(12, 138);
            this.ToLab.Name = "ToLab";
            this.ToLab.Size = new System.Drawing.Size(139, 20);
            this.ToLab.TabIndex = 2;
            this.ToLab.Text = "Destination Airport:";
            // 
            // There
            // 
            this.There.Location = new System.Drawing.Point(221, 86);
            this.There.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.There.Name = "There";
            this.There.Size = new System.Drawing.Size(200, 27);
            this.There.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(488, 180);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 10;
            this.button1.Text = "Find";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // From
            // 
            this.From.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.From.FormattingEnabled = true;
            this.From.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.From.Location = new System.Drawing.Point(12, 85);
            this.From.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.From.Name = "From";
            this.From.Size = new System.Drawing.Size(139, 28);
            this.From.TabIndex = 11;
            // 
            // To
            // 
            this.To.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.To.FormattingEnabled = true;
            this.To.Location = new System.Drawing.Point(12, 178);
            this.To.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.To.Name = "To";
            this.To.Size = new System.Drawing.Size(139, 28);
            this.To.TabIndex = 12;
            // 
            // Class
            // 
            this.Class.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Class.FormattingEnabled = true;
            this.Class.Location = new System.Drawing.Point(488, 88);
            this.Class.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Class.Name = "Class";
            this.Class.Size = new System.Drawing.Size(121, 28);
            this.Class.TabIndex = 14;
            // 
            // ClassLab
            // 
            this.ClassLab.AutoSize = true;
            this.ClassLab.Location = new System.Drawing.Point(488, 39);
            this.ClassLab.Name = "ClassLab";
            this.ClassLab.Size = new System.Drawing.Size(45, 20);
            this.ClassLab.TabIndex = 16;
            this.ClassLab.Text = "Class:";
            // 
            // FlightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 295);
            this.Controls.Add(this.ClassLab);
            this.Controls.Add(this.Class);
            this.Controls.Add(this.To);
            this.Controls.Add(this.From);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.There);
            this.Controls.Add(this.ToLab);
            this.Controls.Add(this.ThereLab);
            this.Controls.Add(this.FromLab);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FlightForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);

        }

        #endregion

        private System.Windows.Forms.Label FromLab;
        private System.Windows.Forms.Label ThereLab;
        private System.Windows.Forms.Label ToLab;
        private System.Windows.Forms.DateTimePicker There;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox From;
        private System.Windows.Forms.ComboBox To;
      
        private System.Windows.Forms.ComboBox Class;
        private System.Windows.Forms.Label ClassLab;
        
    }
}

