﻿using System.Windows.Controls;

using System.Collections.ObjectModel;


namespace BigFiveQ.Controls.Respuesta
{
    public partial class RadioButtonList : UserControl
    {
        public RadioButtonList()
        {
            InitializeComponent();
        }

        public ObservableCollection<ISelectableItem> Items
        {
            get
            {
                ObservableCollection<ISelectableItem> viewModel =
                    this.DataContext as ObservableCollection<ISelectableItem>;

                if (viewModel == null)
                {
                    viewModel = new ObservableCollection<ISelectableItem>();

                    this.DataContext = viewModel;
                }

                return viewModel;
            }
        }
    }
}
