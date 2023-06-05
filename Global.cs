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
using AlbumOnlineApp.com.somee.albumonline2023;

namespace AlbumOnlineApp
{
    class Global
    {
        //Instanciar el servicio web
        public static AlbumSW Servicio = new AlbumSW();
        public static string Usuario;

        //Definir los metodos de acceso locales
        //1. Registro de usuario
        public static bool RegistroUsuario( string Email, string Pass)
        {
            return Servicio.addAspNetUser(Email, Pass);
        }
        //2. Logueo de usuario
        public static bool IniciarSesion(string Email, string Pass)
        {
            return Servicio.AspUserLogin(Email, Pass);
        }
        //3. Agregar Foto
        public static bool AgregarFoto(byte[] Img, int Tipo, string User)
        {
            return Servicio.AddImg(Img, Tipo, User);
        }
        //4. Listar las fotos
        public static List<SWPhoto> ListarFotos(string User)
        {
            return Servicio.get_photos(User).ToList();
        }
    }
}