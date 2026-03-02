using System;

public class Product
{
	public class Product()
	{
		public int Id { get; set; }

		[Required]
		[MaxLength(100)]
		public string Name { get; set; }

		[Range(1, 100000)]
		public decimal Price { get; set; }

		[MaxLength(500)]
		public string Description { get; set; }
	}
}
