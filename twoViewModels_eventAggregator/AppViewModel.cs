using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using System.ComponentModel.Composition;
using System.Windows.Media;

namespace twoViewModels_eventAggregator
{
    [Export(typeof(AppViewModel))]
    public class AppViewModel : PropertyChangedBase, IHandle<ColorEvent>//,IHandle<SampleMessage>
    {

        private SolidColorBrush _Color;
        public SolidColorBrush Color
        {
            get { return _Color; }
            set
            {
                _Color = value;
                NotifyOfPropertyChange(() => Color);
            }
        }

        [ImportingConstructor]
        public AppViewModel(ColorViewModel colorModel, IEventAggregator events)
        {
            ColorModel = colorModel;

            events.Subscribe(this);
        }


        public ColorViewModel ColorModel { get; private set; }

        public void Handle(ColorEvent message)
        {
            Color = message.Color;
        }



        /// <summary>
        /// 下面是测试的
        /// </summary>
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

        //public void Handle(SampleMessage message)
        //{
        //    Name = message.Name;
        //}

    }


 
}
