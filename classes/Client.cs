namespace gestion_hotelier.classes
{
    public class Client
    {
        public int id { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string adress { get; set; }
        public int tel { get; set; }

        public string pays { get; set; }

        public string code_postal { get; set; }

        public string email { get; set; }
    }
}