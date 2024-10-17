using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ficha1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Exercicios 1

        // Quais os valores no final das variáveis a, b, c, d
        private void ButtonExercicio1_1_Click(object sender, EventArgs e)
        {
            int a = 1;
            int b = -1;
            int c = 0;
            int d = 0;

            a = a + 1;  // a += 1;
            c = b * 2;
            a = c - 1;
            d = -1 * c;
            d = d * 3;
            c -= 3;     // c = c - 3;
            b = a - b;

            MessageBox.Show("a=" + a.ToString() + " b=" + b.ToString() + " c=" + c.ToString() + " d=" + d.ToString());
        }

        // Quais os valores no final das variáveis a, b, c, d
        private void ButtonExercicio1_2_Click(object sender, EventArgs e)
        {
            int a = 1;
            int b = -1;
            int c = 0;
            int d = 0;
            
            a += 1;
            c = b * -2;
            d = -1 * c;
            b *= 2;
            a = c - 1;
            d += 3;

            c -= (3 + b);
            //int f = 0;
            //f = b + 3;
            //c = c - f;

            b = a - d;

            MessageBox.Show("a=" + a.ToString() + " b=" + b.ToString() + " c=" + c.ToString() + " d=" + d.ToString());
        }

        // Quais os valores no final das variáveis a, b, c, d
        private void ButtonExercicio1_3_Click(object sender, EventArgs e)
        {
            int a = 1;
            int b = 2;
            int c = 3;
            int d = 4;

            a += (a + 1);
            b *= 2;
            c *= (b * -2);
            d -= c;
            b *= 2;
            a = c + 1;
            d += (3 + b);
            c -= (3 + b);
            b = a - c;

            MessageBox.Show("a=" + a.ToString() + " b=" + b.ToString() + " c=" + c.ToString() + " d=" + d.ToString());
        }

        #endregion

        #region Exercicios 2

        private int Teste(int x, int y)
        {
            int h = y;
            h += 3;
            return x * h * 2;
        }

        private int Teste2(int x, ref int y)
        {
            y += 1;
            return x + y;
        }

        private int Teste3(ref int x, ref int y)
        {
            x -= 1;
            y += 1;
            return x + y;
        }

        // Quais os valores no final das variáveis a, b, c
        private void ButtonExercicio2_1_Click(object sender, EventArgs e)
        {
            int a = 1;
            int b = -1;
            int c = 0;
            c = this.Teste(a, b);

            MessageBox.Show("a=" + a.ToString() + " b=" + b.ToString() + " c=" + c.ToString());
        }

        // Quais os valores no final das variáveis a, b, c
        private void ButtonExercicio2_2_Click(object sender, EventArgs e)
        {
            int a = 1;
            int b = -1;
            int c = 0;
            c = this.Teste2(a, ref b);

            MessageBox.Show("a=" + a.ToString() + " b=" + b.ToString() + " c=" + c.ToString());
        }

        // Quais os valores no final das variáveis a, b, c
        private void ButtonExercicio2_3_Click(object sender, EventArgs e)
        {
            int a = 1;
            int b = -1;
            int c = 0;
            c = this.Teste3(ref a, ref b);

            MessageBox.Show("a=" + a.ToString() + " b=" + b.ToString() + " c=" + c.ToString());
        }

        // Quais os valores no final das variáveis a, b, c, d
        private void ButtonExercicio2_4_Click(object sender, EventArgs e)
        {
            int a = 1;
            int b = 2;
            int c = 3;
            int d = 4;

            c = this.Teste3(ref b, ref a);
            d = this.Teste(c, b);
            b = this.Teste2(a, ref b);

            MessageBox.Show("a=" + a.ToString() + " b=" + b.ToString() + " c=" + c.ToString() + " d=" + d.ToString());
        }

        // Quais os valores no final das variáveis a, b, c, d
        private void ButtonExercicio2_5_Click(object sender, EventArgs e)
        {
            int a = 1;
            int b = -1;
            int c = 0;
            int d = 0;

            c = this.Teste(a, b);
            d = this.Teste2(c, ref b);
            b = this.Teste3(ref a, ref b);

            MessageBox.Show("a=" + a.ToString() + " b=" + b.ToString() + " c=" + c.ToString() + " d=" + d.ToString());
        }

        #endregion

        #region Exercicios 3

        // Quais os valores no final das variáveis a, b, c, d
        private void ButtonExercicio3_1_Click(object sender, EventArgs e)
        {
            int a = 1;
            int b = -1;
            int c = 0;
            int d = 0;

            c = this.Teste(a, this.Teste3(ref b, ref d));

            MessageBox.Show("a=" + a.ToString() + " b=" + b.ToString() + " c=" + c.ToString() + " d=" + d.ToString());
        }

        // Quais os valores no final das variáveis a, b, c, d
        private void ButtonExercicio3_2_Click(object sender, EventArgs e)
        {
            int a = 1;
            int b = -1;
            int c = 0;
            int d = 0;

            c = this.Teste(a, this.Teste2(b, ref d));

            MessageBox.Show("a=" + a.ToString() + " b=" + b.ToString() + " c=" + c.ToString() + " d=" + d.ToString());
        }

        // Quais os valores no final das variáveis a, b, c, d
        private void ButtonExercicio3_3_Click(object sender, EventArgs e)
        {
            int a = 1;
            int b = -1;
            int c = 0;
            int d = 0;

            c = this.Teste(this.Teste2(this.Teste3(ref a, ref d), ref a), b);

            MessageBox.Show("a=" + a.ToString() + " b=" + b.ToString() + " c=" + c.ToString() + " d=" + d.ToString());
        }

        #endregion

        #region Exercicios 4

        struct XPTO
        {
            public int a;
            public int b;
        }

        private void T(ref XPTO k)
        {
            int h = 0;

            h = k.a;
            k.b = k.a;
            k.a = h;
        }

        // Quais os valores no final das propriedades a, b do objecto XPTO
        private void ButtonExercicio4_1_Click(object sender, EventArgs e)
        {
            XPTO x;

            x.a = 5;
            x.b = 3;
            x.b += x.a;

            MessageBox.Show("x.a =" + x.a.ToString() + " x.b=" + x.b.ToString());
        }

        // Quais os valores no final das propriedades a, b do objecto XPTO
        private void ButtonExercicio4_2_Click(object sender, EventArgs e)
        {
            XPTO x;

            x.a = 2;
            x.b = 8;
            this.T(ref x);

            MessageBox.Show("x.a =" + x.a.ToString() + " x.b=" + x.b.ToString());
        }

        // Quais os valores no final das propriedades a, b do objecto XPTO
        private void ButtonExercicio4_3_Click(object sender, EventArgs e)
        {
            XPTO x;

            x.a = 0;
            x.a += 1;
            x.b = 3 + x.a;

            this.T(ref x);

            MessageBox.Show("x.a =" + x.a.ToString() + " x.b=" + x.b.ToString());
        }

        #endregion

        #region Exercicios 5

        private void W(int x, int y, int z, out XYZ xyz)
        {
            xyz = new XYZ();

            xyz.a = x;
            xyz.b = y;
            xyz.c = z;
        }

        private void ButtonExercicio5_1_Click(object sender, EventArgs e)
        {
            int h = 2;
            int i = 7;
            int j = 3;
            XYZ k = new XYZ(5, 5, 5);

            this.W(h, i, j, out k);

            MessageBox.Show("k.a =" + k.a.ToString() + " k.b=" + k.b.ToString() + " k.c=" + k.c.ToString());
        }

        #endregion
    }
}
