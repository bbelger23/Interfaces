namespace Interfaces.Models
{
    public interface IMonster
    {
        public string Name {get;set;}

        void Roar();
        void Stomp();
    }
}