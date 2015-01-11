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
        PlotView graph;
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

        internal void LoadUc()
        {
            if( _currentComp == null )
                _currentComp = GameContext.CurrentGame.PlayerCompany;

            if( graph == null )
            {
                LoadGraph( true );
            }
            else
                LoadGraph( false );

        }

        private void LoadGraph( bool n )
        {
            if( n )
            {
                graph = new OxyPlot.WindowsForms.PlotView();
            }
            graph.Model = new PlotModel();
            graph.Dock = DockStyle.Fill;
            var plotModel1 = new PlotModel();
            graph.Model.LegendSymbolLength = 24;
            graph.Model.Title = _currentComp.Name;
            var linearAxis1 = new LinearAxis();
            linearAxis1.Position = AxisPosition.Bottom;
            linearAxis1.MajorStep = 1;
            linearAxis1.Minimum = 1;
            linearAxis1.Maximum = 12;
            linearAxis1.MinorStep = 1;
           // linearAxis1.Maximum = 12;
            plotModel1.Axes.Add( linearAxis1 );
            var linearAxis2 = new LinearAxis();
            graph.Model.Axes.Add( linearAxis2 );
            var lineSeries1 = new LineSeries();
            lineSeries1.MarkerType = MarkerType.Circle;
            lineSeries1.Smooth = true;
            lineSeries1.Points.Add( new DataPoint( 1, _currentComp.WealthInYear.January ) );
            lineSeries1.Points.Add( new DataPoint( 2, _currentComp.WealthInYear.February ) );
            lineSeries1.Points.Add( new DataPoint( 3, _currentComp.WealthInYear.March ) );
            lineSeries1.Points.Add( new DataPoint( 4, _currentComp.WealthInYear.April ) );
            lineSeries1.Points.Add( new DataPoint( 5, _currentComp.WealthInYear.May ) );
            lineSeries1.Points.Add( new DataPoint( 6, _currentComp.WealthInYear.June ) );
            lineSeries1.Points.Add( new DataPoint( 7, _currentComp.WealthInYear.July ) );
            lineSeries1.Points.Add( new DataPoint( 8, _currentComp.WealthInYear.August ) );
            lineSeries1.Points.Add( new DataPoint( 9, _currentComp.WealthInYear.September ) );
            lineSeries1.Points.Add( new DataPoint( 10, _currentComp.WealthInYear.October ) );
            lineSeries1.Points.Add( new DataPoint( 11, _currentComp.WealthInYear.November ) );
            lineSeries1.Points.Add( new DataPoint( 12, _currentComp.WealthInYear.December ) );
            graph.Model.Series.Add( lineSeries1 );
            this.Controls.Add( graph );
        }

    }
}
