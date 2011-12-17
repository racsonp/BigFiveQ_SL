using System;

using System.Windows;
using System.Windows.Controls;


namespace BigFiveQ.Controls
{
    public partial class ExamenBFQWindow : ChildWindow
    {
        public ExamenBFQWindow()
        {
            InitializeComponent();
         
        }


        public void InjectUser()
        {
            this.Examen.IdUssuario = NombreUsuario;
        }


        public string NombreUsuario { get; set; }
        public string IdUsuario { get; set; }
        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}

