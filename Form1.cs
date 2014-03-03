using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MatVec;

namespace DCalc
{
  public partial class DCalc : Form
  {
    Stack stack = new Stack();
    Stack evalStack = new Stack();
    Stack tokStack = new Stack();
    string[] opArray = {"+", "-", "*", "/", "^", "&", "|", "\\", "%"};
    string[] fArray = {"sin", "s", "c", "t", "S", "C", "T", "q", "mm", "\"", "r", "n", "~", "ans"};
    Hashtable constHash = new Hashtable();
    Hashtable opHash = new Hashtable();

    Label[] lblStack = new Label[4];

    public DCalc()
    {
      InitializeComponent();
      
      for (int i = 0; i < 4; i++)
      {
        lblStack[i] = new Label();
        lblStack[i].Font = new System.Drawing.Font("Courier New", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        lblStack[i].Location = new System.Drawing.Point(33, 95 - 30 * i);
        lblStack[i].Size = new System.Drawing.Size(200, 20);
        lblStack[i].TabIndex = 4 + i;
        lblStack[i].Text = "0";
        lblStack[i].BackColor = Color.White;
        lblStack[i].AutoSize = false;
        lblStack[i].TextAlign = ContentAlignment.TopRight;
        lblStack[i].ContextMenuStrip = this.contextMenuStrip1;
      }
      panel1.Controls.AddRange(lblStack);
      constHash.Add("#p", "3.14159265358");
      constHash.Add("#e", "2.718281828459045");
      BuildOperatorHashtable();
    }

    private void BuildOperatorHashtable()
    {
      opHash.Add("%", -9);
      opHash.Add("\\", -8);
      opHash.Add("|", -7);
      opHash.Add("&", -6);
      opHash.Add("^", -5);
      opHash.Add("/", -4);
      opHash.Add("*", -3);
      opHash.Add("-", -2);
      opHash.Add("+", -1);
      opHash.Add("sin", 1);
      opHash.Add("s", 1);
      opHash.Add("cos", 2);
      opHash.Add("c", 2);
      opHash.Add("tan", 3);
      opHash.Add("t", 3);
      opHash.Add("S", 4);
      opHash.Add("asin", 4);
      opHash.Add("C", 5);
      opHash.Add("acos", 5);
      opHash.Add("T", 6);
      opHash.Add("atan", 6);
      opHash.Add("q", 7);
      opHash.Add("sqrt", 7);
      opHash.Add("r", 8);
      opHash.Add("n", 9);
      opHash.Add("chs", 9);
      opHash.Add("ans", 10);
    }

    private bool isOperator(string o)
    {
      if (opHash.ContainsKey(o)) return true;
      //if (fArray.Contains(o)) return true;
      return false;
    }

    private int opPrec(string o)
    {
	    if (o.Equals("+")) return 1;
      if (o.Equals("-")) return 1;
      if (o.Equals("*")) return 2;
      if (o.Equals("/")) return 2;
      if (o.Equals("^")) return 3;
	    return 0;
    }

    private void InfixToPostfix()
    {
      string infixStr = txtInfix.Text;
      string mstr;

      infixStr = Regex.Replace(infixStr, @" +", "");

      infixStr = Regex.Replace(infixStr, @"\+", " + ");
      infixStr = Regex.Replace(infixStr, @"-", " - ");
      infixStr = Regex.Replace(infixStr, @"\*", " * ");
      infixStr = Regex.Replace(infixStr, @"/", " / ");
      infixStr = Regex.Replace(infixStr, @"\^", " ^ ");
      foreach (string fstr in fArray)
      {
        mstr = @"(?<op>" + fstr + ") *";
        infixStr = Regex.Replace(infixStr, mstr, " ${op} ");
      }

      foreach(DictionaryEntry hstr in constHash)
      { 
        infixStr = Regex.Replace(infixStr, hstr.Key.ToString(), " " + hstr.Value.ToString() + " ");
      }

      infixStr = Regex.Replace(infixStr, @"\(", " ( ");
      infixStr = Regex.Replace(infixStr, @"\)", " ) ");
      infixStr = infixStr.Trim();
      txtInfix.Text = infixStr;
      
      string pattern = @" +";
      Regex rgx = new Regex(pattern, RegexOptions.IgnoreCase);
      MatchCollection matches = rgx.Matches(infixStr);
      string[] tokens = rgx.Split(infixStr);

      string postfixStr = "";

      try
      {
        foreach (string token in tokens)
        {

          if (IsNumeric(token))
          {
            postfixStr += token + " ";
          }
          else if (token[0] == '(')
          {
            stack.Push(token);
          }
          else if (isOperator(token))
          {
            while (stack.Count > 0 && opPrec(token) <= opPrec((string)stack.Peek()))
            {
              postfixStr += stack.Pop() + " ";
            }
            stack.Push(token);
          }
          else if (token[0] == ')')
          {
            string peekStr = (string)stack.Peek();
            while (peekStr[0] != '(')
            {
              postfixStr += stack.Pop() + " ";
              peekStr = (string)stack.Peek();
            }
            stack.Pop();
          }
        }
        while (stack.Count > 0)
        {
          postfixStr += " " + stack.Pop();
        }
      }
      catch
      {
        //postfixStr = "Input Error";
      }
      txtPostfix.Text = postfixStr;
      txtInfix.Text = "";
    }

    void EvaluatePostfix(string postfixStr)
    {
      if (postfixStr != "")
      {
        string token = "";
        foreach (DictionaryEntry pair in constHash)
        {
          postfixStr = Regex.Replace(postfixStr, (string)(pair.Key), (string)(pair.Value));
        }

        postfixStr = postfixStr.Trim();

        UpdateTokStack(postfixStr);

        if (tokStack.Count > 0)
        {
          while (tokStack.Count > 0)
          {
            token = (string)(tokStack.Pop());
            if (IsNumeric(token))
            {
              evalStack.Push(double.Parse(token));
            }
            else if (opHash.ContainsKey(token))
            {
              if ((int)(opHash[token]) > 0)
              {
                double a = (double)evalStack.Pop();
                evalStack.Push(op(a, token));
              }
              else
              {
                double a = (double)evalStack.Pop();
                double b = (double)evalStack.Pop();
                evalStack.Push(op(a, b, token));
              }
            }
            else
            {
              if (token != "")
              {
                string input = Microsoft.VisualBasic.Interaction.InputBox("Bad Token", "DCalc", token);
                UpdateTokStack(input);
              }
            }
          }
        }
      }
      txtPostfix.Text = "";
    }

    void UpdateTokStack(string s)
    {
      string pattern = @"\s+";
      Regex rgx = new Regex(pattern, RegexOptions.IgnoreCase);
      MatchCollection matches = rgx.Matches(s);

      string[] sa = rgx.Split(s);

      for (int i = sa.Count() - 1; i >= 0; i--)
      {
        tokStack.Push(sa[i]);
      }
    }

    double op(double b, double a, string o)
    {
      switch ((int) opHash[o])
      {
        case -1:
          return (a + b);
        case -2:
          return (a - b);
        case -3:
          return (a * b);
        case -4:
          return (a / b);
        case -5:
          return Math.Pow(a, b);
        case -6:
          return ((int)a & (int)b);
        case -7:
          return ((int)a | (int)b);
        case -8:
          return ((int)a / (int)b);
        case -9:
          return (a % b);
        default:
          return b;
      }
    }

    double op(double a, string o)
    {
      switch ((int)opHash[o])
      {
        case 1:
          if (cbDegRad.Text == "Deg") return Math.Sin(d2r(a)); else return Math.Sin(a);
          break;
        case 2:
          if (cbDegRad.Text == "Deg") return Math.Cos(d2r(a)); else return Math.Cos(a);
          break;
        case 3:
          if (cbDegRad.Text == "Deg") return Math.Tan(d2r(a)); else return Math.Tan(a);
          break;
        case 4:
          if (cbDegRad.Text == "Deg") return r2d(Math.Asin(a)); else return Math.Asin(a);
          break;
        case 5:
          if (cbDegRad.Text == "Deg") return r2d(Math.Acos(a)); else return Math.Acos(a);
          break;
        case 6:
          if (cbDegRad.Text == "Deg") return r2d(Math.Atan(a)); else return Math.Atan(a);
          break;
        case 7:
          return Math.Sqrt(a);
          break;
        case 8:
          if (a != 0) return 1 / a; else return a;
          break;
        case 9:
          return -a;
          break;
        case 10:
          return a;
          break;
        default:
          return a;
      }
    }

    public bool IsNumeric(string stringToTest)
    {
      double result;
      return double.TryParse(stringToTest, out result);
    }

    private void btnEvalInfix_Click(object sender, EventArgs e)
    {
      InfixToPostfix();
      EvaluatePostfix(txtPostfix.Text);
      showStack();
    }

    private void btnEvalPostfix_Click(object sender, EventArgs e)
    {
      txtInfix.Text = "";
      EvaluatePostfix(txtPostfix.Text);
      showStack();
    }

    private void txtPostScript_Leave(object sender, EventArgs e)
    {
      showStack();
    }

    private void txtPostScript_KeyUp(object sender, KeyEventArgs e)
    {
      if (cbCalcMode.Checked)
      {
        switch (e.KeyCode)
        {
          case Keys.R:
          case Keys.Q:
            EvaluatePostfix(txtPostfix.Text);
            showStack();
            break;
          default:
            break;
        }
        switch (e.KeyValue)
        {
          case 187:
          case 107:
          case 189:
          case 109:
          case 56:
          case 106:
          case 191:
          case 111:
          case 54:
            EvaluatePostfix(txtPostfix.Text);
            showStack();
            break;
          default:
            break;
        }
      }
      if (e.KeyCode == Keys.Enter)
      {
        if (Control.ModifierKeys == Keys.Shift && txtPostfix.Text == "")
        {
          try
          {
            evalStack.Push(evalStack.Peek());
          }
          catch
          {
          }
        }

        txtInfix.Text = "";
        EvaluatePostfix(txtPostfix.Text);
        showStack();
        txtPostfix.Text = "";
      }
      if (e.KeyCode == Keys.Escape)
      {
        txtPostfix.Text = "";
      }
    }
  
    private void txtPostScript_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Escape)
      {
        e.SuppressKeyPress = true;
      }
    }

