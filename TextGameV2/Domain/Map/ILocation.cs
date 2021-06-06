using TextGameV2.Domain.Characters;

namespace TextGameV2.Domain.Map
{
    public interface ILocation
    {
        int Id { get; set; }
        string Name { get; set; }
        bool RequireHard { get; set; }
        bool CanYouMine { get; set; }
        bool CanLoot { get; set; }

        void EnterHero(Hero hero);

        void LeavingHero();
    }
}