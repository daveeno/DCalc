namespace DCalc
{
  partial class VectorForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VectorForm));
      this.rtbV1 = new System.Windows.Forms.RichTextBox();
      this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.normalizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.scalarMultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.pushToCalculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.sendToMatrixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.rtbV2 = new System.Windows.Forms.RichTextBox();
      this.rtbVx = new System.Windows.Forms.RichTextBox();
      this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
      this.rotateAboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
      this.btnPlus = new System.Windows.Forms.Button();
      this.btnMinus = new System.Windows.Forms.Button();
      this.btnDotP = new System.Windows.Forms.Button();
      this.btnCrossP = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.rtbNormU = new System.Windows.Forms.RichTextBox();
      this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.pushToCalculatorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.rtbNormV = new System.Windows.Forms.RichTextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.rtbNormW = new System.Windows.Forms.RichTextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.rtbUVAngle = new System.Windows.Forms.RichTextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.btnUpdate1 = new System.Windows.Forms.Button();
      this.label8 = new System.Windows.Forms.Label();
      this.rtbAlphaU = new System.Windows.Forms.RichTextBox();
      this.rtbBetaU = new System.Windows.Forms.RichTextBox();
      this.rtbGammaU = new System.Windows.Forms.RichTextBox();
      this.rtbGammaV = new System.Windows.Forms.RichTextBox();
      this.rtbBetaV = new System.Windows.Forms.RichTextBox();
      this.rtbAlphaV = new System.Windows.Forms.RichTextBox();
      this.rtbGammaW = new System.Windows.Forms.RichTextBox();
      this.rtbBetaW = new System.Windows.Forms.RichTextBox();
      this.rtbAlphaW = new System.Windows.Forms.RichTextBox();
      this.contextMenuStrip1.SuspendLayout();
      this.contextMenuStrip3.SuspendLayout();
      this.contextMenuStrip2.SuspendLayout();
      this.SuspendLayout();
      // 
      // rtbV1
      // 
      this.rtbV1.ContextMenuStrip = this.contextMenuStrip1;
      this.rtbV1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.rtbV1.Location = new System.Drawing.Point(12, 288);
      this.rtbV1.Name = "rtbV1";
      this.rtbV1.Size = new System.Drawing.Size(177, 245);
      this.rtbV1.TabIndex = 0;
      this.rtbV1.Text = "";
      // 
      // contextMenuStrip1
      // 
      this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.normalizeToolStripMenuItem,
            this.scalarMultToolStripMenuItem,
            this.pushToCalculatorToolStripMenuItem,
            this.sendToMatrixToolStripMenuItem});
      this.contextMenuStrip1.Name = "contextMenuStrip1";
      this.contextMenuStrip1.Size = new System.Drawing.Size(172, 92);
      // 
      // normalizeToolStripMenuItem
      // 
      this.normalizeToolStripMenuItem.Name = "normalizeToolStripMenuItem";
      this.normalizeToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
      this.normalizeToolStripMenuItem.Text = "Normalize";
      this.normalizeToolStripMenuItem.Click += new System.EventHandler(this.normalizeToolStripMenuItem_Click);
      // 
      // scalarMultToolStripMenuItem
      // 
      this.scalarMultToolStripMenuItem.Name = "scalarMultToolStripMenuItem";
      this.scalarMultToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
      this.scalarMultToolStripMenuItem.Text = "Scalar Mult...";
      this.scalarMultToolStripMenuItem.Click += new System.EventHandler(this.scalarMultToolStripMenuItem_Click);
      // 
      // pushToCalculatorToolStripMenuItem
      // 
      this.pushToCalculatorToolStripMenuItem.Enabled = false;
      this.pushToCalculatorToolStripMenuItem.Name = "pushToCalculatorToolStripMenuItem";
      this.pushToCalculatorToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
      this.pushToCalculatorToolStripMenuItem.Text = "Push to Calculator";
      this.pushToCalculatorToolStripMenuItem.Click += new System.EventHandler(this.pushToCalculatorToolStripMenuItem_Click);
      // 
      // sendToMatrixToolStripMenuItem
      // 
      this.sendToMatrixToolStripMenuItem.Enabled = false;
      this.sendToMatrixToolStripMenuItem.Name = "sendToMatrixToolStripMenuItem";
      this.sendToMatrixToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
      this.sendToMatrixToolStripMenuItem.Text = "Send to Matrix";
      this.sendToMatrixToolStripMenuItem.Click += new System.EventHandler(this.sendToMatrixToolStripMenuItem_Click);
      // 
      // rtbV2
      // 
      this.rtbV2.ContextMenuStrip = this.contextMenuStrip1;
      this.rtbV2.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.rtbV2.Location = new System.Drawing.Point(276, 288);
      this.rtbV2.Name = "rtbV2";
      this.rtbV2.Size = new System.Drawing.Size(177, 245);
      this.rtbV2.TabIndex = 1;
      this.rtbV2.Text = "";
      // 
      // rtbVx
      // 
      this.rtbVx.ContextMenuStrip = this.contextMenuStrip3;
      this.rtbVx.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.rtbVx.Location = new System.Drawing.Point(459, 288);
      this.rtbVx.Name = "rtbVx";
      this.rtbVx.Size = new System.Drawing.Size(276, 245);
      this.rtbVx.TabIndex = 2;
      this.rtbVx.Text = "";
      // 
      // contextMenuStrip3
      // 
      this.contextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.rotateAboutToolStripMenuItem,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
      this.contextMenuStrip3.Name = "contextMenuStrip1";
      this.contextMenuStrip3.Size = new System.Drawing.Size(172, 114);
      // 
      // toolStripMenuItem1
      // 
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new System.Drawing.Size(171, 22);
      this.toolStripMenuItem1.Text = "Normalize";
      this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
      // 
      // toolStripMenuItem2
      // 
      this.toolStripMenuItem2.Name = "toolStripMenuItem2";
      this.toolStripMenuItem2.Size = new System.Drawing.Size(171, 22);
      this.toolStripMenuItem2.Text = "Scalar Mult...";
      this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
      // 
      // rotateAboutToolStripMenuItem
      // 
      this.rotateAboutToolStripMenuItem.Name = "rotateAboutToolStripMenuItem";
      this.rotateAboutToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
      this.rotateAboutToolStripMenuItem.Text = "Rotate About";
      this.rotateAboutToolStripMenuItem.Click += new System.EventHandler(this.rotateAboutToolStripMenuItem_Click);
      // 
      // toolStripMenuItem3
      // 
      this.toolStripMenuItem3.Enabled = false;
      this.toolStripMenuItem3.Name = "toolStripMenuItem3";
      this.toolStripMenuItem3.Size = new System.Drawing.Size(171, 22);
      this.toolStripMenuItem3.Text = "Push to Calculator";
      this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
      // 
      // toolStripMenuItem4
      // 
      this.toolStripMenuItem4.Enabled = false;
      this.toolStripMenuItem4.Name = "toolStripMenuItem4";
      this.toolStripMenuItem4.Size = new System.Drawing.Size(171, 22);
      this.toolStripMenuItem4.Text = "Send to Matrix";
      this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
      // 
      // btnPlus
      // 
      this.btnPlus.Location = new System.Drawing.Point(195, 311);
      this.btnPlus.Name = "btnPlus";
      this.btnPlus.Size = new System.Drawing.Size(75, 23);
      this.btnPlus.TabIndex = 3;
      this.btnPlus.Text = "+";
      this.btnPlus.UseVisualStyleBackColor = true;
      this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
      // 
      // btnMinus
      // 
      this.btnMinus.Location = new System.Drawing.Point(195, 340);
      this.btnMinus.Name = "btnMinus";
      this.btnMinus.Size = new System.Drawing.Size(75, 23);
      this.btnMinus.TabIndex = 4;
      this.btnMinus.Text = "-";
      this.btnMinus.UseVisualStyleBackColor = true;
      this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
      // 
      // btnDotP
      // 
      this.btnDotP.Location = new System.Drawing.Point(195, 369);
      this.btnDotP.Name = "btnDotP";
      this.btnDotP.Size = new System.Drawing.Size(75, 23);
      this.btnDotP.TabIndex = 6;
      this.btnDotP.Text = "Dot";
      this.btnDotP.UseVisualStyleBackColor = true;
      this.btnDotP.Click += new System.EventHandler(this.btnDotP_Click);
      // 
      // btnCrossP
      // 
      this.btnCrossP.Location = new System.Drawing.Point(195, 398);
      this.btnCrossP.Name = "btnCrossP";
      this.btnCrossP.Size = new System.Drawing.Size(75, 23);
      this.btnCrossP.TabIndex = 7;
      this.btnCrossP.Text = "Cross";
      this.btnCrossP.UseVisualStyleBackColor = true;
      this.btnCrossP.Click += new System.EventHandler(this.btnCrossP_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(12, 269);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(16, 16);
      this.label1.TabIndex = 8;
      this.label1.Text = "u";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(273, 269);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(16, 16);
      this.label2.TabIndex = 9;
      this.label2.Text = "v";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(456, 269);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(16, 16);
      this.label3.TabIndex = 10;
      this.label3.Text = "w";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(9, 167);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(48, 16);
      this.label4.TabIndex = 11;
      this.label4.Text = "||u||";
      // 
      // rtbNormU
      // 
      this.rtbNormU.ContextMenuStrip = this.contextMenuStrip2;
      this.rtbNormU.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.rtbNormU.Location = new System.Drawing.Point(12, 186);
      this.rtbNormU.Name = "rtbNormU";
      this.rtbNormU.Size = new System.Drawing.Size(177, 21);
      this.rtbNormU.TabIndex = 12;
      this.rtbNormU.Text = "";
      // 
      // contextMenuStrip2
      // 
      this.contextMenuStrip2.Enabled = false;
      this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pushToCalculatorToolStripMenuItem1});
      this.contextMenuStrip2.Name = "contextMenuStrip2";
      this.contextMenuStrip2.Size = new System.Drawing.Size(172, 26);
      // 
      // pushToCalculatorToolStripMenuItem1
      // 
      this.pushToCalculatorToolStripMenuItem1.Enabled = false;
      this.pushToCalculatorToolStripMenuItem1.Name = "pushToCalculatorToolStripMenuItem1";
      this.pushToCalculatorToolStripMenuItem1.Size = new System.Drawing.Size(171, 22);
      this.pushToCalculatorToolStripMenuItem1.Text = "Push to Calculator";
      this.pushToCalculatorToolStripMenuItem1.Click += new System.EventHandler(this.pushToCalculatorToolStripMenuItem1_Click);
      // 
      // rtbNormV
      // 
      this.rtbNormV.ContextMenuStrip = this.contextMenuStrip2;
      this.rtbNormV.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.rtbNormV.Location = new System.Drawing.Point(276, 186);
      this.rtbNormV.Name = "rtbNormV";
      this.rtbNormV.Size = new System.Drawing.Size(177, 21);
      this.rtbNormV.TabIndex = 14;
      this.rtbNormV.Text = "";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(273, 167);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(48, 16);
      this.label5.TabIndex = 13;
      this.label5.Text = "||v||";
      // 
      // rtbNormW
      // 
      this.rtbNormW.ContextMenuStrip = this.contextMenuStrip2;
      this.rtbNormW.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.rtbNormW.Location = new System.Drawing.Point(459, 186);
      this.rtbNormW.Name = "rtbNormW";
      this.rtbNormW.Size = new System.Drawing.Size(276, 21);
      this.rtbNormW.TabIndex = 16;
      this.rtbNormW.Text = "";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.Location = new System.Drawing.Point(456, 167);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(48, 16);
      this.label6.TabIndex = 15;
      this.label6.Text = "||w||";
      // 
      // rtbUVAngle
      // 
      this.rtbUVAngle.ContextMenuStrip = this.contextMenuStrip2;
      this.rtbUVAngle.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.rtbUVAngle.Location = new System.Drawing.Point(144, 234);
      this.rtbUVAngle.Name = "rtbUVAngle";
      this.rtbUVAngle.Size = new System.Drawing.Size(177, 21);
      this.rtbUVAngle.TabIndex = 18;
      this.rtbUVAngle.Text = "";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label7.Location = new System.Drawing.Point(141, 215);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(112, 16);
      this.label7.TabIndex = 17;
      this.label7.Text = "Angle Between";
      // 
      // btnUpdate1
      // 
      this.btnUpdate1.Location = new System.Drawing.Point(12, 232);
      this.btnUpdate1.Name = "btnUpdate1";
      this.btnUpdate1.Size = new System.Drawing.Size(100, 23);
      this.btnUpdate1.TabIndex = 19;
      this.btnUpdate1.Text = "Update";
      this.btnUpdate1.UseVisualStyleBackColor = true;
      this.btnUpdate1.Click += new System.EventHandler(this.btnUpdate1_Click);
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label8.Location = new System.Drawing.Point(327, 237);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(64, 16);
      this.label8.TabIndex = 20;
      this.label8.Text = "Degrees";
      // 
      // rtbAlphaU
      // 
      this.rtbAlphaU.ContextMenuStrip = this.contextMenuStrip2;
      this.rtbAlphaU.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.rtbAlphaU.Location = new System.Drawing.Point(12, 63);
      this.rtbAlphaU.Name = "rtbAlphaU";
      this.rtbAlphaU.Size = new System.Drawing.Size(177, 21);
      this.rtbAlphaU.TabIndex = 22;
      this.rtbAlphaU.Text = "";
      // 
      // rtbBetaU
      // 
      this.rtbBetaU.ContextMenuStrip = this.contextMenuStrip2;
      this.rtbBetaU.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.rtbBetaU.Location = new System.Drawing.Point(12, 90);
      this.rtbBetaU.Name = "rtbBetaU";
      this.rtbBetaU.Size = new System.Drawing.Size(177, 21);
      this.rtbBetaU.TabIndex = 23;
      this.rtbBetaU.Text = "";
      // 
      // rtbGammaU
      // 
      this.rtbGammaU.ContextMenuStrip = this.contextMenuStrip2;
      this.rtbGammaU.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.rtbGammaU.Location = new System.Drawing.Point(12, 117);
      this.rtbGammaU.Name = "rtbGammaU";
      this.rtbGammaU.Size = new System.Drawing.Size(177, 21);
      this.rtbGammaU.TabIndex = 24;
      this.rtbGammaU.Text = "";
      // 
      // rtbGammaV
      // 
      this.rtbGammaV.ContextMenuStrip = this.contextMenuStrip2;
      this.rtbGammaV.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.rtbGammaV.Location = new System.Drawing.Point(276, 117);
      this.rtbGammaV.Name = "rtbGammaV";
      this.rtbGammaV.Size = new System.Drawing.Size(177, 21);
      this.rtbGammaV.TabIndex = 27;
      this.rtbGammaV.Text = "";
      // 
      // rtbBetaV
      // 
      this.rtbBetaV.ContextMenuStrip = this.contextMenuStrip2;
      this.rtbBetaV.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.rtbBetaV.Location = new System.Drawing.Point(276, 90);
      this.rtbBetaV.Name = "rtbBetaV";
      this.rtbBetaV.Size = new System.Drawing.Size(177, 21);
      this.rtbBetaV.TabIndex = 26;
      this.rtbBetaV.Text = "";
      // 
      // rtbAlphaV
      // 
      this.rtbAlphaV.ContextMenuStrip = this.contextMenuStrip2;
      this.rtbAlphaV.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.rtbAlphaV.Location = new System.Drawing.Point(276, 63);
      this.rtbAlphaV.Name = "rtbAlphaV";
      this.rtbAlphaV.Size = new System.Drawing.Size(177, 21);
      this.rtbAlphaV.TabIndex = 25;
      this.rtbAlphaV.Text = "";
      // 
      // rtbGammaW
      // 
      this.rtbGammaW.ContextMenuStrip = this.contextMenuStrip2;
      this.rtbGammaW.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.rtbGammaW.Location = new System.Drawing.Point(459, 117);
      this.rtbGammaW.Name = "rtbGammaW";
      this.rtbGammaW.Size = new System.Drawing.Size(276, 21);
      this.rtbGammaW.TabIndex = 30;
      this.rtbGammaW.Text = "";
      // 
      // rtbBetaW
      // 
      this.rtbBetaW.ContextMenuStrip = this.contextMenuStrip2;
      this.rtbBetaW.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.rtbBetaW.Location = new System.Drawing.Point(459, 90);
      this.rtbBetaW.Name = "rtbBetaW";
      this.rtbBetaW.Size = new System.Drawing.Size(276, 21);
      this.rtbBetaW.TabIndex = 29;
      this.rtbBetaW.Text = "";
      // 
      // rtbAlphaW
      // 
      this.rtbAlphaW.ContextMenuStrip = this.contextMenuStrip2;
      this.rtbAlphaW.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.rtbAlphaW.Location = new System.Drawing.Point(459, 63);
      this.rtbAlphaW.Name = "rtbAlphaW";
      this.rtbAlphaW.Size = new System.Drawing.Size(276, 21);
      this.rtbAlphaW.TabIndex = 28;
      this.rtbAlphaW.Text = "";
      // 
      // VectorForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(747, 544);
      this.Controls.Add(this.rtbGammaW);
      this.Controls.Add(this.rtbBetaW);
      this.Controls.Add(this.rtbAlphaW);
      this.Controls.Add(this.rtbGammaV);
      this.Controls.Add(this.rtbBetaV);
      this.Controls.Add(this.rtbAlphaV);
      this.Controls.Add(this.rtbGammaU);
      this.Controls.Add(this.rtbBetaU);
      this.Controls.Add(this.rtbAlphaU);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.btnUpdate1);
      this.Controls.Add(this.rtbUVAngle);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.rtbNormW);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.rtbNormV);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.rtbNormU);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnCrossP);
      this.Controls.Add(this.btnDotP);
      this.Controls.Add(this.btnMinus);
      this.Controls.Add(this.btnPlus);
      this.Controls.Add(this.rtbVx);
      this.Controls.Add(this.rtbV2);
      this.Controls.Add(this.rtbV1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "VectorForm";
      this.Text = "Vector Calc";
      this.Load += new System.EventHandler(this.VectorForm_Load);
      this.contextMenuStrip1.ResumeLayout(false);
      this.contextMenuStrip3.ResumeLayout(false);
      this.contextMenuStrip2.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.RichTextBox rtbV1;
    private System.Windows.Forms.RichTextBox rtbV2;
    private System.Windows.Forms.RichTextBox rtbVx;
    private System.Windows.Forms.Button btnPlus;
    private System.Windows.Forms.Button btnMinus;
    private System.Windows.Forms.Button btnDotP;
    private System.Windows.Forms.Button btnCrossP;
    private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    private System.Windows.Forms.ToolStripMenuItem normalizeToolStripMenuItem;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.RichTextBox rtbNormU;
    private System.Windows.Forms.RichTextBox rtbNormV;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.RichTextBox rtbNormW;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.RichTextBox rtbUVAngle;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Button btnUpdate1;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.ToolStripMenuItem scalarMultToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem pushToCalculatorToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem sendToMatrixToolStripMenuItem;
    private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
    private System.Windows.Forms.ToolStripMenuItem pushToCalculatorToolStripMenuItem1;
    private System.Windows.Forms.RichTextBox rtbAlphaU;
    private System.Windows.Forms.RichTextBox rtbBetaU;
    private System.Windows.Forms.RichTextBox rtbGammaU;
    private System.Windows.Forms.RichTextBox rtbGammaV;
    private System.Windows.Forms.RichTextBox rtbBetaV;
    private System.Windows.Forms.RichTextBox rtbAlphaV;
    private System.Windows.Forms.RichTextBox rtbGammaW;
    private System.Windows.Forms.RichTextBox rtbBetaW;
    private System.Windows.Forms.RichTextBox rtbAlphaW;
    private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    private System.Windows.Forms.ToolStripMenuItem rotateAboutToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
  }
}