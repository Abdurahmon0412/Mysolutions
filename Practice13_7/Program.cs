//Queue
#region QUEUE
var user1 = new User("John", "Doe",30);
var user2 = new User("Emily", "Smith", 25);
var user3 = new User("Michael", "Johnson", 35);
var user4 = new User("Sarah", "Williams", 28);
var user5 = new User("David", "Brown", 32);

List<User> UsersList = new List<User>();
Queue<User> UsersQueue = new Queue<User>();
UsersList.Add(user1);
UsersList.Add(user2);
UsersList.Add(user3);
UsersList.Add(user4);
UsersList.Add(user5);

UsersQueue.Enqueue(user1);
UsersQueue.Enqueue(user2);
UsersQueue.Enqueue(user3);
UsersQueue.Enqueue(user4);
UsersQueue.Enqueue(user5);

for(int i = 0; i < 5; i++)
{
    Console.WriteLine(UsersList[i]);
    Console.WriteLine(UsersQueue.Dequeue());

}

public class User
{
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public int Age { get; set; }

    public User(string firstname, string lastname, int age)
    {
        Firstname = firstname; Lastname = lastname; Age = age;
    }
    public override string ToString()
    {
        return $"{Firstname} {Lastname}, {Age}";
    }
}
#endregion