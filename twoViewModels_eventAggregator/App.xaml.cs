using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Caliburn.Micro;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.ComponentModel.Composition.Primitives;

namespace twoViewModels_eventAggregator
{
    //public class AppBootstrapper:BootstrapperBase
    //{
    //    public AppBootstrapper()
    //    {
    //        Initialize();
    //    }
    //    protected override void OnStartup(object sender, StartupEventArgs e)
    //    {
    //        DisplayRootViewFor<AppViewModel>();
    //    }

    //    private CompositionContainer container;
    //    protected override void Configure()
    //    {
    //        container = new CompositionContainer(new AggregateCatalog(AssemblySource.Instance.Select(x => new AssemblyCatalog(x)).OfType<ComposablePartCatalog>()));
    //        CompositionBatch batch = new CompositionBatch();

    //        batch.AddExportedValue<IWindowManager>(new WindowManager());
    //        batch.AddExportedValue<IEventAggregator>(new EventAggregator());
    //        batch.AddExportedValue(container);

    //        container.Compose(batch);
    //    }

    //    protected override object GetInstance(Type serviceType, string key)
    //    {
    //        string contract = string.IsNullOrEmpty(key) ? AttributedModelServices.GetContractName(serviceType) : key;
    //        var exports = container.GetExportedValues<object>(contract);

    //        if (exports.Count() > 0)
    //        {
    //            return exports.First();
    //        }

    //        throw new Exception(string.Format("Could not locate any instances of contract {0}.", contract));
    //    }
    //}
    
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
    }
}
