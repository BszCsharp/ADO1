namespace ADO1
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                 components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonConnection = new System.Windows.Forms.Button();
            this.buttonCommand = new System.Windows.Forms.Button();
            this.buttonRead = new System.Windows.Forms.Button();
            this.listBoxAusgabe = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxArtGruppe = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonConnection
            // 
            this.buttonConnection.Location = new System.Drawing.Point(60, 12);
            this.buttonConnection.Name = "buttonConnection";
            this.buttonConnection.Size = new System.Drawing.Size(149, 39);
            this.buttonConnection.TabIndex = 0;
            this.buttonConnection.Text = "Connection öffnen";
            this.buttonConnection.UseVisualStyleBackColor = true;
            this.buttonConnection.Click += new System.EventHandler(this.buttonConnection_Click);
            // 
            // buttonCommand
            // 
            this.buttonCommand.Enabled = false;
            this.buttonCommand.Location = new System.Drawing.Point(65, 84);
            this.buttonCommand.Name = "buttonCommand";
            this.buttonCommand.Size = new System.Drawing.Size(144, 37);
            this.buttonCommand.TabIndex = 1;
            this.buttonCommand.Text = "Kommando";
            this.buttonCommand.UseVisualStyleBackColor = true;
            this.buttonCommand.Click += new System.EventHandler(this.buttonCommand_Click);
            // 
            // buttonRead
            // 
            this.buttonRead.Enabled = false;
            this.buttonRead.Location = new System.Drawing.Point(64, 148);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(144, 37);
            this.buttonRead.TabIndex = 2;
            this.buttonRead.Text = "auslesen";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // listBoxAusgabe
            // 
            this.listBoxAusgabe.FormattingEnabled = true;
            this.listBoxAusgabe.Location = new System.Drawing.Point(65, 221);
            this.listBoxAusgabe.Name = "listBoxAusgabe";
            this.listBoxAusgabe.Size = new System.Drawing.Size(331, 147);
            this.listBoxAusgabe.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Artikelgruppe";
            // 
            // textBoxArtGruppe
            // 
            this.textBoxArtGruppe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxArtGruppe.Location = new System.Drawing.Point(301, 88);
            this.textBoxArtGruppe.Name = "textBoxArtGruppe";
            this.textBoxArtGruppe.Size = new System.Drawing.Size(149, 26);
            this.textBoxArtGruppe.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 403);
            this.Controls.Add(this.textBoxArtGruppe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxAusgabe);
            this.Controls.Add(this.buttonRead);
            this.Controls.Add(this.buttonCommand);
            this.Controls.Add(this.buttonConnection);
            this.Name = "Form1";
            this.Text = "ADO-Beispiel 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonConnection;
        private System.Windows.Forms.Button buttonCommand;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.ListBox listBoxAusgabe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxArtGruppe;
    }
}

