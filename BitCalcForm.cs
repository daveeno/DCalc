using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCalc
{
  public partial class BitCalcForm : Form
  {
    private DCalc m_parent;

    public BitCalcForm()
    {
      InitializeComponent();
    }

    public BitCalcForm(DCalc dc1)
    {
      InitializeComponent();
      m_parent = dc1;
    }

    private void BitCalcForm_Load(object sender, EventArgs e)
    {

    }

    
    private int Bin2Dec(string binstr)
    {
      double dec = 0;
      int n = 0;

      char[] carray = binstr.ToCharArray();
      for (int i = carray.Length - 1; i >= 0; i--)
      {
        if (carray[i] == '1') dec += Math.Pow(2, n);
        n++;
      }

      return (int)dec;
    }

    private string Dec2Bin(int dec)
    {
      return Convert.ToString(dec, 2);
    }

    private void txtBin1_Leave(object sender, EventArgs e)
    {
      txtDec1.Text = Bin2Dec(txtBin1.Text).ToString();
    }

    private void txtDec1_Leave(object sender, EventArgs e)
    {
      txtBin1.Text = Dec2Bin(Convert.ToInt32(txtDec1.Text));
    }

    private void txtBin2_Leave(object sender, EventArgs e)
    {
      txtDec2.Text = Bin2Dec(txtBin2.Text).ToString();
    }

    private void txtDec2_Leave(object sender, EventArgs e)
    {
      txtBin2.Text = Dec2Bin(Convert.ToInt32(txtDec2.Text));
    }

    private void txtBin1_TextChanged(object sender, EventArgs e)
    {
      txtDec1.Text = Bin2Dec(txtBin1.Text).ToString();
    }

    private void txtBin2_TextChanged(object sender, EventArgs e)
    {
      txtDec2.Text = Bin2Dec(txtBin2.Text).ToString();
    }

    private void txtDec1_TextChanged(object sender, EventArgs e)
    {
      txtBin1.Text = Dec2Bin(Convert.ToInt32(txtDec1.Text));
    }

    private void txtDec2_TextChanged(object sender, EventArgs e)
    {
      txtBin2.Text = Dec2Bin(Convert.ToInt32(txtDec2.Text));
    }

    private void btnNot1_Click(object sender, EventArgs e)
    {
      txtBin1.Text = BinNot(txtBin1.Text);
    }

    private string BinNot(string binstr)
    {
      char[] carray = binstr.ToCharArray();

      for (int i = 0; i < carray.Length; i++)
      {
        if (carray[i] == '1')
          carray[i] = '0';
        else
          carray[i] = '1';
      }

      return new string(carray);
    }

    private void btnNot2_Click(object sender, EventArgs e)
    {
      txtBin2.Text = BinNot(txtBin2.Text);
    }

    private void btnAnd_Click(object sender, EventArgs e)
    {
      string outstr = "";
      int max = ((txtBin1.Text.Length > txtBin2.Text.Length) ? txtBin1.Text.Length : txtBin2.Text.Length);
      string str1 = Pad(txtBin1.Text, max);
      string str2 = Pad(txtBin2.Text, max);
      char[] carray1 = str1.ToCharArray();
      char[] carray2 = str2.ToCharArray();

      for(int i = 0; i < max; i++)
      {
        if (carray1[i] == '1' && carray2[i] == '1')
          outstr += "1";
        else
          outstr += "0";
      }
      lblBinAns.Text = outstr;  
    }

    private void label1_TextChanged(object sender, EventArgs e)
    {
      lblDecAns.Text = Bin2Dec(lblBinAns.Text).ToString();
    }

    private string Pad(string binstr, int plcs)
    {
      if (binstr.Length >= plcs) return binstr;

      for(int i = binstr.Length; i < plcs; i++)
      {
        binstr = '0' + binstr;
      }
      return binstr;
    }

    private string UnPad(string binstr)
    {
      return Dec2Bin(Bin2Dec(binstr));
    }

    private void btnOr_Click(object sender, EventArgs e)
    {
      string outstr = "";
      int max = ((txtBin1.Text.Length > txtBin2.Text.Length) ? txtBin1.Text.Length : txtBin2.Text.Length);
      string str1 = Pad(txtBin1.Text, max);
      string str2 = Pad(txtBin2.Text, max);
      char[] carray1 = str1.ToCharArray();
      char[] carray2 = str2.ToCharArray();

      for (int i = 0; i < max; i++)
      {
        if (carray1[i] == '1' || carray2[i] == '1')
          outstr += "1";
        else
          outstr += "0";
      }
      lblBinAns.Text = outstr;  
    }

    private void btnXor_Click(object sender, EventArgs e)
    {
      string outstr = "";
      int max = ((txtBin1.Text.Length > txtBin2.Text.Length) ? txtBin1.Text.Length : txtBin2.Text.Length);
      string str1 = Pad(txtBin1.Text, max);
      string str2 = Pad(txtBin2.Text, max);
      char[] carray1 = str1.ToCharArray();
      char[] carray2 = str2.ToCharArray();

      for (int i = 0; i < max; i++)
      {
        if ((carray1[i] == '1' && carray2[i] == '0') || (carray1[i] == '0' && carray2[i] == '1'))
          outstr += "1";
        else
          outstr += "0";
      }
      lblBinAns.Text = outstr;  
    }

    private string LShift(string binstr)
    {
      return binstr + "0";
    }

    private string RShift(string binstr)
    {
      return binstr.Substring(0, binstr.Length - 1);
    }

    private void btnLShift1_Click(object sender, EventArgs e)
    {
      txtBin1.Text = LShift(txtBin1.Text);
    }

    private void btnLShift2_Click(object sender, EventArgs e)
    {
      txtBin2.Text = LShift(txtBin2.Text);
    }

    private void btnRShift1_Click(object sender, EventArgs e)
    {
      txtBin1.Text = RShift(txtBin1.Text);
    }

    private void btnRShift2_Click(object sender, EventArgs e)
    {
      txtBin2.Text = RShift(txtBin2.Text);
    }

    private void txtBin1_KeyPress(object sender, KeyPressEventArgs e)
    {
      char[] allowedKeys = { '0', '1', (char)Keys.Back };
      if (!allowedKeys.Contains(e.KeyChar))
      {
        e.Handled = true;
      }
    }

    private void txtBin2_KeyPress(object sender, KeyPressEventArgs e)
    {
      char[] allowedKeys = { '0', '1', (char)Keys.Back };
      if (!allowedKeys.Contains(e.KeyChar))
      {
        e.Handled = true;
      }
    }

    private void txtDec1_KeyPress(object sender, KeyPressEventArgs e)
    {
      char[] allowedKeys = { (char)Keys.Back, (char)Keys.Enter };
      if (!char.IsDigit(e.KeyChar) && !allowedKeys.Contains(e.KeyChar))
      {
        e.Handled = true;
      }
      else
      {
        if (e.KeyChar == (char)Keys.Enter)
          txtBin1.Text = Dec2Bin(Convert.ToInt32(txtDec1.Text));
      }
    }

    private void txtDec2_KeyPress(object sender, KeyPressEventArgs e)
    {
      char[] allowedKeys = { (char)Keys.Back, (char)Keys.Enter };
      if (!char.IsDigit(e.KeyChar) && !allowedKeys.Contains(e.KeyChar))
      {
        e.Handled = true;
      }
      else
      {
        if (e.KeyChar == (char)Keys.Enter)
          txtBin2.Text = Dec2Bin(Convert.ToInt32(txtDec2.Text));
      }
    }

    private void pushToStackToolStripMenuItem_Click(object sender, EventArgs e)
    {
      try
      {
        double d = Double.Parse(lblDecAns.Text);
        m_parent.pushExternal(d);
      }
      catch { MessageBox.Show("NaN"); }
    }
  }
}
