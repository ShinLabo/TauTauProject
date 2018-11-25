using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace TauTau.Models
{
    public class Login
    {
        [DisplayName("ログインID")]
        public string Id { get; set; }

        [DisplayName("パスワード")]
        public string Password { get; set; }

        [DisplayName("パスワード確認")]
        public string Password_Second { get; set; }

        [DisplayName("メールアドレス")]
        public string EMail { get; set; }
    }
}