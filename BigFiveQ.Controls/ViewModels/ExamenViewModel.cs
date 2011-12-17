using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using BigFiveQ.Controls.ExamenBfqService;


/*
 find an UIElement using Linq
  http://stackoverflow.com/questions/4631721/silverlight-how-to-find-an-uielement-using-linq
 IEnumerable<UIElement> textboxes =
         from c in this.LayoutRoot.Children
         where c.GetType() == typeof(TextBox)
         select c;
*/



namespace BigFiveQ.Controls.ViewModels
{
    public class ExamenViewModel :ViewModel
    {
        
       private Examen _examen;
        public Examen Examen
        {
            get { return _examen; }
            set { _examen = value; NotifyPropertyChanged("Examen"); }
        }

        public event  EventHandler ExamenLoaded;
        public void CargarExamen()
        {
            var client = new ExamenBfqServiceClient();
            client.GetExamenCompleted += (s, ea) =>
                                             {
                                                 Examen = ea.Result;
                                                 OnLoadedExamen();
                                             };
            client.GetExamenAsync();
        }

      protected void OnLoadedExamen()
        {
            if (ExamenLoaded != null)
                ExamenLoaded(this, EventArgs.Empty);
        }


        /// <summary>
        /// ENVIO DE EXAMEN
        /// </summary>


        private string _mensage;
        public string Mensage
        {
            get { return _mensage; }
            set
            {
                if (Mensage == value)
                {
                    return;
                }              
                _mensage = value; NotifyPropertyChanged("Mensage");
            }
        }
        private static int GetRespuestaSeleccionada(IEnumerable<RadioButton> contestaciones)
        {
            var punto = 0;
            foreach (var contestacion in contestaciones)
            {
                if (contestacion.IsChecked != null)
                    if ((bool)contestacion.IsChecked)
                    {
                        punto = Convert.ToInt32(contestacion.Tag);
                    }
            }

            return punto;
        }
        public void CommitExamen(IEnumerable<UIElement> uiElements, string user)
        {
            var contestaciones = new ObservableCollection<Contestacion>();
            foreach (var uiElement in uiElements)
            {

                var grid = (Grid) uiElement;
                var textBlock = grid.FindName("Index") as TextBlock;

                if (textBlock != null)
                {
                    var r1 = grid.FindName("r1") as RadioButton;
                    var r2 = grid.FindName("r2") as RadioButton;
                    var r3 = grid.FindName("r3") as RadioButton;
                    var r4 = grid.FindName("r4") as RadioButton;
                    var r5 = grid.FindName("r5") as RadioButton;

                    var posiblesrespuestas =
                        new List<RadioButton> {r1, r2, r3, r4, r5};
                    var contestacion = new Contestacion
                                           {
                                               NumeroPregunta = Convert.ToInt32(textBlock.Text)
                                               ,RepuestaSeleccionada =   GetRespuestaSeleccionada(posiblesrespuestas)
                                             
                                           };
                    contestaciones.Add(contestacion);
                }

            }

            SendExamen(contestaciones,user);
   
          
        }

      public event EventHandler ExamenSent;
      private void SendExamen(ObservableCollection<Contestacion> respuestas, string user)
        {
            var client = new ExamenBfqServiceClient();
            client.CommitExamenCompleted += (s, ea) =>
                                                {
                                                    Mensage = ea.Result;
                                                    OnSentExamen();
                                                };
          client.CommitExamenAsync(respuestas,user);

        }

        protected void OnSentExamen()
        {
            if (ExamenSent != null)
                ExamenSent(this, EventArgs.Empty);
        }
    }
}
