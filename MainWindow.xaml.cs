using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Falcon.Data.Sqlite;

namespace DPHD
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Database database;
        public MainWindow()
        {
            InitializeComponent();
            InitialDatabase();
        }
        public void InitialDatabase()
        {
            Table employee = new Table("employee");
            employee.AddColumn("id", ColumnType.INTEGER);
            employee.AddColumn("permission", ColumnType.INTEGER);
            employee.AddColumn("first_name", ColumnType.TEXT);
            employee.AddColumn("last_name", ColumnType.TEXT);
            employee.AddColumn("age", ColumnType.INTEGER);
            employee.AddColumn("user_name", ColumnType.TEXT);
            employee.AddColumn("password", ColumnType.TEXT);
            database = new Database("DPHD", "Main");
            database.CreateTable(employee);
        }
    }
}