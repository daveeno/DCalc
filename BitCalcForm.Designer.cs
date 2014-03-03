namespace DCalc
{
  partial class BitCalcForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BitCalcForm));
      this.btnAnd = new System.Windows.Forms.Button();
      this.btnOr = new System.Windows.Forms.Button();
      this.btnXor = new System.Windows.Forms.Button();
      this.btnNot1 = new System.Windows.Forms.Button();
      this.txtBin1 = new System.Windows.Forms.TextBox();
      this.txtBin2 = new System.Windows.Forms.TextBox();
      this.txtDec1 = new System.Windows.Forms.TextBox();
      this.txtDec2 = new System.Windows.Forms.TextBox();
      this.lblBinAns = new System.Windows.Forms.Label();
      this.lblDecAns = new System.Windows.Forms.Label();
      this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.pushToStackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.btnNot2 = new System.Windows.Forms.Button();
      this.btnLShift2 = new System.Windows.Forms.Button();
      this.btnLShift1 = new System.Windows.Forms.Button();
      this.btnRShift2 = new System.Windows.Forms.Button();
      this.btnRShift1 = new System.Windows.Forms.Button();
      this.contextMenuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnAnd
      // 
      this.btnAnd.Location = new System.Drawing.Point(299, 86);
      this.btnAnd.Name = "btnAnd";
      this.btnAnd.Size = new System.Drawing.Size(45, 30);
      this.btnAnd.TabIndex = 3;
      this.btnAnd.Text = "AND";
      this.btnAnd.UseVisualStyleBackColor = true;
      this.btnAnd.Click += new System.EventHandler(this.btnAnd_Click);
      // 
      // btnOr
      // 
      this.btnOr.Location = new System.Drawing.Point(350, 86);
      this.btnOr.Name = "btnOr";
      this.btnOr.Size = new System.Drawing.Size(45, 30);
      this.btnOr.TabIndex = 4;
      this.btnOr.Text = "OR";
      this.btnOr.UseVisualStyleBackColor = true;
      this.btnOr.Click += new System.EventHandler(this.btnOr_Click);
      // 
      // btnXor
      // 
      this.btnXor.Location = new System.Drawing.Point(401, 86);
      this.btnXor.Name = "btnXor";
      this.btnXor.Size = new System.Drawing.Size(45, 30);
      this.btnXor.TabIndex = 5;
      this.btnXor.Text = "XOR";
      this.btnXor.UseVisualStyleBackColor = true;
      this.btnXor.Click += new System.EventHandler(this.btnXor_Click);
      // 
      // btnNot1
      // 
      this.btnNot1.Location = new System.Drawing.Point(46, 13);
      this.btnNot1.Name = "btnNot1";
      this.btnNot1.Size = new System.Drawing.Size(45, 26);
      this.btnNot1.TabIndex = 6;
      this.btnNot1.Text = "NOT";
      this.btnNot1.UseVisualStyleBackColor = true;
      this.btnNot1.Click += new System.EventHandler(this.btnNot1_Click);
      // 
      // txtBin1
      // 
      this.txtBin1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtBin1.Location = new System.Drawing.Point(131, 13);
      this.txtBin1.Name = "txtBin1";
      this.txtBin1.Size = new System.Drawing.Size(315, 26);
      this.txtBin1.TabIndex = 7;
      this.txtBin1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.txtBin1.TextChanged += new System.EventHandler(this.txtBin1_TextChanged);
      this.txtBin1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBin1_KeyPress);
      this.txtBin1.Leave += new System.EventHandler(this.txtBin1_Leave);
      // 
      // txtBin2
      // 
      this.txtBin2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtBin2.Location = new System.Drawing.Point(131, 45);
      this.txtBin2.Name = "txtBin2";
      this.txtBin2.Size = new System.Drawing.Size(315, 26);
      this.txtBin2.TabIndex = 8;
      this.txtBin2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.txtBin2.TextChanged += new System.EventHandler(this.txtBin2_TextChanged);
      this.txtBin2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBin2_KeyPress);
      this.txtBin2.Leave += new System.EventHandler(this.txtBin2_Leave);
      // 
      // txtDec1
      // 
      this.txtDec1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtDec1.Location = new System.Drawing.Point(452, 13);
      this.txtDec1.Name = "txtDec1";
      this.txtDec1.Size = new System.Drawing.Size(94, 26);
      this.txtDec1.TabIndex = 10;
      this.txtDec1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.txtDec1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDec1_KeyPress);
      this.txtDec1.Leave += new System.EventHandler(this.txtDec1_Leave);
      // 
      // txtDec2
      // 
      this.txtDec2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtDec2.Location = new System.Drawing.Point(452, 45);
      this.txtDec2.Name = "txtDec2";
      this.txtDec2.Size = new System.Drawing.Size(94, 26);
      this.txtDec2.TabIndex = 11;
      this.txtDec2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
      this.txtDec2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDec2_KeyPress);
      this.txtDec2.Leave += new System.EventHandler(this.txtDec2_Leave);
      // 
      // lblBinAns
      // 
      this.lblBinAns.BackColor = System.Drawing.Color.White;
      this.lblBinAns.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblBinAns.Location = new System.Drawing.Point(13, 129);
      this.lblBinAns.Name = "lblBinAns";
      this.lblBinAns.Size = new System.Drawing.Size(433, 26);
      this.lblBinAns.TabIndex = 12;
      this.lblBinAns.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.lblBinAns.TextChanged += new System.EventHandler(this.label1_TextChanged);
      // 
      // lblDecAns
      // 
      this.lblDecAns.BackColor = System.Drawing.Color.White;
      this.lblDecAns.ContextMenuStrip = this.contextMenuStrip1;
      this.lblDecAns.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblDecAns.Location = new System.Drawing.Point(452, 129);
      this.lblDecAns.Name = "lblDecAns";
      this.lblDecAns.Size = new System.Drawing.Size(94, 26);
      this.lblDecAns.TabIndex = 13;
      this.lblDecAns.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // contextMenuStrip1
      // 
      this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pushToStackToolStripMenuItem});
      this.contextMenuStrip1.Name = "contextMenuStrip1";
      this.contextMenuStrip1.Size = new System.Drawing.Size(145, 26);
      // 
      // pushToStackToolStripMenuItem
      // 
      this.pushToStackToolStripMenuItem.Name = "pushToStackToolStripMenuItem";
      this.pushToStackToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
      this.pushToStackToolStripMenuItem.Text = "Push to stack";
      this.pushToStackToolStripMenuItem.Click += new System.EventHandler(this.pushToStackToolStripMenuItem_Click);
      // 
      // btnNot2
      // 
      this.btnNot2.Location = new System.Drawing.Point(46, 45);
      this.btnNot2.Name = "btnNot2";
      this.btnNot2.Size = new System.Drawing.Size(45, 26);
      this.btnNot2.TabIndex = 14;
      this.btnNot2.Text = "NOT";
      this.btnNot2.UseVisualStyleBackColor = true;
      this.btnNot2.Click += new System.EventHandler(this.btnNot2_Click);
      // 
      // btnLShift2
      // 
      this.btnLShift2.Location = new System.Drawing.Point(12, 45);
      this.btnLShift2.Name = "btnLShift2";
      this.btnLShift2.Size = new System.Drawing.Size(28, 26);
      this.btnLShift2.TabIndex = 16;
      this.btnLShift2.Text = "<<";
      this.btnLShift2.UseVisualStyleBackColor = true;
      this.btnLShift2.Click += new System.EventHandler(this.btnLShift2_Click);
      // 
      // btnLShift1
      // 
      this.btnLShift1.Location = new System.Drawing.Point(12, 13);
      this.btnLShift1.Name = "btnLShift1";
      this.btnLShift1.Size = new System.Drawing.Size(28, 26);
      this.btnLShift1.TabIndex = 15;
      this.btnLShift1.Text = "<<";
      this.btnLShift1.UseVisualStyleBackColor = true;
      this.btnLShift1.Click += new System.EventHandler(this.btnLShift1_Click);
      // 
      // btnRShift2
      // 
      this.btnRShift2.Location = new System.Drawing.Point(97, 45);
      this.btnRShift2.Name = "btnRShift2";
      this.btnRShift2.Size = new System.Drawing.Size(28, 26);
      this.btnRShift2.TabIndex = 18;
      this.btnRShift2.Text = ">>";
      this.btnRShift2.UseVisualStyleBackColor = true;
      this.btnRShift2.Click += new System.EventHandler(this.btnRShift2_Click);
      // 
      // btnRShift1
      // 
      this.btnRShift1.Location = new System.Drawing.Point(97, 13);
      this.btnRShift1.Name = "btnRShift1";
      this.btnRShift1.Size = new System.Drawing.Size(28, 26);
      this.btnRShift1.TabIndex = 17;
      this.btnRShift1.Text = ">>";
      this.btnRShift1.UseVisualStyleBackColor = true;
      this.btnRShift1.Click += new System.EventHandler(this.btnRShift1_Click);
      // 
      // BitCalcForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(558, 172);
      this.Controls.Add(this.btnRShift2);
      this.Controls.Add(this.btnRShift1);
      this.Controls.Add(this.btnLShift2);
      this.Controls.Add(this.btnLShift1);
      this.Controls.Add(this.btnNot2);
      this.Controls.Add(this.lblDecAns);
      this.Controls.Add(this.lblBinAns);
      this.Controls.Add(this.txtDec2);
      this.Controls.Add(this.txtDec1);
      this.Controls.Add(this.txtBin2);
      this.Controls.Add(this.txtBin1);
      this.Controls.Add(this.btnNot1);
      this.Controls.Add(this.btnXor);
      this.Controls.Add(this.btnOr);
      this.Controls.Add(this.btnAnd);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "BitCalcForm";
      this.Text = "Bit Calc";
      this.Load += new System.EventHandler(this.BitCalcForm_Load);
      this.contextMenuStrip1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnAnd;
    private System.Windows.Forms.Button btnOr;
    private System.Windows.Forms.Button btnXor;
    private System.Windows.Forms.Button btnNot1;
    private System.Windows.Forms.TextBox txtBin1;
    private System.Windows.Forms.TextBox txtBin2;
    private System.Windows.Forms.TextBox txtDec1;
    private System.Windows.Forms.TextBox txtDec2;
    private System.Windows.Forms.Label lblBinAns;
    private System.Windows.Forms.Button btnNot2;
    private System.Windows.Forms.Button btnLShift2;
    private System.Windows.Forms.Button btnLShift1;
    private System.Windows.Forms.Button btnRShift2;
    private System.Windows.Forms.Button btnRShift1;
    private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    private System.Windows.Forms.ToolStripMenuItem pushToStackToolStripMenuItem;
    public System.Windows.Forms.Label lblDecAns;
  }
}