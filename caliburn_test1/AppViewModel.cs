using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
namespace caliburn_test1
{
    public class AppViewModel:PropertyChangedBase
    {
        private int _count = 50;
        public int Count
        {
            get { return _count; }
            set
            {
                _count = value;
                NotifyOfPropertyChange(() => Count);
                //NotifyOfPropertyChange(()=>CanIncrementCount);
            }
        }

        public void IncrementCount(int delta)
        {
            Count+=delta;
            //if(Count==60)
            //{
            //    Count = 0;
            //}
        }

        //public bool CanIncrementCount
        //{
        //    get { return Count < 60; }
        //}
    }
}
