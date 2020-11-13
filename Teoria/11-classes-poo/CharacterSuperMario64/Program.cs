using System;
namespace CharacterSuperMario64
{
    class Program
    {
        static void Main(string[] args)
        {
            Character character = new Character();
            character.Name = "Personaje general";
            character.Hero = true;
            character.Alias = "hahakak";
            character.Move();
            character.ShowDetails();
            Mario mario = new Mario();
            mario.Name = "Mario";
            mario.Hero = true;
            mario.Move();
            mario.ShowDetails();
            mario.CollectMoneys();
            mario.Jump();
            mario.Swim();
            Bowser bowser = new Bowser();
            bowser.Name = "Bowser";
            bowser.Hero = false;
            bowser.Height = 4.5f;
            bowser.Move();
            bowser.ShowDetails();
            bowser.DobleJump();
            bowser.ShootFire();
            MamaPinguino mp = new MamaPinguino();
            mp.Name = "Mama Pinguino";
            mp.ShowDetails();
            mp.Move();
        }
    }
}
