namespace GameDB
{
    public class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Mana { get; set; }
        public int Stamina { get; set; }
        public CharacterClass CharacterClass { get; set; }
        public short Reputation { get; set; }
        public Quest[] Quests { get; set; }
        public Stats Stats { get; set; }
        public Effect[] Effects { get; set; }
        public Item[] Inventory { get; set; }
    }
}