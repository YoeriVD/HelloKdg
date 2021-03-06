﻿using Autofac;
using HelloKdg.Main;
using HelloKdg.NavigateDemo;

namespace HelloKdg
{
    internal static class ViewModelLocator
    {
        internal static IMainViewModel MainViewModel => Resolve<IMainViewModel>();
        internal static IDemoViewModel DemoViewModel => Resolve<IDemoViewModel>();

        private static T Resolve<T>()
        {
            return App.Container.Resolve<T>();
        }
    }
}