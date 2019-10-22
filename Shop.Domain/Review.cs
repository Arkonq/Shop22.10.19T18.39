using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Domain
{
	public class Review : Entity		
	{
		public Guid UserId { get; set; }
		public Guid ItemId { get; set; }
		public int Rate { get; set; }
		public string Value { get; set; }
	}
}
