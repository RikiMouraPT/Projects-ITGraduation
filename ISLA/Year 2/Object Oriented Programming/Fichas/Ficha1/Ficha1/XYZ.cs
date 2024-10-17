namespace Ficha1
{
    internal class XYZ
    {
        public XYZ()
        {
            this.a = 0;
            this.b = 0;
            this.c = 0;
        }

        public XYZ(int a, int b, int c)
            : this()
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public int a { get; set; }
        public int b { get; set; }
        public int c { get; set; }

    }
}
