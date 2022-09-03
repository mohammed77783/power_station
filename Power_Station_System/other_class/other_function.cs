using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Power_Station_System.other_class
{
    class other_function
    {
        public static DataTable gridview_to_datatabel(DataGridView gv)
        {
            DataTable tb = new DataTable();
            foreach (DataGridViewColumn col in gv.Columns)
            {
             //  if(col.Name!="checkedBOX")
                tb.Columns.Add(col.Name);
            }
            foreach(DataGridViewRow row in gv.Rows)
            {
                if (Convert.ToInt32(row.Cells["checkedBOX"].Value )!= 0) {
                    DataRow dRow = tb.NewRow();
                    foreach (DataGridViewCell cell in row.Cells)
                {
                  
                    dRow[cell.ColumnIndex] = cell.Value;
                }
                tb.Rows.Add(dRow);
                }
            }
            return tb;
        }
    }
}
