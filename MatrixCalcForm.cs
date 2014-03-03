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
using System.Collections;
using System.Text.RegularExpressions;

namespace DCalc
{
  public partial class MatrixCalcForm : Form
  {
    Matrix A;
    Matrix sto;
    Label[] lblStack = new Label[3];
    Stack stack = new Stack();
    string[] operators = { "INV", "INVERSE", "I", "TRANSPOSE", "T", "RREF", "AUGMENT", "SOLVE", "SOLVELSQ", "APPROX", "SQUARE", "SQ", "MAPTO", "MAPFROM", "STO", "RCL", "RECALL", "DET" };

    public MatrixCalcForm()
    {
      InitializeComponent();

      for (int i = 0; i < 3; i++)
      {
        lblStack[i] = new Label();
        lblStack[i].Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        lblStack[i].Location = new System.Drawing.Point(513, 488 - 175 * i);
        lblStack[i].Size = new System.Drawing.Size(376, 164);
        //lblStack[i].TabIndex = 4 + i;
        lblStack[i].Text = "";
        lblStack[i].BackColor = Color.White;
        lblStack[i].AutoSize = false;
        lblStack[i].TextAlign = ContentAlignment.BottomRight;
      }
      lblStack[0].ContextMenuStrip = this.contextMenuStrip2;
      this.Controls.AddRange(lblStack);
    }

    private void showStack()
    {
      int sz = Math.Min(3, stack.Count);
      int i = 0;
      lblStack[0].Text = "";
      lblStack[1].Text = "";
      lblStack[2].Text = "";
      foreach (Matrix d in stack)
      {
        lblStack[i++].Text = d.toStr(8);
        if (--sz < 1) break;
      }
      rtbMatrixA.Text = "";
      rtbMatrixA.Focus();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      
    }

    private string CleanMatStr(string matstr)
    {
      string[] rows = matstr.Split('\n');
      List<string> outlist = new List<string>();

      for(int i = 0; i < rows.Count(); i++)
      {
        rows[i] = rows[i].Trim();
        if (rows[i].Length > 0)
        {
          outlist.Add(rows[i]);
        }
      }

      return (string.Join("\n", outlist.ToArray()));
    }

    private void vectorCalcToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ToolStripMenuItem tsmi = (ToolStripMenuItem)sender;
      ContextMenuStrip strip = (ContextMenuStrip)tsmi.Owner;

      VectorForm vf = new VectorForm(this, strip.SourceControl.Name);
      vf.Show();
    }

    public bool getExternal(string vectorStr, string target)
    {
      try
      {
        if (target == "rtbMatrixA")
          rtbMatrixA.Text = vectorStr;          
        return true;
      }
      catch { return false; }
    }

    private void inverseToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ToolStripMenuItem tsmi = (ToolStripMenuItem)sender;
      ContextMenuStrip strip = (ContextMenuStrip)tsmi.Owner;

