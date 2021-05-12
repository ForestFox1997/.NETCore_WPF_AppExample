using ExcelDataHandler.ViewModel;
using GalaSoft.MvvmLight.Ioc;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExcelDataHandler.ViewModel
{
    class ViewModelLocator
    {
        public ViewModelLocator()
        {
            SimpleIoc.Default.Register<MainViewModel>();
        }

        public MainViewModel MainViewModel
        {
            get
            {
                if (!SimpleIoc.Default.IsRegistered<MainViewModel>())
                {
                    SimpleIoc.Default.Register<MainViewModel>();
                }
                return SimpleIoc.Default.GetInstance<MainViewModel>();
            }
        }
    }
}
