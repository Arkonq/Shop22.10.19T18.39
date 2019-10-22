using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Logistic
{
	public class Registration
	{
		string phoneNum, email, address, password, verCode;
		Console.WriteLine("Введите номер телефона: ");
			phoneNum = Console.ReadLine();
			Console.WriteLine("Введите почту: ");
			email = Console.ReadLine();
			Console.WriteLine("Введите адрес: ");
			address = Console.ReadLine();
			Console.WriteLine("Введите пароль: ");
			password = Console.ReadLine();
			Console.WriteLine("Введите секретный код (???): ");
			verCode = Console.ReadLine();

			User user = new User
			{
				PhoneNumber = phoneNum,
				Email = email,
				Address = address,
				Password = password,
				VerificationCode = verCode
			};
		IUserRepository repository = new UserRepository(connectionString, providerName);
			using (var name = new WholeRepository(providerName, connectionString))
			{
				repository.Add(user);
				var res = repository.GetAll();
}
	}
}