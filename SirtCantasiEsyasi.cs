using System;

namespace SirtCantasi
{
    public struct SirtCantasiEsyasi : IComparable<SirtCantasiEsyasi>
    {
        private int _id;
        private int _deger;
        private int _agirlik;
        private string _secildiMi;

        public int Id
        {
            get
            {
                return _id;
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

        public string SelectionText
        {
            get
            {
                return _secildiMi;
            }
            set
            {
                _secildiMi = value;
            }
        }

        public SirtCantasiEsyasi(int id, int Deger, int Agirlik)
        {

            if (Deger <= 0 || Agirlik <= 0)
                throw new ArgumentException("Deger ve Agirlik degerleri pozitif olmalidir.");

            else
            {
                _id = id;
                _deger = Deger;
                _agirlik = Agirlik;
                _secildiMi = "";
            }
        }

        public int CompareTo(SirtCantasiEsyasi item)
        {

            long side1 = (long)this.Deger * item.Agirlik;
            long side2 = (long)item.Deger * this.Agirlik;

            if (side1 == side2)
            {
                if (this.Deger < item.Deger || this.Agirlik < item.Agirlik)
                    return -1;

                else if (this.Deger > item.Deger || this.Agirlik > item.Agirlik)
                    return 1;

                else
                    return 0;
            }

            else if (side1 > side2)
                return -1;

            else
                return 1;

        }
    }
}
