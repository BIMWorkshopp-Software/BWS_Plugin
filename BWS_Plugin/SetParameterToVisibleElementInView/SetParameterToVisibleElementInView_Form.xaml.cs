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

namespace BWS_Plugin.SetParameterToVisibleElementInView
{
    /// <summary>
    /// Логика взаимодействия для SetParameterToVisibleElementInView_Form.xaml
    /// </summary>
    public partial class SetParameterToVisibleElementInView_Form : Window
    {
        static Helpers _help;
        public SetParameterToVisibleElementInView_Form()
        {
            _help = new Helpers();
            InitializeComponent();
            tbParameterName.Text = _help.SetingsLineValue(0);
            tbParameterValue.Text = _help.SetingsLineValue(1);
        }

        private void runButton_Click(object sender, RoutedEventArgs e)
        {
            SetParameterToVisibleElementInView_Code code = new SetParameterToVisibleElementInView_Code();
            string oldParameterNameValue = _help.SetingsLineValue(0);
            string oldParameterValue = _help.SetingsLineValue(1);

            _help.ReplaceSetingsLineValue(oldParameterNameValue, tbParameterName.Text);
            _help.ReplaceSetingsLineValue(oldParameterValue, tbParameterValue.Text);

            code.setParameter(tbParameterName.Text,tbParameterValue.Text);
            Close();
            code.task();
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