      string[] rows = CleanMatStr(strip.SourceControl.Text).Split('\n');
      Matrix tA = new Matrix(rows);
      strip.SourceControl.Text = tA.inverse().toStr(8);
    }

    private void transformToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ToolStripMenuItem tsmi = (ToolStripMenuItem)sender;
      ContextMenuStrip strip = (ContextMenuStrip)tsmi.Owner;

      string[] rows = CleanMatStr(strip.SourceControl.Text).Split('\n');
      Matrix tA = new Matrix(rows);
      strip.SourceControl.Text = tA.transpose().toStr(8);
    }

    private void rREFToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ToolStripMenuItem tsmi = (ToolStripMenuItem)sender;
      ContextMenuStrip strip = (ContextMenuStrip)tsmi.Owner;

      string[] rows = CleanMatStr(strip.SourceControl.Text).Split('\n');
      Matrix tA = new Matrix(rows);
      tA.rref();
      strip.SourceControl.Text = tA.toStr(8);
    }

    private void dETToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ToolStripMenuItem tsmi = (ToolStripMenuItem)sender;
      ContextMenuStrip strip = (ContextMenuStrip)tsmi.Owner;

      string[] rows = CleanMatStr(strip.SourceControl.Text).Split('\n');
      Matrix tA = new Matrix(rows);
      strip.SourceControl.Text = (tA.DET()).ToString();
    }

    private void clearToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ToolStripMenuItem tsmi = (ToolStripMenuItem)sender;
      ContextMenuStrip strip = (ContextMenuStrip)tsmi.Owner;
      strip.SourceControl.Text = "";
    }

    private void Inverse() { stack.Push(((Matrix)stack.Pop()).inverse()); }

    private void Transpose() { stack.Push(((Matrix)stack.Pop()).transpose()); }

    private void RREF()
    {
      Matrix tA = (Matrix)stack.Pop();
      tA.rref();
      stack.Push(tA);
    }

    private void Square()
    {
      Matrix m1 = (Matrix)stack.Pop();
      stack.Push(m1 * m1);
    }

    private void Augment()
    {
      if (stack.Count >= 2)
      {
        Matrix m1 = (Matrix)stack.Pop();
        Matrix m2 = (Matrix)stack.Pop();
        stack.Push(m2.augment(m1));
      }
    }

    private void LinSolve()
    {
      if (stack.Count >= 2)
      {
        Matrix m1 = (Matrix)stack.Pop();
        Matrix m2 = (Matrix)stack.Pop();
        m2 = m2.augment(m1);
        stack.Push(m2.solve(m1.getCols()));
      }
    }

    private void LinSolveLSq()
    {
      if (stack.Count >= 2)
      {
        Matrix m2 = (Matrix)stack.Pop();
        Matrix m1 = (Matrix)stack.Pop();
        Matrix m1t = m1.transpose();
        Matrix m1tm1 = m1t * m1t;
        Matrix m1tm2 = m1t * m2;
        stack.Push((m1tm1.augment(m1tm2)).solve(m1tm2.getCols()));
      }
    }

    private void MapTo()
    {
      Matrix m2 = (Matrix)stack.Pop();
      Matrix m1 = (Matrix)stack.Pop();
      stack.Push(m1 * m2);
    }

    private void MapFrom()
    {
      Matrix m2 = (Matrix)stack.Pop();
      Matrix m1 = (Matrix)stack.Pop();
      stack.Push(m1.inverse() * m2);
    }

    private void Store()
    {
      sto = (Matrix)stack.Peek();
    }

    private void Recall()
    {
      try
      {
        stack.Push(sto);
      }
      catch { }
    }

    private double Determinate()
    {
      return ((Matrix)stack.Peek()).DET();
      //double d;
      //Matrix m1 = (Matrix)stack.Pop();
      //d = m1.DET();
      //stack.Push(m1);
      //return d;
    }

    private void Operate(string opstr)
    {
      switch (opstr.ToUpper())
      {
        case "INV":
        case "INVERSE":
        case "I":
          Inverse();
          break;
        case "TRANSPOSE":
        case "T":
          Transpose();
          break;
        case "RREF":
          RREF();
          break;
        case "AUGMENT":
          Augment();
          break;
        case "SOLVE":
          LinSolve();
          break;
        case "SOLVELSQ":
        case "APPROX":
          LinSolveLSq();
          break;
        case "SQ":
        case "SQUARE":
          Square();
          break;
        case "MAPTO":
          MapTo();
          break;
        case "MAPFROM":
          MapFrom();
          break;
        case "STO":
          Store();
          break;
        case "RCL":
        case "RECALL":
          Recall();
          break;
        case "DET":
          MessageBox.Show("DET = " + Determinate());
          break;
      }
    }

    private int InputType(string instr)
    {
      //MessageBox.Show("~~~" + instr + "~~~");
      //1 = a scalar
      try
      {
        double d = double.Parse(instr);
        return 1;
      }
      catch { }

      //2 = operator
      if (Array.IndexOf(operators, instr.ToUpper().Trim()) > -1)
        return 2;

      //3 = A Matrix
      try
      {
        Matrix m = new Matrix(instr);
        return 3;
      }
      catch { }

      try
      {
        string[] rows = CleanMatStr(rtbMatrixA.Text).Split('\n');
        Matrix m = new Matrix(rows);
        return 4;
      }
      catch { }
      return 0;
    }

    private void rtbMatrixA_KeyUp(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter && rtbMatrixA.Text == "\n")
      {
        String mstr = ((Matrix)stack.Peek()).toMatStr();
        stack.Push(new Matrix(mstr));
        showStack();
      }

      if (e.KeyCode == Keys.Enter && InputType(rtbMatrixA.Text) == 2)
      {
        Operate(rtbMatrixA.Text.Trim());
        showStack();
      }

      if (e.KeyCode == Keys.Enter && InputType(rtbMatrixA.Text) == 3)
      {
        stack.Push(new Matrix(rtbMatrixA.Text));
        showStack();
      }

      if (e.KeyCode == Keys.Enter && InputType(rtbMatrixA.Text) == 4)
      {
        string[] rows = (rtbMatrixA.Text).Split('\n');
        if (rows[rows.Count() - 2] == "")
        {
          rows = CleanMatStr(rtbMatrixA.Text).Split('\n');
          Matrix tA = new Matrix(rows);
          stack.Push(tA);
          showStack();
        }
      }

      if (e.KeyCode == Keys.Add)
      {
        if (stack.Count >= 2)
        {
          Matrix m2 = (Matrix)stack.Pop();
          stack.Push((Matrix)stack.Pop() + m2);
          showStack();
        }
      }

      //if (e.KeyCode == Keys.Subtract)
      //{
      //  if (stack.Count >= 2)
      //  {
      //    Matrix m2 = (Matrix)stack.Pop();
      //    stack.Push((Matrix)stack.Pop() - m2);
      //    showStack();
      //  }
      //}

      if (e.KeyCode == Keys.Multiply)
      {
        if (stack.Count >= 2)
        {
          Matrix m2 = (Matrix)stack.Pop();
          stack.Push((Matrix)stack.Pop() * m2);
          showStack();
        }
      }

      if (Control.ModifierKeys == Keys.Control)
      {
        if (e.KeyCode == Keys.Return)
        {
          //MessageBox.Show(InputType(rtbMatrixA.Text).ToString());
          int type = InputType(rtbMatrixA.Text);
          switch (type)
          {
            case 1:
              break;
            case 2:
              Operate(rtbMatrixA.Text.Trim());
              break;
            case 4:
              string[] rows = CleanMatStr(rtbMatrixA.Text).Split('\n');
              Matrix tA = new Matrix(rows);
              stack.Push(tA);
              break;
            case 3:
              stack.Push(new Matrix(rtbMatrixA.Text));
              break;
            default:
              break;
          }
          
        }
        if (e.KeyCode == Keys.I)
        {
          Operate("INV");
        }
        if (e.KeyCode == Keys.T)
        {
          Operate("transpose");
        }
        if (e.KeyCode == Keys.Q)
        {
          Operate("square");
        }
        if (e.KeyCode == Keys.R)
        {
          Operate("rref");
        }
        if (e.KeyCode == Keys.A)
        {
          Operate("AUGMENT");
        }
        if (e.KeyCode == Keys.S)
        {
          Operate("LINSOLVE");
        }
        if (e.KeyCode == Keys.P)
        {
          Operate("APPROX");
        }
        showStack();
      }

      if (Control.ModifierKeys == Keys.Alt)
      {
        if(e.KeyCode == Keys.I)
        {
          string input = Microsoft.VisualBasic.Interaction.InputBox("Multiplier");
          int s = int.Parse(input);
          stack.Push(new Matrix(s));
          showStack();
        }
      }
    }

    private void nudFix_ValueChanged(object sender, EventArgs e)
    {
      showStack();
    }

    private void toolStripMenuItem1_Click(object sender, EventArgs e)
    {
      stack.Push(((Matrix)stack.Pop()).inverse());
      showStack();
    }

    private void dropToolStripMenuItem_Click(object sender, EventArgs e)
    {
      stack.Pop();
      showStack();
    }

    private void swapToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Matrix m1 = (Matrix)stack.Pop();
      Matrix m2 = (Matrix)stack.Pop();
      stack.Push(m1);
      stack.Push(m2);
      showStack();
    }

    private void clearStackToolStripMenuItem_Click(object sender, EventArgs e)
    {
      stack.Clear();
      showStack();
    }
  }
}
