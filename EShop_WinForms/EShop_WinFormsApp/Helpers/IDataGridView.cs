using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAS_WinFormsApp.Helpers
{
    public interface IDataGridView
    {
        void InitDataGridView(DataGridView view, BindingSource source);
        void EnumerateRows(DataGridView view, string keyRowName);
        public void RefreshDataGridView();
    }
}
