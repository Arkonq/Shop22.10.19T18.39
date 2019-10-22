using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Domain
{
	public abstract class Entity
	{
		public Guid Id { get; set; } = Guid.NewGuid();
		public DateTime CreationDate { get; set; } = DateTime.Now;
		public DateTime? DeletedDate { get; set; }

	}
}
