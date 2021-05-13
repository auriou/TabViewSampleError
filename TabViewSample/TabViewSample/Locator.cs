using System;
using System.Collections.Generic;
using System.Text;
using TabViewSample.ViewModels;

namespace TabViewSample
{
    public class Locator
    {
        public MainViewModel MainViewModel => new MainViewModel();
        public OneViewModel OneView => new OneViewModel();
        public TwoViewModel TwoView => new TwoViewModel();
    }
}
