using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class JukeBox
    {
        public List<IVinylSingle> Singles = new List<IVinylSingle>();
        private IVinylSingle CurrentSingle = null;

        public JukeBox(List<IVinylSingle> singles)
        {
            this.Singles = singles;
        }

        public void Play()
        {
            CurrentSingle.Play();
        }

        public void SelectSingle(int index)
        {
            CurrentSingle = Singles[index - 1];
        }

        public void Stop()
        {
            CurrentSingle.Stop();
        }
    }
}
