﻿using Android.Content;
using Android.Views;
using Android.Widget;
using System.Collections;
using System.Collections.Generic;

namespace DuurHooiClicker
{
    public class ImageAdapter : BaseAdapter
    {
        Context context;

        public ImageAdapter(Context c)
        {
            context = c;
        }
        //lengte moet ff gefixt worden
        public override int Count
        {
            get { return 2; }
        }

        public override Java.Lang.Object GetItem(int position)
        {
            return null;
        }

        public override long GetItemId(int position)
        {
            return 0;
        }

        // create a new ImageView for each item referenced by the Adapter
        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            ImageView imageView;

            if (convertView == null)
            {  // if it's not recycled, initialize some attributes
                imageView = new ImageView(context);
                imageView.LayoutParameters = new GridView.LayoutParams(350, 350);
                imageView.SetScaleType(ImageView.ScaleType.CenterCrop);
                imageView.SetPadding(8, 8, 8, 8);
            }
            else
            {
                imageView = (ImageView)convertView;
            }

            CheckAchievement();


            imageView.SetImageResource(thumbIds2[position]);

            return imageView;
        }

        //image list
        List<int> thumbIds2 = new List<int>();

        public void CheckAchievement()
        {
            //miljoen hooi
            int hay = Game.Hay;
            if(hay >= 1000000)
            {
                thumbIds2.Add(Resource.Drawable.achievement_miljoenhooi_enabled);
            }
            if(hay <= 1000000)
            {
                thumbIds2.Add(Resource.Drawable.achievement_miljoenhooi_disabled);
            }

            //miljard hooi
            if(hay >= 1000000000)
            {
                thumbIds2.Add(Resource.Drawable.achievement_miljardhooi_enabled);
            }
            if(hay <= 1000000000)
            {
                thumbIds2.Add(Resource.Drawable.achievement_miljardhooi_disabled);
            }

        }
    }
}