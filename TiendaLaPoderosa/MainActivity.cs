using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using Android.Content;

namespace TiendaLaPoderosa
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        Button btnInicio, btnMision, btnHistoria, btnCategorias, btnMarcas, btnSucursales, btnRecetas;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            btnInicio = FindViewById<Button>(Resource.Id.btnInicio);
            btnMision = FindViewById<Button>(Resource.Id.btnMision);
            btnHistoria = FindViewById<Button>(Resource.Id.btnHistoria);
            btnCategorias = FindViewById<Button>(Resource.Id.btnCategorias);
            btnMarcas = FindViewById<Button>(Resource.Id.btnMarcas);
            btnSucursales = FindViewById<Button>(Resource.Id.btnSucursales);
            btnRecetas = FindViewById<Button>(Resource.Id.btnRecetas);
        }

        private void Btninicio_Click(object sender, System.EventArgs e)
        {
            Intent i = new Intent(this, typeof(inicioActivity));
            StartActivity(i);
        }

        private void Btnmision_Click(object sender, System.EventArgs e)
        {
            Intent i = new Intent(this, typeof(misionActivity));
            StartActivity(i);
        }

        private void Btnhistoria_Click(object sender, System.EventArgs e)
        {
            Intent i = new Intent(this, typeof(historiaActivity));
            StartActivity(i);
        }

        private void Btncategorias_Click(object sender, System.EventArgs e)
        {
            Intent i = new Intent(this, typeof(categoriasActivity));
            StartActivity(i);
        }

        private void Btnsucursales_Click(object sender, System.EventArgs e)
        {
            Intent i = new Intent(this, typeof(sucursalasActivity));
            StartActivity(i);
        }

        private void Btnrecetas_Click(object sender, System.EventArgs e)
        {
            Intent i = new Intent(this, typeof(recetasActivity));
            StartActivity(i);
        }

        private void Btnmarcas_Click(object sender, System.EventArgs e)
        {
            Intent i = new Intent(this, typeof(marcasActivity));
            StartActivity(i);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}