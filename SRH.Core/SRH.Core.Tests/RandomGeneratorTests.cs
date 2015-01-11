using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SRH.Core.Tests
{
    [TestFixture]
    class RandomGeneratorTests
    {
        Game myGame = new Game( 1, "Dannone" );


        [Test]
        public void Create_RandomGenerator()
        {
            RandomGenerator r = new RandomGenerator(myGame, new Random() );

            Assert.NotNull( r );
        }

        [Test]
        public void Create_a_random_Person()
        {
            RandomGenerator r = new RandomGenerator(myGame, new Random() );
            LaborMarket lb = new LaborMarket( myGame );
            
            Person p = r.GetRandomPerson( lb, 18, 60 );

            Assert.NotNull( p );
        }

		// TEMPORARY TEST
		[Test]
		public void get_a_random_skill()
		{
			RandomGenerator r = new RandomGenerator( myGame, new Random() );

			string s = r.GetRandomSkillName();
			string s1 = r.GetRandomSkillName();
			string s2 = r.GetRandomSkillName();
			string s3 = r.GetRandomSkillName();
			string s4 = r.GetRandomSkillName();
			string s5 = r.GetRandomSkillName();
			string s6 = r.GetRandomSkillName();
			string s7 = r.GetRandomSkillName();
			string s8 = r.GetRandomSkillName();
			string s9 = r.GetRandomSkillName();

			Console.WriteLine( s );
			Console.WriteLine( s1 );
			Console.WriteLine( s2 );
			Console.WriteLine( s3 );
			Console.WriteLine( s4 );
			Console.WriteLine( s5 );
			Console.WriteLine( s6 );
			Console.WriteLine( s7 );
			Console.WriteLine( s8 );
			Console.WriteLine( s9 );

			Assert.NotNull( s );
		}

		// TEMPORARY TEST
		[Test]
		public void get_random_points()
		{
			RandomGenerator r = new RandomGenerator( myGame, new Random() );

			int p = r.GetRandomPoints();
			int p1 = r.GetRandomPoints();
			int p2 = r.GetRandomPoints();
			int p3 = r.GetRandomPoints();
			int p4 = r.GetRandomPoints();
			int p5 = r.GetRandomPoints();
			int p6 = r.GetRandomPoints();
			int p7 = r.GetRandomPoints();
			int p8 = r.GetRandomPoints();
			int p9 = r.GetRandomPoints();

			Console.WriteLine( p );
			Console.WriteLine( p1 );
			Console.WriteLine( p2 );
			Console.WriteLine( p3 );
			Console.WriteLine( p4 );
			Console.WriteLine( p5 );
			Console.WriteLine( p6 );
			Console.WriteLine( p7 );
			Console.WriteLine( p8 );
			Console.WriteLine( p9 );

			Assert.NotNull( p );
		}
    }
}
