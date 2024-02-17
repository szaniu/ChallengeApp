using ChallengeApp;

User user1 = new User("Darek", "ldsoihw67asnd");
User user2 = new User("Stefan", "ldsoihw67asnd");
User user3 = new User("Bartek", "ldsoihw67asnd");

User1.AddScore(5)
User1.AddScore(2)
User1.AddScore(1)

User2.AddScore(2)
User2.AddScore(5)
User2.AddScore(9)

User3.AddScore(11)
User3.AddScore(1)
User3.AddScore(1)

class User //KLASA
{
    private List<int> score = new List<int>(); //LISTA Z WYNIKAMI
    //KONSTRUKTOR
    public User(string name, string password)
    {
        this.Login = login;
        this.Password = password;
    }
    //POLA
    public string Login { get; private set; }
    public string Password { get; private set; }
    public int Score
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