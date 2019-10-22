using System;
using Shop.Services.Abstract;
using BCrypt.Net;
using static BCrypt.Net.BCrypt;

namespace Shop.Services
{
	public class BcryptHasher : ICryptoService
	{
		public string EncryptPassword(string password)
		{
			return HashPassword(password);
		}

		public bool VerifyPassword(string password, string passwordCandidate)
		{
			return Verify(passwordCandidate, password);
		}
	}
}
