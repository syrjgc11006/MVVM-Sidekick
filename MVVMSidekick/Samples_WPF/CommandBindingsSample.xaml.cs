﻿using System.Reactive;
using System.Reactive.Linq;
using MVVMSidekick.ViewModels;
using MVVMSidekick.Views;
using MVVMSidekick.Reactive;
using MVVMSidekick.Services;
using MVVMSidekick.Commands;
using Samples.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Samples
{
    /// <summary>
    /// Interaction logic for CommandBindingsSample.xaml
    /// </summary>
    public partial class CommandBindingsSample : MVVMWindow
    {
        public CommandBindingsSample()
            : base(null)
        {
            InitializeComponent();
        }

        public CommandBindingsSample(CommandBindingsSample_Model model)
            : base(model)
        {
            InitializeComponent();
        }
    }
}
