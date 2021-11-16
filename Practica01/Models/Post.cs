using System;

namespace Practica01
{
    public class Post
    {
        public string Title { get; set; }
        public DateTime? DatePost { get; set; }
        public string Content { get; set; }
        public Usuario UsuarioPost { get; set; }
    }
}