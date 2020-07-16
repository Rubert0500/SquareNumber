using NUnit.Framework;
using System;
using Practica_Final_Tendencia;

namespace Practica_Final_Tendencia
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
            //Test positivo
        [Test]
        public void Validate_input_4_is_correct()
        {
                        
           Assert.AreEqual(2, Program.Square(4));
        }

          [Test]
        public void Validate_input_49_is_correct()
        {
            
           Assert.AreEqual(7, Program.Square(49));
        }
          [Test]
        public void Validate_input_144_is_correct()
        {
            
           Assert.AreEqual(12, Program.Square(144));
        }
          [Test]
        public void Validate_input_68_is_correct()
        {
           
           Assert.AreEqual(8, Program.Square(64));
        }

        //Test negativo


        [Test]
        public void Validate_input_4_has_Square(){
                        
           Assert.AreNotEqual(3, Program.Square(4));
        }

          [Test]
        public void Validate_input_49_has_Square()
        {
            
           Assert.AreNotEqual(8, Program.Square(49));
        }
          [Test]
        public void Validate_input_144_has_Square()
        {
            
           Assert.AreNotEqual(2, Program.Square(144));
        }
          [Test]
        public void Validate_input_64_has_Square()
        {
           
           Assert.AreNotEqual(9, Program.Square(64));
        }
    }
}