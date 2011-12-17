using System;

using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using BigFiveQ.Controls.ViewModels;


namespace BigFiveQ.Controls
{

    public partial class BigFiveQControl : UserControl
    {

        public BigFiveQControl()
        {
           InitializeComponent();
          LlamaServicios();

        }

        private void LlamaServicios()
        {
            _viewModel = new ExamenViewModel();
            CargarExamen();

        }

        private ObservableCollection<SelectableItem> _respuestas;
        public string IdUssuario { get; set; }

        private ExamenViewModel _viewModel;

       public void CargarExamen()
       {
               _viewModel.ExamenLoaded += (s, ea) =>
                                              {
                                                  LoadingProgress.Visibility = Visibility.Collapsed;
                                                  CaragarRespuestasUi(_viewModel);
                                                  CargarPreguntasUi(_viewModel);
                                              };
 
               LoadingProgress.Visibility = Visibility.Visible;
               _viewModel.CargarExamen();

       }

       private void CaragarRespuestasUi(ExamenViewModel model)
        {            
            _respuestas = new ObservableCollection<SelectableItem>();
           var resultado = model.Examen.Respuestas;
            foreach (var respuesta in resultado)
            {
                _respuestas.Add(new SelectableItem(false, respuesta.Statement, respuesta.Value.ToString()));
            }
        }

    private void CargarPreguntasUi(ExamenViewModel model)
    {

        var resultado = model.Examen.Preguntas;

            foreach (var pregutna in resultado)
            {
                var preguntaN = new ExamenBfqUi.PreguntaControl();

                preguntaN.r1.Content = _respuestas[0].Text;
                preguntaN.r1.Tag = _respuestas[0].Value;


                preguntaN.r2.Content = _respuestas[1].Text;
                preguntaN.r2.Tag = _respuestas[1].Value;


                preguntaN.r3.Content = _respuestas[2].Text;
                preguntaN.r3.Tag = _respuestas[2].Value;


                preguntaN.r4.Content = _respuestas[3].Text;
                preguntaN.r4.Tag = _respuestas[3].Value;


                preguntaN.r5.Content = _respuestas[4].Text;
                preguntaN.r5.Tag = _respuestas[4].Value;

                preguntaN.enunciadoTxt.Text = pregutna.Statement;
                preguntaN.Index.Text = pregutna.Index.ToString();
                ctrlWizard.Pages.Add(preguntaN);

            }
            var endControl = new ExamenBfqUi.EndControl();
            ctrlWizard.Pages.Add(endControl);
            ctrlWizard.IdUser = IdUssuario;

        }
    }

}
