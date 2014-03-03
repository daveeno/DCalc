namespace DCalc
{
  partial class DCalc
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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DCalc));
      this.label2 = new System.Windows.Forms.Label();
      this.txtInfix = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.txtPostfix = new System.Windows.Forms.TextBox();
      this.btnDrop = new System.Windows.Forms.Button();
      this.btnSwap = new System.Windows.Forms.Button();
      this.btnClear = new System.Windows.Forms.Button();
      this.cbCalcMode = new System.Windows.Forms.CheckBox();
      this.cbDegRad = new System.Windows.Forms.ComboBox();
      this.panel1 = new System.Windows.Forms.Panel();
      this.labelT = new System.Windows.Forms.Label();
      this.labelZ = new System.Windows.Forms.Label();
      this.labelY = new System.Windows.Forms.Label();
      this.labelX = new System.Windows.Forms.Label();
      this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.showStackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.btnMatrixCalc = new System.Windows.Forms.Button();
      this.btnBitCalc = new System.Windows.Forms.Button();
      this.btnVectorCalc = new System.Windows.Forms.Button();
      this.panel1.SuspendLayout();
      this.contextMenuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.ForeColor = System.Drawing.Color.White;
      this.label2.Location = new System.Drawing.Point(13, 9);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(26, 13);
      this.label2.TabIndex = 0;
      this.label2.Text = "Infix";
      // 
      // txtInfix
      // 
      this.txtInfix.Location = new System.Drawing.Point(57, 6);
      this.txtInfix.Name = "txtInfix";
      this.txtInfix.Size = new System.Drawing.Size(191, 20);
      this.txtInfix.TabIndex = 1;
      this.txtInfix.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInfix_KeyDown);
      this.txtInfix.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtInfix_KeyUp);
      this.txtInfix.Leave += new System.EventHandler(this.txtInfix_Leave);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.ForeColor = System.Drawing.Color.White;
      this.label3.Location = new System.Drawing.Point(13, 34);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(38, 13);
      this.label3.TabIndex = 2;
      this.label3.Text = "Postfix";
      // 
      // txtPostfix
      // 
      this.txtPostfix.Location = new System.Drawing.Point(57, 31);
      this.txtPostfix.Name = "txtPostfix";
      this.txtPostfix.Size = new System.Drawing.Size(191, 20);
      this.txtPostfix.TabIndex = 1;
      this.txtPostfix.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPostScript_KeyDown);
      this.txtPostfix.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPostScript_KeyUp);
      this.txtPostfix.Leave += new System.EventHandler(this.txtPostScript_Leave);
      // 
      // btnDrop
      // 
      this.btnDrop.Location = new System.Drawing.Point(493, 101);
      this.btnDrop.Name = "btnDrop";
      this.btnDrop.Size = new System.Drawing.Size(18, 23);
      this.btnDrop.TabIndex = 17;
      this.btnDrop.Text = "D";
      this.btnDrop.UseVisualStyleBackColor = true;
      this.btnDrop.Click += new System.EventHandler(this.btnDrop_Click);
      // 
      // btnSwap
      // 
      this.btnSwap.Location = new System.Drawing.Point(493, 72);
      this.btnSwap.Name = "btnSwap";
      this.btnSwap.Size = new System.Drawing.Size(18, 23);
      this.btnSwap.TabIndex = 18;
      this.btnSwap.Text = "S";
      this.btnSwap.UseVisualStyleBackColor = true;
      this.btnSwap.Click += new System.EventHandler(this.btnSwap_Click);
      // 
      // btnClear
      // 
      this.btnClear.Location = new System.Drawing.Point(493, 5);
      this.btnClear.Name = "btnClear";
      this.btnClear.Size = new System.Drawing.Size(18, 23);
      this.btnClear.TabIndex = 19;
      this.btnClear.Text = "C";
      this.btnClear.UseVisualStyleBackColor = true;
      this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
      // 
      // cbCalcMode
      // 
      this.cbCalcMode.AutoSize = true;
      this.cbCalcMode.ForeColor = System.Drawing.Color.White;
      this.cbCalcMode.Location = new System.Drawing.Point(201, 57);
      this.cbCalcMode.Name = "cbCalcMode";
      this.cbCalcMode.Size = new System.Drawing.Size(47, 17);
      this.cbCalcMode.TabIndex = 20;
      this.cbCalcMode.Text = "Calc";
      this.cbCalcMode.UseVisualStyleBackColor = true;
      // 
      // cbDegRad
      // 
      this.cbDegRad.FormattingEnabled = true;
      this.cbDegRad.Items.AddRange(new object[] {
            "Deg",
            "Rad"});
      this.cbDegRad.Location = new System.Drawing.Point(201, 96);
      this.cbDegRad.Name = "cbDegRad";
      this.cbDegRad.Size = new System.Drawing.Size(47, 21);
      this.cbDegRad.TabIndex = 21;
      this.cbDegRad.Text = "Deg";
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
      this.panel1.Controls.Add(this.labelT);
      this.panel1.Controls.Add(this.labelZ);
      this.panel1.Controls.Add(this.labelY);
      this.panel1.Controls.Add(this.labelX);
      this.panel1.Location = new System.Drawing.Point(254, 5);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(233, 121);
      this.panel1.TabIndex = 24;
      // 
      // labelT
      // 
      this.labelT.AutoSize = true;
      this.labelT.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelT.ForeColor = System.Drawing.Color.White;
      this.labelT.Location = new System.Drawing.Point(3, 5);
      this.labelT.Name = "labelT";
      this.labelT.Size = new System.Drawing.Size(28, 18);
      this.labelT.TabIndex = 3;
      this.labelT.Text = "T:";
      // 
      // labelZ
      // 
      this.labelZ.AutoSize = true;
      this.labelZ.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelZ.ForeColor = System.Drawing.Color.White;
      this.labelZ.Location = new System.Drawing.Point(3, 35);
      this.labelZ.Name = "labelZ";
      this.labelZ.Size = new System.Drawing.Size(28, 18);
      this.labelZ.TabIndex = 2;
      this.labelZ.Text = "Z:";
      // 
      // labelY
      // 
      this.labelY.AutoSize = true;
      this.labelY.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelY.ForeColor = System.Drawing.Color.White;
      this.labelY.Location = new System.Drawing.Point(3, 65);
      this.labelY.Name = "labelY";
      this.labelY.Size = new System.Drawing.Size(28, 18);
      this.labelY.TabIndex = 1;
      this.labelY.Text = "Y:";
      // 
      // labelX
      // 
      this.labelX.AutoSize = true;
      this.labelX.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelX.ForeColor = System.Drawing.Color.White;
      this.labelX.Location = new System.Drawing.Point(3, 95);
      this.labelX.Name = "labelX";
      this.labelX.Size = new System.Drawing.Size(28, 18);
      this.labelX.TabIndex = 0;
      this.labelX.Text = "X:";
      // 
      // contextMenuStrip1
      // 
      this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.showStackToolStripMenuItem});
      this.contextMenuStrip1.Name = "contextMenuStrip1";
      this.contextMenuStrip1.Size = new System.Drawing.Size(134, 48);
      // 
      // copyToolStripMenuItem
      // 
      this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
      this.copyToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
      this.copyToolStripMenuItem.Text = "Copy";
      this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
      // 
      // showStackToolStripMenuItem
      // 
      this.showStackToolStripMenuItem.Name = "showStackToolStripMenuItem";
      this.showStackToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
      this.showStackToolStripMenuItem.Text = "Copy Stack";
      this.showStackToolStripMenuItem.Click += new System.EventHandler(this.showStackToolStripMenuItem_Click);
      // 
      // btnMatrixCalc
      // 
      this.btnMatrixCalc.Location = new System.Drawing.Point(12, 96);
      this.btnMatrixCalc.Name = "btnMatrixCalc";
      this.btnMatrixCalc.Size = new System.Drawing.Size(18, 23);
      this.btnMatrixCalc.TabIndex = 25;
      this.btnMatrixCalc.Text = "M";
      this.btnMatrixCalc.UseVisualStyleBackColor = true;
      this.btnMatrixCalc.Click += new System.EventHandler(this.btnMatrixCalc_Click);
      // 
      // btnBitCalc
      // 
      this.btnBitCalc.Location = new System.Drawing.Point(36, 96);
      this.btnBitCalc.Name = "btnBitCalc";
      this.btnBitCalc.Size = new System.Drawing.Size(18, 23);
      this.btnBitCalc.TabIndex = 26;
      this.btnBitCalc.Text = "B";
      this.btnBitCalc.UseVisualStyleBackColor = true;
      this.btnBitCalc.Click += new System.EventHandler(this.btnBitCalc_Click);
      // 
      // btnVectorCalc
      // 
      this.btnVectorCalc.Location = new System.Drawing.Point(60, 96);
      this.btnVectorCalc.Name = "btnVectorCalc";
      this.btnVectorCalc.Size = new System.Drawing.Size(18, 23);
      this.btnVectorCalc.TabIndex = 27;
      this.btnVectorCalc.Text = "V";
      this.btnVectorCalc.UseVisualStyleBackColor = true;
      this.btnVectorCalc.Click += new System.EventHandler(this.btnVectorCalc_Click);
      // 
      // DCalc
      // 
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
      this.ClientSize = new System.Drawing.Size(517, 131);
      this.Controls.Add(this.btnVectorCalc);
      this.Controls.Add(this.btnBitCalc);
      this.Controls.Add(this.btnMatrixCalc);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.cbDegRad);
      this.Controls.Add(this.cbCalcMode);
      this.Controls.Add(this.btnClear);
      this.Controls.Add(this.btnSwap);
      this.Controls.Add(this.btnDrop);
      this.Controls.Add(this.txtPostfix);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtInfix);
      this.Controls.Add(this.label2);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "DCalc";
      this.Load += new System.EventHandler(this.DCalc_Load);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.contextMenuStrip1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtInfix;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtPostfix;
    private System.Windows.Forms.Button btnDrop;
    private System.Windows.Forms.Button btnSwap;
    private System.Windows.Forms.Button btnClear;
    private System.Windows.Forms.CheckBox cbCalcMode;
    private System.Windows.Forms.ComboBox cbDegRad;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label labelT;
    private System.Windows.Forms.Label labelZ;
    private System.Windows.Forms.Label labelY;
    private System.Windows.Forms.Label labelX;
    private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem showStackToolStripMenuItem;
    private System.Windows.Forms.Button btnMatrixCalc;
    private System.Windows.Forms.Button btnBitCalc;
    private System.Windows.Forms.Button btnVectorCalc;
  }
}