    private double d2r(double d)
    {
      return d * 0.0174532925;
    }

    private double r2d(double r)
    {
      return r / 0.0174532925;
    }

    private void txtInfix_KeyUp(object sender, KeyEventArgs e)
    {
      //MessageBox.Show("KeyValue: " + e.KeyValue);
      if (e.KeyCode == Keys.Enter)
      {
        InfixToPostfix();
        EvaluatePostfix(txtPostfix.Text);
        showStack();
      }
      if (e.KeyCode == Keys.Escape)
      {
        txtInfix.Text = "";
      }
    }

    private void txtInfix_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Escape)
      {
        e.SuppressKeyPress = true;
      }
    }

    private void txtInfix_Leave(object sender, EventArgs e)
    {
      //InfixToPostfix();
      //EvaluatePostfix(txtPostfix.Text);
      //showStack();
    }

    private void DCalc_Load(object sender, EventArgs e)
    {
      
    }

    private void button1_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void strStack(Stack s)
    {
      string str = "";
      foreach(var v in s)
      {
        str += v + "\r\n";
      }
      MessageBox.Show(str);
    }

    private void showStack()
    {
      string stackStr = "";
      int sz = Math.Min(4, evalStack.Count);
      int i = 0;
      lblStack[0].Text = "0";
      lblStack[1].Text = "0";
      lblStack[2].Text = "0";
      lblStack[3].Text = "0";
      foreach (double d in evalStack)
      {
        lblStack[i++].Text = d + "\r\n" + stackStr;
        if (--sz < 1) break;
      }
    }

    private string dec2bin(string data)
    {
      string result = string.Empty;
      string error = string.Empty;
      int rem = 0;
      try
      {
        if (!IsNumeric(data))
          error = "Invalid Value - This is not a numeric value";
        else
        {
          int num = int.Parse(data);
          while (num > 0)
          {
            rem = num % 2;
            num = num / 2;
            result = rem.ToString() + result;
          }
        }
      }
      catch (Exception ex)
      {
        error = ex.Message;
      }
      return result;
    }

    private string dec2hex(decimal d)
    {
      int[] bits = decimal.GetBits(d);
      if (bits[3] != 0) // Sign and exponent 
      {
        throw new ArgumentException();
      }
      return string.Format("{0:x8}{1:x8}{2:x8}",
          (uint)bits[2], (uint)bits[1], (uint)bits[0]); 
    }

    private void btnDrop_Click(object sender, EventArgs e)
    {
      if (evalStack.Count > 0)
      {
        evalStack.Pop();
        showStack();
      }
      txtPostfix.Focus();
    }

    private void btnSwap_Click(object sender, EventArgs e)
    {
      try
      {
        double d1 = (double)evalStack.Pop();
        double d2 = (double)evalStack.Pop();
        evalStack.Push(d1);
        evalStack.Push(d2);
      }
      catch
      {

      }
      showStack();
      txtPostfix.Focus();
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
      evalStack = new Stack();
      showStack();
      txtPostfix.Focus();
    }

    private void cbBase_SelectedIndexChanged(object sender, EventArgs e)
    {
      showStack();
    }

    private void copyToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ToolStripMenuItem tsmi = (ToolStripMenuItem)sender;
      ContextMenuStrip strip = (ContextMenuStrip)tsmi.Owner;

      Clipboard.SetDataObject(strip.SourceControl.Text);
    }

    private void showStackToolStripMenuItem_Click(object sender, EventArgs e)
    {
      string message = "";
      foreach (double d in evalStack)
      {
        if (message == "") message = d.ToString(); else message += "\r\n" + d.ToString();
      }

      Clipboard.SetDataObject(message);
    }

    private void btnMatrixCalc_Click(object sender, EventArgs e)
    {
      MatrixCalcForm mcf = new MatrixCalcForm();
      mcf.Show();

    }

    private void btnBitCalc_Click(object sender, EventArgs e)
    {
      BitCalcForm bcf = new BitCalcForm(this);
      bcf.Owner = this;
      bcf.Show();
    }

    public bool pushExternal(double d)
    {
      try
      {
        evalStack.Push(d);
        showStack();
        return true;
      }
      catch { return false; }
    }

    private void btnVectorCalc_Click(object sender, EventArgs e)
    {
      VectorForm vf = new VectorForm(this);
      vf.Show();
    }

    private void FlushKeyboard()
    {
      while (Console.In.Peek() != -1)
        Console.In.Read();
    }
  }
}
