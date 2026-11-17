using System;

namespace ECampus.Classes.Commune
{
 
    public class Utilisateur
    {

        public int Id { get; set; }
        public string Mail { get; set; } = string.Empty;
        public string PasswordHash { get; private set; } = string.Empty;

        public string Nom { get; set; } = string.Empty;
        public string Prenom { get; set; } = string.Empty;

        public RoleUtilisateur Role { get; set; }
        public DateTime? LastLogin { get; set; }

        public bool IsValidated { get; set; } = false;
        protected Utilisateur() { }

        public Utilisateur(string mail, string passwordHash, string nom, string prenom, RoleUtilisateur role)
        {
            Mail = mail;
            PasswordHash = passwordHash;
            Nom = nom;
            Prenom = prenom;
            Role = role;
        }

        public void ChangePassword(string newPasswordHash)
        {
            if (string.IsNullOrWhiteSpace(newPasswordHash))
                throw new ArgumentException("Le hash du mot de passe ne peut pas être vide.", nameof(newPasswordHash));

            PasswordHash = newPasswordHash;
        }
    }
}