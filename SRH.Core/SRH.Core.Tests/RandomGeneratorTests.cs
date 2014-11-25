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
            RandomGenerator r = new RandomGenerator( new Random() );

            Assert.NotNull( r );
        }

        [Test]
        public void Create_a_random_Person()
        {
            RandomGenerator r = new RandomGenerator( new Random() );
            LaborMarket lb = new LaborMarket( myGame );
            
            Person p = r.GetRandomPerson( lb, 18, 60 );

            Assert.NotNull( p );
        }
    }
}
