namespace ChallengeApp1
{
    public class User
    {
        private List<int> score = new List<int>(); //LISTA Z WYNIKAMI
                
        //KONSTRUKTOR
        public User(string login, string password)
        {
            this.Login = login;
            this.Password = password;
        }
        //POLA
        public string Login { get; private set; }
        public string Password { get; private set; }
        public int Result
        {
            get
            {
                return this.score.Sum(); //LOGIKA DO SUMOWANIA RESULT
            }
        }
        //METODA
        public void AddScore(int number)
        {
            this.score.Add(number);
        }
    }
}
