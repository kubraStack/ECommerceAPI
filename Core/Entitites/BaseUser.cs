using Core.DataAccess;
using Core.Utilities.Encryption;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entitites
{
    public  class BaseUser : Entity
    {
        public string Email { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        //Veri güvenliği için Firstname ve Lastname şifrelendi
        private string? _firstName;
        public string? FirstName
        {
            get => _firstName != null ? EncryptionHelper.DecryptString(_firstName) : null;
            set => _firstName = value != null ? EncryptionHelper.EncryptString(value): null ;
        }

        private string? _lastName;
        public string? LastName
        {
            get => _lastName != null ? EncryptionHelper.DecryptString(_lastName) : null;
            set => _lastName = value != null ? EncryptionHelper.EncryptString(value) : null ;
        }

        public UserType UserType { get; set; }
    }

    public enum UserType
    {
        Customer = 2,
        Admin = 1,
        Guest = 3
    }
}
