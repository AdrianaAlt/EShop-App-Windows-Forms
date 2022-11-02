using MAS_WinFormsApp.Forms;
using MAS_WinFormsApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MAS_WinFormsApp.Helpers
{
    public class FormsController
    {
        private static Stack<Form> _forms = new Stack<Form>();

        public static void RunApplicationGUI(EShopDBRepository _database)
        {
            Login loginWindow = new Login(_database);
            loginWindow.StartPosition = FormStartPosition.CenterScreen;
            _forms.Push(loginWindow);
            _forms.Peek().Show();
            Application.Run();
        }

        private static void InitWindowLocation(Form window, Form sourceWindow)
        {
            window.Location = sourceWindow.Location;
            window.StartPosition = FormStartPosition.Manual;
        }
        public static void SwitchWindowForm(Form newWindowForm)
        {
            InitWindowLocation(newWindowForm, _forms.Peek());
            Form prevForm = _forms.Peek();
            _forms.Push(newWindowForm);
            newWindowForm.Show();
            prevForm.Hide();
        }
        public static void SwitchWindowFormWithClose(Form newWindowForm)
        {
            InitWindowLocation(newWindowForm, _forms.Peek());
            Form prevForm = _forms.Peek();
            _forms.Pop();
            _forms.Push(newWindowForm);
            newWindowForm.Show();
            prevForm.Close();
        }

        public static void CloseWindow(Form windowToClose)
        {
            if (windowToClose != _forms.Peek()) throw new Exception("[Error]: Window can not be closed");
            var poppedWindow = _forms.Pop();

            if (_forms.Count == 0)
            {
                Application.Exit();
            }
            else
            {
                InitWindowLocation(_forms.Peek(), poppedWindow);
                _forms.Peek().Refresh();
                _forms.Peek().Show();
            }
        }

        public static void ReturnToMenu()
        {
            while(_forms.Count > 1)
            {
                var topForm = _forms.Pop();
                topForm.Close();
            }
            _forms.Peek().Refresh();
            _forms.Peek().Show();
        }

    }
}
