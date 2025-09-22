using System;

namespace Monster
{
	internal class Slime : Monster
	{
		private int _physicalDefense;   // 물리 방어력

		public int PhysicalDefense
		{
			get => _physicalDefense;
		}

		public Slime(string name, int health, int defense, int attack, int physicalDefense)
			: base(name, health, defense, attack)
		{
			_physicalDefense = physicalDefense;
		}

		public new void Info()
		{
			base.Info();
			Console.WriteLine($"물리방어력: {_physicalDefense}");
		}


	}
}
