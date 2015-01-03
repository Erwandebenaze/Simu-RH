using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OxyPlot;
using OxyPlot.WindowsForms;
using SRH.Core;
using OxyPlot.Series;
using OxyPlot.Axes;

namespace SRH.Interface
{
    public partial class UcGraph : UserControl
    {
        Company _currentComp;

        public Company CurrentComp
        {
            get { return _currentComp; }
            set { _currentComp = value; }
        }
        public UcGraph()
        {
            InitializeComponent();
        }
        IGameContext GameContext
        {
            get { return (IGameContext)TopLevelControl; }
        }

        protected override void OnLoad( EventArgs e )
        {
            if( this.IsInRuntimeMode() )
            {
                base.OnLoad( e );
                LoadUc();
            }
        }

        private void LoadUc()
        {
            PlotView graph = new OxyPlot.WindowsForms.Plot();
            graph.Model = new PlotModel();
            graph.Dock = DockStyle.Fill;
            this.Controls.Add( graph );

            graph.Model.PlotType = PlotType.XY;


            // Create Line series
            var s1 = new LineSeries { Title = "LineSeries", StrokeThickness = 1 };
            s1.Points.Add( new DataPoint( 2, 7 ) );
            s1.Points.Add( new DataPoint( 7, 9 ) );
            s1.Points.Add( new DataPoint( 9, 4 ) );

            // add Series and Axis to plot model
            graph.Model.Series.Add( s1 );
            graph.Model.Axes.Add( new LinearAxis( AxisPosition.Bottom, 0.0, 10.0 ) );
            graph.Model.Axes.Add( new LinearAxis( AxisPosition.Left, 0.0, 10.0 ) );
        }

    }
}
