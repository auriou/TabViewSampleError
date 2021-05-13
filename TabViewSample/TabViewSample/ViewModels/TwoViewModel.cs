using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MvvmHelpers;
using MvvmHelpers.Commands;

namespace TabViewSample.ViewModels
{
    public class TwoViewModel : BaseViewModel
    {
        private int _countClick;

        public int CountClick
        {
            get => _countClick;
            set => SetProperty(ref _countClick, value);
        }
        public ICommand ClickCommand => new AsyncCommand(Click);

        private Task Click()
        {
            CountClick++;
            return Task.CompletedTask;
        }

        public TwoViewModel()
        {
                
        }
    }
}
