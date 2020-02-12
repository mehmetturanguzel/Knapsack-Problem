using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace SirtCantasi
{
    public partial class UserInterface : Form
    {
        private List<SirtCantasiEsyasi> _items;
        private int _agirlikLimiti;
        private int _toplamDeger;
        private int _toplamAgirlik;

        public UserInterface()
        {
            InitializeComponent();
        }

        public int ReadInput(string filename)
        {
            int bound;
            List<SirtCantasiEsyasi> tmpList = new List<SirtCantasiEsyasi>();

            using (StreamReader sr = new StreamReader(filename))
            {
                Int32.TryParse(sr.ReadLine(), out bound);

                while (!sr.EndOfStream)
                {
                    string[] pieces = sr.ReadLine().Split(',');
                    SirtCantasiEsyasi newItem = new SirtCantasiEsyasi(Convert.ToInt32(pieces[0]), Convert.ToInt32(pieces[1]), Convert.ToInt32(pieces[2]));
                    tmpList.Add(newItem);
                }

                tmpList.Sort();
            }

            _items = tmpList;
            return bound;
        }

        public int ComputeBounds(YedekCozum toCompute, ref YedekCozum best)
        {
            int i = toCompute.Index + 1;

            while (i < _items.Count && (toCompute.Agirlik + _items[i].Agirlik) <= _agirlikLimiti)
            {
                YedekCozum newSolution = new YedekCozum(_items, i, toCompute);
                toCompute = newSolution;
                i++;
            }

            if (toCompute.Deger > best.Deger)
            {
                best = toCompute;
            }

            if (i >= _items.Count || toCompute.Agirlik == _agirlikLimiti)
            {
                return toCompute.Deger;
            }

            else
            {
                return (int)(((((long)(_agirlikLimiti - toCompute.Agirlik) * (_items[i].Deger)) - 1) / (_items[i].Agirlik)) + toCompute.Deger);
            }
        }

        public void Solve(string filename)
        {
            _agirlikLimiti = ReadInput(filename);

            YedekCozum candidate = new YedekCozum(_items, -1, null);
            YedekCozum best = candidate;

            OncelikSirasi<int, YedekCozum> queue = new OncelikSirasi<int, YedekCozum>();
            queue.Add(candidate, ComputeBounds(candidate, ref best));

            while (queue.Count > 0 && queue.YuksekOncelik >= best.Deger)
            {
                YedekCozum root = queue.RemoveYuksekOncelik();
                int k = root.Index + 1;

                for (int j = k; j < _items.Count; j++)
                {
                    YedekCozum child = new YedekCozum(_items, j, root);

                    if (child.Agirlik <= _agirlikLimiti)
                    {
                        int childBounds = ComputeBounds(child, ref best);

                        if (childBounds > best.Deger)
                        {
                            queue.Add(child, childBounds);
                        }
                    }
                }

            }

            _toplamDeger = best.Deger;
            _toplamAgirlik = best.Agirlik;

            while (best.Onceki != null)
            {
                SirtCantasiEsyasi tmp = _items[best.Index];

                tmp.SelectionText = "X";
                _items[best.Index] = tmp;
                best = best.Onceki;
            }
        }

        public void ShowSolution()
        {
            uxLimit.Text = _agirlikLimiti.ToString();
            uxTotalValue.Text = _toplamDeger.ToString();
            uxTotalWeight.Text = _toplamAgirlik.ToString();
            uxSolution.Rows.Clear();

            if (uxSolution.SortedColumn != null)
            {
                uxSolution.SortedColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
                uxSolution.SortedColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            }

            uxSolution.Rows.Add(_items.Count);

            for (int i = 0; i < _items.Count; i++)
            {
                float density = _items[i].Deger / (float)_items[i].Agirlik;
                uxSolution.Rows[i].SetValues(_items[i].Id, _items[i].Deger, _items[i].Agirlik, density, _items[i].SelectionText);
            }
        }

        private void uxOpen_Click(object sender, EventArgs e)
        {
            try
            {
                if (uxOpenDialog.ShowDialog() == DialogResult.OK)
                {
                    Solve(uxOpenDialog.FileName);
                    ShowSolution();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void uxSolution_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void uxFileName_TextChanged(object sender, EventArgs e)
        {

        }

        private void uxLimit_TextChanged(object sender, EventArgs e)
        {

        }

        private void uxLimitLabel_Click(object sender, EventArgs e)
        {

        }

        private void uxTotalValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserInterface_Load(object sender, EventArgs e)
        {

        }

        private void uxValueLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
