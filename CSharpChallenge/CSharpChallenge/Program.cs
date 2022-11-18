using System.ComponentModel.DataAnnotations;
using CSharpChallenge;

User u = new User(username: "alienne4", password: "1234", email: "alicecania@gmail.com");

Console.WriteLine(u.GetMail());
u.ChangePassword("4321");
Console.WriteLine(u.ToString());

