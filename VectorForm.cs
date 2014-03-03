using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MatVec;

namespace DCalc
{
  public partial class VectorForm : Form
  {
    Vector V1, V2, Vx;
    private DCalc dc_parent;
    private MatrixCalcForm mcf_parent;
    string mcf_target;

    public VectorForm()
    {
      InitializeComponent();
    }

    public VectorForm(DCalc dc1)
    {
      InitializeComponent();
      dc_parent = dc1;
      contextMenuStrip1.Items[2].Enabled = true;
      contextMenuStrip3.Items[3].Enabled = true;
      contextMenuStrip2.Enabled = true;
      contextMenuStrip2.Items[0].Enabled = true;
    }

    public VectorForm(MatrixCalcForm mcf1, string sourseCtrlName)
    {
      InitializeComponent();
      mcf_parent = mcf1;
      mcf_target = sourseCtrlName;
      contextMenuStrip1.Items[3].Enabled = true;
      contextMenuStrip3.Items[4].Enabled = true;
    }

    private string CleanVecStr(string matstr)
    {
      string[] rows = matstr.Split('\n');
      List<string> outlist = new List<string>();

      for (int i = 0; i < rows.Count(); i++)
      {
        rows[i] = rows[i].Trim();
        if (rows[i].Length > 0)
        {
          outlist.Add(rows[i]);
        }
      }

      return (string.Join("\n", outlist.ToArray()));
    }

    private void btnPlus_Click(object sender, EventArgs e)
    {
      string[] rows = CleanVecStr(rtbV1.Text).Split('\n');
      V1 = new Vector(rows);
      rows = CleanVecStr(rtbV2.Text).Split('\n');
      V2 = new Vector(rows);
      rtbVx.Text = (V1 + V2).toStr();
    }

    private void btnMinus_Click(object sender, EventArgs e)
    {
      string[] rows = CleanVecStr(rtbV1.Text).Split('\n');
      V1 = new Vector(rows);
      rows = CleanVecStr(rtbV2.Text).Split('\n');
      V2 = new Vector(rows);
      rtbVx.Text = (V1 - V2).toStr();
    }

    private void btnDotP_Click(object sender, EventArgs e)
    {
      string[] rows = CleanVecStr(rtbV1.Text).Split('\n');
      V1 = new Vector(rows);
      rows = CleanVecStr(rtbV2.Text).Split('\n');
      V2 = new Vector(rows);
      rtbVx.Text = (V1.Dotp(V2)).ToString();
    }

    private void btnCrossP_Click(object sender, EventArgs e)
    {
      string[] rows = CleanVecStr(rtbV1.Text).Split('\n');
      V1 = new Vector(rows);
      rows = CleanVecStr(rtbV2.Text).Split('\n');
      V2 = new Vector(rows);
      rtbVx.Text = (V1.Crossp(V2)).toStr();
    }

    private void normalizeToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ToolStripMenuItem tsmi = (ToolStripMenuItem)sender;
      ContextMenuStrip strip = (ContextMenuStrip)tsmi.Owner;

      Vector tempV = new Vector(CleanVecStr(strip.SourceControl.Text));
      strip.SourceControl.Text = tempV.Normalized().toStr();
    }

    private void VectorForm_Load(object sender, EventArgs e)
    {

    }

    private void btnUpdate1_Click(object sender, EventArgs e)
    {
      string[] rows;

      rtbNormU.Text = "";
      rtbNormV.Text = "";
      rtbNormW.Text = "";
      rtbUVAngle.Text = "";
      rtbAlphaU.Text = "";
      rtbBetaU.Text = "";
      rtbGammaU.Text = "";

      try
      {
        rows = CleanVecStr(rtbV1.Text).Split('\n');
        V1 = new Vector(rows);
        V1 = V1.Normalized();

        rtbAlphaU.Text = (Math.Acos(V1.Components[0]) * (180 / 3.14159265358)).ToString();
        rtbBetaU.Text = (Math.Acos(V1.Components[1]) * (180 / 3.14159265358)).ToString();
        rtbGammaU.Text = (Math.Acos(V1.Components[2]) * (180 / 3.14159265358)).ToString();
      }
      catch
      {

      }

      try
      {
        rows = CleanVecStr(rtbV2.Text).Split('\n');
        V1 = new Vector(rows);
        V1 = V1.Normalized();

        rtbAlphaV.Text = (Math.Acos(V1.Components[0]) * (180 / 3.14159265358)).ToString();
        rtbBetaV.Text = (Math.Acos(V1.Components[1]) * (180 / 3.14159265358)).ToString();
        rtbGammaV.Text = (Math.Acos(V1.Components[2]) * (180 / 3.14159265358)).ToString();
      }
      catch
      {

      }

      try
      {
        rows = CleanVecStr(rtbVx.Text).Split('\n');
        V1 = new Vector(rows);
        V1 = V1.Normalized();

        rtbAlphaW.Text = (Math.Acos(V1.Components[0]) * (180 / 3.14159265358)).ToString();
        rtbBetaW.Text = (Math.Acos(V1.Components[1]) * (180 / 3.14159265358)).ToString();
        rtbGammaW.Text = (Math.Acos(V1.Components[2]) * (180 / 3.14159265358)).ToString();
      }
      catch
      {

      }

      try
      {
        rows = CleanVecStr(rtbV1.Text).Split('\n');
        V1 = new Vector(rows);
        rtbNormU.Text = V1.Norm().ToString();
      }
      catch
      {

      }

      try
      {
        rows = CleanVecStr(rtbV2.Text).Split('\n');
        V2 = new Vector(rows);
        rtbNormV.Text = V2.Norm().ToString();
      }
      catch
      {

      }

      try
      {
        rows = CleanVecStr(rtbVx.Text).Split('\n');
        Vx = new Vector(rows);
        rtbNormW.Text = Vx.Norm().ToString();
      }
      catch
      {

      }

      if(rtbNormU.Text != "" && rtbNormV.Text != "")
      {
        rtbUVAngle.Text = ( Math.Acos( V1.Dotp(V2) / (V1.Norm() * V2.Norm()) ) * (180/3.14159265358) ).ToString();
      }
    }

