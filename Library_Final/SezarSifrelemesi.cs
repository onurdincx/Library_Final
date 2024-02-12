using System;
using System.Collections.Generic;
using System.Text;

namespace Library_Final
{
    class SezarSifrelemesi
    {
        public static string Sifreleme(string text,int key) //classi hep tanimlamamak icin static yazdik. publici heryerde kullanmak icin yaziyoruz
        {
            char[] x = text.ToCharArray();
            string SifrelemeText = null;

            foreach (char item in x) //x dizinin adi
            {
                SifrelemeText += Convert.ToChar(item + key); //char oldugu icin null'e eklememiz lazim o yuzden + kullandim ( abc -> a b c null olur yoksa )
            }
            return SifrelemeText;
        }

        public static string SifreyiCoz(string text,int key)
        {
            char[] x = text.ToCharArray();
            string SifreyiCozText = null;

            foreach (char item in x)
            {
                SifreyiCozText += Convert.ToChar(item - key); //sifreyi cozmek istedigim icin + yerine - kullandim.
            }
            return SifreyiCozText;
        }
    }
}
