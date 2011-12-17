using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using BigFiveQ.Controls.ViewModels;

namespace BigFiveQ.Controls.ExamenBfqUi
{
    public delegate void WizardPageEvent(Wizard sender, WizardEventArgs e);

    public partial class Wizard : UserControl
    {
        int _iCurrentPage = 0;

        public event WizardPageEvent PageEvent;
     
        public Wizard()
        {
            // Initialise page storage
            // -------------------------------
            this.Pages = new List<UserControl>();

            InitializeComponent();

            btNext.Click += OnNextClick;
            btPrevious.Click += OnPreviousClick;

            Loaded += OnLoaded;
          
        }


        public static readonly DependencyProperty TitleProperty =
           DependencyProperty.RegisterAttached("Title", typeof(string), typeof(Wizard), null);

        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set
            {
                SetValue(TitleProperty, value);
                txtTitle.Text = (string)value;
            }
        }

        public static readonly DependencyProperty PagesProperty =
            DependencyProperty.RegisterAttached("Pages", typeof(List<UserControl>), typeof(Wizard), null);

        public List<UserControl> Pages
        {
            get { return (List<UserControl>)GetValue(PagesProperty); }
            set { SetValue(PagesProperty, value); }
        }

        void OnLoaded(object sender, RoutedEventArgs e)
        {
            UpdateView();
        }

        void OnNextClick(object sender, RoutedEventArgs e)
        {
            if (_iCurrentPage == Pages.Count - 1)
            {
                FirePageEvent(_iCurrentPage, -1, WizardAction.Finish);
            }
            else
            {
                if (FirePageEvent(_iCurrentPage, _iCurrentPage + 1, WizardAction.Next))
                {
                    _iCurrentPage++;

                    UpdateView();
                }
            }
        }

        void OnPreviousClick(object sender, RoutedEventArgs e)
        {
            if (FirePageEvent(_iCurrentPage, _iCurrentPage - 1, WizardAction.Previous))
            {
                _iCurrentPage--;

                UpdateView();
            }
        }

        bool FirePageEvent(int iCurrentPageIndex, int iNewPageIndex, WizardAction eAction)
        {
            WizardEventArgs oArgs =
                    new WizardEventArgs(iCurrentPageIndex, iNewPageIndex, eAction);

            if (PageEvent != null)
                PageEvent(this, oArgs);

            if (eAction == WizardAction.Finish)
            Procesar();

            return !oArgs.Cancel;
        }

 
        void UpdateView()
        {
            ctrPageHost.SwitchPage(Pages[_iCurrentPage]);

            if (_iCurrentPage == 0)
                btPrevious.IsEnabled = false;
            else if (_iCurrentPage == Pages.Count - 1)
                btNext.Content = "Finalizar";
            else
            {
                btPrevious.IsEnabled = true;
                btNext.Content = "Siguiente";
            }
        }

        private void Procesar()
        {
            var contestacionesControl = new List<UIElement>();
            foreach (var uiElement in this.Pages)
            {
                contestacionesControl.Add(uiElement.Content);
            }

            var viewModel = new ExamenViewModel();


            string r = null;

            viewModel.ExamenSent += (s, ea) =>
            {
                LoadingProgress.Visibility = Visibility.Collapsed;
                r = viewModel.Mensage;
                MessageBox.Show(r.ToString());
                this.btPrevious.IsEnabled = false;
                this.btNext.IsEnabled = false;
                
            };
            LoadingProgress.Visibility = Visibility.Visible;
            this.btPrevious.IsEnabled = false;
            this.btNext.IsEnabled = false;
            viewModel.CommitExamen(contestacionesControl, IdUser);


        }

        public string IdUser { get; set; }
    }

}