    private void scalarMultToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ToolStripMenuItem tsmi = (ToolStripMenuItem)sender;
      ContextMenuStrip strip = (ContextMenuStrip)tsmi.Owner;

      Vector tempV = new Vector(CleanVecStr(strip.SourceControl.Text));
      
      double s;
      string input = Microsoft.VisualBasic.Interaction.InputBox("Multiplier");
      s = double.Parse(input);
      strip.SourceControl.Text = tempV.SMult(s).toStr();
    }

    private void pushToCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ToolStripMenuItem tsmi = (ToolStripMenuItem)sender;
      ContextMenuStrip strip = (ContextMenuStrip)tsmi.Owner;

      Vector tempV = new Vector(CleanVecStr(strip.SourceControl.Text));
      try
      {
        for (int i = 0; i < tempV.Rows; i++)
          dc_parent.pushExternal(tempV.Components[i]);
      }
      catch { MessageBox.Show("NaN"); }
    }

    private void sendToMatrixToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ToolStripMenuItem tsmi = (ToolStripMenuItem)sender;
      ContextMenuStrip strip = (ContextMenuStrip)tsmi.Owner;
      Vector tempV = new Vector(CleanVecStr(strip.SourceControl.Text));

      mcf_parent.getExternal(strip.SourceControl.Text, mcf_target);
    }

    private void pushToCalculatorToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      ToolStripMenuItem tsmi = (ToolStripMenuItem)sender;
      ContextMenuStrip strip = (ContextMenuStrip)tsmi.Owner;
      Vector tempV = new Vector(CleanVecStr(strip.SourceControl.Text));
      dc_parent.pushExternal(double.Parse(strip.SourceControl.Text));
    }

    private void rotateAboutToolStripMenuItem_Click(object sender, EventArgs e)
    {
      string[] rows;
      string matstr = "";
      string input = Microsoft.VisualBasic.Interaction.InputBox("Degrees");
      double theta = double.Parse(input);
      theta *= (3.14159265358 / 180);
      try
      {
        rows = CleanVecStr(rtbVx.Text).Split('\n');
        Vx = new Vector(rows);
        Vector uVx = Vx.Normalized();
        matstr  = "0," + (-uVx.Components[2]).ToString() + "," + uVx.Components[1].ToString() + ";";
        matstr += uVx.Components[2].ToString() + ",0," + (-uVx.Components[0]).ToString() + ";";
        matstr += (-uVx.Components[1]).ToString() + "," + uVx.Components[0].ToString() + ",0";
        Matrix S = new Matrix(matstr);
        Matrix I = new Matrix(3);
        Matrix U = I + (Math.Sin(theta) * S) + ((1-Math.Cos(theta)) * (S * S));
        rows = CleanVecStr(rtbV1.Text).Split('\n');
        if (rows.Count() == 3)
        {
          V1 = new Vector(rows);
          V1 = U * V1;
          rtbV1.Text = V1.toStr();
        }
        rows = CleanVecStr(rtbV2.Text).Split('\n');
        if (rows.Count() == 3)
        {
          V2 = new Vector(rows);
          V2 = U * V2;
          rtbV2.Text = V2.toStr();
        }
      }
      catch
      {

      }
    }

    private void toolStripMenuItem1_Click(object sender, EventArgs e)
    {
      ToolStripMenuItem tsmi = (ToolStripMenuItem)sender;
      ContextMenuStrip strip = (ContextMenuStrip)tsmi.Owner;

      Vector tempV = new Vector(CleanVecStr(strip.SourceControl.Text));
      strip.SourceControl.Text = tempV.Normalized().toStr();
    }

    private void toolStripMenuItem2_Click(object sender, EventArgs e)
    {
      ToolStripMenuItem tsmi = (ToolStripMenuItem)sender;
      ContextMenuStrip strip = (ContextMenuStrip)tsmi.Owner;

      Vector tempV = new Vector(CleanVecStr(strip.SourceControl.Text));

      double s;
      string input = Microsoft.VisualBasic.Interaction.InputBox("Scalar Multiplier");
      s = double.Parse(input);
      strip.SourceControl.Text = tempV.SMult(s).toStr();
    }

    private void toolStripMenuItem4_Click(object sender, EventArgs e)
    {
      ToolStripMenuItem tsmi = (ToolStripMenuItem)sender;
      ContextMenuStrip strip = (ContextMenuStrip)tsmi.Owner;
      Vector tempV = new Vector(CleanVecStr(strip.SourceControl.Text));

      mcf_parent.getExternal(strip.SourceControl.Text, mcf_target);
      Close();
    }

    private void toolStripMenuItem3_Click(object sender, EventArgs e)
    {
      ToolStripMenuItem tsmi = (ToolStripMenuItem)sender;
      ContextMenuStrip strip = (ContextMenuStrip)tsmi.Owner;

      Vector tempV = new Vector(CleanVecStr(strip.SourceControl.Text));
      try
      {
        for (int i = 0; i < tempV.Rows; i++)
          dc_parent.pushExternal(tempV.Components[i]);
      }
      catch { MessageBox.Show("NaN"); }
    }
  }
}
