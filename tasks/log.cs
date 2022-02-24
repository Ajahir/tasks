using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tasks
{
    [Activity(Label = "log")]
    public class log : Activity
    {
        private Button login;
        private ImageView fb,ig;
        private TextView user,pass,forgot;
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.login);
            // Create your application here
            login = FindViewById<Button>(Resource.Id.button1);
            fb = FindViewById<ImageView>(Resource.Id.imageView1); 
            ig = FindViewById<ImageView>(Resource.Id.imageView2);
            forgot = FindViewById<TextView>(Resource.Id.forgot);
            user = FindViewById<EditText>(Resource.Id.editText3);
            pass=FindViewById<EditText>(Resource.Id.editText4);
            forgot.Click += Forgot_Click;
            fb.Click += Fb_Click;
            ig.Click += Ig_Click;
            login.Click += Login_Click;
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(user.Text) && string.IsNullOrEmpty(pass.Text))
            {
                Toast.MakeText(this, "enter full data", ToastLength.Short).Show();
            }
            else
            {
                Toast.MakeText(this, "login  successfully", ToastLength.Short).Show();
            }
        }

        private void Ig_Click(object sender, EventArgs e)
        {
            Toast.MakeText(this, "google sign in ", ToastLength.Short).Show();
        }

        private void Fb_Click(object sender, EventArgs e)
        {
            Toast.MakeText(this, "facebook sign in ", ToastLength.Short).Show();
        }

        private void Forgot_Click(object sender, EventArgs e)
        {
            Toast.MakeText(this,"OTP send this number ",ToastLength.Short).Show();
        }
    }
}