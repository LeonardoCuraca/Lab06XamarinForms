using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Lab06
{
	public class SuperHeroModel : ObservableCollection<SuperHeroModel>
	{
		public string Name { get; set; }
		public string AlterEgo { get; set; }
		public SuperHeroModel()
		{
		}
	}

	public class GroupedSuperHeroModel : ObservableCollection<SuperHeroModel>
	{
		public string Comic { get; set; }
	}
}