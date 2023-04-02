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
using System.Windows.Shapes;

namespace AdoProj
{
    /// <summary>
    /// Логика взаимодействия для Insert.xaml
    /// </summary>
    public partial class Insert : Window
    {
        wpfCrudEntities _db = new wpfCrudEntities();

        public Insert()
        {
            InitializeComponent();
        }

        private void insertBtn_Click(object sender, RoutedEventArgs e)
        {
            member newMember = new member()
            {
                name = nametextBox.Text,
                gender = gendercomboBox.Text
            };

            _db.members.Add(newMember);
            _db.SaveChanges();
            MainWindow.datagrid.ItemsSource = _db.members.ToList();
            this.Hide();
        }

    }
}
