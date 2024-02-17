namespace ChallengeApp1.Tests
{
    public class UserTests
    {
        [Test]
        public void WhenUserCollectTwoSetOfPoint_ShouldReturnCorrectSumAsResult()
        {
            // arrange - przygotowanie
            var user = new User("Darek", "ldsoihw67asnd");
            user.AddScore(5);
            user.AddScore(6);

            // act - uruchomienie
            var result = user.Result;

            // assert - sprawdzenie czy zosta³y spe³nione pewne wrunki
            Assert.AreEqual(11, result);

        }

    }
}