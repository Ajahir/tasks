using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;

namespace tasks
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private Button reg;
        private ImageView fb, ig;
        private EditText name, email, user, pass;
        private TextView log;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            reg = FindViewById<Button>(Resource.Id.button1);
            fb = FindViewById<ImageView>(Resource.Id.imageView1);
            ig = FindViewById<ImageView>(Resource.Id.imageView2);
            name = FindViewById<EditText>(Resource.Id.editText1);
            email = FindViewById<EditText>(Resource.Id.editText2);
            user = FindViewById<EditText>(Resource.Id.editText3);
            pass = FindViewById<EditText>(Resource.Id.editText4);
            log = FindViewById<TextView>(Resource.Id.textView1);
            reg.Click += Reg_Click;
            fb.Click += Fb_Click;
            ig.Click += Ig_Click;
            log.Click += Log_Click;
            
        }

        private void Log_Click(object sender, System.EventArgs e)
        {
            StartActivity(typeof(log));
        }

        private void Ig_Click(object sender, System.EventArgs e)
        {
            Toast.MakeText(this, "google sign in ", ToastLength.Short).Show();
        }

        private void Fb_Click(object sender, System.EventArgs e)
        {
            Toast.MakeText(this, "facebook sign in ", ToastLength.Short).Show();
        }

        private void Reg_Click(object sender, System.EventArgs e)
        {
           
           if (string.IsNullOrEmpty(name.Text) || string.IsNullOrEmpty(email.Text) || string.IsNullOrEmpty(user.Text) || string.IsNullOrEmpty(pass.Text))
                {
                
                
                    Toast.MakeText(this, "enter full data", ToastLength.Short).Show();
                
                
            }
          
           else
            {
                Toast.MakeText(this, "register successfully", ToastLength.Short).Show();
            }
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}