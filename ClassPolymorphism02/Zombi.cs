using System;

namespace Monster
{
	internal class Zombi : Monster
	{
		private int _poisonAttackRegist;


		public void GetDamage(int attack)
		{
			int damage = attack - (_defense + _poisonAttackRegist);

			if (damage > 0) { damage = 0; }

			_health -= damage;
		}

		public Zombi(string name, int health, int defense, int attack)
			: base(name, health, defense, attack) { }
	}
}
