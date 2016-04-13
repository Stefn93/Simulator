using Simulation.CellGUI;
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

namespace Simulation.GridGUI
{
    /// <summary>
    /// Logica di interazione per DynamicGridUserControl.xaml
    /// </summary>
    public partial class Grid : UserControl
    {
        public static event ChangeGridHandler OnChangeGrid;
        public delegate void ChangeGridHandler();
        private GridCell[,] cells = new GridCell[160,80];

        public Grid()
        {
            InitializeComponent();
            grid.Background = new SolidColorBrush(Color.FromRgb(237,237,237));

            OnChangeGrid += Update; // registra il metodo Update al verificarsi dell'evento OnchangedGrid
        }

        #region dependency properties
        public int rows
        {
            get { return (int)GetValue(rowsProperty); }
            set { SetValue(rowsProperty, value); }
        }

        public static readonly DependencyProperty rowsProperty = DependencyProperty.Register("rows", typeof(int),
            typeof(Grid), new PropertyMetadata(0, ExamplePropertyChangedCallback, ExampleCoerceValueCallBack));

        public int columns
        {
            get { return (int)GetValue(columnsProperty); }
            set { SetValue(columnsProperty, value); }
        }

        public static readonly DependencyProperty columnsProperty = DependencyProperty.Register("columns", typeof(int), 
            typeof(Grid), new PropertyMetadata(0, ExamplePropertyChangedCallback, ExampleCoerceValueCallBack));
        #endregion 

        //rilascia l'evento che farà modifcare griglia
        private static void ExamplePropertyChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (OnChangeGrid != null)
                OnChangeGrid();
        }

        //validazione del set della dependency property
        private static object ExampleCoerceValueCallBack(DependencyObject d, object value)
        {
            return value;
        }

        private void Update()
        {
            grid.RowDefinitions.Clear();
            grid.ColumnDefinitions.Clear();


            for (int i = 0; i < rows; i++)
            {
                grid.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(10, GridUnitType.Auto) });
            }

            for (int i = 0; i < columns; i++)
            {
                grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(10, GridUnitType.Auto) });
            }

            //int TotalItems = rows * columns;
            GridCell PreviousItem = null;
            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    GridCell cell = new GridCell();

                    //int rowValue = 0;
                    //int columnValue = 0;

                    //if (i != 0 && j != 0)
                    //{
                    //    int PreviousRowValue = System.Windows.Controls.Grid.GetRow(PreviousItem.getRectangle());
                    //    int PreviousColumnValue = System.Windows.Controls.Grid.GetColumn(PreviousItem.getRectangle());

                    //    //rowValue = PreviousColumnValue < (columns - 1) ? PreviousRowValue : PreviousRowValue += 1;
                    //    //columnValue = PreviousColumnValue < (columns - 1) ? PreviousColumnValue += 1 : 0;
                    //}

                    System.Windows.Controls.Grid.SetColumn(cell.getRectangle(), i);
                    System.Windows.Controls.Grid.SetRow(cell.getRectangle(), j);
                    cells[i, j] = cell;
                    //cell.setX(columnValue);
                    //cell.setY(rowValue);

                    PreviousItem = cell;
                    grid.Children.Add(cell.getRectangle());
                }
            }
            Console.WriteLine(cells[0, 0]);
            //cells[0, 0].getRectangle().Fill = new SolidColorBrush(Colors.Black);
        }

        public GridCell getCell(int x, int y)
        {
            return cells[x, y];
        }

        public System.Windows.Controls.Grid getGrid()
        {
            return grid;
        }

        public void setGrid(System.Windows.Controls.Grid grid)
        {
            this.grid = grid;
        }

    }
}
