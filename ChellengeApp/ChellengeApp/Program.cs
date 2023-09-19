using ChellengeApp;

User user1 = new User("Adam", "234324jkhnk");
User user2 = new User("Michał", "234324jkhnk");
User user3 = new User("Paweł", "234324jkhnk");


user1.AddScore(7);
user1.SubScore(6);
user1.AddScore(4);

user2.AddScore(5);
user2.AddScore(5);
user2.AddScore(5);

user3.AddScore(5);
user3.AddScore(5);
user3.AddScore(5);

Console.WriteLine(user1.Result);
