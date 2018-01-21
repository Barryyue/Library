﻿using System;
using System.Collections.Generic;

namespace Library.UI.DTOs
{
	public class ImportBookInventoryDTO
	{
		public ImportBookInventoryDTO()
		{
			BookInventoryIds = new List<Guid>();
		}

		public List<Guid> BookInventoryIds { get; set; }
	}
}