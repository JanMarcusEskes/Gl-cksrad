namespace Glücksrad
{
  partial class Main
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
      this.btnPlus = new System.Windows.Forms.Button();
      this.btnMinus = new System.Windows.Forms.Button();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.wert4 = new System.Windows.Forms.Label();
      this.wert3 = new System.Windows.Forms.Label();
      this.wert2 = new System.Windows.Forms.Label();
      this.wert1 = new System.Windows.Forms.Label();
      this.wert0 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.btnAddRemove = new System.Windows.Forms.Button();
      this.txtAddRemove = new System.Windows.Forms.TextBox();
      this.btnRandom = new System.Windows.Forms.Button();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnPlus
      // 
      this.btnPlus.Location = new System.Drawing.Point(88, 22);
      this.btnPlus.Name = "btnPlus";
      this.btnPlus.Size = new System.Drawing.Size(25, 25);
      this.btnPlus.TabIndex = 0;
      this.btnPlus.Text = "▲";
      this.btnPlus.UseVisualStyleBackColor = true;
      this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
      // 
      // btnMinus
      // 
      this.btnMinus.Location = new System.Drawing.Point(85, 123);
      this.btnMinus.Name = "btnMinus";
      this.btnMinus.Size = new System.Drawing.Size(25, 25);
      this.btnMinus.TabIndex = 1;
      this.btnMinus.Text = "▼";
      this.btnMinus.UseVisualStyleBackColor = true;
      this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.wert4);
      this.groupBox1.Controls.Add(this.wert3);
      this.groupBox1.Controls.Add(this.wert2);
      this.groupBox1.Controls.Add(this.wert1);
      this.groupBox1.Controls.Add(this.wert0);
      this.groupBox1.Location = new System.Drawing.Point(26, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(53, 139);
      this.groupBox1.TabIndex = 2;
      this.groupBox1.TabStop = false;
      // 
      // wert4
      // 
      this.wert4.AutoSize = true;
      this.wert4.ForeColor = System.Drawing.Color.Gray;
      this.wert4.Location = new System.Drawing.Point(6, 117);
      this.wert4.Name = "wert4";
      this.wert4.Size = new System.Drawing.Size(36, 13);
      this.wert4.TabIndex = 4;
      this.wert4.Text = "Wert4";
      // 
      // wert3
      // 
      this.wert3.AutoSize = true;
      this.wert3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.wert3.Location = new System.Drawing.Point(6, 91);
      this.wert3.Name = "wert3";
      this.wert3.Size = new System.Drawing.Size(36, 13);
      this.wert3.TabIndex = 3;
      this.wert3.Text = "Wert3";
      // 
      // wert2
      // 
      this.wert2.AutoSize = true;
      this.wert2.Location = new System.Drawing.Point(6, 67);
      this.wert2.Name = "wert2";
      this.wert2.Size = new System.Drawing.Size(36, 13);
      this.wert2.TabIndex = 2;
      this.wert2.Text = "Wert2";
      // 
      // wert1
      // 
      this.wert1.AutoSize = true;
      this.wert1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.wert1.Location = new System.Drawing.Point(6, 41);
      this.wert1.Name = "wert1";
      this.wert1.Size = new System.Drawing.Size(36, 13);
      this.wert1.TabIndex = 1;
      this.wert1.Text = "Wert1";
      // 
      // wert0
      // 
      this.wert0.AutoSize = true;
      this.wert0.ForeColor = System.Drawing.Color.Gray;
      this.wert0.Location = new System.Drawing.Point(6, 16);
      this.wert0.Name = "wert0";
      this.wert0.Size = new System.Drawing.Size(36, 13);
      this.wert0.TabIndex = 0;
      this.wert0.Text = "Wert0";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(85, 79);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(12, 13);
      this.label1.TabIndex = 5;
      this.label1.Text = "◄";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(8, 79);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(12, 13);
      this.label2.TabIndex = 6;
      this.label2.Text = "►";
      // 
      // btnAddRemove
      // 
      this.btnAddRemove.Location = new System.Drawing.Point(9, 197);
      this.btnAddRemove.Name = "btnAddRemove";
      this.btnAddRemove.Size = new System.Drawing.Size(118, 37);
      this.btnAddRemove.TabIndex = 7;
      this.btnAddRemove.Text = "Wert hinzufügen/entfernen";
      this.btnAddRemove.UseVisualStyleBackColor = true;
      this.btnAddRemove.Click += new System.EventHandler(this.button1_Click);
      // 
      // txtAddRemove
      // 
      this.txtAddRemove.Location = new System.Drawing.Point(11, 171);
      this.txtAddRemove.Name = "txtAddRemove";
      this.txtAddRemove.Size = new System.Drawing.Size(116, 20);
      this.txtAddRemove.TabIndex = 8;
      // 
      // btnRandom
      // 
      this.btnRandom.Location = new System.Drawing.Point(132, 73);
      this.btnRandom.Name = "btnRandom";
      this.btnRandom.Size = new System.Drawing.Size(53, 25);
      this.btnRandom.TabIndex = 9;
      this.btnRandom.Text = "Drehen";
      this.btnRandom.UseVisualStyleBackColor = true;
      this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
      // 
      // Main
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(197, 252);
      this.Controls.Add(this.btnRandom);
      this.Controls.Add(this.txtAddRemove);
      this.Controls.Add(this.btnAddRemove);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.btnMinus);
      this.Controls.Add(this.btnPlus);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Name = "Main";
      this.Text = "Glücksrad";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnPlus;
    private System.Windows.Forms.Button btnMinus;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label wert4;
    private System.Windows.Forms.Label wert3;
    private System.Windows.Forms.Label wert2;
    private System.Windows.Forms.Label wert1;
    private System.Windows.Forms.Label wert0;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button btnAddRemove;
    private System.Windows.Forms.TextBox txtAddRemove;
    private System.Windows.Forms.Button btnRandom;
  }
}

