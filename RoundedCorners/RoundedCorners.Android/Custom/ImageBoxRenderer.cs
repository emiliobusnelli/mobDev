using System;
using Xamarin.Forms;
using RoundedCorners;
using RoundedCorners.Droid;
using Xamarin.Forms.Platform.Android;
using RoundedCorners.Custom;
using RoundedCorners.Droid.Custom;
using Android.Graphics;

#pragma warning disable CS0612 // Type or member is obsolete
[assembly: ExportRenderer(typeof(ImageBox), typeof(ImageBoxRenderer))]
#pragma warning restore CS0612 // Type or member is obsolete

namespace RoundedCorners.Droid.Custom
{
    [Obsolete]
    public class ImageBoxRenderer : ImageRenderer
    {
        protected override bool DrawChild(Canvas canvas, Android.Views.View child, long drawingTime)
        {

            try
            {
                //Clip Path
                var radius = 25.0f;
                var path = new Path();
                RectF rect = new RectF(0, 0, Width, Height);
                path.AddRoundRect(rect, radius, radius, Path.Direction.Cw);
                canvas.Save();
                canvas.ClipPath(path);
                var result = base.DrawChild(canvas, child, drawingTime);
                canvas.Restore();

                // Create Border
                path = new Path();
                path.AddRoundRect(rect, radius, radius, Path.Direction.Cw);
                var paint = new Paint();
                paint.AntiAlias = true;
                paint.StrokeWidth = 1;
                paint.SetStyle(Paint.Style.Stroke);
                paint.Color = global::Android.Graphics.Color.Rgb(11, 11, 14);
                canvas.DrawPath(path, paint);

                //Clean Up
                paint.Dispose();
                path.Dispose();

                return result;

            }
            catch
            {
                return base.DrawChild(canvas, child, drawingTime);
            }

            
        }
    }
}
