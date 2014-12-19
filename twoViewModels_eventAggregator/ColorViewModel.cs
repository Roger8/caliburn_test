using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Composition;
using Caliburn.Micro;
using System.Windows.Media;
namespace twoViewModels_eventAggregator
{
    [Export(typeof(ColorViewModel))]
    public class ColorViewModel:PropertyChangedBase
    {
        private readonly IEventAggregator _events;

        [ImportingConstructor]
        public ColorViewModel(IEventAggregator events)
        {
            _events = events;
        }

        public void Red()
        {
            _events.PublishOnUIThread(new ColorEvent(new SolidColorBrush(Colors.Red)));
        }

        public void Green()
        {
            _events.PublishOnUIThread(new ColorEvent(new SolidColorBrush(Colors.Green)));
        }

        public void Blue()
        {
            _events.PublishOnUIThread(new ColorEvent(new SolidColorBrush(Colors.Blue)));
        }
        //textbox name convention
        
        //private string name;

        //public string Name
        //{
        //    get { return name; }
        //    set
        //    {
        //        name = value;
        //        NotifyOfPropertyChange(() => Name);
        //    }
        //}

        //public void SendMessage()
        //{
        //    _events.PublishOnUIThread(new SampleMessage("dddd"));
        //}
    }
}
