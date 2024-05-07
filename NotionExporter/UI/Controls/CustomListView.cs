using System.ComponentModel;

namespace NotionExporter.UI.Controls
{
    internal class CustomListView : ListView
    {
        public class HeaderRightClickEventArgs : EventArgs
        {
            public HeaderRightClickEventArgs(int x, int y, int columnIndex)
            {
                X = x;
                Y = y;
                ColumnIndex = columnIndex;
            }

            public int X { get; }

            public int Y { get; }

            public int ColumnIndex { get; }

            public Point Location => new Point(X, Y);
        }

        public delegate void HeaderRightClickEventHandler(object? sender, HeaderRightClickEventArgs e);

        private HeaderRightClickEventHandler onColumnHeaderRightClick;

        const long WM_NCDESTROY = 0x82;
        const long WM_PARENTNOTIFY = 0x210;
        const long WM_RBUTTONDOWN = 0x204;

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_PARENTNOTIFY && m.WParam.ToInt64() == WM_RBUTTONDOWN)
            {
                var x = m.LParam.ToInt64() & 0xffff;
                var y = m.LParam.ToInt64() >> 16 & 0xffff;

                var columnX = x;
                var columnIndex = -1;
                for (var i = 0; i < Columns.Count; i++)
                {

                    columnX = columnX - Columns[i].Width;
                    if (columnX <= 0)
                    {
                        columnIndex = i;
                        break;
                    }
                }

                OnColumnHeaderRightClick(new HeaderRightClickEventArgs((int)x, (int)y, columnIndex));
            }

            base.WndProc(ref m);
        }

        [Category("Action")]
        public event HeaderRightClickEventHandler ColumnHeaderRightClick
        {
            add
            {
                onColumnHeaderRightClick += value;
            }
            remove
            {
                onColumnHeaderRightClick -= value;
            }
        }

        protected virtual void OnColumnHeaderRightClick(HeaderRightClickEventArgs e)
        {
            onColumnHeaderRightClick?.Invoke(this, e);
        }
    }

}
