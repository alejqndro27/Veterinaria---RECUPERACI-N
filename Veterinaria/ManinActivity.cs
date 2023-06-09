﻿/*using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Veterinaria
{
    [Activity(Label = "ManinActivity")]
    public class ManinActivity : Activity
    {
        public static string IdAdm;
        public static string PasswordAdm;
        string Rol;
        EditText txtIdentificacion;
        EditText txtPassword;
        Button btnIngresar;
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            txtIdentificacion = FindViewById<EditText>(Resource.Id.txtIdentificacion);
            txtPassword = FindViewById<EditText>(Resource.Id.txtPassword);
            btnIngresar = FindViewById<Button>(Resource.Id.btnIngresar);
            

            btnIngresar.Click += BtnIngresar_Click;
            
        }

        private void BtnIngresar_Click(object sender, System.EventArgs e)
        {
            try
            {
                IdAdm = "2023";
                PasswordAdm = "12345";
                Rol = "Administrador";
                Bienvenido bvb =  new Bienvenido(); 
                if (txtIdentificacion.Text.Trim().Equals(IdAdm) && txtPassword.Text.Trim().Equals(PasswordAdm))
                {
                    Toast.MakeText(this, "Login realizado con exito", ToastLength.Short).Show();
                    var bienvenido = new Intent(this, typeof(Bienvenido));
                    bvb.Rol = Rol;
                    bienvenido.PutExtra("usuario", FindViewById<EditText>(Resource.Id.txtIdentificacion).Text);
                    StartActivity(bienvenido);
                    Finish();
                }
                else
                {
                    Login resultado = null;
                    
                    if (!string.IsNullOrEmpty(txtIdentificacion.Text.Trim()) && !string.IsNullOrEmpty(txtPassword.Text.Trim()))
                    {
                        resultado = new Conectar().SelecionarUno(txtIdentificacion.Text.Trim(), txtPassword.Text.Trim());
                        if (resultado != null)
                        {
                            Rol = resultado.Rol.ToString();
                            txtIdentificacion.Text = resultado.Usuario.ToString();
                            Toast.MakeText(this, "Login realizado con exito", ToastLength.Short).Show();
                            var bienvenido = new Intent(this, typeof(Bienvenido));
                            bvb.Rol = Rol;
                            bienvenido.PutExtra("usuario", FindViewById<EditText>(Resource.Id.txtIdentificacion).Text);
                            StartActivity(bienvenido);
                            Finish();
                        }
                        else
                        {
                            Toast.MakeText(this, "Nombre de usuario y/o clave inválida(s)", ToastLength.Long).Show();
                        }
                    }
                    else
                    {
                        Toast.MakeText(this, "Nombre de usuario y/o clave son vacios", ToastLength.Long).Show();
                    }

                }
                

            }
            catch
            {

            }
        }
    }
}*/