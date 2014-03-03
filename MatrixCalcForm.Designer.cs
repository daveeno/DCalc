namespace DCalc
{
  partial class MatrixCalcForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MatrixCalcForm));
      this.rtbMatrixA = new System.Windows.Forms.RichTextBox();
      this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.inverseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.transformToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.dETToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.rREFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.vectorCalcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.labelX = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.dropToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.swapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.clearStackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.label2 = new System.Windows.Forms.Label();
      this.contextMenuStrip1.SuspendLayout();
      this.contextMenuStrip2.SuspendLayout();
      this.SuspendLayout();
      // 
      // rtbMatrixA
      // 
      this.rtbMatrixA.ContextMenuStrip = this.contextMenuStrip1;
      this.rtbMatrixA.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.rtbMatrixA.Location = new System.Drawing.Point(13, 487);
      this.rtbMatrixA.Name = "rtbMatrixA";
      this.rtbMatrixA.Size = new System.Drawing.Size(373, 158);
      this.rtbMatrixA.TabIndex = 0;
      this.rtbMatrixA.Text = "";
      this.rtbMatrixA.WordWrap = false;
      this.rtbMatrixA.KeyUp += new System.Windows.Forms.KeyEventHandler(this.rtbMatrixA_KeyUp);
      // 
      // contextMenuStrip1
      // 
      this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inverseToolStripMenuItem,
            this.transformToolStripMenuItem,
            this.dETToolStripMenuItem,
            this.rREFToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.vectorCalcToolStripMenuItem});
      this.contextMenuStrip1.Name = "contextMenuStrip1";
      this.contextMenuStrip1.Size = new System.Drawing.Size(144, 136);
      // 
      // inverseToolStripMenuItem
      // 
      this.inverseToolStripMenuItem.Name = "inverseToolStripMenuItem";
      this.inverseToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
      this.inverseToolStripMenuItem.Text = "Inverse";
      this.inverseToolStripMenuItem.Click += new System.EventHandler(this.inverseToolStripMenuItem_Click);
      // 
      // transformToolStripMenuItem
      // 
      this.transformToolStripMenuItem.Name = "transformToolStripMenuItem";
      this.transformToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
      this.transformToolStripMenuItem.Text = "Transpose";
      this.transformToolStripMenuItem.Click += new System.EventHandler(this.transformToolStripMenuItem_Click);
      // 
      // dETToolStripMenuItem
      // 
      this.dETToolStripMenuItem.Name = "dETToolStripMenuItem";
      this.dETToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
      this.dETToolStripMenuItem.Text = "DET";
      this.dETToolStripMenuItem.Click += new System.EventHandler(this.dETToolStripMenuItem_Click);
      // 
      // rREFToolStripMenuItem
      // 
      this.rREFToolStripMenuItem.Name = "rREFToolStripMenuItem";
      this.rREFToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
      this.rREFToolStripMenuItem.Text = "RREF";
      this.rREFToolStripMenuItem.Click += new System.EventHandler(this.rREFToolStripMenuItem_Click);
      // 
      // clearToolStripMenuItem
      // 
      this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
      this.clearToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
      this.clearToolStripMenuItem.Text = "Clear";
      this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
      // 
      // vectorCalcToolStripMenuItem
      // 
      this.vectorCalcToolStripMenuItem.Name = "vectorCalcToolStripMenuItem";
      this.vectorCalcToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
      this.vectorCalcToolStripMenuItem.Text = "Vector Calc...";
      this.vectorCalcToolStripMenuItem.Click += new System.EventHandler(this.vectorCalcToolStripMenuItem_Click);
      // 
      // labelX
      // 
      this.labelX.AutoSize = true;
      this.labelX.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelX.ForeColor = System.Drawing.Color.White;
      this.labelX.Location = new System.Drawing.Point(466, 488);
      this.labelX.Name = "labelX";
      this.labelX.Size = new System.Drawing.Size(28, 18);
      this.labelX.TabIndex = 19;
      this.labelX.Text = "A:";
      this.labelX.Visible = false;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label7.ForeColor = System.Drawing.Color.White;
      this.label7.Location = new System.Drawing.Point(466, 313);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(28, 18);
      this.label7.TabIndex = 20;
      this.label7.Text = "B:";
      this.label7.Visible = false;
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label8.ForeColor = System.Drawing.Color.White;
      this.label8.Location = new System.Drawing.Point(466, 138);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(28, 18);
      this.label8.TabIndex = 21;
      this.label8.Text = "C:";
      this.label8.Visible = false;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.Color.White;
      this.label1.Location = new System.Drawing.Point(12, 466);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(288, 18);
      this.label1.TabIndex = 22;
      this.label1.Text = "Input (Ctrl-Enter to accept)";
      // 
      // contextMenuStrip2
      // 
      this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dropToolStripMenuItem,
            this.swapToolStripMenuItem,
            this.clearStackToolStripMenuItem});
      this.contextMenuStrip2.Name = "contextMenuStrip1";
      this.contextMenuStrip2.Size = new System.Drawing.Size(133, 70);
      // 
      // dropToolStripMenuItem
      // 
      this.dropToolStripMenuItem.Name = "dropToolStripMenuItem";
      this.dropToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
      this.dropToolStripMenuItem.Text = "Drop";
      this.dropToolStripMenuItem.Click += new System.EventHandler(this.dropToolStripMenuItem_Click);
      // 
      // swapToolStripMenuItem
      // 
      this.swapToolStripMenuItem.Name = "swapToolStripMenuItem";
      this.swapToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
      this.swapToolStripMenuItem.Text = "Swap";
      this.swapToolStripMenuItem.Click += new System.EventHandler(this.swapToolStripMenuItem_Click);
      // 
      // clearStackToolStripMenuItem
      // 
      this.clearStackToolStripMenuItem.Name = "clearStackToolStripMenuItem";
      this.clearStackToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
      this.clearStackToolStripMenuItem.Text = "Clear Stack";
      this.clearStackToolStripMenuItem.Click += new System.EventHandler(this.clearStackToolStripMenuItem_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.ForeColor = System.Drawing.Color.White;
      this.label2.Location = new System.Drawing.Point(10, 9);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(418, 180);
      this.label2.TabIndex = 23;
      this.label2.Text = resources.GetString("label2.Text");
      // 
      // MatrixCalcForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
      this.ClientSize = new System.Drawing.Size(901, 661);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.labelX);
      this.Controls.Add(this.rtbMatrixA);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "MatrixCalcForm";
      this.Text = "Matrices";
      this.contextMenuStrip1.ResumeLayout(false);
      this.contextMenuStrip2.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.RichTextBox rtbMatrixA;
    private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    private System.Windows.Forms.ToolStripMenuItem vectorCalcToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem inverseToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem transformToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem dETToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem rREFToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
    private System.Windows.Forms.Label labelX;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ToolStripMenuItem dropToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem swapToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem clearStackToolStripMenuItem;
  }
}