using System;
namespace CharacterSuperMario64
{
    class Program
    {
        static void Main(string[] args)
        {
            Character character = new Character();
            character.Move();
            character.ShowDetails();
            Mario mario = new Mario();
            mario.Move();
            mario.CollectMoneys();
            mario.Jump();
            mario.Swim();
            mario.ShowDetails();
            Bowser bowser = new Bowser();
            bowser.Move();
            bowser.DobleJump();
            bowser.ShootFire();
            bowser.ShowDetails();
            MamaPinguino mp = new MamaPinguino();
            mp.Move();
            mp.ShowDetails();
        }
    }
}
