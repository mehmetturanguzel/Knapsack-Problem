using System.Collections.Generic;

namespace SirtCantasi
{
    public class YedekCozum
    {

        private int _index;
        private int _deger = 0;
        private int _agirlik = 0;
        private YedekCozum _onceki;

        public int Index
        {
            get
            {
                return _index;
            }
        }

        public int Deger
        {
            get
            {
                return _deger;
            }
        }

        public int Agirlik
        {
            get
            {
                return _agirlik;
            }
        }

        public YedekCozum Onceki
        {
            get
            {
                return _onceki;
            }
        }

        public YedekCozum(List<SirtCantasiEsyasi> esyalar, int index, YedekCozum onceki)
        {
            if (index == -1)
            {
                _index = index;
                _deger = 0;
                _agirlik = 0;
                _onceki = null;
            }

            else
            {
                _index = index;
                _deger = onceki.Deger + esyalar[index].Deger;
                _agirlik = onceki.Agirlik + esyalar[index].Agirlik;
                _onceki = onceki;
            }
        }
    }
}
