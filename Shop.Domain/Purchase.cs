using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Domain
{
	public class Purchase : Entity
	{
		public Guid ItemId { get; set; }
		public Guid UserId { get; set; }
	}
}
