using Shop.Domain;
using System;
using System.Collections.Generic;

namespace Shop.DataAccess.Abstract
{
	public interface IUserRepository
	{
		void Add(User user);
		void Delete(string userId);
		void Update(User user);
		ICollection<User> GetAll();
	}
}
