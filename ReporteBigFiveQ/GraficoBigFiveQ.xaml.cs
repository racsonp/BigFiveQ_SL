using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace ReporteBigFiveQ
{
    public partial class GraficoBigFiveQ : UserControl
    {
        public GraficoBigFiveQ()
        {
            InitializeComponent();

            //   CreaSampleData();

        }
        public void Run(List<IDimencion> dimenciones)
        {
            _dimenciones = dimenciones;
            _rows = _dimenciones.Count();
            GeneraContextoGrafico();
            DibujaDimenciones();
        }


        public void CreaSampleData()
        {
            var dimenciones = new List<IDimencion>
                                {
                                    new Energia {Puntos = 37}
                                    ,new Afabilidad{ Puntos = 56}
                                    ,new Teson {Puntos = 43}
                                    ,new EstabilidadEmocional{Puntos = 34}
                                    ,new AperturaMental {Puntos = 44}
                                    ,new Distorcion{Puntos= 37 }
                                };
            _dimenciones = dimenciones;
            _rows = _dimenciones.Count();
        }

        private List<IDimencion> _dimenciones;
        public List<IDimencion> Dimenciones
        {
            get { return _dimenciones; }
            set { _dimenciones = value; }
        }
        private const int DistanciaY = 30;
        private const int DistanciaX = 12;
        //     private const int DistanciaX = 15;
        private int _rows;
        private const int Columns = 51;
        private const int RadioNormal = 2;
        private const int RadioGrande = 7;

        public void DibujaDimenciones()
        {
            if (_dimenciones != null)
            {
                //dibuja los puntos
                foreach (var dimencion in _dimenciones)
                {
                    DibujaPuntajeDimencion(dimencion);
                    DibujaTexto(dimencion.Simbolo, dimencion.Puntos.ToString());
                }
                //une los puntos (dibuja las lineas entre puntos)
                var color = new SolidColorBrush(Colors.Black);
                // ToDo: verificar el orden de cada elementos  en la collection de IDimenciones _diemnciones.OrderBY(x => x.Orden)  TEST TEST TEST           
                for (var i = 0; i < (_dimenciones.Count - 1); i++)
                {
                    var coordenada1 = CalculaCoordenadas(_dimenciones[i]);
                    var coordenada2 = CalculaCoordenadas(_dimenciones[i + 1]);
                    DibujaUnaLinea(coordenada1.X + 2, coordenada1.Y + 2, coordenada2.X + 2, coordenada2.Y + 2, 3, color);
                }
            }
            else
            {
                CreaSampleData();
            }
        }
        private void DibujaPuntajeDimencion(IDimencion dimencion)
        {
            var colorFill = new SolidColorBrush(Colors.Black);
            var pocion = CalculaCoordenadas(dimencion);
            GraficaUnPunto(pocion.X, pocion.Y, RadioGrande, 2, colorFill);
        }
        private static Posicion CalculaCoordenadas(IDimencion dimencion)
        {
            var y = ((dimencion.Orden * DistanciaY) - 2);
            var x = (((dimencion.Puntos - 25) * DistanciaX));
            return new Posicion { X = x, Y = y };
        }
        private void GraficaUnPunto(double posicionX, double posicionY, double radio, int diferencia, SolidColorBrush colorBrush)
        {
            var colorLinea = new SolidColorBrush(Colors.Black);
            var ellipse = new Ellipse { Height = radio, Width = radio, Stroke = colorLinea, StrokeThickness = 2, Fill = colorBrush };
            ellipse.SetValue(Canvas.LeftProperty, posicionX);
            ellipse.SetValue(Canvas.TopProperty, posicionY - diferencia);
            AgregaElemento(ellipse);
        }
        private void DibujaTexto(string dimencion, string puntos)
        {
            var margen = new Thickness(0, 3, 0, 0);
            var textDimencion = new TextBlock { Height = DistanciaY, Text = dimencion, FontSize = 12.0, Margin = margen, HorizontalAlignment = HorizontalAlignment.Center, VerticalAlignment = VerticalAlignment.Center, TextAlignment = TextAlignment.Center };
            var textPuntos = new TextBlock { Height = DistanciaY, Text = puntos, FontSize = 12.0, Margin = margen, HorizontalAlignment = HorizontalAlignment.Center, VerticalAlignment = VerticalAlignment.Center, TextAlignment = TextAlignment.Center };
            var textPd = new TextBlock { Height = DistanciaY, Text = "", FontSize = 12.0, Margin = margen, HorizontalAlignment = HorizontalAlignment.Center, VerticalAlignment = VerticalAlignment.Center, TextAlignment = TextAlignment.Center };
            DimPanel.Children.Add(textDimencion);
            tPanel.Children.Add(textPuntos);
            pdPanel.Children.Add(textPd);
        }
        private void AgregaElemento(UIElement ui)
        {
            Grafico.Children.Add(ui);
        }
        private void DibujaUnaLinea(double x1, double y1, double x2, double y2, int grueso, SolidColorBrush colorBrush)
        {
            var linea = new Line { X1 = x1, Y1 = y1, X2 = x2, Y2 = y2, StrokeThickness = grueso, Stroke = colorBrush };
            AgregaElemento(linea);
        }
        public void GeneraContextoGrafico()
        {
            DibujaRows();
            DibujaColumns();

            var color = new SolidColorBrush(Colors.White);
            //Dibuja  los puntoas en Y
            for (var y = 1; y < _rows + 1; y++)
            //  for (var y = 1; y < _dimenciones.Count; y++)
            {
                // var para distingir los puntos mas grandes del grafico segun ejemplo del BFQ lo hace cada 15 desde 5
                var circuloGrande = 5;
                // Separacion en Y distancia entre cada punto Y
                var posicionY = Convert.ToDouble(DistanciaY * y);

                //Dibuja  los puntoas en X
                for (var x = 0; x < Columns; x++)
                {
                    // Separacion en X distancia entre cada punto X                                   
                    var posiciconX = Convert.ToDouble(DistanciaX * x);
                    if (circuloGrande == x)
                    {
                        circuloGrande = circuloGrande + 10;
                        GraficaUnPunto(posiciconX, posicionY, RadioGrande, 2, color);
                    }
                    else
                    {
                        GraficaUnPunto(posiciconX, posicionY, RadioNormal, 0, color);
                    }
                }
            }
        }
        private void DibujaColumns()
        {
            // <Line  X1="15"   X2="15"  Y1="15"  Y2="180" Stroke="Red" StrokeThickness="1" />
            //<Line  X1="165" X2="165" Y1="15"  Y2="180" Stroke="Red" StrokeThickness="1" />
            //<Line  X1="315" X2="315" Y1="15"  Y2="180" Stroke="Red" StrokeThickness="1" />
            //............
            //<Line  X1="765" X2="765" Y1="15"  Y2="180" Stroke="Red" StrokeThickness="1" />

            var color = new SolidColorBrush(Colors.Purple);
            var x = (DistanciaX * 10);
            int y = DistanciaY * (_rows + 1);// 180 =30*6 == y2*x2   
            //for (var i = 0; i < Rows; i++)
            // son 6 comumas fijas segun BFQ => Muy bajoajo Pr..
            for (var i = 0; i < 6; i++)
            {
                if (i == 0)
                {
                    DibujaUnaLinea(0, 0, 0, y, 1, color);
                }
                else
                {
                    DibujaUnaLinea(x, 0, x, y, 1, color);
                    x = x + (DistanciaX * 10);
                }
            }

        }
        private void DibujaRows()
        {
            // <Line  X1="15"   X2="765"  Y1="15"  Y2="15" Stroke="Red" StrokeThickness="1" />
            //<Line  X1="15"   X2="765"  Y1="180"  Y2="180" Stroke="Red" StrokeThickness="1" />-->
            var color = new SolidColorBrush(Colors.Purple);
            var x1 = 0;// DistanciaX;
            var y1 = 0;
            var x2 = ((DistanciaX * Columns) - DistanciaX); //15*51 ==765
            var y2 = DistanciaY * (_rows + 1);
            var linea1 = new Line { X1 = x1, Y1 = x1, X2 = x2, Y2 = x1, Stroke = color };
            var linea2 = new Line { X1 = x1, Y1 = y1, X2 = x2, Y2 = y1, Stroke = color };

            AgregaElemento(linea1);
            AgregaElemento(linea2);
        }
    }
}
