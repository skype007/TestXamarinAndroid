using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace MonAppDemo.CustomAdapters
{

    public class MyAdapter : BaseAdapter<string>
    {
        List<string> _items;
        Activity _context;

        public MyAdapter()
        {
        }

        public MyAdapter(Activity context, List<string> items)
        {
            this._context = context;
            this._items = items;
        }

        public override string this[int position]
        {
            get { return _items[position]; }
        }

        public override int Count
        {
            get { return _items.Count; }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = _items[position];
            TextView title;
            TextView detail;

            View view = convertView;
            if (view == null) // no view to re-use, create new
                view = _context.LayoutInflater.Inflate(Android.Resource.Layout.SimpleListItem2, null);
            // then update some cells here
            title = view.FindViewById<TextView>(Android.Resource.Id.Text1);
            title.Text = item;

            detail = view.FindViewById<TextView>(Android.Resource.Id.Text2);
            detail.Text = "Detail";

            return view;
        }
    }
}