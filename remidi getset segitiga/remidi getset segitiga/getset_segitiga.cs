using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace remidi_getset_segitiga
{
    class getset_segitiga
    {
        private double alas;
        private double tinggi;
        private double skn;
        private double ski;

        public double getalas ()
        {
            return alas;
        }

        public double setalas(double nalas)
        {
            alas += nalas;
            return nalas;
        }

        public double gettinggi()
        {
            return tinggi;
        }

        public double setinggi(double ntinggi)
        {
            tinggi += ntinggi;
            return ntinggi;
        }

        public double getskn()
        {
            return skn;
        }

        public double setskn(double nskn)
        {
            skn += nskn;
            return nskn;
        }

        public double getski()
        {
            return ski;
        }

        public double setski(double nski)
        {
            ski += nski;
            return nski;
        }

    }
}
